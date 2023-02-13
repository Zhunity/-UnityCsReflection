
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreCachePathProxy
	/// </summary>
    public partial class RAssetStoreCachePathProxy : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEditorInternal.AssetStoreCachePathManager+CachePathConfig] onConfigChanged
		/// </summary>
		protected REvent r_EonConfigChanged;
		public virtual REvent REonConfigChanged
		{
			get
			{
				if(r_EonConfigChanged == null)
				{
					r_EonConfigChanged = new(this, "onConfigChanged");
					r_EonConfigChanged.SetBelong(this.instance);
				}
				return r_EonConfigChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditorInternal.AssetStoreCachePathManager+CachePathConfig] onConfigChanged
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditorInternal.RAssetStoreCachePathManager.RCachePathConfig> r_FonConfigChanged;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditorInternal.RAssetStoreCachePathManager.RCachePathConfig> RFonConfigChanged
		{
			get
			{
				if(r_FonConfigChanged == null)
				{
					r_FonConfigChanged = new(this, "onConfigChanged");
					r_FonConfigChanged.SetBelong(this.instance);
				}
				return r_FonConfigChanged;
			}
		}

		/// <summary>
		/// UnityEditorInternal.AssetStoreCachePathManager+CachePathConfig m_CurrentConfig
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditorInternal.RAssetStoreCachePathManager.RCachePathConfig r_Fm_CurrentConfig;
		public virtual SMFrame.Editor.Refleaction.RUnityEditorInternal.RAssetStoreCachePathManager.RCachePathConfig RFm_CurrentConfig
		{
			get
			{
				if(r_Fm_CurrentConfig == null)
				{
					r_Fm_CurrentConfig = new(this, "m_CurrentConfig");
					r_Fm_CurrentConfig.SetBelong(this.instance);
				}
				return r_Fm_CurrentConfig;
			}
		}

		/// <summary>
		/// CachePathConfig GetDefaultConfig()
		/// </summary>
		protected RMethod r_MGetDefaultConfig;
		public virtual RMethod RMGetDefaultConfig
		{
			get
			{
				if(r_MGetDefaultConfig == null)
				{
					r_MGetDefaultConfig = new(this, "GetDefaultConfig", 0);
					r_MGetDefaultConfig.SetBelong(this.instance);
				}
				return r_MGetDefaultConfig;
			}
		}

		/// <summary>
		/// CachePathConfig GetConfig()
		/// </summary>
		protected RMethod r_MGetConfig;
		public virtual RMethod RMGetConfig
		{
			get
			{
				if(r_MGetConfig == null)
				{
					r_MGetConfig = new(this, "GetConfig", 0);
					r_MGetConfig.SetBelong(this.instance);
				}
				return r_MGetConfig;
			}
		}

		/// <summary>
		/// ConfigStatus SetConfig(System.String)
		/// </summary>
		protected RMethod r_MSetConfig_String;
		public virtual RMethod RMSetConfig_String
		{
			get
			{
				if(r_MSetConfig_String == null)
				{
					r_MSetConfig_String = new(this, "SetConfig", 0, typeof(System.String));
					r_MSetConfig_String.SetBelong(this.instance);
				}
				return r_MSetConfig_String;
			}
		}

		/// <summary>
		/// ConfigStatus ResetConfig()
		/// </summary>
		protected RMethod r_MResetConfig;
		public virtual RMethod RMResetConfig
		{
			get
			{
				if(r_MResetConfig == null)
				{
					r_MResetConfig = new(this, "ResetConfig", 0);
					r_MResetConfig.SetBelong(this.instance);
				}
				return r_MResetConfig;
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


        public RAssetStoreCachePathProxy() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreCachePathProxy")
        {
        }

        public RAssetStoreCachePathProxy(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreCachePathProxy")
		{
            SetInstance(instance);
		}

        public RAssetStoreCachePathProxy(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStoreCachePathProxy(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual SMFrame.Editor.Refleaction.RUnityEditorInternal.RAssetStoreCachePathManager.RCachePathConfig GetDefaultConfig()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDefaultConfig.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditorInternal.RAssetStoreCachePathManager.RCachePathConfig(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditorInternal.RAssetStoreCachePathManager.RCachePathConfig GetConfig()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetConfig.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditorInternal.RAssetStoreCachePathManager.RCachePathConfig(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditorInternal.RAssetStoreCachePathManager.RConfigStatus SetConfig(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMSetConfig_String.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditorInternal.RAssetStoreCachePathManager.RConfigStatus(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditorInternal.RAssetStoreCachePathManager.RConfigStatus ResetConfig()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetConfig.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditorInternal.RAssetStoreCachePathManager.RConfigStatus(___result);
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
