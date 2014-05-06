namespace ValidatorDemo
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.compareValidator1 = new DevSD.Windows.Forms.Validators.CompareValidator();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.btnCVValidate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.regularExpressionValidator1 = new DevSD.Windows.Forms.Validators.RegularExpressionValidator();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnREVValidate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rangeValidator1 = new DevSD.Windows.Forms.Validators.RangeValidator();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnRVValidate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.requiredFieldValidator1 = new DevSD.Windows.Forms.Validators.RequiredFieldValidator();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRFVValidate = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblFrmTitle = new System.Windows.Forms.Label();
            this.lblFrmVal2 = new System.Windows.Forms.Label();
            this.lblFrmVal1 = new System.Windows.Forms.Label();
            this.lblFrmEmailId = new System.Windows.Forms.Label();
            this.lblFrmAge = new System.Windows.Forms.Label();
            this.lblFrmName = new System.Windows.Forms.Label();
            this.validationSummary1 = new DevSD.Windows.Forms.Validators.ValidationSummary();
            this.btnValidateForm = new System.Windows.Forms.Button();
            this.cvValue = new DevSD.Windows.Forms.Validators.CompareValidator();
            this.txtFrmValue2 = new System.Windows.Forms.TextBox();
            this.txtFrmValue1 = new System.Windows.Forms.TextBox();
            this.revEmailId = new DevSD.Windows.Forms.Validators.RegularExpressionValidator();
            this.txtFrmEmailId = new System.Windows.Forms.TextBox();
            this.rvAge = new DevSD.Windows.Forms.Validators.RangeValidator();
            this.txtFrmAge = new System.Windows.Forms.TextBox();
            this.rfvName = new DevSD.Windows.Forms.Validators.RequiredFieldValidator();
            this.txtFrmName = new System.Windows.Forms.TextBox();
            this.panelLeft.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBox4);
            this.panelLeft.Controls.Add(this.groupBox3);
            this.panelLeft.Controls.Add(this.groupBox2);
            this.panelLeft.Controls.Add(this.groupBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(344, 377);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.compareValidator1);
            this.groupBox4.Controls.Add(this.txtValue2);
            this.groupBox4.Controls.Add(this.btnCVValidate);
            this.groupBox4.Controls.Add(this.txtValue1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 107);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compare Validator";
            // 
            // compareValidator1
            // 
            this.compareValidator1.BackColor = System.Drawing.Color.Transparent;
            this.compareValidator1.ControlToCompare = this.txtValue2;
            this.compareValidator1.ControlToValidate = this.txtValue1;
            this.compareValidator1.ErrorMessage = "Values do not match!";
            this.compareValidator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareValidator1.Location = new System.Drawing.Point(148, 28);
            this.compareValidator1.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.compareValidator1.Name = "compareValidator1";
            this.compareValidator1.PointerOffset = 5;
            this.compareValidator1.PointerSize = 10;
            this.compareValidator1.Position = DevSD.Windows.Forms.Validators.Position.Right;
            this.compareValidator1.PositionType = DevSD.Windows.Forms.Validators.PositionType.Auto;
            this.compareValidator1.ShowExceptions = false;
            this.compareValidator1.Size = new System.Drawing.Size(150, 40);
            this.compareValidator1.TabIndex = 7;
            this.compareValidator1.TabStop = false;
            this.compareValidator1.Visible = false;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(16, 54);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(132, 20);
            this.txtValue2.TabIndex = 7;
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(16, 28);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(132, 20);
            this.txtValue1.TabIndex = 6;
            // 
            // btnCVValidate
            // 
            this.btnCVValidate.Location = new System.Drawing.Point(16, 80);
            this.btnCVValidate.Name = "btnCVValidate";
            this.btnCVValidate.Size = new System.Drawing.Size(132, 23);
            this.btnCVValidate.TabIndex = 8;
            this.btnCVValidate.Text = "Validate Textbox";
            this.btnCVValidate.UseVisualStyleBackColor = true;
            this.btnCVValidate.Click += new System.EventHandler(this.btnCVValidate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.regularExpressionValidator1);
            this.groupBox3.Controls.Add(this.btnREVValidate);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 90);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Regular Expression Validator";
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.BackColor = System.Drawing.Color.Transparent;
            this.regularExpressionValidator1.ControlToValidate = this.txtEmail;
            this.regularExpressionValidator1.ErrorMessage = "Invalid Email Id.";
            this.regularExpressionValidator1.ExpressionPattern = "[a-z0-9!#$%&\'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&\'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-" +
    "z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
            this.regularExpressionValidator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularExpressionValidator1.Location = new System.Drawing.Point(148, 28);
            this.regularExpressionValidator1.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.regularExpressionValidator1.Name = "regularExpressionValidator1";
            this.regularExpressionValidator1.PointerOffset = 5;
            this.regularExpressionValidator1.PointerSize = 10;
            this.regularExpressionValidator1.Position = DevSD.Windows.Forms.Validators.Position.Right;
            this.regularExpressionValidator1.PositionType = DevSD.Windows.Forms.Validators.PositionType.Auto;
            this.regularExpressionValidator1.ShowExceptions = false;
            this.regularExpressionValidator1.Size = new System.Drawing.Size(150, 40);
            this.regularExpressionValidator1.TabIndex = 6;
            this.regularExpressionValidator1.TabStop = false;
            this.regularExpressionValidator1.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // btnREVValidate
            // 
            this.btnREVValidate.Location = new System.Drawing.Point(16, 54);
            this.btnREVValidate.Name = "btnREVValidate";
            this.btnREVValidate.Size = new System.Drawing.Size(132, 23);
            this.btnREVValidate.TabIndex = 5;
            this.btnREVValidate.Text = "Validate Textbox";
            this.btnREVValidate.UseVisualStyleBackColor = true;
            this.btnREVValidate.Click += new System.EventHandler(this.btnREVValidate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rangeValidator1);
            this.groupBox2.Controls.Add(this.btnRVValidate);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 90);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Range Validator";
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.BackColor = System.Drawing.Color.Transparent;
            this.rangeValidator1.ControlToValidate = this.txtAge;
            this.rangeValidator1.ErrorMessage = "The value must be between 18 and 100.";
            this.rangeValidator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeValidator1.Location = new System.Drawing.Point(148, 28);
            this.rangeValidator1.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.rangeValidator1.MaximumValue = 100D;
            this.rangeValidator1.MinimumValue = 18D;
            this.rangeValidator1.Name = "rangeValidator1";
            this.rangeValidator1.PointerOffset = 5;
            this.rangeValidator1.PointerSize = 10;
            this.rangeValidator1.Position = DevSD.Windows.Forms.Validators.Position.Right;
            this.rangeValidator1.PositionType = DevSD.Windows.Forms.Validators.PositionType.Auto;
            this.rangeValidator1.ShowExceptions = false;
            this.rangeValidator1.Size = new System.Drawing.Size(150, 40);
            this.rangeValidator1.TabIndex = 6;
            this.rangeValidator1.TabStop = false;
            this.rangeValidator1.Visible = false;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(16, 28);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(132, 20);
            this.txtAge.TabIndex = 2;
            // 
            // btnRVValidate
            // 
            this.btnRVValidate.Location = new System.Drawing.Point(16, 54);
            this.btnRVValidate.Name = "btnRVValidate";
            this.btnRVValidate.Size = new System.Drawing.Size(132, 23);
            this.btnRVValidate.TabIndex = 3;
            this.btnRVValidate.Text = "Validate Textbox";
            this.btnRVValidate.UseVisualStyleBackColor = true;
            this.btnRVValidate.Click += new System.EventHandler(this.btnRVValidate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.requiredFieldValidator1);
            this.groupBox1.Controls.Add(this.btnRFVValidate);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 90);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Required Field Validator";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.BackColor = System.Drawing.Color.Transparent;
            this.requiredFieldValidator1.ControlToValidate = this.txtName;
            this.requiredFieldValidator1.ErrorMessage = "Name is required!";
            this.requiredFieldValidator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredFieldValidator1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.requiredFieldValidator1.Location = new System.Drawing.Point(148, 28);
            this.requiredFieldValidator1.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.requiredFieldValidator1.MaxLength = 0;
            this.requiredFieldValidator1.MinLength = 0;
            this.requiredFieldValidator1.Name = "requiredFieldValidator1";
            this.requiredFieldValidator1.PointerOffset = 5;
            this.requiredFieldValidator1.PointerSize = 10;
            this.requiredFieldValidator1.Position = DevSD.Windows.Forms.Validators.Position.Right;
            this.requiredFieldValidator1.PositionType = DevSD.Windows.Forms.Validators.PositionType.Auto;
            this.requiredFieldValidator1.ShowExceptions = false;
            this.requiredFieldValidator1.Size = new System.Drawing.Size(150, 41);
            this.requiredFieldValidator1.TabIndex = 6;
            this.requiredFieldValidator1.TabStop = false;
            this.requiredFieldValidator1.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnRFVValidate
            // 
            this.btnRFVValidate.Location = new System.Drawing.Point(16, 54);
            this.btnRFVValidate.Name = "btnRFVValidate";
            this.btnRFVValidate.Size = new System.Drawing.Size(132, 23);
            this.btnRFVValidate.TabIndex = 1;
            this.btnRFVValidate.Text = "Validate Textbox";
            this.btnRFVValidate.UseVisualStyleBackColor = true;
            this.btnRFVValidate.Click += new System.EventHandler(this.btnRFVValidate_Click);
            // 
            // panelRight
            // 
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.lblFrmTitle);
            this.panelRight.Controls.Add(this.lblFrmVal2);
            this.panelRight.Controls.Add(this.lblFrmVal1);
            this.panelRight.Controls.Add(this.lblFrmEmailId);
            this.panelRight.Controls.Add(this.lblFrmAge);
            this.panelRight.Controls.Add(this.lblFrmName);
            this.panelRight.Controls.Add(this.validationSummary1);
            this.panelRight.Controls.Add(this.btnValidateForm);
            this.panelRight.Controls.Add(this.cvValue);
            this.panelRight.Controls.Add(this.txtFrmValue2);
            this.panelRight.Controls.Add(this.revEmailId);
            this.panelRight.Controls.Add(this.txtFrmValue1);
            this.panelRight.Controls.Add(this.txtFrmEmailId);
            this.panelRight.Controls.Add(this.rvAge);
            this.panelRight.Controls.Add(this.txtFrmAge);
            this.panelRight.Controls.Add(this.rfvName);
            this.panelRight.Controls.Add(this.txtFrmName);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(350, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(446, 377);
            this.panelRight.TabIndex = 1;
            // 
            // lblFrmTitle
            // 
            this.lblFrmTitle.AutoSize = true;
            this.lblFrmTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmTitle.Location = new System.Drawing.Point(30, 13);
            this.lblFrmTitle.Name = "lblFrmTitle";
            this.lblFrmTitle.Size = new System.Drawing.Size(98, 13);
            this.lblFrmTitle.TabIndex = 17;
            this.lblFrmTitle.Text = "Form Validation:";
            // 
            // lblFrmVal2
            // 
            this.lblFrmVal2.AutoSize = true;
            this.lblFrmVal2.Location = new System.Drawing.Point(33, 211);
            this.lblFrmVal2.Name = "lblFrmVal2";
            this.lblFrmVal2.Size = new System.Drawing.Size(43, 13);
            this.lblFrmVal2.TabIndex = 16;
            this.lblFrmVal2.Text = "Value 2";
            // 
            // lblFrmVal1
            // 
            this.lblFrmVal1.AutoSize = true;
            this.lblFrmVal1.Location = new System.Drawing.Point(33, 185);
            this.lblFrmVal1.Name = "lblFrmVal1";
            this.lblFrmVal1.Size = new System.Drawing.Size(40, 13);
            this.lblFrmVal1.TabIndex = 15;
            this.lblFrmVal1.Text = "Value1";
            // 
            // lblFrmEmailId
            // 
            this.lblFrmEmailId.AutoSize = true;
            this.lblFrmEmailId.Location = new System.Drawing.Point(33, 146);
            this.lblFrmEmailId.Name = "lblFrmEmailId";
            this.lblFrmEmailId.Size = new System.Drawing.Size(41, 13);
            this.lblFrmEmailId.TabIndex = 14;
            this.lblFrmEmailId.Text = "EmailId";
            // 
            // lblFrmAge
            // 
            this.lblFrmAge.AutoSize = true;
            this.lblFrmAge.Location = new System.Drawing.Point(33, 101);
            this.lblFrmAge.Name = "lblFrmAge";
            this.lblFrmAge.Size = new System.Drawing.Size(26, 13);
            this.lblFrmAge.TabIndex = 13;
            this.lblFrmAge.Text = "Age";
            // 
            // lblFrmName
            // 
            this.lblFrmName.AutoSize = true;
            this.lblFrmName.Location = new System.Drawing.Point(33, 61);
            this.lblFrmName.Name = "lblFrmName";
            this.lblFrmName.Size = new System.Drawing.Size(35, 13);
            this.lblFrmName.TabIndex = 12;
            this.lblFrmName.Text = "Name";
            // 
            // validationSummary1
            // 
            this.validationSummary1.BackColor = System.Drawing.Color.Transparent;
            this.validationSummary1.ControlToValidate = this.panelRight;
            this.validationSummary1.ErrorMessage = "Form contains error!";
            this.validationSummary1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationSummary1.Location = new System.Drawing.Point(135, 13);
            this.validationSummary1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.validationSummary1.Name = "validationSummary1";
            this.validationSummary1.ShowExceptions = false;
            this.validationSummary1.Size = new System.Drawing.Size(198, 34);
            this.validationSummary1.TabIndex = 0;
            this.validationSummary1.TabStop = false;
            this.validationSummary1.Visible = false;
            // 
            // btnValidateForm
            // 
            this.btnValidateForm.Location = new System.Drawing.Point(92, 234);
            this.btnValidateForm.Name = "btnValidateForm";
            this.btnValidateForm.Size = new System.Drawing.Size(132, 23);
            this.btnValidateForm.TabIndex = 14;
            this.btnValidateForm.Text = "Validate Form";
            this.btnValidateForm.UseVisualStyleBackColor = true;
            this.btnValidateForm.Click += new System.EventHandler(this.btnValidateForm_Click);
            // 
            // cvValue
            // 
            this.cvValue.BackColor = System.Drawing.Color.Transparent;
            this.cvValue.ControlToCompare = this.txtFrmValue2;
            this.cvValue.ControlToValidate = this.txtFrmValue1;
            this.cvValue.ErrorMessage = "Values do not match!";
            this.cvValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvValue.Location = new System.Drawing.Point(224, 182);
            this.cvValue.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.cvValue.Name = "cvValue";
            this.cvValue.PointerOffset = 5;
            this.cvValue.PointerSize = 10;
            this.cvValue.Position = DevSD.Windows.Forms.Validators.Position.Right;
            this.cvValue.PositionType = DevSD.Windows.Forms.Validators.PositionType.Auto;
            this.cvValue.ShowExceptions = false;
            this.cvValue.Size = new System.Drawing.Size(150, 40);
            this.cvValue.TabIndex = 10;
            this.cvValue.TabStop = false;
            this.cvValue.Visible = false;
            // 
            // txtFrmValue2
            // 
            this.txtFrmValue2.Location = new System.Drawing.Point(92, 208);
            this.txtFrmValue2.Name = "txtFrmValue2";
            this.txtFrmValue2.Size = new System.Drawing.Size(132, 20);
            this.txtFrmValue2.TabIndex = 13;
            // 
            // txtFrmValue1
            // 
            this.txtFrmValue1.Location = new System.Drawing.Point(92, 182);
            this.txtFrmValue1.Name = "txtFrmValue1";
            this.txtFrmValue1.Size = new System.Drawing.Size(132, 20);
            this.txtFrmValue1.TabIndex = 12;
            // 
            // revEmailId
            // 
            this.revEmailId.BackColor = System.Drawing.Color.Transparent;
            this.revEmailId.ControlToValidate = this.txtFrmEmailId;
            this.revEmailId.ErrorMessage = "Invalid Email Id.";
            this.revEmailId.ExpressionPattern = "[a-z0-9!#$%&\'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&\'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-" +
    "z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
            this.revEmailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revEmailId.Location = new System.Drawing.Point(224, 143);
            this.revEmailId.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.revEmailId.Name = "revEmailId";
            this.revEmailId.PointerOffset = 5;
            this.revEmailId.PointerSize = 10;
            this.revEmailId.Position = DevSD.Windows.Forms.Validators.Position.Right;
            this.revEmailId.PositionType = DevSD.Windows.Forms.Validators.PositionType.Auto;
            this.revEmailId.ShowExceptions = false;
            this.revEmailId.Size = new System.Drawing.Size(150, 31);
            this.revEmailId.TabIndex = 8;
            this.revEmailId.TabStop = false;
            this.revEmailId.Visible = false;
            // 
            // txtFrmEmailId
            // 
            this.txtFrmEmailId.Location = new System.Drawing.Point(92, 143);
            this.txtFrmEmailId.Name = "txtFrmEmailId";
            this.txtFrmEmailId.Size = new System.Drawing.Size(132, 20);
            this.txtFrmEmailId.TabIndex = 11;
            // 
            // rvAge
            // 
            this.rvAge.BackColor = System.Drawing.Color.Transparent;
            this.rvAge.ControlToValidate = this.txtFrmAge;
            this.rvAge.ErrorMessage = "The value must be between 18 and 100.";
            this.rvAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rvAge.Location = new System.Drawing.Point(224, 98);
            this.rvAge.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.rvAge.MaximumValue = 100D;
            this.rvAge.MinimumValue = 18D;
            this.rvAge.Name = "rvAge";
            this.rvAge.PointerOffset = 5;
            this.rvAge.PointerSize = 10;
            this.rvAge.Position = DevSD.Windows.Forms.Validators.Position.Right;
            this.rvAge.PositionType = DevSD.Windows.Forms.Validators.PositionType.Auto;
            this.rvAge.ShowExceptions = false;
            this.rvAge.Size = new System.Drawing.Size(150, 40);
            this.rvAge.TabIndex = 8;
            this.rvAge.TabStop = false;
            this.rvAge.Visible = false;
            // 
            // txtFrmAge
            // 
            this.txtFrmAge.Location = new System.Drawing.Point(92, 98);
            this.txtFrmAge.Name = "txtFrmAge";
            this.txtFrmAge.Size = new System.Drawing.Size(132, 20);
            this.txtFrmAge.TabIndex = 10;
            // 
            // rfvName
            // 
            this.rfvName.BackColor = System.Drawing.Color.Transparent;
            this.rfvName.ControlToValidate = this.txtFrmName;
            this.rfvName.ErrorMessage = "Name is required!";
            this.rfvName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfvName.Location = new System.Drawing.Point(224, 58);
            this.rfvName.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.rfvName.MaxLength = 0;
            this.rfvName.MinLength = 0;
            this.rfvName.Name = "rfvName";
            this.rfvName.PointerOffset = 5;
            this.rfvName.PointerSize = 10;
            this.rfvName.Position = DevSD.Windows.Forms.Validators.Position.Right;
            this.rfvName.PositionType = DevSD.Windows.Forms.Validators.PositionType.Auto;
            this.rfvName.ShowExceptions = false;
            this.rfvName.Size = new System.Drawing.Size(150, 32);
            this.rfvName.TabIndex = 8;
            this.rfvName.TabStop = false;
            this.rfvName.Visible = false;
            // 
            // txtFrmName
            // 
            this.txtFrmName.Location = new System.Drawing.Point(92, 58);
            this.txtFrmName.Name = "txtFrmName";
            this.txtFrmName.Size = new System.Drawing.Size(132, 20);
            this.txtFrmName.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 377);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "Form1";
            this.Text = "Validator Demo";
            this.panelLeft.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevSD.Windows.Forms.Validators.CompareValidator compareValidator1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.Button btnCVValidate;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevSD.Windows.Forms.Validators.RegularExpressionValidator regularExpressionValidator1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnREVValidate;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevSD.Windows.Forms.Validators.RangeValidator rangeValidator1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnRVValidate;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevSD.Windows.Forms.Validators.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRFVValidate;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnValidateForm;
        private DevSD.Windows.Forms.Validators.CompareValidator cvValue;
        private System.Windows.Forms.TextBox txtFrmValue2;
        private System.Windows.Forms.TextBox txtFrmValue1;
        private DevSD.Windows.Forms.Validators.RegularExpressionValidator revEmailId;
        private System.Windows.Forms.TextBox txtFrmEmailId;
        private DevSD.Windows.Forms.Validators.RangeValidator rvAge;
        private System.Windows.Forms.TextBox txtFrmAge;
        private DevSD.Windows.Forms.Validators.RequiredFieldValidator rfvName;
        private System.Windows.Forms.TextBox txtFrmName;
        private DevSD.Windows.Forms.Validators.ValidationSummary validationSummary1;
        private System.Windows.Forms.Label lblFrmVal2;
        private System.Windows.Forms.Label lblFrmVal1;
        private System.Windows.Forms.Label lblFrmEmailId;
        private System.Windows.Forms.Label lblFrmAge;
        private System.Windows.Forms.Label lblFrmName;
        private System.Windows.Forms.Label lblFrmTitle;







    }
}

