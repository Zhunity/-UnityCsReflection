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
using Hvak.Editor.Refleaction.RHvak.REditor.RRefleaction;

namespace Hvak.Editor.Refleaction
{

	class ATest
	{
		int a = 2;

		void Log()
		{
			Debug.Log("Log ATest");
		}
	}

	class BTest
	{
		string str = "hello world!";

		ATest aTest
		{
			get; set;
		} = new ATest();
	}

	static class Test
	{ 
		[MenuItem("Tools/NewGenerate")]
		static void GenerateNewWay()
		{
			// 0�������Ҫ�õ�dll�ı���������������ע�ᡣ����Ϊ��֪����ô����dll��alias�������ñ��������ֶ�ע���ˣ�
			ModuleAliasConfig.Set("", "");
			// 1��ָ�����ɴ�����ļ���·��
			GenerateRtype.UnityCSReflectionPath = $"{Application.dataPath}/Script/UnityCsReflection/";
			// 2�������Ҫ���ɵ��࣬���������ֽӿڣ��������д����������ֵĽӿڣ����������Ǵ������б���ʵ���б�
			GenerateRtype.Generate(new List<string> { "UnityType", "ComponentDropdownItem", "AddComponentWindow", "PackageManagerWindow", "BTest" });
		}

		[MenuItem("Tools/Test Generate")]
		static void TestRType()
		{
			// 1��������Ȼ��ֱ��new��һ��BTest��������ʵ�������ͨ�������ֶ��õ���BTestʵ��
			BTest bTest = new BTest();
			// 2��newһ��RBTest������BTest��ʵ������ȥ
			RBTest rBTest = new RBTest(bTest);
			// 3�����Ե���ͨ��RBTest������BTest�����private field
			Debug.Log(rBTest.RFstr.Value);
			// 4�����Ե���ͨ��RBTest������BTest�����private property
			Debug.Log(rBTest.RPaTest.RFa.Value);
			// 5�����Ե���ͨ��RBTest������BTest�����private method
			rBTest.RPaTest.Log();
		}
	}
}
