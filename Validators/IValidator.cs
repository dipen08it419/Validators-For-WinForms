using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevSD.Windows.Forms.Validators
{
    public delegate void ValidatingEventHandler(object sender, ValidationEventArgs args);
    public delegate void ValidatedEventHandler(object sender, ValidationEventArgs args);
    public interface IValidator
    {
        event ValidatingEventHandler Validating;
        event ValidatedEventHandler Validated;
        String ErrorMessage { get; set; }
        bool IsValid { get; }
        bool Validate();
    }
}
