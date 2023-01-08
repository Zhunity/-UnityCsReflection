using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GUIStyleState
	/// </summary>
    public partial class RGUIStyleState : RMember //
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
		/// UnityEngine.GUIStyle m_SourceStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_SourceStyle;
		public virtual RUnityEngine.RGUIStyle Rm_SourceStyle
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
		/// UnityEngine.Texture2D background
		/// </summary>
		protected RUnityEngine.RTexture2D r_background;
		public virtual RUnityEngine.RTexture2D Rbackground
		{
			get
			{
				if(r_background == null)
				{
					r_background = new(this, "background", -1);
					r_background.SetBelong(this.instance);
				}
				return r_background;
			}
		}

		/// <summary>
		/// UnityEngine.Color textColor
		/// </summary>
		protected RUnityEngine.RColor r_textColor;
		public virtual RUnityEngine.RColor RtextColor
		{
			get
			{
				if(r_textColor == null)
				{
					r_textColor = new(this, "textColor", -1);
					r_textColor.SetBelong(this.instance);
				}
				return r_textColor;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D[] scaledBackgrounds
		/// </summary>
		protected RPropertyArray<RUnityEngine.RTexture2D> r_scaledBackgrounds;
		public virtual RPropertyArray<RUnityEngine.RTexture2D> RscaledBackgrounds
		{
			get
			{
				if(r_scaledBackgrounds == null)
				{
					r_scaledBackgrounds = new(this, "scaledBackgrounds", -1);
					r_scaledBackgrounds.SetBelong(this.instance);
				}
				return r_scaledBackgrounds;
			}
		}

		/// <summary>
		/// IntPtr Init()
		/// </summary>
		protected static RMethod r_Init;
		public static RMethod RInit
		{
			get
			{
				if(r_Init == null)
				{
					r_Init = new(typeof(UnityEngine.GUIStyleState), "Init", 0);
					r_Init.SetBelong(null);
				}
				return r_Init;
			}
		}

		/// <summary>
		/// Void Cleanup()
		/// </summary>
		protected RMethod r_Cleanup;
		public virtual RMethod RCleanup
		{
			get
			{
				if(r_Cleanup == null)
				{
					r_Cleanup = new(this, "Cleanup", 0);
					r_Cleanup.SetBelong(this.instance);
				}
				return r_Cleanup;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState ProduceGUIStyleStateFromDeserialization(UnityEngine.GUIStyle, IntPtr)
		/// </summary>
		protected static RMethod r_ProduceGUIStyleStateFromDeserialization_GUIStyle_IntPtr;
		public static RMethod RProduceGUIStyleStateFromDeserialization_GUIStyle_IntPtr
		{
			get
			{
				if(r_ProduceGUIStyleStateFromDeserialization_GUIStyle_IntPtr == null)
				{
					r_ProduceGUIStyleStateFromDeserialization_GUIStyle_IntPtr = new(typeof(UnityEngine.GUIStyleState), "ProduceGUIStyleStateFromDeserialization", 0, typeof(UnityEngine.GUIStyle), typeof(System.IntPtr));
					r_ProduceGUIStyleStateFromDeserialization_GUIStyle_IntPtr.SetBelong(null);
				}
				return r_ProduceGUIStyleStateFromDeserialization_GUIStyle_IntPtr;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle, IntPtr)
		/// </summary>
		protected static RMethod r_GetGUIStyleState_GUIStyle_IntPtr;
		public static RMethod RGetGUIStyleState_GUIStyle_IntPtr
		{
			get
			{
				if(r_GetGUIStyleState_GUIStyle_IntPtr == null)
				{
					r_GetGUIStyleState_GUIStyle_IntPtr = new(typeof(UnityEngine.GUIStyleState), "GetGUIStyleState", 0, typeof(UnityEngine.GUIStyle), typeof(System.IntPtr));
					r_GetGUIStyleState_GUIStyle_IntPtr.SetBelong(null);
				}
				return r_GetGUIStyleState_GUIStyle_IntPtr;
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
		/// Void get_textColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_get_textColor_Injected_Out_Color;
		public virtual RMethod Rget_textColor_Injected_Out_Color
		{
			get
			{
				if(r_get_textColor_Injected_Out_Color == null)
				{
					r_get_textColor_Injected_Out_Color = new(this, "get_textColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_get_textColor_Injected_Out_Color.SetBelong(this.instance);
				}
				return r_get_textColor_Injected_Out_Color;
			}
		}

		/// <summary>
		/// Void set_textColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_set_textColor_Injected_Ref_Color;
		public virtual RMethod Rset_textColor_Injected_Ref_Color
		{
			get
			{
				if(r_set_textColor_Injected_Ref_Color == null)
				{
					r_set_textColor_Injected_Ref_Color = new(this, "set_textColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_set_textColor_Injected_Ref_Color.SetBelong(this.instance);
				}
				return r_set_textColor_Injected_Ref_Color;
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


        public RGUIStyleState() : base("UnityEngine.GUIStyleState")
        {
        }

        public RGUIStyleState(System.Object instance) : base("UnityEngine.GUIStyleState")
		{
            SetInstance(instance);
		}

        public RGUIStyleState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGUIStyleState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.IntPtr Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void Cleanup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCleanup.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.GUIStyleState ProduceGUIStyleStateFromDeserialization(UnityEngine.GUIStyle @sourceStyle, System.IntPtr @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceStyle, @source};
            var ___result = RProduceGUIStyleStateFromDeserialization_GUIStyle_IntPtr.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyleState)___result;
        }


        public static UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle @sourceStyle, System.IntPtr @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceStyle, @source};
            var ___result = RGetGUIStyleState_GUIStyle_IntPtr.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyleState)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void get_textColor_Injected(out UnityEngine.Color @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_textColor_Injected_Out_Color.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void set_textColor_Injected(ref UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_textColor_Injected_Ref_Color.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Color)___parameters[0];

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
