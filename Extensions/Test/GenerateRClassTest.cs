using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
#endif
using System.Reflection;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Hvak.Editor.Refleaction.RSystem.RReflection;
using UnityEngine.UI;

namespace Hvak.Editor.Refleaction
{
	static class Test
	{ 
		[MenuItem("Tools/NewGenerate")]
		static void GenerateNewWay()
		{
			// 0�������Ҫ�õ�dll�ı���������������ע�ᡣ����Ϊ��֪����ô����dll��alias�������ñ��������ֶ�ע���ˣ�
			ModuleAliasConfig.Set("", "");
			// 1��ָ�����ɴ�����ļ���·��
			GenerateRtype.UnityCSReflectionPath = $"{Application.dataPath}/UnityCsReflection/";
			// 2�������Ҫ���ɵ��࣬���������ֽӿڣ��������д����������ֵĽӿڣ����������Ǵ������б���ʵ���б�
			GenerateRtype.Generate(new List<string> { "UnityType", "ComponentDropdownItem", "AddComponentWindow", "PackageManagerWindow" });
		}
	}
}
