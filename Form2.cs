using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LatvanyossagokApplication
{
    public partial class Form2 : Form
    {
        MySqlConnection conn;

        public Form2()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=Latvanyossagokdb;Uid=root;Pwd=;");
            conn.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
