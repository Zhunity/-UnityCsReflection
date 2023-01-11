using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.SByte
	/// </summary>
    public partial class RSByte : RMember //
    {

		/// <summary>
		/// System.SByte m_value
		/// </summary>
		protected RSystem.RSByte r_m_value;
		public virtual RSystem.RSByte Rm_value
		{
			get
			{
				if(r_m_value == null)
				{
					r_m_value = new(this, "m_value");
					r_m_value.SetBelong(this.instance);
				}
				return r_m_value;
			}
		}

		/// <summary>
		/// System.SByte MaxValue
		/// </summary>
		protected static RSystem.RSByte r_MaxValue;
		public static RSystem.RSByte RMaxValue
		{
			get
			{
				if(r_MaxValue == null)
				{
					r_MaxValue = new(typeof(System.SByte), "MaxValue");
					r_MaxValue.SetBelong(null);
				}
				return r_MaxValue;
			}
		}

		/// <summary>
		/// System.SByte MinValue
		/// </summary>
		protected static RSystem.RSByte r_MinValue;
		public static RSystem.RSByte RMinValue
		{
			get
			{
				if(r_MinValue == null)
				{
					r_MinValue = new(typeof(System.SByte), "MinValue");
					r_MinValue.SetBelong(null);
				}
				return r_MinValue;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_CompareTo_Object;
		public virtual RMethod RCompareTo_Object
		{
			get
			{
				if(r_CompareTo_Object == null)
				{
					r_CompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_CompareTo_Object.SetBelong(this.instance);
				}
				return r_CompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 CompareTo(SByte)
		/// </summary>
		protected RMethod r_CompareTo_SByte;
		public virtual RMethod RCompareTo_SByte
		{
			get
			{
				if(r_CompareTo_SByte == null)
				{
					r_CompareTo_SByte = new(this, "CompareTo", 0, typeof(System.SByte));
					r_CompareTo_SByte.SetBelong(this.instance);
				}
				return r_CompareTo_SByte;
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
		/// Boolean Equals(SByte)
		/// </summary>
		protected RMethod r_Equals_SByte;
		public virtual RMethod REquals_SByte
		{
			get
			{
				if(r_Equals_SByte == null)
				{
					r_Equals_SByte = new(this, "Equals", 0, typeof(System.SByte));
					r_Equals_SByte.SetBelong(this.instance);
				}
				return r_Equals_SByte;
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
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToString_IFormatProvider;
		public virtual RMethod RToString_IFormatProvider
		{
			get
			{
				if(r_ToString_IFormatProvider == null)
				{
					r_ToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
					r_ToString_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToString_IFormatProvider;
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
		/// Boolean TryFormat(System.Span`1[System.Char], Int32 ByRef, System.ReadOnlySpan`1[System.Char], System.IFormatProvider)
		/// </summary>
		protected RMethod r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
		public virtual RMethod RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider
		{
			get
			{
				if(r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider == null)
				{
					r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider = new(this, "TryFormat", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider));
					r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.SetBelong(this.instance);
				}
				return r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// SByte Parse(System.String)
		/// </summary>
		protected static RMethod r_Parse_String;
		public static RMethod RParse_String
		{
			get
			{
				if(r_Parse_String == null)
				{
					r_Parse_String = new(typeof(System.SByte), "Parse", 0, typeof(System.String));
					r_Parse_String.SetBelong(null);
				}
				return r_Parse_String;
			}
		}

		/// <summary>
		/// SByte Parse(System.String, System.Globalization.NumberStyles)
		/// </summary>
		protected static RMethod r_Parse_String_NumberStyles;
		public static RMethod RParse_String_NumberStyles
		{
			get
			{
				if(r_Parse_String_NumberStyles == null)
				{
					r_Parse_String_NumberStyles = new(typeof(System.SByte), "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles));
					r_Parse_String_NumberStyles.SetBelong(null);
				}
				return r_Parse_String_NumberStyles;
			}
		}

		/// <summary>
		/// SByte Parse(System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_Parse_String_IFormatProvider;
		public static RMethod RParse_String_IFormatProvider
		{
			get
			{
				if(r_Parse_String_IFormatProvider == null)
				{
					r_Parse_String_IFormatProvider = new(typeof(System.SByte), "Parse", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_Parse_String_IFormatProvider.SetBelong(null);
				}
				return r_Parse_String_IFormatProvider;
			}
		}

		/// <summary>
		/// SByte Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_Parse_String_NumberStyles_IFormatProvider;
		public static RMethod RParse_String_NumberStyles_IFormatProvider
		{
			get
			{
				if(r_Parse_String_NumberStyles_IFormatProvider == null)
				{
					r_Parse_String_NumberStyles_IFormatProvider = new(typeof(System.SByte), "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider));
					r_Parse_String_NumberStyles_IFormatProvider.SetBelong(null);
				}
				return r_Parse_String_NumberStyles_IFormatProvider;
			}
		}

		/// <summary>
		/// SByte Parse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider;
		public static RMethod RParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider
		{
			get
			{
				if(r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider == null)
				{
					r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider = new(typeof(System.SByte), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider));
					r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider.SetBelong(null);
				}
				return r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider;
			}
		}

		/// <summary>
		/// SByte Parse(System.String, System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo)
		/// </summary>
		protected static RMethod r_Parse_String_NumberStyles_NumberFormatInfo;
		public static RMethod RParse_String_NumberStyles_NumberFormatInfo
		{
			get
			{
				if(r_Parse_String_NumberStyles_NumberFormatInfo == null)
				{
					r_Parse_String_NumberStyles_NumberFormatInfo = new(typeof(System.SByte), "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.Globalization.NumberFormatInfo));
					r_Parse_String_NumberStyles_NumberFormatInfo.SetBelong(null);
				}
				return r_Parse_String_NumberStyles_NumberFormatInfo;
			}
		}

		/// <summary>
		/// SByte Parse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo)
		/// </summary>
		protected static RMethod r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo;
		public static RMethod RParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo
		{
			get
			{
				if(r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo == null)
				{
					r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo = new(typeof(System.SByte), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.Globalization.NumberFormatInfo));
					r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo.SetBelong(null);
				}
				return r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, SByte ByRef)
		/// </summary>
		protected static RMethod r_TryParse_String_Out_SByte;
		public static RMethod RTryParse_String_Out_SByte
		{
			get
			{
				if(r_TryParse_String_Out_SByte == null)
				{
					r_TryParse_String_Out_SByte = new(typeof(System.SByte), "TryParse", 0, typeof(System.String), typeof(System.SByte).MakeByRefType());
					r_TryParse_String_Out_SByte.SetBelong(null);
				}
				return r_TryParse_String_Out_SByte;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], SByte ByRef)
		/// </summary>
		protected static RMethod r_TryParse_ReadOnlySpan_d_Char_p__Out_SByte;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__Out_SByte
		{
			get
			{
				if(r_TryParse_ReadOnlySpan_d_Char_p__Out_SByte == null)
				{
					r_TryParse_ReadOnlySpan_d_Char_p__Out_SByte = new(typeof(System.SByte), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.SByte).MakeByRefType());
					r_TryParse_ReadOnlySpan_d_Char_p__Out_SByte.SetBelong(null);
				}
				return r_TryParse_ReadOnlySpan_d_Char_p__Out_SByte;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Globalization.NumberStyles, System.IFormatProvider, SByte ByRef)
		/// </summary>
		protected static RMethod r_TryParse_String_NumberStyles_IFormatProvider_Out_SByte;
		public static RMethod RTryParse_String_NumberStyles_IFormatProvider_Out_SByte
		{
			get
			{
				if(r_TryParse_String_NumberStyles_IFormatProvider_Out_SByte == null)
				{
					r_TryParse_String_NumberStyles_IFormatProvider_Out_SByte = new(typeof(System.SByte), "TryParse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.SByte).MakeByRefType());
					r_TryParse_String_NumberStyles_IFormatProvider_Out_SByte.SetBelong(null);
				}
				return r_TryParse_String_NumberStyles_IFormatProvider_Out_SByte;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider, SByte ByRef)
		/// </summary>
		protected static RMethod r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_SByte;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_SByte
		{
			get
			{
				if(r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_SByte == null)
				{
					r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_SByte = new(typeof(System.SByte), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.SByte).MakeByRefType());
					r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_SByte.SetBelong(null);
				}
				return r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_SByte;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, SByte ByRef)
		/// </summary>
		protected static RMethod r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_SByte;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_SByte
		{
			get
			{
				if(r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_SByte == null)
				{
					r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_SByte = new(typeof(System.SByte), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.Globalization.NumberFormatInfo), typeof(System.SByte).MakeByRefType());
					r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_SByte.SetBelong(null);
				}
				return r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_SByte;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_GetTypeCode;
		public virtual RMethod RGetTypeCode
		{
			get
			{
				if(r_GetTypeCode == null)
				{
					r_GetTypeCode = new(this, "GetTypeCode", 0);
					r_GetTypeCode.SetBelong(this.instance);
				}
				return r_GetTypeCode;
			}
		}

		/// <summary>
		/// Boolean System.IConvertible.ToBoolean(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToBoolean_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToBoolean_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToBoolean_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToBoolean_IFormatProvider = new(this, "System.IConvertible.ToBoolean", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToBoolean_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToBoolean_IFormatProvider;
			}
		}

		/// <summary>
		/// Char System.IConvertible.ToChar(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToChar_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToChar_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToChar_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToChar_IFormatProvider = new(this, "System.IConvertible.ToChar", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToChar_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToChar_IFormatProvider;
			}
		}

		/// <summary>
		/// SByte System.IConvertible.ToSByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToSByte_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToSByte_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToSByte_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToSByte_IFormatProvider = new(this, "System.IConvertible.ToSByte", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToSByte_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToSByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Byte System.IConvertible.ToByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToByte_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToByte_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToByte_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToByte_IFormatProvider = new(this, "System.IConvertible.ToByte", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToByte_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Int16 System.IConvertible.ToInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToInt16_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToInt16_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToInt16_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToInt16_IFormatProvider = new(this, "System.IConvertible.ToInt16", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToInt16_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt16 System.IConvertible.ToUInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToUInt16_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToUInt16_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToUInt16_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToUInt16_IFormatProvider = new(this, "System.IConvertible.ToUInt16", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToUInt16_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToUInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 System.IConvertible.ToInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToInt32_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToInt32_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToInt32_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToInt32_IFormatProvider = new(this, "System.IConvertible.ToInt32", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToInt32_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt32 System.IConvertible.ToUInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToUInt32_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToUInt32_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToUInt32_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToUInt32_IFormatProvider = new(this, "System.IConvertible.ToUInt32", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToUInt32_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToUInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// Int64 System.IConvertible.ToInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToInt64_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToInt64_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToInt64_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToInt64_IFormatProvider = new(this, "System.IConvertible.ToInt64", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToInt64_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt64 System.IConvertible.ToUInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToUInt64_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToUInt64_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToUInt64_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToUInt64_IFormatProvider = new(this, "System.IConvertible.ToUInt64", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToUInt64_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToUInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// Single System.IConvertible.ToSingle(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToSingle_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToSingle_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToSingle_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToSingle_IFormatProvider = new(this, "System.IConvertible.ToSingle", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToSingle_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToSingle_IFormatProvider;
			}
		}

		/// <summary>
		/// Double System.IConvertible.ToDouble(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToDouble_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToDouble_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToDouble_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToDouble_IFormatProvider = new(this, "System.IConvertible.ToDouble", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToDouble_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToDouble_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Decimal System.IConvertible.ToDecimal(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToDecimal_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToDecimal_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToDecimal_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToDecimal_IFormatProvider = new(this, "System.IConvertible.ToDecimal", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToDecimal_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToDecimal_IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToDateTime_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToDateTime_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToDateTime_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToDateTime_IFormatProvider = new(this, "System.IConvertible.ToDateTime", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToDateTime_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToDateTime_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Object System.IConvertible.ToType(System.Type, System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToType_Type_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToType_Type_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToType_Type_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToType_Type_IFormatProvider = new(this, "System.IConvertible.ToType", 0, typeof(System.Type), typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToType_Type_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToType_Type_IFormatProvider;
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


        public RSByte() : base("System.SByte")
        {
        }

        public RSByte(System.Object instance) : base("System.SByte")
		{
            SetInstance(instance);
		}

        public RSByte(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSByte(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 CompareTo(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.SByte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_SByte.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.SByte @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_SByte.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryFormat(RSystem.RSpan<RSystem.RChar> @destination, out System.Int32 @charsWritten, RSystem.RReadOnlySpan<RSystem.RChar> @format, System.IFormatProvider @provider)
        {
			@charsWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @charsWritten, @format.Value, @provider};
            var ___result = RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.Invoke(___genericsType, ___parameters);
			@charsWritten = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.SByte Parse(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public static System.SByte Parse(System.String @s, System.Globalization.NumberStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style};
            var ___result = RParse_String_NumberStyles.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public static System.SByte Parse(System.String @s, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @provider};
            var ___result = RParse_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public static System.SByte Parse(System.String @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider};
            var ___result = RParse_String_NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public static System.SByte Parse(RSystem.RReadOnlySpan<RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @provider};
            var ___result = RParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public static System.SByte Parse(System.String @s, System.Globalization.NumberStyles @style, System.Globalization.NumberFormatInfo @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @info};
            var ___result = RParse_String_NumberStyles_NumberFormatInfo.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public static System.SByte Parse(RSystem.RReadOnlySpan<RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.Globalization.NumberFormatInfo @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @info};
            var ___result = RParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public static System.Boolean TryParse(System.String @s, out System.SByte @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RTryParse_String_Out_SByte.Invoke(___genericsType, ___parameters);
			@result = (System.SByte)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(RSystem.RReadOnlySpan<RSystem.RChar> @s, out System.SByte @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @result};
            var ___result = RTryParse_ReadOnlySpan_d_Char_p__Out_SByte.Invoke(___genericsType, ___parameters);
			@result = (System.SByte)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(System.String @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider, out System.SByte @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider, @result};
            var ___result = RTryParse_String_NumberStyles_IFormatProvider_Out_SByte.Invoke(___genericsType, ___parameters);
			@result = (System.SByte)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(RSystem.RReadOnlySpan<RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider, out System.SByte @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @provider, @result};
            var ___result = RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_SByte.Invoke(___genericsType, ___parameters);
			@result = (System.SByte)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(RSystem.RReadOnlySpan<RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.Globalization.NumberFormatInfo @info, out System.SByte @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @info, @result};
            var ___result = RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_SByte.Invoke(___genericsType, ___parameters);
			@result = (System.SByte)___parameters[3];

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public virtual System.Boolean System__2__IConvertible__2__ToBoolean(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToBoolean_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char System__2__IConvertible__2__ToChar(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToChar_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.SByte System__2__IConvertible__2__ToSByte(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToSByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public virtual System.Byte System__2__IConvertible__2__ToByte(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Int16 System__2__IConvertible__2__ToInt16(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public virtual System.UInt16 System__2__IConvertible__2__ToUInt16(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToUInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual System.Int32 System__2__IConvertible__2__ToInt32(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.UInt32 System__2__IConvertible__2__ToUInt32(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToUInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int64 System__2__IConvertible__2__ToInt64(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.UInt64 System__2__IConvertible__2__ToUInt64(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToUInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Single System__2__IConvertible__2__ToSingle(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToSingle_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Double System__2__IConvertible__2__ToDouble(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToDouble_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Decimal System__2__IConvertible__2__ToDecimal(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToDecimal_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.DateTime System__2__IConvertible__2__ToDateTime(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToDateTime_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.Object System__2__IConvertible__2__ToType(System.Type @type, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @provider};
            var ___result = RSystem__2__IConvertible__2__ToType_Type_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
