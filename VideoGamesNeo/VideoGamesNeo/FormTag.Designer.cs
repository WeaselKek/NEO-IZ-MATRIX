namespace VideoGamesNeo
{
    partial class FormTag
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
            this.dgvTag = new System.Windows.Forms.DataGridView();
            this.btnTrue = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTag)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTag
            // 
            this.dgvTag.AllowUserToAddRows = false;
            this.dgvTag.AllowUserToDeleteRows = false;
            this.dgvTag.AllowUserToResizeColumns = false;
            this.dgvTag.AllowUserToResizeRows = false;
            this.dgvTag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTag.Location = new System.Drawing.Point(32, 13);
            this.dgvTag.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTag.MultiSelect = false;
            this.dgvTag.Name = "dgvTag";
            this.dgvTag.ReadOnly = true;
            this.dgvTag.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTag.Size = new System.Drawing.Size(319, 262);
            this.dgvTag.TabIndex = 7;
            // 
            // btnTrue
            // 
            this.btnTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrue.Location = new System.Drawing.Point(32, 298);
            this.btnTrue.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(319, 63);
            this.btnTrue.TabIndex = 6;
            this.btnTrue.Text = "Add Relationship";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.btnDelete);
            this.panelEdit.Controls.Add(this.btnEdit);
            this.panelEdit.Location = new System.Drawing.Point(12, 288);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(409, 73);
            this.panelEdit.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(268, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 44);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(9, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(202, 44);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FormTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 468);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.dgvTag);
            this.Controls.Add(this.btnTrue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tags";
            this.Load += new System.EventHandler(this.FormTag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTag)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTag;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}