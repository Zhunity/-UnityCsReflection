using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.LocalVariableInfo
	/// </summary>
    public partial class RLocalVariableInfo : RMember //
    {

		/// <summary>
		/// System.Type type
		/// </summary>
		protected RSystem.RType r_type;
		public virtual RSystem.RType Rtype
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
		/// System.Boolean is_pinned
		/// </summary>
		protected RField r_is_pinned;
		public virtual RField Ris_pinned
		{
			get
			{
				if(r_is_pinned == null)
				{
					r_is_pinned = new(this, "is_pinned");
					r_is_pinned.SetBelong(this.instance);
				}
				return r_is_pinned;
			}
		}

		/// <summary>
		/// System.UInt16 position
		/// </summary>
		protected RField r_position;
		public virtual RField Rposition
		{
			get
			{
				if(r_position == null)
				{
					r_position = new(this, "position");
					r_position.SetBelong(this.instance);
				}
				return r_position;
			}
		}

		/// <summary>
		/// Boolean IsPinned
		/// </summary>
		protected RProperty r_IsPinned;
		public virtual RProperty RIsPinned
		{
			get
			{
				if(r_IsPinned == null)
				{
					r_IsPinned = new(this, "IsPinned", -1);
					r_IsPinned.SetBelong(this.instance);
				}
				return r_IsPinned;
			}
		}

		/// <summary>
		/// Int32 LocalIndex
		/// </summary>
		protected RProperty r_LocalIndex;
		public virtual RProperty RLocalIndex
		{
			get
			{
				if(r_LocalIndex == null)
				{
					r_LocalIndex = new(this, "LocalIndex", -1);
					r_LocalIndex.SetBelong(this.instance);
				}
				return r_LocalIndex;
			}
		}

		/// <summary>
		/// System.Type LocalType
		/// </summary>
		protected RSystem.RType r_LocalType;
		public virtual RSystem.RType RLocalType
		{
			get
			{
				if(r_LocalType == null)
				{
					r_LocalType = new(this, "LocalType", -1);
					r_LocalType.SetBelong(this.instance);
				}
				return r_LocalType;
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


        public RLocalVariableInfo() : base("System.Reflection.LocalVariableInfo")
        {
        }

        public RLocalVariableInfo(System.Object instance) : base("System.Reflection.LocalVariableInfo")
		{
            SetInstance(instance);
		}

        public RLocalVariableInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLocalVariableInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
