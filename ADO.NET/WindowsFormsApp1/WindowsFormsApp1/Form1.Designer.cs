namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.labDatSource = new System.Windows.Forms.Label();
            this.tbDatSource = new System.Windows.Forms.TextBox();
            this.labInitCat = new System.Windows.Forms.Label();
            this.tbInitCat = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.DatGridDBTables = new System.Windows.Forms.DataGridView();
            this.labSQLReq = new System.Windows.Forms.Label();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.dataGridSQLResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DatGridDBTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSQLResult)).BeginInit();
            this.SuspendLayout();
            // 
            // labDatSource
            // 
            this.labDatSource.AutoSize = true;
            this.labDatSource.Location = new System.Drawing.Point(21, 12);
            this.labDatSource.Name = "labDatSource";
            this.labDatSource.Size = new System.Drawing.Size(83, 17);
            this.labDatSource.TabIndex = 1;
            this.labDatSource.Text = "DataSource";
            // 
            // tbDatSource
            // 
            this.tbDatSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDatSource.BackColor = System.Drawing.SystemColors.Window;
            this.tbDatSource.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbDatSource.Location = new System.Drawing.Point(124, 12);
            this.tbDatSource.Name = "tbDatSource";
            this.tbDatSource.Size = new System.Drawing.Size(406, 22);
            this.tbDatSource.TabIndex = 2;
            this.tbDatSource.Text = "localhost\\VSdotNET";
            // 
            // labInitCat
            // 
            this.labInitCat.AutoSize = true;
            this.labInitCat.Location = new System.Drawing.Point(21, 45);
            this.labInitCat.Name = "labInitCat";
            this.labInitCat.Size = new System.Drawing.Size(92, 17);
            this.labInitCat.TabIndex = 3;
            this.labInitCat.Text = "Initial Catalog";
            // 
            // tbInitCat
            // 
            this.tbInitCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInitCat.BackColor = System.Drawing.SystemColors.Window;
            this.tbInitCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbInitCat.Location = new System.Drawing.Point(124, 40);
            this.tbInitCat.Name = "tbInitCat";
            this.tbInitCat.Size = new System.Drawing.Size(285, 22);
            this.tbInitCat.TabIndex = 4;
            this.tbInitCat.Text = "CompShop";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(415, 40);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(115, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect to DB";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // DatGridDBTables
            // 
            this.DatGridDBTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatGridDBTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatGridDBTables.Enabled = false;
            this.DatGridDBTables.Location = new System.Drawing.Point(24, 78);
            this.DatGridDBTables.Name = "DatGridDBTables";
            this.DatGridDBTables.ReadOnly = true;
            this.DatGridDBTables.RowHeadersWidth = 51;
            this.DatGridDBTables.RowTemplate.Height = 24;
            this.DatGridDBTables.Size = new System.Drawing.Size(506, 150);
            this.DatGridDBTables.TabIndex = 6;
            // 
            // labSQLReq
            // 
            this.labSQLReq.AutoSize = true;
            this.labSQLReq.Location = new System.Drawing.Point(21, 246);
            this.labSQLReq.Name = "labSQLReq";
            this.labSQLReq.Size = new System.Drawing.Size(93, 17);
            this.labSQLReq.TabIndex = 7;
            this.labSQLReq.Text = "SQL Request";
            // 
            // tbRequest
            // 
            this.tbRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRequest.BackColor = System.Drawing.SystemColors.Window;
            this.tbRequest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbRequest.Location = new System.Drawing.Point(124, 243);
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(285, 22);
            this.tbRequest.TabIndex = 8;
            this.tbRequest.Text = "SELECT * FROM Table";
            // 
            // btnRequest
            // 
            this.btnRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequest.Location = new System.Drawing.Point(415, 243);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(115, 23);
            this.btnRequest.TabIndex = 9;
            this.btnRequest.Text = "Send Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridSQLResult
            // 
            this.dataGridSQLResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSQLResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSQLResult.Enabled = false;
            this.dataGridSQLResult.Location = new System.Drawing.Point(24, 282);
            this.dataGridSQLResult.Name = "dataGridSQLResult";
            this.dataGridSQLResult.ReadOnly = true;
            this.dataGridSQLResult.RowHeadersWidth = 51;
            this.dataGridSQLResult.RowTemplate.Height = 24;
            this.dataGridSQLResult.Size = new System.Drawing.Size(506, 150);
            this.dataGridSQLResult.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(542, 464);
            this.Controls.Add(this.dataGridSQLResult);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.labSQLReq);
            this.Controls.Add(this.DatGridDBTables);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbInitCat);
            this.Controls.Add(this.labInitCat);
            this.Controls.Add(this.tbDatSource);
            this.Controls.Add(this.labDatSource);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Base Request";
            ((System.ComponentModel.ISupportInitialize)(this.DatGridDBTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSQLResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDatSource;
        private System.Windows.Forms.TextBox tbDatSource;
        private System.Windows.Forms.Label labInitCat;
        private System.Windows.Forms.TextBox tbInitCat;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridView DatGridDBTables;
        private System.Windows.Forms.Label labSQLReq;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.DataGridView dataGridSQLResult;
    }
}

