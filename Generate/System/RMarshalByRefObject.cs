using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.MarshalByRefObject
	/// </summary>
    public partial class RMarshalByRefObject : RMember //
    {

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity _identity
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RServerIdentity r__identity;
		public virtual RSystem.RRuntime.RRemoting.RServerIdentity R_identity
		{
			get
			{
				if(r__identity == null)
				{
					r__identity = new(this, "_identity");
					r__identity.SetBelong(this.instance);
				}
				return r__identity;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RServerIdentity r_ObjectIdentity;
		public virtual RSystem.RRuntime.RRemoting.RServerIdentity RObjectIdentity
		{
			get
			{
				if(r_ObjectIdentity == null)
				{
					r_ObjectIdentity = new(this, "ObjectIdentity", -1);
					r_ObjectIdentity.SetBelong(this.instance);
				}
				return r_ObjectIdentity;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_GetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_GetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_GetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_GetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.instance);
				}
				return r_GetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_CreateObjRef_Type;
		public virtual RMethod RCreateObjRef_Type
		{
			get
			{
				if(r_CreateObjRef_Type == null)
				{
					r_CreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_CreateObjRef_Type.SetBelong(this.instance);
				}
				return r_CreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_GetLifetimeService;
		public virtual RMethod RGetLifetimeService
		{
			get
			{
				if(r_GetLifetimeService == null)
				{
					r_GetLifetimeService = new(this, "GetLifetimeService", 0);
					r_GetLifetimeService.SetBelong(this.instance);
				}
				return r_GetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_InitializeLifetimeService;
		public virtual RMethod RInitializeLifetimeService
		{
			get
			{
				if(r_InitializeLifetimeService == null)
				{
					r_InitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_InitializeLifetimeService.SetBelong(this.instance);
				}
				return r_InitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_MemberwiseClone_Boolean;
		public virtual RMethod RMemberwiseClone_Boolean
		{
			get
			{
				if(r_MemberwiseClone_Boolean == null)
				{
					r_MemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_MemberwiseClone_Boolean.SetBelong(this.instance);
				}
				return r_MemberwiseClone_Boolean;
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


        public RMarshalByRefObject() : base("System.MarshalByRefObject")
        {
        }

        public RMarshalByRefObject(System.Object instance) : base("System.MarshalByRefObject")
		{
            SetInstance(instance);
		}

        public RMarshalByRefObject(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMarshalByRefObject(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual RSystem.RRuntime.RRemoting.RIdentity GetObjectIdentity(System.MarshalByRefObject @obj, out System.Boolean @IsClient)
        {
			@IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			@IsClient = (System.Boolean)___parameters[1];

            return new RSystem.RRuntime.RRemoting.RIdentity(___result);
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return (System.MarshalByRefObject)___result;
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
