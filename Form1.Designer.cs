
namespace TechnicService
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisrtNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productProblemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSet = new TechnicService.customerDataSet();
            this.customerTableAdapter = new TechnicService.customerDataSetTableAdapters.CustomerTableAdapter();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductProblem = new System.Windows.Forms.Label();
            this.lblBillRequest = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.cbScreen = new System.Windows.Forms.CheckBox();
            this.cbAudio = new System.Windows.Forms.CheckBox();
            this.cbBattery = new System.Windows.Forms.CheckBox();
            this.cbMainboard = new System.Windows.Forms.CheckBox();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.datetpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.fisrtNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productProblemDataGridViewTextBoxColumn,
            this.billRequestDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dgvCustomerList.DataSource = this.customerBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustomerList.Location = new System.Drawing.Point(51, 12);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.Size = new System.Drawing.Size(914, 150);
            this.dgvCustomerList.TabIndex = 0;
            this.dgvCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerList_CellContentClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fisrtNameDataGridViewTextBoxColumn
            // 
            this.fisrtNameDataGridViewTextBoxColumn.DataPropertyName = "FisrtName";
            this.fisrtNameDataGridViewTextBoxColumn.HeaderText = "FisrtName";
            this.fisrtNameDataGridViewTextBoxColumn.Name = "fisrtNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productProblemDataGridViewTextBoxColumn
            // 
            this.productProblemDataGridViewTextBoxColumn.DataPropertyName = "ProductProblem";
            this.productProblemDataGridViewTextBoxColumn.HeaderText = "ProductProblem";
            this.productProblemDataGridViewTextBoxColumn.Name = "productProblemDataGridViewTextBoxColumn";
            // 
            // billRequestDataGridViewTextBoxColumn
            // 
            this.billRequestDataGridViewTextBoxColumn.DataPropertyName = "BillRequest";
            this.billRequestDataGridViewTextBoxColumn.HeaderText = "BillRequest";
            this.billRequestDataGridViewTextBoxColumn.Name = "billRequestDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.customerDataSet;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "customerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(48, 177);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(48, 215);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(57, 13);
            this.lblFirstname.TabIndex = 2;
            this.lblFirstname.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(48, 250);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(48, 290);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(48, 369);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductProblem
            // 
            this.lblProductProblem.AutoSize = true;
            this.lblProductProblem.Location = new System.Drawing.Point(350, 174);
            this.lblProductProblem.Name = "lblProductProblem";
            this.lblProductProblem.Size = new System.Drawing.Size(85, 13);
            this.lblProductProblem.TabIndex = 6;
            this.lblProductProblem.Text = "Product Problem";
            // 
            // lblBillRequest
            // 
            this.lblBillRequest.AutoSize = true;
            this.lblBillRequest.Location = new System.Drawing.Point(350, 215);
            this.lblBillRequest.Name = "lblBillRequest";
            this.lblBillRequest.Size = new System.Drawing.Size(63, 13);
            this.lblBillRequest.TabIndex = 7;
            this.lblBillRequest.Text = "Bill Request";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(350, 251);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(350, 290);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(30, 13);
            this.lblNote.TabIndex = 9;
            this.lblNote.Text = "Note";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(129, 174);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 10;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(129, 208);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(129, 245);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(129, 290);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 59);
            this.txtAddress.TabIndex = 13;
            // 
            // cboProductName
            // 
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Items.AddRange(new object[] {
            "Phone",
            "Computer",
            "Tablet"});
            this.cboProductName.Location = new System.Drawing.Point(129, 369);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(121, 21);
            this.cboProductName.TabIndex = 14;
            // 
            // cbScreen
            // 
            this.cbScreen.AutoSize = true;
            this.cbScreen.Location = new System.Drawing.Point(464, 172);
            this.cbScreen.Name = "cbScreen";
            this.cbScreen.Size = new System.Drawing.Size(60, 17);
            this.cbScreen.TabIndex = 15;
            this.cbScreen.Text = "Screen";
            this.cbScreen.UseVisualStyleBackColor = true;
            // 
            // cbAudio
            // 
            this.cbAudio.AutoSize = true;
            this.cbAudio.Location = new System.Drawing.Point(567, 172);
            this.cbAudio.Name = "cbAudio";
            this.cbAudio.Size = new System.Drawing.Size(53, 17);
            this.cbAudio.TabIndex = 16;
            this.cbAudio.Text = "Audio";
            this.cbAudio.UseVisualStyleBackColor = true;
            // 
            // cbBattery
            // 
            this.cbBattery.AutoSize = true;
            this.cbBattery.Location = new System.Drawing.Point(668, 172);
            this.cbBattery.Name = "cbBattery";
            this.cbBattery.Size = new System.Drawing.Size(59, 17);
            this.cbBattery.TabIndex = 17;
            this.cbBattery.Text = "Battery";
            this.cbBattery.UseVisualStyleBackColor = true;
            // 
            // cbMainboard
            // 
            this.cbMainboard.AutoSize = true;
            this.cbMainboard.Location = new System.Drawing.Point(771, 173);
            this.cbMainboard.Name = "cbMainboard";
            this.cbMainboard.Size = new System.Drawing.Size(76, 17);
            this.cbMainboard.TabIndex = 18;
            this.cbMainboard.Text = "Mainboard";
            this.cbMainboard.UseVisualStyleBackColor = true;
            // 
            // rdoYes
            // 
            this.rdoYes.AutoSize = true;
            this.rdoYes.Location = new System.Drawing.Point(464, 209);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(43, 17);
            this.rdoYes.TabIndex = 19;
            this.rdoYes.TabStop = true;
            this.rdoYes.Text = "Yes";
            this.rdoYes.UseVisualStyleBackColor = true;
            // 
            // rdoNo
            // 
            this.rdoNo.AutoSize = true;
            this.rdoNo.Location = new System.Drawing.Point(567, 209);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(39, 17);
            this.rdoNo.TabIndex = 20;
            this.rdoNo.TabStop = true;
            this.rdoNo.Text = "No";
            this.rdoNo.UseVisualStyleBackColor = true;
            // 
            // datetpDate
            // 
            this.datetpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetpDate.Location = new System.Drawing.Point(464, 245);
            this.datetpDate.Name = "datetpDate";
            this.datetpDate.Size = new System.Drawing.Size(200, 20);
            this.datetpDate.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(900, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 37);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(900, 325);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 38);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(900, 380);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 38);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(900, 434);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 34);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(464, 290);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 59);
            this.textBox1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 470);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.datetpDate);
            this.Controls.Add(this.rdoNo);
            this.Controls.Add(this.rdoYes);
            this.Controls.Add(this.cbMainboard);
            this.Controls.Add(this.cbBattery);
            this.Controls.Add(this.cbAudio);
            this.Controls.Add(this.cbScreen);
            this.Controls.Add(this.cboProductName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblBillRequest);
            this.Controls.Add(this.lblProductProblem);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dgvCustomerList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerList;
        private customerDataSet customerDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private customerDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisrtNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productProblemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductProblem;
        private System.Windows.Forms.Label lblBillRequest;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.CheckBox cbScreen;
        private System.Windows.Forms.CheckBox cbAudio;
        private System.Windows.Forms.CheckBox cbBattery;
        private System.Windows.Forms.CheckBox cbMainboard;
        private System.Windows.Forms.RadioButton rdoYes;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.DateTimePicker datetpDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBox1;
    }
}

