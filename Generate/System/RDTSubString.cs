using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.DTSubString
	/// </summary>
    public partial class RDTSubString : RMember //
    {

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] s
		/// </summary>
		protected RSystem.RReadOnlySpan<RSystem.RChar> r_s;
		public virtual RSystem.RReadOnlySpan<RSystem.RChar> Rs
		{
			get
			{
				if(r_s == null)
				{
					r_s = new(this, "s");
					r_s.SetBelong(this.instance);
				}
				return r_s;
			}
		}

		/// <summary>
		/// System.Int32 index
		/// </summary>
		protected RSystem.RInt32 r_index;
		public virtual RSystem.RInt32 Rindex
		{
			get
			{
				if(r_index == null)
				{
					r_index = new(this, "index");
					r_index.SetBelong(this.instance);
				}
				return r_index;
			}
		}

		/// <summary>
		/// System.Int32 length
		/// </summary>
		protected RSystem.RInt32 r_length;
		public virtual RSystem.RInt32 Rlength
		{
			get
			{
				if(r_length == null)
				{
					r_length = new(this, "length");
					r_length.SetBelong(this.instance);
				}
				return r_length;
			}
		}

		/// <summary>
		/// System.DTSubStringType type
		/// </summary>
		protected RField r_type;
		public virtual RField Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.Int32 value
		/// </summary>
		protected RSystem.RInt32 r_value;
		public virtual RSystem.RInt32 Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value");
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// Char Item [Int32]
		/// </summary>
		protected RSystem.RChar r_Item_Int32;
		public virtual RSystem.RChar RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
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


        public RDTSubString() : base("System.DTSubString")
        {
        }

        public RDTSubString(System.Object instance) : base("System.DTSubString")
		{
            SetInstance(instance);
		}

        public RDTSubString(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDTSubString(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
