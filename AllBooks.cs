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

namespace FinalTermAssignment
{
    public partial class AllBooks : Form
    {
        Database dss = new Database();
        string query;
        int id;
        public AllBooks()
        {
            InitializeComponent();
            var books = GetAllBooks();

        }

        private void searchLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
