using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Compiler.Models
{
    [DebuggerDisplay("{Name,nq}")]
    public class CategoryModel
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
                        new string('-', value.Trim().Length));
                }
            }
        }
 
        public List<SubCategoryModel> Categories { get; set; }
    }
}