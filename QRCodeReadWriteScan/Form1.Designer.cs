namespace QRCodeReadWriteScan
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
            this.Decodebtn = new System.Windows.Forms.Button();
            this.Encodebtn = new System.Windows.Forms.Button();
            this.DecodeTxt = new System.Windows.Forms.TextBox();
            this.EncodeTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BarcodePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePic)).BeginInit();
            this.SuspendLayout();
            // 
            // Decodebtn
            // 
            this.Decodebtn.Location = new System.Drawing.Point(372, 372);
            this.Decodebtn.Name = "Decodebtn";
            this.Decodebtn.Size = new System.Drawing.Size(75, 23);
            this.Decodebtn.TabIndex = 15;
            this.Decodebtn.Text = "Decode";
            this.Decodebtn.UseVisualStyleBackColor = true;
            this.Decodebtn.Click += new System.EventHandler(this.Decodebtn_Click);
            // 
            // Encodebtn
            // 
            this.Encodebtn.Location = new System.Drawing.Point(264, 372);
            this.Encodebtn.Name = "Encodebtn";
            this.Encodebtn.Size = new System.Drawing.Size(75, 23);
            this.Encodebtn.TabIndex = 14;
            this.Encodebtn.Text = "Encode";
            this.Encodebtn.UseVisualStyleBackColor = true;
            this.Encodebtn.Click += new System.EventHandler(this.Encodebtn_Click);
            // 
            // DecodeTxt
            // 
            this.DecodeTxt.Location = new System.Drawing.Point(227, 306);
            this.DecodeTxt.Name = "DecodeTxt";
            this.DecodeTxt.Size = new System.Drawing.Size(280, 20);
            this.DecodeTxt.TabIndex = 13;
            // 
            // EncodeTxt
            // 
            this.EncodeTxt.Location = new System.Drawing.Point(227, 261);
            this.EncodeTxt.Name = "EncodeTxt";
            this.EncodeTxt.Size = new System.Drawing.Size(280, 20);
            this.EncodeTxt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Decode QRcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Encode QRcode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "QRcode Generator";
            // 
            // BarcodePic
            // 
            this.BarcodePic.Location = new System.Drawing.Point(131, 88);
            this.BarcodePic.Name = "BarcodePic";
            this.BarcodePic.Size = new System.Drawing.Size(376, 120);
            this.BarcodePic.TabIndex = 8;
            this.BarcodePic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Decodebtn);
            this.Controls.Add(this.Encodebtn);
            this.Controls.Add(this.DecodeTxt);
            this.Controls.Add(this.EncodeTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarcodePic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Decodebtn;
        private System.Windows.Forms.Button Encodebtn;
        private System.Windows.Forms.TextBox DecodeTxt;
        private System.Windows.Forms.TextBox EncodeTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BarcodePic;
    }
}

