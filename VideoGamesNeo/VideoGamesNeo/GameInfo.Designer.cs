namespace VideoGamesNeo
{
    partial class GameInfo
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCompany = new System.Windows.Forms.DataGridView();
            this.dgvTag = new System.Windows.Forms.DataGridView();
            this.dgvPlatform = new System.Windows.Forms.DataGridView();
            this.cbxRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddComp = new System.Windows.Forms.Button();
            this.btnRemoveComp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblrat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.btnAddPlat = new System.Windows.Forms.Button();
            this.btnRemoveTag = new System.Windows.Forms.Button();
            this.btnRemovePlatform = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatform)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 23);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 24);
            this.txtName.TabIndex = 0;
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(183, 70);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(276, 24);
            this.dtp1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Release Date:";
            // 
            // dgvCompany
            // 
            this.dgvCompany.AllowUserToAddRows = false;
            this.dgvCompany.AllowUserToDeleteRows = false;
            this.dgvCompany.AllowUserToResizeColumns = false;
            this.dgvCompany.AllowUserToResizeRows = false;
            this.dgvCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompany.Location = new System.Drawing.Point(16, 405);
            this.dgvCompany.MultiSelect = false;
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.ReadOnly = true;
            this.dgvCompany.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompany.Size = new System.Drawing.Size(482, 100);
            this.dgvCompany.TabIndex = 4;
            // 
            // dgvTag
            // 
            this.dgvTag.AllowUserToAddRows = false;
            this.dgvTag.AllowUserToDeleteRows = false;
            this.dgvTag.AllowUserToResizeColumns = false;
            this.dgvTag.AllowUserToResizeRows = false;
            this.dgvTag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTag.ColumnHeadersVisible = false;
            this.dgvTag.Location = new System.Drawing.Point(619, 46);
            this.dgvTag.MultiSelect = false;
            this.dgvTag.Name = "dgvTag";
            this.dgvTag.ReadOnly = true;
            this.dgvTag.RowHeadersVisible = false;
            this.dgvTag.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTag.Size = new System.Drawing.Size(184, 145);
            this.dgvTag.TabIndex = 5;
            // 
            // dgvPlatform
            // 
            this.dgvPlatform.AllowUserToAddRows = false;
            this.dgvPlatform.AllowUserToDeleteRows = false;
            this.dgvPlatform.AllowUserToResizeColumns = false;
            this.dgvPlatform.AllowUserToResizeRows = false;
            this.dgvPlatform.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlatform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatform.ColumnHeadersVisible = false;
            this.dgvPlatform.Location = new System.Drawing.Point(619, 288);
            this.dgvPlatform.MultiSelect = false;
            this.dgvPlatform.Name = "dgvPlatform";
            this.dgvPlatform.ReadOnly = true;
            this.dgvPlatform.RowHeadersVisible = false;
            this.dgvPlatform.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPlatform.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlatform.Size = new System.Drawing.Size(184, 123);
            this.dgvPlatform.TabIndex = 6;
            // 
            // cbxRate
            // 
            this.cbxRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRate.FormattingEnabled = true;
            this.cbxRate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxRate.Location = new System.Drawing.Point(186, 120);
            this.cbxRate.Name = "cbxRate";
            this.cbxRate.Size = new System.Drawing.Size(56, 26);
            this.cbxRate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rating:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Companies:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Platforms:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tags:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(118, 286);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(237, 44);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Save Changes";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(711, 549);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(237, 44);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddComp
            // 
            this.btnAddComp.Location = new System.Drawing.Point(16, 521);
            this.btnAddComp.Name = "btnAddComp";
            this.btnAddComp.Size = new System.Drawing.Size(56, 36);
            this.btnAddComp.TabIndex = 14;
            this.btnAddComp.Text = "+";
            this.btnAddComp.UseVisualStyleBackColor = true;
            this.btnAddComp.Click += new System.EventHandler(this.btnAddComp_Click);
            // 
            // btnRemoveComp
            // 
            this.btnRemoveComp.Location = new System.Drawing.Point(442, 521);
            this.btnRemoveComp.Name = "btnRemoveComp";
            this.btnRemoveComp.Size = new System.Drawing.Size(56, 36);
            this.btnRemoveComp.TabIndex = 15;
            this.btnRemoveComp.Text = "-";
            this.btnRemoveComp.UseVisualStyleBackColor = true;
            this.btnRemoveComp.Click += new System.EventHandler(this.btnRemoveComp_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblrat);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rtbDesc);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxRate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(16, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 355);
            this.panel1.TabIndex = 16;
            // 
            // lblrat
            // 
            this.lblrat.AutoSize = true;
            this.lblrat.Location = new System.Drawing.Point(352, 123);
            this.lblrat.Name = "lblrat";
            this.lblrat.Size = new System.Drawing.Size(51, 18);
            this.lblrat.TabIndex = 16;
            this.lblrat.Text = "currrat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Current:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Description:";
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(117, 175);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(363, 91);
            this.rtbDesc.TabIndex = 13;
            this.rtbDesc.Text = "";
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(619, 208);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(56, 36);
            this.btnAddTag.TabIndex = 17;
            this.btnAddTag.Text = "+";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // btnAddPlat
            // 
            this.btnAddPlat.Location = new System.Drawing.Point(619, 431);
            this.btnAddPlat.Name = "btnAddPlat";
            this.btnAddPlat.Size = new System.Drawing.Size(56, 36);
            this.btnAddPlat.TabIndex = 18;
            this.btnAddPlat.Text = "+";
            this.btnAddPlat.UseVisualStyleBackColor = true;
            this.btnAddPlat.Click += new System.EventHandler(this.btnAddPlat_Click);
            // 
            // btnRemoveTag
            // 
            this.btnRemoveTag.Location = new System.Drawing.Point(747, 208);
            this.btnRemoveTag.Name = "btnRemoveTag";
            this.btnRemoveTag.Size = new System.Drawing.Size(56, 36);
            this.btnRemoveTag.TabIndex = 19;
            this.btnRemoveTag.Text = "-";
            this.btnRemoveTag.UseVisualStyleBackColor = true;
            this.btnRemoveTag.Click += new System.EventHandler(this.btnRemoveTag_Click);
            // 
            // btnRemovePlatform
            // 
            this.btnRemovePlatform.Location = new System.Drawing.Point(747, 431);
            this.btnRemovePlatform.Name = "btnRemovePlatform";
            this.btnRemovePlatform.Size = new System.Drawing.Size(56, 36);
            this.btnRemovePlatform.TabIndex = 20;
            this.btnRemovePlatform.Text = "-";
            this.btnRemovePlatform.UseVisualStyleBackColor = true;
            this.btnRemovePlatform.Click += new System.EventHandler(this.btnRemovePlatform_Click);
            // 
            // GameInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 605);
            this.Controls.Add(this.btnRemovePlatform);
            this.Controls.Add(this.btnRemoveTag);
            this.Controls.Add(this.btnAddPlat);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemoveComp);
            this.Controls.Add(this.btnAddComp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPlatform);
            this.Controls.Add(this.dgvTag);
            this.Controls.Add(this.dgvCompany);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Info";
            this.Load += new System.EventHandler(this.GameInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatform)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCompany;
        private System.Windows.Forms.DataGridView dgvTag;
        private System.Windows.Forms.DataGridView dgvPlatform;
        private System.Windows.Forms.ComboBox cbxRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddComp;
        private System.Windows.Forms.Button btnRemoveComp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.Button btnAddPlat;
        private System.Windows.Forms.Button btnRemoveTag;
        private System.Windows.Forms.Button btnRemovePlatform;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Label lblrat;
        private System.Windows.Forms.Label label8;
    }
}