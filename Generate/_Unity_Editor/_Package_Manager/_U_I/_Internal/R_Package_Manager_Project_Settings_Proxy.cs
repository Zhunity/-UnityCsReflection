
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy
	/// </summary>
    public partial class RPackageManagerProjectSettingsProxy : RMember //
    {

		/// <summary>
		/// System.Action`1[System.Boolean] onEnablePreReleasePackagesChanged
		/// </summary>
		protected REvent r_EonEnablePreReleasePackagesChanged;
		public virtual REvent REonEnablePreReleasePackagesChanged
		{
			get
			{
				if(r_EonEnablePreReleasePackagesChanged == null)
				{
					r_EonEnablePreReleasePackagesChanged = new(this, "onEnablePreReleasePackagesChanged");
					r_EonEnablePreReleasePackagesChanged.SetBelong(this.instance);
				}
				return r_EonEnablePreReleasePackagesChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] onAdvancedSettingsFoldoutChanged
		/// </summary>
		protected REvent r_EonAdvancedSettingsFoldoutChanged;
		public virtual REvent REonAdvancedSettingsFoldoutChanged
		{
			get
			{
				if(r_EonAdvancedSettingsFoldoutChanged == null)
				{
					r_EonAdvancedSettingsFoldoutChanged = new(this, "onAdvancedSettingsFoldoutChanged");
					r_EonAdvancedSettingsFoldoutChanged.SetBelong(this.instance);
				}
				return r_EonAdvancedSettingsFoldoutChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] onScopedRegistriesSettingsFoldoutChanged
		/// </summary>
		protected REvent r_EonScopedRegistriesSettingsFoldoutChanged;
		public virtual REvent REonScopedRegistriesSettingsFoldoutChanged
		{
			get
			{
				if(r_EonScopedRegistriesSettingsFoldoutChanged == null)
				{
					r_EonScopedRegistriesSettingsFoldoutChanged = new(this, "onScopedRegistriesSettingsFoldoutChanged");
					r_EonScopedRegistriesSettingsFoldoutChanged.SetBelong(this.instance);
				}
				return r_EonScopedRegistriesSettingsFoldoutChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] onSeeAllVersionsChanged
		/// </summary>
		protected REvent r_EonSeeAllVersionsChanged;
		public virtual REvent REonSeeAllVersionsChanged
		{
			get
			{
				if(r_EonSeeAllVersionsChanged == null)
				{
					r_EonSeeAllVersionsChanged = new(this, "onSeeAllVersionsChanged");
					r_EonSeeAllVersionsChanged.SetBelong(this.instance);
				}
				return r_EonSeeAllVersionsChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Int64] onLoadAssetsChanged
		/// </summary>
		protected REvent r_EonLoadAssetsChanged;
		public virtual REvent REonLoadAssetsChanged
		{
			get
			{
				if(r_EonLoadAssetsChanged == null)
				{
					r_EonLoadAssetsChanged = new(this, "onLoadAssetsChanged");
					r_EonLoadAssetsChanged.SetBelong(this.instance);
				}
				return r_EonLoadAssetsChanged;
			}
		}

		/// <summary>
		/// System.Action onInitializationFinished
		/// </summary>
		protected REvent r_EonInitializationFinished;
		public virtual REvent REonInitializationFinished
		{
			get
			{
				if(r_EonInitializationFinished == null)
				{
					r_EonInitializationFinished = new(this, "onInitializationFinished");
					r_EonInitializationFinished.SetBelong(this.instance);
				}
				return r_EonInitializationFinished;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] onEnablePreReleasePackagesChanged
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RBoolean> r_FonEnablePreReleasePackagesChanged;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RBoolean> RFonEnablePreReleasePackagesChanged
		{
			get
			{
				if(r_FonEnablePreReleasePackagesChanged == null)
				{
					r_FonEnablePreReleasePackagesChanged = new(this, "onEnablePreReleasePackagesChanged");
					r_FonEnablePreReleasePackagesChanged.SetBelong(this.instance);
				}
				return r_FonEnablePreReleasePackagesChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] onAdvancedSettingsFoldoutChanged
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RBoolean> r_FonAdvancedSettingsFoldoutChanged;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RBoolean> RFonAdvancedSettingsFoldoutChanged
		{
			get
			{
				if(r_FonAdvancedSettingsFoldoutChanged == null)
				{
					r_FonAdvancedSettingsFoldoutChanged = new(this, "onAdvancedSettingsFoldoutChanged");
					r_FonAdvancedSettingsFoldoutChanged.SetBelong(this.instance);
				}
				return r_FonAdvancedSettingsFoldoutChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] onScopedRegistriesSettingsFoldoutChanged
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RBoolean> r_FonScopedRegistriesSettingsFoldoutChanged;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RBoolean> RFonScopedRegistriesSettingsFoldoutChanged
		{
			get
			{
				if(r_FonScopedRegistriesSettingsFoldoutChanged == null)
				{
					r_FonScopedRegistriesSettingsFoldoutChanged = new(this, "onScopedRegistriesSettingsFoldoutChanged");
					r_FonScopedRegistriesSettingsFoldoutChanged.SetBelong(this.instance);
				}
				return r_FonScopedRegistriesSettingsFoldoutChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] onSeeAllVersionsChanged
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RBoolean> r_FonSeeAllVersionsChanged;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RBoolean> RFonSeeAllVersionsChanged
		{
			get
			{
				if(r_FonSeeAllVersionsChanged == null)
				{
					r_FonSeeAllVersionsChanged = new(this, "onSeeAllVersionsChanged");
					r_FonSeeAllVersionsChanged.SetBelong(this.instance);
				}
				return r_FonSeeAllVersionsChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Int64] onLoadAssetsChanged
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RInt64> r_FonLoadAssetsChanged;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RInt64> RFonLoadAssetsChanged
		{
			get
			{
				if(r_FonLoadAssetsChanged == null)
				{
					r_FonLoadAssetsChanged = new(this, "onLoadAssetsChanged");
					r_FonLoadAssetsChanged.SetBelong(this.instance);
				}
				return r_FonLoadAssetsChanged;
			}
		}

		/// <summary>
		/// System.Action onInitializationFinished
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction r_FonInitializationFinished;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction RFonInitializationFinished
		{
			get
			{
				if(r_FonInitializationFinished == null)
				{
					r_FonInitializationFinished = new(this, "onInitializationFinished");
					r_FonInitializationFinished.SetBelong(this.instance);
				}
				return r_FonInitializationFinished;
			}
		}

		/// <summary>
		/// Boolean dismissPreviewPackagesInUse
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PdismissPreviewPackagesInUse;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPdismissPreviewPackagesInUse
		{
			get
			{
				if(r_PdismissPreviewPackagesInUse == null)
				{
					r_PdismissPreviewPackagesInUse = new(this, "dismissPreviewPackagesInUse", -1);
					r_PdismissPreviewPackagesInUse.SetBelong(this.instance);
				}
				return r_PdismissPreviewPackagesInUse;
			}
		}

		/// <summary>
		/// Boolean enablePreReleasePackages
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PenablePreReleasePackages;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPenablePreReleasePackages
		{
			get
			{
				if(r_PenablePreReleasePackages == null)
				{
					r_PenablePreReleasePackages = new(this, "enablePreReleasePackages", -1);
					r_PenablePreReleasePackages.SetBelong(this.instance);
				}
				return r_PenablePreReleasePackages;
			}
		}

		/// <summary>
		/// Boolean advancedSettingsExpanded
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PadvancedSettingsExpanded;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPadvancedSettingsExpanded
		{
			get
			{
				if(r_PadvancedSettingsExpanded == null)
				{
					r_PadvancedSettingsExpanded = new(this, "advancedSettingsExpanded", -1);
					r_PadvancedSettingsExpanded.SetBelong(this.instance);
				}
				return r_PadvancedSettingsExpanded;
			}
		}

		/// <summary>
		/// Boolean scopedRegistriesSettingsExpanded
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PscopedRegistriesSettingsExpanded;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPscopedRegistriesSettingsExpanded
		{
			get
			{
				if(r_PscopedRegistriesSettingsExpanded == null)
				{
					r_PscopedRegistriesSettingsExpanded = new(this, "scopedRegistriesSettingsExpanded", -1);
					r_PscopedRegistriesSettingsExpanded.SetBelong(this.instance);
				}
				return r_PscopedRegistriesSettingsExpanded;
			}
		}

		/// <summary>
		/// Boolean seeAllPackageVersions
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PseeAllPackageVersions;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPseeAllPackageVersions
		{
			get
			{
				if(r_PseeAllPackageVersions == null)
				{
					r_PseeAllPackageVersions = new(this, "seeAllPackageVersions", -1);
					r_PseeAllPackageVersions.SetBelong(this.instance);
				}
				return r_PseeAllPackageVersions;
			}
		}

		/// <summary>
		/// Int64 loadAssets
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_PloadAssets;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RPloadAssets
		{
			get
			{
				if(r_PloadAssets == null)
				{
					r_PloadAssets = new(this, "loadAssets", -1);
					r_PloadAssets.SetBelong(this.instance);
				}
				return r_PloadAssets;
			}
		}

		/// <summary>
		/// Boolean oneTimeWarningShown
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PoneTimeWarningShown;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPoneTimeWarningShown
		{
			get
			{
				if(r_PoneTimeWarningShown == null)
				{
					r_PoneTimeWarningShown = new(this, "oneTimeWarningShown", -1);
					r_PoneTimeWarningShown.SetBelong(this.instance);
				}
				return r_PoneTimeWarningShown;
			}
		}

		/// <summary>
		/// Boolean isUserAddingNewScopedRegistry
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisUserAddingNewScopedRegistry;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisUserAddingNewScopedRegistry
		{
			get
			{
				if(r_PisUserAddingNewScopedRegistry == null)
				{
					r_PisUserAddingNewScopedRegistry = new(this, "isUserAddingNewScopedRegistry", -1);
					r_PisUserAddingNewScopedRegistry.SetBelong(this.instance);
				}
				return r_PisUserAddingNewScopedRegistry;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[UnityEditor.PackageManager.RegistryInfo] registries
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RRegistryInfo> r_Pregistries;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RRegistryInfo> RPregistries
		{
			get
			{
				if(r_Pregistries == null)
				{
					r_Pregistries = new(this, "registries", -1);
					r_Pregistries.SetBelong(this.instance);
				}
				return r_Pregistries;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.RegistryInfo] scopedRegistries
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RRegistryInfo> r_PscopedRegistries;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RRegistryInfo> RPscopedRegistries
		{
			get
			{
				if(r_PscopedRegistries == null)
				{
					r_PscopedRegistries = new(this, "scopedRegistries", -1);
					r_PscopedRegistries.SetBelong(this.instance);
				}
				return r_PscopedRegistries;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.RegistryInfoDraft registryInfoDraft
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRegistryInfoDraft r_PregistryInfoDraft;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRegistryInfoDraft RPregistryInfoDraft
		{
			get
			{
				if(r_PregistryInfoDraft == null)
				{
					r_PregistryInfoDraft = new(this, "registryInfoDraft", -1);
					r_PregistryInfoDraft.SetBelong(this.instance);
				}
				return r_PregistryInfoDraft;
			}
		}

		/// <summary>
		/// Void SetRegistries(UnityEditor.PackageManager.RegistryInfo[])
		/// </summary>
		protected RMethod r_MSetRegistries_RegistryInfoArray;
		public virtual RMethod RMSetRegistries_RegistryInfoArray
		{
			get
			{
				if(r_MSetRegistries_RegistryInfoArray == null)
				{
					r_MSetRegistries_RegistryInfoArray = new(this, "SetRegistries", 0, typeof(UnityEditor.PackageManager.RegistryInfo).MakeArrayType());
					r_MSetRegistries_RegistryInfoArray.SetBelong(this.instance);
				}
				return r_MSetRegistries_RegistryInfoArray;
			}
		}

		/// <summary>
		/// Boolean AddRegistry(UnityEditor.PackageManager.RegistryInfo)
		/// </summary>
		protected RMethod r_MAddRegistry_RegistryInfo;
		public virtual RMethod RMAddRegistry_RegistryInfo
		{
			get
			{
				if(r_MAddRegistry_RegistryInfo == null)
				{
					r_MAddRegistry_RegistryInfo = new(this, "AddRegistry", 0, typeof(UnityEditor.PackageManager.RegistryInfo));
					r_MAddRegistry_RegistryInfo.SetBelong(this.instance);
				}
				return r_MAddRegistry_RegistryInfo;
			}
		}

		/// <summary>
		/// Boolean UpdateRegistry(System.String, UnityEditor.PackageManager.RegistryInfo)
		/// </summary>
		protected RMethod r_MUpdateRegistry_String_RegistryInfo;
		public virtual RMethod RMUpdateRegistry_String_RegistryInfo
		{
			get
			{
				if(r_MUpdateRegistry_String_RegistryInfo == null)
				{
					r_MUpdateRegistry_String_RegistryInfo = new(this, "UpdateRegistry", 0, typeof(System.String), typeof(UnityEditor.PackageManager.RegistryInfo));
					r_MUpdateRegistry_String_RegistryInfo.SetBelong(this.instance);
				}
				return r_MUpdateRegistry_String_RegistryInfo;
			}
		}

		/// <summary>
		/// Boolean RemoveRegistry(System.String)
		/// </summary>
		protected RMethod r_MRemoveRegistry_String;
		public virtual RMethod RMRemoveRegistry_String
		{
			get
			{
				if(r_MRemoveRegistry_String == null)
				{
					r_MRemoveRegistry_String = new(this, "RemoveRegistry", 0, typeof(System.String));
					r_MRemoveRegistry_String.SetBelong(this.instance);
				}
				return r_MRemoveRegistry_String;
			}
		}

		/// <summary>
		/// Void SelectRegistry(System.String)
		/// </summary>
		protected RMethod r_MSelectRegistry_String;
		public virtual RMethod RMSelectRegistry_String
		{
			get
			{
				if(r_MSelectRegistry_String == null)
				{
					r_MSelectRegistry_String = new(this, "SelectRegistry", 0, typeof(System.String));
					r_MSelectRegistry_String.SetBelong(this.instance);
				}
				return r_MSelectRegistry_String;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_MOnEnable;
		public virtual RMethod RMOnEnable
		{
			get
			{
				if(r_MOnEnable == null)
				{
					r_MOnEnable = new(this, "OnEnable", 0);
					r_MOnEnable.SetBelong(this.instance);
				}
				return r_MOnEnable;
			}
		}

		/// <summary>
		/// Void OnDisable()
		/// </summary>
		protected RMethod r_MOnDisable;
		public virtual RMethod RMOnDisable
		{
			get
			{
				if(r_MOnDisable == null)
				{
					r_MOnDisable = new(this, "OnDisable", 0);
					r_MOnDisable.SetBelong(this.instance);
				}
				return r_MOnDisable;
			}
		}

		/// <summary>
		/// Void Save()
		/// </summary>
		protected RMethod r_MSave;
		public virtual RMethod RMSave
		{
			get
			{
				if(r_MSave == null)
				{
					r_MSave = new(this, "Save", 0);
					r_MSave.SetBelong(this.instance);
				}
				return r_MSave;
			}
		}

		/// <summary>
		/// Void OnInitializationFinished()
		/// </summary>
		protected RMethod r_MOnInitializationFinished;
		public virtual RMethod RMOnInitializationFinished
		{
			get
			{
				if(r_MOnInitializationFinished == null)
				{
					r_MOnInitializationFinished = new(this, "OnInitializationFinished", 0);
					r_MOnInitializationFinished.SetBelong(this.instance);
				}
				return r_MOnInitializationFinished;
			}
		}

		/// <summary>
		/// Void OnEnablePreReleasePackagesChanged(Boolean)
		/// </summary>
		protected RMethod r_MOnEnablePreReleasePackagesChanged_Boolean;
		public virtual RMethod RMOnEnablePreReleasePackagesChanged_Boolean
		{
			get
			{
				if(r_MOnEnablePreReleasePackagesChanged_Boolean == null)
				{
					r_MOnEnablePreReleasePackagesChanged_Boolean = new(this, "OnEnablePreReleasePackagesChanged", 0, typeof(System.Boolean));
					r_MOnEnablePreReleasePackagesChanged_Boolean.SetBelong(this.instance);
				}
				return r_MOnEnablePreReleasePackagesChanged_Boolean;
			}
		}

		/// <summary>
		/// Void OnAdvancedSettingsFoldoutChanged(Boolean)
		/// </summary>
		protected RMethod r_MOnAdvancedSettingsFoldoutChanged_Boolean;
		public virtual RMethod RMOnAdvancedSettingsFoldoutChanged_Boolean
		{
			get
			{
				if(r_MOnAdvancedSettingsFoldoutChanged_Boolean == null)
				{
					r_MOnAdvancedSettingsFoldoutChanged_Boolean = new(this, "OnAdvancedSettingsFoldoutChanged", 0, typeof(System.Boolean));
					r_MOnAdvancedSettingsFoldoutChanged_Boolean.SetBelong(this.instance);
				}
				return r_MOnAdvancedSettingsFoldoutChanged_Boolean;
			}
		}

		/// <summary>
		/// Void OnScopedRegistriesSettingsFoldoutChanged(Boolean)
		/// </summary>
		protected RMethod r_MOnScopedRegistriesSettingsFoldoutChanged_Boolean;
		public virtual RMethod RMOnScopedRegistriesSettingsFoldoutChanged_Boolean
		{
			get
			{
				if(r_MOnScopedRegistriesSettingsFoldoutChanged_Boolean == null)
				{
					r_MOnScopedRegistriesSettingsFoldoutChanged_Boolean = new(this, "OnScopedRegistriesSettingsFoldoutChanged", 0, typeof(System.Boolean));
					r_MOnScopedRegistriesSettingsFoldoutChanged_Boolean.SetBelong(this.instance);
				}
				return r_MOnScopedRegistriesSettingsFoldoutChanged_Boolean;
			}
		}

		/// <summary>
		/// Void OnSeeAllPackageVersionsChanged(Boolean)
		/// </summary>
		protected RMethod r_MOnSeeAllPackageVersionsChanged_Boolean;
		public virtual RMethod RMOnSeeAllPackageVersionsChanged_Boolean
		{
			get
			{
				if(r_MOnSeeAllPackageVersionsChanged_Boolean == null)
				{
					r_MOnSeeAllPackageVersionsChanged_Boolean = new(this, "OnSeeAllPackageVersionsChanged", 0, typeof(System.Boolean));
					r_MOnSeeAllPackageVersionsChanged_Boolean.SetBelong(this.instance);
				}
				return r_MOnSeeAllPackageVersionsChanged_Boolean;
			}
		}

		/// <summary>
		/// Void OnLoadAssetsChanged(Int64)
		/// </summary>
		protected RMethod r_MOnLoadAssetsChanged_Int64;
		public virtual RMethod RMOnLoadAssetsChanged_Int64
		{
			get
			{
				if(r_MOnLoadAssetsChanged_Int64 == null)
				{
					r_MOnLoadAssetsChanged_Int64 = new(this, "OnLoadAssetsChanged", 0, typeof(System.Int64));
					r_MOnLoadAssetsChanged_Int64.SetBelong(this.instance);
				}
				return r_MOnLoadAssetsChanged_Int64;
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


        public RPackageManagerProjectSettingsProxy() : base("UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy")
        {
        }

        public RPackageManagerProjectSettingsProxy(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy")
		{
            SetInstance(instance);
		}

        public RPackageManagerProjectSettingsProxy(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageManagerProjectSettingsProxy(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetRegistries(UnityEditor.PackageManager.RegistryInfo[] @registries)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@registries};
            var ___result = RMSetRegistries_RegistryInfoArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AddRegistry(UnityEditor.PackageManager.RegistryInfo @registry)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@registry};
            var ___result = RMAddRegistry_RegistryInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UpdateRegistry(System.String @oldName, UnityEditor.PackageManager.RegistryInfo @newRegistry)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldName, @newRegistry};
            var ___result = RMUpdateRegistry_String_RegistryInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean RemoveRegistry(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMRemoveRegistry_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SelectRegistry(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMSelectRegistry_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDisable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Save()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSave.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInitializationFinished()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnInitializationFinished.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnEnablePreReleasePackagesChanged(System.Boolean @enablePreReleasePackages)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enablePreReleasePackages};
            var ___result = RMOnEnablePreReleasePackagesChanged_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAdvancedSettingsFoldoutChanged(System.Boolean @advancedSettingsExpanded)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@advancedSettingsExpanded};
            var ___result = RMOnAdvancedSettingsFoldoutChanged_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnScopedRegistriesSettingsFoldoutChanged(System.Boolean @scopedRegistriesSettingsExpanded)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scopedRegistriesSettingsExpanded};
            var ___result = RMOnScopedRegistriesSettingsFoldoutChanged_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSeeAllPackageVersionsChanged(System.Boolean @seeAllPackageVersions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@seeAllPackageVersions};
            var ___result = RMOnSeeAllPackageVersionsChanged_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadAssetsChanged(System.Int64 @loadAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@loadAssets};
            var ___result = RMOnLoadAssetsChanged_Int64.Invoke(___genericsType, ___parameters);

            
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
