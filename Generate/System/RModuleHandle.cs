using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.ModuleHandle
	/// </summary>
    public partial class RModuleHandle : RMember //
    {

		/// <summary>
		/// System.IntPtr value
		/// </summary>
		protected RField r_value;
		public virtual RField Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value");
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// System.ModuleHandle EmptyHandle
		/// </summary>
		protected static RSystem.RModuleHandle r_EmptyHandle;
		public static RSystem.RModuleHandle REmptyHandle
		{
			get
			{
				if(r_EmptyHandle == null)
				{
					r_EmptyHandle = new(typeof(System.ModuleHandle), "EmptyHandle");
					r_EmptyHandle.SetBelong(null);
				}
				return r_EmptyHandle;
			}
		}

		/// <summary>
		/// IntPtr Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// Int32 MDStreamVersion
		/// </summary>
		protected RProperty r_MDStreamVersion;
		public virtual RProperty RMDStreamVersion
		{
			get
			{
				if(r_MDStreamVersion == null)
				{
					r_MDStreamVersion = new(this, "MDStreamVersion", -1);
					r_MDStreamVersion.SetBelong(this.instance);
				}
				return r_MDStreamVersion;
			}
		}

		/// <summary>
		/// Void GetPEKind(System.Reflection.PortableExecutableKinds ByRef, System.Reflection.ImageFileMachine ByRef)
		/// </summary>
		protected RMethod r_GetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine;
		public virtual RMethod RGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine
		{
			get
			{
				if(r_GetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine == null)
				{
					r_GetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine = new(this, "GetPEKind", 0, typeof(System.Reflection.PortableExecutableKinds).MakeByRefType(), typeof(System.Reflection.ImageFileMachine).MakeByRefType());
					r_GetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine.SetBelong(this.instance);
				}
				return r_GetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine;
			}
		}

		/// <summary>
		/// System.RuntimeFieldHandle ResolveFieldHandle(Int32)
		/// </summary>
		protected RMethod r_ResolveFieldHandle_Int32;
		public virtual RMethod RResolveFieldHandle_Int32
		{
			get
			{
				if(r_ResolveFieldHandle_Int32 == null)
				{
					r_ResolveFieldHandle_Int32 = new(this, "ResolveFieldHandle", 0, typeof(System.Int32));
					r_ResolveFieldHandle_Int32.SetBelong(this.instance);
				}
				return r_ResolveFieldHandle_Int32;
			}
		}

		/// <summary>
		/// System.RuntimeMethodHandle ResolveMethodHandle(Int32)
		/// </summary>
		protected RMethod r_ResolveMethodHandle_Int32;
		public virtual RMethod RResolveMethodHandle_Int32
		{
			get
			{
				if(r_ResolveMethodHandle_Int32 == null)
				{
					r_ResolveMethodHandle_Int32 = new(this, "ResolveMethodHandle", 0, typeof(System.Int32));
					r_ResolveMethodHandle_Int32.SetBelong(this.instance);
				}
				return r_ResolveMethodHandle_Int32;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle ResolveTypeHandle(Int32)
		/// </summary>
		protected RMethod r_ResolveTypeHandle_Int32;
		public virtual RMethod RResolveTypeHandle_Int32
		{
			get
			{
				if(r_ResolveTypeHandle_Int32 == null)
				{
					r_ResolveTypeHandle_Int32 = new(this, "ResolveTypeHandle", 0, typeof(System.Int32));
					r_ResolveTypeHandle_Int32.SetBelong(this.instance);
				}
				return r_ResolveTypeHandle_Int32;
			}
		}

		/// <summary>
		/// IntPtr[] ptrs_from_handles(System.RuntimeTypeHandle[])
		/// </summary>
		protected RMethod r_ptrs_from_handles_RuntimeTypeHandleArray;
		public virtual RMethod Rptrs_from_handles_RuntimeTypeHandleArray
		{
			get
			{
				if(r_ptrs_from_handles_RuntimeTypeHandleArray == null)
				{
					r_ptrs_from_handles_RuntimeTypeHandleArray = new(this, "ptrs_from_handles", 0, typeof(System.RuntimeTypeHandle).MakeArrayType());
					r_ptrs_from_handles_RuntimeTypeHandleArray.SetBelong(this.instance);
				}
				return r_ptrs_from_handles_RuntimeTypeHandleArray;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle ResolveTypeHandle(Int32, System.RuntimeTypeHandle[], System.RuntimeTypeHandle[])
		/// </summary>
		protected RMethod r_ResolveTypeHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray;
		public virtual RMethod RResolveTypeHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray
		{
			get
			{
				if(r_ResolveTypeHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray == null)
				{
					r_ResolveTypeHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray = new(this, "ResolveTypeHandle", 0, typeof(System.Int32), typeof(System.RuntimeTypeHandle).MakeArrayType(), typeof(System.RuntimeTypeHandle).MakeArrayType());
					r_ResolveTypeHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray.SetBelong(this.instance);
				}
				return r_ResolveTypeHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray;
			}
		}

		/// <summary>
		/// System.RuntimeMethodHandle ResolveMethodHandle(Int32, System.RuntimeTypeHandle[], System.RuntimeTypeHandle[])
		/// </summary>
		protected RMethod r_ResolveMethodHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray;
		public virtual RMethod RResolveMethodHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray
		{
			get
			{
				if(r_ResolveMethodHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray == null)
				{
					r_ResolveMethodHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray = new(this, "ResolveMethodHandle", 0, typeof(System.Int32), typeof(System.RuntimeTypeHandle).MakeArrayType(), typeof(System.RuntimeTypeHandle).MakeArrayType());
					r_ResolveMethodHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray.SetBelong(this.instance);
				}
				return r_ResolveMethodHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray;
			}
		}

		/// <summary>
		/// System.RuntimeFieldHandle ResolveFieldHandle(Int32, System.RuntimeTypeHandle[], System.RuntimeTypeHandle[])
		/// </summary>
		protected RMethod r_ResolveFieldHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray;
		public virtual RMethod RResolveFieldHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray
		{
			get
			{
				if(r_ResolveFieldHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray == null)
				{
					r_ResolveFieldHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray = new(this, "ResolveFieldHandle", 0, typeof(System.Int32), typeof(System.RuntimeTypeHandle).MakeArrayType(), typeof(System.RuntimeTypeHandle).MakeArrayType());
					r_ResolveFieldHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray.SetBelong(this.instance);
				}
				return r_ResolveFieldHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray;
			}
		}

		/// <summary>
		/// System.RuntimeFieldHandle GetRuntimeFieldHandleFromMetadataToken(Int32)
		/// </summary>
		protected RMethod r_GetRuntimeFieldHandleFromMetadataToken_Int32;
		public virtual RMethod RGetRuntimeFieldHandleFromMetadataToken_Int32
		{
			get
			{
				if(r_GetRuntimeFieldHandleFromMetadataToken_Int32 == null)
				{
					r_GetRuntimeFieldHandleFromMetadataToken_Int32 = new(this, "GetRuntimeFieldHandleFromMetadataToken", 0, typeof(System.Int32));
					r_GetRuntimeFieldHandleFromMetadataToken_Int32.SetBelong(this.instance);
				}
				return r_GetRuntimeFieldHandleFromMetadataToken_Int32;
			}
		}

		/// <summary>
		/// System.RuntimeMethodHandle GetRuntimeMethodHandleFromMetadataToken(Int32)
		/// </summary>
		protected RMethod r_GetRuntimeMethodHandleFromMetadataToken_Int32;
		public virtual RMethod RGetRuntimeMethodHandleFromMetadataToken_Int32
		{
			get
			{
				if(r_GetRuntimeMethodHandleFromMetadataToken_Int32 == null)
				{
					r_GetRuntimeMethodHandleFromMetadataToken_Int32 = new(this, "GetRuntimeMethodHandleFromMetadataToken", 0, typeof(System.Int32));
					r_GetRuntimeMethodHandleFromMetadataToken_Int32.SetBelong(this.instance);
				}
				return r_GetRuntimeMethodHandleFromMetadataToken_Int32;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle GetRuntimeTypeHandleFromMetadataToken(Int32)
		/// </summary>
		protected RMethod r_GetRuntimeTypeHandleFromMetadataToken_Int32;
		public virtual RMethod RGetRuntimeTypeHandleFromMetadataToken_Int32
		{
			get
			{
				if(r_GetRuntimeTypeHandleFromMetadataToken_Int32 == null)
				{
					r_GetRuntimeTypeHandleFromMetadataToken_Int32 = new(this, "GetRuntimeTypeHandleFromMetadataToken", 0, typeof(System.Int32));
					r_GetRuntimeTypeHandleFromMetadataToken_Int32.SetBelong(this.instance);
				}
				return r_GetRuntimeTypeHandleFromMetadataToken_Int32;
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
		/// Boolean Equals(System.ModuleHandle)
		/// </summary>
		protected RMethod r_Equals_ModuleHandle;
		public virtual RMethod REquals_ModuleHandle
		{
			get
			{
				if(r_Equals_ModuleHandle == null)
				{
					r_Equals_ModuleHandle = new(this, "Equals", 0, typeof(System.ModuleHandle));
					r_Equals_ModuleHandle.SetBelong(this.instance);
				}
				return r_Equals_ModuleHandle;
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
		/// Boolean op_Equality(System.ModuleHandle, System.ModuleHandle)
		/// </summary>
		protected static RMethod r_op_Equality_ModuleHandle_ModuleHandle;
		public static RMethod Rop_Equality_ModuleHandle_ModuleHandle
		{
			get
			{
				if(r_op_Equality_ModuleHandle_ModuleHandle == null)
				{
					r_op_Equality_ModuleHandle_ModuleHandle = new(typeof(System.ModuleHandle), "op_Equality", 0, typeof(System.ModuleHandle), typeof(System.ModuleHandle));
					r_op_Equality_ModuleHandle_ModuleHandle.SetBelong(null);
				}
				return r_op_Equality_ModuleHandle_ModuleHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.ModuleHandle, System.ModuleHandle)
		/// </summary>
		protected static RMethod r_op_Inequality_ModuleHandle_ModuleHandle;
		public static RMethod Rop_Inequality_ModuleHandle_ModuleHandle
		{
			get
			{
				if(r_op_Inequality_ModuleHandle_ModuleHandle == null)
				{
					r_op_Inequality_ModuleHandle_ModuleHandle = new(typeof(System.ModuleHandle), "op_Inequality", 0, typeof(System.ModuleHandle), typeof(System.ModuleHandle));
					r_op_Inequality_ModuleHandle_ModuleHandle.SetBelong(null);
				}
				return r_op_Inequality_ModuleHandle_ModuleHandle;
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


        public RModuleHandle() : base("System.ModuleHandle")
        {
        }

        public RModuleHandle(System.Object instance) : base("System.ModuleHandle")
		{
            SetInstance(instance);
		}

        public RModuleHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RModuleHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void GetPEKind(out System.Reflection.PortableExecutableKinds @peKind, out System.Reflection.ImageFileMachine @machine)
        {
			@peKind = default;
			@machine = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@peKind, @machine};
            var ___result = RGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine.Invoke(___genericsType, ___parameters);
			@peKind = (System.Reflection.PortableExecutableKinds)___parameters[0];
			@machine = (System.Reflection.ImageFileMachine)___parameters[1];

            
        }


        public virtual System.RuntimeFieldHandle ResolveFieldHandle(System.Int32 @fieldToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldToken};
            var ___result = RResolveFieldHandle_Int32.Invoke(___genericsType, ___parameters);

            return (System.RuntimeFieldHandle)___result;
        }


        public virtual System.RuntimeMethodHandle ResolveMethodHandle(System.Int32 @methodToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodToken};
            var ___result = RResolveMethodHandle_Int32.Invoke(___genericsType, ___parameters);

            return (System.RuntimeMethodHandle)___result;
        }


        public virtual System.RuntimeTypeHandle ResolveTypeHandle(System.Int32 @typeToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeToken};
            var ___result = RResolveTypeHandle_Int32.Invoke(___genericsType, ___parameters);

            return (System.RuntimeTypeHandle)___result;
        }


        public virtual System.IntPtr[] ptrs_from_handles(System.RuntimeTypeHandle[] @handles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handles};
            var ___result = Rptrs_from_handles_RuntimeTypeHandleArray.Invoke(___genericsType, ___parameters);

            return (System.IntPtr[])___result;
        }


        public virtual System.RuntimeTypeHandle ResolveTypeHandle(System.Int32 @typeToken, System.RuntimeTypeHandle[] @typeInstantiationContext, System.RuntimeTypeHandle[] @methodInstantiationContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeToken, @typeInstantiationContext, @methodInstantiationContext};
            var ___result = RResolveTypeHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray.Invoke(___genericsType, ___parameters);

            return (System.RuntimeTypeHandle)___result;
        }


        public virtual System.RuntimeMethodHandle ResolveMethodHandle(System.Int32 @methodToken, System.RuntimeTypeHandle[] @typeInstantiationContext, System.RuntimeTypeHandle[] @methodInstantiationContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodToken, @typeInstantiationContext, @methodInstantiationContext};
            var ___result = RResolveMethodHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray.Invoke(___genericsType, ___parameters);

            return (System.RuntimeMethodHandle)___result;
        }


        public virtual System.RuntimeFieldHandle ResolveFieldHandle(System.Int32 @fieldToken, System.RuntimeTypeHandle[] @typeInstantiationContext, System.RuntimeTypeHandle[] @methodInstantiationContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldToken, @typeInstantiationContext, @methodInstantiationContext};
            var ___result = RResolveFieldHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray.Invoke(___genericsType, ___parameters);

            return (System.RuntimeFieldHandle)___result;
        }


        public virtual System.RuntimeFieldHandle GetRuntimeFieldHandleFromMetadataToken(System.Int32 @fieldToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldToken};
            var ___result = RGetRuntimeFieldHandleFromMetadataToken_Int32.Invoke(___genericsType, ___parameters);

            return (System.RuntimeFieldHandle)___result;
        }


        public virtual System.RuntimeMethodHandle GetRuntimeMethodHandleFromMetadataToken(System.Int32 @methodToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodToken};
            var ___result = RGetRuntimeMethodHandleFromMetadataToken_Int32.Invoke(___genericsType, ___parameters);

            return (System.RuntimeMethodHandle)___result;
        }


        public virtual System.RuntimeTypeHandle GetRuntimeTypeHandleFromMetadataToken(System.Int32 @typeToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeToken};
            var ___result = RGetRuntimeTypeHandleFromMetadataToken_Int32.Invoke(___genericsType, ___parameters);

            return (System.RuntimeTypeHandle)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.ModuleHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = REquals_ModuleHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.ModuleHandle @left, System.ModuleHandle @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_ModuleHandle_ModuleHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.ModuleHandle @left, System.ModuleHandle @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_ModuleHandle_ModuleHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
