using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
	/// System.Security.Policy.CodeGroup
	/// </summary>
    public partial class RCodeGroup : RMember //
    {

		/// <summary>
		/// System.Security.Policy.PolicyStatement m_policy
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RPolicyStatement r_m_policy;
		public virtual RSystem.RSecurity.RPolicy.RPolicyStatement Rm_policy
		{
			get
			{
				if(r_m_policy == null)
				{
					r_m_policy = new(this, "m_policy");
					r_m_policy.SetBelong(this.instance);
				}
				return r_m_policy;
			}
		}

		/// <summary>
		/// System.Security.Policy.IMembershipCondition m_membershipCondition
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RIMembershipCondition r_m_membershipCondition;
		public virtual RSystem.RSecurity.RPolicy.RIMembershipCondition Rm_membershipCondition
		{
			get
			{
				if(r_m_membershipCondition == null)
				{
					r_m_membershipCondition = new(this, "m_membershipCondition");
					r_m_membershipCondition.SetBelong(this.instance);
				}
				return r_m_membershipCondition;
			}
		}

		/// <summary>
		/// System.String m_description
		/// </summary>
		protected RField r_m_description;
		public virtual RField Rm_description
		{
			get
			{
				if(r_m_description == null)
				{
					r_m_description = new(this, "m_description");
					r_m_description.SetBelong(this.instance);
				}
				return r_m_description;
			}
		}

		/// <summary>
		/// System.String m_name
		/// </summary>
		protected RField r_m_name;
		public virtual RField Rm_name
		{
			get
			{
				if(r_m_name == null)
				{
					r_m_name = new(this, "m_name");
					r_m_name.SetBelong(this.instance);
				}
				return r_m_name;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList m_children
		/// </summary>
		protected RSystem.RCollections.RArrayList r_m_children;
		public virtual RSystem.RCollections.RArrayList Rm_children
		{
			get
			{
				if(r_m_children == null)
				{
					r_m_children = new(this, "m_children");
					r_m_children.SetBelong(this.instance);
				}
				return r_m_children;
			}
		}

		/// <summary>
		/// System.String MergeLogic
		/// </summary>
		protected RProperty r_MergeLogic;
		public virtual RProperty RMergeLogic
		{
			get
			{
				if(r_MergeLogic == null)
				{
					r_MergeLogic = new(this, "MergeLogic", -1);
					r_MergeLogic.SetBelong(this.instance);
				}
				return r_MergeLogic;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatement PolicyStatement
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RPolicyStatement r_PolicyStatement;
		public virtual RSystem.RSecurity.RPolicy.RPolicyStatement RPolicyStatement
		{
			get
			{
				if(r_PolicyStatement == null)
				{
					r_PolicyStatement = new(this, "PolicyStatement", -1);
					r_PolicyStatement.SetBelong(this.instance);
				}
				return r_PolicyStatement;
			}
		}

		/// <summary>
		/// System.String Description
		/// </summary>
		protected RProperty r_Description;
		public virtual RProperty RDescription
		{
			get
			{
				if(r_Description == null)
				{
					r_Description = new(this, "Description", -1);
					r_Description.SetBelong(this.instance);
				}
				return r_Description;
			}
		}

		/// <summary>
		/// System.Security.Policy.IMembershipCondition MembershipCondition
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RIMembershipCondition r_MembershipCondition;
		public virtual RSystem.RSecurity.RPolicy.RIMembershipCondition RMembershipCondition
		{
			get
			{
				if(r_MembershipCondition == null)
				{
					r_MembershipCondition = new(this, "MembershipCondition", -1);
					r_MembershipCondition.SetBelong(this.instance);
				}
				return r_MembershipCondition;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// System.Collections.IList Children
		/// </summary>
		protected RSystem.RCollections.RIList r_Children;
		public virtual RSystem.RCollections.RIList RChildren
		{
			get
			{
				if(r_Children == null)
				{
					r_Children = new(this, "Children", -1);
					r_Children.SetBelong(this.instance);
				}
				return r_Children;
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
		/// System.String PermissionSetName
		/// </summary>
		protected RProperty r_PermissionSetName;
		public virtual RProperty RPermissionSetName
		{
			get
			{
				if(r_PermissionSetName == null)
				{
					r_PermissionSetName = new(this, "PermissionSetName", -1);
					r_PermissionSetName.SetBelong(this.instance);
				}
				return r_PermissionSetName;
			}
		}

		/// <summary>
		/// System.Security.Policy.CodeGroup Copy()
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
		/// System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_Resolve_Evidence;
		public virtual RMethod RResolve_Evidence
		{
			get
			{
				if(r_Resolve_Evidence == null)
				{
					r_Resolve_Evidence = new(this, "Resolve", 0, typeof(System.Security.Policy.Evidence));
					r_Resolve_Evidence.SetBelong(this.instance);
				}
				return r_Resolve_Evidence;
			}
		}

		/// <summary>
		/// System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_ResolveMatchingCodeGroups_Evidence;
		public virtual RMethod RResolveMatchingCodeGroups_Evidence
		{
			get
			{
				if(r_ResolveMatchingCodeGroups_Evidence == null)
				{
					r_ResolveMatchingCodeGroups_Evidence = new(this, "ResolveMatchingCodeGroups", 0, typeof(System.Security.Policy.Evidence));
					r_ResolveMatchingCodeGroups_Evidence.SetBelong(this.instance);
				}
				return r_ResolveMatchingCodeGroups_Evidence;
			}
		}

		/// <summary>
		/// Void AddChild(System.Security.Policy.CodeGroup)
		/// </summary>
		protected RMethod r_AddChild_CodeGroup;
		public virtual RMethod RAddChild_CodeGroup
		{
			get
			{
				if(r_AddChild_CodeGroup == null)
				{
					r_AddChild_CodeGroup = new(this, "AddChild", 0, typeof(System.Security.Policy.CodeGroup));
					r_AddChild_CodeGroup.SetBelong(this.instance);
				}
				return r_AddChild_CodeGroup;
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
		/// Boolean Equals(System.Security.Policy.CodeGroup, Boolean)
		/// </summary>
		protected RMethod r_Equals_CodeGroup_Boolean;
		public virtual RMethod REquals_CodeGroup_Boolean
		{
			get
			{
				if(r_Equals_CodeGroup_Boolean == null)
				{
					r_Equals_CodeGroup_Boolean = new(this, "Equals", 0, typeof(System.Security.Policy.CodeGroup), typeof(System.Boolean));
					r_Equals_CodeGroup_Boolean.SetBelong(this.instance);
				}
				return r_Equals_CodeGroup_Boolean;
			}
		}

		/// <summary>
		/// Void RemoveChild(System.Security.Policy.CodeGroup)
		/// </summary>
		protected RMethod r_RemoveChild_CodeGroup;
		public virtual RMethod RRemoveChild_CodeGroup
		{
			get
			{
				if(r_RemoveChild_CodeGroup == null)
				{
					r_RemoveChild_CodeGroup = new(this, "RemoveChild", 0, typeof(System.Security.Policy.CodeGroup));
					r_RemoveChild_CodeGroup.SetBelong(this.instance);
				}
				return r_RemoveChild_CodeGroup;
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
		/// Void ParseXml(System.Security.SecurityElement, System.Security.Policy.PolicyLevel)
		/// </summary>
		protected RMethod r_ParseXml_SecurityElement_PolicyLevel;
		public virtual RMethod RParseXml_SecurityElement_PolicyLevel
		{
			get
			{
				if(r_ParseXml_SecurityElement_PolicyLevel == null)
				{
					r_ParseXml_SecurityElement_PolicyLevel = new(this, "ParseXml", 0, typeof(System.Security.SecurityElement), typeof(System.Security.Policy.PolicyLevel));
					r_ParseXml_SecurityElement_PolicyLevel.SetBelong(this.instance);
				}
				return r_ParseXml_SecurityElement_PolicyLevel;
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
		/// Void CreateXml(System.Security.SecurityElement, System.Security.Policy.PolicyLevel)
		/// </summary>
		protected RMethod r_CreateXml_SecurityElement_PolicyLevel;
		public virtual RMethod RCreateXml_SecurityElement_PolicyLevel
		{
			get
			{
				if(r_CreateXml_SecurityElement_PolicyLevel == null)
				{
					r_CreateXml_SecurityElement_PolicyLevel = new(this, "CreateXml", 0, typeof(System.Security.SecurityElement), typeof(System.Security.Policy.PolicyLevel));
					r_CreateXml_SecurityElement_PolicyLevel.SetBelong(this.instance);
				}
				return r_CreateXml_SecurityElement_PolicyLevel;
			}
		}

		/// <summary>
		/// System.Security.Policy.CodeGroup CreateFromXml(System.Security.SecurityElement, System.Security.Policy.PolicyLevel)
		/// </summary>
		protected static RMethod r_CreateFromXml_SecurityElement_PolicyLevel;
		public static RMethod RCreateFromXml_SecurityElement_PolicyLevel
		{
			get
			{
				if(r_CreateFromXml_SecurityElement_PolicyLevel == null)
				{
					r_CreateFromXml_SecurityElement_PolicyLevel = new(typeof(System.Security.Policy.CodeGroup), "CreateFromXml", 0, typeof(System.Security.SecurityElement), typeof(System.Security.Policy.PolicyLevel));
					r_CreateFromXml_SecurityElement_PolicyLevel.SetBelong(null);
				}
				return r_CreateFromXml_SecurityElement_PolicyLevel;
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


        public RCodeGroup() : base("System.Security.Policy.CodeGroup")
        {
        }

        public RCodeGroup(System.Object instance) : base("System.Security.Policy.CodeGroup")
		{
            SetInstance(instance);
		}

        public RCodeGroup(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCodeGroup(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Security.Policy.CodeGroup Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.CodeGroup)___result;
        }


        public virtual System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RResolve_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.PolicyStatement)___result;
        }


        public virtual System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RResolveMatchingCodeGroups_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.CodeGroup)___result;
        }


        public virtual void AddChild(System.Security.Policy.CodeGroup @group)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@group};
            var ___result = RAddChild_CodeGroup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Security.Policy.CodeGroup @cg, System.Boolean @compareChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cg, @compareChildren};
            var ___result = REquals_CodeGroup_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveChild(System.Security.Policy.CodeGroup @group)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@group};
            var ___result = RRemoveChild_CodeGroup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void FromXml(System.Security.SecurityElement @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RFromXml_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FromXml(System.Security.SecurityElement @e, System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @level};
            var ___result = RFromXml_SecurityElement_PolicyLevel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ParseXml(System.Security.SecurityElement @e, System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @level};
            var ___result = RParseXml_SecurityElement_PolicyLevel.Invoke(___genericsType, ___parameters);

            
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


        public virtual void CreateXml(System.Security.SecurityElement @element, System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @level};
            var ___result = RCreateXml_SecurityElement_PolicyLevel.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Security.Policy.CodeGroup CreateFromXml(System.Security.SecurityElement @se, System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@se, @level};
            var ___result = RCreateFromXml_SecurityElement_PolicyLevel.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.CodeGroup)___result;
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
