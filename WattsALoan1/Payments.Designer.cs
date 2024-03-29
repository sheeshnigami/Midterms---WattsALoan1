﻿namespace WattsALoan1
{
    partial class Payments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsEmployees = new System.Data.DataSet();
            this.tblEmployee = new System.Data.DataTable();
            this.colEmployeeNumber = new System.Data.DataColumn();
            this.colFirstName = new System.Data.DataColumn();
            this.colLastName = new System.Data.DataColumn();
            this.colTitle = new System.Data.DataColumn();
            this.colHourlySalary = new System.Data.DataColumn();
            this.colEmployeeDetails = new System.Data.DataColumn();
            this.dsLoansAllocations = new System.Data.DataSet();
            this.tblLoan = new System.Data.DataTable();
            this.colDateAllocated = new System.Data.DataColumn();
            this.colLoanNumber = new System.Data.DataColumn();
            this.colPreparedBy = new System.Data.DataColumn();
            this.colPreparedFor = new System.Data.DataColumn();
            this.colPrincipal = new System.Data.DataColumn();
            this.colInterestRate = new System.Data.DataColumn();
            this.colPeriods = new System.Data.DataColumn();
            this.colInterestEarned = new System.Data.DataColumn();
            this.colFutureValue = new System.Data.DataColumn();
            this.colMonthlyPayment = new System.Data.DataColumn();
            this.dsPayments = new System.Data.DataSet();
            this.tblPayment = new System.Data.DataTable();
            this.colPaymentNumber = new System.Data.DataColumn();
            this.colPaymentDate = new System.Data.DataColumn();
            this.colReceivedBy = new System.Data.DataColumn();
            this.colPaymentFor = new System.Data.DataColumn();
            this.colPaymentAmount = new System.Data.DataColumn();
            this.colBalance = new System.Data.DataColumn();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.btnLoans = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.paymentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.paymentForDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.paymentAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLoansAllocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // dsEmployees
            // 
            this.dsEmployees.DataSetName = "Employees";
            this.dsEmployees.Tables.AddRange(new System.Data.DataTable[] {
            this.tblEmployee});
            // 
            // tblEmployee
            // 
            this.tblEmployee.Columns.AddRange(new System.Data.DataColumn[] {
            this.colEmployeeNumber,
            this.colFirstName,
            this.colLastName,
            this.colTitle,
            this.colHourlySalary,
            this.colEmployeeDetails});
            this.tblEmployee.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "EmployeeNumber"}, false)});
            this.tblEmployee.TableName = "Employee";
            // 
            // colEmployeeNumber
            // 
            this.colEmployeeNumber.AllowDBNull = false;
            this.colEmployeeNumber.ColumnName = "EmployeeNumber";
            // 
            // colFirstName
            // 
            this.colFirstName.ColumnName = "FirstName";
            // 
            // colLastName
            // 
            this.colLastName.AllowDBNull = false;
            this.colLastName.ColumnName = "LastName";
            // 
            // colTitle
            // 
            this.colTitle.ColumnName = "Title";
            // 
            // colHourlySalary
            // 
            this.colHourlySalary.ColumnName = "HourlySalary";
            this.colHourlySalary.DataType = typeof(double);
            this.colHourlySalary.DefaultValue = 8.75D;
            // 
            // colEmployeeDetails
            // 
            this.colEmployeeDetails.ColumnName = "EmployeeDetails";
            this.colEmployeeDetails.Expression = "EmployeeNumber + \': \' +FirstName + \' \' + LastName";
            this.colEmployeeDetails.ReadOnly = true;
            // 
            // dsLoansAllocations
            // 
            this.dsLoansAllocations.DataSetName = "LoansAllocations";
            this.dsLoansAllocations.Tables.AddRange(new System.Data.DataTable[] {
            this.tblLoan});
            // 
            // tblLoan
            // 
            this.tblLoan.Columns.AddRange(new System.Data.DataColumn[] {
            this.colDateAllocated,
            this.colLoanNumber,
            this.colPreparedBy,
            this.colPreparedFor,
            this.colPrincipal,
            this.colInterestRate,
            this.colPeriods,
            this.colInterestEarned,
            this.colFutureValue,
            this.colMonthlyPayment});
            this.tblLoan.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "LoanNumber"}, false)});
            this.tblLoan.TableName = "Loan";
            // 
            // colDateAllocated
            // 
            this.colDateAllocated.AllowDBNull = false;
            this.colDateAllocated.ColumnName = "DateAllocated";
            this.colDateAllocated.DataType = typeof(System.DateTime);
            // 
            // colLoanNumber
            // 
            this.colLoanNumber.AllowDBNull = false;
            this.colLoanNumber.ColumnName = "LoanNumber";
            this.colLoanNumber.DataType = typeof(int);
            // 
            // colPreparedBy
            // 
            this.colPreparedBy.ColumnName = "PreparedBy";
            // 
            // colPreparedFor
            // 
            this.colPreparedFor.ColumnName = "PreparedFor";
            // 
            // colPrincipal
            // 
            this.colPrincipal.ColumnName = "Principal";
            this.colPrincipal.DataType = typeof(double);
            // 
            // colInterestRate
            // 
            this.colInterestRate.ColumnName = "InterestRate";
            this.colInterestRate.DataType = typeof(double);
            this.colInterestRate.DefaultValue = 8.75D;
            this.colInterestRate.ReadOnly = true;
            // 
            // colPeriods
            // 
            this.colPeriods.ColumnName = "Periods";
            this.colPeriods.DataType = typeof(double);
            this.colPeriods.DefaultValue = 36D;
            // 
            // colInterestEarned
            // 
            this.colInterestEarned.ColumnName = "InterestEarned";
            this.colInterestEarned.DataType = typeof(double);
            this.colInterestEarned.Expression = "Principal * (InterestRate / 100) * (Periods / 12)";
            this.colInterestEarned.ReadOnly = true;
            // 
            // colFutureValue
            // 
            this.colFutureValue.ColumnName = "FutureValue";
            this.colFutureValue.DataType = typeof(double);
            this.colFutureValue.Expression = "Principal + InterestEarned";
            this.colFutureValue.ReadOnly = true;
            // 
            // colMonthlyPayment
            // 
            this.colMonthlyPayment.ColumnName = "MonthlyPayment";
            this.colMonthlyPayment.DataType = typeof(double);
            this.colMonthlyPayment.Expression = "FutureValue / Periods";
            this.colMonthlyPayment.ReadOnly = true;
            // 
            // dsPayments
            // 
            this.dsPayments.DataSetName = "Payments";
            this.dsPayments.Tables.AddRange(new System.Data.DataTable[] {
            this.tblPayment});
            // 
            // tblPayment
            // 
            this.tblPayment.Columns.AddRange(new System.Data.DataColumn[] {
            this.colPaymentNumber,
            this.colPaymentDate,
            this.colReceivedBy,
            this.colPaymentFor,
            this.colPaymentAmount,
            this.colBalance});
            this.tblPayment.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "PaymentNumber"}, false)});
            this.tblPayment.TableName = "Payment";
            // 
            // colPaymentNumber
            // 
            this.colPaymentNumber.AllowDBNull = false;
            this.colPaymentNumber.ColumnName = "PaymentNumber";
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.AllowDBNull = false;
            this.colPaymentDate.ColumnName = "PaymentDate";
            this.colPaymentDate.DataType = typeof(System.DateTime);
            // 
            // colReceivedBy
            // 
            this.colReceivedBy.AllowDBNull = false;
            this.colReceivedBy.ColumnName = "ReceivedBy";
            // 
            // colPaymentFor
            // 
            this.colPaymentFor.AllowDBNull = false;
            this.colPaymentFor.ColumnName = "PaymentFor";
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.AllowDBNull = false;
            this.colPaymentAmount.ColumnName = "PaymentAmount";
            this.colPaymentAmount.DataType = typeof(double);
            this.colPaymentAmount.DefaultValue = 0D;
            // 
            // colBalance
            // 
            this.colBalance.ColumnName = "Balance";
            this.colBalance.DataType = typeof(double);
            this.colBalance.DefaultValue = 0D;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AutoGenerateColumns = false;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentNumberDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.receivedByDataGridViewTextBoxColumn,
            this.paymentForDataGridViewTextBoxColumn,
            this.paymentAmountDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dgvPayments.DataMember = "Payment";
            this.dgvPayments.DataSource = this.dsPayments;
            this.dgvPayments.Location = new System.Drawing.Point(12, 12);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.Size = new System.Drawing.Size(526, 251);
            this.dgvPayments.TabIndex = 0;
            // 
            // btnLoans
            // 
            this.btnLoans.Location = new System.Drawing.Point(382, 269);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Size = new System.Drawing.Size(75, 23);
            this.btnLoans.TabIndex = 1;
            this.btnLoans.Text = "Loans...";
            this.btnLoans.UseVisualStyleBackColor = true;
            this.btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(463, 269);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // paymentNumberDataGridViewTextBoxColumn
            // 
            this.paymentNumberDataGridViewTextBoxColumn.DataPropertyName = "PaymentNumber";
            this.paymentNumberDataGridViewTextBoxColumn.HeaderText = "Pmt #";
            this.paymentNumberDataGridViewTextBoxColumn.Name = "paymentNumberDataGridViewTextBoxColumn";
            this.paymentNumberDataGridViewTextBoxColumn.Width = 55;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            this.paymentDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "Pmt Date";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.Width = 70;
            // 
            // receivedByDataGridViewTextBoxColumn
            // 
            this.receivedByDataGridViewTextBoxColumn.DataPropertyName = "ReceivedBy";
            this.receivedByDataGridViewTextBoxColumn.DataSource = this.dsEmployees;
            this.receivedByDataGridViewTextBoxColumn.DisplayMember = "Employee.EmployeeNumber";
            this.receivedByDataGridViewTextBoxColumn.HeaderText = "Received By";
            this.receivedByDataGridViewTextBoxColumn.Name = "receivedByDataGridViewTextBoxColumn";
            this.receivedByDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.receivedByDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // paymentForDataGridViewTextBoxColumn
            // 
            this.paymentForDataGridViewTextBoxColumn.DataPropertyName = "PaymentFor";
            this.paymentForDataGridViewTextBoxColumn.DataSource = this.dsLoansAllocations;
            this.paymentForDataGridViewTextBoxColumn.DisplayMember = "Loan.LoanNumber";
            this.paymentForDataGridViewTextBoxColumn.HeaderText = "Payment For";
            this.paymentForDataGridViewTextBoxColumn.Name = "paymentForDataGridViewTextBoxColumn";
            this.paymentForDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentForDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // paymentAmountDataGridViewTextBoxColumn
            // 
            this.paymentAmountDataGridViewTextBoxColumn.DataPropertyName = "PaymentAmount";
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.paymentAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.paymentAmountDataGridViewTextBoxColumn.HeaderText = "Pmt Amt";
            this.paymentAmountDataGridViewTextBoxColumn.Name = "paymentAmountDataGridViewTextBoxColumn";
            this.paymentAmountDataGridViewTextBoxColumn.Width = 70;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.NullValue = null;
            this.balanceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.Width = 80;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 302);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoans);
            this.Controls.Add(this.dgvPayments);
            this.Name = "Payments";
            this.Text = "Watts A Loan - Payments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Payments_FormClosing);
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLoansAllocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dsEmployees;
        private System.Data.DataTable tblEmployee;
        private System.Data.DataColumn colEmployeeNumber;
        private System.Data.DataColumn colFirstName;
        private System.Data.DataColumn colLastName;
        private System.Data.DataColumn colTitle;
        private System.Data.DataColumn colHourlySalary;
        private System.Data.DataColumn colEmployeeDetails;
        private System.Data.DataSet dsLoansAllocations;
        private System.Data.DataTable tblLoan;
        private System.Data.DataColumn colDateAllocated;
        private System.Data.DataColumn colLoanNumber;
        private System.Data.DataColumn colPreparedBy;
        private System.Data.DataColumn colPreparedFor;
        private System.Data.DataColumn colPrincipal;
        private System.Data.DataColumn colInterestRate;
        private System.Data.DataColumn colPeriods;
        private System.Data.DataColumn colInterestEarned;
        private System.Data.DataColumn colFutureValue;
        private System.Data.DataColumn colMonthlyPayment;
        private System.Data.DataSet dsPayments;
        private System.Data.DataTable tblPayment;
        private System.Data.DataColumn colPaymentNumber;
        private System.Data.DataColumn colPaymentDate;
        private System.Data.DataColumn colReceivedBy;
        private System.Data.DataColumn colPaymentFor;
        private System.Data.DataColumn colPaymentAmount;
        private System.Data.DataColumn colBalance;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn receivedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn paymentForDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLoans;
        private System.Windows.Forms.Button btnClose;
    }
}