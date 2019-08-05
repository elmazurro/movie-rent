namespace VideoWort
{
    partial class AddFilm
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
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.DirectroBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.PieceBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Copies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(162, 66);
            this.TitleBox.MaxLength = 50;
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(319, 20);
            this.TitleBox.TabIndex = 0;
            this.TitleBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TitleBox_KeyPress);
            // 
            // DirectroBox
            // 
            this.DirectroBox.Location = new System.Drawing.Point(162, 125);
            this.DirectroBox.MaxLength = 50;
            this.DirectroBox.Name = "DirectroBox";
            this.DirectroBox.Size = new System.Drawing.Size(319, 20);
            this.DirectroBox.TabIndex = 1;
            this.DirectroBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DirectroBox_KeyPress);
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(162, 186);
            this.YearBox.MaxLength = 4;
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(102, 20);
            this.YearBox.TabIndex = 2;
            this.YearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearBox_KeyPress);
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Items.AddRange(new object[] {
            "Nowosc",
            "Klasyk",
            "Oldschool"});
            this.CategoryBox.Location = new System.Drawing.Point(162, 242);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(102, 21);
            this.CategoryBox.TabIndex = 3;
            // 
            // PieceBox
            // 
            this.PieceBox.FormattingEnabled = true;
            this.PieceBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.PieceBox.Location = new System.Drawing.Point(162, 305);
            this.PieceBox.Name = "PieceBox";
            this.PieceBox.Size = new System.Drawing.Size(102, 21);
            this.PieceBox.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(162, 378);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 35);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(43, 66);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(32, 13);
            this.Title.TabIndex = 6;
            this.Title.Text = "Tytuł";
            // 
            // Director
            // 
            this.Director.AutoSize = true;
            this.Director.Location = new System.Drawing.Point(43, 125);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(45, 13);
            this.Director.TabIndex = 7;
            this.Director.Text = "Reżyser";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(43, 189);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(73, 13);
            this.Year.TabIndex = 8;
            this.Year.Text = "Rok produkcji";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(43, 245);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(52, 13);
            this.Category.TabIndex = 9;
            this.Category.Text = "Kategoria";
            // 
            // Copies
            // 
            this.Copies.AutoSize = true;
            this.Copies.Location = new System.Drawing.Point(43, 308);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(99, 13);
            this.Copies.TabIndex = 10;
            this.Copies.Text = "Liczba egzemplarzy";
            // 
            // AddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.Copies);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PieceBox);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.DirectroBox);
            this.Controls.Add(this.TitleBox);
            this.Name = "AddFilm";
            this.Text = "AddFilm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox DirectroBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.ComboBox PieceBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Director;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Copies;
    }
}