namespace CRUD_LINQ
{
    partial class frmCrudLinq
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTittleLinQ = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblINE = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtINE = new System.Windows.Forms.TextBox();
            this.dgvDataUsers = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittleLinQ
            // 
            this.lblTittleLinQ.AutoSize = true;
            this.lblTittleLinQ.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittleLinQ.Location = new System.Drawing.Point(151, 20);
            this.lblTittleLinQ.Name = "lblTittleLinQ";
            this.lblTittleLinQ.Size = new System.Drawing.Size(258, 34);
            this.lblTittleLinQ.TabIndex = 0;
            this.lblTittleLinQ.Text = "CRUD LINQ HD";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(86, 72);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(52, 13);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "Firsname:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(86, 101);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(56, 13);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Lastname:";
            // 
            // lblINE
            // 
            this.lblINE.AutoSize = true;
            this.lblINE.Location = new System.Drawing.Point(86, 127);
            this.lblINE.Name = "lblINE";
            this.lblINE.Size = new System.Drawing.Size(28, 13);
            this.lblINE.TabIndex = 3;
            this.lblINE.Text = "INE:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(169, 72);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(248, 20);
            this.txtFirstname.TabIndex = 4;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(169, 101);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(248, 20);
            this.txtLastname.TabIndex = 4;
            // 
            // txtINE
            // 
            this.txtINE.Location = new System.Drawing.Point(169, 127);
            this.txtINE.Name = "txtINE";
            this.txtINE.Size = new System.Drawing.Size(248, 20);
            this.txtINE.TabIndex = 4;
            // 
            // dgvDataUsers
            // 
            this.dgvDataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataUsers.Location = new System.Drawing.Point(89, 202);
            this.dgvDataUsers.Name = "dgvDataUsers";
            this.dgvDataUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDataUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataUsers.Size = new System.Drawing.Size(452, 150);
            this.dgvDataUsers.TabIndex = 5;
            this.dgvDataUsers.SelectionChanged += new System.EventHandler(this.dgvDataUsers_SelectionChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(89, 167);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(170, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(251, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(342, 167);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(520, 167);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmCrudLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 373);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvDataUsers);
            this.Controls.Add(this.txtINE);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblINE);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblTittleLinQ);
            this.Name = "frmCrudLinq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD LINQ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittleLinQ;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblINE;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtINE;
        private System.Windows.Forms.DataGridView dgvDataUsers;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRefresh;
    }
}

