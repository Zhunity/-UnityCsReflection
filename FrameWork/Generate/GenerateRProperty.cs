using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Rendering;

namespace SMFrame.Editor.Refleaction
{
    public partial class GenerateRClass
    {
		/// <summary>
		/// GenericTypeArguments defineation Ҳ��shu�� GenericTypeArguments����
		/// </summary>
		/// <param name="classType"></param>
		/// <param name="getSetHash"></param>
		/// <param name="delcareStr"></param>
		/// <param name="newStr"></param>
		/// <returns></returns>
		private static string GenerateProperty(Type classType, ref string delcareStr,  ref string newStr)
        {
            string methodInvoke = string.Empty;
            var properties = classType.GetProperties(Class.flags);
            foreach (var property in properties)
            {
                delcareStr += GeneratePropertyDeclare(property);
                newStr += GeneratePropertyNew(property);
            }

            return methodInvoke;
        }

        private static string GeneratePropertyDeclare(PropertyInfo property)
        {
            string name = GetPropertyName(property);

            return GenerateDeclare("Method", name, property.ToString(), property.IsStatic());
        }

        private static string GeneratePropertyNew(PropertyInfo property)
        {
            string name = GetPropertyName(property);

			var method = property.GetMethod == null ? property.SetMethod : property.GetMethod;
			var parameters = method.GetParameters();
            var paramStr = string.Empty;
            for (int i = 0; i < parameters.Length; i++)
            {
                paramStr += $", {parameters[i].ParameterType.ToGetMethod()}";
            }

            return $"\t\t\t{name} = new Method(this, \"{method.Name}\", -1{paramStr});\n";
        }


        static private string GetPropertyName(PropertyInfo property)
        {
            var method = property.GetMethod == null ? property.SetMethod : property.GetMethod;
			string paramStr = GetMethodName(method);
			return paramStr;
        }
    }
}