namespace Salak_Mısın
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
            this.evt = new System.Windows.Forms.Button();
            this.hyr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // evt
            // 
            this.evt.Location = new System.Drawing.Point(26, 151);
            this.evt.Name = "evt";
            this.evt.Size = new System.Drawing.Size(75, 23);
            this.evt.TabIndex = 0;
            this.evt.Text = "evet";
            this.evt.UseVisualStyleBackColor = true;
            this.evt.Click += new System.EventHandler(this.evt_Click);
            // 
            // hyr
            // 
            this.hyr.Location = new System.Drawing.Point(247, 151);
            this.hyr.Name = "hyr";
            this.hyr.Size = new System.Drawing.Size(75, 23);
            this.hyr.TabIndex = 1;
            this.hyr.Text = "hayır";
            this.hyr.UseVisualStyleBackColor = true;
            this.hyr.MouseEnter += new System.EventHandler(this.hyr_MouseEnter);
            this.hyr.MouseHover += new System.EventHandler(this.hyr_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(126, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salak mısın?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hyr);
            this.Controls.Add(this.evt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button evt;
        private System.Windows.Forms.Button hyr;
        private System.Windows.Forms.Label label1;
    }
}

