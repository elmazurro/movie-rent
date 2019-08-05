namespace VideoWort
{
    partial class AddClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstNametextbox = new System.Windows.Forms.TextBox();
            this.SurrNametextbox = new System.Windows.Forms.TextBox();
            this.Peselbox = new System.Windows.Forms.TextBox();
            this.Addresbox = new System.Windows.Forms.TextBox();
            this.Phonebox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pesel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon";
            // 
            // FirstNametextbox
            // 
            this.FirstNametextbox.Location = new System.Drawing.Point(380, 60);
            this.FirstNametextbox.MaxLength = 25;
            this.FirstNametextbox.Name = "FirstNametextbox";
            this.FirstNametextbox.ShortcutsEnabled = false;
            this.FirstNametextbox.Size = new System.Drawing.Size(100, 20);
            this.FirstNametextbox.TabIndex = 5;
            this.FirstNametextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNametextbox_KeyPress);
            // 
            // SurrNametextbox
            // 
            this.SurrNametextbox.Location = new System.Drawing.Point(380, 122);
            this.SurrNametextbox.MaxLength = 25;
            this.SurrNametextbox.Name = "SurrNametextbox";
            this.SurrNametextbox.ShortcutsEnabled = false;
            this.SurrNametextbox.Size = new System.Drawing.Size(100, 20);
            this.SurrNametextbox.TabIndex = 6;
            this.SurrNametextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurrNametextbox_KeyPress);
            // 
            // Peselbox
            // 
            this.Peselbox.Location = new System.Drawing.Point(380, 191);
            this.Peselbox.MaxLength = 11;
            this.Peselbox.Name = "Peselbox";
            this.Peselbox.ShortcutsEnabled = false;
            this.Peselbox.Size = new System.Drawing.Size(100, 20);
            this.Peselbox.TabIndex = 11;
            this.Peselbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Peselbox_KeyPress);
            // 
            // Addresbox
            // 
            this.Addresbox.Location = new System.Drawing.Point(380, 255);
            this.Addresbox.MaxLength = 50;
            this.Addresbox.Name = "Addresbox";
            this.Addresbox.Size = new System.Drawing.Size(100, 20);
            this.Addresbox.TabIndex = 8;
            // 
            // Phonebox
            // 
            this.Phonebox.Location = new System.Drawing.Point(380, 316);
            this.Phonebox.MaxLength = 16;
            this.Phonebox.Name = "Phonebox";
            this.Phonebox.ShortcutsEnabled = false;
            this.Phonebox.Size = new System.Drawing.Size(100, 20);
            this.Phonebox.TabIndex = 9;
            this.Phonebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phonebox_KeyPress);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(369, 393);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Phonebox);
            this.Controls.Add(this.Addresbox);
            this.Controls.Add(this.Peselbox);
            this.Controls.Add(this.SurrNametextbox);
            this.Controls.Add(this.FirstNametextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstNametextbox;
        private System.Windows.Forms.TextBox SurrNametextbox;
        private System.Windows.Forms.TextBox Peselbox;
        private System.Windows.Forms.TextBox Addresbox;
        private System.Windows.Forms.TextBox Phonebox;
        private System.Windows.Forms.Button AddButton;
    }
}