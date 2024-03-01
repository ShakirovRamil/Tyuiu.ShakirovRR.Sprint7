
namespace Tyuiu.ShakirovRR.Sprint7.Project.V7
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxMe_SRR = new System.Windows.Forms.PictureBox();
            this.labelAboout_SRR = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_SRR)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMe_SRR
            // 
            this.pictureBoxMe_SRR.Image = global::Tyuiu.ShakirovRR.Sprint7.Project.V7.Properties.Resources.me;
            this.pictureBoxMe_SRR.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMe_SRR.Name = "pictureBoxMe_SRR";
            this.pictureBoxMe_SRR.Size = new System.Drawing.Size(234, 309);
            this.pictureBoxMe_SRR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMe_SRR.TabIndex = 2;
            this.pictureBoxMe_SRR.TabStop = false;
            // 
            // labelAboout_SRR
            // 
            this.labelAboout_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAboout_SRR.AutoSize = true;
            this.labelAboout_SRR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelAboout_SRR.Location = new System.Drawing.Point(252, 12);
            this.labelAboout_SRR.Name = "labelAboout_SRR";
            this.labelAboout_SRR.Size = new System.Drawing.Size(282, 130);
            this.labelAboout_SRR.TabIndex = 3;
            this.labelAboout_SRR.Text = resources.GetString("labelAboout_SRR.Text");
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(588, 286);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(113, 35);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 336);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelAboout_SRR);
            this.Controls.Add(this.pictureBoxMe_SRR);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_SRR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMe_SRR;
        private System.Windows.Forms.Label labelAboout_SRR;
        private System.Windows.Forms.Button buttonOk;
    }
}