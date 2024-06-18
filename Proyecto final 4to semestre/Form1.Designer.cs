namespace Proyecto_final_4to_semestre
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
            this.btnSaveToJson = new System.Windows.Forms.Button();
            this.btnSaveToXML = new System.Windows.Forms.Button();
            this.btnSaveToCSV = new System.Windows.Forms.Button();
            this.btnLoadFromDatabase = new System.Windows.Forms.Button();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveToJson
            // 
            this.btnSaveToJson.Location = new System.Drawing.Point(654, 131);
            this.btnSaveToJson.Name = "btnSaveToJson";
            this.btnSaveToJson.Size = new System.Drawing.Size(124, 36);
            this.btnSaveToJson.TabIndex = 15;
            this.btnSaveToJson.Text = "SAVE TO JSON";
            this.btnSaveToJson.UseVisualStyleBackColor = true;
            this.btnSaveToJson.Click += new System.EventHandler(this.btnSaveToJson_Click);
            // 
            // btnSaveToXML
            // 
            this.btnSaveToXML.Location = new System.Drawing.Point(654, 183);
            this.btnSaveToXML.Name = "btnSaveToXML";
            this.btnSaveToXML.Size = new System.Drawing.Size(124, 36);
            this.btnSaveToXML.TabIndex = 14;
            this.btnSaveToXML.Text = "SAVE TO XML";
            this.btnSaveToXML.UseVisualStyleBackColor = true;
            this.btnSaveToXML.Click += new System.EventHandler(this.btnSaveToXML_Click);
            // 
            // btnSaveToCSV
            // 
            this.btnSaveToCSV.Location = new System.Drawing.Point(654, 238);
            this.btnSaveToCSV.Name = "btnSaveToCSV";
            this.btnSaveToCSV.Size = new System.Drawing.Size(124, 36);
            this.btnSaveToCSV.TabIndex = 13;
            this.btnSaveToCSV.Text = "SAVE TO CSV";
            this.btnSaveToCSV.UseVisualStyleBackColor = true;
            this.btnSaveToCSV.Click += new System.EventHandler(this.btnSaveToCSV_Click);
            // 
            // btnLoadFromDatabase
            // 
            this.btnLoadFromDatabase.Location = new System.Drawing.Point(529, 183);
            this.btnLoadFromDatabase.Name = "btnLoadFromDatabase";
            this.btnLoadFromDatabase.Size = new System.Drawing.Size(95, 63);
            this.btnLoadFromDatabase.TabIndex = 12;
            this.btnLoadFromDatabase.Text = "LOAD FROM DATABASE";
            this.btnLoadFromDatabase.UseVisualStyleBackColor = true;
            this.btnLoadFromDatabase.Click += new System.EventHandler(this.btnLoadFromDatabase_Click);
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.Location = new System.Drawing.Point(529, 252);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(91, 43);
            this.btnSaveToDatabase.TabIndex = 11;
            this.btnSaveToDatabase.Text = "SAVE TO DATABASE";
            this.btnSaveToDatabase.UseVisualStyleBackColor = true;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "ADD ROW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(529, 131);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(95, 46);
            this.btnLoadFile.TabIndex = 9;
            this.btnLoadFile.Text = "LOAD FILE";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(455, 221);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveToJson);
            this.Controls.Add(this.btnSaveToXML);
            this.Controls.Add(this.btnSaveToCSV);
            this.Controls.Add(this.btnLoadFromDatabase);
            this.Controls.Add(this.btnSaveToDatabase);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveToJson;
        private System.Windows.Forms.Button btnSaveToXML;
        private System.Windows.Forms.Button btnSaveToCSV;
        private System.Windows.Forms.Button btnLoadFromDatabase;
        private System.Windows.Forms.Button btnSaveToDatabase;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

