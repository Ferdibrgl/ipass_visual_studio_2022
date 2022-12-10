namespace iPass
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_generatepass = new System.Windows.Forms.Button();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.trckbar_length = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_passlength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trckbar_length)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_generatepass
            // 
            this.btn_generatepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generatepass.Location = new System.Drawing.Point(103, 88);
            this.btn_generatepass.Name = "btn_generatepass";
            this.btn_generatepass.Size = new System.Drawing.Size(155, 31);
            this.btn_generatepass.TabIndex = 0;
            this.btn_generatepass.Text = "Generate a password";
            this.btn_generatepass.UseVisualStyleBackColor = true;
            this.btn_generatepass.Click += new System.EventHandler(this.btn_generatepass_Click);
            // 
            // txb_password
            // 
            this.txb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_password.Location = new System.Drawing.Point(54, 125);
            this.txb_password.Multiline = true;
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(263, 30);
            this.txb_password.TabIndex = 1;
            // 
            // trckbar_length
            // 
            this.trckbar_length.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trckbar_length.Location = new System.Drawing.Point(50, 37);
            this.trckbar_length.Maximum = 19;
            this.trckbar_length.Name = "trckbar_length";
            this.trckbar_length.Size = new System.Drawing.Size(263, 45);
            this.trckbar_length.TabIndex = 2;
            this.trckbar_length.ValueChanged += new System.EventHandler(this.trckbar_length_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Passwords length :";
            // 
            // lbl_passlength
            // 
            this.lbl_passlength.AutoSize = true;
            this.lbl_passlength.Location = new System.Drawing.Point(149, 21);
            this.lbl_passlength.Name = "lbl_passlength";
            this.lbl_passlength.Size = new System.Drawing.Size(13, 13);
            this.lbl_passlength.TabIndex = 4;
            this.lbl_passlength.Text = "1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 176);
            this.Controls.Add(this.lbl_passlength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trckbar_length);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.btn_generatepass);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iPass - Simple password generator";
            ((System.ComponentModel.ISupportInitialize)(this.trckbar_length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generatepass;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.TrackBar trckbar_length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_passlength;
    }
}

