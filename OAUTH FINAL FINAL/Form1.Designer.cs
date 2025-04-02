namespace OAUTH_FINAL_FINAL
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
            this.GoogleSign_BTN = new System.Windows.Forms.Button();
            this.SignOut_BTN = new System.Windows.Forms.Button();
            this.UserProfile_PB = new System.Windows.Forms.PictureBox();
            this.Status_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfile_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // GoogleSign_BTN
            // 
            this.GoogleSign_BTN.Location = new System.Drawing.Point(303, 373);
            this.GoogleSign_BTN.Name = "GoogleSign_BTN";
            this.GoogleSign_BTN.Size = new System.Drawing.Size(164, 55);
            this.GoogleSign_BTN.TabIndex = 0;
            this.GoogleSign_BTN.Text = "Google Sign In";
            this.GoogleSign_BTN.UseVisualStyleBackColor = true;
            this.GoogleSign_BTN.Click += new System.EventHandler(this.GoogleSign_BTN_Click);
            // 
            // SignOut_BTN
            // 
            this.SignOut_BTN.Location = new System.Drawing.Point(303, 374);
            this.SignOut_BTN.Name = "SignOut_BTN";
            this.SignOut_BTN.Size = new System.Drawing.Size(164, 54);
            this.SignOut_BTN.TabIndex = 1;
            this.SignOut_BTN.Text = "Sign Out";
            this.SignOut_BTN.UseVisualStyleBackColor = true;
            this.SignOut_BTN.Visible = false;
            this.SignOut_BTN.Click += new System.EventHandler(this.SignOut_BTN_Click);
            // 
            // UserProfile_PB
            // 
            this.UserProfile_PB.Location = new System.Drawing.Point(303, 34);
            this.UserProfile_PB.Name = "UserProfile_PB";
            this.UserProfile_PB.Size = new System.Drawing.Size(164, 124);
            this.UserProfile_PB.TabIndex = 2;
            this.UserProfile_PB.TabStop = false;
            this.UserProfile_PB.Click += new System.EventHandler(this.UserProfile_PB_Click);
            // 
            // Status_lb
            // 
            this.Status_lb.AutoSize = true;
            this.Status_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_lb.Location = new System.Drawing.Point(221, 224);
            this.Status_lb.Name = "Status_lb";
            this.Status_lb.Size = new System.Drawing.Size(320, 52);
            this.Status_lb.TabIndex = 3;
            this.Status_lb.Text = "Not Logged In ";
            this.Status_lb.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.Status_lb);
            this.Controls.Add(this.UserProfile_PB);
            this.Controls.Add(this.SignOut_BTN);
            this.Controls.Add(this.GoogleSign_BTN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UserProfile_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoogleSign_BTN;
        private System.Windows.Forms.Button SignOut_BTN;
        private System.Windows.Forms.PictureBox UserProfile_PB;
        private System.Windows.Forms.Label Status_lb;
    }
}

