using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.RawAcl
	/// </summary>
    public partial class RRawAcl : RMember //
    {

		/// <summary>
		/// System.Byte revision
		/// </summary>
		protected RField r_revision;
		public virtual RField Rrevision
		{
			get
			{
				if(r_revision == null)
				{
					r_revision = new(this, "revision");
					r_revision.SetBelong(this.instance);
				}
				return r_revision;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Security.AccessControl.GenericAce] list
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RSecurity.RAccessControl.RGenericAce> r_list;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RSecurity.RAccessControl.RGenericAce> Rlist
		{
			get
			{
				if(r_list == null)
				{
					r_list = new(this, "list");
					r_list.SetBelong(this.instance);
				}
				return r_list;
			}
		}

		/// <summary>
		/// Int32 BinaryLength
		/// </summary>
		protected RProperty r_BinaryLength;
		public virtual RProperty RBinaryLength
		{
			get
			{
				if(r_BinaryLength == null)
				{
					r_BinaryLength = new(this, "BinaryLength", -1);
					r_BinaryLength.SetBelong(this.instance);
				}
				return r_BinaryLength;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAce Item [Int32]
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RGenericAce r_Item_Int32;
		public virtual RSystem.RSecurity.RAccessControl.RGenericAce RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// Byte Revision
		/// </summary>
		protected RProperty r_Revision;
		public virtual RProperty RRevision
		{
			get
			{
				if(r_Revision == null)
				{
					r_Revision = new(this, "Revision", -1);
					r_Revision.SetBelong(this.instance);
				}
				return r_Revision;
			}
		}

		/// <summary>
		/// Boolean IsSynchronized
		/// </summary>
		protected RProperty r_IsSynchronized;
		public virtual RProperty RIsSynchronized
		{
			get
			{
				if(r_IsSynchronized == null)
				{
					r_IsSynchronized = new(this, "IsSynchronized", -1);
					r_IsSynchronized.SetBelong(this.instance);
				}
				return r_IsSynchronized;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected RSystem.RObject r_SyncRoot;
		public virtual RSystem.RObject RSyncRoot
		{
			get
			{
				if(r_SyncRoot == null)
				{
					r_SyncRoot = new(this, "SyncRoot", -1);
					r_SyncRoot.SetBelong(this.instance);
				}
				return r_SyncRoot;
			}
		}

		/// <summary>
		/// Void GetBinaryForm(Byte[], Int32)
		/// </summary>
		protected RMethod r_GetBinaryForm_ByteArray_Int32;
		public virtual RMethod RGetBinaryForm_ByteArray_Int32
		{
			get
			{
				if(r_GetBinaryForm_ByteArray_Int32 == null)
				{
					r_GetBinaryForm_ByteArray_Int32 = new(this, "GetBinaryForm", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_GetBinaryForm_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_GetBinaryForm_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Void InsertAce(Int32, System.Security.AccessControl.GenericAce)
		/// </summary>
		protected RMethod r_InsertAce_Int32_GenericAce;
		public virtual RMethod RInsertAce_Int32_GenericAce
		{
			get
			{
				if(r_InsertAce_Int32_GenericAce == null)
				{
					r_InsertAce_Int32_GenericAce = new(this, "InsertAce", 0, typeof(System.Int32), typeof(System.Security.AccessControl.GenericAce));
					r_InsertAce_Int32_GenericAce.SetBelong(this.instance);
				}
				return r_InsertAce_Int32_GenericAce;
			}
		}

		/// <summary>
		/// Void RemoveAce(Int32)
		/// </summary>
		protected RMethod r_RemoveAce_Int32;
		public virtual RMethod RRemoveAce_Int32
		{
			get
			{
				if(r_RemoveAce_Int32 == null)
				{
					r_RemoveAce_Int32 = new(this, "RemoveAce", 0, typeof(System.Int32));
					r_RemoveAce_Int32.SetBelong(this.instance);
				}
				return r_RemoveAce_Int32;
			}
		}

		/// <summary>
		/// System.String GetSddlForm(System.Security.AccessControl.ControlFlags, Boolean)
		/// </summary>
		protected RMethod r_GetSddlForm_ControlFlags_Boolean;
		public virtual RMethod RGetSddlForm_ControlFlags_Boolean
		{
			get
			{
				if(r_GetSddlForm_ControlFlags_Boolean == null)
				{
					r_GetSddlForm_ControlFlags_Boolean = new(this, "GetSddlForm", 0, typeof(System.Security.AccessControl.ControlFlags), typeof(System.Boolean));
					r_GetSddlForm_ControlFlags_Boolean.SetBelong(this.instance);
				}
				return r_GetSddlForm_ControlFlags_Boolean;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.RawAcl ParseSddlForm(System.String, Boolean, System.Security.AccessControl.ControlFlags ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_ParseSddlForm_String_Boolean_Ref_ControlFlags_Ref_Int32;
		public static RMethod RParseSddlForm_String_Boolean_Ref_ControlFlags_Ref_Int32
		{
			get
			{
				if(r_ParseSddlForm_String_Boolean_Ref_ControlFlags_Ref_Int32 == null)
				{
					r_ParseSddlForm_String_Boolean_Ref_ControlFlags_Ref_Int32 = new(typeof(System.Security.AccessControl.RawAcl), "ParseSddlForm", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Security.AccessControl.ControlFlags).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_ParseSddlForm_String_Boolean_Ref_ControlFlags_Ref_Int32.SetBelong(null);
				}
				return r_ParseSddlForm_String_Boolean_Ref_ControlFlags_Ref_Int32;
			}
		}

		/// <summary>
		/// Void ParseFlags(System.String, Boolean, System.Security.AccessControl.ControlFlags ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_ParseFlags_String_Boolean_Ref_ControlFlags_Ref_Int32;
		public static RMethod RParseFlags_String_Boolean_Ref_ControlFlags_Ref_Int32
		{
			get
			{
				if(r_ParseFlags_String_Boolean_Ref_ControlFlags_Ref_Int32 == null)
				{
					r_ParseFlags_String_Boolean_Ref_ControlFlags_Ref_Int32 = new(typeof(System.Security.AccessControl.RawAcl), "ParseFlags", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Security.AccessControl.ControlFlags).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_ParseFlags_String_Boolean_Ref_ControlFlags_Ref_Int32.SetBelong(null);
				}
				return r_ParseFlags_String_Boolean_Ref_ControlFlags_Ref_Int32;
			}
		}

		/// <summary>
		/// Void WriteUShort(UInt16, Byte[], Int32)
		/// </summary>
		protected RMethod r_WriteUShort_UInt16_ByteArray_Int32;
		public virtual RMethod RWriteUShort_UInt16_ByteArray_Int32
		{
			get
			{
				if(r_WriteUShort_UInt16_ByteArray_Int32 == null)
				{
					r_WriteUShort_UInt16_ByteArray_Int32 = new(this, "WriteUShort", 0, typeof(System.UInt16), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_WriteUShort_UInt16_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_WriteUShort_UInt16_ByteArray_Int32;
			}
		}

		/// <summary>
		/// UInt16 ReadUShort(Byte[], Int32)
		/// </summary>
		protected RMethod r_ReadUShort_ByteArray_Int32;
		public virtual RMethod RReadUShort_ByteArray_Int32
		{
			get
			{
				if(r_ReadUShort_ByteArray_Int32 == null)
				{
					r_ReadUShort_ByteArray_Int32 = new(this, "ReadUShort", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_ReadUShort_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_ReadUShort_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Security.AccessControl.GenericAce[], Int32)
		/// </summary>
		protected RMethod r_CopyTo_GenericAceArray_Int32;
		public virtual RMethod RCopyTo_GenericAceArray_Int32
		{
			get
			{
				if(r_CopyTo_GenericAceArray_Int32 == null)
				{
					r_CopyTo_GenericAceArray_Int32 = new(this, "CopyTo", 0, typeof(System.Security.AccessControl.GenericAce).MakeArrayType(), typeof(System.Int32));
					r_CopyTo_GenericAceArray_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_GenericAceArray_Int32;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_GetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_GetEnumerator == null)
				{
					r_GetEnumerator = new(this, "GetEnumerator", 0);
					r_GetEnumerator.SetBelong(this.instance);
				}
				return r_GetEnumerator;
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


        public RRawAcl() : base("System.Security.AccessControl.RawAcl")
        {
        }

        public RRawAcl(System.Object instance) : base("System.Security.AccessControl.RawAcl")
		{
            SetInstance(instance);
		}

        public RRawAcl(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRawAcl(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void GetBinaryForm(System.Byte[] @binaryForm, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @offset};
            var ___result = RGetBinaryForm_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertAce(System.Int32 @index, System.Security.AccessControl.GenericAce @ace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @ace};
            var ___result = RInsertAce_Int32_GenericAce.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAce(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveAce_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetSddlForm(System.Security.AccessControl.ControlFlags @sdFlags, System.Boolean @isDacl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sdFlags, @isDacl};
            var ___result = RGetSddlForm_ControlFlags_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Security.AccessControl.RawAcl ParseSddlForm(System.String @sddlForm, System.Boolean @isDacl, ref System.Security.AccessControl.ControlFlags @sdFlags, ref System.Int32 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm, @isDacl, @sdFlags, @pos};
            var ___result = RParseSddlForm_String_Boolean_Ref_ControlFlags_Ref_Int32.Invoke(___genericsType, ___parameters);
			@sdFlags = (System.Security.AccessControl.ControlFlags)___parameters[2];
			@pos = (System.Int32)___parameters[3];

            return (System.Security.AccessControl.RawAcl)___result;
        }


        public static void ParseFlags(System.String @sddlForm, System.Boolean @isDacl, ref System.Security.AccessControl.ControlFlags @sdFlags, ref System.Int32 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm, @isDacl, @sdFlags, @pos};
            var ___result = RParseFlags_String_Boolean_Ref_ControlFlags_Ref_Int32.Invoke(___genericsType, ___parameters);
			@sdFlags = (System.Security.AccessControl.ControlFlags)___parameters[2];
			@pos = (System.Int32)___parameters[3];

            
        }


        public virtual void WriteUShort(System.UInt16 @val, System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val, @buffer, @offset};
            var ___result = RWriteUShort_UInt16_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt16 ReadUShort(System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset};
            var ___result = RReadUShort_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual void CopyTo(System.Security.AccessControl.GenericAce[] @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_GenericAceArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.AceEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AceEnumerator)___result;
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
