﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Cake.Core;

namespace Compiler.Extensions
{
    public static class MethodExtensions
    {
        private static readonly Dictionary<string, string> _lookup;

        static MethodExtensions()
        {
            _lookup = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            _lookup.Add("String", "string");
            _lookup.Add("Int32", "int");
            _lookup.Add("Boolean", "bool");
        }

        public static string GetMethodSignature(this MethodInfo method)
        {
            var builder = new StringBuilder();
            var name = method.Name;            
            builder.Append(method.Name);
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
                var parameterString = GetFriendlyTypeName(parameter.ParameterType);
                parameterString = isParams ? string.Concat("params ", parameterString) : parameterString;

                var parameterName = parameter.Name;
                parameterList.Add(string.Concat(parameterString, " ", parameterName));
            }
            builder.Append(string.Join(", ", parameterList));
            builder.Append(")");
            return builder.ToString();
        }

        private static string GetFriendlyTypeName(Type type)
        {
            var name = type.GetFullName(false);
            return _lookup.ContainsKey(name) ? _lookup[name] : name;
        }
    }
}
