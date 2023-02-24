using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
    public partial class RPackageDatabase
    {
		RIPackage item = new RIPackage();

		protected override void OnInit()
		{
			RFm_Packages.GetValue();
		}

		protected override void OnSetBelong()
		{
			var packages = RFm_Packages.GetValue() as IDictionary;
			var iter = packages.GetEnumerator();
			while (iter.MoveNext())
			{
				item.SetInstance(iter.Value);
				if (item.RPstate.Value.Equals( RPackageState.RFUpdateAvailable.Value))
				{
					if (UnityEditor.EditorUtility.DisplayDialog("һ������", $"��⵽��{item.RPdisplayName.Value}�����������Ƿ�һ��������", "ȷ��", "ȡ��"))
					{
						var updateTarget = item.RPversions.GetUpdateTarget(item.RPversions.RPinstalled);
						Install(updateTarget);
						Debug.Log(item.id + " update  " + item.RPdisplayName.Value + "  state " + item.RPstate.Value + " to version : " + updateTarget.RPversionId.Value);
					}
					break;
				}
			}
		}
	}
}