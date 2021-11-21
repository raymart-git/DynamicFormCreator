using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicFormCreator
{
    public class FormDirectory
    {
        public string FormName { get; set; }
        public string ControlName { get; set; }
        public string ControlType { get; set; }
        public string ControlOptions { get; set; }
        public string DBName { get; set; }
        public string ControlValueLimit { get; set; }
    }
}
