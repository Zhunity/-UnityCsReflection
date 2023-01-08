using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.RectOffset
	/// </summary>
    public partial class RRectOffset : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected RField r_m_Ptr;
		public virtual RField Rm_Ptr
		{
			get
			{
				if(r_m_Ptr == null)
				{
					r_m_Ptr = new(this, "m_Ptr");
					r_m_Ptr.SetBelong(this.instance);
				}
				return r_m_Ptr;
			}
		}

		/// <summary>
		/// System.Object m_SourceStyle
		/// </summary>
		protected RSystem.RObject r_m_SourceStyle;
		public virtual RSystem.RObject Rm_SourceStyle
		{
			get
			{
				if(r_m_SourceStyle == null)
				{
					r_m_SourceStyle = new(this, "m_SourceStyle");
					r_m_SourceStyle.SetBelong(this.instance);
				}
				return r_m_SourceStyle;
			}
		}

		/// <summary>
		/// Int32 left
		/// </summary>
		protected RProperty r_left;
		public virtual RProperty Rleft
		{
			get
			{
				if(r_left == null)
				{
					r_left = new(this, "left", -1);
					r_left.SetBelong(this.instance);
				}
				return r_left;
			}
		}

		/// <summary>
		/// Int32 right
		/// </summary>
		protected RProperty r_right;
		public virtual RProperty Rright
		{
			get
			{
				if(r_right == null)
				{
					r_right = new(this, "right", -1);
					r_right.SetBelong(this.instance);
				}
				return r_right;
			}
		}

		/// <summary>
		/// Int32 top
		/// </summary>
		protected RProperty r_top;
		public virtual RProperty Rtop
		{
			get
			{
				if(r_top == null)
				{
					r_top = new(this, "top", -1);
					r_top.SetBelong(this.instance);
				}
				return r_top;
			}
		}

		/// <summary>
		/// Int32 bottom
		/// </summary>
		protected RProperty r_bottom;
		public virtual RProperty Rbottom
		{
			get
			{
				if(r_bottom == null)
				{
					r_bottom = new(this, "bottom", -1);
					r_bottom.SetBelong(this.instance);
				}
				return r_bottom;
			}
		}

		/// <summary>
		/// Int32 horizontal
		/// </summary>
		protected RProperty r_horizontal;
		public virtual RProperty Rhorizontal
		{
			get
			{
				if(r_horizontal == null)
				{
					r_horizontal = new(this, "horizontal", -1);
					r_horizontal.SetBelong(this.instance);
				}
				return r_horizontal;
			}
		}

		/// <summary>
		/// Int32 vertical
		/// </summary>
		protected RProperty r_vertical;
		public virtual RProperty Rvertical
		{
			get
			{
				if(r_vertical == null)
				{
					r_vertical = new(this, "vertical", -1);
					r_vertical.SetBelong(this.instance);
				}
				return r_vertical;
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
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_ToString_String;
		public virtual RMethod RToString_String
		{
			get
			{
				if(r_ToString_String == null)
				{
					r_ToString_String = new(this, "ToString", 0, typeof(System.String));
					r_ToString_String.SetBelong(this.instance);
				}
				return r_ToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToString_String_IFormatProvider;
		public virtual RMethod RToString_String_IFormatProvider
		{
			get
			{
				if(r_ToString_String_IFormatProvider == null)
				{
					r_ToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_ToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Void Destroy()
		/// </summary>
		protected RMethod r_Destroy;
		public virtual RMethod RDestroy
		{
			get
			{
				if(r_Destroy == null)
				{
					r_Destroy = new(this, "Destroy", 0);
					r_Destroy.SetBelong(this.instance);
				}
				return r_Destroy;
			}
		}

		/// <summary>
		/// IntPtr InternalCreate()
		/// </summary>
		protected static RMethod r_InternalCreate;
		public static RMethod RInternalCreate
		{
			get
			{
				if(r_InternalCreate == null)
				{
					r_InternalCreate = new(typeof(UnityEngine.RectOffset), "InternalCreate", 0);
					r_InternalCreate.SetBelong(null);
				}
				return r_InternalCreate;
			}
		}

		/// <summary>
		/// Void InternalDestroy(IntPtr)
		/// </summary>
		protected static RMethod r_InternalDestroy_IntPtr;
		public static RMethod RInternalDestroy_IntPtr
		{
			get
			{
				if(r_InternalDestroy_IntPtr == null)
				{
					r_InternalDestroy_IntPtr = new(typeof(UnityEngine.RectOffset), "InternalDestroy", 0, typeof(System.IntPtr));
					r_InternalDestroy_IntPtr.SetBelong(null);
				}
				return r_InternalDestroy_IntPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Rect Add(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_Add_Rect;
		public virtual RMethod RAdd_Rect
		{
			get
			{
				if(r_Add_Rect == null)
				{
					r_Add_Rect = new(this, "Add", 0, typeof(UnityEngine.Rect));
					r_Add_Rect.SetBelong(this.instance);
				}
				return r_Add_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect Remove(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_Remove_Rect;
		public virtual RMethod RRemove_Rect
		{
			get
			{
				if(r_Remove_Rect == null)
				{
					r_Remove_Rect = new(this, "Remove", 0, typeof(UnityEngine.Rect));
					r_Remove_Rect.SetBelong(this.instance);
				}
				return r_Remove_Rect;
			}
		}

		/// <summary>
		/// Void Add_Injected(UnityEngine.Rect ByRef, UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_Add_Injected_Ref_Rect_Out_Rect;
		public virtual RMethod RAdd_Injected_Ref_Rect_Out_Rect
		{
			get
			{
				if(r_Add_Injected_Ref_Rect_Out_Rect == null)
				{
					r_Add_Injected_Ref_Rect_Out_Rect = new(this, "Add_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType());
					r_Add_Injected_Ref_Rect_Out_Rect.SetBelong(this.instance);
				}
				return r_Add_Injected_Ref_Rect_Out_Rect;
			}
		}

		/// <summary>
		/// Void Remove_Injected(UnityEngine.Rect ByRef, UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_Remove_Injected_Ref_Rect_Out_Rect;
		public virtual RMethod RRemove_Injected_Ref_Rect_Out_Rect
		{
			get
			{
				if(r_Remove_Injected_Ref_Rect_Out_Rect == null)
				{
					r_Remove_Injected_Ref_Rect_Out_Rect = new(this, "Remove_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType());
					r_Remove_Injected_Ref_Rect_Out_Rect.SetBelong(this.instance);
				}
				return r_Remove_Injected_Ref_Rect_Out_Rect;
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


        public RRectOffset() : base("UnityEngine.RectOffset")
        {
        }

        public RRectOffset(System.Object instance) : base("UnityEngine.RectOffset")
		{
            SetInstance(instance);
		}

        public RRectOffset(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRectOffset(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Destroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr InternalCreate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalCreate.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void InternalDestroy(System.IntPtr @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RInternalDestroy_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect Add(UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RAdd_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual UnityEngine.Rect Remove(UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RRemove_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void Add_Injected(ref UnityEngine.Rect @rect, out UnityEngine.Rect @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @ret};
            var ___result = RAdd_Injected_Ref_Rect_Out_Rect.Invoke(___genericsType, ___parameters);
			@rect = (UnityEngine.Rect)___parameters[0];
			@ret = (UnityEngine.Rect)___parameters[1];

            
        }


        public virtual void Remove_Injected(ref UnityEngine.Rect @rect, out UnityEngine.Rect @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @ret};
            var ___result = RRemove_Injected_Ref_Rect_Out_Rect.Invoke(___genericsType, ___parameters);
			@rect = (UnityEngine.Rect)___parameters[0];
			@ret = (UnityEngine.Rect)___parameters[1];

            
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
