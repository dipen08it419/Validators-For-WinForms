using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ValidatorDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            validationSummary1.Validating += validationSummary1_Validating;
            validationSummary1.Validated += validationSummary1_Validated;
        }

        private void btnCVValidate_Click(object sender, EventArgs e)
        {
            compareValidator1.Validate();
        }

        private void btnREVValidate_Click(object sender, EventArgs e)
        {
            regularExpressionValidator1.Validate();
        }

        private void btnRVValidate_Click(object sender, EventArgs e)
        {
            rangeValidator1.Validate();
        }

        private void btnRFVValidate_Click(object sender, EventArgs e)
        {
            requiredFieldValidator1.Validate();
        }

        private void btnValidateForm_Click(object sender, EventArgs e)
        {
            validationSummary1.Validate();            
        }

        void validationSummary1_Validated(object sender, DevSD.Windows.Forms.Validators.ValidationEventArgs args)
        {
            MessageBox.Show("Form Validated!\nThe Form is :"+args.Result.ToString().ToUpper());
        }

        void validationSummary1_Validating(object sender, DevSD.Windows.Forms.Validators.ValidationEventArgs args)
        {
            MessageBox.Show("Validating Form!");
        }
    }
}
