
namespace Rechteck_Rechner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHöhe = new System.Windows.Forms.TextBox();
            this.textBoxBreite = new System.Windows.Forms.TextBox();
            this.textBoxAusgabe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Breite des Rechtecks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Höhe des Rechtecks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ausgabe (Fläche)";
            // 
            // textBoxHöhe
            // 
            this.textBoxHöhe.Location = new System.Drawing.Point(232, 57);
            this.textBoxHöhe.Name = "textBoxHöhe";
            this.textBoxHöhe.Size = new System.Drawing.Size(100, 23);
            this.textBoxHöhe.TabIndex = 3;
            // 
            // textBoxBreite
            // 
            this.textBoxBreite.Location = new System.Drawing.Point(232, 131);
            this.textBoxBreite.Name = "textBoxBreite";
            this.textBoxBreite.Size = new System.Drawing.Size(100, 23);
            this.textBoxBreite.TabIndex = 4;
            // 
            // textBoxAusgabe
            // 
            this.textBoxAusgabe.Location = new System.Drawing.Point(232, 219);
            this.textBoxAusgabe.Name = "textBoxAusgabe";
            this.textBoxAusgabe.Size = new System.Drawing.Size(100, 23);
            this.textBoxAusgabe.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Berchnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.berechnenClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Beenden";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.beendenClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 294);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAusgabe);
            this.Controls.Add(this.textBoxBreite);
            this.Controls.Add(this.textBoxHöhe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rechteck Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHöhe;
        private System.Windows.Forms.TextBox textBoxBreite;
        private System.Windows.Forms.TextBox textBoxAusgabe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

