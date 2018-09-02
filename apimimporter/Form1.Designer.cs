namespace apimimporter
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
            this.btngetapis = new System.Windows.Forms.Button();
            this.txtapimname = new System.Windows.Forms.TextBox();
            this.txtaccesstoken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboapislist = new System.Windows.Forms.ComboBox();
            this.btngetapisrev = new System.Windows.Forms.Button();
            this.comboapis2 = new System.Windows.Forms.ComboBox();
            this.btnimport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnfinalimport = new System.Windows.Forms.Button();
            this.lblprogressstatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpApis = new System.Windows.Forms.GroupBox();
            this.lblimporttype = new System.Windows.Forms.Label();
            this.txtfilebrowse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.grpApis.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngetapis
            // 
            this.btngetapis.Location = new System.Drawing.Point(574, 49);
            this.btngetapis.Name = "btngetapis";
            this.btngetapis.Size = new System.Drawing.Size(47, 23);
            this.btngetapis.TabIndex = 0;
            this.btngetapis.Text = "Go";
            this.btngetapis.UseVisualStyleBackColor = true;
            this.btngetapis.Click += new System.EventHandler(this.btngetapis_Click);
            // 
            // txtapimname
            // 
            this.txtapimname.Location = new System.Drawing.Point(156, 23);
            this.txtapimname.Name = "txtapimname";
            this.txtapimname.Size = new System.Drawing.Size(118, 20);
            this.txtapimname.TabIndex = 1;
            this.txtapimname.Text = "apimwithdns";
            this.txtapimname.TextChanged += new System.EventHandler(this.txtapimname_TextChanged);
            // 
            // txtaccesstoken
            // 
            this.txtaccesstoken.Location = new System.Drawing.Point(156, 49);
            this.txtaccesstoken.Name = "txtaccesstoken";
            this.txtaccesstoken.Size = new System.Drawing.Size(412, 20);
            this.txtaccesstoken.TabIndex = 2;
            this.txtaccesstoken.Text = "integration&201810020721&5uD7D8xy37S3HlqmGvHuWcJELlLxbrTiynAaPGf2JhRw12A3LfT0hZn7" +
    "Fd20H0Ni5E41UPFFAt3pFFT+7EQYIg==";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "APIM Service:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SharedAccessSignature:";
            // 
            // comboapislist
            // 
            this.comboapislist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboapislist.FormattingEnabled = true;
            this.comboapislist.Location = new System.Drawing.Point(156, 19);
            this.comboapislist.Name = "comboapislist";
            this.comboapislist.Size = new System.Drawing.Size(375, 21);
            this.comboapislist.TabIndex = 6;
            this.comboapislist.SelectedIndexChanged += new System.EventHandler(this.comboapislist_SelectedIndexChanged);
            // 
            // btngetapisrev
            // 
            this.btngetapisrev.Location = new System.Drawing.Point(537, 19);
            this.btngetapisrev.Name = "btngetapisrev";
            this.btngetapisrev.Size = new System.Drawing.Size(84, 23);
            this.btngetapisrev.TabIndex = 7;
            this.btngetapisrev.Text = "Fetch Details";
            this.btngetapisrev.UseVisualStyleBackColor = true;
            this.btngetapisrev.Click += new System.EventHandler(this.btngetapisrev_Click);
            // 
            // comboapis2
            // 
            this.comboapis2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboapis2.FormattingEnabled = true;
            this.comboapis2.Location = new System.Drawing.Point(156, 46);
            this.comboapis2.Name = "comboapis2";
            this.comboapis2.Size = new System.Drawing.Size(375, 21);
            this.comboapis2.TabIndex = 8;
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(464, 72);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(67, 23);
            this.btnimport.TabIndex = 9;
            this.btnimport.Text = "browse..";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select file to import:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Select file to import..";
            // 
            // btnfinalimport
            // 
            this.btnfinalimport.Location = new System.Drawing.Point(156, 96);
            this.btnfinalimport.Name = "btnfinalimport";
            this.btnfinalimport.Size = new System.Drawing.Size(75, 23);
            this.btnfinalimport.TabIndex = 12;
            this.btnfinalimport.Text = "Import";
            this.btnfinalimport.UseVisualStyleBackColor = true;
            this.btnfinalimport.Click += new System.EventHandler(this.btnfinalimport_Click);
            // 
            // lblprogressstatus
            // 
            this.lblprogressstatus.AutoSize = true;
            this.lblprogressstatus.Location = new System.Drawing.Point(640, 276);
            this.lblprogressstatus.Name = "lblprogressstatus";
            this.lblprogressstatus.Size = new System.Drawing.Size(0, 13);
            this.lblprogressstatus.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtapimname);
            this.groupBox1.Controls.Add(this.txtaccesstoken);
            this.groupBox1.Controls.Add(this.btngetapis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 78);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login APIM service with SAS token";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpApis
            // 
            this.grpApis.Controls.Add(this.lblimporttype);
            this.grpApis.Controls.Add(this.btnimport);
            this.grpApis.Controls.Add(this.txtfilebrowse);
            this.grpApis.Controls.Add(this.label5);
            this.grpApis.Controls.Add(this.label3);
            this.grpApis.Controls.Add(this.comboapislist);
            this.grpApis.Controls.Add(this.comboapis2);
            this.grpApis.Controls.Add(this.btngetapisrev);
            this.grpApis.Controls.Add(this.btnfinalimport);
            this.grpApis.Controls.Add(this.label4);
            this.grpApis.Enabled = false;
            this.grpApis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpApis.Location = new System.Drawing.Point(12, 95);
            this.grpApis.Name = "grpApis";
            this.grpApis.Size = new System.Drawing.Size(627, 131);
            this.grpApis.TabIndex = 16;
            this.grpApis.TabStop = false;
            this.grpApis.Text = "Existing apis in Azure";
            // 
            // lblimporttype
            // 
            this.lblimporttype.AutoSize = true;
            this.lblimporttype.Location = new System.Drawing.Point(239, 101);
            this.lblimporttype.Name = "lblimporttype";
            this.lblimporttype.Size = new System.Drawing.Size(0, 13);
            this.lblimporttype.TabIndex = 17;
            // 
            // txtfilebrowse
            // 
            this.txtfilebrowse.Location = new System.Drawing.Point(156, 73);
            this.txtfilebrowse.Name = "txtfilebrowse";
            this.txtfilebrowse.Size = new System.Drawing.Size(315, 20);
            this.txtfilebrowse.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select api revision:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select api:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 237);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(653, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(170, 20);
            this.toolStripProgressBar1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel1.Text = "Idle...";
            this.toolStripStatusLabel1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 259);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpApis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblprogressstatus);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "APIM Importer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpApis.ResumeLayout(false);
            this.grpApis.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngetapis;
        private System.Windows.Forms.TextBox txtapimname;
        private System.Windows.Forms.TextBox txtaccesstoken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboapislist;
        private System.Windows.Forms.Button btngetapisrev;
        private System.Windows.Forms.ComboBox comboapis2;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnfinalimport;
        private System.Windows.Forms.Label lblprogressstatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpApis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfilebrowse;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblimporttype;
    }
}

