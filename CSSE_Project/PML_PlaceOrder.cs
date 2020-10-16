using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSE_Project
{
    public partial class PML_PlaceOrder : Form
    {

        string connectionString = @"Server=projects.dimodigital.lk; Database=PML; Uid=ttm;Pwd=ttm;";

        int order_id = 0;

        public PML_PlaceOrder()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PML_Home home = new PML_Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PML_PlaceOrder_Load(object sender, EventArgs e)
        {
            GridFill();
            Clear();
            lbl_name.Text = PML_Login.chkName;

            if (PML_Login.chkType == "Supervisor")
            {
                lblName.Text = "Supervisor";
            }

            else if (PML_Login.chkType == "Line Manager")
            {
                lblName.Text = "Line Manager";
            }

        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewApprovedOrders", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbPlace = new DataTable();
                sqlDa.Fill(dtbPlace);
                dgv_placeOrderView.DataSource = dtbPlace;
                dgv_placeOrderView.Columns[0].Visible = false;
            }
        }

        void Clear()
        {
            txt_orderRef.Text = "";
            txt_amount.Text = "";
            txt_orderStatus.Text = "";
            order_id = 0;
        }

        private void dgv_placeOrderView_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_placeOrderView.CurrentRow.Index != -1)
            {
                txt_orderRef.Text = dgv_placeOrderView.CurrentRow.Cells[1].Value.ToString();
                txt_site.Text = dgv_placeOrderView.CurrentRow.Cells[6].Value.ToString();
                txt_material.Text = dgv_placeOrderView.CurrentRow.Cells[2].Value.ToString();
                txt_des.Text = dgv_placeOrderView.CurrentRow.Cells[3].Value.ToString();
                txt_supplier.Text = dgv_placeOrderView.CurrentRow.Cells[4].Value.ToString();
                txt_amount.Text = dgv_placeOrderView.CurrentRow.Cells[5].Value.ToString();
                dtp_po.Text = dgv_placeOrderView.CurrentRow.Cells[7].Value.ToString();
                txt_orderStatus.Text = dgv_placeOrderView.CurrentRow.Cells[8].Value.ToString();
                order_id = Convert.ToInt32(dgv_placeOrderView.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btn_placeOrder_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd;
                cmd = new MySqlCommand("UPDATE purchase_order SET Status='Placed' WHERE OrderID=@OrderID", mysqlCon);
                mysqlCon.Open();
                cmd.Parameters.AddWithValue("@OrderID", order_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Status Updated Successfully");

                if (txt_orderRef.Text != "")
                {
                    Document pdoc = new Document(PageSize.A4, 50f, 0f, 0f, 30f);

                    PdfWriter pWriter = PdfWriter.GetInstance(pdoc, new FileStream("C:/" + txt_orderRef.Text + ".pdf", FileMode.Create));
                    pdoc.Open();

                    System.Drawing.Image PImage = System.Drawing.Image.FromFile("C:\\ReportHeader.png");
                    iTextSharp.text.Image ItextImage = iTextSharp.text.Image.GetInstance(PImage, System.Drawing.Imaging.ImageFormat.Png);
                    ItextImage.Alignment = Element.ALIGN_CENTER;
                    pdoc.Add(ItextImage);

                    Paragraph address = new Paragraph("KHS2 Cnstructions (Pvt) Ltd ," + "\n" + "No: 01 ," + "\n" + "Dane's Plains ," + "\n" + "Katukurunda ," + "\n" + "Kaluthara North." + "\n");
                    address.Alignment = Element.ALIGN_LEFT;
                    pdoc.Add(address);

                    Paragraph heading = new Paragraph("\n" + "\n" + "Prchase Order Requisition" + "\n" + "\n");
                    heading.Alignment = Element.ALIGN_CENTER;
                    pdoc.Add(heading);

                    Paragraph para = new Paragraph("\n" + "Purchase Order Details are as of below. Please be kind enough to let us know if there are any information that should be modified." + "\n" + "\n" + "\n");
                    para.Alignment = Element.ALIGN_LEFT;
                    pdoc.Add(para);

                    Paragraph para1 = new Paragraph("Order Reference   :   " + txt_orderRef.Text + "\n" + "Construction Site   :   " + txt_site.Text + "\n" + "Order Material       :   " + txt_material.Text + "\n" + "Order Description  :   " + txt_des.Text + "\n" + "Supplier Name       :   " + txt_supplier.Text + "\n" + "Agreed Price          :   LKR. " + txt_amount.Text + "\n" + "Delivery Date        :  " + dtp_po.Value + "\n" + "\n");
                    para1.Alignment = Element.ALIGN_BASELINE;
                    pdoc.Add(para1);

                    Paragraph para2 = new Paragraph("\n" + "Thanks & Regards!" + "\n");
                    para2.Alignment = Element.ALIGN_LEFT;
                    pdoc.Add(para2);

                    System.Drawing.Image PImage1 = System.Drawing.Image.FromFile("C:\\stamp.png");
                    iTextSharp.text.Image ItextImage1 = iTextSharp.text.Image.GetInstance(PImage1, System.Drawing.Imaging.ImageFormat.Png);
                    ItextImage1.Alignment = Element.ALIGN_LEFT;
                    pdoc.Add(ItextImage1);

                    pdoc.Close();
                    MessageBox.Show("Order Report Created Successfully.");
                }

                GridFill();
            }

            if (txt_orderRef.Text != "")
            {
                string userMail = null;
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    String sql = "SELECT Email FROM pml_user WHERE Username='" + lbl_name.Text + "'";
                    MySqlCommand mySc = new MySqlCommand(sql, mysqlCon);
                    MySqlDataReader myDr = mySc.ExecuteReader();

                    while (myDr.Read())
                    {
                        userMail = myDr.GetValue(0).ToString();
                    }
                }

                string Tomail = null;
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    String sql = "SELECT Email FROM suppliers WHERE name='" + txt_supplier.Text + "'";
                    MySqlCommand mySc = new MySqlCommand(sql, mysqlCon);
                    MySqlDataReader myDr = mySc.ExecuteReader();

                    while (myDr.Read())
                    {
                        Tomail = myDr.GetValue(0).ToString();
                    }
                }

                string ccMail = null;
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    String sql = "SELECT Email FROM pml_user WHERE Username='" + txt_orderStatus.Text + "'";
                    MySqlCommand mySc = new MySqlCommand(sql, mysqlCon);
                    MySqlDataReader myDr = mySc.ExecuteReader();

                    while (myDr.Read())
                    {
                        ccMail = myDr.GetValue(0).ToString();
                    }
                }

                Mail.userEmail = userMail;
                Mail.toName = Tomail;
                Mail.ccName = ccMail;
                Mail.attachment = "C:\\" + txt_orderRef.Text + ".pdf";
                Mail.subject = "Purchase Order Requisition";
                Mail.message = "Please find the attached pdf file of order details of " + txt_material.Text + " Order No: " + txt_orderRef.Text + "\n" + "\n" + "Thanks & Regards!";
                Mail openMail = new Mail();
                openMail.Show();
            }

            else
            {
                MessageBox.Show("Please select an order to be placed");
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        
        private void btn_placeSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchByApproved", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_OrderSearch", txt_search.Text);
                DataTable dtblOrder = new DataTable();
                sqlDa.Fill(dtblOrder);
                dgv_placeOrderView.DataSource = dtblOrder;
                dgv_placeOrderView.Columns[0].Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PML_UserProfile userProfile = new PML_UserProfile();
            userProfile.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PML_Login login = new PML_Login();
            login.Show();
            this.Hide();
        }

        private void btn_Supervisor_signOut_Click(object sender, EventArgs e)
        {
            PML_Login logout = new PML_Login();
            logout.Show();
            this.Hide();
        }

        private void btn_Supervisor_POHistory_Click(object sender, EventArgs e)
        {
            PML_POhistory pML_POhistory = new PML_POhistory();
            pML_POhistory.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PML_PlaceOrder placeOrder = new PML_PlaceOrder();
            placeOrder.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PML_DraftPO draftPO = new PML_DraftPO();
            draftPO.Show();
            this.Hide();
        }

        private void btn_Supervisor_authorizePO_Click(object sender, EventArgs e)
        {
            PML_AuthorizePO authorize = new PML_AuthorizePO();
            authorize.Show();
            this.Hide();
        }

    }
}
