using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.SubMeshDescriptor
	/// </summary>
    public partial class RSubMeshDescriptor : RMember //
    {

		/// <summary>
		/// UnityEngine.Bounds <bounds>k__BackingField
		/// </summary>
		protected RUnityEngine.RBounds r___0__bounds__1__k__BackingField;
		public virtual RUnityEngine.RBounds R__0__bounds__1__k__BackingField
		{
			get
			{
				if(r___0__bounds__1__k__BackingField == null)
				{
					r___0__bounds__1__k__BackingField = new(this, "<bounds>k__BackingField");
					r___0__bounds__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__bounds__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.MeshTopology <topology>k__BackingField
		/// </summary>
		protected RField r___0__topology__1__k__BackingField;
		public virtual RField R__0__topology__1__k__BackingField
		{
			get
			{
				if(r___0__topology__1__k__BackingField == null)
				{
					r___0__topology__1__k__BackingField = new(this, "<topology>k__BackingField");
					r___0__topology__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__topology__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <indexStart>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r___0__indexStart__1__k__BackingField;
		public virtual RSystem.RInt32 R__0__indexStart__1__k__BackingField
		{
			get
			{
				if(r___0__indexStart__1__k__BackingField == null)
				{
					r___0__indexStart__1__k__BackingField = new(this, "<indexStart>k__BackingField");
					r___0__indexStart__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__indexStart__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <indexCount>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r___0__indexCount__1__k__BackingField;
		public virtual RSystem.RInt32 R__0__indexCount__1__k__BackingField
		{
			get
			{
				if(r___0__indexCount__1__k__BackingField == null)
				{
					r___0__indexCount__1__k__BackingField = new(this, "<indexCount>k__BackingField");
					r___0__indexCount__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__indexCount__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <baseVertex>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r___0__baseVertex__1__k__BackingField;
		public virtual RSystem.RInt32 R__0__baseVertex__1__k__BackingField
		{
			get
			{
				if(r___0__baseVertex__1__k__BackingField == null)
				{
					r___0__baseVertex__1__k__BackingField = new(this, "<baseVertex>k__BackingField");
					r___0__baseVertex__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__baseVertex__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <firstVertex>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r___0__firstVertex__1__k__BackingField;
		public virtual RSystem.RInt32 R__0__firstVertex__1__k__BackingField
		{
			get
			{
				if(r___0__firstVertex__1__k__BackingField == null)
				{
					r___0__firstVertex__1__k__BackingField = new(this, "<firstVertex>k__BackingField");
					r___0__firstVertex__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__firstVertex__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <vertexCount>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r___0__vertexCount__1__k__BackingField;
		public virtual RSystem.RInt32 R__0__vertexCount__1__k__BackingField
		{
			get
			{
				if(r___0__vertexCount__1__k__BackingField == null)
				{
					r___0__vertexCount__1__k__BackingField = new(this, "<vertexCount>k__BackingField");
					r___0__vertexCount__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__vertexCount__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds bounds
		/// </summary>
		protected RUnityEngine.RBounds r_bounds;
		public virtual RUnityEngine.RBounds Rbounds
		{
			get
			{
				if(r_bounds == null)
				{
					r_bounds = new(this, "bounds", -1);
					r_bounds.SetBelong(this.instance);
				}
				return r_bounds;
			}
		}

		/// <summary>
		/// UnityEngine.MeshTopology topology
		/// </summary>
		protected RProperty r_topology;
		public virtual RProperty Rtopology
		{
			get
			{
				if(r_topology == null)
				{
					r_topology = new(this, "topology", -1);
					r_topology.SetBelong(this.instance);
				}
				return r_topology;
			}
		}

		/// <summary>
		/// Int32 indexStart
		/// </summary>
		protected RSystem.RInt32 r_indexStart;
		public virtual RSystem.RInt32 RindexStart
		{
			get
			{
				if(r_indexStart == null)
				{
					r_indexStart = new(this, "indexStart", -1);
					r_indexStart.SetBelong(this.instance);
				}
				return r_indexStart;
			}
		}

		/// <summary>
		/// Int32 indexCount
		/// </summary>
		protected RSystem.RInt32 r_indexCount;
		public virtual RSystem.RInt32 RindexCount
		{
			get
			{
				if(r_indexCount == null)
				{
					r_indexCount = new(this, "indexCount", -1);
					r_indexCount.SetBelong(this.instance);
				}
				return r_indexCount;
			}
		}

		/// <summary>
		/// Int32 baseVertex
		/// </summary>
		protected RSystem.RInt32 r_baseVertex;
		public virtual RSystem.RInt32 RbaseVertex
		{
			get
			{
				if(r_baseVertex == null)
				{
					r_baseVertex = new(this, "baseVertex", -1);
					r_baseVertex.SetBelong(this.instance);
				}
				return r_baseVertex;
			}
		}

		/// <summary>
		/// Int32 firstVertex
		/// </summary>
		protected RSystem.RInt32 r_firstVertex;
		public virtual RSystem.RInt32 RfirstVertex
		{
			get
			{
				if(r_firstVertex == null)
				{
					r_firstVertex = new(this, "firstVertex", -1);
					r_firstVertex.SetBelong(this.instance);
				}
				return r_firstVertex;
			}
		}

		/// <summary>
		/// Int32 vertexCount
		/// </summary>
		protected RSystem.RInt32 r_vertexCount;
		public virtual RSystem.RInt32 RvertexCount
		{
			get
			{
				if(r_vertexCount == null)
				{
					r_vertexCount = new(this, "vertexCount", -1);
					r_vertexCount.SetBelong(this.instance);
				}
				return r_vertexCount;
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


        public RSubMeshDescriptor() : base("UnityEngine.Rendering.SubMeshDescriptor")
        {
        }

        public RSubMeshDescriptor(System.Object instance) : base("UnityEngine.Rendering.SubMeshDescriptor")
		{
            SetInstance(instance);
		}

        public RSubMeshDescriptor(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSubMeshDescriptor(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
