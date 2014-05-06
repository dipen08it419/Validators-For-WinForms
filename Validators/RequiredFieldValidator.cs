using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevSD.Windows.Forms.Validators
{
    public partial class RequiredFieldValidator : Validator
    {
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

        public int MinLength { get; set; }
        public int MaxLength { get; set; }

        public override bool Validate()
        {
            OnValidating();//Call anyone who is listening Validated event

            if (!Enabled)
                return UpdateResult(true);
            try
            {
                String value = ControlToValidate.GetType().GetProperty(PropertyToValidate).GetValue(ControlToValidate, null).ToString().Trim();
                if (value.Length <= 0)
                {
                    return UpdateResult(false);
                }
                else
                {
                    if (MinLength > 0 && value.Length < MinLength)
                    {
                        return UpdateResult(false);
                    }
                    if (MaxLength > 0 && value.Length > MaxLength)
                    {
                        return UpdateResult(false);
                    }
                    return UpdateResult(true);
                }
            }
            catch (Exception ex)
            {
                if (ShowExceptions)
                {
                    MessageBox.Show(ex.Message.ToString(), "Exception occured!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return UpdateResult(false);
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
