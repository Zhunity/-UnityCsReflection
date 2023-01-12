using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RUIRenderDevice
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate
	/// </summary>
    public partial class RAllocToUpdate : RMember //
    {

		/// <summary>
		/// System.UInt32 id
		/// </summary>
		protected RSystem.RUInt32 r_Fid;
		public virtual RSystem.RUInt32 RFid
		{
			get
			{
				if(r_Fid == null)
				{
					r_Fid = new(this, "id");
					r_Fid.SetBelong(this.instance);
				}
				return r_Fid;
			}
		}

		/// <summary>
		/// System.UInt32 allocTime
		/// </summary>
		protected RSystem.RUInt32 r_FallocTime;
		public virtual RSystem.RUInt32 RFallocTime
		{
			get
			{
				if(r_FallocTime == null)
				{
					r_FallocTime = new(this, "allocTime");
					r_FallocTime.SetBelong(this.instance);
				}
				return r_FallocTime;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshHandle meshHandle
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RMeshHandle r_FmeshHandle;
		public virtual RUnityEngine.RUIElements.RUIR.RMeshHandle RFmeshHandle
		{
			get
			{
				if(r_FmeshHandle == null)
				{
					r_FmeshHandle = new(this, "meshHandle");
					r_FmeshHandle.SetBelong(this.instance);
				}
				return r_FmeshHandle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Alloc permAllocVerts
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RAlloc r_FpermAllocVerts;
		public virtual RUnityEngine.RUIElements.RUIR.RAlloc RFpermAllocVerts
		{
			get
			{
				if(r_FpermAllocVerts == null)
				{
					r_FpermAllocVerts = new(this, "permAllocVerts");
					r_FpermAllocVerts.SetBelong(this.instance);
				}
				return r_FpermAllocVerts;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Alloc permAllocIndices
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RAlloc r_FpermAllocIndices;
		public virtual RUnityEngine.RUIElements.RUIR.RAlloc RFpermAllocIndices
		{
			get
			{
				if(r_FpermAllocIndices == null)
				{
					r_FpermAllocIndices = new(this, "permAllocIndices");
					r_FpermAllocIndices.SetBelong(this.instance);
				}
				return r_FpermAllocIndices;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Page permPage
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RPage r_FpermPage;
		public virtual RUnityEngine.RUIElements.RUIR.RPage RFpermPage
		{
			get
			{
				if(r_FpermPage == null)
				{
					r_FpermPage = new(this, "permPage");
					r_FpermPage.SetBelong(this.instance);
				}
				return r_FpermPage;
			}
		}

		/// <summary>
		/// System.Boolean copyBackIndices
		/// </summary>
		protected RSystem.RBoolean r_FcopyBackIndices;
		public virtual RSystem.RBoolean RFcopyBackIndices
		{
			get
			{
				if(r_FcopyBackIndices == null)
				{
					r_FcopyBackIndices = new(this, "copyBackIndices");
					r_FcopyBackIndices.SetBelong(this.instance);
				}
				return r_FcopyBackIndices;
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


        public RAllocToUpdate() : base("UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate")
        {
        }

        public RAllocToUpdate(System.Object instance) : base("UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate")
		{
            SetInstance(instance);
		}

        public RAllocToUpdate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAllocToUpdate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
}