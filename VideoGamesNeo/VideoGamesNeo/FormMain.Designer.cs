namespace VideoGamesNeo
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddPlatform = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddTag = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditPlatform = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditTag = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelGame = new System.Windows.Forms.Button();
            this.cbxTags = new System.Windows.Forms.ComboBox();
            this.cbxPlatforms = new System.Windows.Forms.ComboBox();
            this.cbxCompanies = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbxRate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv1.ColumnHeadersHeight = 35;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv1.Location = new System.Drawing.Point(13, 40);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(658, 326);
            this.dgv1.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(13, 398);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(282, 47);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show Game Info";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddGame,
            this.tsmAddPlatform,
            this.tsmAddTag,
            this.tsmAddCompany});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // tsmAddGame
            // 
            this.tsmAddGame.Name = "tsmAddGame";
            this.tsmAddGame.Size = new System.Drawing.Size(126, 22);
            this.tsmAddGame.Text = "Game";
            this.tsmAddGame.Click += new System.EventHandler(this.tsmAddGame_Click);
            // 
            // tsmAddPlatform
            // 
            this.tsmAddPlatform.Name = "tsmAddPlatform";
            this.tsmAddPlatform.Size = new System.Drawing.Size(126, 22);
            this.tsmAddPlatform.Text = "Platform";
            this.tsmAddPlatform.Click += new System.EventHandler(this.tsmAddPlatform_Click);
            // 
            // tsmAddTag
            // 
            this.tsmAddTag.Name = "tsmAddTag";
            this.tsmAddTag.Size = new System.Drawing.Size(126, 22);
            this.tsmAddTag.Text = "Tag";
            this.tsmAddTag.Click += new System.EventHandler(this.tsmAddTag_Click);
            // 
            // tsmAddCompany
            // 
            this.tsmAddCompany.Name = "tsmAddCompany";
            this.tsmAddCompany.Size = new System.Drawing.Size(126, 22);
            this.tsmAddCompany.Text = "Company";
            this.tsmAddCompany.Click += new System.EventHandler(this.tsmAddCompany_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditPlatform,
            this.tsmEditTag,
            this.tsmEditCompany});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.editToolStripMenuItem.Text = "Show/Edit";
            // 
            // tsmEditPlatform
            // 
            this.tsmEditPlatform.Name = "tsmEditPlatform";
            this.tsmEditPlatform.Size = new System.Drawing.Size(126, 22);
            this.tsmEditPlatform.Text = "Platform";
            this.tsmEditPlatform.Click += new System.EventHandler(this.tsmEditPlatform_Click);
            // 
            // tsmEditTag
            // 
            this.tsmEditTag.Name = "tsmEditTag";
            this.tsmEditTag.Size = new System.Drawing.Size(126, 22);
            this.tsmEditTag.Text = "Tag";
            this.tsmEditTag.Click += new System.EventHandler(this.tsmEditTag_Click);
            // 
            // tsmEditCompany
            // 
            this.tsmEditCompany.Name = "tsmEditCompany";
            this.tsmEditCompany.Size = new System.Drawing.Size(126, 22);
            this.tsmEditCompany.Text = "Company";
            this.tsmEditCompany.Click += new System.EventHandler(this.tsmEditCompany_Click);
            // 
            // btnDelGame
            // 
            this.btnDelGame.Location = new System.Drawing.Point(510, 398);
            this.btnDelGame.Name = "btnDelGame";
            this.btnDelGame.Size = new System.Drawing.Size(161, 47);
            this.btnDelGame.TabIndex = 4;
            this.btnDelGame.Text = "Delete Game";
            this.btnDelGame.UseVisualStyleBackColor = true;
            this.btnDelGame.Click += new System.EventHandler(this.btnDelGame_Click);
            // 
            // cbxTags
            // 
            this.cbxTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTags.FormattingEnabled = true;
            this.cbxTags.Items.AddRange(new object[] {
            "None"});
            this.cbxTags.Location = new System.Drawing.Point(828, 164);
            this.cbxTags.Name = "cbxTags";
            this.cbxTags.Size = new System.Drawing.Size(193, 26);
            this.cbxTags.TabIndex = 5;
            // 
            // cbxPlatforms
            // 
            this.cbxPlatforms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPlatforms.FormattingEnabled = true;
            this.cbxPlatforms.Items.AddRange(new object[] {
            "None"});
            this.cbxPlatforms.Location = new System.Drawing.Point(829, 251);
            this.cbxPlatforms.Name = "cbxPlatforms";
            this.cbxPlatforms.Size = new System.Drawing.Size(193, 26);
            this.cbxPlatforms.TabIndex = 6;
            // 
            // cbxCompanies
            // 
            this.cbxCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompanies.FormattingEnabled = true;
            this.cbxCompanies.Items.AddRange(new object[] {
            "None"});
            this.cbxCompanies.Location = new System.Drawing.Point(828, 336);
            this.cbxCompanies.Name = "cbxCompanies";
            this.cbxCompanies.Size = new System.Drawing.Size(193, 26);
            this.cbxCompanies.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(829, 91);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 24);
            this.txtSearch.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(826, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Game Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(863, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(826, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tag:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(826, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Platform:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(826, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Company:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(828, 443);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(193, 38);
            this.btnFilter.TabIndex = 14;
            this.btnFilter.Text = "Apply Fillters";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            this.cbxRate.Location = new System.Drawing.Point(829, 398);
            this.cbxRate.Name = "cbxRate";
            this.cbxRate.Size = new System.Drawing.Size(56, 26);
            this.cbxRate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(825, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Lowest Grade:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 529);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxRate);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbxCompanies);
            this.Controls.Add(this.cbxPlatforms);
            this.Controls.Add(this.cbxTags);
            this.Controls.Add(this.btnDelGame);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Game DB";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAddGame;
        private System.Windows.Forms.ToolStripMenuItem tsmAddPlatform;
        private System.Windows.Forms.ToolStripMenuItem tsmAddTag;
        private System.Windows.Forms.ToolStripMenuItem tsmAddCompany;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmEditPlatform;
        private System.Windows.Forms.ToolStripMenuItem tsmEditTag;
        private System.Windows.Forms.ToolStripMenuItem tsmEditCompany;
        private System.Windows.Forms.Button btnDelGame;
        private System.Windows.Forms.ComboBox cbxTags;
        private System.Windows.Forms.ComboBox cbxPlatforms;
        private System.Windows.Forms.ComboBox cbxCompanies;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbxRate;
        private System.Windows.Forms.Label label6;
    }
}

