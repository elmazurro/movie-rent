namespace VideoWort
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filmyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaFilmówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajFilmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKlientaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wypożyczeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaWypożyczeńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wypożyczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oddanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmyToolStripMenuItem,
            this.dodajKlientaToolStripMenuItem,
            this.wypożyczeniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmyToolStripMenuItem
            // 
            this.filmyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaFilmówToolStripMenuItem,
            this.dodajFilmToolStripMenuItem1});
            this.filmyToolStripMenuItem.Name = "filmyToolStripMenuItem";
            this.filmyToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.filmyToolStripMenuItem.Text = "Filmy";
            // 
            // listaFilmówToolStripMenuItem
            // 
            this.listaFilmówToolStripMenuItem.Name = "listaFilmówToolStripMenuItem";
            this.listaFilmówToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.listaFilmówToolStripMenuItem.Text = "Lista Filmów";
            this.listaFilmówToolStripMenuItem.Click += new System.EventHandler(this.listaFilmówToolStripMenuItem_Click);
            // 
            // dodajFilmToolStripMenuItem1
            // 
            this.dodajFilmToolStripMenuItem1.Name = "dodajFilmToolStripMenuItem1";
            this.dodajFilmToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.dodajFilmToolStripMenuItem1.Text = "Dodaj film";
            this.dodajFilmToolStripMenuItem1.Click += new System.EventHandler(this.dodajFilmToolStripMenuItem1_Click);
            // 
            // dodajKlientaToolStripMenuItem
            // 
            this.dodajKlientaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajFilmToolStripMenuItem,
            this.dodajKlientaToolStripMenuItem1,
            this.edytujKlientaToolStripMenuItem});
            this.dodajKlientaToolStripMenuItem.Name = "dodajKlientaToolStripMenuItem";
            this.dodajKlientaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.dodajKlientaToolStripMenuItem.Text = "Klienci";
            // 
            // dodajFilmToolStripMenuItem
            // 
            this.dodajFilmToolStripMenuItem.Name = "dodajFilmToolStripMenuItem";
            this.dodajFilmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajFilmToolStripMenuItem.Text = "Lista klientów";
            this.dodajFilmToolStripMenuItem.Click += new System.EventHandler(this.dodajFilmToolStripMenuItem_Click);
            // 
            // dodajKlientaToolStripMenuItem1
            // 
            this.dodajKlientaToolStripMenuItem1.Name = "dodajKlientaToolStripMenuItem1";
            this.dodajKlientaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dodajKlientaToolStripMenuItem1.Text = "Dodaj klienta";
            this.dodajKlientaToolStripMenuItem1.Click += new System.EventHandler(this.dodajKlientaToolStripMenuItem1_Click);
            // 
            // edytujKlientaToolStripMenuItem
            // 
            this.edytujKlientaToolStripMenuItem.Name = "edytujKlientaToolStripMenuItem";
            this.edytujKlientaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.edytujKlientaToolStripMenuItem.Text = "Edytuj klienta";
            this.edytujKlientaToolStripMenuItem.Click += new System.EventHandler(this.edytujKlientaToolStripMenuItem_Click);
            // 
            // wypożyczeniaToolStripMenuItem
            // 
            this.wypożyczeniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaWypożyczeńToolStripMenuItem,
            this.wypożyczToolStripMenuItem,
            this.oddanieToolStripMenuItem});
            this.wypożyczeniaToolStripMenuItem.Name = "wypożyczeniaToolStripMenuItem";
            this.wypożyczeniaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.wypożyczeniaToolStripMenuItem.Text = "Wypożyczenia";
            // 
            // listaWypożyczeńToolStripMenuItem
            // 
            this.listaWypożyczeńToolStripMenuItem.Name = "listaWypożyczeńToolStripMenuItem";
            this.listaWypożyczeńToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaWypożyczeńToolStripMenuItem.Text = "Lista wypożyczeń";
            this.listaWypożyczeńToolStripMenuItem.Click += new System.EventHandler(this.listaWypożyczeńToolStripMenuItem_Click);
            // 
            // wypożyczToolStripMenuItem
            // 
            this.wypożyczToolStripMenuItem.Name = "wypożyczToolStripMenuItem";
            this.wypożyczToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wypożyczToolStripMenuItem.Text = "Wypożycz";
            this.wypożyczToolStripMenuItem.Click += new System.EventHandler(this.wypożyczToolStripMenuItem_Click);
            // 
            // oddanieToolStripMenuItem
            // 
            this.oddanieToolStripMenuItem.Name = "oddanieToolStripMenuItem";
            this.oddanieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oddanieToolStripMenuItem.Text = "Oddanie";
            this.oddanieToolStripMenuItem.Click += new System.EventHandler(this.oddanieToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 55);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(729, 316);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajKlientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmyToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem listaFilmówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKlientaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem edytujKlientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajFilmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wypożyczeniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaWypożyczeńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wypożyczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oddanieToolStripMenuItem;
    }
}

