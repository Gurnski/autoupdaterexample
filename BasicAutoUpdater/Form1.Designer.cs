namespace BasicAutoUpdater
{
    partial class autoUpdateForm
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
            this.clientVersionLabel = new System.Windows.Forms.Label();
            this.serverVersionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientVersionLabel
            // 
            this.clientVersionLabel.AutoSize = true;
            this.clientVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientVersionLabel.Location = new System.Drawing.Point(265, 62);
            this.clientVersionLabel.Name = "clientVersionLabel";
            this.clientVersionLabel.Size = new System.Drawing.Size(200, 32);
            this.clientVersionLabel.TabIndex = 0;
            this.clientVersionLabel.Text = "Client Version:";
            // 
            // serverVersionLabel
            // 
            this.serverVersionLabel.AutoSize = true;
            this.serverVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverVersionLabel.Location = new System.Drawing.Point(265, 139);
            this.serverVersionLabel.Name = "serverVersionLabel";
            this.serverVersionLabel.Size = new System.Drawing.Size(209, 32);
            this.serverVersionLabel.TabIndex = 1;
            this.serverVersionLabel.Text = "Server Version:";
            // 
            // autoUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serverVersionLabel);
            this.Controls.Add(this.clientVersionLabel);
            this.Name = "autoUpdateForm";
            this.Text = "Basic Autoupdater example";
            this.Load += new System.EventHandler(this.autoUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientVersionLabel;
        private System.Windows.Forms.Label serverVersionLabel;
    }
}

