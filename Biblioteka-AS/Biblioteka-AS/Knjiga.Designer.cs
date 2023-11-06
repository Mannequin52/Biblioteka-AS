namespace Biblioteka_AS
{
    partial class Knjiga
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
            this.autorimetxt = new System.Windows.Forms.TextBox();
            this.nazivknjigetxt = new System.Windows.Forms.RichTextBox();
            this.autorprezimetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isbntxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.izdavactxt = new System.Windows.Forms.TextBox();
            this.godinatxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.unesiknjigubtn = new System.Windows.Forms.Button();
            this.odustaniknjigabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // autorimetxt
            // 
            this.autorimetxt.Location = new System.Drawing.Point(43, 36);
            this.autorimetxt.Name = "autorimetxt";
            this.autorimetxt.Size = new System.Drawing.Size(100, 20);
            this.autorimetxt.TabIndex = 0;
            // 
            // nazivknjigetxt
            // 
            this.nazivknjigetxt.Location = new System.Drawing.Point(43, 92);
            this.nazivknjigetxt.Name = "nazivknjigetxt";
            this.nazivknjigetxt.Size = new System.Drawing.Size(206, 96);
            this.nazivknjigetxt.TabIndex = 1;
            this.nazivknjigetxt.Text = "";
            // 
            // autorprezimetxt
            // 
            this.autorprezimetxt.Location = new System.Drawing.Point(149, 36);
            this.autorprezimetxt.Name = "autorprezimetxt";
            this.autorprezimetxt.Size = new System.Drawing.Size(100, 20);
            this.autorprezimetxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Autor ime i prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv knjige:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ISBN:";
            // 
            // isbntxt
            // 
            this.isbntxt.Location = new System.Drawing.Point(43, 221);
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(100, 20);
            this.isbntxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Izdavač:";
            // 
            // izdavactxt
            // 
            this.izdavactxt.Location = new System.Drawing.Point(43, 282);
            this.izdavactxt.Name = "izdavactxt";
            this.izdavactxt.Size = new System.Drawing.Size(100, 20);
            this.izdavactxt.TabIndex = 8;
            // 
            // godinatxt
            // 
            this.godinatxt.Location = new System.Drawing.Point(43, 332);
            this.godinatxt.Name = "godinatxt";
            this.godinatxt.Size = new System.Drawing.Size(100, 20);
            this.godinatxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Godina:";
            // 
            // unesiknjigubtn
            // 
            this.unesiknjigubtn.Location = new System.Drawing.Point(46, 396);
            this.unesiknjigubtn.Name = "unesiknjigubtn";
            this.unesiknjigubtn.Size = new System.Drawing.Size(97, 34);
            this.unesiknjigubtn.TabIndex = 11;
            this.unesiknjigubtn.Text = "Unesi";
            this.unesiknjigubtn.UseVisualStyleBackColor = true;
            // 
            // odustaniknjigabtn
            // 
            this.odustaniknjigabtn.Location = new System.Drawing.Point(152, 396);
            this.odustaniknjigabtn.Name = "odustaniknjigabtn";
            this.odustaniknjigabtn.Size = new System.Drawing.Size(97, 34);
            this.odustaniknjigabtn.TabIndex = 12;
            this.odustaniknjigabtn.Text = "Odustani";
            this.odustaniknjigabtn.UseVisualStyleBackColor = true;
            // 
            // Knjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.odustaniknjigabtn);
            this.Controls.Add(this.unesiknjigubtn);
            this.Controls.Add(this.godinatxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.izdavactxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.isbntxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autorprezimetxt);
            this.Controls.Add(this.nazivknjigetxt);
            this.Controls.Add(this.autorimetxt);
            this.Name = "Knjiga";
            this.Text = "Knjiga";
            this.Load += new System.EventHandler(this.Knjiga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox autorimetxt;
        private System.Windows.Forms.RichTextBox nazivknjigetxt;
        private System.Windows.Forms.TextBox autorprezimetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isbntxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox izdavactxt;
        private System.Windows.Forms.TextBox godinatxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button unesiknjigubtn;
        private System.Windows.Forms.Button odustaniknjigabtn;
    }
}