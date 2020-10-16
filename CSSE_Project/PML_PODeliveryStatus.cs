using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace CSSE_Project
{
    public partial class PML_PODeliveryStatus : Form
    {
        ProcurementDeliveryStatus procurement_delivery_status = new ProcurementDeliveryStatus();
        String EmailMsg;
        DataGridView testGrid =new DataGridView();
        public PML_PODeliveryStatus()
        {
            InitializeComponent();
        }

        private void PML_PODeliveryStatus_Load(object sender, EventArgs e)
        {
            lbl_name.Text = PML_Login.chkName;

            dgv_Delivary_status.DataSource = procurement_delivery_status.FillGridByRef();

        }

        private void Pnl_POHistorySideNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            PML_Home home = new PML_Home();
            home.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txt_del_status_requested.Text = "";
            txt_del_status_sent.Text = "";
            txt_del_status_recieved.Text = "";
            dgv_Delivary_status.DataSource = procurement_delivery_status.FillGridByRef();
        }

        private void Btn_del_status_search_Click(object sender, EventArgs e)
        {
            
            if (txt_del_stats_search.Text == "")
            {
                MessageBox.Show("Search Field Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                //MessageBox.Show("test button inside"+ txt_del_stats_search.Text);
                procurement_delivery_status.Refno_search = txt_del_stats_search.Text.Trim().ToString();
                dgv_Delivary_status.DataSource = procurement_delivery_status.FillGridByRef(procurement_delivery_status.Refno_search);
                
            }

        }

        private void Dgv_Delivary_status_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_Delivary_status_DoubleClick(object sender, EventArgs e)
        {
            txt_del_status_requested.Text = dgv_Delivary_status.CurrentRow.Cells[6].Value.ToString();
            txt_del_status_sent.Text = dgv_Delivary_status.CurrentRow.Cells[13].Value.ToString();
            //txt_del_status_recieved.Text = dgv_Delivary_status.CurrentRow.Cells[14].Value.ToString();

            procurement_delivery_status.OrderId = Int32.Parse(dgv_Delivary_status.CurrentRow.Cells[0].Value.ToString());
            procurement_delivery_status.Requested_amount = float.Parse(txt_del_status_requested.Text.Trim().ToString());
            procurement_delivery_status.Suplier_sent_amount = float.Parse(txt_del_status_sent.Text.Trim().ToString());
            //procurement_delivery_status.Recieved_amount = float.Parse(txt_del_status_recieved.Text.Trim().ToString());

            MessageBox.Show("insidebtn" + procurement_delivery_status.Requested_amount.ToString());
        }

        private void Btn_Ddel_status_add_Click(object sender, EventArgs e)
        {
            procurement_delivery_status.Recieved_amount = float.Parse(txt_del_status_recieved.Text.Trim().ToString());
            procurement_delivery_status.UpdatePo_byProc_dept();
            dgv_Delivary_status.DataSource = procurement_delivery_status.FillGridByRef();
        }

        private void Btn_Ddel_status_complaint_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComplainEmail complainEmail = new ComplainEmail();
            complainEmail.ShowDialog();
            
            complainEmail.txt_email_del_status_Message.Text = EmailMsg;
            
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            procurement_delivery_status.FillGridByRef();
        }

        private void Dgv_Delivary_status_Click(object sender, EventArgs e)
        {
            EmailMsg = dgv_Delivary_status.CurrentRow.Cells[17].Value.ToString();
        }

        private void Bbtn_download_pdf_del_status_Click(object sender, EventArgs e)
        {
            if (txt_del_stats_search.Text == "")
            {
                MessageBox.Show("Search Field Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show("test button inside"+ txt_del_stats_search.Text);
                procurement_delivery_status.Refno_search = txt_del_stats_search.Text.Trim().ToString();
                dgv_Delivary_status.DataSource = procurement_delivery_status.ForPDfDownloadSearch(procurement_delivery_status.Refno_search);
                //createDocument();
                testGrid = dgv_Delivary_status;
                procurement_delivery_status.proc_testGrid = testGrid;
                procurement_delivery_status.createPDF_complaint();
            }
        }

       private void createDocument()
        {
            Document document = new Document(PageSize.A2);

            PdfWriter.GetInstance(document, new FileStream("D:/DelivaryStatusComplain_Report.pdf", FileMode.Create));
            document.Open();

            /*System.Drawing.Image PImage = System.Drawing.Image.FromFile("D:\\i1.png");
            iTextSharp.text.Image ItextImage = iTextSharp.text.Image.GetInstance(PImage, System.Drawing.Imaging.ImageFormat.Png);
            ItextImage.Alignment = Element.ALIGN_CENTER;
            document.Add(ItextImage);*/


            PdfPTable table = new PdfPTable(dgv_Delivary_status.Columns.Count);

            for (int j = 0; j < dgv_Delivary_status.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dgv_Delivary_status.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;


            for (int i = 0; i < dgv_Delivary_status.Rows.Count; i++)
            {
                for (int k = 0; k < dgv_Delivary_status.Columns.Count; k++)
                {
                    if (dgv_Delivary_status[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dgv_Delivary_status[k, i].Value.ToString()));
                    }
                }
            }

            document.Add(table);

            table.HorizontalAlignment = Element.ALIGN_CENTER;

            document.Close();

            MessageBox.Show("Document Created.");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            PML_Login logout = new PML_Login();
            logout.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PML_POhistory pML_POhistory = new PML_POhistory();
            pML_POhistory.Show();
            this.Hide();
        }

        private void btn_Supervisor_DeliveryStatusHandle_Click(object sender, EventArgs e)
        {
            PML_PODeliveryStatus deliverystatusprocurement = new PML_PODeliveryStatus();
            deliverystatusprocurement.Show();
            this.Hide();
        }
    }
}
