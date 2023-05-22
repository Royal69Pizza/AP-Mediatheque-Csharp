namespace Mediateq_AP_SIO2
{
    partial class login
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
            this.label15 = new System.Windows.Forms.Label();
            this.textAlertEvent = new System.Windows.Forms.Label();
            this.inputMDPUser = new System.Windows.Forms.TextBox();
            this.inputLoginUser = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonConnexionUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Omega Flight Title", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(128, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "Mediateq";
            // 
            // textAlertEvent
            // 
            this.textAlertEvent.AutoSize = true;
            this.textAlertEvent.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlertEvent.ForeColor = System.Drawing.Color.White;
            this.textAlertEvent.Location = new System.Drawing.Point(14, 43);
            this.textAlertEvent.Name = "textAlertEvent";
            this.textAlertEvent.Size = new System.Drawing.Size(365, 18);
            this.textAlertEvent.TabIndex = 6;
            this.textAlertEvent.Text = "Connectez vous pour accéder à l\'application Mediateq.";
            // 
            // inputMDPUser
            // 
            this.inputMDPUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputMDPUser.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMDPUser.ForeColor = System.Drawing.Color.Cyan;
            this.inputMDPUser.Location = new System.Drawing.Point(121, 106);
            this.inputMDPUser.Name = "inputMDPUser";
            this.inputMDPUser.PasswordChar = '•';
            this.inputMDPUser.Size = new System.Drawing.Size(243, 26);
            this.inputMDPUser.TabIndex = 11;
            this.inputMDPUser.Text = "#Thunder_Legion_4543%";
            // 
            // inputLoginUser
            // 
            this.inputLoginUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputLoginUser.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLoginUser.ForeColor = System.Drawing.Color.Cyan;
            this.inputLoginUser.Location = new System.Drawing.Point(121, 74);
            this.inputLoginUser.Name = "inputLoginUser";
            this.inputLoginUser.Size = new System.Drawing.Size(243, 26);
            this.inputLoginUser.TabIndex = 10;
            this.inputLoginUser.Text = "Royal69Pizza";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(18, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 18);
            this.label16.TabIndex = 9;
            this.label16.Text = "Mot de passe";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(18, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 18);
            this.label17.TabIndex = 8;
            this.label17.Text = "Login";
            // 
            // buttonConnexionUser
            // 
            this.buttonConnexionUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonConnexionUser.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnexionUser.ForeColor = System.Drawing.Color.White;
            this.buttonConnexionUser.Location = new System.Drawing.Point(124, 147);
            this.buttonConnexionUser.Name = "buttonConnexionUser";
            this.buttonConnexionUser.Size = new System.Drawing.Size(153, 34);
            this.buttonConnexionUser.TabIndex = 19;
            this.buttonConnexionUser.Text = "Connexion";
            this.buttonConnexionUser.UseVisualStyleBackColor = false;
            this.buttonConnexionUser.Click += new System.EventHandler(this.ButtonConnexionUser_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(416, 185);
            this.Controls.Add(this.buttonConnexionUser);
            this.Controls.Add(this.inputMDPUser);
            this.Controls.Add(this.inputLoginUser);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textAlertEvent);
            this.Controls.Add(this.label15);
            this.MaximumSize = new System.Drawing.Size(434, 232);
            this.MinimumSize = new System.Drawing.Size(434, 232);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Médiateq";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label textAlertEvent;
        private System.Windows.Forms.TextBox inputMDPUser;
        private System.Windows.Forms.TextBox inputLoginUser;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonConnexionUser;
    }
}