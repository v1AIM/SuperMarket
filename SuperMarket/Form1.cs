using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.VISIT' table. You can move, or remove it, as needed.
            this.vISITTableAdapter.Fill(this.dataSet1.VISIT);
            // TODO: This line of code loads data into the 'dataSet1.SUPPLIES' table. You can move, or remove it, as needed.
            this.sUPPLIESTableAdapter.Fill(this.dataSet1.SUPPLIES);
            // TODO: This line of code loads data into the 'dataSet1.SUPPLIER' table. You can move, or remove it, as needed.
            this.sUPPLIERTableAdapter.Fill(this.dataSet1.SUPPLIER);
            // TODO: This line of code loads data into the 'dataSet1.SUPERMARKET' table. You can move, or remove it, as needed.
            this.sUPERMARKETTableAdapter.Fill(this.dataSet1.SUPERMARKET);
            // TODO: This line of code loads data into the 'dataSet1.SECTION_LOCATION' table. You can move, or remove it, as needed.
            this.sECTION_LOCATIONTableAdapter.Fill(this.dataSet1.SECTION_LOCATION);
            // TODO: This line of code loads data into the 'dataSet1.SECTION' table. You can move, or remove it, as needed.
            this.sECTIONTableAdapter.Fill(this.dataSet1.SECTION);
            // TODO: This line of code loads data into the 'dataSet1.PURCHASED' table. You can move, or remove it, as needed.
            this.pURCHASEDTableAdapter.Fill(this.dataSet1.PURCHASED);
            // TODO: This line of code loads data into the 'dataSet1.PRODUCT_GROUP' table. You can move, or remove it, as needed.
            this.pRODUCT_GROUPTableAdapter.Fill(this.dataSet1.PRODUCT_GROUP);
            // TODO: This line of code loads data into the 'dataSet1.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.dataSet1.PRODUCT);
            // TODO: This line of code loads data into the 'dataSet1.ORDERS' table. You can move, or remove it, as needed.
            this.oRDERSTableAdapter.Fill(this.dataSet1.ORDERS);
            // TODO: This line of code loads data into the 'dataSet1.ORDER' table. You can move, or remove it, as needed.
            this.oRDERTableAdapter.Fill(this.dataSet1.ORDER);
            // TODO: This line of code loads data into the 'dataSet1.GETS' table. You can move, or remove it, as needed.
            this.gETSTableAdapter.Fill(this.dataSet1.GETS);
            // TODO: This line of code loads data into the 'dataSet1.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.dataSet1.EMPLOYEE);
            // TODO: This line of code loads data into the 'dataSet1.ELECTRONIC_STAFF' table. You can move, or remove it, as needed.
            this.eLECTRONIC_STAFFTableAdapter.Fill(this.dataSet1.ELECTRONIC_STAFF);
            // TODO: This line of code loads data into the 'dataSet1.DELIVERY' table. You can move, or remove it, as needed.
            this.dELIVERYTableAdapter.Fill(this.dataSet1.DELIVERY);
            // TODO: This line of code loads data into the 'dataSet1.DEAL_WITH' table. You can move, or remove it, as needed.
            this.dEAL_WITHTableAdapter.Fill(this.dataSet1.DEAL_WITH);
            // TODO: This line of code loads data into the 'dataSet1.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
            // TODO: This line of code loads data into the 'dataSet1.CLEANING_STAFF' table. You can move, or remove it, as needed.
            this.cLEANING_STAFFTableAdapter.Fill(this.dataSet1.CLEANING_STAFF);
            // TODO: This line of code loads data into the 'dataSet1.CASHIER' table. You can move, or remove it, as needed.
            this.cASHIERTableAdapter.Fill(this.dataSet1.CASHIER);
            // TODO: This line of code loads data into the 'dataSet1.BRANCH' table. You can move, or remove it, as needed.
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-2JB7FNI;Integrated Security=True");
//SqlCommand sqlCommand = new SqlCommand();
            //sqlCommand.Connection = sqlConnection;
          //  sqlConnection.Open();
           // sqlCommand.CommandText = "sp_MSforeachtable @command1 = \"select count(*) from ? \";";
           // sqlCommand.ExecuteNonQuery();
          //  sqlConnection.Close();
          //  MessageBox.Show("DATA UPDATED SUCCESSUFlly");
    

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.bRANCHTableAdapter.Fill(this.dataSet1.BRANCH);
        }


        //Insert Button
        private void button1_Click(object sender, EventArgs e)
        {

        }


        //Update Button

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-2JB7FNI;Integrated Security=True");
           // SqlCommand sqlCommand = new SqlCommand();
          //  sqlCommand.Connection = sqlConnection;
           // sqlConnection.Open();
           // sqlCommand.CommandText = "update CustomerDemographics set CustomerDesc = '" + textBox2.Text + "' WHERE CustomerTypeID = '" + textBox1.Text + "'";
          //  sqlCommand.ExecuteNonQuery();
          //  sqlConnection.Close();
          //  MessageBox.Show("DATA UPDATED SUCCESSUFlly");
        }


        //Show Data
        private void button5_Click(object sender, EventArgs e)
        {

        }


        //Delete Button
        private void button3_Click(object sender, EventArgs e)
        {

        }


        //Scroll UP
        private void button7_Click(object sender, EventArgs e)
        {

        }


        //Scroll Down
        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
