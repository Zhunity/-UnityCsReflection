using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.SortKey
	/// </summary>
    public partial class RSortKey : RMember //
    {

		/// <summary>
		/// System.String source
		/// </summary>
		protected RSystem.RString r_source;
		public virtual RSystem.RString Rsource
		{
			get
			{
				if(r_source == null)
				{
					r_source = new(this, "source");
					r_source.SetBelong(this.instance);
				}
				return r_source;
			}
		}

		/// <summary>
		/// System.Byte[] key
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_key;
		public virtual RFieldArray<RSystem.RByte> Rkey
		{
			get
			{
				if(r_key == null)
				{
					r_key = new(this, "key");
					r_key.SetBelong(this.instance);
				}
				return r_key;
			}
		}

		/// <summary>
		/// System.Globalization.CompareOptions options
		/// </summary>
		protected RField r_options;
		public virtual RField Roptions
		{
			get
			{
				if(r_options == null)
				{
					r_options = new(this, "options");
					r_options.SetBelong(this.instance);
				}
				return r_options;
			}
		}

		/// <summary>
		/// System.Int32 lcid
		/// </summary>
		protected RSystem.RInt32 r_lcid;
		public virtual RSystem.RInt32 Rlcid
		{
			get
			{
				if(r_lcid == null)
				{
					r_lcid = new(this, "lcid");
					r_lcid.SetBelong(this.instance);
				}
				return r_lcid;
			}
		}

		/// <summary>
		/// System.String OriginalString
		/// </summary>
		protected RSystem.RString r_OriginalString;
		public virtual RSystem.RString ROriginalString
		{
			get
			{
				if(r_OriginalString == null)
				{
					r_OriginalString = new(this, "OriginalString", -1);
					r_OriginalString.SetBelong(this.instance);
				}
				return r_OriginalString;
			}
		}

		/// <summary>
		/// Byte[] KeyData
		/// </summary>
		protected RPropertyArray<RSystem.RByte> r_KeyData;
		public virtual RPropertyArray<RSystem.RByte> RKeyData
		{
			get
			{
				if(r_KeyData == null)
				{
					r_KeyData = new(this, "KeyData", -1);
					r_KeyData.SetBelong(this.instance);
				}
				return r_KeyData;
			}
		}

		/// <summary>
		/// Int32 Compare(System.Globalization.SortKey, System.Globalization.SortKey)
		/// </summary>
		protected static RMethod r_Compare_SortKey_SortKey;
		public static RMethod RCompare_SortKey_SortKey
		{
			get
			{
				if(r_Compare_SortKey_SortKey == null)
				{
					r_Compare_SortKey_SortKey = new(typeof(System.Globalization.SortKey), "Compare", 0, typeof(System.Globalization.SortKey), typeof(System.Globalization.SortKey));
					r_Compare_SortKey_SortKey.SetBelong(null);
				}
				return r_Compare_SortKey_SortKey;
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


        public RSortKey() : base("System.Globalization.SortKey")
        {
        }

        public RSortKey(System.Object instance) : base("System.Globalization.SortKey")
		{
            SetInstance(instance);
		}

        public RSortKey(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSortKey(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Int32 Compare(System.Globalization.SortKey @sortkey1, System.Globalization.SortKey @sortkey2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sortkey1, @sortkey2};
            var ___result = RCompare_SortKey_SortKey.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
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
