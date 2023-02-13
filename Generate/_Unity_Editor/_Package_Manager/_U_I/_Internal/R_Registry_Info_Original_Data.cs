
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.RegistryInfoOriginalData
	/// </summary>
    public partial class RRegistryInfoOriginalData : RMember //
    {

		/// <summary>
		/// UnityEditor.PackageManager.RegistryInfo m_RegistryInfo
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RRegistryInfo r_Fm_RegistryInfo;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RRegistryInfo RFm_RegistryInfo
		{
			get
			{
				if(r_Fm_RegistryInfo == null)
				{
					r_Fm_RegistryInfo = new(this, "m_RegistryInfo");
					r_Fm_RegistryInfo.SetBelong(this.instance);
				}
				return r_Fm_RegistryInfo;
			}
		}

		/// <summary>
		/// System.String id
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Pid;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPid
		{
			get
			{
				if(r_Pid == null)
				{
					r_Pid = new(this, "id", -1);
					r_Pid.SetBelong(this.instance);
				}
				return r_Pid;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.SearchCapabilities capabilities
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RSearchCapabilities r_Pcapabilities;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RSearchCapabilities RPcapabilities
		{
			get
			{
				if(r_Pcapabilities == null)
				{
					r_Pcapabilities = new(this, "capabilities", -1);
					r_Pcapabilities.SetBelong(this.instance);
				}
				return r_Pcapabilities;
			}
		}

		/// <summary>
		/// Boolean isDefault
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisDefault;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisDefault
		{
			get
			{
				if(r_PisDefault == null)
				{
					r_PisDefault = new(this, "isDefault", -1);
					r_PisDefault.SetBelong(this.instance);
				}
				return r_PisDefault;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// System.String url
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Purl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPurl
		{
			get
			{
				if(r_Purl == null)
				{
					r_Purl = new(this, "url", -1);
					r_Purl.SetBelong(this.instance);
				}
				return r_Purl;
			}
		}

		/// <summary>
		/// System.String[] scopes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RString> r_Pscopes;
		public virtual SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RString> RPscopes
		{
			get
			{
				if(r_Pscopes == null)
				{
					r_Pscopes = new(this, "scopes", -1);
					r_Pscopes.SetBelong(this.instance);
				}
				return r_Pscopes;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.ConfigSource configSource
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RConfigSource r_PconfigSource;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RConfigSource RPconfigSource
		{
			get
			{
				if(r_PconfigSource == null)
				{
					r_PconfigSource = new(this, "configSource", -1);
					r_PconfigSource.SetBelong(this.instance);
				}
				return r_PconfigSource;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
					r_PhideFlags.SetBelong(this.instance);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void SetRegistryInfo(UnityEditor.PackageManager.RegistryInfo)
		/// </summary>
		protected RMethod r_MSetRegistryInfo_RegistryInfo;
		public virtual RMethod RMSetRegistryInfo_RegistryInfo
		{
			get
			{
				if(r_MSetRegistryInfo_RegistryInfo == null)
				{
					r_MSetRegistryInfo_RegistryInfo = new(this, "SetRegistryInfo", 0, typeof(UnityEditor.PackageManager.RegistryInfo));
					r_MSetRegistryInfo_RegistryInfo.SetBelong(this.instance);
				}
				return r_MSetRegistryInfo_RegistryInfo;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.RegistryInfo CopyOriginal(UnityEditor.PackageManager.RegistryInfo)
		/// </summary>
		protected RMethod r_MCopyOriginal_RegistryInfo;
		public virtual RMethod RMCopyOriginal_RegistryInfo
		{
			get
			{
				if(r_MCopyOriginal_RegistryInfo == null)
				{
					r_MCopyOriginal_RegistryInfo = new(this, "CopyOriginal", 0, typeof(UnityEditor.PackageManager.RegistryInfo));
					r_MCopyOriginal_RegistryInfo.SetBelong(this.instance);
				}
				return r_MCopyOriginal_RegistryInfo;
			}
		}

		/// <summary>
		/// Boolean IsEqualTo(UnityEditor.PackageManager.RegistryInfo)
		/// </summary>
		protected RMethod r_MIsEqualTo_RegistryInfo;
		public virtual RMethod RMIsEqualTo_RegistryInfo
		{
			get
			{
				if(r_MIsEqualTo_RegistryInfo == null)
				{
					r_MIsEqualTo_RegistryInfo = new(this, "IsEqualTo", 0, typeof(UnityEditor.PackageManager.RegistryInfo));
					r_MIsEqualTo_RegistryInfo.SetBelong(this.instance);
				}
				return r_MIsEqualTo_RegistryInfo;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_MSetDirty;
		public virtual RMethod RMSetDirty
		{
			get
			{
				if(r_MSetDirty == null)
				{
					r_MSetDirty = new(this, "SetDirty", 0);
					r_MSetDirty.SetBelong(this.instance);
				}
				return r_MSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
					r_MGetInstanceID.SetBelong(this.instance);
				}
				return r_MGetInstanceID;
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
		/// System.String get_name()
		/// </summary>
		protected RMethod r_Mget_name;
		public virtual RMethod RMget_name
		{
			get
			{
				if(r_Mget_name == null)
				{
					r_Mget_name = new(this, "get_name", 0);
					r_Mget_name.SetBelong(this.instance);
				}
				return r_Mget_name;
			}
		}

		/// <summary>
		/// Void set_name(System.String)
		/// </summary>
		protected RMethod r_Mset_name_String;
		public virtual RMethod RMset_name_String
		{
			get
			{
				if(r_Mset_name_String == null)
				{
					r_Mset_name_String = new(this, "set_name", 0, typeof(System.String));
					r_Mset_name_String.SetBelong(this.instance);
				}
				return r_Mset_name_String;
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


        public RRegistryInfoOriginalData() : base("UnityEditor.PackageManager.UI.Internal.RegistryInfoOriginalData")
        {
        }

        public RRegistryInfoOriginalData(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.RegistryInfoOriginalData")
		{
            SetInstance(instance);
		}

        public RRegistryInfoOriginalData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRegistryInfoOriginalData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetRegistryInfo(UnityEditor.PackageManager.RegistryInfo @registryInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@registryInfo};
            var ___result = RMSetRegistryInfo_RegistryInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.PackageManager.RegistryInfo CopyOriginal(UnityEditor.PackageManager.RegistryInfo @original)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@original};
            var ___result = RMCopyOriginal_RegistryInfo.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.RegistryInfo)___result;
        }


        public virtual System.Boolean IsEqualTo(UnityEditor.PackageManager.RegistryInfo @registryInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@registryInfo};
            var ___result = RMIsEqualTo_RegistryInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String get_name()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_name.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void set_name(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_name_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
