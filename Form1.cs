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
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=latvanyossagokdb;Uid=root;Pwd=;");
            conn.Open();
            var command = conn.CreateCommand();
            command.CommandText = @"CREATE TABLE IF NOT EXISTS varosok(
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    nev VARCHAR(1000) NOT NULL,
                    lakossag INTEGER NOT NULL
                )";
            command.CommandText = @"CREATE TABLE IF NOT EXISTS latvanyossagok(
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    nev VARCHAR(1000) NOT NULL,
                    leiras VARCHAR(1000) NOT NULL,
                    ar INTEGER NOT NULL,
                    varos_id INTEGER
                )";
            command.ExecuteNonQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
