
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Security.AccessControl.ObjectAccessRule
	/// </summary>
    public partial class RObjectAccessRule : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.AccessControl.ObjectAccessRule);
            }
        }

        public RObjectAccessRule() : base("System.Security.AccessControl.ObjectAccessRule")
        {
        }

        public RObjectAccessRule(System.Object instance) : base("System.Security.AccessControl.ObjectAccessRule")
		{
            SetInstance(instance);
		}

        public RObjectAccessRule(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RObjectAccessRule(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Guid object_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid r_Fobject_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid RFobject_type
		{
			get
			{
				if(r_Fobject_type == null)
				{
					r_Fobject_type = new(this, "object_type");
				}
				return r_Fobject_type;
			}
		}

		/// <summary>
		/// System.Guid inherited_object_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid r_Finherited_object_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid RFinherited_object_type
		{
			get
			{
				if(r_Finherited_object_type == null)
				{
					r_Finherited_object_type = new(this, "inherited_object_type");
				}
				return r_Finherited_object_type;
			}
		}

		/// <summary>
		/// System.Guid InheritedObjectType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid r_PInheritedObjectType;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid RPInheritedObjectType
		{
			get
			{
				if(r_PInheritedObjectType == null)
				{
					r_PInheritedObjectType = new(this, "InheritedObjectType", -1);
				}
				return r_PInheritedObjectType;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ObjectAceFlags ObjectFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RObjectAceFlags r_PObjectFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RObjectAceFlags RPObjectFlags
		{
			get
			{
				if(r_PObjectFlags == null)
				{
					r_PObjectFlags = new(this, "ObjectFlags", -1);
				}
				return r_PObjectFlags;
			}
		}

		/// <summary>
		/// System.Guid ObjectType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid r_PObjectType;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid RPObjectType
		{
			get
			{
				if(r_PObjectType == null)
				{
					r_PObjectType = new(this, "ObjectType", -1);
				}
				return r_PObjectType;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AccessControlType AccessControlType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAccessControlType r_PAccessControlType;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAccessControlType RPAccessControlType
		{
			get
			{
				if(r_PAccessControlType == null)
				{
					r_PAccessControlType = new(this, "AccessControlType", -1);
				}
				return r_PAccessControlType;
			}
		}

		/// <summary>
		/// System.Security.Principal.IdentityReference IdentityReference
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIdentityReference r_PIdentityReference;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIdentityReference RPIdentityReference
		{
			get
			{
				if(r_PIdentityReference == null)
				{
					r_PIdentityReference = new(this, "IdentityReference", -1);
				}
				return r_PIdentityReference;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.InheritanceFlags InheritanceFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RInheritanceFlags r_PInheritanceFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RInheritanceFlags RPInheritanceFlags
		{
			get
			{
				if(r_PInheritanceFlags == null)
				{
					r_PInheritanceFlags = new(this, "InheritanceFlags", -1);
				}
				return r_PInheritanceFlags;
			}
		}

		/// <summary>
		/// Boolean IsInherited
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsInherited;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsInherited
		{
			get
			{
				if(r_PIsInherited == null)
				{
					r_PIsInherited = new(this, "IsInherited", -1);
				}
				return r_PIsInherited;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.PropagationFlags PropagationFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RPropagationFlags r_PPropagationFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RPropagationFlags RPPropagationFlags
		{
			get
			{
				if(r_PPropagationFlags == null)
				{
					r_PPropagationFlags = new(this, "PropagationFlags", -1);
				}
				return r_PPropagationFlags;
			}
		}

		/// <summary>
		/// Int32 AccessMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PAccessMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPAccessMask
		{
			get
			{
				if(r_PAccessMask == null)
				{
					r_PAccessMask = new(this, "AccessMask", -1);
				}
				return r_PAccessMask;
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
				}
				return r_MEquals_Object;
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
				}
				return r_MFinalize;
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
				}
				return r_MGetHashCode;
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
				}
				return r_MMemberwiseClone;
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
				}
				return r_MToString;
			}
		}


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
