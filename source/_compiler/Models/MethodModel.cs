using System.Diagnostics;

namespace Compiler.Models
{
    [DebuggerDisplay("{Name,nq}")]
    public class MethodModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}