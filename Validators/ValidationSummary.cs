using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevSD.Windows.Forms.Validators
{
    public class ValidationSummary : UserControl, IValidator
    {
        private System.Windows.Forms.Panel panelMessageContainer;
        private System.Windows.Forms.Label lblMessage;
        private Position _position = Position.Right;
        internal bool _isValid = false;
        private string _errorMessage = "";

        public ValidationSummary()
        {
            this.panelMessageContainer = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panelMessageContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMessageContainer
            // 
            this.panelMessageContainer.BackColor = System.Drawing.Color.Maroon;
            this.panelMessageContainer.Controls.Add(this.lblMessage);
            this.panelMessageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessageContainer.Location = new System.Drawing.Point(10, 0);
            this.panelMessageContainer.Name = "panelMessageContainer";
            this.panelMessageContainer.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(3, 4);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = _errorMessage;
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.Dock = DockStyle.Fill;
            this.lblMessage.Padding = new Padding(5);

            // 
            // Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMessageContainer);
            this.Name = "Validator";
            this.Size = new Size(150, 40);
            this.panelMessageContainer.ResumeLayout(false);
            this.panelMessageContainer.PerformLayout();
            this.ResumeLayout(false);

            this.Visible = false;
            this.Top = 100;
        }

        public event ValidatingEventHandler Validating;
        public event ValidatedEventHandler Validated;

        private void OnValidating()
        {
            if (Validating != null)
            {
                ValidationEventArgs args = new ValidationEventArgs();
                args.Result = ValidationResult.Validating;
                Validating(this, args);
            }
        }

        private void OnValidated(bool result)
        {
            if (Validated != null)
            {
                ValidationEventArgs args = new ValidationEventArgs();
                args.Result = result ? ValidationResult.Valid : ValidationResult.InValid;
                Validated(this, args);
            }
        }

        public Control ControlToValidate { get; set; }
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; this.lblMessage.Text = value; }
        }
        [DefaultValue(true)]
        public bool IsValid { get { return _isValid; } }

        public bool ShowExceptions { get; set; }

        public bool Validate()
        {
            OnValidating();//Call anyone who is listening Validated event

            _isValid = true;

            if (ControlToValidate != null)
            {
                ExploreControl(ControlToValidate);
            }

            return UpdateResult(_isValid);
        }

        private void ExploreControl(Control Control)
        {
            foreach (Control control in Control.Controls)
            {
                if (control.GetType().IsSubclassOf(typeof(Validator)))
                {
                    _isValid = _isValid & ((Validator)control).Validate();
                }
                ExploreControl(control);
            }
        }

        private bool UpdateResult(bool result)
        {
            base.Visible = !result;//updating UI if Data is valid than hide UI else make it visible
            _isValid = result; //Update variable _isValid
            OnValidated(result); //Call anyone who is listening Validated event
            return result; //returning result
        }
    }
}
