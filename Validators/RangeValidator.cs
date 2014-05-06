using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevSD.Windows.Forms.Validators
{
    public class RangeValidator : Validator
    {
        private double _minValue = 0.0, _maxValue = 100.0;
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
        public double MinimumValue
        {
            get { return _minValue; }
            set
            {
                _minValue = value;
            }
        }
        public double MaximumValue
        {
            get { return _maxValue; }
            set
            {
                if (value < _minValue)
                    throw new Exception("Max value cannot be less than min value");
                else
                    _maxValue = value;
            }
        }
        public override bool Validate()
        {
            OnValidating();//Call anyone who is listening Validated event

            if (!Enabled)
                return UpdateResult(true);

            try
            {
                double value = double.Parse(ControlToValidate.GetType().GetProperty(PropertyToValidate).GetValue(ControlToValidate, null).ToString().Trim());
                if (value >= MinimumValue && value <= MaximumValue)
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
