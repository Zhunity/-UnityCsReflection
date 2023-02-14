
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.EncoderNLS
	/// </summary>
    public partial class REncoderNLS : RMember //
    {

		/// <summary>
		/// System.Char _charLeftOver
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RChar r_F_charLeftOver;
		public virtual Hvak.Editor.Refleaction.RSystem.RChar RF_charLeftOver
		{
			get
			{
				if(r_F_charLeftOver == null)
				{
					r_F_charLeftOver = new(this, "_charLeftOver");
					r_F_charLeftOver.SetBelong(this.instance);
				}
				return r_F_charLeftOver;
			}
		}

		/// <summary>
		/// System.Text.Encoding _encoding
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.REncoding r_F_encoding;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.REncoding RF_encoding
		{
			get
			{
				if(r_F_encoding == null)
				{
					r_F_encoding = new(this, "_encoding");
					r_F_encoding.SetBelong(this.instance);
				}
				return r_F_encoding;
			}
		}

		/// <summary>
		/// System.Boolean _mustFlush
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_mustFlush;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_mustFlush
		{
			get
			{
				if(r_F_mustFlush == null)
				{
					r_F_mustFlush = new(this, "_mustFlush");
					r_F_mustFlush.SetBelong(this.instance);
				}
				return r_F_mustFlush;
			}
		}

		/// <summary>
		/// System.Boolean _throwOnOverflow
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_throwOnOverflow;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_throwOnOverflow
		{
			get
			{
				if(r_F_throwOnOverflow == null)
				{
					r_F_throwOnOverflow = new(this, "_throwOnOverflow");
					r_F_throwOnOverflow.SetBelong(this.instance);
				}
				return r_F_throwOnOverflow;
			}
		}

		/// <summary>
		/// System.Int32 _charsUsed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_charsUsed;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_charsUsed
		{
			get
			{
				if(r_F_charsUsed == null)
				{
					r_F_charsUsed = new(this, "_charsUsed");
					r_F_charsUsed.SetBelong(this.instance);
				}
				return r_F_charsUsed;
			}
		}

		/// <summary>
		/// System.Text.EncoderFallback _fallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.REncoderFallback r_F_fallback;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.REncoderFallback RF_fallback
		{
			get
			{
				if(r_F_fallback == null)
				{
					r_F_fallback = new(this, "_fallback");
					r_F_fallback.SetBelong(this.instance);
				}
				return r_F_fallback;
			}
		}

		/// <summary>
		/// System.Text.EncoderFallbackBuffer _fallbackBuffer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.REncoderFallbackBuffer r_F_fallbackBuffer;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.REncoderFallbackBuffer RF_fallbackBuffer
		{
			get
			{
				if(r_F_fallbackBuffer == null)
				{
					r_F_fallbackBuffer = new(this, "_fallbackBuffer");
					r_F_fallbackBuffer.SetBelong(this.instance);
				}
				return r_F_fallbackBuffer;
			}
		}

		/// <summary>
		/// System.Text.Encoding Encoding
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.REncoding r_PEncoding;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.REncoding RPEncoding
		{
			get
			{
				if(r_PEncoding == null)
				{
					r_PEncoding = new(this, "Encoding", -1);
					r_PEncoding.SetBelong(this.instance);
				}
				return r_PEncoding;
			}
		}

		/// <summary>
		/// Boolean MustFlush
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PMustFlush;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPMustFlush
		{
			get
			{
				if(r_PMustFlush == null)
				{
					r_PMustFlush = new(this, "MustFlush", -1);
					r_PMustFlush.SetBelong(this.instance);
				}
				return r_PMustFlush;
			}
		}

		/// <summary>
		/// Boolean HasState
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasState;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasState
		{
			get
			{
				if(r_PHasState == null)
				{
					r_PHasState = new(this, "HasState", -1);
					r_PHasState.SetBelong(this.instance);
				}
				return r_PHasState;
			}
		}

		/// <summary>
		/// System.Text.EncoderFallback Fallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.REncoderFallback r_PFallback;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.REncoderFallback RPFallback
		{
			get
			{
				if(r_PFallback == null)
				{
					r_PFallback = new(this, "Fallback", -1);
					r_PFallback.SetBelong(this.instance);
				}
				return r_PFallback;
			}
		}

		/// <summary>
		/// System.Text.EncoderFallbackBuffer FallbackBuffer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.REncoderFallbackBuffer r_PFallbackBuffer;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.REncoderFallbackBuffer RPFallbackBuffer
		{
			get
			{
				if(r_PFallbackBuffer == null)
				{
					r_PFallbackBuffer = new(this, "FallbackBuffer", -1);
					r_PFallbackBuffer.SetBelong(this.instance);
				}
				return r_PFallbackBuffer;
			}
		}

		/// <summary>
		/// Boolean InternalHasFallbackBuffer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PInternalHasFallbackBuffer;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPInternalHasFallbackBuffer
		{
			get
			{
				if(r_PInternalHasFallbackBuffer == null)
				{
					r_PInternalHasFallbackBuffer = new(this, "InternalHasFallbackBuffer", -1);
					r_PInternalHasFallbackBuffer.SetBelong(this.instance);
				}
				return r_PInternalHasFallbackBuffer;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
					r_MReset.SetBelong(this.instance);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char[], Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetByteCount_CharArray_Int32_Int32_Boolean;
		public virtual RMethod RMGetByteCount_CharArray_Int32_Int32_Boolean
		{
			get
			{
				if(r_MGetByteCount_CharArray_Int32_Int32_Boolean == null)
				{
					r_MGetByteCount_CharArray_Int32_Int32_Boolean = new(this, "GetByteCount", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_MGetByteCount_CharArray_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_MGetByteCount_CharArray_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char*, Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetByteCount_CharPointer_Int32_Boolean;
		public virtual RMethod RMGetByteCount_CharPointer_Int32_Boolean
		{
			get
			{
				if(r_MGetByteCount_CharPointer_Int32_Boolean == null)
				{
					r_MGetByteCount_CharPointer_Int32_Boolean = new(this, "GetByteCount", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
					r_MGetByteCount_CharPointer_Int32_Boolean.SetBelong(this.instance);
				}
				return r_MGetByteCount_CharPointer_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetBytes(Char[], Int32, Int32, Byte[], Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetBytes_CharArray_Int32_Int32_ByteArray_Int32_Boolean;
		public virtual RMethod RMGetBytes_CharArray_Int32_Int32_ByteArray_Int32_Boolean
		{
			get
			{
				if(r_MGetBytes_CharArray_Int32_Int32_ByteArray_Int32_Boolean == null)
				{
					r_MGetBytes_CharArray_Int32_Int32_ByteArray_Int32_Boolean = new(this, "GetBytes", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_MGetBytes_CharArray_Int32_Int32_ByteArray_Int32_Boolean.SetBelong(this.instance);
				}
				return r_MGetBytes_CharArray_Int32_Int32_ByteArray_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetBytes(Char*, Int32, Byte*, Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetBytes_CharPointer_Int32_BytePointer_Int32_Boolean;
		public virtual RMethod RMGetBytes_CharPointer_Int32_BytePointer_Int32_Boolean
		{
			get
			{
				if(r_MGetBytes_CharPointer_Int32_BytePointer_Int32_Boolean == null)
				{
					r_MGetBytes_CharPointer_Int32_BytePointer_Int32_Boolean = new(this, "GetBytes", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
					r_MGetBytes_CharPointer_Int32_BytePointer_Int32_Boolean.SetBelong(this.instance);
				}
				return r_MGetBytes_CharPointer_Int32_BytePointer_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Convert(Char[], Int32, Int32, Byte[], Int32, Int32, Boolean, Int32 ByRef, Int32 ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_MConvert_CharArray_Int32_Int32_ByteArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean;
		public virtual RMethod RMConvert_CharArray_Int32_Int32_ByteArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean
		{
			get
			{
				if(r_MConvert_CharArray_Int32_Int32_ByteArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean == null)
				{
					r_MConvert_CharArray_Int32_Int32_ByteArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean = new(this, "Convert", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_MConvert_CharArray_Int32_Int32_ByteArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean.SetBelong(this.instance);
				}
				return r_MConvert_CharArray_Int32_Int32_ByteArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean;
			}
		}

		/// <summary>
		/// Void Convert(Char*, Int32, Byte*, Int32, Boolean, Int32 ByRef, Int32 ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_MConvert_CharPointer_Int32_BytePointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean;
		public virtual RMethod RMConvert_CharPointer_Int32_BytePointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean
		{
			get
			{
				if(r_MConvert_CharPointer_Int32_BytePointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean == null)
				{
					r_MConvert_CharPointer_Int32_BytePointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean = new(this, "Convert", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_MConvert_CharPointer_Int32_BytePointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean.SetBelong(this.instance);
				}
				return r_MConvert_CharPointer_Int32_BytePointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean;
			}
		}

		/// <summary>
		/// Void ClearMustFlush()
		/// </summary>
		protected RMethod r_MClearMustFlush;
		public virtual RMethod RMClearMustFlush
		{
			get
			{
				if(r_MClearMustFlush == null)
				{
					r_MClearMustFlush = new(this, "ClearMustFlush", 0);
					r_MClearMustFlush.SetBelong(this.instance);
				}
				return r_MClearMustFlush;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(System.ReadOnlySpan`1[System.Char], Boolean)
		/// </summary>
		protected RMethod r_MGetByteCount_ReadOnlySpan_d_Char_p__Boolean;
		public virtual RMethod RMGetByteCount_ReadOnlySpan_d_Char_p__Boolean
		{
			get
			{
				if(r_MGetByteCount_ReadOnlySpan_d_Char_p__Boolean == null)
				{
					r_MGetByteCount_ReadOnlySpan_d_Char_p__Boolean = new(this, "GetByteCount", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_MGetByteCount_ReadOnlySpan_d_Char_p__Boolean.SetBelong(this.instance);
				}
				return r_MGetByteCount_ReadOnlySpan_d_Char_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 GetBytes(System.ReadOnlySpan`1[System.Char], System.Span`1[System.Byte], Boolean)
		/// </summary>
		protected RMethod r_MGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean;
		public virtual RMethod RMGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean
		{
			get
			{
				if(r_MGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean == null)
				{
					r_MGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean = new(this, "GetBytes", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Boolean));
					r_MGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean.SetBelong(this.instance);
				}
				return r_MGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean;
			}
		}

		/// <summary>
		/// Void Convert(System.ReadOnlySpan`1[System.Char], System.Span`1[System.Byte], Boolean, Int32 ByRef, Int32 ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_MConvert_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean_Out_Int32_Out_Int32_Out_Boolean;
		public virtual RMethod RMConvert_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean_Out_Int32_Out_Int32_Out_Boolean
		{
			get
			{
				if(r_MConvert_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean_Out_Int32_Out_Int32_Out_Boolean == null)
				{
					r_MConvert_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean_Out_Int32_Out_Int32_Out_Boolean = new(this, "Convert", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Boolean), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_MConvert_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean_Out_Int32_Out_Int32_Out_Boolean.SetBelong(this.instance);
				}
				return r_MConvert_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean_Out_Int32_Out_Int32_Out_Boolean;
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


        public REncoderNLS() : base("System.Text.EncoderNLS")
        {
        }

        public REncoderNLS(System.Object instance) : base("System.Text.EncoderNLS")
		{
            SetInstance(instance);
		}

        public REncoderNLS(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REncoderNLS(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetByteCount(System.Char[] @chars, System.Int32 @index, System.Int32 @count, System.Boolean @flush)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @index, @count, @flush};
            var ___result = RMGetByteCount_CharArray_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetByteCount(System.Char* @chars, System.Int32 @count, System.Boolean @flush)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@chars, typeof(System.Char)), @count, @flush};
            var ___result = RMGetByteCount_CharPointer_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetBytes(System.Char[] @chars, System.Int32 @charIndex, System.Int32 @charCount, System.Byte[] @bytes, System.Int32 @byteIndex, System.Boolean @flush)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @charIndex, @charCount, @bytes, @byteIndex, @flush};
            var ___result = RMGetBytes_CharArray_Int32_Int32_ByteArray_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetBytes(System.Char* @chars, System.Int32 @charCount, System.Byte* @bytes, System.Int32 @byteCount, System.Boolean @flush)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@chars, typeof(System.Char)), @charCount, Pointer.Box(@bytes, typeof(System.Byte)), @byteCount, @flush};
            var ___result = RMGetBytes_CharPointer_Int32_BytePointer_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Convert(System.Char[] @chars, System.Int32 @charIndex, System.Int32 @charCount, System.Byte[] @bytes, System.Int32 @byteIndex, System.Int32 @byteCount, System.Boolean @flush, out System.Int32 @charsUsed, out System.Int32 @bytesUsed, out System.Boolean @completed)
        {
			@charsUsed = default;
			@bytesUsed = default;
			@completed = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @charIndex, @charCount, @bytes, @byteIndex, @byteCount, @flush, @charsUsed, @bytesUsed, @completed};
            var ___result = RMConvert_CharArray_Int32_Int32_ByteArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean.Invoke(___genericsType, ___parameters);
			@charsUsed = (System.Int32)___parameters[7];
			@bytesUsed = (System.Int32)___parameters[8];
			@completed = (System.Boolean)___parameters[9];

            
        }


        public unsafe virtual void Convert(System.Char* @chars, System.Int32 @charCount, System.Byte* @bytes, System.Int32 @byteCount, System.Boolean @flush, out System.Int32 @charsUsed, out System.Int32 @bytesUsed, out System.Boolean @completed)
        {
			@charsUsed = default;
			@bytesUsed = default;
			@completed = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@chars, typeof(System.Char)), @charCount, Pointer.Box(@bytes, typeof(System.Byte)), @byteCount, @flush, @charsUsed, @bytesUsed, @completed};
            var ___result = RMConvert_CharPointer_Int32_BytePointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean.Invoke(___genericsType, ___parameters);
			@charsUsed = (System.Int32)___parameters[5];
			@bytesUsed = (System.Int32)___parameters[6];
			@completed = (System.Boolean)___parameters[7];

            
        }


        public virtual void ClearMustFlush()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearMustFlush.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetByteCount(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @chars, System.Boolean @flush)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars.Value, @flush};
            var ___result = RMGetByteCount_ReadOnlySpan_d_Char_p__Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetBytes(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @chars, Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RByte> @bytes, System.Boolean @flush)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars.Value, @bytes.Value, @flush};
            var ___result = RMGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Convert(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @chars, Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RByte> @bytes, System.Boolean @flush, out System.Int32 @charsUsed, out System.Int32 @bytesUsed, out System.Boolean @completed)
        {
			@charsUsed = default;
			@bytesUsed = default;
			@completed = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars.Value, @bytes.Value, @flush, @charsUsed, @bytesUsed, @completed};
            var ___result = RMConvert_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean_Out_Int32_Out_Int32_Out_Boolean.Invoke(___genericsType, ___parameters);
			@charsUsed = (System.Int32)___parameters[3];
			@bytesUsed = (System.Int32)___parameters[4];
			@completed = (System.Boolean)___parameters[5];

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
