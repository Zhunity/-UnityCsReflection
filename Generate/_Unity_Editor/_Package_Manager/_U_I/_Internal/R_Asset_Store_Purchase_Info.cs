
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo
	/// </summary>
    public partial class RAssetStorePurchaseInfo : RMember //
    {

		/// <summary>
		/// System.Int64 productId
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_FproductId;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RFproductId
		{
			get
			{
				if(r_FproductId == null)
				{
					r_FproductId = new(this, "productId");
					r_FproductId.SetBelong(this.instance);
				}
				return r_FproductId;
			}
		}

		/// <summary>
		/// System.String purchasedTime
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_FpurchasedTime;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFpurchasedTime
		{
			get
			{
				if(r_FpurchasedTime == null)
				{
					r_FpurchasedTime = new(this, "purchasedTime");
					r_FpurchasedTime.SetBelong(this.instance);
				}
				return r_FpurchasedTime;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_FdisplayName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFdisplayName
		{
			get
			{
				if(r_FdisplayName == null)
				{
					r_FdisplayName = new(this, "displayName");
					r_FdisplayName.SetBelong(this.instance);
				}
				return r_FdisplayName;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] tags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RSystem.RString> r_Ftags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RSystem.RString> RFtags
		{
			get
			{
				if(r_Ftags == null)
				{
					r_Ftags = new(this, "tags");
					r_Ftags.SetBelong(this.instance);
				}
				return r_Ftags;
			}
		}

		/// <summary>
		/// System.Boolean isHidden
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FisHidden;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFisHidden
		{
			get
			{
				if(r_FisHidden == null)
				{
					r_FisHidden = new(this, "isHidden");
					r_FisHidden.SetBelong(this.instance);
				}
				return r_FisHidden;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo ParsePurchaseInfo(System.Collections.Generic.IDictionary`2[System.String,System.Object])
		/// </summary>
		protected static RMethod r_MParsePurchaseInfo_IDictionary_d_String_Object_p_;
		public static RMethod RMParsePurchaseInfo_IDictionary_d_String_Object_p_
		{
			get
			{
				if(r_MParsePurchaseInfo_IDictionary_d_String_Object_p_ == null)
				{
					r_MParsePurchaseInfo_IDictionary_d_String_Object_p_ = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo"), "ParsePurchaseInfo", 0, typeof(System.Collections.Generic.IDictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object)));
					r_MParsePurchaseInfo_IDictionary_d_String_Object_p_.SetBelong(null);
				}
				return r_MParsePurchaseInfo_IDictionary_d_String_Object_p_;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo)
		/// </summary>
		protected RMethod r_MEquals_AssetStorePurchaseInfo;
		public virtual RMethod RMEquals_AssetStorePurchaseInfo
		{
			get
			{
				if(r_MEquals_AssetStorePurchaseInfo == null)
				{
					r_MEquals_AssetStorePurchaseInfo = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo"));
					r_MEquals_AssetStorePurchaseInfo.SetBelong(this.instance);
				}
				return r_MEquals_AssetStorePurchaseInfo;
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


        public RAssetStorePurchaseInfo() : base("UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo")
        {
        }

        public RAssetStorePurchaseInfo(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo")
		{
            SetInstance(instance);
		}

        public RAssetStorePurchaseInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStorePurchaseInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo ParsePurchaseInfo(System.Collections.Generic.IDictionary<System.String, System.Object> @rawInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawInfo};
            var ___result = RMParsePurchaseInfo_IDictionary_d_String_Object_p_.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo(___result);
        }


        public virtual System.Boolean Equals(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_AssetStorePurchaseInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
