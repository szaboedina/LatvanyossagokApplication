namespace LatvanyossagokApplication
{
    partial class Form2
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
            this.buttonLatvanyossagModositas = new System.Windows.Forms.Button();
            this.textBoxLatvanyossagLeiras = new System.Windows.Forms.TextBox();
            this.latvanyossagVarosLabel = new System.Windows.Forms.Label();
            this.latvanyossagLeirasLabel = new System.Windows.Forms.Label();
            this.latvanyossagNevLabel = new System.Windows.Forms.Label();
            this.comboVarosok = new System.Windows.Forms.ComboBox();
            this.latvanyossagAr = new System.Windows.Forms.NumericUpDown();
            this.textBoxLatvanyossagNev = new System.Windows.Forms.TextBox();
            this.latvanyossagModositasLabel = new System.Windows.Forms.Label();
            this.latvanyossagArLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossagAr)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLatvanyossagModositas
            // 
            this.buttonLatvanyossagModositas.Location = new System.Drawing.Point(35, 172);
            this.buttonLatvanyossagModositas.Name = "buttonLatvanyossagModositas";
            this.buttonLatvanyossagModositas.Size = new System.Drawing.Size(120, 27);
            this.buttonLatvanyossagModositas.TabIndex = 26;
            this.buttonLatvanyossagModositas.Text = "Módosít";
            this.buttonLatvanyossagModositas.UseVisualStyleBackColor = true;
            this.buttonLatvanyossagModositas.Click += new System.EventHandler(this.ButtonLatvanyossagModositas_Click);
            // 
            // textBoxLatvanyossagLeiras
            // 
            this.textBoxLatvanyossagLeiras.Location = new System.Drawing.Point(153, 71);
            this.textBoxLatvanyossagLeiras.Name = "textBoxLatvanyossagLeiras";
            this.textBoxLatvanyossagLeiras.Size = new System.Drawing.Size(120, 22);
            this.textBoxLatvanyossagLeiras.TabIndex = 25;
            // 
            // latvanyossagVarosLabel
            // 
            this.latvanyossagVarosLabel.AutoSize = true;
            this.latvanyossagVarosLabel.Location = new System.Drawing.Point(32, 136);
            this.latvanyossagVarosLabel.Name = "latvanyossagVarosLabel";
            this.latvanyossagVarosLabel.Size = new System.Drawing.Size(45, 17);
            this.latvanyossagVarosLabel.TabIndex = 24;
            this.latvanyossagVarosLabel.Text = "Város";
            // 
            // latvanyossagLeirasLabel
            // 
            this.latvanyossagLeirasLabel.AutoSize = true;
            this.latvanyossagLeirasLabel.Location = new System.Drawing.Point(32, 74);
            this.latvanyossagLeirasLabel.Name = "latvanyossagLeirasLabel";
            this.latvanyossagLeirasLabel.Size = new System.Drawing.Size(51, 17);
            this.latvanyossagLeirasLabel.TabIndex = 23;
            this.latvanyossagLeirasLabel.Text = "Leírás:";
            // 
            // latvanyossagNevLabel
            // 
            this.latvanyossagNevLabel.AutoSize = true;
            this.latvanyossagNevLabel.Location = new System.Drawing.Point(32, 42);
            this.latvanyossagNevLabel.Name = "latvanyossagNevLabel";
            this.latvanyossagNevLabel.Size = new System.Drawing.Size(37, 17);
            this.latvanyossagNevLabel.TabIndex = 22;
            this.latvanyossagNevLabel.Text = "Név:";
            // 
            // comboVarosok
            // 
            this.comboVarosok.FormattingEnabled = true;
            this.comboVarosok.Location = new System.Drawing.Point(152, 131);
            this.comboVarosok.Name = "comboVarosok";
            this.comboVarosok.Size = new System.Drawing.Size(121, 24);
            this.comboVarosok.TabIndex = 21;
            // 
            // latvanyossagAr
            // 
            this.latvanyossagAr.Location = new System.Drawing.Point(153, 103);
            this.latvanyossagAr.Name = "latvanyossagAr";
            this.latvanyossagAr.Size = new System.Drawing.Size(120, 22);
            this.latvanyossagAr.TabIndex = 20;
            // 
            // textBoxLatvanyossagNev
            // 
            this.textBoxLatvanyossagNev.Location = new System.Drawing.Point(153, 39);
            this.textBoxLatvanyossagNev.Name = "textBoxLatvanyossagNev";
            this.textBoxLatvanyossagNev.Size = new System.Drawing.Size(120, 22);
            this.textBoxLatvanyossagNev.TabIndex = 19;
            // 
            // latvanyossagModositasLabel
            // 
            this.latvanyossagModositasLabel.AutoSize = true;
            this.latvanyossagModositasLabel.Location = new System.Drawing.Point(29, 19);
            this.latvanyossagModositasLabel.Name = "latvanyossagModositasLabel";
            this.latvanyossagModositasLabel.Size = new System.Drawing.Size(172, 17);
            this.latvanyossagModositasLabel.TabIndex = 18;
            this.latvanyossagModositasLabel.Text = "Látványosság Módosítása";
            // 
            // latvanyossagArLabel
            // 
            this.latvanyossagArLabel.AutoSize = true;
            this.latvanyossagArLabel.Location = new System.Drawing.Point(32, 108);
            this.latvanyossagArLabel.Name = "latvanyossagArLabel";
            this.latvanyossagArLabel.Size = new System.Drawing.Size(22, 17);
            this.latvanyossagArLabel.TabIndex = 27;
            this.latvanyossagArLabel.Text = "Ár";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.latvanyossagArLabel);
            this.Controls.Add(this.buttonLatvanyossagModositas);
            this.Controls.Add(this.textBoxLatvanyossagLeiras);
            this.Controls.Add(this.latvanyossagVarosLabel);
            this.Controls.Add(this.latvanyossagLeirasLabel);
            this.Controls.Add(this.latvanyossagNevLabel);
            this.Controls.Add(this.comboVarosok);
            this.Controls.Add(this.latvanyossagAr);
            this.Controls.Add(this.textBoxLatvanyossagNev);
            this.Controls.Add(this.latvanyossagModositasLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossagAr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLatvanyossagModositas;
        private System.Windows.Forms.TextBox textBoxLatvanyossagLeiras;
        private System.Windows.Forms.Label latvanyossagVarosLabel;
        private System.Windows.Forms.Label latvanyossagLeirasLabel;
        private System.Windows.Forms.Label latvanyossagNevLabel;
        private System.Windows.Forms.ComboBox comboVarosok;
        private System.Windows.Forms.NumericUpDown latvanyossagAr;
        private System.Windows.Forms.TextBox textBoxLatvanyossagNev;
        private System.Windows.Forms.Label latvanyossagModositasLabel;
        private System.Windows.Forms.Label latvanyossagArLabel;
    }
}