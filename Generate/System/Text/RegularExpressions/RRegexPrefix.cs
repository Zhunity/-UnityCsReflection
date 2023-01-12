using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.RegexPrefix
	/// </summary>
    public partial class RRegexPrefix : RMember //
    {

		/// <summary>
		/// System.Boolean <CaseInsensitive>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__CaseInsensitive__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__CaseInsensitive__1__k__BackingField
		{
			get
			{
				if(r_F__0__CaseInsensitive__1__k__BackingField == null)
				{
					r_F__0__CaseInsensitive__1__k__BackingField = new(this, "<CaseInsensitive>k__BackingField");
					r_F__0__CaseInsensitive__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__CaseInsensitive__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexPrefix <Empty>k__BackingField
		/// </summary>
		protected static RSystem.RText.RRegularExpressions.RRegexPrefix r_F__0__Empty__1__k__BackingField;
		public static RSystem.RText.RRegularExpressions.RRegexPrefix RF__0__Empty__1__k__BackingField
		{
			get
			{
				if(r_F__0__Empty__1__k__BackingField == null)
				{
					r_F__0__Empty__1__k__BackingField = new( ReflectionUtils.GetType("System.Text.RegularExpressions.RegexPrefix"), "<Empty>k__BackingField");
					r_F__0__Empty__1__k__BackingField.SetBelong(null);
				}
				return r_F__0__Empty__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <Prefix>k__BackingField
		/// </summary>
		protected RSystem.RString r_F__0__Prefix__1__k__BackingField;
		public virtual RSystem.RString RF__0__Prefix__1__k__BackingField
		{
			get
			{
				if(r_F__0__Prefix__1__k__BackingField == null)
				{
					r_F__0__Prefix__1__k__BackingField = new(this, "<Prefix>k__BackingField");
					r_F__0__Prefix__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__Prefix__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean CaseInsensitive
		/// </summary>
		protected RSystem.RBoolean r_PCaseInsensitive;
		public virtual RSystem.RBoolean RPCaseInsensitive
		{
			get
			{
				if(r_PCaseInsensitive == null)
				{
					r_PCaseInsensitive = new(this, "CaseInsensitive", -1);
					r_PCaseInsensitive.SetBelong(this.instance);
				}
				return r_PCaseInsensitive;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexPrefix Empty
		/// </summary>
		protected static RSystem.RText.RRegularExpressions.RRegexPrefix r_PEmpty;
		public static RSystem.RText.RRegularExpressions.RRegexPrefix RPEmpty
		{
			get
			{
				if(r_PEmpty == null)
				{
					r_PEmpty = new( ReflectionUtils.GetType("System.Text.RegularExpressions.RegexPrefix"), "Empty", -1);
					r_PEmpty.SetBelong(null);
				}
				return r_PEmpty;
			}
		}

		/// <summary>
		/// System.String Prefix
		/// </summary>
		protected RSystem.RString r_PPrefix;
		public virtual RSystem.RString RPPrefix
		{
			get
			{
				if(r_PPrefix == null)
				{
					r_PPrefix = new(this, "Prefix", -1);
					r_PPrefix.SetBelong(this.instance);
				}
				return r_PPrefix;
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


        public RRegexPrefix() : base("System.Text.RegularExpressions.RegexPrefix")
        {
        }

        public RRegexPrefix(System.Object instance) : base("System.Text.RegularExpressions.RegexPrefix")
		{
            SetInstance(instance);
		}

        public RRegexPrefix(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRegexPrefix(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
