using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSE_Project
{
    class ProcurementDeliveryStatus
    {
        private int orderId;
        private String refno_search;
        private float requested_amount;
        private float suplier_sent_amount;
        private float recieved_amount;
        private float remaining_qty;
        private float complain_qty;
        private String delivery_status;
        public String messege;
        //PML_PODeliveryStatus pmlPODeliveryStatus = new PML_PODeliveryStatus();
        public DataGridView proc_testGrid = new DataGridView();
        MySqlConnection mysqlcon = DBConnection.getConnection();


        //ctrl+r then ctrl+e for generate gettersand setters
        public int OrderId { get => orderId; set => orderId = value; }
        public string Refno_search { get => refno_search; set => refno_search = value; }
        public float Requested_amount { get => requested_amount; set => requested_amount = value; }
        public float Suplier_sent_amount { get => suplier_sent_amount; set => suplier_sent_amount = value; }
        public float Recieved_amount { get => recieved_amount; set => recieved_amount = value; }
        public float Remaining_qty { get => remaining_qty; set => remaining_qty = value; }
        public float Complain_qty { get => complain_qty; set => complain_qty = value; }
        public string Delivery_status { get => delivery_status; set => delivery_status = value; }

        public ProcurementDeliveryStatus()
        {

        }

        public DataTable FillGridByRef(String refno_search) //overloadin example
        {
            DataTable table = new DataTable();

            try
            {
                MessageBox.Show("Inside grid");
                DBConnection.openDBConnection();


                //MySqlCommand command = new MySqlCommand("SELECT * FROM purchase_order WHERE RefNo = '" + refno_search + "' ", mysqlcon);
                MySqlCommand command = new MySqlCommand("SELECT * FROM purchase_order WHERE  OrderID != 'Null' AND Price != 0 AND RefNo != 'Null' AND Material != 'Null' AND Description != 'Null' AND Supplier != 'Null'AND Quantity != 0 AND Site != 'Null' AND RefNo = '" + refno_search + "' ", mysqlcon);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("?refno_search", refno_search);

                MySqlDataAdapter adapter = new MySqlDataAdapter();


                adapter.SelectCommand = command;
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Onsearching Records", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
            return table;
        }

        public DataTable FillGridByRef() //overloading example
        {
            DataTable table = new DataTable();

            try
            {
                MessageBox.Show("Inside grid");
                DBConnection.openDBConnection();


                // MySqlCommand command = new MySqlCommand("SELECT * FROM purchase_order", mysqlcon);
                MySqlCommand command = new MySqlCommand("SELECT * FROM purchase_order WHERE  OrderID != 'Null' AND Price != 0 AND RefNo != 'Null' AND Material != 'Null' AND Description != 'Null' AND Supplier != 'Null'AND Quantity != 0 AND Site != 'Null'", mysqlcon);
                //command.CommandType = CommandType.StoredProcedure;
                command.CommandType = CommandType.Text;
                //command.Parameters.AddWithValue("?refno_search", refno_search);

                MySqlDataAdapter adapter = new MySqlDataAdapter();


                adapter.SelectCommand = command;
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error On Searching Records", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
            return table;
        }

        public void UpdatePo_byProc_dept()
        {
            try
            {
                DBConnection.openDBConnection();

                MessageBox.Show(Requested_amount.ToString());


                if (Suplier_sent_amount == Recieved_amount)
                {
                    MessageBox.Show("suplier sent amount and recieved amount are same", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (Requested_amount == Suplier_sent_amount)
                    {
                        //update as complete
                        Delivery_status = "Completely Delivered";
                        Remaining_qty = 0;
                        
                        //remaining must be 0
                        //Qry kiyala ekak hadala eke query eka gahala updatewenna pass kaamu
                    }
                    else if (Requested_amount > Suplier_sent_amount)
                    {
                        //partially completed
                        Delivery_status = "Partially Delivered";
                        Remaining_qty = (Requested_amount - Suplier_sent_amount);
                        //remaining must be (requested_amount - suplier_sent_amount)
                    }
                    else if (Requested_amount < Suplier_sent_amount)
                    {
                        //place complaint
                        Delivery_status = "Complain : Sent More Items Than Requested";
                        Complain_qty = (Suplier_sent_amount - Requested_amount);
                    }

                }
                else if (Suplier_sent_amount > Recieved_amount)
                {
                    MessageBox.Show("suplier sent amount is higher than recieved amount are same", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);

                    //place immidiate complaint
                    Delivery_status = "Complain : Items Lost In Middle";
                    Complain_qty = (Suplier_sent_amount - Recieved_amount);
                }
                else if (Suplier_sent_amount < Recieved_amount)
                {
                    MessageBox.Show("suplier sent amount is lower than recieved amount are same", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);

                    //place immidiate complaint
                    Delivery_status = "Complain : More Items Added In Middle";
                    Complain_qty = (Recieved_amount - Suplier_sent_amount);
                }
                MySqlCommand mySqlCmd = new MySqlCommand("UpdateDeliveryStatus", mysqlcon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;

                MessageBox.Show("insidemethod" + Recieved_amount.ToString());

                mySqlCmd.Parameters.AddWithValue("_OrderID", OrderId);
                mySqlCmd.Parameters.AddWithValue("_RecievedQty", Recieved_amount);
                mySqlCmd.Parameters.AddWithValue("_RemainingQty", Remaining_qty);
                mySqlCmd.Parameters.AddWithValue("_DelivaryStatus", Delivery_status);
                mySqlCmd.Parameters.AddWithValue("_ComplainQty", Complain_qty);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error Onsearching Records", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }

        }

        public DataTable ForPDfDownloadSearch(String refno_search) //overloadin example
        {
            DataTable table = new DataTable();

            try
            {
                MessageBox.Show("Inside grid");
                DBConnection.openDBConnection();


                //MySqlCommand command = new MySqlCommand("SELECT * FROM purchase_order WHERE RefNo = '" + refno_search + "' ", mysqlcon);
                MySqlCommand command = new MySqlCommand("SELECT RefNo, Material,Supplier,Price,Quantity,DelDate,SuplierSentQty,RecievedQty,RemainingQty,ComplainQty,DelivaryStatus FROM purchase_order WHERE  OrderID != 'Null' AND Price != 0 AND RefNo != 'Null' AND Material != 'Null' AND Description != 'Null' AND Supplier != 'Null'AND Quantity != 0 AND Site != 'Null' AND RefNo = '" + refno_search + "' ", mysqlcon);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("?refno_search", refno_search);

                MySqlDataAdapter adapter = new MySqlDataAdapter();


                adapter.SelectCommand = command;
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Onsearching Records", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
            return table;
        }
   
    public void createPDF_complaint()
    {
        Document document = new Document(PageSize.A2);

        PdfWriter.GetInstance(document, new FileStream("C:/DelivaryStatusComplain_Report.pdf", FileMode.Create));
        document.Open();

            System.Drawing.Image PImage = System.Drawing.Image.FromFile("C:\\ReportHeader.png");
            iTextSharp.text.Image ItextImage = iTextSharp.text.Image.GetInstance(PImage, System.Drawing.Imaging.ImageFormat.Png);
            ItextImage.Alignment = Element.ALIGN_CENTER;
            document.Add(ItextImage);


            PdfPTable table = new PdfPTable(proc_testGrid.Columns.Count);

        for (int j = 0; j < proc_testGrid.Columns.Count; j++)
        {
            table.AddCell(new Phrase(proc_testGrid.Columns[j].HeaderText));
        }

        table.HeaderRows = 1;


        for (int i = 0; i < proc_testGrid.Rows.Count; i++)
        {
            for (int k = 0; k < proc_testGrid.Columns.Count; k++)
            {
                if (proc_testGrid[k, i].Value != null)
                {
                    table.AddCell(new Phrase(proc_testGrid[k, i].Value.ToString()));
                }
            }
        }

        document.Add(table);

        table.HorizontalAlignment = Element.ALIGN_CENTER;

        document.Close();

        MessageBox.Show("Document Created.");

    }
}
}