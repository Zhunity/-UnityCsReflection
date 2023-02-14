
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering
{public partial class RRayTracingAccelerationStructure
{
	
	/// <summary>
	/// UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure+RASSettings
	/// </summary>
    public partial class RRASSettings : RMember //
    {

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure+ManagementMode managementMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingAccelerationStructure.RManagementMode r_FmanagementMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingAccelerationStructure.RManagementMode RFmanagementMode
		{
			get
			{
				if(r_FmanagementMode == null)
				{
					r_FmanagementMode = new(this, "managementMode");
					r_FmanagementMode.SetBelong(this.instance);
				}
				return r_FmanagementMode;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure+RayTracingModeMask rayTracingModeMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingAccelerationStructure.RRayTracingModeMask r_FrayTracingModeMask;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingAccelerationStructure.RRayTracingModeMask RFrayTracingModeMask
		{
			get
			{
				if(r_FrayTracingModeMask == null)
				{
					r_FrayTracingModeMask = new(this, "rayTracingModeMask");
					r_FrayTracingModeMask.SetBelong(this.instance);
				}
				return r_FrayTracingModeMask;
			}
		}

		/// <summary>
		/// System.Int32 layerMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FlayerMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlayerMask
		{
			get
			{
				if(r_FlayerMask == null)
				{
					r_FlayerMask = new(this, "layerMask");
					r_FlayerMask.SetBelong(this.instance);
				}
				return r_FlayerMask;
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


        public RRASSettings() : base("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure+RASSettings")
        {
        }

        public RRASSettings(System.Object instance) : base("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure+RASSettings")
		{
            SetInstance(instance);
		}

        public RRASSettings(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRASSettings(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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