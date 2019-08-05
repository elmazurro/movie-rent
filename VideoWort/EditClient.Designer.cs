namespace VideoWort
{
    partial class EditClient
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
            this.Peselbox = new System.Windows.Forms.TextBox();
            this.FirstNametextbox = new System.Windows.Forms.TextBox();
            this.SurrNametextbox = new System.Windows.Forms.TextBox();
            this.Addresbox = new System.Windows.Forms.TextBox();
            this.Phonebox = new System.Windows.Forms.TextBox();
            this.AcceptEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(70, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesel klienta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imie po edycji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko po edycji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres po edycji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon po edycji";
            // 
            // Peselbox
            // 
            this.Peselbox.Location = new System.Drawing.Point(220, 50);
            this.Peselbox.MaxLength = 11;
            this.Peselbox.Name = "Peselbox";
            this.Peselbox.ShortcutsEnabled = false;
            this.Peselbox.Size = new System.Drawing.Size(184, 20);
            this.Peselbox.TabIndex = 5;
            this.Peselbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Peselbox_KeyPress);
            // 
            // FirstNametextbox
            // 
            this.FirstNametextbox.Location = new System.Drawing.Point(220, 152);
            this.FirstNametextbox.MaxLength = 25;
            this.FirstNametextbox.Name = "FirstNametextbox";
            this.FirstNametextbox.ShortcutsEnabled = false;
            this.FirstNametextbox.Size = new System.Drawing.Size(235, 20);
            this.FirstNametextbox.TabIndex = 6;
            this.FirstNametextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNametextbox_KeyPress);
            // 
            // SurrNametextbox
            // 
            this.SurrNametextbox.Location = new System.Drawing.Point(220, 200);
            this.SurrNametextbox.MaxLength = 25;
            this.SurrNametextbox.Name = "SurrNametextbox";
            this.SurrNametextbox.ShortcutsEnabled = false;
            this.SurrNametextbox.Size = new System.Drawing.Size(235, 20);
            this.SurrNametextbox.TabIndex = 7;
            this.SurrNametextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurrNametextbox_KeyPress);
            // 
            // Addresbox
            // 
            this.Addresbox.Location = new System.Drawing.Point(220, 261);
            this.Addresbox.MaxLength = 50;
            this.Addresbox.Name = "Addresbox";
            this.Addresbox.ShortcutsEnabled = false;
            this.Addresbox.Size = new System.Drawing.Size(235, 20);
            this.Addresbox.TabIndex = 8;
            this.Addresbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Addresbox_KeyPress);
            // 
            // Phonebox
            // 
            this.Phonebox.Location = new System.Drawing.Point(220, 317);
            this.Phonebox.MaxLength = 16;
            this.Phonebox.Name = "Phonebox";
            this.Phonebox.ShortcutsEnabled = false;
            this.Phonebox.Size = new System.Drawing.Size(235, 20);
            this.Phonebox.TabIndex = 9;
            this.Phonebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phonebox_KeyPress);
            // 
            // AcceptEdit
            // 
            this.AcceptEdit.Location = new System.Drawing.Point(259, 385);
            this.AcceptEdit.Name = "AcceptEdit";
            this.AcceptEdit.Size = new System.Drawing.Size(196, 62);
            this.AcceptEdit.TabIndex = 10;
            this.AcceptEdit.Text = "Potwierdz edycje";
            this.AcceptEdit.UseVisualStyleBackColor = true;
            this.AcceptEdit.Click += new System.EventHandler(this.AcceptEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(70, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wszystkie dane muszą zostać uzupełnione";
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 476);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AcceptEdit);
            this.Controls.Add(this.Phonebox);
            this.Controls.Add(this.Addresbox);
            this.Controls.Add(this.SurrNametextbox);
            this.Controls.Add(this.FirstNametextbox);
            this.Controls.Add(this.Peselbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditClient";
            this.Text = "EditClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Peselbox;
        private System.Windows.Forms.TextBox FirstNametextbox;
        private System.Windows.Forms.TextBox SurrNametextbox;
        private System.Windows.Forms.TextBox Addresbox;
        private System.Windows.Forms.TextBox Phonebox;
        private System.Windows.Forms.Button AcceptEdit;
        private System.Windows.Forms.Label label6;
    }
}