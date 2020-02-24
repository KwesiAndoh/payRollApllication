namespace PayRollApplication
{
    partial class Pay_Roll_Calculator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelfirstName = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelEmployeeId = new System.Windows.Forms.Label();
            this.labelSsnitNumber = new System.Windows.Forms.Label();
            this.labelPayDate = new System.Windows.Forms.Label();
            this.labelPayMonth = new System.Windows.Forms.Label();
            this.labelSsnitEmployer = new System.Windows.Forms.Label();
            this.labelSsnitEmployee = new System.Windows.Forms.Label();
            this.labelBasicSalary = new System.Windows.Forms.Label();
            this.textEmployeeId = new System.Windows.Forms.TextBox();
            this.textSsnitNumber = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textBasicSalary = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textTotalEarning = new System.Windows.Forms.TextBox();
            this.comboBxPayMonth = new System.Windows.Forms.ComboBox();
            this.groupBxButton = new System.Windows.Forms.GroupBox();
            this.btnResetDeduction = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPaySlip = new System.Windows.Forms.Button();
            this.CheckDeduction = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpBxEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.grpBxSalaryInfo = new System.Windows.Forms.GroupBox();
            this.btnTotalEarning = new System.Windows.Forms.Button();
            this.grpBxAllowance = new System.Windows.Forms.GroupBox();
            this.textHousing = new System.Windows.Forms.TextBox();
            this._textDressing = new System.Windows.Forms.Label();
            this._textTransport = new System.Windows.Forms.Label();
            this._textHousing = new System.Windows.Forms.Label();
            this.textDressing = new System.Windows.Forms.TextBox();
            this.textTransport = new System.Windows.Forms.TextBox();
            this.labelDressing = new System.Windows.Forms.Label();
            this.labelTransport = new System.Windows.Forms.Label();
            this.labelHousing = new System.Windows.Forms.Label();
            this.SearchPaymentId = new System.Windows.Forms.Label();
            this._SearchPaymentID = new System.Windows.Forms.TextBox();
            this.grpBxDeduction = new System.Windows.Forms.GroupBox();
            this._textnetSalary = new System.Windows.Forms.Label();
            this._textTotalDeduction = new System.Windows.Forms.Label();
            this._textSsnitEmployer = new System.Windows.Forms.Label();
            this._textIncomeTax = new System.Windows.Forms.Label();
            this._textSsnitEmployee = new System.Windows.Forms.Label();
            this.lblNetSalary = new System.Windows.Forms.Label();
            this.lblTotalDeduction = new System.Windows.Forms.Label();
            this.lblIncomeTax = new System.Windows.Forms.Label();
            this.payRollSystemDBDataSet = new PayRollApplication.PayRollSystemDBDataSet();
            this.payRecordsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.payRecordsTableAdapter = new PayRollApplication.PayRollSystemDBDataSetTableAdapters.PayRecordsTableAdapter();
            this.PayRecordsdataGridViewOne = new System.Windows.Forms.DataGridView();
            this.paymentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNITNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dressingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEarningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNITEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNITEmployerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDeductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRecordsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.payRollSystemDBDataSet1 = new PayRollApplication.PayRollSystemDBDataSet1();
            this.payRecordsTableAdapter1 = new PayRollApplication.PayRollSystemDBDataSet1TableAdapters.PayRecordsTableAdapter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._lblFullName = new System.Windows.Forms.Label();
            this._lblSystemDate = new System.Windows.Forms.Label();
            this._SearchFullName = new System.Windows.Forms.TextBox();
            this.SearchFullName = new System.Windows.Forms.Label();
            this.SearchSSNIT = new System.Windows.Forms.Label();
            this._SearchSSNITNo = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBxButton.SuspendLayout();
            this.grpBxEmployeeInfo.SuspendLayout();
            this.grpBxSalaryInfo.SuspendLayout();
            this.grpBxAllowance.SuspendLayout();
            this.grpBxDeduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payRollSystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRecordsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayRecordsdataGridViewOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRecordsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRollSystemDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelfirstName
            // 
            this.labelfirstName.AutoSize = true;
            this.labelfirstName.Location = new System.Drawing.Point(11, 53);
            this.labelfirstName.Name = "labelfirstName";
            this.labelfirstName.Size = new System.Drawing.Size(65, 14);
            this.labelfirstName.TabIndex = 0;
            this.labelfirstName.Text = "First Name";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(11, 81);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(64, 14);
            this.labelLastname.TabIndex = 1;
            this.labelLastname.Text = "Last Name";
            // 
            // labelEmployeeId
            // 
            this.labelEmployeeId.AutoSize = true;
            this.labelEmployeeId.Location = new System.Drawing.Point(10, 25);
            this.labelEmployeeId.Name = "labelEmployeeId";
            this.labelEmployeeId.Size = new System.Drawing.Size(76, 14);
            this.labelEmployeeId.TabIndex = 2;
            this.labelEmployeeId.Text = "Employee ID";
            // 
            // labelSsnitNumber
            // 
            this.labelSsnitNumber.AutoSize = true;
            this.labelSsnitNumber.Location = new System.Drawing.Point(12, 109);
            this.labelSsnitNumber.Name = "labelSsnitNumber";
            this.labelSsnitNumber.Size = new System.Drawing.Size(80, 14);
            this.labelSsnitNumber.TabIndex = 4;
            this.labelSsnitNumber.Text = "Ssnit Number";
            // 
            // labelPayDate
            // 
            this.labelPayDate.AutoSize = true;
            this.labelPayDate.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayDate.Location = new System.Drawing.Point(330, 104);
            this.labelPayDate.Name = "labelPayDate";
            this.labelPayDate.Size = new System.Drawing.Size(63, 13);
            this.labelPayDate.TabIndex = 5;
            this.labelPayDate.Text = "Pay Date";
            // 
            // labelPayMonth
            // 
            this.labelPayMonth.AutoSize = true;
            this.labelPayMonth.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayMonth.Location = new System.Drawing.Point(330, 136);
            this.labelPayMonth.Name = "labelPayMonth";
            this.labelPayMonth.Size = new System.Drawing.Size(77, 13);
            this.labelPayMonth.TabIndex = 6;
            this.labelPayMonth.Text = "Pay Month";
            // 
            // labelSsnitEmployer
            // 
            this.labelSsnitEmployer.AutoSize = true;
            this.labelSsnitEmployer.Location = new System.Drawing.Point(6, 50);
            this.labelSsnitEmployer.Name = "labelSsnitEmployer";
            this.labelSsnitEmployer.Size = new System.Drawing.Size(90, 14);
            this.labelSsnitEmployer.TabIndex = 9;
            this.labelSsnitEmployer.Text = "Ssnit: Employer";
            // 
            // labelSsnitEmployee
            // 
            this.labelSsnitEmployee.AutoSize = true;
            this.labelSsnitEmployee.Location = new System.Drawing.Point(8, 24);
            this.labelSsnitEmployee.Name = "labelSsnitEmployee";
            this.labelSsnitEmployee.Size = new System.Drawing.Size(93, 14);
            this.labelSsnitEmployee.TabIndex = 8;
            this.labelSsnitEmployee.Text = "Ssnit: Employee";
            // 
            // labelBasicSalary
            // 
            this.labelBasicSalary.AutoSize = true;
            this.labelBasicSalary.Location = new System.Drawing.Point(9, 24);
            this.labelBasicSalary.Name = "labelBasicSalary";
            this.labelBasicSalary.Size = new System.Drawing.Size(70, 14);
            this.labelBasicSalary.TabIndex = 7;
            this.labelBasicSalary.Text = "Basic Salary";
            // 
            // textEmployeeId
            // 
            this.textEmployeeId.Location = new System.Drawing.Point(105, 22);
            this.textEmployeeId.Name = "textEmployeeId";
            this.textEmployeeId.Size = new System.Drawing.Size(126, 20);
            this.textEmployeeId.TabIndex = 1;
            this.textEmployeeId.TextChanged += new System.EventHandler(this.textEmployeeId_TextChanged);
            // 
            // textSsnitNumber
            // 
            this.textSsnitNumber.Location = new System.Drawing.Point(106, 109);
            this.textSsnitNumber.Name = "textSsnitNumber";
            this.textSsnitNumber.Size = new System.Drawing.Size(178, 20);
            this.textSsnitNumber.TabIndex = 4;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(105, 51);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(178, 20);
            this.textFirstName.TabIndex = 2;
            this.textFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // textBasicSalary
            // 
            this.textBasicSalary.Location = new System.Drawing.Point(95, 25);
            this.textBasicSalary.Name = "textBasicSalary";
            this.textBasicSalary.Size = new System.Drawing.Size(178, 20);
            this.textBasicSalary.TabIndex = 7;
            this.textBasicSalary.TextChanged += new System.EventHandler(this.textBasicSalary_TextChanged);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(106, 79);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(178, 20);
            this.textLastName.TabIndex = 3;
            // 
            // textTotalEarning
            // 
            this.textTotalEarning.Location = new System.Drawing.Point(99, 159);
            this.textTotalEarning.Name = "textTotalEarning";
            this.textTotalEarning.Size = new System.Drawing.Size(179, 20);
            this.textTotalEarning.TabIndex = 11;
            this.textTotalEarning.TextChanged += new System.EventHandler(this.textTotalEarning_TextChanged);
            this.textTotalEarning.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTotalEarning_KeyPress);
            // 
            // comboBxPayMonth
            // 
            this.comboBxPayMonth.FormattingEnabled = true;
            this.comboBxPayMonth.Items.AddRange(new object[] {
            "Select Month",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBxPayMonth.Location = new System.Drawing.Point(449, 133);
            this.comboBxPayMonth.Name = "comboBxPayMonth";
            this.comboBxPayMonth.Size = new System.Drawing.Size(178, 21);
            this.comboBxPayMonth.TabIndex = 6;
            // 
            // groupBxButton
            // 
            this.groupBxButton.Controls.Add(this.btnResetDeduction);
            this.groupBxButton.Controls.Add(this.button2);
            this.groupBxButton.Controls.Add(this.button1);
            this.groupBxButton.Controls.Add(this.btnPaySlip);
            this.groupBxButton.Controls.Add(this.CheckDeduction);
            this.groupBxButton.Controls.Add(this.btnCalculate);
            this.groupBxButton.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBxButton.Location = new System.Drawing.Point(12, 378);
            this.groupBxButton.Name = "groupBxButton";
            this.groupBxButton.Size = new System.Drawing.Size(647, 46);
            this.groupBxButton.TabIndex = 31;
            this.groupBxButton.TabStop = false;
            this.groupBxButton.Text = "Menu";
            // 
            // btnResetDeduction
            // 
            this.btnResetDeduction.Location = new System.Drawing.Point(567, 12);
            this.btnResetDeduction.Name = "btnResetDeduction";
            this.btnResetDeduction.Size = new System.Drawing.Size(64, 25);
            this.btnResetDeduction.TabIndex = 33;
            this.btnResetDeduction.Text = "Reset";
            this.btnResetDeduction.UseVisualStyleBackColor = true;
            this.btnResetDeduction.Click += new System.EventHandler(this.btnResetDeduction_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "&Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPaySlip
            // 
            this.btnPaySlip.Location = new System.Drawing.Point(123, 14);
            this.btnPaySlip.Name = "btnPaySlip";
            this.btnPaySlip.Size = new System.Drawing.Size(58, 26);
            this.btnPaySlip.TabIndex = 0;
            this.btnPaySlip.Text = "Pay Slip";
            this.btnPaySlip.UseVisualStyleBackColor = true;
            this.btnPaySlip.Click += new System.EventHandler(this.btnPaySlip_Click);
            // 
            // CheckDeduction
            // 
            this.CheckDeduction.Location = new System.Drawing.Point(23, 15);
            this.CheckDeduction.Name = "CheckDeduction";
            this.CheckDeduction.Size = new System.Drawing.Size(66, 25);
            this.CheckDeduction.TabIndex = 0;
            this.CheckDeduction.Text = "Calculate";
            this.CheckDeduction.UseVisualStyleBackColor = true;
            this.CheckDeduction.Click += new System.EventHandler(this.resetDeduction_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(321, 13);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(66, 26);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Save";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(573, 435);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpBxEmployeeInfo
            // 
            this.grpBxEmployeeInfo.Controls.Add(this.buttonGet);
            this.grpBxEmployeeInfo.Controls.Add(this.labelEmployeeId);
            this.grpBxEmployeeInfo.Controls.Add(this.labelfirstName);
            this.grpBxEmployeeInfo.Controls.Add(this.labelLastname);
            this.grpBxEmployeeInfo.Controls.Add(this.labelSsnitNumber);
            this.grpBxEmployeeInfo.Controls.Add(this.textEmployeeId);
            this.grpBxEmployeeInfo.Controls.Add(this.textSsnitNumber);
            this.grpBxEmployeeInfo.Controls.Add(this.textLastName);
            this.grpBxEmployeeInfo.Controls.Add(this.textFirstName);
            this.grpBxEmployeeInfo.Font = new System.Drawing.Font("Lucida Bright", 8F);
            this.grpBxEmployeeInfo.Location = new System.Drawing.Point(12, 13);
            this.grpBxEmployeeInfo.Name = "grpBxEmployeeInfo";
            this.grpBxEmployeeInfo.Size = new System.Drawing.Size(299, 165);
            this.grpBxEmployeeInfo.TabIndex = 33;
            this.grpBxEmployeeInfo.TabStop = false;
            this.grpBxEmployeeInfo.Text = "EMPLOYEE INFO";
            this.grpBxEmployeeInfo.Enter += new System.EventHandler(this.grpBxEmployeeInfo_Enter);
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(238, 21);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(46, 22);
            this.buttonGet.TabIndex = 0;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // grpBxSalaryInfo
            // 
            this.grpBxSalaryInfo.Controls.Add(this.btnTotalEarning);
            this.grpBxSalaryInfo.Controls.Add(this.grpBxAllowance);
            this.grpBxSalaryInfo.Controls.Add(this.textTotalEarning);
            this.grpBxSalaryInfo.Controls.Add(this.labelBasicSalary);
            this.grpBxSalaryInfo.Controls.Add(this.textBasicSalary);
            this.grpBxSalaryInfo.Font = new System.Drawing.Font("Lucida Bright", 8F);
            this.grpBxSalaryInfo.Location = new System.Drawing.Point(12, 186);
            this.grpBxSalaryInfo.Name = "grpBxSalaryInfo";
            this.grpBxSalaryInfo.Size = new System.Drawing.Size(301, 188);
            this.grpBxSalaryInfo.TabIndex = 35;
            this.grpBxSalaryInfo.TabStop = false;
            this.grpBxSalaryInfo.Text = "SALARY INFO";
            // 
            // btnTotalEarning
            // 
            this.btnTotalEarning.Location = new System.Drawing.Point(6, 158);
            this.btnTotalEarning.Name = "btnTotalEarning";
            this.btnTotalEarning.Size = new System.Drawing.Size(84, 22);
            this.btnTotalEarning.TabIndex = 32;
            this.btnTotalEarning.Text = "Total Earning";
            this.btnTotalEarning.UseVisualStyleBackColor = true;
            this.btnTotalEarning.Click += new System.EventHandler(this.btnTotalEarning_Click);
            // 
            // grpBxAllowance
            // 
            this.grpBxAllowance.Controls.Add(this.textHousing);
            this.grpBxAllowance.Controls.Add(this._textDressing);
            this.grpBxAllowance.Controls.Add(this._textTransport);
            this.grpBxAllowance.Controls.Add(this._textHousing);
            this.grpBxAllowance.Controls.Add(this.textDressing);
            this.grpBxAllowance.Controls.Add(this.textTransport);
            this.grpBxAllowance.Controls.Add(this.labelDressing);
            this.grpBxAllowance.Controls.Add(this.labelTransport);
            this.grpBxAllowance.Controls.Add(this.labelHousing);
            this.grpBxAllowance.Location = new System.Drawing.Point(7, 47);
            this.grpBxAllowance.Name = "grpBxAllowance";
            this.grpBxAllowance.Size = new System.Drawing.Size(273, 102);
            this.grpBxAllowance.TabIndex = 30;
            this.grpBxAllowance.TabStop = false;
            this.grpBxAllowance.Text = "Allowance";
            // 
            // textHousing
            // 
            this.textHousing.Location = new System.Drawing.Point(92, 18);
            this.textHousing.Name = "textHousing";
            this.textHousing.Size = new System.Drawing.Size(100, 20);
            this.textHousing.TabIndex = 14;
            // 
            // _textDressing
            // 
            this._textDressing.AutoSize = true;
            this._textDressing.Location = new System.Drawing.Point(199, 72);
            this._textDressing.Name = "_textDressing";
            this._textDressing.Size = new System.Drawing.Size(15, 14);
            this._textDressing.TabIndex = 13;
            this._textDressing.Text = "%";
            // 
            // _textTransport
            // 
            this._textTransport.AutoSize = true;
            this._textTransport.Location = new System.Drawing.Point(199, 49);
            this._textTransport.Name = "_textTransport";
            this._textTransport.Size = new System.Drawing.Size(15, 14);
            this._textTransport.TabIndex = 12;
            this._textTransport.Text = "%";
            // 
            // _textHousing
            // 
            this._textHousing.AutoSize = true;
            this._textHousing.Location = new System.Drawing.Point(199, 21);
            this._textHousing.Name = "_textHousing";
            this._textHousing.Size = new System.Drawing.Size(15, 14);
            this._textHousing.TabIndex = 11;
            this._textHousing.Text = "%";
            // 
            // textDressing
            // 
            this.textDressing.Location = new System.Drawing.Point(92, 72);
            this.textDressing.Name = "textDressing";
            this.textDressing.Size = new System.Drawing.Size(100, 20);
            this.textDressing.TabIndex = 10;
            this.textDressing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDressing_KeyPress);
            // 
            // textTransport
            // 
            this.textTransport.Location = new System.Drawing.Point(92, 46);
            this.textTransport.Name = "textTransport";
            this.textTransport.Size = new System.Drawing.Size(100, 20);
            this.textTransport.TabIndex = 9;
            this.textTransport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTransport_KeyPress);
            // 
            // labelDressing
            // 
            this.labelDressing.AutoSize = true;
            this.labelDressing.Location = new System.Drawing.Point(12, 77);
            this.labelDressing.Name = "labelDressing";
            this.labelDressing.Size = new System.Drawing.Size(55, 14);
            this.labelDressing.TabIndex = 2;
            this.labelDressing.Text = "Dressing";
            // 
            // labelTransport
            // 
            this.labelTransport.AutoSize = true;
            this.labelTransport.Location = new System.Drawing.Point(10, 49);
            this.labelTransport.Name = "labelTransport";
            this.labelTransport.Size = new System.Drawing.Size(59, 14);
            this.labelTransport.TabIndex = 1;
            this.labelTransport.Text = "Transport";
            // 
            // labelHousing
            // 
            this.labelHousing.AutoSize = true;
            this.labelHousing.Location = new System.Drawing.Point(11, 21);
            this.labelHousing.Name = "labelHousing";
            this.labelHousing.Size = new System.Drawing.Size(51, 14);
            this.labelHousing.TabIndex = 0;
            this.labelHousing.Text = "Housing";
            // 
            // SearchPaymentId
            // 
            this.SearchPaymentId.AutoSize = true;
            this.SearchPaymentId.Location = new System.Drawing.Point(12, 439);
            this.SearchPaymentId.Name = "SearchPaymentId";
            this.SearchPaymentId.Size = new System.Drawing.Size(62, 13);
            this.SearchPaymentId.TabIndex = 18;
            this.SearchPaymentId.Text = "Payment ID";
            // 
            // _SearchPaymentID
            // 
            this._SearchPaymentID.Location = new System.Drawing.Point(79, 437);
            this._SearchPaymentID.Name = "_SearchPaymentID";
            this._SearchPaymentID.Size = new System.Drawing.Size(91, 20);
            this._SearchPaymentID.TabIndex = 17;
            this._SearchPaymentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPaymentID_KeyPress);
            // 
            // grpBxDeduction
            // 
            this.grpBxDeduction.Controls.Add(this._textnetSalary);
            this.grpBxDeduction.Controls.Add(this._textTotalDeduction);
            this.grpBxDeduction.Controls.Add(this._textSsnitEmployer);
            this.grpBxDeduction.Controls.Add(this._textIncomeTax);
            this.grpBxDeduction.Controls.Add(this._textSsnitEmployee);
            this.grpBxDeduction.Controls.Add(this.lblNetSalary);
            this.grpBxDeduction.Controls.Add(this.lblTotalDeduction);
            this.grpBxDeduction.Controls.Add(this.lblIncomeTax);
            this.grpBxDeduction.Controls.Add(this.labelSsnitEmployee);
            this.grpBxDeduction.Controls.Add(this.labelSsnitEmployer);
            this.grpBxDeduction.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxDeduction.Location = new System.Drawing.Point(324, 189);
            this.grpBxDeduction.Name = "grpBxDeduction";
            this.grpBxDeduction.Size = new System.Drawing.Size(333, 186);
            this.grpBxDeduction.TabIndex = 36;
            this.grpBxDeduction.TabStop = false;
            this.grpBxDeduction.Text = "DEDUCTIONS";
            // 
            // _textnetSalary
            // 
            this._textnetSalary.AutoSize = true;
            this._textnetSalary.Location = new System.Drawing.Point(121, 134);
            this._textnetSalary.Name = "_textnetSalary";
            this._textnetSalary.Size = new System.Drawing.Size(0, 14);
            this._textnetSalary.TabIndex = 26;
            // 
            // _textTotalDeduction
            // 
            this._textTotalDeduction.AutoSize = true;
            this._textTotalDeduction.Location = new System.Drawing.Point(123, 102);
            this._textTotalDeduction.Name = "_textTotalDeduction";
            this._textTotalDeduction.Size = new System.Drawing.Size(0, 14);
            this._textTotalDeduction.TabIndex = 25;
            // 
            // _textSsnitEmployer
            // 
            this._textSsnitEmployer.AutoSize = true;
            this._textSsnitEmployer.Location = new System.Drawing.Point(122, 47);
            this._textSsnitEmployer.Name = "_textSsnitEmployer";
            this._textSsnitEmployer.Size = new System.Drawing.Size(0, 14);
            this._textSsnitEmployer.TabIndex = 24;
            this._textSsnitEmployer.Click += new System.EventHandler(this._textSsnitEmployer_Click);
            // 
            // _textIncomeTax
            // 
            this._textIncomeTax.AutoSize = true;
            this._textIncomeTax.Location = new System.Drawing.Point(122, 75);
            this._textIncomeTax.Name = "_textIncomeTax";
            this._textIncomeTax.Size = new System.Drawing.Size(0, 14);
            this._textIncomeTax.TabIndex = 23;
            // 
            // _textSsnitEmployee
            // 
            this._textSsnitEmployee.AutoSize = true;
            this._textSsnitEmployee.Location = new System.Drawing.Point(122, 21);
            this._textSsnitEmployee.Name = "_textSsnitEmployee";
            this._textSsnitEmployee.Size = new System.Drawing.Size(0, 14);
            this._textSsnitEmployee.TabIndex = 22;
            // 
            // lblNetSalary
            // 
            this.lblNetSalary.AutoSize = true;
            this.lblNetSalary.Location = new System.Drawing.Point(7, 133);
            this.lblNetSalary.Name = "lblNetSalary";
            this.lblNetSalary.Size = new System.Drawing.Size(60, 14);
            this.lblNetSalary.TabIndex = 21;
            this.lblNetSalary.Text = "Net Salary";
            // 
            // lblTotalDeduction
            // 
            this.lblTotalDeduction.AutoSize = true;
            this.lblTotalDeduction.Location = new System.Drawing.Point(6, 106);
            this.lblTotalDeduction.Name = "lblTotalDeduction";
            this.lblTotalDeduction.Size = new System.Drawing.Size(95, 14);
            this.lblTotalDeduction.TabIndex = 20;
            this.lblTotalDeduction.Text = "Total Deduction";
            // 
            // lblIncomeTax
            // 
            this.lblIncomeTax.AutoSize = true;
            this.lblIncomeTax.Location = new System.Drawing.Point(7, 77);
            this.lblIncomeTax.Name = "lblIncomeTax";
            this.lblIncomeTax.Size = new System.Drawing.Size(71, 14);
            this.lblIncomeTax.TabIndex = 19;
            this.lblIncomeTax.Text = "Income Tax";
            // 
            // payRollSystemDBDataSet
            // 
            this.payRollSystemDBDataSet.DataSetName = "PayRollSystemDBDataSet";
            this.payRollSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payRecordsBindingSource1
            // 
            this.payRecordsBindingSource1.DataMember = "PayRecords";
            this.payRecordsBindingSource1.DataSource = this.payRollSystemDBDataSet;
            // 
            // payRecordsTableAdapter
            // 
            this.payRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // PayRecordsdataGridViewOne
            // 
            this.PayRecordsdataGridViewOne.AllowUserToAddRows = false;
            this.PayRecordsdataGridViewOne.AllowUserToDeleteRows = false;
            this.PayRecordsdataGridViewOne.AllowUserToResizeColumns = false;
            this.PayRecordsdataGridViewOne.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PayRecordsdataGridViewOne.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PayRecordsdataGridViewOne.AutoGenerateColumns = false;
            this.PayRecordsdataGridViewOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PayRecordsdataGridViewOne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentIdDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.sSNITNumberDataGridViewTextBoxColumn,
            this.payDateDataGridViewTextBoxColumn,
            this.payMonthDataGridViewTextBoxColumn,
            this.basicSalaryDataGridViewTextBoxColumn,
            this.housingDataGridViewTextBoxColumn,
            this.transportDataGridViewTextBoxColumn,
            this.dressingDataGridViewTextBoxColumn,
            this.totalEarningDataGridViewTextBoxColumn,
            this.sSNITEmployeeDataGridViewTextBoxColumn,
            this.sSNITEmployerDataGridViewTextBoxColumn,
            this.incomeTaxDataGridViewTextBoxColumn,
            this.totalDeductionDataGridViewTextBoxColumn,
            this.netSalaryDataGridViewTextBoxColumn});
            this.PayRecordsdataGridViewOne.DataSource = this.payRecordsBindingSource3;
            this.PayRecordsdataGridViewOne.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.PayRecordsdataGridViewOne.Location = new System.Drawing.Point(11, 464);
            this.PayRecordsdataGridViewOne.Name = "PayRecordsdataGridViewOne";
            this.PayRecordsdataGridViewOne.ReadOnly = true;
            this.PayRecordsdataGridViewOne.RowHeadersWidth = 50;
            this.PayRecordsdataGridViewOne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PayRecordsdataGridViewOne.Size = new System.Drawing.Size(648, 150);
            this.PayRecordsdataGridViewOne.TabIndex = 37;
            this.PayRecordsdataGridViewOne.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PayRecordsdataGridViewOne_CellClick);
            // 
            // paymentIdDataGridViewTextBoxColumn
            // 
            this.paymentIdDataGridViewTextBoxColumn.DataPropertyName = "PaymentId";
            this.paymentIdDataGridViewTextBoxColumn.HeaderText = "PaymentId";
            this.paymentIdDataGridViewTextBoxColumn.Name = "paymentIdDataGridViewTextBoxColumn";
            this.paymentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sSNITNumberDataGridViewTextBoxColumn
            // 
            this.sSNITNumberDataGridViewTextBoxColumn.DataPropertyName = "SSNITNumber";
            this.sSNITNumberDataGridViewTextBoxColumn.HeaderText = "SSNITNumber";
            this.sSNITNumberDataGridViewTextBoxColumn.Name = "sSNITNumberDataGridViewTextBoxColumn";
            this.sSNITNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payDateDataGridViewTextBoxColumn
            // 
            this.payDateDataGridViewTextBoxColumn.DataPropertyName = "PayDate";
            this.payDateDataGridViewTextBoxColumn.HeaderText = "PayDate";
            this.payDateDataGridViewTextBoxColumn.Name = "payDateDataGridViewTextBoxColumn";
            this.payDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payMonthDataGridViewTextBoxColumn
            // 
            this.payMonthDataGridViewTextBoxColumn.DataPropertyName = "PayMonth";
            this.payMonthDataGridViewTextBoxColumn.HeaderText = "PayMonth";
            this.payMonthDataGridViewTextBoxColumn.Name = "payMonthDataGridViewTextBoxColumn";
            this.payMonthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // basicSalaryDataGridViewTextBoxColumn
            // 
            this.basicSalaryDataGridViewTextBoxColumn.DataPropertyName = "BasicSalary";
            this.basicSalaryDataGridViewTextBoxColumn.HeaderText = "BasicSalary";
            this.basicSalaryDataGridViewTextBoxColumn.Name = "basicSalaryDataGridViewTextBoxColumn";
            this.basicSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // housingDataGridViewTextBoxColumn
            // 
            this.housingDataGridViewTextBoxColumn.DataPropertyName = "Housing";
            this.housingDataGridViewTextBoxColumn.HeaderText = "Housing";
            this.housingDataGridViewTextBoxColumn.Name = "housingDataGridViewTextBoxColumn";
            this.housingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transportDataGridViewTextBoxColumn
            // 
            this.transportDataGridViewTextBoxColumn.DataPropertyName = "Transport";
            this.transportDataGridViewTextBoxColumn.HeaderText = "Transport";
            this.transportDataGridViewTextBoxColumn.Name = "transportDataGridViewTextBoxColumn";
            this.transportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dressingDataGridViewTextBoxColumn
            // 
            this.dressingDataGridViewTextBoxColumn.DataPropertyName = "Dressing";
            this.dressingDataGridViewTextBoxColumn.HeaderText = "Dressing";
            this.dressingDataGridViewTextBoxColumn.Name = "dressingDataGridViewTextBoxColumn";
            this.dressingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalEarningDataGridViewTextBoxColumn
            // 
            this.totalEarningDataGridViewTextBoxColumn.DataPropertyName = "TotalEarning";
            this.totalEarningDataGridViewTextBoxColumn.HeaderText = "TotalEarning";
            this.totalEarningDataGridViewTextBoxColumn.Name = "totalEarningDataGridViewTextBoxColumn";
            this.totalEarningDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sSNITEmployeeDataGridViewTextBoxColumn
            // 
            this.sSNITEmployeeDataGridViewTextBoxColumn.DataPropertyName = "SSNITEmployee";
            this.sSNITEmployeeDataGridViewTextBoxColumn.HeaderText = "SSNITEmployee";
            this.sSNITEmployeeDataGridViewTextBoxColumn.Name = "sSNITEmployeeDataGridViewTextBoxColumn";
            this.sSNITEmployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sSNITEmployerDataGridViewTextBoxColumn
            // 
            this.sSNITEmployerDataGridViewTextBoxColumn.DataPropertyName = "SSNITEmployer";
            this.sSNITEmployerDataGridViewTextBoxColumn.HeaderText = "SSNITEmployer";
            this.sSNITEmployerDataGridViewTextBoxColumn.Name = "sSNITEmployerDataGridViewTextBoxColumn";
            this.sSNITEmployerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incomeTaxDataGridViewTextBoxColumn
            // 
            this.incomeTaxDataGridViewTextBoxColumn.DataPropertyName = "IncomeTax";
            this.incomeTaxDataGridViewTextBoxColumn.HeaderText = "IncomeTax";
            this.incomeTaxDataGridViewTextBoxColumn.Name = "incomeTaxDataGridViewTextBoxColumn";
            this.incomeTaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDeductionDataGridViewTextBoxColumn
            // 
            this.totalDeductionDataGridViewTextBoxColumn.DataPropertyName = "TotalDeduction";
            this.totalDeductionDataGridViewTextBoxColumn.HeaderText = "TotalDeduction";
            this.totalDeductionDataGridViewTextBoxColumn.Name = "totalDeductionDataGridViewTextBoxColumn";
            this.totalDeductionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netSalaryDataGridViewTextBoxColumn
            // 
            this.netSalaryDataGridViewTextBoxColumn.DataPropertyName = "NetSalary";
            this.netSalaryDataGridViewTextBoxColumn.HeaderText = "NetSalary";
            this.netSalaryDataGridViewTextBoxColumn.Name = "netSalaryDataGridViewTextBoxColumn";
            this.netSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payRecordsBindingSource3
            // 
            this.payRecordsBindingSource3.DataMember = "PayRecords";
            this.payRecordsBindingSource3.DataSource = this.payRollSystemDBDataSet1;
            // 
            // payRollSystemDBDataSet1
            // 
            this.payRollSystemDBDataSet1.DataSetName = "PayRollSystemDBDataSet1";
            this.payRollSystemDBDataSet1.RemotingFormat = System.Data.SerializationFormat.Binary;
            this.payRollSystemDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payRecordsTableAdapter1
            // 
            this.payRecordsTableAdapter1.ClearBeforeFill = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(338, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 26);
            this.lblTitle.TabIndex = 38;
            this.lblTitle.Text = "Monthly End Pay ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Full Name :";
            // 
            // _lblFullName
            // 
            this._lblFullName.AutoSize = true;
            this._lblFullName.Font = new System.Drawing.Font("Felix Titling", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFullName.Location = new System.Drawing.Point(451, 67);
            this._lblFullName.Name = "_lblFullName";
            this._lblFullName.Size = new System.Drawing.Size(0, 23);
            this._lblFullName.TabIndex = 40;
            // 
            // _lblSystemDate
            // 
            this._lblSystemDate.AutoSize = true;
            this._lblSystemDate.Location = new System.Drawing.Point(446, 107);
            this._lblSystemDate.Name = "_lblSystemDate";
            this._lblSystemDate.Size = new System.Drawing.Size(0, 13);
            this._lblSystemDate.TabIndex = 41;
            // 
            // _SearchFullName
            // 
            this._SearchFullName.Location = new System.Drawing.Point(247, 436);
            this._SearchFullName.Name = "_SearchFullName";
            this._SearchFullName.Size = new System.Drawing.Size(100, 20);
            this._SearchFullName.TabIndex = 42;
            // 
            // SearchFullName
            // 
            this.SearchFullName.AutoSize = true;
            this.SearchFullName.Location = new System.Drawing.Point(182, 440);
            this.SearchFullName.Name = "SearchFullName";
            this.SearchFullName.Size = new System.Drawing.Size(54, 13);
            this.SearchFullName.TabIndex = 43;
            this.SearchFullName.Text = "Full Name";
            this.SearchFullName.Click += new System.EventHandler(this._SearchFullName_Click);
            // 
            // SearchSSNIT
            // 
            this.SearchSSNIT.AutoSize = true;
            this.SearchSSNIT.Location = new System.Drawing.Point(356, 440);
            this.SearchSSNIT.Name = "SearchSSNIT";
            this.SearchSSNIT.Size = new System.Drawing.Size(59, 13);
            this.SearchSSNIT.TabIndex = 44;
            this.SearchSSNIT.Text = "SSNIT No.";
            // 
            // _SearchSSNITNo
            // 
            this._SearchSSNITNo.Location = new System.Drawing.Point(418, 436);
            this._SearchSSNITNo.Name = "_SearchSSNITNo";
            this._SearchSSNITNo.Size = new System.Drawing.Size(100, 20);
            this._SearchSSNITNo.TabIndex = 45;
            // 
            // Pay_Roll_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 624);
            this.Controls.Add(this._SearchSSNITNo);
            this.Controls.Add(this.SearchSSNIT);
            this.Controls.Add(this.SearchFullName);
            this.Controls.Add(this._SearchFullName);
            this.Controls.Add(this._lblSystemDate);
            this.Controls.Add(this._lblFullName);
            this.Controls.Add(this.SearchPaymentId);
            this.Controls.Add(this._SearchPaymentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.PayRecordsdataGridViewOne);
            this.Controls.Add(this.grpBxDeduction);
            this.Controls.Add(this.grpBxSalaryInfo);
            this.Controls.Add(this.labelPayDate);
            this.Controls.Add(this.grpBxEmployeeInfo);
            this.Controls.Add(this.comboBxPayMonth);
            this.Controls.Add(this.groupBxButton);
            this.Controls.Add(this.labelPayMonth);
            this.Name = "Pay_Roll_Calculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Employee Payroll Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.groupBxButton.ResumeLayout(false);
            this.grpBxEmployeeInfo.ResumeLayout(false);
            this.grpBxEmployeeInfo.PerformLayout();
            this.grpBxSalaryInfo.ResumeLayout(false);
            this.grpBxSalaryInfo.PerformLayout();
            this.grpBxAllowance.ResumeLayout(false);
            this.grpBxAllowance.PerformLayout();
            this.grpBxDeduction.ResumeLayout(false);
            this.grpBxDeduction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payRollSystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRecordsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayRecordsdataGridViewOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRecordsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRollSystemDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelfirstName;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelEmployeeId;
        private System.Windows.Forms.Label labelSsnitNumber;
        private System.Windows.Forms.Label labelPayDate;
        private System.Windows.Forms.Label labelPayMonth;
        private System.Windows.Forms.Label labelSsnitEmployer;
        private System.Windows.Forms.Label labelSsnitEmployee;
        private System.Windows.Forms.Label labelBasicSalary;
        private System.Windows.Forms.TextBox textEmployeeId;
        private System.Windows.Forms.TextBox textSsnitNumber;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textBasicSalary;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textTotalEarning;
        private System.Windows.Forms.ComboBox comboBxPayMonth;
        private System.Windows.Forms.GroupBox groupBxButton;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPaySlip;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpBxEmployeeInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.GroupBox grpBxSalaryInfo;
        private System.Windows.Forms.GroupBox grpBxAllowance;
        private System.Windows.Forms.TextBox textDressing;
        private System.Windows.Forms.Label labelDressing;
        private System.Windows.Forms.Label labelTransport;
        private System.Windows.Forms.Label labelHousing;
        private System.Windows.Forms.GroupBox grpBxDeduction;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Button CheckDeduction;
        private System.Windows.Forms.Button btnTotalEarning;
        private PayRollSystemDBDataSet5 payRollSystemDBDataSet5;
        private PayRollSystemDBDataSet5TableAdapters.PayRecordsTableAdapter payRecordsTableAdapter2;
        private PayRollSystemDBDataSet payRollSystemDBDataSet;
        private System.Windows.Forms.BindingSource payRecordsBindingSource1;
        private PayRollSystemDBDataSetTableAdapters.PayRecordsTableAdapter payRecordsTableAdapter;
        private System.Windows.Forms.DataGridView PayRecordsdataGridViewOne;
        private System.Windows.Forms.BindingSource payRecordsBindingSource3;
        private PayRollSystemDBDataSet1TableAdapters.PayRecordsTableAdapter payRecordsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNITNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dressingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEarningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNITEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNITEmployerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDeductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netSalaryDataGridViewTextBoxColumn;
        protected internal PayRollSystemDBDataSet1 payRollSystemDBDataSet1;
        private System.Windows.Forms.Label SearchPaymentId;
        private System.Windows.Forms.TextBox _SearchPaymentID;
        private System.Windows.Forms.Label lblNetSalary;
        private System.Windows.Forms.Label lblTotalDeduction;
        private System.Windows.Forms.Label lblIncomeTax;
        private System.Windows.Forms.Button btnResetDeduction;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblFullName;
        private System.Windows.Forms.Label _lblSystemDate;
        private System.Windows.Forms.Label _textnetSalary;
        private System.Windows.Forms.Label _textTotalDeduction;
        private System.Windows.Forms.Label _textSsnitEmployer;
        private System.Windows.Forms.Label _textIncomeTax;
        private System.Windows.Forms.Label _textSsnitEmployee;
        private System.Windows.Forms.Label _textDressing;
        private System.Windows.Forms.Label _textTransport;
        private System.Windows.Forms.Label _textHousing;
        private System.Windows.Forms.TextBox textTransport;
        private System.Windows.Forms.TextBox textHousing;
        private System.Windows.Forms.TextBox _SearchFullName;
        private System.Windows.Forms.Label SearchFullName;
        private System.Windows.Forms.Label SearchSSNIT;
        private System.Windows.Forms.TextBox _SearchSSNITNo;
    }
}