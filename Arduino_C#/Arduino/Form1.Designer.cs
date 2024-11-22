namespace Arduino
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
            this.BtnCon = new System.Windows.Forms.Button();
            this.BtnDiscon = new System.Windows.Forms.Button();
            this.txtAlgo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCon
            // 
            this.BtnCon.Location = new System.Drawing.Point(29, 203);
            this.BtnCon.Name = "BtnCon";
            this.BtnCon.Size = new System.Drawing.Size(75, 23);
            this.BtnCon.TabIndex = 0;
            this.BtnCon.Text = "Conectar";
            this.BtnCon.UseVisualStyleBackColor = true;
            this.BtnCon.Click += new System.EventHandler(this.BtnCon_Click);
            // 
            // BtnDiscon
            // 
            this.BtnDiscon.Location = new System.Drawing.Point(156, 203);
            this.BtnDiscon.Name = "BtnDiscon";
            this.BtnDiscon.Size = new System.Drawing.Size(93, 23);
            this.BtnDiscon.TabIndex = 1;
            this.BtnDiscon.Text = "Desconectar";
            this.BtnDiscon.UseVisualStyleBackColor = true;
            this.BtnDiscon.Click += new System.EventHandler(this.BtnDiscon_Click);
            // 
            // txtAlgo
            // 
            this.txtAlgo.Location = new System.Drawing.Point(29, 120);
            this.txtAlgo.Name = "txtAlgo";
            this.txtAlgo.Size = new System.Drawing.Size(220, 20);
            this.txtAlgo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 262);
            this.Controls.Add(this.txtAlgo);
            this.Controls.Add(this.BtnDiscon);
            this.Controls.Add(this.BtnCon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConnection_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCon;
        private System.Windows.Forms.Button BtnDiscon;
        private System.Windows.Forms.TextBox txtAlgo;
    }
}

