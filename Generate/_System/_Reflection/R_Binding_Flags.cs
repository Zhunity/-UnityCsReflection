
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Reflection.BindingFlags
	/// </summary>
    public partial class RBindingFlags : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.BindingFlags);
            }
        }

        public RBindingFlags() : base("System.Reflection.BindingFlags")
        {
        }

        public RBindingFlags(System.Object instance) : base("System.Reflection.BindingFlags")
		{
            SetInstance(instance);
		}

        public RBindingFlags(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBindingFlags(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// System.Reflection.BindingFlags Default
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FDefault;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFDefault
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
		/// System.Reflection.BindingFlags IgnoreCase
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FIgnoreCase;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFIgnoreCase
		{
			get
			{
				if(r_FIgnoreCase == null)
				{
					r_FIgnoreCase = new(Type, "IgnoreCase");
				}
				return r_FIgnoreCase;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags DeclaredOnly
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FDeclaredOnly;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFDeclaredOnly
		{
			get
			{
				if(r_FDeclaredOnly == null)
				{
					r_FDeclaredOnly = new(Type, "DeclaredOnly");
				}
				return r_FDeclaredOnly;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags Instance
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FInstance;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFInstance
		{
			get
			{
				if(r_FInstance == null)
				{
					r_FInstance = new(Type, "Instance");
				}
				return r_FInstance;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags Static
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FStatic;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFStatic
		{
			get
			{
				if(r_FStatic == null)
				{
					r_FStatic = new(Type, "Static");
				}
				return r_FStatic;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags Public
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FPublic;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFPublic
		{
			get
			{
				if(r_FPublic == null)
				{
					r_FPublic = new(Type, "Public");
				}
				return r_FPublic;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags NonPublic
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FNonPublic;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFNonPublic
		{
			get
			{
				if(r_FNonPublic == null)
				{
					r_FNonPublic = new(Type, "NonPublic");
				}
				return r_FNonPublic;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags FlattenHierarchy
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FFlattenHierarchy;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFFlattenHierarchy
		{
			get
			{
				if(r_FFlattenHierarchy == null)
				{
					r_FFlattenHierarchy = new(Type, "FlattenHierarchy");
				}
				return r_FFlattenHierarchy;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags InvokeMethod
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FInvokeMethod;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFInvokeMethod
		{
			get
			{
				if(r_FInvokeMethod == null)
				{
					r_FInvokeMethod = new(Type, "InvokeMethod");
				}
				return r_FInvokeMethod;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags CreateInstance
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FCreateInstance;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFCreateInstance
		{
			get
			{
				if(r_FCreateInstance == null)
				{
					r_FCreateInstance = new(Type, "CreateInstance");
				}
				return r_FCreateInstance;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags GetField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FGetField;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFGetField
		{
			get
			{
				if(r_FGetField == null)
				{
					r_FGetField = new(Type, "GetField");
				}
				return r_FGetField;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags SetField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FSetField;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFSetField
		{
			get
			{
				if(r_FSetField == null)
				{
					r_FSetField = new(Type, "SetField");
				}
				return r_FSetField;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags GetProperty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FGetProperty;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFGetProperty
		{
			get
			{
				if(r_FGetProperty == null)
				{
					r_FGetProperty = new(Type, "GetProperty");
				}
				return r_FGetProperty;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags SetProperty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FSetProperty;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFSetProperty
		{
			get
			{
				if(r_FSetProperty == null)
				{
					r_FSetProperty = new(Type, "SetProperty");
				}
				return r_FSetProperty;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags PutDispProperty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FPutDispProperty;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFPutDispProperty
		{
			get
			{
				if(r_FPutDispProperty == null)
				{
					r_FPutDispProperty = new(Type, "PutDispProperty");
				}
				return r_FPutDispProperty;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags PutRefDispProperty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FPutRefDispProperty;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFPutRefDispProperty
		{
			get
			{
				if(r_FPutRefDispProperty == null)
				{
					r_FPutRefDispProperty = new(Type, "PutRefDispProperty");
				}
				return r_FPutRefDispProperty;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags ExactBinding
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FExactBinding;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFExactBinding
		{
			get
			{
				if(r_FExactBinding == null)
				{
					r_FExactBinding = new(Type, "ExactBinding");
				}
				return r_FExactBinding;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags SuppressChangeType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FSuppressChangeType;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFSuppressChangeType
		{
			get
			{
				if(r_FSuppressChangeType == null)
				{
					r_FSuppressChangeType = new(Type, "SuppressChangeType");
				}
				return r_FSuppressChangeType;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags OptionalParamBinding
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FOptionalParamBinding;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFOptionalParamBinding
		{
			get
			{
				if(r_FOptionalParamBinding == null)
				{
					r_FOptionalParamBinding = new(Type, "OptionalParamBinding");
				}
				return r_FOptionalParamBinding;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags IgnoreReturn
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FIgnoreReturn;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFIgnoreReturn
		{
			get
			{
				if(r_FIgnoreReturn == null)
				{
					r_FIgnoreReturn = new(Type, "IgnoreReturn");
				}
				return r_FIgnoreReturn;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags DoNotWrapExceptions
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FDoNotWrapExceptions;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFDoNotWrapExceptions
		{
			get
			{
				if(r_FDoNotWrapExceptions == null)
				{
					r_FDoNotWrapExceptions = new(Type, "DoNotWrapExceptions");
				}
				return r_FDoNotWrapExceptions;
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
