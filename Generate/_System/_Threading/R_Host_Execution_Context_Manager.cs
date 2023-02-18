
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.HostExecutionContextManager
	/// </summary>
    public partial class RHostExecutionContextManager : RMember //
    {

		/// <summary>
		/// System.Threading.HostExecutionContext Capture()
		/// </summary>
		protected RMethod r_MCapture;
		public virtual RMethod RMCapture
		{
			get
			{
				if(r_MCapture == null)
				{
					r_MCapture = new(this, "Capture", 0);
				}
				return r_MCapture;
			}
		}

		/// <summary>
		/// Void Revert(System.Object)
		/// </summary>
		protected RMethod r_MRevert_Object;
		public virtual RMethod RMRevert_Object
		{
			get
			{
				if(r_MRevert_Object == null)
				{
					r_MRevert_Object = new(this, "Revert", 0, typeof(System.Object));
				}
				return r_MRevert_Object;
			}
		}

		/// <summary>
		/// System.Object SetHostExecutionContext(System.Threading.HostExecutionContext)
		/// </summary>
		protected RMethod r_MSetHostExecutionContext_HostExecutionContext;
		public virtual RMethod RMSetHostExecutionContext_HostExecutionContext
		{
			get
			{
				if(r_MSetHostExecutionContext_HostExecutionContext == null)
				{
					r_MSetHostExecutionContext_HostExecutionContext = new(this, "SetHostExecutionContext", 0, typeof(System.Threading.HostExecutionContext));
				}
				return r_MSetHostExecutionContext_HostExecutionContext;
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


        public RHostExecutionContextManager() : base("System.Threading.HostExecutionContextManager")
        {
        }

        public RHostExecutionContextManager(System.Object instance) : base("System.Threading.HostExecutionContextManager")
		{
            SetInstance(instance);
		}

        public RHostExecutionContextManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHostExecutionContextManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Threading.HostExecutionContext Capture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCapture.Invoke(___genericsType, ___parameters);

            return (System.Threading.HostExecutionContext)___result;
        }


        public virtual void Revert(System.Object @previousState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previousState};
            var ___result = RMRevert_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object SetHostExecutionContext(System.Threading.HostExecutionContext @hostExecutionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hostExecutionContext};
            var ___result = RMSetHostExecutionContext_HostExecutionContext.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
