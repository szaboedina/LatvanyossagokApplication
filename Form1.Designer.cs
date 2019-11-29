namespace LatvanyossagokApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.varosnevText = new System.Windows.Forms.TextBox();
            this.varos_felvetel = new System.Windows.Forms.Label();
            this.lakossagSzam = new System.Windows.Forms.NumericUpDown();
            this.varosfelvetelButton = new System.Windows.Forms.Button();
            this.latvanyossagfelvetel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.customInstaller2 = new MySql.Data.MySqlClient.CustomInstaller();
            this.latvanyossagAr = new System.Windows.Forms.NumericUpDown();
            this.comboVarosok = new System.Windows.Forms.ComboBox();
            this.varosNevLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.latvanyossagNevLabel = new System.Windows.Forms.Label();
            this.latvanyossagLeirasLabel = new System.Windows.Forms.Label();
            this.latvanyossagArLabel = new System.Windows.Forms.Label();
            this.latvanyossagVarosLabel = new System.Windows.Forms.Label();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lakossagSzam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossagAr)).BeginInit();
            this.SuspendLayout();
            // 
            // varosnevText
            // 
            this.varosnevText.Location = new System.Drawing.Point(149, 53);
            this.varosnevText.Name = "varosnevText";
            this.varosnevText.Size = new System.Drawing.Size(120, 22);
            this.varosnevText.TabIndex = 0;
            this.varosnevText.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // varos_felvetel
            // 
            this.varos_felvetel.AutoSize = true;
            this.varos_felvetel.Location = new System.Drawing.Point(25, 28);
            this.varos_felvetel.Name = "varos_felvetel";
            this.varos_felvetel.Size = new System.Drawing.Size(126, 17);
            this.varos_felvetel.TabIndex = 2;
            this.varos_felvetel.Text = "Város hozzáadása";
            this.varos_felvetel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lakossagSzam
            // 
            this.lakossagSzam.Location = new System.Drawing.Point(149, 81);
            this.lakossagSzam.Name = "lakossagSzam";
            this.lakossagSzam.Size = new System.Drawing.Size(120, 22);
            this.lakossagSzam.TabIndex = 3;
            // 
            // varosfelvetelButton
            // 
            this.varosfelvetelButton.Location = new System.Drawing.Point(25, 108);
            this.varosfelvetelButton.Name = "varosfelvetelButton";
            this.varosfelvetelButton.Size = new System.Drawing.Size(75, 27);
            this.varosfelvetelButton.TabIndex = 4;
            this.varosfelvetelButton.Text = "Hozzáadás";
            this.varosfelvetelButton.UseVisualStyleBackColor = true;
            this.varosfelvetelButton.Click += new System.EventHandler(this.VarosfelvetelButton_Click);
            // 
            // latvanyossagfelvetel
            // 
            this.latvanyossagfelvetel.AutoSize = true;
            this.latvanyossagfelvetel.Location = new System.Drawing.Point(25, 190);
            this.latvanyossagfelvetel.Name = "latvanyossagfelvetel";
            this.latvanyossagfelvetel.Size = new System.Drawing.Size(153, 17);
            this.latvanyossagfelvetel.TabIndex = 5;
            this.latvanyossagfelvetel.Text = "Látványosság felvétele";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 6;
            // 
            // customInstaller2
            // 
            this.customInstaller2.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.CustomInstaller2_AfterInstall);
            // 
            // latvanyossagAr
            // 
            this.latvanyossagAr.Location = new System.Drawing.Point(149, 274);
            this.latvanyossagAr.Name = "latvanyossagAr";
            this.latvanyossagAr.Size = new System.Drawing.Size(120, 22);
            this.latvanyossagAr.TabIndex = 8;
            // 
            // comboVarosok
            // 
            this.comboVarosok.FormattingEnabled = true;
            this.comboVarosok.Location = new System.Drawing.Point(148, 302);
            this.comboVarosok.Name = "comboVarosok";
            this.comboVarosok.Size = new System.Drawing.Size(121, 24);
            this.comboVarosok.TabIndex = 9;
            // 
            // varosNevLabel
            // 
            this.varosNevLabel.AutoSize = true;
            this.varosNevLabel.Location = new System.Drawing.Point(25, 53);
            this.varosNevLabel.Name = "varosNevLabel";
            this.varosNevLabel.Size = new System.Drawing.Size(37, 17);
            this.varosNevLabel.TabIndex = 10;
            this.varosNevLabel.Text = "Név:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lakosság száma:";
            // 
            // latvanyossagNevLabel
            // 
            this.latvanyossagNevLabel.AutoSize = true;
            this.latvanyossagNevLabel.Location = new System.Drawing.Point(28, 213);
            this.latvanyossagNevLabel.Name = "latvanyossagNevLabel";
            this.latvanyossagNevLabel.Size = new System.Drawing.Size(37, 17);
            this.latvanyossagNevLabel.TabIndex = 12;
            this.latvanyossagNevLabel.Text = "Név:";
            // 
            // latvanyossagLeirasLabel
            // 
            this.latvanyossagLeirasLabel.AutoSize = true;
            this.latvanyossagLeirasLabel.Location = new System.Drawing.Point(28, 245);
            this.latvanyossagLeirasLabel.Name = "latvanyossagLeirasLabel";
            this.latvanyossagLeirasLabel.Size = new System.Drawing.Size(51, 17);
            this.latvanyossagLeirasLabel.TabIndex = 13;
            this.latvanyossagLeirasLabel.Text = "Leírás:";
            // 
            // latvanyossagArLabel
            // 
            this.latvanyossagArLabel.AutoSize = true;
            this.latvanyossagArLabel.Location = new System.Drawing.Point(28, 279);
            this.latvanyossagArLabel.Name = "latvanyossagArLabel";
            this.latvanyossagArLabel.Size = new System.Drawing.Size(22, 17);
            this.latvanyossagArLabel.TabIndex = 14;
            this.latvanyossagArLabel.Text = "Ár";
            // 
            // latvanyossagVarosLabel
            // 
            this.latvanyossagVarosLabel.AutoSize = true;
            this.latvanyossagVarosLabel.Location = new System.Drawing.Point(28, 307);
            this.latvanyossagVarosLabel.Name = "latvanyossagVarosLabel";
            this.latvanyossagVarosLabel.Size = new System.Drawing.Size(45, 17);
            this.latvanyossagVarosLabel.TabIndex = 15;
            this.latvanyossagVarosLabel.Text = "Város";
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(149, 242);
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(100, 22);
            this.leirasTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leirasTextBox);
            this.Controls.Add(this.latvanyossagVarosLabel);
            this.Controls.Add(this.latvanyossagArLabel);
            this.Controls.Add(this.latvanyossagLeirasLabel);
            this.Controls.Add(this.latvanyossagNevLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.varosNevLabel);
            this.Controls.Add(this.comboVarosok);
            this.Controls.Add(this.latvanyossagAr);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.latvanyossagfelvetel);
            this.Controls.Add(this.varosfelvetelButton);
            this.Controls.Add(this.lakossagSzam);
            this.Controls.Add(this.varos_felvetel);
            this.Controls.Add(this.varosnevText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lakossagSzam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossagAr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox varosnevText;
        private System.Windows.Forms.Label varos_felvetel;
        private System.Windows.Forms.NumericUpDown lakossagSzam;
        private System.Windows.Forms.Button varosfelvetelButton;
        private System.Windows.Forms.Label latvanyossagfelvetel;
        private System.Windows.Forms.TextBox textBox1;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller2;
        private System.Windows.Forms.NumericUpDown latvanyossagAr;
        private System.Windows.Forms.ComboBox comboVarosok;
        private System.Windows.Forms.Label varosNevLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label latvanyossagNevLabel;
        private System.Windows.Forms.Label latvanyossagLeirasLabel;
        private System.Windows.Forms.Label latvanyossagArLabel;
        private System.Windows.Forms.Label latvanyossagVarosLabel;
        private System.Windows.Forms.TextBox leirasTextBox;
    }
}

