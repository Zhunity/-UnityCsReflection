
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.IPackageActionButton
	/// </summary>
    public partial class RIPackageActionButton : RMember //
    {

		/// <summary>
		/// System.String text
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Ptext;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPtext
		{
			get
			{
				if(r_Ptext == null)
				{
					r_Ptext = new(this, "text", -1);
					r_Ptext.SetBelong(this.instance);
				}
				return r_Ptext;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D icon
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTexture2D r_Picon;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTexture2D RPicon
		{
			get
			{
				if(r_Picon == null)
				{
					r_Picon = new(this, "icon", -1);
					r_Picon.SetBelong(this.instance);
				}
				return r_Picon;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Ptooltip;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPtooltip
		{
			get
			{
				if(r_Ptooltip == null)
				{
					r_Ptooltip = new(this, "tooltip", -1);
					r_Ptooltip.SetBelong(this.instance);
				}
				return r_Ptooltip;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.PackageSelectionArgs] action
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RPackageSelectionArgs> r_Paction;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RPackageSelectionArgs> RPaction
		{
			get
			{
				if(r_Paction == null)
				{
					r_Paction = new(this, "action", -1);
					r_Paction.SetBelong(this.instance);
				}
				return r_Paction;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IPackageActionDropdownItem AddDropdownItem()
		/// </summary>
		protected RMethod r_MAddDropdownItem;
		public virtual RMethod RMAddDropdownItem
		{
			get
			{
				if(r_MAddDropdownItem == null)
				{
					r_MAddDropdownItem = new(this, "AddDropdownItem", 0);
					r_MAddDropdownItem.SetBelong(this.instance);
				}
				return r_MAddDropdownItem;
			}
		}


        public RIPackageActionButton() : base("UnityEditor.PackageManager.UI.IPackageActionButton")
        {
        }

        public RIPackageActionButton(System.Object instance) : base("UnityEditor.PackageManager.UI.IPackageActionButton")
		{
            SetInstance(instance);
		}

        public RIPackageActionButton(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPackageActionButton(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageActionDropdownItem AddDropdownItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddDropdownItem.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageActionDropdownItem(___result);
        }


    }
}
