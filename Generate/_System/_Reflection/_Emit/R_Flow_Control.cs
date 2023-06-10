
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.FlowControl
	/// </summary>
    public partial class RFlowControl : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.Emit.FlowControl);
            }
        }

        public RFlowControl() : base("System.Reflection.Emit.FlowControl")
        {
        }

        public RFlowControl(System.Object instance) : base("System.Reflection.Emit.FlowControl")
		{
            SetInstance(instance);
		}

        public RFlowControl(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFlowControl(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// System.Reflection.Emit.FlowControl Branch
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl r_FBranch;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl RFBranch
		{
			get
			{
				if(r_FBranch == null)
				{
					r_FBranch = new(typeof(System.Reflection.Emit.FlowControl), "Branch");
				}
				return r_FBranch;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FlowControl Break
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl r_FBreak;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl RFBreak
		{
			get
			{
				if(r_FBreak == null)
				{
					r_FBreak = new(typeof(System.Reflection.Emit.FlowControl), "Break");
				}
				return r_FBreak;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FlowControl Call
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl r_FCall;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl RFCall
		{
			get
			{
				if(r_FCall == null)
				{
					r_FCall = new(typeof(System.Reflection.Emit.FlowControl), "Call");
				}
				return r_FCall;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FlowControl Cond_Branch
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl r_FCond_Branch;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl RFCond_Branch
		{
			get
			{
				if(r_FCond_Branch == null)
				{
					r_FCond_Branch = new(typeof(System.Reflection.Emit.FlowControl), "Cond_Branch");
				}
				return r_FCond_Branch;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FlowControl Meta
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl r_FMeta;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl RFMeta
		{
			get
			{
				if(r_FMeta == null)
				{
					r_FMeta = new(typeof(System.Reflection.Emit.FlowControl), "Meta");
				}
				return r_FMeta;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FlowControl Next
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl r_FNext;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl RFNext
		{
			get
			{
				if(r_FNext == null)
				{
					r_FNext = new(typeof(System.Reflection.Emit.FlowControl), "Next");
				}
				return r_FNext;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FlowControl Phi
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl r_FPhi;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl RFPhi
		{
			get
			{
				if(r_FPhi == null)
				{
					r_FPhi = new(typeof(System.Reflection.Emit.FlowControl), "Phi");
				}
				return r_FPhi;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FlowControl Return
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl r_FReturn;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl RFReturn
		{
			get
			{
				if(r_FReturn == null)
				{
					r_FReturn = new(typeof(System.Reflection.Emit.FlowControl), "Return");
				}
				return r_FReturn;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FlowControl Throw
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl r_FThrow;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl RFThrow
		{
			get
			{
				if(r_FThrow == null)
				{
					r_FThrow = new(typeof(System.Reflection.Emit.FlowControl), "Throw");
				}
				return r_FThrow;
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

            return (System.Object)___result;
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
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
