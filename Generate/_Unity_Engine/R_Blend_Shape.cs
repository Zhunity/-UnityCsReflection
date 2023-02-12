
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.BlendShape
	/// </summary>
    public partial class RBlendShape : RMember //
    {

		/// <summary>
		/// System.UInt32 m_FirstVertex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_Fm_FirstVertex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFm_FirstVertex
		{
			get
			{
				if(r_Fm_FirstVertex == null)
				{
					r_Fm_FirstVertex = new(this, "m_FirstVertex");
					r_Fm_FirstVertex.SetBelong(this.instance);
				}
				return r_Fm_FirstVertex;
			}
		}

		/// <summary>
		/// System.UInt32 m_VertexCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_Fm_VertexCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFm_VertexCount
		{
			get
			{
				if(r_Fm_VertexCount == null)
				{
					r_Fm_VertexCount = new(this, "m_VertexCount");
					r_Fm_VertexCount.SetBelong(this.instance);
				}
				return r_Fm_VertexCount;
			}
		}

		/// <summary>
		/// System.Boolean m_HasNormals
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_HasNormals;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_HasNormals
		{
			get
			{
				if(r_Fm_HasNormals == null)
				{
					r_Fm_HasNormals = new(this, "m_HasNormals");
					r_Fm_HasNormals.SetBelong(this.instance);
				}
				return r_Fm_HasNormals;
			}
		}

		/// <summary>
		/// System.Boolean m_HasTangents
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_HasTangents;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_HasTangents
		{
			get
			{
				if(r_Fm_HasTangents == null)
				{
					r_Fm_HasTangents = new(this, "m_HasTangents");
					r_Fm_HasTangents.SetBelong(this.instance);
				}
				return r_Fm_HasTangents;
			}
		}

		/// <summary>
		/// UInt32 firstVertex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_PfirstVertex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPfirstVertex
		{
			get
			{
				if(r_PfirstVertex == null)
				{
					r_PfirstVertex = new(this, "firstVertex", -1);
					r_PfirstVertex.SetBelong(this.instance);
				}
				return r_PfirstVertex;
			}
		}

		/// <summary>
		/// UInt32 vertexCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_PvertexCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPvertexCount
		{
			get
			{
				if(r_PvertexCount == null)
				{
					r_PvertexCount = new(this, "vertexCount", -1);
					r_PvertexCount.SetBelong(this.instance);
				}
				return r_PvertexCount;
			}
		}

		/// <summary>
		/// Boolean hasNormals
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PhasNormals;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPhasNormals
		{
			get
			{
				if(r_PhasNormals == null)
				{
					r_PhasNormals = new(this, "hasNormals", -1);
					r_PhasNormals.SetBelong(this.instance);
				}
				return r_PhasNormals;
			}
		}

		/// <summary>
		/// Boolean hasTangents
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PhasTangents;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPhasTangents
		{
			get
			{
				if(r_PhasTangents == null)
				{
					r_PhasTangents = new(this, "hasTangents", -1);
					r_PhasTangents.SetBelong(this.instance);
				}
				return r_PhasTangents;
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


        public RBlendShape() : base("UnityEngine.BlendShape")
        {
        }

        public RBlendShape(System.Object instance) : base("UnityEngine.BlendShape")
		{
            SetInstance(instance);
		}

        public RBlendShape(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBlendShape(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
