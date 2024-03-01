
namespace Tyuiu.ShakirovRR.Sprint7.Project.V7
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
            this.groupBoxReg_SRR = new System.Windows.Forms.GroupBox();
            this.buttonSaveFile_SRR = new System.Windows.Forms.Button();
            this.labelSumRoom_SRR = new System.Windows.Forms.Label();
            this.labelAddFlat_SRR = new System.Windows.Forms.Label();
            this.labelFlatArea_SRR = new System.Windows.Forms.Label();
            this.labelSumPeople_SRR = new System.Windows.Forms.Label();
            this.labelAddEntrance_SRR = new System.Windows.Forms.Label();
            this.labelFIO_SRR = new System.Windows.Forms.Label();
            this.textBoxSumRoom_SRR = new System.Windows.Forms.TextBox();
            this.textBoxAddFlat_SRR = new System.Windows.Forms.TextBox();
            this.textBoxSumPeople_SRR = new System.Windows.Forms.TextBox();
            this.textBoxFlatArea_SRR = new System.Windows.Forms.TextBox();
            this.textBoxAddEntrance_SRR = new System.Windows.Forms.TextBox();
            this.textBoxFIO_SRR = new System.Windows.Forms.TextBox();
            this.buttonAbout_SRR = new System.Windows.Forms.Button();
            this.buttonHelp_SRR = new System.Windows.Forms.Button();
            this.groupBoxDeletePeople_SRR = new System.Windows.Forms.GroupBox();
            this.labelDeleteEntrance_SRR = new System.Windows.Forms.Label();
            this.labelDeleteFlat_SRR = new System.Windows.Forms.Label();
            this.buttonDeletePeople_SRR = new System.Windows.Forms.Button();
            this.textBoxDeleteEntrance_SRR = new System.Windows.Forms.TextBox();
            this.textBoxDeleteFlat_SRR = new System.Windows.Forms.TextBox();
            this.groupBoxInfo_SRR = new System.Windows.Forms.GroupBox();
            this.dataGridViewInfo_SRR = new System.Windows.Forms.DataGridView();
            this.groupBoxReg_SRR.SuspendLayout();
            this.groupBoxDeletePeople_SRR.SuspendLayout();
            this.groupBoxInfo_SRR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo_SRR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxReg_SRR
            // 
            this.groupBoxReg_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxReg_SRR.Controls.Add(this.buttonSaveFile_SRR);
            this.groupBoxReg_SRR.Controls.Add(this.labelSumRoom_SRR);
            this.groupBoxReg_SRR.Controls.Add(this.labelAddFlat_SRR);
            this.groupBoxReg_SRR.Controls.Add(this.labelFlatArea_SRR);
            this.groupBoxReg_SRR.Controls.Add(this.labelSumPeople_SRR);
            this.groupBoxReg_SRR.Controls.Add(this.labelAddEntrance_SRR);
            this.groupBoxReg_SRR.Controls.Add(this.labelFIO_SRR);
            this.groupBoxReg_SRR.Controls.Add(this.textBoxSumRoom_SRR);
            this.groupBoxReg_SRR.Controls.Add(this.textBoxAddFlat_SRR);
            this.groupBoxReg_SRR.Controls.Add(this.textBoxSumPeople_SRR);
            this.groupBoxReg_SRR.Controls.Add(this.textBoxFlatArea_SRR);
            this.groupBoxReg_SRR.Controls.Add(this.textBoxAddEntrance_SRR);
            this.groupBoxReg_SRR.Controls.Add(this.textBoxFIO_SRR);
            this.groupBoxReg_SRR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxReg_SRR.Name = "groupBoxReg_SRR";
            this.groupBoxReg_SRR.Size = new System.Drawing.Size(265, 604);
            this.groupBoxReg_SRR.TabIndex = 3;
            this.groupBoxReg_SRR.TabStop = false;
            this.groupBoxReg_SRR.Text = "Регистрация новых жильцов:";
            // 
            // buttonSaveFile_SRR
            // 
            this.buttonSaveFile_SRR.Location = new System.Drawing.Point(6, 269);
            this.buttonSaveFile_SRR.Name = "buttonSaveFile_SRR";
            this.buttonSaveFile_SRR.Size = new System.Drawing.Size(75, 66);
            this.buttonSaveFile_SRR.TabIndex = 3;
            this.buttonSaveFile_SRR.Text = "Добавить";
            this.buttonSaveFile_SRR.UseVisualStyleBackColor = true;
            this.buttonSaveFile_SRR.Click += new System.EventHandler(this.buttonSaveFile_SRR_Click);
            // 
            // labelSumRoom_SRR
            // 
            this.labelSumRoom_SRR.AutoSize = true;
            this.labelSumRoom_SRR.Location = new System.Drawing.Point(7, 188);
            this.labelSumRoom_SRR.Name = "labelSumRoom_SRR";
            this.labelSumRoom_SRR.Size = new System.Drawing.Size(143, 13);
            this.labelSumRoom_SRR.TabIndex = 1;
            this.labelSumRoom_SRR.Text = "Кол-во комнат в квартире:";
            // 
            // labelAddFlat_SRR
            // 
            this.labelAddFlat_SRR.AutoSize = true;
            this.labelAddFlat_SRR.Location = new System.Drawing.Point(7, 106);
            this.labelAddFlat_SRR.Name = "labelAddFlat_SRR";
            this.labelAddFlat_SRR.Size = new System.Drawing.Size(96, 13);
            this.labelAddFlat_SRR.TabIndex = 1;
            this.labelAddFlat_SRR.Text = "Номер квартиры:";
            // 
            // labelFlatArea_SRR
            // 
            this.labelFlatArea_SRR.AutoSize = true;
            this.labelFlatArea_SRR.Location = new System.Drawing.Point(7, 149);
            this.labelFlatArea_SRR.Name = "labelFlatArea_SRR";
            this.labelFlatArea_SRR.Size = new System.Drawing.Size(76, 13);
            this.labelFlatArea_SRR.TabIndex = 1;
            this.labelFlatArea_SRR.Text = "Кол-во кв. м.:";
            // 
            // labelSumPeople_SRR
            // 
            this.labelSumPeople_SRR.AutoSize = true;
            this.labelSumPeople_SRR.Location = new System.Drawing.Point(7, 227);
            this.labelSumPeople_SRR.Name = "labelSumPeople_SRR";
            this.labelSumPeople_SRR.Size = new System.Drawing.Size(123, 13);
            this.labelSumPeople_SRR.TabIndex = 1;
            this.labelSumPeople_SRR.Text = "Кол-во заселяющихся:";
            // 
            // labelAddEntrance_SRR
            // 
            this.labelAddEntrance_SRR.AutoSize = true;
            this.labelAddEntrance_SRR.Location = new System.Drawing.Point(7, 63);
            this.labelAddEntrance_SRR.Name = "labelAddEntrance_SRR";
            this.labelAddEntrance_SRR.Size = new System.Drawing.Size(96, 13);
            this.labelAddEntrance_SRR.TabIndex = 1;
            this.labelAddEntrance_SRR.Text = "Номер подъезда:";
            // 
            // labelFIO_SRR
            // 
            this.labelFIO_SRR.AutoSize = true;
            this.labelFIO_SRR.Location = new System.Drawing.Point(7, 20);
            this.labelFIO_SRR.Name = "labelFIO_SRR";
            this.labelFIO_SRR.Size = new System.Drawing.Size(122, 13);
            this.labelFIO_SRR.TabIndex = 1;
            this.labelFIO_SRR.Text = "ФИО заселяющегося:";
            // 
            // textBoxSumRoom_SRR
            // 
            this.textBoxSumRoom_SRR.Location = new System.Drawing.Point(10, 204);
            this.textBoxSumRoom_SRR.Name = "textBoxSumRoom_SRR";
            this.textBoxSumRoom_SRR.Size = new System.Drawing.Size(165, 20);
            this.textBoxSumRoom_SRR.TabIndex = 0;
            // 
            // textBoxAddFlat_SRR
            // 
            this.textBoxAddFlat_SRR.Location = new System.Drawing.Point(10, 126);
            this.textBoxAddFlat_SRR.Name = "textBoxAddFlat_SRR";
            this.textBoxAddFlat_SRR.Size = new System.Drawing.Size(165, 20);
            this.textBoxAddFlat_SRR.TabIndex = 0;
            // 
            // textBoxSumPeople_SRR
            // 
            this.textBoxSumPeople_SRR.Location = new System.Drawing.Point(6, 243);
            this.textBoxSumPeople_SRR.Name = "textBoxSumPeople_SRR";
            this.textBoxSumPeople_SRR.Size = new System.Drawing.Size(169, 20);
            this.textBoxSumPeople_SRR.TabIndex = 0;
            // 
            // textBoxFlatArea_SRR
            // 
            this.textBoxFlatArea_SRR.Location = new System.Drawing.Point(10, 165);
            this.textBoxFlatArea_SRR.Name = "textBoxFlatArea_SRR";
            this.textBoxFlatArea_SRR.Size = new System.Drawing.Size(165, 20);
            this.textBoxFlatArea_SRR.TabIndex = 0;
            // 
            // textBoxAddEntrance_SRR
            // 
            this.textBoxAddEntrance_SRR.Location = new System.Drawing.Point(10, 83);
            this.textBoxAddEntrance_SRR.Name = "textBoxAddEntrance_SRR";
            this.textBoxAddEntrance_SRR.Size = new System.Drawing.Size(165, 20);
            this.textBoxAddEntrance_SRR.TabIndex = 0;
            // 
            // textBoxFIO_SRR
            // 
            this.textBoxFIO_SRR.Location = new System.Drawing.Point(6, 40);
            this.textBoxFIO_SRR.Name = "textBoxFIO_SRR";
            this.textBoxFIO_SRR.Size = new System.Drawing.Size(169, 20);
            this.textBoxFIO_SRR.TabIndex = 0;
            // 
            // buttonAbout_SRR
            // 
            this.buttonAbout_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAbout_SRR.Location = new System.Drawing.Point(13, 622);
            this.buttonAbout_SRR.Name = "buttonAbout_SRR";
            this.buttonAbout_SRR.Size = new System.Drawing.Size(174, 47);
            this.buttonAbout_SRR.TabIndex = 4;
            this.buttonAbout_SRR.Text = "Авторские права";
            this.buttonAbout_SRR.UseVisualStyleBackColor = true;
            this.buttonAbout_SRR.Click += new System.EventHandler(this.buttonAbout_SRR_Click);
            // 
            // buttonHelp_SRR
            // 
            this.buttonHelp_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHelp_SRR.Location = new System.Drawing.Point(194, 622);
            this.buttonHelp_SRR.Name = "buttonHelp_SRR";
            this.buttonHelp_SRR.Size = new System.Drawing.Size(83, 47);
            this.buttonHelp_SRR.TabIndex = 5;
            this.buttonHelp_SRR.Text = "?";
            this.buttonHelp_SRR.UseVisualStyleBackColor = true;
            this.buttonHelp_SRR.Click += new System.EventHandler(this.buttonHelp_SRR_Click);
            // 
            // groupBoxDeletePeople_SRR
            // 
            this.groupBoxDeletePeople_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDeletePeople_SRR.Controls.Add(this.labelDeleteEntrance_SRR);
            this.groupBoxDeletePeople_SRR.Controls.Add(this.labelDeleteFlat_SRR);
            this.groupBoxDeletePeople_SRR.Controls.Add(this.buttonDeletePeople_SRR);
            this.groupBoxDeletePeople_SRR.Controls.Add(this.textBoxDeleteEntrance_SRR);
            this.groupBoxDeletePeople_SRR.Controls.Add(this.textBoxDeleteFlat_SRR);
            this.groupBoxDeletePeople_SRR.Location = new System.Drawing.Point(283, 12);
            this.groupBoxDeletePeople_SRR.Name = "groupBoxDeletePeople_SRR";
            this.groupBoxDeletePeople_SRR.Size = new System.Drawing.Size(969, 119);
            this.groupBoxDeletePeople_SRR.TabIndex = 6;
            this.groupBoxDeletePeople_SRR.TabStop = false;
            this.groupBoxDeletePeople_SRR.Text = "Удаление жильцов из базы:";
            // 
            // labelDeleteEntrance_SRR
            // 
            this.labelDeleteEntrance_SRR.AutoSize = true;
            this.labelDeleteEntrance_SRR.Location = new System.Drawing.Point(6, 66);
            this.labelDeleteEntrance_SRR.Name = "labelDeleteEntrance_SRR";
            this.labelDeleteEntrance_SRR.Size = new System.Drawing.Size(96, 13);
            this.labelDeleteEntrance_SRR.TabIndex = 2;
            this.labelDeleteEntrance_SRR.Text = "Номер подъезда:";
            // 
            // labelDeleteFlat_SRR
            // 
            this.labelDeleteFlat_SRR.AutoSize = true;
            this.labelDeleteFlat_SRR.Location = new System.Drawing.Point(6, 24);
            this.labelDeleteFlat_SRR.Name = "labelDeleteFlat_SRR";
            this.labelDeleteFlat_SRR.Size = new System.Drawing.Size(96, 13);
            this.labelDeleteFlat_SRR.TabIndex = 2;
            this.labelDeleteFlat_SRR.Text = "Номер квартиры:";
            // 
            // buttonDeletePeople_SRR
            // 
            this.buttonDeletePeople_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeletePeople_SRR.Location = new System.Drawing.Point(791, 43);
            this.buttonDeletePeople_SRR.Name = "buttonDeletePeople_SRR";
            this.buttonDeletePeople_SRR.Size = new System.Drawing.Size(172, 60);
            this.buttonDeletePeople_SRR.TabIndex = 1;
            this.buttonDeletePeople_SRR.Text = "Удалить";
            this.buttonDeletePeople_SRR.UseVisualStyleBackColor = true;
            this.buttonDeletePeople_SRR.Click += new System.EventHandler(this.buttonDeletePeople_SRR_Click);
            // 
            // textBoxDeleteEntrance_SRR
            // 
            this.textBoxDeleteEntrance_SRR.Location = new System.Drawing.Point(6, 83);
            this.textBoxDeleteEntrance_SRR.Name = "textBoxDeleteEntrance_SRR";
            this.textBoxDeleteEntrance_SRR.Size = new System.Drawing.Size(169, 20);
            this.textBoxDeleteEntrance_SRR.TabIndex = 0;
            // 
            // textBoxDeleteFlat_SRR
            // 
            this.textBoxDeleteFlat_SRR.Location = new System.Drawing.Point(6, 43);
            this.textBoxDeleteFlat_SRR.Name = "textBoxDeleteFlat_SRR";
            this.textBoxDeleteFlat_SRR.Size = new System.Drawing.Size(169, 20);
            this.textBoxDeleteFlat_SRR.TabIndex = 0;
            // 
            // groupBoxInfo_SRR
            // 
            this.groupBoxInfo_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInfo_SRR.Controls.Add(this.dataGridViewInfo_SRR);
            this.groupBoxInfo_SRR.Location = new System.Drawing.Point(292, 138);
            this.groupBoxInfo_SRR.Name = "groupBoxInfo_SRR";
            this.groupBoxInfo_SRR.Size = new System.Drawing.Size(960, 483);
            this.groupBoxInfo_SRR.TabIndex = 7;
            this.groupBoxInfo_SRR.TabStop = false;
            this.groupBoxInfo_SRR.Text = "Информация о жильцах:";
            // 
            // dataGridViewInfo_SRR
            // 
            this.dataGridViewInfo_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInfo_SRR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo_SRR.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInfo_SRR.Name = "dataGridViewInfo_SRR";
            this.dataGridViewInfo_SRR.Size = new System.Drawing.Size(954, 464);
            this.dataGridViewInfo_SRR.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBoxInfo_SRR);
            this.Controls.Add(this.groupBoxDeletePeople_SRR);
            this.Controls.Add(this.buttonHelp_SRR);
            this.Controls.Add(this.buttonAbout_SRR);
            this.Controls.Add(this.groupBoxReg_SRR);
            this.Name = "FormMain";
            this.Text = "Спринт 7 |  Вариант 7 | Шакиров Р.Р.";
            this.groupBoxReg_SRR.ResumeLayout(false);
            this.groupBoxReg_SRR.PerformLayout();
            this.groupBoxDeletePeople_SRR.ResumeLayout(false);
            this.groupBoxDeletePeople_SRR.PerformLayout();
            this.groupBoxInfo_SRR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo_SRR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxReg_SRR;
        private System.Windows.Forms.Button buttonSaveFile_SRR;
        private System.Windows.Forms.Label labelSumRoom_SRR;
        private System.Windows.Forms.Label labelAddFlat_SRR;
        private System.Windows.Forms.Label labelFlatArea_SRR;
        private System.Windows.Forms.Label labelSumPeople_SRR;
        private System.Windows.Forms.Label labelAddEntrance_SRR;
        private System.Windows.Forms.Label labelFIO_SRR;
        private System.Windows.Forms.TextBox textBoxSumRoom_SRR;
        private System.Windows.Forms.TextBox textBoxAddFlat_SRR;
        private System.Windows.Forms.TextBox textBoxSumPeople_SRR;
        private System.Windows.Forms.TextBox textBoxFlatArea_SRR;
        private System.Windows.Forms.TextBox textBoxAddEntrance_SRR;
        private System.Windows.Forms.TextBox textBoxFIO_SRR;
        private System.Windows.Forms.Button buttonAbout_SRR;
        private System.Windows.Forms.Button buttonHelp_SRR;
        private System.Windows.Forms.GroupBox groupBoxDeletePeople_SRR;
        private System.Windows.Forms.Label labelDeleteEntrance_SRR;
        private System.Windows.Forms.Label labelDeleteFlat_SRR;
        private System.Windows.Forms.Button buttonDeletePeople_SRR;
        private System.Windows.Forms.TextBox textBoxDeleteEntrance_SRR;
        private System.Windows.Forms.TextBox textBoxDeleteFlat_SRR;
        private System.Windows.Forms.GroupBox groupBoxInfo_SRR;
        private System.Windows.Forms.DataGridView dataGridViewInfo_SRR;
    }
}

