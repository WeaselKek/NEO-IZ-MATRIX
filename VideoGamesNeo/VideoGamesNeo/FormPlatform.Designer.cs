namespace VideoGamesNeo
{
    partial class FormPlatform
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
            this.dgvPlatform = new System.Windows.Forms.DataGridView();
            this.btnTrue = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatform)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlatform
            // 
            this.dgvPlatform.AllowUserToAddRows = false;
            this.dgvPlatform.AllowUserToDeleteRows = false;
            this.dgvPlatform.AllowUserToResizeColumns = false;
            this.dgvPlatform.AllowUserToResizeRows = false;
            this.dgvPlatform.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlatform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatform.Location = new System.Drawing.Point(52, 25);
            this.dgvPlatform.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPlatform.MultiSelect = false;
            this.dgvPlatform.Name = "dgvPlatform";
            this.dgvPlatform.ReadOnly = true;
            this.dgvPlatform.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPlatform.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlatform.Size = new System.Drawing.Size(319, 262);
            this.dgvPlatform.TabIndex = 9;
            // 
            // btnTrue
            // 
            this.btnTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrue.Location = new System.Drawing.Point(52, 306);
            this.btnTrue.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(319, 63);
            this.btnTrue.TabIndex = 8;
            this.btnTrue.Text = "Add Relationship";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.btnDelete);
            this.panelEdit.Controls.Add(this.btnEdit);
            this.panelEdit.Location = new System.Drawing.Point(52, 306);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(377, 54);
            this.panelEdit.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 44);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(3, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(173, 44);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FormPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 458);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.dgvPlatform);
            this.Controls.Add(this.btnTrue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPlatform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platforms";
            this.Load += new System.EventHandler(this.FormPlatform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatform)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlatform;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;

    }
}