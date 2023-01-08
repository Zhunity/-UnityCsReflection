using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
	/// System.Security.Policy.PolicyStatement
	/// </summary>
    public partial class RPolicyStatement : RMember //
    {

		/// <summary>
		/// System.Security.PermissionSet perms
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r_perms;
		public virtual RSystem.RSecurity.RPermissionSet Rperms
		{
			get
			{
				if(r_perms == null)
				{
					r_perms = new(this, "perms");
					r_perms.SetBelong(this.instance);
				}
				return r_perms;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatementAttribute attrs
		/// </summary>
		protected RField r_attrs;
		public virtual RField Rattrs
		{
			get
			{
				if(r_attrs == null)
				{
					r_attrs = new(this, "attrs");
					r_attrs.SetBelong(this.instance);
				}
				return r_attrs;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet PermissionSet
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r_PermissionSet;
		public virtual RSystem.RSecurity.RPermissionSet RPermissionSet
		{
			get
			{
				if(r_PermissionSet == null)
				{
					r_PermissionSet = new(this, "PermissionSet", -1);
					r_PermissionSet.SetBelong(this.instance);
				}
				return r_PermissionSet;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatementAttribute Attributes
		/// </summary>
		protected RProperty r_Attributes;
		public virtual RProperty RAttributes
		{
			get
			{
				if(r_Attributes == null)
				{
					r_Attributes = new(this, "Attributes", -1);
					r_Attributes.SetBelong(this.instance);
				}
				return r_Attributes;
			}
		}

		/// <summary>
		/// System.String AttributeString
		/// </summary>
		protected RProperty r_AttributeString;
		public virtual RProperty RAttributeString
		{
			get
			{
				if(r_AttributeString == null)
				{
					r_AttributeString = new(this, "AttributeString", -1);
					r_AttributeString.SetBelong(this.instance);
				}
				return r_AttributeString;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatement Copy()
		/// </summary>
		protected RMethod r_Copy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_Copy == null)
				{
					r_Copy = new(this, "Copy", 0);
					r_Copy.SetBelong(this.instance);
				}
				return r_Copy;
			}
		}

		/// <summary>
		/// Void FromXml(System.Security.SecurityElement)
		/// </summary>
		protected RMethod r_FromXml_SecurityElement;
		public virtual RMethod RFromXml_SecurityElement
		{
			get
			{
				if(r_FromXml_SecurityElement == null)
				{
					r_FromXml_SecurityElement = new(this, "FromXml", 0, typeof(System.Security.SecurityElement));
					r_FromXml_SecurityElement.SetBelong(this.instance);
				}
				return r_FromXml_SecurityElement;
			}
		}

		/// <summary>
		/// Void FromXml(System.Security.SecurityElement, System.Security.Policy.PolicyLevel)
		/// </summary>
		protected RMethod r_FromXml_SecurityElement_PolicyLevel;
		public virtual RMethod RFromXml_SecurityElement_PolicyLevel
		{
			get
			{
				if(r_FromXml_SecurityElement_PolicyLevel == null)
				{
					r_FromXml_SecurityElement_PolicyLevel = new(this, "FromXml", 0, typeof(System.Security.SecurityElement), typeof(System.Security.Policy.PolicyLevel));
					r_FromXml_SecurityElement_PolicyLevel.SetBelong(this.instance);
				}
				return r_FromXml_SecurityElement_PolicyLevel;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement ToXml()
		/// </summary>
		protected RMethod r_ToXml;
		public virtual RMethod RToXml
		{
			get
			{
				if(r_ToXml == null)
				{
					r_ToXml = new(this, "ToXml", 0);
					r_ToXml.SetBelong(this.instance);
				}
				return r_ToXml;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel)
		/// </summary>
		protected RMethod r_ToXml_PolicyLevel;
		public virtual RMethod RToXml_PolicyLevel
		{
			get
			{
				if(r_ToXml_PolicyLevel == null)
				{
					r_ToXml_PolicyLevel = new(this, "ToXml", 0, typeof(System.Security.Policy.PolicyLevel));
					r_ToXml_PolicyLevel.SetBelong(this.instance);
				}
				return r_ToXml_PolicyLevel;
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
		/// System.Security.Policy.PolicyStatement Empty()
		/// </summary>
		protected static RMethod r_Empty;
		public static RMethod REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new(typeof(System.Security.Policy.PolicyStatement), "Empty", 0);
					r_Empty.SetBelong(null);
				}
				return r_Empty;
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


        public RPolicyStatement() : base("System.Security.Policy.PolicyStatement")
        {
        }

        public RPolicyStatement(System.Object instance) : base("System.Security.Policy.PolicyStatement")
		{
            SetInstance(instance);
		}

        public RPolicyStatement(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPolicyStatement(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Security.Policy.PolicyStatement Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.PolicyStatement)___result;
        }


        public virtual void FromXml(System.Security.SecurityElement @et)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@et};
            var ___result = RFromXml_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FromXml(System.Security.SecurityElement @et, System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@et, @level};
            var ___result = RFromXml_SecurityElement_PolicyLevel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.SecurityElement ToXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToXml.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RToXml_PolicyLevel.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
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


        public static System.Security.Policy.PolicyStatement Empty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REmpty.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.PolicyStatement)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
