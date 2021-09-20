namespace gestione_libreria
{
    partial class FormMain
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
            this.btnInc = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInc
            // 
            this.btnInc.Location = new System.Drawing.Point(103, 62);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(120, 69);
            this.btnInc.TabIndex = 0;
            this.btnInc.Text = "inc";
            this.btnInc.UseVisualStyleBackColor = true;
            this.btnInc.Click += new System.EventHandler(this.btnInc_Click);
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(283, 69);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(138, 62);
            this.btnDec.TabIndex = 1;
            this.btnDec.Text = "dec";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(510, 253);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnInc);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInc;
        private System.Windows.Forms.Button btnDec;
    }
}