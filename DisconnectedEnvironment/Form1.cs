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

namespace DisconnectedEnvironment
{
    public partial class Form1 : Form
    {
        public SqlConnection SqlConnection { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string Code;

            Code = txtCode.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRDataSet.empdetails' table. You can move, or remove it, as needed.
            this.empdetailsTableAdapter.Fill(this.hRDataSet.empdetails);
            DataTable dt;
            DataRow dr;
            string Code;

            // TODO: This line of code loads data into the 'hRDataSet.empdetails' table. You can move, or remove it, as needed.
            //This line of code loads data into the hRDataSet.Empdetails table. this would appear in form 1 load event
            txtCode.Enabled = false;
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtState.Enabled = false;
            txtCountry.Enabled = false;
            cbDesignation.Enabled = false;
            cbDepartment.Enabled = false;
            cbDesignation.Items.Add("MANAGER");
            cbDesignation.Items.Add("AUTHOR");
            cbDesignation.Items.Add("DESIGNER");
            cbDepartment.Items.Add("MARKETING");
            cbDepartment.Items.Add("FINANCE");
            cbDepartment.Items.Add("IDD");
            cmdSave.Enabled = false;
        }
    }
}
