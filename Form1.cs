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
                    id INTEGER PRIMARY KEY AUTO_INCREMENT,
                    nev VARCHAR(128) NOT NULL,
                    lakossag INTEGER NOT NULL
                )";
            command.ExecuteNonQuery();

            command.CommandText = @"CREATE TABLE IF NOT EXISTS latvanyossagok(
                    id INTEGER PRIMARY KEY AUTO_INCREMENT,
                    nev VARCHAR(128) NOT NULL,
                    leiras VARCHAR(1000) NOT NULL,
                    ar INTEGER DEFAULT 0,
                    varos_id INTEGER NOT NULL,
                    FOREIGN KEY (varos_ID)
                        REFERENCES varosok(id)
                )";
            command.ExecuteNonQuery();
        }

        void VarosListazas()
        {
            comboVarosok.Items.Clear();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT nev FROM varosok";
            using(var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetString("nev");
                    comboVarosok.Items.Add(new)
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomInstaller2_AfterInstall(object sender, System.Configuration.Install.InstallEventArgs e)
        {

        }

        private void VarosfelvetelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(varosnevText.Text))
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"INSERT INTO varosok(nev, lakossag)
                                VALUES(@nev, @lakossag)";
                    cmd.Parameters.AddWithValue("@nev", varosnevText.Text);
                    cmd.Parameters.AddWithValue("@lakossag", lakossagSzam.Value);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Minden mezőt ki kell tölteni!");
                }

            }
            catch (MySqlException ex)
            {
                if ( ex.Number==1062)
                {
                    MessageBox.Show("Már van ilyen nevű város az adatbázisban");
                }
              
            }


            
        }

        private void VarosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
