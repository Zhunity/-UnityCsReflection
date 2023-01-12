using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleBackground
	/// </summary>
    public partial class RStyleBackground : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Background m_Value
		/// </summary>
		protected RUnityEngine.RUIElements.RBackground r_Fm_Value;
		public virtual RUnityEngine.RUIElements.RBackground RFm_Value
		{
			get
			{
				if(r_Fm_Value == null)
				{
					r_Fm_Value = new(this, "m_Value");
					r_Fm_Value.SetBelong(this.instance);
				}
				return r_Fm_Value;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleKeyword m_Keyword
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleKeyword r_Fm_Keyword;
		public virtual RUnityEngine.RUIElements.RStyleKeyword RFm_Keyword
		{
			get
			{
				if(r_Fm_Keyword == null)
				{
					r_Fm_Keyword = new(this, "m_Keyword");
					r_Fm_Keyword.SetBelong(this.instance);
				}
				return r_Fm_Keyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background value
		/// </summary>
		protected RUnityEngine.RUIElements.RBackground r_Pvalue;
		public virtual RUnityEngine.RUIElements.RBackground RPvalue
		{
			get
			{
				if(r_Pvalue == null)
				{
					r_Pvalue = new(this, "value", -1);
					r_Pvalue.SetBelong(this.instance);
				}
				return r_Pvalue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleKeyword keyword
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleKeyword r_Pkeyword;
		public virtual RUnityEngine.RUIElements.RStyleKeyword RPkeyword
		{
			get
			{
				if(r_Pkeyword == null)
				{
					r_Pkeyword = new(this, "keyword", -1);
					r_Pkeyword.SetBelong(this.instance);
				}
				return r_Pkeyword;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.StyleBackground, UnityEngine.UIElements.StyleBackground)
		/// </summary>
		protected static RMethod r_Mop_Equality_StyleBackground_StyleBackground;
		public static RMethod RMop_Equality_StyleBackground_StyleBackground
		{
			get
			{
				if(r_Mop_Equality_StyleBackground_StyleBackground == null)
				{
					r_Mop_Equality_StyleBackground_StyleBackground = new(typeof(UnityEngine.UIElements.StyleBackground), "op_Equality", 0, typeof(UnityEngine.UIElements.StyleBackground), typeof(UnityEngine.UIElements.StyleBackground));
					r_Mop_Equality_StyleBackground_StyleBackground.SetBelong(null);
				}
				return r_Mop_Equality_StyleBackground_StyleBackground;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleBackground, UnityEngine.UIElements.StyleBackground)
		/// </summary>
		protected static RMethod r_Mop_Inequality_StyleBackground_StyleBackground;
		public static RMethod RMop_Inequality_StyleBackground_StyleBackground
		{
			get
			{
				if(r_Mop_Inequality_StyleBackground_StyleBackground == null)
				{
					r_Mop_Inequality_StyleBackground_StyleBackground = new(typeof(UnityEngine.UIElements.StyleBackground), "op_Inequality", 0, typeof(UnityEngine.UIElements.StyleBackground), typeof(UnityEngine.UIElements.StyleBackground));
					r_Mop_Inequality_StyleBackground_StyleBackground.SetBelong(null);
				}
				return r_Mop_Inequality_StyleBackground_StyleBackground;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground op_Implicit(UnityEngine.UIElements.StyleKeyword)
		/// </summary>
		protected static RMethod r_Mop_Implicit_StyleKeyword;
		public static RMethod RMop_Implicit_StyleKeyword
		{
			get
			{
				if(r_Mop_Implicit_StyleKeyword == null)
				{
					r_Mop_Implicit_StyleKeyword = new(typeof(UnityEngine.UIElements.StyleBackground), "op_Implicit", 0, typeof(UnityEngine.UIElements.StyleKeyword));
					r_Mop_Implicit_StyleKeyword.SetBelong(null);
				}
				return r_Mop_Implicit_StyleKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground op_Implicit(UnityEngine.UIElements.Background)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Background;
		public static RMethod RMop_Implicit_Background
		{
			get
			{
				if(r_Mop_Implicit_Background == null)
				{
					r_Mop_Implicit_Background = new(typeof(UnityEngine.UIElements.StyleBackground), "op_Implicit", 0, typeof(UnityEngine.UIElements.Background));
					r_Mop_Implicit_Background.SetBelong(null);
				}
				return r_Mop_Implicit_Background;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground op_Implicit(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Texture2D;
		public static RMethod RMop_Implicit_Texture2D
		{
			get
			{
				if(r_Mop_Implicit_Texture2D == null)
				{
					r_Mop_Implicit_Texture2D = new(typeof(UnityEngine.UIElements.StyleBackground), "op_Implicit", 0, typeof(UnityEngine.Texture2D));
					r_Mop_Implicit_Texture2D.SetBelong(null);
				}
				return r_Mop_Implicit_Texture2D;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleBackground)
		/// </summary>
		protected RMethod r_MEquals_StyleBackground;
		public virtual RMethod RMEquals_StyleBackground
		{
			get
			{
				if(r_MEquals_StyleBackground == null)
				{
					r_MEquals_StyleBackground = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StyleBackground));
					r_MEquals_StyleBackground.SetBelong(this.instance);
				}
				return r_MEquals_StyleBackground;
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


        public RStyleBackground() : base("UnityEngine.UIElements.StyleBackground")
        {
        }

        public RStyleBackground(System.Object instance) : base("UnityEngine.UIElements.StyleBackground")
		{
            SetInstance(instance);
		}

        public RStyleBackground(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleBackground(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean op_Equality(UnityEngine.UIElements.StyleBackground @lhs, UnityEngine.UIElements.StyleBackground @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_StyleBackground_StyleBackground.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StyleBackground @lhs, UnityEngine.UIElements.StyleBackground @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_StyleBackground_StyleBackground.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.StyleBackground op_Implicit(UnityEngine.UIElements.StyleKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMop_Implicit_StyleKeyword.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleBackground)___result;
        }


        public static UnityEngine.UIElements.StyleBackground op_Implicit(UnityEngine.UIElements.Background @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_Background.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleBackground)___result;
        }


        public static UnityEngine.UIElements.StyleBackground op_Implicit(UnityEngine.Texture2D @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_Texture2D.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleBackground)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.StyleBackground @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_StyleBackground.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
