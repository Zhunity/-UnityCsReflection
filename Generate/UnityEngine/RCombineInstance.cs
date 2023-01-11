using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.CombineInstance
	/// </summary>
    public partial class RCombineInstance : RMember //
    {

		/// <summary>
		/// System.Int32 m_MeshInstanceID
		/// </summary>
		protected RSystem.RInt32 r_m_MeshInstanceID;
		public virtual RSystem.RInt32 Rm_MeshInstanceID
		{
			get
			{
				if(r_m_MeshInstanceID == null)
				{
					r_m_MeshInstanceID = new(this, "m_MeshInstanceID");
					r_m_MeshInstanceID.SetBelong(this.instance);
				}
				return r_m_MeshInstanceID;
			}
		}

		/// <summary>
		/// System.Int32 m_SubMeshIndex
		/// </summary>
		protected RSystem.RInt32 r_m_SubMeshIndex;
		public virtual RSystem.RInt32 Rm_SubMeshIndex
		{
			get
			{
				if(r_m_SubMeshIndex == null)
				{
					r_m_SubMeshIndex = new(this, "m_SubMeshIndex");
					r_m_SubMeshIndex.SetBelong(this.instance);
				}
				return r_m_SubMeshIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_Transform
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_m_Transform;
		public virtual RUnityEngine.RMatrix4x4 Rm_Transform
		{
			get
			{
				if(r_m_Transform == null)
				{
					r_m_Transform = new(this, "m_Transform");
					r_m_Transform.SetBelong(this.instance);
				}
				return r_m_Transform;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 m_LightmapScaleOffset
		/// </summary>
		protected RUnityEngine.RVector4 r_m_LightmapScaleOffset;
		public virtual RUnityEngine.RVector4 Rm_LightmapScaleOffset
		{
			get
			{
				if(r_m_LightmapScaleOffset == null)
				{
					r_m_LightmapScaleOffset = new(this, "m_LightmapScaleOffset");
					r_m_LightmapScaleOffset.SetBelong(this.instance);
				}
				return r_m_LightmapScaleOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 m_RealtimeLightmapScaleOffset
		/// </summary>
		protected RUnityEngine.RVector4 r_m_RealtimeLightmapScaleOffset;
		public virtual RUnityEngine.RVector4 Rm_RealtimeLightmapScaleOffset
		{
			get
			{
				if(r_m_RealtimeLightmapScaleOffset == null)
				{
					r_m_RealtimeLightmapScaleOffset = new(this, "m_RealtimeLightmapScaleOffset");
					r_m_RealtimeLightmapScaleOffset.SetBelong(this.instance);
				}
				return r_m_RealtimeLightmapScaleOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Mesh mesh
		/// </summary>
		protected RUnityEngine.RMesh r_mesh;
		public virtual RUnityEngine.RMesh Rmesh
		{
			get
			{
				if(r_mesh == null)
				{
					r_mesh = new(this, "mesh", -1);
					r_mesh.SetBelong(this.instance);
				}
				return r_mesh;
			}
		}

		/// <summary>
		/// Int32 subMeshIndex
		/// </summary>
		protected RSystem.RInt32 r_subMeshIndex;
		public virtual RSystem.RInt32 RsubMeshIndex
		{
			get
			{
				if(r_subMeshIndex == null)
				{
					r_subMeshIndex = new(this, "subMeshIndex", -1);
					r_subMeshIndex.SetBelong(this.instance);
				}
				return r_subMeshIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 transform
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_transform;
		public virtual RUnityEngine.RMatrix4x4 Rtransform
		{
			get
			{
				if(r_transform == null)
				{
					r_transform = new(this, "transform", -1);
					r_transform.SetBelong(this.instance);
				}
				return r_transform;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 lightmapScaleOffset
		/// </summary>
		protected RUnityEngine.RVector4 r_lightmapScaleOffset;
		public virtual RUnityEngine.RVector4 RlightmapScaleOffset
		{
			get
			{
				if(r_lightmapScaleOffset == null)
				{
					r_lightmapScaleOffset = new(this, "lightmapScaleOffset", -1);
					r_lightmapScaleOffset.SetBelong(this.instance);
				}
				return r_lightmapScaleOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 realtimeLightmapScaleOffset
		/// </summary>
		protected RUnityEngine.RVector4 r_realtimeLightmapScaleOffset;
		public virtual RUnityEngine.RVector4 RrealtimeLightmapScaleOffset
		{
			get
			{
				if(r_realtimeLightmapScaleOffset == null)
				{
					r_realtimeLightmapScaleOffset = new(this, "realtimeLightmapScaleOffset", -1);
					r_realtimeLightmapScaleOffset.SetBelong(this.instance);
				}
				return r_realtimeLightmapScaleOffset;
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


        public RCombineInstance() : base("UnityEngine.CombineInstance")
        {
        }

        public RCombineInstance(System.Object instance) : base("UnityEngine.CombineInstance")
		{
            SetInstance(instance);
		}

        public RCombineInstance(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCombineInstance(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
