using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.RenderTargetIdentifier
	/// </summary>
    public partial class RRenderTargetIdentifier : RMember //
    {

		/// <summary>
		/// System.Int32 AllDepthSlices
		/// </summary>
		protected static RSystem.RInt32 r_AllDepthSlices;
		public static RSystem.RInt32 RAllDepthSlices
		{
			get
			{
				if(r_AllDepthSlices == null)
				{
					r_AllDepthSlices = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "AllDepthSlices");
					r_AllDepthSlices.SetBelong(null);
				}
				return r_AllDepthSlices;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType m_Type
		/// </summary>
		protected RField r_m_Type;
		public virtual RField Rm_Type
		{
			get
			{
				if(r_m_Type == null)
				{
					r_m_Type = new(this, "m_Type");
					r_m_Type.SetBelong(this.instance);
				}
				return r_m_Type;
			}
		}

		/// <summary>
		/// System.Int32 m_NameID
		/// </summary>
		protected RSystem.RInt32 r_m_NameID;
		public virtual RSystem.RInt32 Rm_NameID
		{
			get
			{
				if(r_m_NameID == null)
				{
					r_m_NameID = new(this, "m_NameID");
					r_m_NameID.SetBelong(this.instance);
				}
				return r_m_NameID;
			}
		}

		/// <summary>
		/// System.Int32 m_InstanceID
		/// </summary>
		protected RSystem.RInt32 r_m_InstanceID;
		public virtual RSystem.RInt32 Rm_InstanceID
		{
			get
			{
				if(r_m_InstanceID == null)
				{
					r_m_InstanceID = new(this, "m_InstanceID");
					r_m_InstanceID.SetBelong(this.instance);
				}
				return r_m_InstanceID;
			}
		}

		/// <summary>
		/// System.IntPtr m_BufferPointer
		/// </summary>
		protected RSystem.RIntPtr r_m_BufferPointer;
		public virtual RSystem.RIntPtr Rm_BufferPointer
		{
			get
			{
				if(r_m_BufferPointer == null)
				{
					r_m_BufferPointer = new(this, "m_BufferPointer");
					r_m_BufferPointer.SetBelong(this.instance);
				}
				return r_m_BufferPointer;
			}
		}

		/// <summary>
		/// System.Int32 m_MipLevel
		/// </summary>
		protected RSystem.RInt32 r_m_MipLevel;
		public virtual RSystem.RInt32 Rm_MipLevel
		{
			get
			{
				if(r_m_MipLevel == null)
				{
					r_m_MipLevel = new(this, "m_MipLevel");
					r_m_MipLevel.SetBelong(this.instance);
				}
				return r_m_MipLevel;
			}
		}

		/// <summary>
		/// UnityEngine.CubemapFace m_CubeFace
		/// </summary>
		protected RField r_m_CubeFace;
		public virtual RField Rm_CubeFace
		{
			get
			{
				if(r_m_CubeFace == null)
				{
					r_m_CubeFace = new(this, "m_CubeFace");
					r_m_CubeFace.SetBelong(this.instance);
				}
				return r_m_CubeFace;
			}
		}

		/// <summary>
		/// System.Int32 m_DepthSlice
		/// </summary>
		protected RSystem.RInt32 r_m_DepthSlice;
		public virtual RSystem.RInt32 Rm_DepthSlice
		{
			get
			{
				if(r_m_DepthSlice == null)
				{
					r_m_DepthSlice = new(this, "m_DepthSlice");
					r_m_DepthSlice.SetBelong(this.instance);
				}
				return r_m_DepthSlice;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.BuiltinRenderTextureType)
		/// </summary>
		protected static RMethod r_op_Implicit_BuiltinRenderTextureType;
		public static RMethod Rop_Implicit_BuiltinRenderTextureType
		{
			get
			{
				if(r_op_Implicit_BuiltinRenderTextureType == null)
				{
					r_op_Implicit_BuiltinRenderTextureType = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "op_Implicit", 0, typeof(UnityEngine.Rendering.BuiltinRenderTextureType));
					r_op_Implicit_BuiltinRenderTextureType.SetBelong(null);
				}
				return r_op_Implicit_BuiltinRenderTextureType;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(System.String)
		/// </summary>
		protected static RMethod r_op_Implicit_String;
		public static RMethod Rop_Implicit_String
		{
			get
			{
				if(r_op_Implicit_String == null)
				{
					r_op_Implicit_String = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "op_Implicit", 0, typeof(System.String));
					r_op_Implicit_String.SetBelong(null);
				}
				return r_op_Implicit_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(Int32)
		/// </summary>
		protected static RMethod r_op_Implicit_Int32;
		public static RMethod Rop_Implicit_Int32
		{
			get
			{
				if(r_op_Implicit_Int32 == null)
				{
					r_op_Implicit_Int32 = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "op_Implicit", 0, typeof(System.Int32));
					r_op_Implicit_Int32.SetBelong(null);
				}
				return r_op_Implicit_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Texture)
		/// </summary>
		protected static RMethod r_op_Implicit_Texture;
		public static RMethod Rop_Implicit_Texture
		{
			get
			{
				if(r_op_Implicit_Texture == null)
				{
					r_op_Implicit_Texture = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "op_Implicit", 0, typeof(UnityEngine.Texture));
					r_op_Implicit_Texture.SetBelong(null);
				}
				return r_op_Implicit_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.RenderBuffer)
		/// </summary>
		protected static RMethod r_op_Implicit_RenderBuffer;
		public static RMethod Rop_Implicit_RenderBuffer
		{
			get
			{
				if(r_op_Implicit_RenderBuffer == null)
				{
					r_op_Implicit_RenderBuffer = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "op_Implicit", 0, typeof(UnityEngine.RenderBuffer));
					r_op_Implicit_RenderBuffer.SetBelong(null);
				}
				return r_op_Implicit_RenderBuffer;
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
		/// Boolean Equals(UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_Equals_RenderTargetIdentifier;
		public virtual RMethod REquals_RenderTargetIdentifier
		{
			get
			{
				if(r_Equals_RenderTargetIdentifier == null)
				{
					r_Equals_RenderTargetIdentifier = new(this, "Equals", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_Equals_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_Equals_RenderTargetIdentifier;
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
		/// Boolean op_Equality(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected static RMethod r_op_Equality_RenderTargetIdentifier_RenderTargetIdentifier;
		public static RMethod Rop_Equality_RenderTargetIdentifier_RenderTargetIdentifier
		{
			get
			{
				if(r_op_Equality_RenderTargetIdentifier_RenderTargetIdentifier == null)
				{
					r_op_Equality_RenderTargetIdentifier_RenderTargetIdentifier = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "op_Equality", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_op_Equality_RenderTargetIdentifier_RenderTargetIdentifier.SetBelong(null);
				}
				return r_op_Equality_RenderTargetIdentifier_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected static RMethod r_op_Inequality_RenderTargetIdentifier_RenderTargetIdentifier;
		public static RMethod Rop_Inequality_RenderTargetIdentifier_RenderTargetIdentifier
		{
			get
			{
				if(r_op_Inequality_RenderTargetIdentifier_RenderTargetIdentifier == null)
				{
					r_op_Inequality_RenderTargetIdentifier_RenderTargetIdentifier = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "op_Inequality", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_op_Inequality_RenderTargetIdentifier_RenderTargetIdentifier.SetBelong(null);
				}
				return r_op_Inequality_RenderTargetIdentifier_RenderTargetIdentifier;
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


        public RRenderTargetIdentifier() : base("UnityEngine.Rendering.RenderTargetIdentifier")
        {
        }

        public RRenderTargetIdentifier(System.Object instance) : base("UnityEngine.Rendering.RenderTargetIdentifier")
		{
            SetInstance(instance);
		}

        public RRenderTargetIdentifier(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderTargetIdentifier(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.BuiltinRenderTextureType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = Rop_Implicit_BuiltinRenderTextureType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.RenderTargetIdentifier)___result;
        }


        public static UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = Rop_Implicit_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.RenderTargetIdentifier)___result;
        }


        public static UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = Rop_Implicit_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.RenderTargetIdentifier)___result;
        }


        public static UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Texture @tex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tex};
            var ___result = Rop_Implicit_Texture.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.RenderTargetIdentifier)___result;
        }


        public static UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.RenderBuffer @buf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buf};
            var ___result = Rop_Implicit_RenderBuffer.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.RenderTargetIdentifier)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.RenderTargetIdentifier @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rhs};
            var ___result = REquals_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Rendering.RenderTargetIdentifier @lhs, UnityEngine.Rendering.RenderTargetIdentifier @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_RenderTargetIdentifier_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.RenderTargetIdentifier @lhs, UnityEngine.Rendering.RenderTargetIdentifier @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_RenderTargetIdentifier_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
