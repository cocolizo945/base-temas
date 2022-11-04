namespace Wind
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvgData = new System.Windows.Forms.DataGridView();
            this.cboTables = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(404, 114);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(404, 172);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(69, 32);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Cargar";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID del Tema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del tema";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(145, 74);
            this.txtID.Margin = new System.Windows.Forms.Padding(0);
            this.txtID.MaxLength = 5;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(85, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 40);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(85, 20);
            this.txtName.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(26, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 164);
            this.panel1.TabIndex = 6;
            // 
            // dvgData
            // 
            this.dvgData.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dvgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgData.Location = new System.Drawing.Point(26, 114);
            this.dvgData.Margin = new System.Windows.Forms.Padding(0);
            this.dvgData.Name = "dvgData";
            this.dvgData.Size = new System.Drawing.Size(359, 164);
            this.dvgData.TabIndex = 0;
            // 
            // cboTables
            // 
            this.cboTables.FormattingEnabled = true;
            this.cboTables.Location = new System.Drawing.Point(294, 39);
            this.cboTables.Margin = new System.Windows.Forms.Padding(0);
            this.cboTables.Name = "cboTables";
            this.cboTables.Size = new System.Drawing.Size(91, 21);
            this.cboTables.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 287);
            this.Controls.Add(this.cboTables);
            this.Controls.Add(this.dvgData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Form1";
            this.Text = "Temas control";
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cboTables;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dvgData;

        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;

        #endregion
    }
}