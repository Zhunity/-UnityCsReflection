using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography
{
	/// <summary>
	/// System.Security.Cryptography.RSAParameters
	/// </summary>
    public partial class RRSAParameters : RMember //
    {

		/// <summary>
		/// System.Byte[] Exponent
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_Exponent;
		public virtual RFieldArray<RSystem.RByte> RExponent
		{
			get
			{
				if(r_Exponent == null)
				{
					r_Exponent = new(this, "Exponent");
					r_Exponent.SetBelong(this.instance);
				}
				return r_Exponent;
			}
		}

		/// <summary>
		/// System.Byte[] Modulus
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_Modulus;
		public virtual RFieldArray<RSystem.RByte> RModulus
		{
			get
			{
				if(r_Modulus == null)
				{
					r_Modulus = new(this, "Modulus");
					r_Modulus.SetBelong(this.instance);
				}
				return r_Modulus;
			}
		}

		/// <summary>
		/// System.Byte[] P
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_P;
		public virtual RFieldArray<RSystem.RByte> RP
		{
			get
			{
				if(r_P == null)
				{
					r_P = new(this, "P");
					r_P.SetBelong(this.instance);
				}
				return r_P;
			}
		}

		/// <summary>
		/// System.Byte[] Q
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_Q;
		public virtual RFieldArray<RSystem.RByte> RQ
		{
			get
			{
				if(r_Q == null)
				{
					r_Q = new(this, "Q");
					r_Q.SetBelong(this.instance);
				}
				return r_Q;
			}
		}

		/// <summary>
		/// System.Byte[] DP
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_DP;
		public virtual RFieldArray<RSystem.RByte> RDP
		{
			get
			{
				if(r_DP == null)
				{
					r_DP = new(this, "DP");
					r_DP.SetBelong(this.instance);
				}
				return r_DP;
			}
		}

		/// <summary>
		/// System.Byte[] DQ
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_DQ;
		public virtual RFieldArray<RSystem.RByte> RDQ
		{
			get
			{
				if(r_DQ == null)
				{
					r_DQ = new(this, "DQ");
					r_DQ.SetBelong(this.instance);
				}
				return r_DQ;
			}
		}

		/// <summary>
		/// System.Byte[] InverseQ
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_InverseQ;
		public virtual RFieldArray<RSystem.RByte> RInverseQ
		{
			get
			{
				if(r_InverseQ == null)
				{
					r_InverseQ = new(this, "InverseQ");
					r_InverseQ.SetBelong(this.instance);
				}
				return r_InverseQ;
			}
		}

		/// <summary>
		/// System.Byte[] D
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_D;
		public virtual RFieldArray<RSystem.RByte> RD
		{
			get
			{
				if(r_D == null)
				{
					r_D = new(this, "D");
					r_D.SetBelong(this.instance);
				}
				return r_D;
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


        public RRSAParameters() : base("System.Security.Cryptography.RSAParameters")
        {
        }

        public RRSAParameters(System.Object instance) : base("System.Security.Cryptography.RSAParameters")
		{
            SetInstance(instance);
		}

        public RRSAParameters(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRSAParameters(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
