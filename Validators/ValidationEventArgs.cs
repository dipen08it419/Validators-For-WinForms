using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevSD.Windows.Forms.Validators
{
    public class ValidationEventArgs
    {
        public ValidationResult Result { get; set; }
    }

    public enum ValidationResult { Validating, Valid, InValid };
}
