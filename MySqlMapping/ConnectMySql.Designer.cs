namespace MySqlMapping
{
    partial class ConnectMySql
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BntGetAll = new System.Windows.Forms.Button();
            this.BtnConnectDB = new System.Windows.Forms.Button();
            this.BntDisconnectDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(285, 146);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(78, 29);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(41, 195);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1027, 281);
            this.dataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(115, 33);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(170, 22);
            this.textID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(115, 72);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(356, 22);
            this.textPhone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(115, 108);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(356, 22);
            this.textName.TabIndex = 3;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(391, 146);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(80, 29);
            this.BtnUpdate.TabIndex = 0;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(508, 146);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(82, 29);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BntGetAll
            // 
            this.BntGetAll.Location = new System.Drawing.Point(631, 146);
            this.BntGetAll.Name = "BntGetAll";
            this.BntGetAll.Size = new System.Drawing.Size(86, 29);
            this.BntGetAll.TabIndex = 0;
            this.BntGetAll.Text = "Get All";
            this.BntGetAll.UseVisualStyleBackColor = true;
            // 
            // BtnConnectDB
            // 
            this.BtnConnectDB.Location = new System.Drawing.Point(618, 12);
            this.BtnConnectDB.Name = "BtnConnectDB";
            this.BtnConnectDB.Size = new System.Drawing.Size(221, 29);
            this.BtnConnectDB.TabIndex = 0;
            this.BtnConnectDB.Text = "Connect Database";
            this.BtnConnectDB.UseVisualStyleBackColor = true;
            this.BtnConnectDB.Click += new System.EventHandler(this.BtnConnectDB_Click);
            // 
            // BntDisconnectDB
            // 
            this.BntDisconnectDB.Location = new System.Drawing.Point(618, 69);
            this.BntDisconnectDB.Name = "BntDisconnectDB";
            this.BntDisconnectDB.Size = new System.Drawing.Size(221, 29);
            this.BntDisconnectDB.TabIndex = 0;
            this.BntDisconnectDB.Text = "Disconnect Database";
            this.BntDisconnectDB.UseVisualStyleBackColor = true;
            this.BntDisconnectDB.Click += new System.EventHandler(this.BntDisconnectDB_Click);
            // 
            // ConnectMySql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 501);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.BntGetAll);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BntDisconnectDB);
            this.Controls.Add(this.BtnConnectDB);
            this.Controls.Add(this.btnInsert);
            this.Name = "ConnectMySql";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BntGetAll;
        private System.Windows.Forms.Button BtnConnectDB;
        private System.Windows.Forms.Button BntDisconnectDB;
    }
}

