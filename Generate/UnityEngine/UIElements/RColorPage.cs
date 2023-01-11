using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ColorPage
	/// </summary>
    public partial class RColorPage : RMember //
    {

		/// <summary>
		/// System.Boolean isValid
		/// </summary>
		protected RSystem.RBoolean r_isValid;
		public virtual RSystem.RBoolean RisValid
		{
			get
			{
				if(r_isValid == null)
				{
					r_isValid = new(this, "isValid");
					r_isValid.SetBelong(this.instance);
				}
				return r_isValid;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 pageAndID
		/// </summary>
		protected RUnityEngine.RColor32 r_pageAndID;
		public virtual RUnityEngine.RColor32 RpageAndID
		{
			get
			{
				if(r_pageAndID == null)
				{
					r_pageAndID = new(this, "pageAndID");
					r_pageAndID.SetBelong(this.instance);
				}
				return r_pageAndID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ColorPage Init(UnityEngine.UIElements.UIR.RenderChain, UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected static RMethod r_Init_RenderChain_BMPAlloc;
		public static RMethod RInit_RenderChain_BMPAlloc
		{
			get
			{
				if(r_Init_RenderChain_BMPAlloc == null)
				{
					r_Init_RenderChain_BMPAlloc = new( ReflectionUtils.GetType("UnityEngine.UIElements.ColorPage"), "Init", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_Init_RenderChain_BMPAlloc.SetBelong(null);
				}
				return r_Init_RenderChain_BMPAlloc;
			}
		}

		/// <summary>
		/// NativeColorPage ToNativeColorPage()
		/// </summary>
		protected RMethod r_ToNativeColorPage;
		public virtual RMethod RToNativeColorPage
		{
			get
			{
				if(r_ToNativeColorPage == null)
				{
					r_ToNativeColorPage = new(this, "ToNativeColorPage", 0);
					r_ToNativeColorPage.SetBelong(this.instance);
				}
				return r_ToNativeColorPage;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}


        public RColorPage() : base("UnityEngine.UIElements.ColorPage")
        {
        }

        public RColorPage(System.Object instance) : base("UnityEngine.UIElements.ColorPage")
		{
            SetInstance(instance);
		}

        public RColorPage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RColorPage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static RUnityEngine.RUIElements.RColorPage Init(RUnityEngine.RUIElements.RUIR.RRenderChain @renderChain, RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderChain.Value, @alloc.Value};
            var ___result = RInit_RenderChain_BMPAlloc.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RColorPage(___result);
        }


        public virtual RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage ToNativeColorPage()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToNativeColorPage.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
