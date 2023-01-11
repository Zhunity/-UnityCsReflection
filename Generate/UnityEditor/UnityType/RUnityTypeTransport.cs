using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{public partial class RUnityType
{
	
	/// <summary>
	/// UnityEditor.UnityType+UnityTypeTransport
	/// </summary>
    public partial class RUnityTypeTransport : RMember //
    {

		/// <summary>
		/// System.UInt32 runtimeTypeIndex
		/// </summary>
		protected RSystem.RUInt32 r_runtimeTypeIndex;
		public virtual RSystem.RUInt32 RruntimeTypeIndex
		{
			get
			{
				if(r_runtimeTypeIndex == null)
				{
					r_runtimeTypeIndex = new(this, "runtimeTypeIndex");
					r_runtimeTypeIndex.SetBelong(this.instance);
				}
				return r_runtimeTypeIndex;
			}
		}

		/// <summary>
		/// System.UInt32 descendantCount
		/// </summary>
		protected RSystem.RUInt32 r_descendantCount;
		public virtual RSystem.RUInt32 RdescendantCount
		{
			get
			{
				if(r_descendantCount == null)
				{
					r_descendantCount = new(this, "descendantCount");
					r_descendantCount.SetBelong(this.instance);
				}
				return r_descendantCount;
			}
		}

		/// <summary>
		/// System.UInt32 baseClassIndex
		/// </summary>
		protected RSystem.RUInt32 r_baseClassIndex;
		public virtual RSystem.RUInt32 RbaseClassIndex
		{
			get
			{
				if(r_baseClassIndex == null)
				{
					r_baseClassIndex = new(this, "baseClassIndex");
					r_baseClassIndex.SetBelong(this.instance);
				}
				return r_baseClassIndex;
			}
		}

		/// <summary>
		/// System.String className
		/// </summary>
		protected RSystem.RString r_className;
		public virtual RSystem.RString RclassName
		{
			get
			{
				if(r_className == null)
				{
					r_className = new(this, "className");
					r_className.SetBelong(this.instance);
				}
				return r_className;
			}
		}

		/// <summary>
		/// System.String classNamespace
		/// </summary>
		protected RSystem.RString r_classNamespace;
		public virtual RSystem.RString RclassNamespace
		{
			get
			{
				if(r_classNamespace == null)
				{
					r_classNamespace = new(this, "classNamespace");
					r_classNamespace.SetBelong(this.instance);
				}
				return r_classNamespace;
			}
		}

		/// <summary>
		/// System.String module
		/// </summary>
		protected RSystem.RString r_module;
		public virtual RSystem.RString Rmodule
		{
			get
			{
				if(r_module == null)
				{
					r_module = new(this, "module");
					r_module.SetBelong(this.instance);
				}
				return r_module;
			}
		}

		/// <summary>
		/// System.Int32 persistentTypeID
		/// </summary>
		protected RSystem.RInt32 r_persistentTypeID;
		public virtual RSystem.RInt32 RpersistentTypeID
		{
			get
			{
				if(r_persistentTypeID == null)
				{
					r_persistentTypeID = new(this, "persistentTypeID");
					r_persistentTypeID.SetBelong(this.instance);
				}
				return r_persistentTypeID;
			}
		}

		/// <summary>
		/// System.UInt32 flags
		/// </summary>
		protected RSystem.RUInt32 r_flags;
		public virtual RSystem.RUInt32 Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags");
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
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


        public RUnityTypeTransport() : base("UnityEditor.UnityType+UnityTypeTransport")
        {
        }

        public RUnityTypeTransport(System.Object instance) : base("UnityEditor.UnityType+UnityTypeTransport")
		{
            SetInstance(instance);
		}

        public RUnityTypeTransport(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnityTypeTransport(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}