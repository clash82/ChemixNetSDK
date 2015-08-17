namespace chxModul
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PomocButton = new System.Windows.Forms.Button();
            this.DrukujButton = new System.Windows.Forms.Button();
            this.OpisLabel = new System.Windows.Forms.Label();
            this.DostosujButton = new System.Windows.Forms.Button();
            this.RejestrWczytajTekstButton = new System.Windows.Forms.Button();
            this.RejestrZapiszTekstButton = new System.Windows.Forms.Button();
            this.WyjatekButton = new System.Windows.Forms.Button();
            this.RejestrUstawieniaButton = new System.Windows.Forms.Button();
            this.BazaPobierzRekordButton = new System.Windows.Forms.Button();
            this.BazaPobierzKolumneButton = new System.Windows.Forms.Button();
            this.BazaPobierzWiersz = new System.Windows.Forms.Button();
            this.BazaPobierzWszystko = new System.Windows.Forms.Button();
            this.UsunTagiButton = new System.Windows.Forms.Button();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // PomocButton
            // 
            this.PomocButton.Location = new System.Drawing.Point(24, 88);
            this.PomocButton.Name = "PomocButton";
            this.PomocButton.Size = new System.Drawing.Size(192, 23);
            this.PomocButton.TabIndex = 1;
            this.PomocButton.Text = "&Pokaż okno pomocy";
            this.PomocButton.UseVisualStyleBackColor = true;
            this.PomocButton.Click += new System.EventHandler(this.PomocButton_Click);
            // 
            // DrukujButton
            // 
            this.DrukujButton.Location = new System.Drawing.Point(24, 117);
            this.DrukujButton.Name = "DrukujButton";
            this.DrukujButton.Size = new System.Drawing.Size(192, 23);
            this.DrukujButton.TabIndex = 2;
            this.DrukujButton.Text = "&Wydrukuj coś";
            this.DrukujButton.UseVisualStyleBackColor = true;
            this.DrukujButton.Click += new System.EventHandler(this.DrukujButton_Click);
            // 
            // OpisLabel
            // 
            this.OpisLabel.BackColor = System.Drawing.Color.Transparent;
            this.OpisLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpisLabel.Location = new System.Drawing.Point(21, 21);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(407, 62);
            this.OpisLabel.TabIndex = 0;
            this.OpisLabel.Text = resources.GetString("OpisLabel.Text");
            // 
            // DostosujButton
            // 
            this.DostosujButton.Location = new System.Drawing.Point(24, 146);
            this.DostosujButton.Name = "DostosujButton";
            this.DostosujButton.Size = new System.Drawing.Size(192, 23);
            this.DostosujButton.TabIndex = 3;
            this.DostosujButton.Text = "&Dostosuj wygląd dokumentu";
            this.DostosujButton.UseVisualStyleBackColor = true;
            this.DostosujButton.Click += new System.EventHandler(this.DostosujButton_Click);
            // 
            // RejestrWczytajTekstButton
            // 
            this.RejestrWczytajTekstButton.Location = new System.Drawing.Point(24, 204);
            this.RejestrWczytajTekstButton.Name = "RejestrWczytajTekstButton";
            this.RejestrWczytajTekstButton.Size = new System.Drawing.Size(192, 23);
            this.RejestrWczytajTekstButton.TabIndex = 5;
            this.RejestrWczytajTekstButton.Text = "Rejestr: wczytaj &tekst z rejestru";
            this.RejestrWczytajTekstButton.UseVisualStyleBackColor = true;
            this.RejestrWczytajTekstButton.Click += new System.EventHandler(this.WczytajLiczbeButton_Click);
            // 
            // RejestrZapiszTekstButton
            // 
            this.RejestrZapiszTekstButton.Location = new System.Drawing.Point(24, 175);
            this.RejestrZapiszTekstButton.Name = "RejestrZapiszTekstButton";
            this.RejestrZapiszTekstButton.Size = new System.Drawing.Size(192, 23);
            this.RejestrZapiszTekstButton.TabIndex = 4;
            this.RejestrZapiszTekstButton.Text = "Rejestr: &zapisz tekst do rejestru";
            this.RejestrZapiszTekstButton.UseVisualStyleBackColor = true;
            this.RejestrZapiszTekstButton.Click += new System.EventHandler(this.ZapiszTekstButton_Click);
            // 
            // WyjatekButton
            // 
            this.WyjatekButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WyjatekButton.Location = new System.Drawing.Point(236, 233);
            this.WyjatekButton.Name = "WyjatekButton";
            this.WyjatekButton.Size = new System.Drawing.Size(192, 23);
            this.WyjatekButton.TabIndex = 12;
            this.WyjatekButton.Text = "Pokaż wyjąte&k";
            this.WyjatekButton.UseVisualStyleBackColor = true;
            this.WyjatekButton.Click += new System.EventHandler(this.WyjatekButton_Click);
            // 
            // RejestrUstawieniaButton
            // 
            this.RejestrUstawieniaButton.Location = new System.Drawing.Point(24, 233);
            this.RejestrUstawieniaButton.Name = "RejestrUstawieniaButton";
            this.RejestrUstawieniaButton.Size = new System.Drawing.Size(192, 23);
            this.RejestrUstawieniaButton.TabIndex = 6;
            this.RejestrUstawieniaButton.Text = "Rejestr: pobierz &ustawienia";
            this.RejestrUstawieniaButton.UseVisualStyleBackColor = true;
            this.RejestrUstawieniaButton.Click += new System.EventHandler(this.UstawieniaButton_Click);
            // 
            // BazaPobierzRekordButton
            // 
            this.BazaPobierzRekordButton.Location = new System.Drawing.Point(236, 88);
            this.BazaPobierzRekordButton.Name = "BazaPobierzRekordButton";
            this.BazaPobierzRekordButton.Size = new System.Drawing.Size(192, 23);
            this.BazaPobierzRekordButton.TabIndex = 7;
            this.BazaPobierzRekordButton.Text = "Baza: pobierz &rekord";
            this.BazaPobierzRekordButton.UseVisualStyleBackColor = true;
            this.BazaPobierzRekordButton.Click += new System.EventHandler(this.BazaPobierzRekordButton_Click);
            // 
            // BazaPobierzKolumneButton
            // 
            this.BazaPobierzKolumneButton.Location = new System.Drawing.Point(236, 117);
            this.BazaPobierzKolumneButton.Name = "BazaPobierzKolumneButton";
            this.BazaPobierzKolumneButton.Size = new System.Drawing.Size(192, 23);
            this.BazaPobierzKolumneButton.TabIndex = 8;
            this.BazaPobierzKolumneButton.Text = "Baza: pobierz kolu&mnę";
            this.BazaPobierzKolumneButton.UseVisualStyleBackColor = true;
            this.BazaPobierzKolumneButton.Click += new System.EventHandler(this.BazaPobierzKolumneButton_Click);
            // 
            // BazaPobierzWiersz
            // 
            this.BazaPobierzWiersz.Location = new System.Drawing.Point(236, 146);
            this.BazaPobierzWiersz.Name = "BazaPobierzWiersz";
            this.BazaPobierzWiersz.Size = new System.Drawing.Size(192, 23);
            this.BazaPobierzWiersz.TabIndex = 9;
            this.BazaPobierzWiersz.Text = "Baza: pobierz wie&rsz";
            this.BazaPobierzWiersz.UseVisualStyleBackColor = true;
            this.BazaPobierzWiersz.Click += new System.EventHandler(this.BazaPobierzWiersz_Click);
            // 
            // BazaPobierzWszystko
            // 
            this.BazaPobierzWszystko.Location = new System.Drawing.Point(236, 175);
            this.BazaPobierzWszystko.Name = "BazaPobierzWszystko";
            this.BazaPobierzWszystko.Size = new System.Drawing.Size(192, 23);
            this.BazaPobierzWszystko.TabIndex = 10;
            this.BazaPobierzWszystko.Text = "Baza: pobierz wszystk&o";
            this.BazaPobierzWszystko.UseVisualStyleBackColor = true;
            this.BazaPobierzWszystko.Click += new System.EventHandler(this.BazaPobierzWszystko_Click);
            // 
            // UsunTagiButton
            // 
            this.UsunTagiButton.Location = new System.Drawing.Point(236, 204);
            this.UsunTagiButton.Name = "UsunTagiButton";
            this.UsunTagiButton.Size = new System.Drawing.Size(192, 23);
            this.UsunTagiButton.TabIndex = 11;
            this.UsunTagiButton.Text = "U&suń wszystkie tagi";
            this.UsunTagiButton.UseVisualStyleBackColor = true;
            this.UsunTagiButton.Click += new System.EventHandler(this.UsunTagiButton_Click);
            // 
            // LinkLabel
            // 
            this.LinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel.LinkArea = new System.Windows.Forms.LinkArea(121, 15);
            this.LinkLabel.Location = new System.Drawing.Point(21, 276);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(407, 36);
            this.LinkLabel.TabIndex = 13;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "Jeśli zechcesz podzielić się ze światem swoim modułem, nie zapomnij wysłać go do " +
                "autora. Więcej informacji znajdziesz na stronie domowej.";
            this.LinkLabel.UseCompatibleTextRendering = true;
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 328);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.UsunTagiButton);
            this.Controls.Add(this.BazaPobierzWszystko);
            this.Controls.Add(this.BazaPobierzWiersz);
            this.Controls.Add(this.BazaPobierzKolumneButton);
            this.Controls.Add(this.BazaPobierzRekordButton);
            this.Controls.Add(this.RejestrUstawieniaButton);
            this.Controls.Add(this.WyjatekButton);
            this.Controls.Add(this.RejestrZapiszTekstButton);
            this.Controls.Add(this.RejestrWczytajTekstButton);
            this.Controls.Add(this.DostosujButton);
            this.Controls.Add(this.OpisLabel);
            this.Controls.Add(this.DrukujButton);
            this.Controls.Add(this.PomocButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mój pierwszy moduł";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PomocButton;
        private System.Windows.Forms.Button DrukujButton;
        private System.Windows.Forms.Label OpisLabel;
        private System.Windows.Forms.Button DostosujButton;
        private System.Windows.Forms.Button RejestrWczytajTekstButton;
        private System.Windows.Forms.Button RejestrZapiszTekstButton;
        private System.Windows.Forms.Button WyjatekButton;
        private System.Windows.Forms.Button RejestrUstawieniaButton;
        private System.Windows.Forms.Button BazaPobierzRekordButton;
        private System.Windows.Forms.Button BazaPobierzKolumneButton;
        private System.Windows.Forms.Button BazaPobierzWiersz;
        private System.Windows.Forms.Button BazaPobierzWszystko;
        private System.Windows.Forms.Button UsunTagiButton;
        private System.Windows.Forms.LinkLabel LinkLabel;

    }
}

