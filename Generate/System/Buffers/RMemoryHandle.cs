using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RBuffers
{
	/// <summary>
	/// System.Buffers.MemoryHandle
	/// </summary>
    public partial class RMemoryHandle : RMember //
    {

		/// <summary>
		/// System.Void* _pointer
		/// </summary>
		protected RFieldPointer<RField> r_F_pointer;
		public virtual RFieldPointer<RField> RF_pointer
		{
			get
			{
				if(r_F_pointer == null)
				{
					r_F_pointer = new(this, "_pointer");
					r_F_pointer.SetBelong(this.instance);
				}
				return r_F_pointer;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.GCHandle _handle
		/// </summary>
		protected RSystem.RRuntime.RInteropServices.RGCHandle r_F_handle;
		public virtual RSystem.RRuntime.RInteropServices.RGCHandle RF_handle
		{
			get
			{
				if(r_F_handle == null)
				{
					r_F_handle = new(this, "_handle");
					r_F_handle.SetBelong(this.instance);
				}
				return r_F_handle;
			}
		}

		/// <summary>
		/// System.Buffers.IPinnable _pinnable
		/// </summary>
		protected RSystem.RBuffers.RIPinnable r_F_pinnable;
		public virtual RSystem.RBuffers.RIPinnable RF_pinnable
		{
			get
			{
				if(r_F_pinnable == null)
				{
					r_F_pinnable = new(this, "_pinnable");
					r_F_pinnable.SetBelong(this.instance);
				}
				return r_F_pinnable;
			}
		}

		/// <summary>
		/// Void* Pointer
		/// </summary>
		protected RPropertyPointer<RProperty> r_PPointer;
		public virtual RPropertyPointer<RProperty> RPPointer
		{
			get
			{
				if(r_PPointer == null)
				{
					r_PPointer = new(this, "Pointer", -1);
					r_PPointer.SetBelong(this.instance);
				}
				return r_PPointer;
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


        public RMemoryHandle() : base("System.Buffers.MemoryHandle")
        {
        }

        public RMemoryHandle(System.Object instance) : base("System.Buffers.MemoryHandle")
		{
            SetInstance(instance);
		}

        public RMemoryHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMemoryHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
