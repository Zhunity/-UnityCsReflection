using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.PropertyToken
	/// </summary>
    public partial class RPropertyToken : RMember //
    {

		/// <summary>
		/// System.Int32 tokValue
		/// </summary>
		protected RSystem.RInt32 r_tokValue;
		public virtual RSystem.RInt32 RtokValue
		{
			get
			{
				if(r_tokValue == null)
				{
					r_tokValue = new(this, "tokValue");
					r_tokValue.SetBelong(this.instance);
				}
				return r_tokValue;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.PropertyToken Empty
		/// </summary>
		protected static RSystem.RReflection.REmit.RPropertyToken r_Empty;
		public static RSystem.RReflection.REmit.RPropertyToken REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new(typeof(System.Reflection.Emit.PropertyToken), "Empty");
					r_Empty.SetBelong(null);
				}
				return r_Empty;
			}
		}

		/// <summary>
		/// Int32 Token
		/// </summary>
		protected RSystem.RInt32 r_Token;
		public virtual RSystem.RInt32 RToken
		{
			get
			{
				if(r_Token == null)
				{
					r_Token = new(this, "Token", -1);
					r_Token.SetBelong(this.instance);
				}
				return r_Token;
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
		/// Boolean Equals(System.Reflection.Emit.PropertyToken)
		/// </summary>
		protected RMethod r_Equals_PropertyToken;
		public virtual RMethod REquals_PropertyToken
		{
			get
			{
				if(r_Equals_PropertyToken == null)
				{
					r_Equals_PropertyToken = new(this, "Equals", 0, typeof(System.Reflection.Emit.PropertyToken));
					r_Equals_PropertyToken.SetBelong(this.instance);
				}
				return r_Equals_PropertyToken;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Reflection.Emit.PropertyToken, System.Reflection.Emit.PropertyToken)
		/// </summary>
		protected static RMethod r_op_Equality_PropertyToken_PropertyToken;
		public static RMethod Rop_Equality_PropertyToken_PropertyToken
		{
			get
			{
				if(r_op_Equality_PropertyToken_PropertyToken == null)
				{
					r_op_Equality_PropertyToken_PropertyToken = new(typeof(System.Reflection.Emit.PropertyToken), "op_Equality", 0, typeof(System.Reflection.Emit.PropertyToken), typeof(System.Reflection.Emit.PropertyToken));
					r_op_Equality_PropertyToken_PropertyToken.SetBelong(null);
				}
				return r_op_Equality_PropertyToken_PropertyToken;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Emit.PropertyToken, System.Reflection.Emit.PropertyToken)
		/// </summary>
		protected static RMethod r_op_Inequality_PropertyToken_PropertyToken;
		public static RMethod Rop_Inequality_PropertyToken_PropertyToken
		{
			get
			{
				if(r_op_Inequality_PropertyToken_PropertyToken == null)
				{
					r_op_Inequality_PropertyToken_PropertyToken = new(typeof(System.Reflection.Emit.PropertyToken), "op_Inequality", 0, typeof(System.Reflection.Emit.PropertyToken), typeof(System.Reflection.Emit.PropertyToken));
					r_op_Inequality_PropertyToken_PropertyToken.SetBelong(null);
				}
				return r_op_Inequality_PropertyToken_PropertyToken;
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


        public RPropertyToken() : base("System.Reflection.Emit.PropertyToken")
        {
        }

        public RPropertyToken(System.Object instance) : base("System.Reflection.Emit.PropertyToken")
		{
            SetInstance(instance);
		}

        public RPropertyToken(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPropertyToken(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Reflection.Emit.PropertyToken @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_PropertyToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Reflection.Emit.PropertyToken @a, System.Reflection.Emit.PropertyToken @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_PropertyToken_PropertyToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.Emit.PropertyToken @a, System.Reflection.Emit.PropertyToken @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_PropertyToken_PropertyToken.Invoke(___genericsType, ___parameters);

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
