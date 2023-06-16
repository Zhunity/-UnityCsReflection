
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.EventCategory
	/// </summary>
    public partial class REventCategory : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory");
            }
        }

        public REventCategory() : base("UnityEngine.UIElements.EventCategory")
        {
        }

        public REventCategory(System.Object instance) : base("UnityEngine.UIElements.EventCategory")
		{
            SetInstance(instance);
		}

        public REventCategory(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventCategory(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory Default
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FDefault;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFDefault
		{
			get
			{
				if(r_FDefault == null)
				{
					r_FDefault = new(Type, "Default");
				}
				return r_FDefault;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory Pointer
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FPointer;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFPointer
		{
			get
			{
				if(r_FPointer == null)
				{
					r_FPointer = new(Type, "Pointer");
				}
				return r_FPointer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory PointerMove
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FPointerMove;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFPointerMove
		{
			get
			{
				if(r_FPointerMove == null)
				{
					r_FPointerMove = new(Type, "PointerMove");
				}
				return r_FPointerMove;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory EnterLeave
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FEnterLeave;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFEnterLeave
		{
			get
			{
				if(r_FEnterLeave == null)
				{
					r_FEnterLeave = new(Type, "EnterLeave");
				}
				return r_FEnterLeave;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory EnterLeaveWindow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FEnterLeaveWindow;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFEnterLeaveWindow
		{
			get
			{
				if(r_FEnterLeaveWindow == null)
				{
					r_FEnterLeaveWindow = new(Type, "EnterLeaveWindow");
				}
				return r_FEnterLeaveWindow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory Keyboard
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FKeyboard;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFKeyboard
		{
			get
			{
				if(r_FKeyboard == null)
				{
					r_FKeyboard = new(Type, "Keyboard");
				}
				return r_FKeyboard;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory Geometry
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FGeometry;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFGeometry
		{
			get
			{
				if(r_FGeometry == null)
				{
					r_FGeometry = new(Type, "Geometry");
				}
				return r_FGeometry;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory Style
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FStyle;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFStyle
		{
			get
			{
				if(r_FStyle == null)
				{
					r_FStyle = new(Type, "Style");
				}
				return r_FStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory ChangeValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FChangeValue;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFChangeValue
		{
			get
			{
				if(r_FChangeValue == null)
				{
					r_FChangeValue = new(Type, "ChangeValue");
				}
				return r_FChangeValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory Bind
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FBind;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFBind
		{
			get
			{
				if(r_FBind == null)
				{
					r_FBind = new(Type, "Bind");
				}
				return r_FBind;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory Focus
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FFocus;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFFocus
		{
			get
			{
				if(r_FFocus == null)
				{
					r_FFocus = new(Type, "Focus");
				}
				return r_FFocus;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory ChangePanel
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FChangePanel;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFChangePanel
		{
			get
			{
				if(r_FChangePanel == null)
				{
					r_FChangePanel = new(Type, "ChangePanel");
				}
				return r_FChangePanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory StyleTransition
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FStyleTransition;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFStyleTransition
		{
			get
			{
				if(r_FStyleTransition == null)
				{
					r_FStyleTransition = new(Type, "StyleTransition");
				}
				return r_FStyleTransition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory Navigation
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FNavigation;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFNavigation
		{
			get
			{
				if(r_FNavigation == null)
				{
					r_FNavigation = new(Type, "Navigation");
				}
				return r_FNavigation;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory Command
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FCommand;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFCommand
		{
			get
			{
				if(r_FCommand == null)
				{
					r_FCommand = new(Type, "Command");
				}
				return r_FCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory Tooltip
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FTooltip;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFTooltip
		{
			get
			{
				if(r_FTooltip == null)
				{
					r_FTooltip = new(Type, "Tooltip");
				}
				return r_FTooltip;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory IMGUI
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_FIMGUI;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RFIMGUI
		{
			get
			{
				if(r_FIMGUI == null)
				{
					r_FIMGUI = new(Type, "IMGUI");
				}
				return r_FIMGUI;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
				}
				return r_MGetValue;
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
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
				}
				return r_MGetTypeCode;
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
				}
				return r_MMemberwiseClone;
			}
		}


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
