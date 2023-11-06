namespace Biblioteka_AS
{
    partial class Korisnici
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
            this.ispisKorisnicitxt = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.osvjezibtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ispisKorisnicitxt
            // 
            this.ispisKorisnicitxt.Location = new System.Drawing.Point(12, 70);
            this.ispisKorisnicitxt.Name = "ispisKorisnicitxt";
            this.ispisKorisnicitxt.Size = new System.Drawing.Size(776, 368);
            this.ispisKorisnicitxt.TabIndex = 0;
            this.ispisKorisnicitxt.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ime",
            "Prezime",
            "Dob"});
            this.comboBox1.Location = new System.Drawing.Point(75, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sortiraj po:";
            // 
            // osvjezibtn
            // 
            this.osvjezibtn.Location = new System.Drawing.Point(229, 41);
            this.osvjezibtn.Name = "osvjezibtn";
            this.osvjezibtn.Size = new System.Drawing.Size(75, 23);
            this.osvjezibtn.TabIndex = 3;
            this.osvjezibtn.Text = "Osvježi";
            this.osvjezibtn.UseVisualStyleBackColor = true;
            // 
            // Korisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.osvjezibtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ispisKorisnicitxt);
            this.Name = "Korisnici";
            this.Text = "Korisnici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ispisKorisnicitxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button osvjezibtn;
    }
}