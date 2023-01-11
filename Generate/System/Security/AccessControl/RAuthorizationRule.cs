using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.AuthorizationRule
	/// </summary>
    public partial class RAuthorizationRule : RMember //
    {

		/// <summary>
		/// System.Security.Principal.IdentityReference identity
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RIdentityReference r_identity;
		public virtual RSystem.RSecurity.RPrincipal.RIdentityReference Ridentity
		{
			get
			{
				if(r_identity == null)
				{
					r_identity = new(this, "identity");
					r_identity.SetBelong(this.instance);
				}
				return r_identity;
			}
		}

		/// <summary>
		/// System.Int32 accessMask
		/// </summary>
		protected RSystem.RInt32 r_accessMask;
		public virtual RSystem.RInt32 RaccessMask
		{
			get
			{
				if(r_accessMask == null)
				{
					r_accessMask = new(this, "accessMask");
					r_accessMask.SetBelong(this.instance);
				}
				return r_accessMask;
			}
		}

		/// <summary>
		/// System.Boolean isInherited
		/// </summary>
		protected RSystem.RBoolean r_isInherited;
		public virtual RSystem.RBoolean RisInherited
		{
			get
			{
				if(r_isInherited == null)
				{
					r_isInherited = new(this, "isInherited");
					r_isInherited.SetBelong(this.instance);
				}
				return r_isInherited;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.InheritanceFlags inheritanceFlags
		/// </summary>
		protected RField r_inheritanceFlags;
		public virtual RField RinheritanceFlags
		{
			get
			{
				if(r_inheritanceFlags == null)
				{
					r_inheritanceFlags = new(this, "inheritanceFlags");
					r_inheritanceFlags.SetBelong(this.instance);
				}
				return r_inheritanceFlags;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.PropagationFlags propagationFlags
		/// </summary>
		protected RField r_propagationFlags;
		public virtual RField RpropagationFlags
		{
			get
			{
				if(r_propagationFlags == null)
				{
					r_propagationFlags = new(this, "propagationFlags");
					r_propagationFlags.SetBelong(this.instance);
				}
				return r_propagationFlags;
			}
		}

		/// <summary>
		/// System.Security.Principal.IdentityReference IdentityReference
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RIdentityReference r_IdentityReference;
		public virtual RSystem.RSecurity.RPrincipal.RIdentityReference RIdentityReference
		{
			get
			{
				if(r_IdentityReference == null)
				{
					r_IdentityReference = new(this, "IdentityReference", -1);
					r_IdentityReference.SetBelong(this.instance);
				}
				return r_IdentityReference;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.InheritanceFlags InheritanceFlags
		/// </summary>
		protected RProperty r_InheritanceFlags;
		public virtual RProperty RInheritanceFlags
		{
			get
			{
				if(r_InheritanceFlags == null)
				{
					r_InheritanceFlags = new(this, "InheritanceFlags", -1);
					r_InheritanceFlags.SetBelong(this.instance);
				}
				return r_InheritanceFlags;
			}
		}

		/// <summary>
		/// Boolean IsInherited
		/// </summary>
		protected RSystem.RBoolean r_IsInherited;
		public virtual RSystem.RBoolean RIsInherited
		{
			get
			{
				if(r_IsInherited == null)
				{
					r_IsInherited = new(this, "IsInherited", -1);
					r_IsInherited.SetBelong(this.instance);
				}
				return r_IsInherited;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.PropagationFlags PropagationFlags
		/// </summary>
		protected RProperty r_PropagationFlags;
		public virtual RProperty RPropagationFlags
		{
			get
			{
				if(r_PropagationFlags == null)
				{
					r_PropagationFlags = new(this, "PropagationFlags", -1);
					r_PropagationFlags.SetBelong(this.instance);
				}
				return r_PropagationFlags;
			}
		}

		/// <summary>
		/// Int32 AccessMask
		/// </summary>
		protected RSystem.RInt32 r_AccessMask;
		public virtual RSystem.RInt32 RAccessMask
		{
			get
			{
				if(r_AccessMask == null)
				{
					r_AccessMask = new(this, "AccessMask", -1);
					r_AccessMask.SetBelong(this.instance);
				}
				return r_AccessMask;
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


        public RAuthorizationRule() : base("System.Security.AccessControl.AuthorizationRule")
        {
        }

        public RAuthorizationRule(System.Object instance) : base("System.Security.AccessControl.AuthorizationRule")
		{
            SetInstance(instance);
		}

        public RAuthorizationRule(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAuthorizationRule(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
