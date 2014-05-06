using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevSD.Windows.Forms.Validators
{
    public class CompareValidator : Validator
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

        private Control _controlToCompare;
        public Control ControlToCompare
        {
            get { return _controlToCompare; }
            set
            {
                if (value == null)
                    throw new System.Data.NoNullAllowedException();

                _controlToCompare = value;
            }
        }
        public override bool Validate()
        {
            OnValidating();//Call anyone who is listening Validated event

            if (!Enabled)
                return UpdateResult(true);
            try
            {
                string value = ControlToValidate.GetType().GetProperty(PropertyToValidate).GetValue(ControlToValidate, null).ToString().Trim();
                string compareValue = ControlToCompare.GetType().GetProperty(PropertyToValidate).GetValue(ControlToCompare, null).ToString().Trim();

                if (value == compareValue)
                {
                    return UpdateResult(true);
                }
                return UpdateResult(false);
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
