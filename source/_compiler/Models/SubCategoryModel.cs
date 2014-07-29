using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Compiler.Models
{
    [DebuggerDisplay("{Name,nq}")]
    public class SubCategoryModel
    {
        private string _name;

        public string Name 
        {
            get { return _name; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = string.Concat(value.Trim(), Environment.NewLine,
                        new string('^', value.Trim().Length));
                }
            }
        }
        
        public bool HasName
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Name);
            }
        }

        public List<MethodModel> Methods { get; set; }
    }
}