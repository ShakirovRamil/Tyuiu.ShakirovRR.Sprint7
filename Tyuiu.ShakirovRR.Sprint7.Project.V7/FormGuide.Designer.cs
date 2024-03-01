
namespace Tyuiu.ShakirovRR.Sprint7.Project.V7
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.groupBoxHelp_SRR = new System.Windows.Forms.GroupBox();
            this.textBoxHelp_SRR = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxHelp_SRR.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHelp_SRR
            // 
            this.groupBoxHelp_SRR.Controls.Add(this.textBoxHelp_SRR);
            this.groupBoxHelp_SRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxHelp_SRR.Location = new System.Drawing.Point(13, 13);
            this.groupBoxHelp_SRR.Name = "groupBoxHelp_SRR";
            this.groupBoxHelp_SRR.Size = new System.Drawing.Size(384, 316);
            this.groupBoxHelp_SRR.TabIndex = 2;
            this.groupBoxHelp_SRR.TabStop = false;
            this.groupBoxHelp_SRR.Text = "Функции приложения:";
            // 
            // textBoxHelp_SRR
            // 
            this.textBoxHelp_SRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHelp_SRR.Location = new System.Drawing.Point(6, 19);
            this.textBoxHelp_SRR.Multiline = true;
            this.textBoxHelp_SRR.Name = "textBoxHelp_SRR";
            this.textBoxHelp_SRR.ReadOnly = true;
            this.textBoxHelp_SRR.Size = new System.Drawing.Size(372, 291);
            this.textBoxHelp_SRR.TabIndex = 1;
            this.textBoxHelp_SRR.Text = resources.GetString("textBoxHelp_SRR.Text");
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(648, 396);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(113, 35);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 443);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxHelp_SRR);
            this.Name = "FormGuide";
            this.Text = "Справочник";
            this.groupBoxHelp_SRR.ResumeLayout(false);
            this.groupBoxHelp_SRR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHelp_SRR;
        private System.Windows.Forms.TextBox textBoxHelp_SRR;
        private System.Windows.Forms.Button buttonOk;
    }
}