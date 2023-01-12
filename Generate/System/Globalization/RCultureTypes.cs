using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.CultureTypes
	/// </summary>
    public partial class RCultureTypes : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected RSystem.RInt32 r_Fvalue__;
		public virtual RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
					r_Fvalue__.SetBelong(this.instance);
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Globalization.CultureTypes NeutralCultures
		/// </summary>
		protected static RSystem.RGlobalization.RCultureTypes r_FNeutralCultures;
		public static RSystem.RGlobalization.RCultureTypes RFNeutralCultures
		{
			get
			{
				if(r_FNeutralCultures == null)
				{
					r_FNeutralCultures = new(typeof(System.Globalization.CultureTypes), "NeutralCultures");
					r_FNeutralCultures.SetBelong(null);
				}
				return r_FNeutralCultures;
			}
		}

		/// <summary>
		/// System.Globalization.CultureTypes SpecificCultures
		/// </summary>
		protected static RSystem.RGlobalization.RCultureTypes r_FSpecificCultures;
		public static RSystem.RGlobalization.RCultureTypes RFSpecificCultures
		{
			get
			{
				if(r_FSpecificCultures == null)
				{
					r_FSpecificCultures = new(typeof(System.Globalization.CultureTypes), "SpecificCultures");
					r_FSpecificCultures.SetBelong(null);
				}
				return r_FSpecificCultures;
			}
		}

		/// <summary>
		/// System.Globalization.CultureTypes InstalledWin32Cultures
		/// </summary>
		protected static RSystem.RGlobalization.RCultureTypes r_FInstalledWin32Cultures;
		public static RSystem.RGlobalization.RCultureTypes RFInstalledWin32Cultures
		{
			get
			{
				if(r_FInstalledWin32Cultures == null)
				{
					r_FInstalledWin32Cultures = new(typeof(System.Globalization.CultureTypes), "InstalledWin32Cultures");
					r_FInstalledWin32Cultures.SetBelong(null);
				}
				return r_FInstalledWin32Cultures;
			}
		}

		/// <summary>
		/// System.Globalization.CultureTypes AllCultures
		/// </summary>
		protected static RSystem.RGlobalization.RCultureTypes r_FAllCultures;
		public static RSystem.RGlobalization.RCultureTypes RFAllCultures
		{
			get
			{
				if(r_FAllCultures == null)
				{
					r_FAllCultures = new(typeof(System.Globalization.CultureTypes), "AllCultures");
					r_FAllCultures.SetBelong(null);
				}
				return r_FAllCultures;
			}
		}

		/// <summary>
		/// System.Globalization.CultureTypes UserCustomCulture
		/// </summary>
		protected static RSystem.RGlobalization.RCultureTypes r_FUserCustomCulture;
		public static RSystem.RGlobalization.RCultureTypes RFUserCustomCulture
		{
			get
			{
				if(r_FUserCustomCulture == null)
				{
					r_FUserCustomCulture = new(typeof(System.Globalization.CultureTypes), "UserCustomCulture");
					r_FUserCustomCulture.SetBelong(null);
				}
				return r_FUserCustomCulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureTypes ReplacementCultures
		/// </summary>
		protected static RSystem.RGlobalization.RCultureTypes r_FReplacementCultures;
		public static RSystem.RGlobalization.RCultureTypes RFReplacementCultures
		{
			get
			{
				if(r_FReplacementCultures == null)
				{
					r_FReplacementCultures = new(typeof(System.Globalization.CultureTypes), "ReplacementCultures");
					r_FReplacementCultures.SetBelong(null);
				}
				return r_FReplacementCultures;
			}
		}

		/// <summary>
		/// System.Globalization.CultureTypes WindowsOnlyCultures
		/// </summary>
		protected static RSystem.RGlobalization.RCultureTypes r_FWindowsOnlyCultures;
		public static RSystem.RGlobalization.RCultureTypes RFWindowsOnlyCultures
		{
			get
			{
				if(r_FWindowsOnlyCultures == null)
				{
					r_FWindowsOnlyCultures = new(typeof(System.Globalization.CultureTypes), "WindowsOnlyCultures");
					r_FWindowsOnlyCultures.SetBelong(null);
				}
				return r_FWindowsOnlyCultures;
			}
		}

		/// <summary>
		/// System.Globalization.CultureTypes FrameworkCultures
		/// </summary>
		protected static RSystem.RGlobalization.RCultureTypes r_FFrameworkCultures;
		public static RSystem.RGlobalization.RCultureTypes RFFrameworkCultures
		{
			get
			{
				if(r_FFrameworkCultures == null)
				{
					r_FFrameworkCultures = new(typeof(System.Globalization.CultureTypes), "FrameworkCultures");
					r_FFrameworkCultures.SetBelong(null);
				}
				return r_FFrameworkCultures;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
					r_MGetValue.SetBelong(this.instance);
				}
				return r_MGetValue;
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
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_MCompareTo_Object.SetBelong(this.instance);
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
					r_MToString_String.SetBelong(this.instance);
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
					r_MToString_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
					r_MHasFlag_Enum.SetBelong(this.instance);
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
					r_MGetTypeCode.SetBelong(this.instance);
				}
				return r_MGetTypeCode;
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


        public RCultureTypes() : base("System.Globalization.CultureTypes")
        {
        }

        public RCultureTypes(System.Object instance) : base("System.Globalization.CultureTypes")
		{
            SetInstance(instance);
		}

        public RCultureTypes(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCultureTypes(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
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
