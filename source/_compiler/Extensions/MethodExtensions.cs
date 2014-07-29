using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Cake.Core;

namespace Compiler.Extensions
{
    public static class MethodExtensions
    {
        public static string GetMethodSignature(this MethodInfo method, bool includeMethodNamespace = true, bool includeParameterNamespace = false)
        {
            var builder = new StringBuilder();
            builder.Append(includeMethodNamespace ? method.GetFullName() : method.Name);
            builder.Append("(");
            var parameters = method.GetParameters();
            var parameterList = new List<string>();
            foreach (var parameter in parameters)
            {
                if (parameter.ParameterType == typeof(ICakeContext))
                {
                    continue;
                }
                var isParams = parameter.IsDefined(typeof(ParamArrayAttribute));
                var signature = parameter.ParameterType.GetFullName(includeParameterNamespace);
                signature = isParams ? string.Concat("params ", signature) : signature;
                var parameterName = parameter.Name;
                parameterList.Add(string.Concat(signature, " ", parameterName));
            }
            builder.Append(string.Join(", ", parameterList));
            builder.Append(")");
            return builder.ToString();
        }
    }
}
