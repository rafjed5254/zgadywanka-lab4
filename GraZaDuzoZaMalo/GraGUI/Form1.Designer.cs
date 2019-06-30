namespace GraGUI
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSprawdz = new System.Windows.Forms.TextBox();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.labelSprawdz = new System.Windows.Forms.Label();
            this.textSprawdz = new System.Windows.Forms.TextBox();
            this.buttonZakoncz = new System.Windows.Forms.Button();
            this.buttonWyjdz = new System.Windows.Forms.Button();
            this.groupBoxLosuj.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(13, 13);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosuj
            // 
            this.groupBoxLosuj.Controls.Add(this.buttonLosuj);
            this.groupBoxLosuj.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosuj.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosuj.Controls.Add(this.labelZakresDo);
            this.groupBoxLosuj.Controls.Add(this.labelZakresOd);
            this.groupBoxLosuj.Location = new System.Drawing.Point(13, 43);
            this.groupBoxLosuj.Name = "groupBoxLosuj";
            this.groupBoxLosuj.Size = new System.Drawing.Size(293, 114);
            this.groupBoxLosuj.TabIndex = 1;
            this.groupBoxLosuj.TabStop = false;
            this.groupBoxLosuj.Text = "Losowanie";
            this.groupBoxLosuj.Visible = false;
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(116, 85);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonLosuj.TabIndex = 2;
            this.buttonLosuj.Text = "Wylosuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(116, 56);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(75, 20);
            this.textBoxZakresDo.TabIndex = 3;
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(116, 20);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(75, 20);
            this.textBoxZakresOd.TabIndex = 2;
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Location = new System.Drawing.Point(52, 59);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(58, 13);
            this.labelZakresDo.TabIndex = 1;
            this.labelZakresDo.Text = "Zakres do:";
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Location = new System.Drawing.Point(52, 23);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(58, 13);
            this.labelZakresOd.TabIndex = 0;
            this.labelZakresOd.Text = "Zakres od:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSprawdz);
            this.groupBox1.Controls.Add(this.buttonSprawdz);
            this.groupBox1.Controls.Add(this.labelSprawdz);
            this.groupBox1.Controls.Add(this.textSprawdz);
            this.groupBox1.Location = new System.Drawing.Point(13, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gra";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // textBoxSprawdz
            // 
            this.textBoxSprawdz.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxSprawdz.Location = new System.Drawing.Point(21, 58);
            this.textBoxSprawdz.Name = "textBoxSprawdz";
            this.textBoxSprawdz.ReadOnly = true;
            this.textBoxSprawdz.Size = new System.Drawing.Size(251, 20);
            this.textBoxSprawdz.TabIndex = 3;
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(197, 29);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(75, 23);
            this.buttonSprawdz.TabIndex = 2;
            this.buttonSprawdz.Text = "Sprawdź";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.ButtonSprawdz_Click);
            // 
            // labelSprawdz
            // 
            this.labelSprawdz.AutoSize = true;
            this.labelSprawdz.Location = new System.Drawing.Point(18, 33);
            this.labelSprawdz.Name = "labelSprawdz";
            this.labelSprawdz.Size = new System.Drawing.Size(92, 13);
            this.labelSprawdz.TabIndex = 1;
            this.labelSprawdz.Text = "Podaj rozwiązanie";
            // 
            // textSprawdz
            // 
            this.textSprawdz.Location = new System.Drawing.Point(116, 29);
            this.textSprawdz.Name = "textSprawdz";
            this.textSprawdz.Size = new System.Drawing.Size(75, 20);
            this.textSprawdz.TabIndex = 0;
            // 
            // buttonZakoncz
            // 
            this.buttonZakoncz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonZakoncz.Location = new System.Drawing.Point(111, 14);
            this.buttonZakoncz.Name = "buttonZakoncz";
            this.buttonZakoncz.Size = new System.Drawing.Size(96, 23);
            this.buttonZakoncz.TabIndex = 3;
            this.buttonZakoncz.Text = "Zakończ Grę";
            this.buttonZakoncz.UseVisualStyleBackColor = true;
            this.buttonZakoncz.Click += new System.EventHandler(this.ButtonZakoncz_Click);
            // 
            // buttonWyjdz
            // 
            this.buttonWyjdz.Location = new System.Drawing.Point(225, 14);
            this.buttonWyjdz.Name = "buttonWyjdz";
            this.buttonWyjdz.Size = new System.Drawing.Size(75, 23);
            this.buttonWyjdz.TabIndex = 4;
            this.buttonWyjdz.Text = "Zamknij";
            this.buttonWyjdz.UseVisualStyleBackColor = true;
            this.buttonWyjdz.Click += new System.EventHandler(this.ButtonWyjdz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 269);
            this.Controls.Add(this.buttonWyjdz);
            this.Controls.Add(this.buttonZakoncz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxLosuj);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Za dużo za mało";
            this.groupBoxLosuj.ResumeLayout(false);
            this.groupBoxLosuj.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosuj;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.Label labelZakresDo;
        private System.Windows.Forms.Label labelZakresOd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSprawdz;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.Label labelSprawdz;
        private System.Windows.Forms.TextBox textSprawdz;
        private System.Windows.Forms.Button buttonZakoncz;
        private System.Windows.Forms.Button buttonWyjdz;
    }
}

