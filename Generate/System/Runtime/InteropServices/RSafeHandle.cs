using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices
{
	/// <summary>
	/// System.Runtime.InteropServices.SafeHandle
	/// </summary>
    public partial class RSafeHandle : RMember //
    {

		/// <summary>
		/// System.IntPtr handle
		/// </summary>
		protected RSystem.RIntPtr r_Fhandle;
		public virtual RSystem.RIntPtr RFhandle
		{
			get
			{
				if(r_Fhandle == null)
				{
					r_Fhandle = new(this, "handle");
					r_Fhandle.SetBelong(this.instance);
				}
				return r_Fhandle;
			}
		}

		/// <summary>
		/// System.Int32 _state
		/// </summary>
		protected RSystem.RInt32 r_F_state;
		public virtual RSystem.RInt32 RF_state
		{
			get
			{
				if(r_F_state == null)
				{
					r_F_state = new(this, "_state");
					r_F_state.SetBelong(this.instance);
				}
				return r_F_state;
			}
		}

		/// <summary>
		/// System.Boolean _ownsHandle
		/// </summary>
		protected RSystem.RBoolean r_F_ownsHandle;
		public virtual RSystem.RBoolean RF_ownsHandle
		{
			get
			{
				if(r_F_ownsHandle == null)
				{
					r_F_ownsHandle = new(this, "_ownsHandle");
					r_F_ownsHandle.SetBelong(this.instance);
				}
				return r_F_ownsHandle;
			}
		}

		/// <summary>
		/// System.Boolean _fullyInitialized
		/// </summary>
		protected RSystem.RBoolean r_F_fullyInitialized;
		public virtual RSystem.RBoolean RF_fullyInitialized
		{
			get
			{
				if(r_F_fullyInitialized == null)
				{
					r_F_fullyInitialized = new(this, "_fullyInitialized");
					r_F_fullyInitialized.SetBelong(this.instance);
				}
				return r_F_fullyInitialized;
			}
		}

		/// <summary>
		/// System.Int32 RefCount_Mask
		/// </summary>
		protected static RSystem.RInt32 r_FRefCount_Mask;
		public static RSystem.RInt32 RFRefCount_Mask
		{
			get
			{
				if(r_FRefCount_Mask == null)
				{
					r_FRefCount_Mask = new(typeof(System.Runtime.InteropServices.SafeHandle), "RefCount_Mask");
					r_FRefCount_Mask.SetBelong(null);
				}
				return r_FRefCount_Mask;
			}
		}

		/// <summary>
		/// System.Int32 RefCount_One
		/// </summary>
		protected static RSystem.RInt32 r_FRefCount_One;
		public static RSystem.RInt32 RFRefCount_One
		{
			get
			{
				if(r_FRefCount_One == null)
				{
					r_FRefCount_One = new(typeof(System.Runtime.InteropServices.SafeHandle), "RefCount_One");
					r_FRefCount_One.SetBelong(null);
				}
				return r_FRefCount_One;
			}
		}

		/// <summary>
		/// Boolean IsClosed
		/// </summary>
		protected RSystem.RBoolean r_PIsClosed;
		public virtual RSystem.RBoolean RPIsClosed
		{
			get
			{
				if(r_PIsClosed == null)
				{
					r_PIsClosed = new(this, "IsClosed", -1);
					r_PIsClosed.SetBelong(this.instance);
				}
				return r_PIsClosed;
			}
		}

		/// <summary>
		/// Boolean IsInvalid
		/// </summary>
		protected RSystem.RBoolean r_PIsInvalid;
		public virtual RSystem.RBoolean RPIsInvalid
		{
			get
			{
				if(r_PIsInvalid == null)
				{
					r_PIsInvalid = new(this, "IsInvalid", -1);
					r_PIsInvalid.SetBelong(this.instance);
				}
				return r_PIsInvalid;
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
					r_MFinalize.SetBelong(this.instance);
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// Void SetHandle(IntPtr)
		/// </summary>
		protected RMethod r_MSetHandle_IntPtr;
		public virtual RMethod RMSetHandle_IntPtr
		{
			get
			{
				if(r_MSetHandle_IntPtr == null)
				{
					r_MSetHandle_IntPtr = new(this, "SetHandle", 0, typeof(System.IntPtr));
					r_MSetHandle_IntPtr.SetBelong(this.instance);
				}
				return r_MSetHandle_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr DangerousGetHandle()
		/// </summary>
		protected RMethod r_MDangerousGetHandle;
		public virtual RMethod RMDangerousGetHandle
		{
			get
			{
				if(r_MDangerousGetHandle == null)
				{
					r_MDangerousGetHandle = new(this, "DangerousGetHandle", 0);
					r_MDangerousGetHandle.SetBelong(this.instance);
				}
				return r_MDangerousGetHandle;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_MClose;
		public virtual RMethod RMClose
		{
			get
			{
				if(r_MClose == null)
				{
					r_MClose = new(this, "Close", 0);
					r_MClose.SetBelong(this.instance);
				}
				return r_MClose;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_MDispose_Boolean.SetBelong(this.instance);
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// Boolean ReleaseHandle()
		/// </summary>
		protected RMethod r_MReleaseHandle;
		public virtual RMethod RMReleaseHandle
		{
			get
			{
				if(r_MReleaseHandle == null)
				{
					r_MReleaseHandle = new(this, "ReleaseHandle", 0);
					r_MReleaseHandle.SetBelong(this.instance);
				}
				return r_MReleaseHandle;
			}
		}

		/// <summary>
		/// Void SetHandleAsInvalid()
		/// </summary>
		protected RMethod r_MSetHandleAsInvalid;
		public virtual RMethod RMSetHandleAsInvalid
		{
			get
			{
				if(r_MSetHandleAsInvalid == null)
				{
					r_MSetHandleAsInvalid = new(this, "SetHandleAsInvalid", 0);
					r_MSetHandleAsInvalid.SetBelong(this.instance);
				}
				return r_MSetHandleAsInvalid;
			}
		}

		/// <summary>
		/// Void DangerousAddRef(Boolean ByRef)
		/// </summary>
		protected RMethod r_MDangerousAddRef_Ref_Boolean;
		public virtual RMethod RMDangerousAddRef_Ref_Boolean
		{
			get
			{
				if(r_MDangerousAddRef_Ref_Boolean == null)
				{
					r_MDangerousAddRef_Ref_Boolean = new(this, "DangerousAddRef", 0, typeof(System.Boolean).MakeByRefType());
					r_MDangerousAddRef_Ref_Boolean.SetBelong(this.instance);
				}
				return r_MDangerousAddRef_Ref_Boolean;
			}
		}

		/// <summary>
		/// Void DangerousRelease()
		/// </summary>
		protected RMethod r_MDangerousRelease;
		public virtual RMethod RMDangerousRelease
		{
			get
			{
				if(r_MDangerousRelease == null)
				{
					r_MDangerousRelease = new(this, "DangerousRelease", 0);
					r_MDangerousRelease.SetBelong(this.instance);
				}
				return r_MDangerousRelease;
			}
		}

		/// <summary>
		/// Void InternalDispose()
		/// </summary>
		protected RMethod r_MInternalDispose;
		public virtual RMethod RMInternalDispose
		{
			get
			{
				if(r_MInternalDispose == null)
				{
					r_MInternalDispose = new(this, "InternalDispose", 0);
					r_MInternalDispose.SetBelong(this.instance);
				}
				return r_MInternalDispose;
			}
		}

		/// <summary>
		/// Void InternalFinalize()
		/// </summary>
		protected RMethod r_MInternalFinalize;
		public virtual RMethod RMInternalFinalize
		{
			get
			{
				if(r_MInternalFinalize == null)
				{
					r_MInternalFinalize = new(this, "InternalFinalize", 0);
					r_MInternalFinalize.SetBelong(this.instance);
				}
				return r_MInternalFinalize;
			}
		}

		/// <summary>
		/// Void DangerousReleaseInternal(Boolean)
		/// </summary>
		protected RMethod r_MDangerousReleaseInternal_Boolean;
		public virtual RMethod RMDangerousReleaseInternal_Boolean
		{
			get
			{
				if(r_MDangerousReleaseInternal_Boolean == null)
				{
					r_MDangerousReleaseInternal_Boolean = new(this, "DangerousReleaseInternal", 0, typeof(System.Boolean));
					r_MDangerousReleaseInternal_Boolean.SetBelong(this.instance);
				}
				return r_MDangerousReleaseInternal_Boolean;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
			}
		}


        public RSafeHandle() : base("System.Runtime.InteropServices.SafeHandle")
        {
        }

        public RSafeHandle(System.Object instance) : base("System.Runtime.InteropServices.SafeHandle")
		{
            SetInstance(instance);
		}

        public RSafeHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSafeHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHandle(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMSetHandle_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr DangerousGetHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDangerousGetHandle.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ReleaseHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReleaseHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetHandleAsInvalid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetHandleAsInvalid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DangerousAddRef(ref System.Boolean @success)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@success};
            var ___result = RMDangerousAddRef_Ref_Boolean.Invoke(___genericsType, ___parameters);
			@success = (System.Boolean)___parameters[0];

            
        }


        public virtual void DangerousRelease()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDangerousRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalDispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalFinalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DangerousReleaseInternal(System.Boolean @dispose)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispose};
            var ___result = RMDangerousReleaseInternal_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
