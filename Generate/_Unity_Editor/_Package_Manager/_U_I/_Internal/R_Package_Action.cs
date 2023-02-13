
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.PackageAction
	/// </summary>
    public partial class RPackageAction : RMember //
    {

		/// <summary>
		/// System.Action onVisibleChanged
		/// </summary>
		protected REvent r_EonVisibleChanged;
		public virtual REvent REonVisibleChanged
		{
			get
			{
				if(r_EonVisibleChanged == null)
				{
					r_EonVisibleChanged = new(this, "onVisibleChanged");
					r_EonVisibleChanged.SetBelong(this.instance);
				}
				return r_EonVisibleChanged;
			}
		}

		/// <summary>
		/// System.Action onPriorityChanged
		/// </summary>
		protected REvent r_EonPriorityChanged;
		public virtual REvent REonPriorityChanged
		{
			get
			{
				if(r_EonPriorityChanged == null)
				{
					r_EonPriorityChanged = new(this, "onPriorityChanged");
					r_EonPriorityChanged.SetBelong(this.instance);
				}
				return r_EonPriorityChanged;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IWindow m_Window
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindow r_Fm_Window;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindow RFm_Window
		{
			get
			{
				if(r_Fm_Window == null)
				{
					r_Fm_Window = new(this, "m_Window");
					r_Fm_Window.SetBelong(this.instance);
				}
				return r_Fm_Window;
			}
		}

		/// <summary>
		/// System.Boolean m_NeedRefresh
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_NeedRefresh;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_NeedRefresh
		{
			get
			{
				if(r_Fm_NeedRefresh == null)
				{
					r_Fm_NeedRefresh = new(this, "m_NeedRefresh");
					r_Fm_NeedRefresh.SetBelong(this.instance);
				}
				return r_Fm_NeedRefresh;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.PackageActionDropdownItem] m_DropdownItems
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageActionDropdownItem> r_Fm_DropdownItems;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageActionDropdownItem> RFm_DropdownItems
		{
			get
			{
				if(r_Fm_DropdownItems == null)
				{
					r_Fm_DropdownItems = new(this, "m_DropdownItems");
					r_Fm_DropdownItems.SetBelong(this.instance);
				}
				return r_Fm_DropdownItems;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DropdownButton <dropdownButton>k__BackingField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDropdownButton r_F__0__dropdownButton__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDropdownButton RF__0__dropdownButton__1__k__BackingField
		{
			get
			{
				if(r_F__0__dropdownButton__1__k__BackingField == null)
				{
					r_F__0__dropdownButton__1__k__BackingField = new(this, "<dropdownButton>k__BackingField");
					r_F__0__dropdownButton__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__dropdownButton__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.PackageSelectionArgs] m_Action
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RPackageSelectionArgs> r_Fm_Action;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RPackageSelectionArgs> RFm_Action
		{
			get
			{
				if(r_Fm_Action == null)
				{
					r_Fm_Action = new(this, "m_Action");
					r_Fm_Action.SetBelong(this.instance);
				}
				return r_Fm_Action;
			}
		}

		/// <summary>
		/// System.Int32 m_Priority
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_Priority;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_Priority
		{
			get
			{
				if(r_Fm_Priority == null)
				{
					r_Fm_Priority = new(this, "m_Priority");
					r_Fm_Priority.SetBelong(this.instance);
				}
				return r_Fm_Priority;
			}
		}

		/// <summary>
		/// System.Boolean m_Visible
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_Visible;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_Visible
		{
			get
			{
				if(r_Fm_Visible == null)
				{
					r_Fm_Visible = new(this, "m_Visible");
					r_Fm_Visible.SetBelong(this.instance);
				}
				return r_Fm_Visible;
			}
		}

		/// <summary>
		/// System.Action onVisibleChanged
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction r_FonVisibleChanged;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction RFonVisibleChanged
		{
			get
			{
				if(r_FonVisibleChanged == null)
				{
					r_FonVisibleChanged = new(this, "onVisibleChanged");
					r_FonVisibleChanged.SetBelong(this.instance);
				}
				return r_FonVisibleChanged;
			}
		}

		/// <summary>
		/// System.Action onPriorityChanged
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction r_FonPriorityChanged;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction RFonPriorityChanged
		{
			get
			{
				if(r_FonPriorityChanged == null)
				{
					r_FonPriorityChanged = new(this, "onPriorityChanged");
					r_FonPriorityChanged.SetBelong(this.instance);
				}
				return r_FonPriorityChanged;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageActionDropdownItem] visibleDropdownItems
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageActionDropdownItem> r_PvisibleDropdownItems;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageActionDropdownItem> RPvisibleDropdownItems
		{
			get
			{
				if(r_PvisibleDropdownItems == null)
				{
					r_PvisibleDropdownItems = new(this, "visibleDropdownItems", -1);
					r_PvisibleDropdownItems.SetBelong(this.instance);
				}
				return r_PvisibleDropdownItems;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DropdownButton dropdownButton
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDropdownButton r_PdropdownButton;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDropdownButton RPdropdownButton
		{
			get
			{
				if(r_PdropdownButton == null)
				{
					r_PdropdownButton = new(this, "dropdownButton", -1);
					r_PdropdownButton.SetBelong(this.instance);
				}
				return r_PdropdownButton;
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
		/// Int32 priority
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Ppriority;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPpriority
		{
			get
			{
				if(r_Ppriority == null)
				{
					r_Ppriority = new(this, "priority", -1);
					r_Ppriority.SetBelong(this.instance);
				}
				return r_Ppriority;
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
		/// Boolean visible
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Pvisible;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPvisible
		{
			get
			{
				if(r_Pvisible == null)
				{
					r_Pvisible = new(this, "visible", -1);
					r_Pvisible.SetBelong(this.instance);
				}
				return r_Pvisible;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Penabled;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPenabled
		{
			get
			{
				if(r_Penabled == null)
				{
					r_Penabled = new(this, "enabled", -1);
					r_Penabled.SetBelong(this.instance);
				}
				return r_Penabled;
			}
		}

		/// <summary>
		/// Void OnBeforeShowDropdown()
		/// </summary>
		protected RMethod r_MOnBeforeShowDropdown;
		public virtual RMethod RMOnBeforeShowDropdown
		{
			get
			{
				if(r_MOnBeforeShowDropdown == null)
				{
					r_MOnBeforeShowDropdown = new(this, "OnBeforeShowDropdown", 0);
					r_MOnBeforeShowDropdown.SetBelong(this.instance);
				}
				return r_MOnBeforeShowDropdown;
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

		/// <summary>
		/// Void RefreshDropdownIcon()
		/// </summary>
		protected RMethod r_MRefreshDropdownIcon;
		public virtual RMethod RMRefreshDropdownIcon
		{
			get
			{
				if(r_MRefreshDropdownIcon == null)
				{
					r_MRefreshDropdownIcon = new(this, "RefreshDropdownIcon", 0);
					r_MRefreshDropdownIcon.SetBelong(this.instance);
				}
				return r_MRefreshDropdownIcon;
			}
		}

		/// <summary>
		/// Void OnAction()
		/// </summary>
		protected RMethod r_MOnAction;
		public virtual RMethod RMOnAction
		{
			get
			{
				if(r_MOnAction == null)
				{
					r_MOnAction = new(this, "OnAction", 0);
					r_MOnAction.SetBelong(this.instance);
				}
				return r_MOnAction;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_MEquals_Object;
		public virtual RMethod RMEquals_Object
		{
			get
			{
				if(r_MEquals_Object == null)
				{
					r_MEquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_MFinalize;
		public virtual RMethod RMFinalize
		{
			get
			{
				if(r_MFinalize == null)
				{
					r_MFinalize = new(this, "Finalize", 0);
					r_MFinalize.SetBelong(this.instance);
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_MGetHashCode;
		public virtual RMethod RMGetHashCode
		{
			get
			{
				if(r_MGetHashCode == null)
				{
					r_MGetHashCode = new(this, "GetHashCode", 0);
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_MGetType;
		public virtual RMethod RMGetType
		{
			get
			{
				if(r_MGetType == null)
				{
					r_MGetType = new(this, "GetType", 0);
					r_MGetType.SetBelong(this.instance);
				}
				return r_MGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MMemberwiseClone;
		public virtual RMethod RMMemberwiseClone
		{
			get
			{
				if(r_MMemberwiseClone == null)
				{
					r_MMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_MToString;
		public virtual RMethod RMToString
		{
			get
			{
				if(r_MToString == null)
				{
					r_MToString = new(this, "ToString", 0);
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
			}
		}


        public RPackageAction() : base("UnityEditor.PackageManager.UI.Internal.PackageAction")
        {
        }

        public RPackageAction(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PackageAction")
		{
            SetInstance(instance);
		}

        public RPackageAction(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageAction(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnBeforeShowDropdown()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeShowDropdown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageActionDropdownItem AddDropdownItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddDropdownItem.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageActionDropdownItem(___result);
        }


        public virtual void RefreshDropdownIcon()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshDropdownIcon.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
