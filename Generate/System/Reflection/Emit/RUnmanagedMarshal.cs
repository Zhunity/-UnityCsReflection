using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.UnmanagedMarshal
	/// </summary>
    public partial class RUnmanagedMarshal : RMember //
    {

		/// <summary>
		/// System.Int32 count
		/// </summary>
		protected RField r_count;
		public virtual RField Rcount
		{
			get
			{
				if(r_count == null)
				{
					r_count = new(this, "count");
					r_count.SetBelong(this.instance);
				}
				return r_count;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType t
		/// </summary>
		protected RField r_t;
		public virtual RField Rt
		{
			get
			{
				if(r_t == null)
				{
					r_t = new(this, "t");
					r_t.SetBelong(this.instance);
				}
				return r_t;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType tbase
		/// </summary>
		protected RField r_tbase;
		public virtual RField Rtbase
		{
			get
			{
				if(r_tbase == null)
				{
					r_tbase = new(this, "tbase");
					r_tbase.SetBelong(this.instance);
				}
				return r_tbase;
			}
		}

		/// <summary>
		/// System.String guid
		/// </summary>
		protected RField r_guid;
		public virtual RField Rguid
		{
			get
			{
				if(r_guid == null)
				{
					r_guid = new(this, "guid");
					r_guid.SetBelong(this.instance);
				}
				return r_guid;
			}
		}

		/// <summary>
		/// System.String mcookie
		/// </summary>
		protected RField r_mcookie;
		public virtual RField Rmcookie
		{
			get
			{
				if(r_mcookie == null)
				{
					r_mcookie = new(this, "mcookie");
					r_mcookie.SetBelong(this.instance);
				}
				return r_mcookie;
			}
		}

		/// <summary>
		/// System.String marshaltype
		/// </summary>
		protected RField r_marshaltype;
		public virtual RField Rmarshaltype
		{
			get
			{
				if(r_marshaltype == null)
				{
					r_marshaltype = new(this, "marshaltype");
					r_marshaltype.SetBelong(this.instance);
				}
				return r_marshaltype;
			}
		}

		/// <summary>
		/// System.Type marshaltyperef
		/// </summary>
		protected RSystem.RType r_marshaltyperef;
		public virtual RSystem.RType Rmarshaltyperef
		{
			get
			{
				if(r_marshaltyperef == null)
				{
					r_marshaltyperef = new(this, "marshaltyperef");
					r_marshaltyperef.SetBelong(this.instance);
				}
				return r_marshaltyperef;
			}
		}

		/// <summary>
		/// System.Int32 param_num
		/// </summary>
		protected RField r_param_num;
		public virtual RField Rparam_num
		{
			get
			{
				if(r_param_num == null)
				{
					r_param_num = new(this, "param_num");
					r_param_num.SetBelong(this.instance);
				}
				return r_param_num;
			}
		}

		/// <summary>
		/// System.Boolean has_size
		/// </summary>
		protected RField r_has_size;
		public virtual RField Rhas_size
		{
			get
			{
				if(r_has_size == null)
				{
					r_has_size = new(this, "has_size");
					r_has_size.SetBelong(this.instance);
				}
				return r_has_size;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType BaseType
		/// </summary>
		protected RProperty r_BaseType;
		public virtual RProperty RBaseType
		{
			get
			{
				if(r_BaseType == null)
				{
					r_BaseType = new(this, "BaseType", -1);
					r_BaseType.SetBelong(this.instance);
				}
				return r_BaseType;
			}
		}

		/// <summary>
		/// Int32 ElementCount
		/// </summary>
		protected RProperty r_ElementCount;
		public virtual RProperty RElementCount
		{
			get
			{
				if(r_ElementCount == null)
				{
					r_ElementCount = new(this, "ElementCount", -1);
					r_ElementCount.SetBelong(this.instance);
				}
				return r_ElementCount;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType GetUnmanagedType
		/// </summary>
		protected RProperty r_GetUnmanagedType;
		public virtual RProperty RGetUnmanagedType
		{
			get
			{
				if(r_GetUnmanagedType == null)
				{
					r_GetUnmanagedType = new(this, "GetUnmanagedType", -1);
					r_GetUnmanagedType.SetBelong(this.instance);
				}
				return r_GetUnmanagedType;
			}
		}

		/// <summary>
		/// System.Guid IIDGuid
		/// </summary>
		protected RSystem.RGuid r_IIDGuid;
		public virtual RSystem.RGuid RIIDGuid
		{
			get
			{
				if(r_IIDGuid == null)
				{
					r_IIDGuid = new(this, "IIDGuid", -1);
					r_IIDGuid.SetBelong(this.instance);
				}
				return r_IIDGuid;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal DefineByValArray(Int32)
		/// </summary>
		protected static RMethod r_DefineByValArray_Int32;
		public static RMethod RDefineByValArray_Int32
		{
			get
			{
				if(r_DefineByValArray_Int32 == null)
				{
					r_DefineByValArray_Int32 = new(typeof(System.Reflection.Emit.UnmanagedMarshal), "DefineByValArray", 0, typeof(System.Int32));
					r_DefineByValArray_Int32.SetBelong(null);
				}
				return r_DefineByValArray_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal DefineByValTStr(Int32)
		/// </summary>
		protected static RMethod r_DefineByValTStr_Int32;
		public static RMethod RDefineByValTStr_Int32
		{
			get
			{
				if(r_DefineByValTStr_Int32 == null)
				{
					r_DefineByValTStr_Int32 = new(typeof(System.Reflection.Emit.UnmanagedMarshal), "DefineByValTStr", 0, typeof(System.Int32));
					r_DefineByValTStr_Int32.SetBelong(null);
				}
				return r_DefineByValTStr_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal DefineLPArray(System.Runtime.InteropServices.UnmanagedType)
		/// </summary>
		protected static RMethod r_DefineLPArray_UnmanagedType;
		public static RMethod RDefineLPArray_UnmanagedType
		{
			get
			{
				if(r_DefineLPArray_UnmanagedType == null)
				{
					r_DefineLPArray_UnmanagedType = new(typeof(System.Reflection.Emit.UnmanagedMarshal), "DefineLPArray", 0, typeof(System.Runtime.InteropServices.UnmanagedType));
					r_DefineLPArray_UnmanagedType.SetBelong(null);
				}
				return r_DefineLPArray_UnmanagedType;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal DefineSafeArray(System.Runtime.InteropServices.UnmanagedType)
		/// </summary>
		protected static RMethod r_DefineSafeArray_UnmanagedType;
		public static RMethod RDefineSafeArray_UnmanagedType
		{
			get
			{
				if(r_DefineSafeArray_UnmanagedType == null)
				{
					r_DefineSafeArray_UnmanagedType = new(typeof(System.Reflection.Emit.UnmanagedMarshal), "DefineSafeArray", 0, typeof(System.Runtime.InteropServices.UnmanagedType));
					r_DefineSafeArray_UnmanagedType.SetBelong(null);
				}
				return r_DefineSafeArray_UnmanagedType;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal DefineUnmanagedMarshal(System.Runtime.InteropServices.UnmanagedType)
		/// </summary>
		protected static RMethod r_DefineUnmanagedMarshal_UnmanagedType;
		public static RMethod RDefineUnmanagedMarshal_UnmanagedType
		{
			get
			{
				if(r_DefineUnmanagedMarshal_UnmanagedType == null)
				{
					r_DefineUnmanagedMarshal_UnmanagedType = new(typeof(System.Reflection.Emit.UnmanagedMarshal), "DefineUnmanagedMarshal", 0, typeof(System.Runtime.InteropServices.UnmanagedType));
					r_DefineUnmanagedMarshal_UnmanagedType.SetBelong(null);
				}
				return r_DefineUnmanagedMarshal_UnmanagedType;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal DefineCustom(System.Type, System.String, System.String, System.Guid)
		/// </summary>
		protected static RMethod r_DefineCustom_Type_String_String_Guid;
		public static RMethod RDefineCustom_Type_String_String_Guid
		{
			get
			{
				if(r_DefineCustom_Type_String_String_Guid == null)
				{
					r_DefineCustom_Type_String_String_Guid = new(typeof(System.Reflection.Emit.UnmanagedMarshal), "DefineCustom", 0, typeof(System.Type), typeof(System.String), typeof(System.String), typeof(System.Guid));
					r_DefineCustom_Type_String_String_Guid.SetBelong(null);
				}
				return r_DefineCustom_Type_String_String_Guid;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal DefineLPArrayInternal(System.Runtime.InteropServices.UnmanagedType, Int32, Int32)
		/// </summary>
		protected static RMethod r_DefineLPArrayInternal_UnmanagedType_Int32_Int32;
		public static RMethod RDefineLPArrayInternal_UnmanagedType_Int32_Int32
		{
			get
			{
				if(r_DefineLPArrayInternal_UnmanagedType_Int32_Int32 == null)
				{
					r_DefineLPArrayInternal_UnmanagedType_Int32_Int32 = new(typeof(System.Reflection.Emit.UnmanagedMarshal), "DefineLPArrayInternal", 0, typeof(System.Runtime.InteropServices.UnmanagedType), typeof(System.Int32), typeof(System.Int32));
					r_DefineLPArrayInternal_UnmanagedType_Int32_Int32.SetBelong(null);
				}
				return r_DefineLPArrayInternal_UnmanagedType_Int32_Int32;
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


        public RUnmanagedMarshal() : base("System.Reflection.Emit.UnmanagedMarshal")
        {
        }

        public RUnmanagedMarshal(System.Object instance) : base("System.Reflection.Emit.UnmanagedMarshal")
		{
            SetInstance(instance);
		}

        public RUnmanagedMarshal(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnmanagedMarshal(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Reflection.Emit.UnmanagedMarshal DefineByValArray(System.Int32 @elemCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elemCount};
            var ___result = RDefineByValArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.UnmanagedMarshal)___result;
        }


        public static System.Reflection.Emit.UnmanagedMarshal DefineByValTStr(System.Int32 @elemCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elemCount};
            var ___result = RDefineByValTStr_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.UnmanagedMarshal)___result;
        }


        public static System.Reflection.Emit.UnmanagedMarshal DefineLPArray(System.Runtime.InteropServices.UnmanagedType @elemType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elemType};
            var ___result = RDefineLPArray_UnmanagedType.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.UnmanagedMarshal)___result;
        }


        public static System.Reflection.Emit.UnmanagedMarshal DefineSafeArray(System.Runtime.InteropServices.UnmanagedType @elemType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elemType};
            var ___result = RDefineSafeArray_UnmanagedType.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.UnmanagedMarshal)___result;
        }


        public static System.Reflection.Emit.UnmanagedMarshal DefineUnmanagedMarshal(System.Runtime.InteropServices.UnmanagedType @unmanagedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unmanagedType};
            var ___result = RDefineUnmanagedMarshal_UnmanagedType.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.UnmanagedMarshal)___result;
        }


        public static System.Reflection.Emit.UnmanagedMarshal DefineCustom(System.Type @typeref, System.String @cookie, System.String @mtype, System.Guid @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeref, @cookie, @mtype, @id};
            var ___result = RDefineCustom_Type_String_String_Guid.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.UnmanagedMarshal)___result;
        }


        public static System.Reflection.Emit.UnmanagedMarshal DefineLPArrayInternal(System.Runtime.InteropServices.UnmanagedType @elemType, System.Int32 @sizeConst, System.Int32 @sizeParamIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elemType, @sizeConst, @sizeParamIndex};
            var ___result = RDefineLPArrayInternal_UnmanagedType_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.UnmanagedMarshal)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
