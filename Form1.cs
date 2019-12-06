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
            VarosListazas();
            LatvanyossagListazas();
        }

        void VarosListazas()
        {
            listBoxVarosok.Items.Clear();
            comboVarosok.Items.Clear();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, nev, lakossag FROM varosok";
            using(var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var lakossag = reader.GetInt32("lakossag");
                    listBoxVarosok.Items.Add(new Varos(id,nev,lakossag));
                    comboVarosok.Items.Add(new Varos(id, nev, lakossag));
                }
            }
        }
        void LatvanyossagListazas()
        {
            listBoxLatvanyossagok.Items.Clear();
            //if (listBoxVarosok.SelectedItems.Count > 0)
           // {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT id, nev, leiras, ar, varos_id FROM latvanyossagok";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32("id");
                        var nev = reader.GetString("nev");
                        var leiras = reader.GetString("leiras");
                        var ar = reader.GetInt32("ar");
                        var varos_id = reader.GetInt32("varos_id");
                       // cmd.Parameters.AddWithValue("@id", listBoxVarosok.SelectedItems);

                        listBoxLatvanyossagok.Items.Add(new Latvanyossagok(id, nev, leiras, ar, varos_id));
                    }
                }
           // }
            
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
                    listBoxVarosok.Items.Clear();
                    VarosListazas();
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
        private void ButtonVarosTorles_Click(object sender, EventArgs e)
        {
            if (listBoxLatvanyossagok.Items.Count > 0)
            {
                MessageBox.Show("Nem törölhet olyan várost aminek látványossága van.");
            }
            else
            {
                if (listBoxVarosok.SelectedIndex == -1)
                {
                    MessageBox.Show("Nincs város kivalasztva!");
                    return;
                }
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM varosok WHERE id = @id";
                var varos = (Varos)listBoxVarosok.SelectedItem;
                cmd.Parameters.AddWithValue("@id", varos.Id);
                cmd.ExecuteNonQuery();
                VarosListazas();
            }
        }
        private void buttonLatvanyossagFelvetel_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(textBoxLatvanyossagNev.Text))
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"INSERT INTO latvanyossagok(nev, leiras, ar, varos_id)
                                VALUES(@nev, @leiras, @ar, @varos_id)";
                    cmd.Parameters.AddWithValue("@nev", textBoxLatvanyossagNev.Text);
                    cmd.Parameters.AddWithValue("@leiras", textBoxLatvanyossagLeiras.Text);
                    cmd.Parameters.AddWithValue("@ar", latvanyossagAr.Value);
                    var varos = (Varos)comboVarosok.SelectedItem;
                    cmd.Parameters.AddWithValue("@varos_id", varos.Id);
                    cmd.ExecuteNonQuery();
                    LatvanyossagListazas();
                }
                else
                {
                    MessageBox.Show("Minden mezőt ki kell tölteni!");
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Már van ilyen nevű látványosság az adatbázisban");
                }
            }
        }
        private void ButtonLatvanyossagTorles_Click(object sender, EventArgs e)
        {
            if (listBoxLatvanyossagok.SelectedIndex == -1)
            {
                MessageBox.Show("Nincs látványosság kivalasztva!");
                return;
            }
            else {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM latvanyossagok WHERE id = @id";
            var latvanyossagok = (Latvanyossagok)listBoxLatvanyossagok.SelectedItem;
            cmd.Parameters.AddWithValue("@id", latvanyossagok.Id);
            cmd.ExecuteNonQuery();
            LatvanyossagListazas();
            }
        }
        Form2 formUpdate = new Form2();

        private void ButtonLatvanyossagModositas_Click(object sender, EventArgs e)
        {
            formUpdate.Show();


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
 

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
