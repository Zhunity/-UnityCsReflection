
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.PropertyBuilder
	/// </summary>
    public partial class RPropertyBuilder : RMember //
    {

		/// <summary>
		/// System.Reflection.PropertyAttributes attrs
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RPropertyAttributes r_Fattrs;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RPropertyAttributes RFattrs
		{
			get
			{
				if(r_Fattrs == null)
				{
					r_Fattrs = new(this, "attrs");
					r_Fattrs.SetBelong(this.instance);
				}
				return r_Fattrs;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFname
		{
			get
			{
				if(r_Fname == null)
				{
					r_Fname = new(this, "name");
					r_Fname.SetBelong(this.instance);
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.Type type
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_Ftype;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
					r_Ftype.SetBelong(this.instance);
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// System.Type[] parameters
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType> r_Fparameters;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType> RFparameters
		{
			get
			{
				if(r_Fparameters == null)
				{
					r_Fparameters = new(this, "parameters");
					r_Fparameters.SetBelong(this.instance);
				}
				return r_Fparameters;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.CustomAttributeBuilder[] cattrs
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RCustomAttributeBuilder> r_Fcattrs;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RCustomAttributeBuilder> RFcattrs
		{
			get
			{
				if(r_Fcattrs == null)
				{
					r_Fcattrs = new(this, "cattrs");
					r_Fcattrs.SetBelong(this.instance);
				}
				return r_Fcattrs;
			}
		}

		/// <summary>
		/// System.Object def_value
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_Fdef_value;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RFdef_value
		{
			get
			{
				if(r_Fdef_value == null)
				{
					r_Fdef_value = new(this, "def_value");
					r_Fdef_value.SetBelong(this.instance);
				}
				return r_Fdef_value;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder set_method
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RMethodBuilder r_Fset_method;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RMethodBuilder RFset_method
		{
			get
			{
				if(r_Fset_method == null)
				{
					r_Fset_method = new(this, "set_method");
					r_Fset_method.SetBelong(this.instance);
				}
				return r_Fset_method;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder get_method
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RMethodBuilder r_Fget_method;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RMethodBuilder RFget_method
		{
			get
			{
				if(r_Fget_method == null)
				{
					r_Fget_method = new(this, "get_method");
					r_Fget_method.SetBelong(this.instance);
				}
				return r_Fget_method;
			}
		}

		/// <summary>
		/// System.Int32 table_idx
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Ftable_idx;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFtable_idx
		{
			get
			{
				if(r_Ftable_idx == null)
				{
					r_Ftable_idx = new(this, "table_idx");
					r_Ftable_idx.SetBelong(this.instance);
				}
				return r_Ftable_idx;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder typeb
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder r_Ftypeb;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder RFtypeb
		{
			get
			{
				if(r_Ftypeb == null)
				{
					r_Ftypeb = new(this, "typeb");
					r_Ftypeb.SetBelong(this.instance);
				}
				return r_Ftypeb;
			}
		}

		/// <summary>
		/// System.Type[] returnModReq
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType> r_FreturnModReq;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType> RFreturnModReq
		{
			get
			{
				if(r_FreturnModReq == null)
				{
					r_FreturnModReq = new(this, "returnModReq");
					r_FreturnModReq.SetBelong(this.instance);
				}
				return r_FreturnModReq;
			}
		}

		/// <summary>
		/// System.Type[] returnModOpt
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType> r_FreturnModOpt;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType> RFreturnModOpt
		{
			get
			{
				if(r_FreturnModOpt == null)
				{
					r_FreturnModOpt = new(this, "returnModOpt");
					r_FreturnModOpt.SetBelong(this.instance);
				}
				return r_FreturnModOpt;
			}
		}

		/// <summary>
		/// System.Type[][] paramModReq
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType>> r_FparamModReq;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType>> RFparamModReq
		{
			get
			{
				if(r_FparamModReq == null)
				{
					r_FparamModReq = new(this, "paramModReq");
					r_FparamModReq.SetBelong(this.instance);
				}
				return r_FparamModReq;
			}
		}

		/// <summary>
		/// System.Type[][] paramModOpt
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType>> r_FparamModOpt;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType>> RFparamModOpt
		{
			get
			{
				if(r_FparamModOpt == null)
				{
					r_FparamModOpt = new(this, "paramModOpt");
					r_FparamModOpt.SetBelong(this.instance);
				}
				return r_FparamModOpt;
			}
		}

		/// <summary>
		/// System.Reflection.CallingConventions callingConvention
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RCallingConventions r_FcallingConvention;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RCallingConventions RFcallingConvention
		{
			get
			{
				if(r_FcallingConvention == null)
				{
					r_FcallingConvention = new(this, "callingConvention");
					r_FcallingConvention.SetBelong(this.instance);
				}
				return r_FcallingConvention;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyAttributes Attributes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RPropertyAttributes r_PAttributes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RPropertyAttributes RPAttributes
		{
			get
			{
				if(r_PAttributes == null)
				{
					r_PAttributes = new(this, "Attributes", -1);
					r_PAttributes.SetBelong(this.instance);
				}
				return r_PAttributes;
			}
		}

		/// <summary>
		/// Boolean CanRead
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PCanRead;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPCanRead
		{
			get
			{
				if(r_PCanRead == null)
				{
					r_PCanRead = new(this, "CanRead", -1);
					r_PCanRead.SetBelong(this.instance);
				}
				return r_PCanRead;
			}
		}

		/// <summary>
		/// Boolean CanWrite
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PCanWrite;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPCanWrite
		{
			get
			{
				if(r_PCanWrite == null)
				{
					r_PCanWrite = new(this, "CanWrite", -1);
					r_PCanWrite.SetBelong(this.instance);
				}
				return r_PCanWrite;
			}
		}

		/// <summary>
		/// System.Type DeclaringType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_PDeclaringType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RPDeclaringType
		{
			get
			{
				if(r_PDeclaringType == null)
				{
					r_PDeclaringType = new(this, "DeclaringType", -1);
					r_PDeclaringType.SetBelong(this.instance);
				}
				return r_PDeclaringType;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.PropertyToken PropertyToken
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RPropertyToken r_PPropertyToken;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RPropertyToken RPPropertyToken
		{
			get
			{
				if(r_PPropertyToken == null)
				{
					r_PPropertyToken = new(this, "PropertyToken", -1);
					r_PPropertyToken.SetBelong(this.instance);
				}
				return r_PPropertyToken;
			}
		}

		/// <summary>
		/// System.Type PropertyType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_PPropertyType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RPPropertyType
		{
			get
			{
				if(r_PPropertyType == null)
				{
					r_PPropertyType = new(this, "PropertyType", -1);
					r_PPropertyType.SetBelong(this.instance);
				}
				return r_PPropertyType;
			}
		}

		/// <summary>
		/// System.Type ReflectedType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_PReflectedType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RPReflectedType
		{
			get
			{
				if(r_PReflectedType == null)
				{
					r_PReflectedType = new(this, "ReflectedType", -1);
					r_PReflectedType.SetBelong(this.instance);
				}
				return r_PReflectedType;
			}
		}

		/// <summary>
		/// System.Reflection.Module Module
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RModule r_PModule;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RModule RPModule
		{
			get
			{
				if(r_PModule == null)
				{
					r_PModule = new(this, "Module", -1);
					r_PModule.SetBelong(this.instance);
				}
				return r_PModule;
			}
		}

		/// <summary>
		/// System.Reflection.MemberTypes MemberType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMemberTypes r_PMemberType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMemberTypes RPMemberType
		{
			get
			{
				if(r_PMemberType == null)
				{
					r_PMemberType = new(this, "MemberType", -1);
					r_PMemberType.SetBelong(this.instance);
				}
				return r_PMemberType;
			}
		}

		/// <summary>
		/// Boolean IsSpecialName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSpecialName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSpecialName
		{
			get
			{
				if(r_PIsSpecialName == null)
				{
					r_PIsSpecialName = new(this, "IsSpecialName", -1);
					r_PIsSpecialName.SetBelong(this.instance);
				}
				return r_PIsSpecialName;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_PGetMethod;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo RPGetMethod
		{
			get
			{
				if(r_PGetMethod == null)
				{
					r_PGetMethod = new(this, "GetMethod", -1);
					r_PGetMethod.SetBelong(this.instance);
				}
				return r_PGetMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo SetMethod
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_PSetMethod;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo RPSetMethod
		{
			get
			{
				if(r_PSetMethod == null)
				{
					r_PSetMethod = new(this, "SetMethod", -1);
					r_PSetMethod.SetBelong(this.instance);
				}
				return r_PSetMethod;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData> r_PCustomAttributes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData> RPCustomAttributes
		{
			get
			{
				if(r_PCustomAttributes == null)
				{
					r_PCustomAttributes = new(this, "CustomAttributes", -1);
					r_PCustomAttributes.SetBelong(this.instance);
				}
				return r_PCustomAttributes;
			}
		}

		/// <summary>
		/// Int32 MetadataToken
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PMetadataToken;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPMetadataToken
		{
			get
			{
				if(r_PMetadataToken == null)
				{
					r_PMetadataToken = new(this, "MetadataToken", -1);
					r_PMetadataToken.SetBelong(this.instance);
				}
				return r_PMetadataToken;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._PropertyBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._PropertyBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._PropertyBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._PropertyBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._PropertyBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._PropertyBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._PropertyBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._PropertyBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void AddOtherMethod(System.Reflection.Emit.MethodBuilder)
		/// </summary>
		protected RMethod r_MAddOtherMethod_MethodBuilder;
		public virtual RMethod RMAddOtherMethod_MethodBuilder
		{
			get
			{
				if(r_MAddOtherMethod_MethodBuilder == null)
				{
					r_MAddOtherMethod_MethodBuilder = new(this, "AddOtherMethod", 0, typeof(System.Reflection.Emit.MethodBuilder));
					r_MAddOtherMethod_MethodBuilder.SetBelong(this.instance);
				}
				return r_MAddOtherMethod_MethodBuilder;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetAccessors(Boolean)
		/// </summary>
		protected RMethod r_MGetAccessors_Boolean;
		public virtual RMethod RMGetAccessors_Boolean
		{
			get
			{
				if(r_MGetAccessors_Boolean == null)
				{
					r_MGetAccessors_Boolean = new(this, "GetAccessors", 0, typeof(System.Boolean));
					r_MGetAccessors_Boolean.SetBelong(this.instance);
				}
				return r_MGetAccessors_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(Boolean)
		/// </summary>
		protected RMethod r_MGetCustomAttributes_Boolean;
		public virtual RMethod RMGetCustomAttributes_Boolean
		{
			get
			{
				if(r_MGetCustomAttributes_Boolean == null)
				{
					r_MGetCustomAttributes_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Boolean));
					r_MGetCustomAttributes_Boolean.SetBelong(this.instance);
				}
				return r_MGetCustomAttributes_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MGetCustomAttributes_Type_Boolean;
		public virtual RMethod RMGetCustomAttributes_Type_Boolean
		{
			get
			{
				if(r_MGetCustomAttributes_Type_Boolean == null)
				{
					r_MGetCustomAttributes_Type_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Type), typeof(System.Boolean));
					r_MGetCustomAttributes_Type_Boolean.SetBelong(this.instance);
				}
				return r_MGetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetGetMethod(Boolean)
		/// </summary>
		protected RMethod r_MGetGetMethod_Boolean;
		public virtual RMethod RMGetGetMethod_Boolean
		{
			get
			{
				if(r_MGetGetMethod_Boolean == null)
				{
					r_MGetGetMethod_Boolean = new(this, "GetGetMethod", 0, typeof(System.Boolean));
					r_MGetGetMethod_Boolean.SetBelong(this.instance);
				}
				return r_MGetGetMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetIndexParameters()
		/// </summary>
		protected RMethod r_MGetIndexParameters;
		public virtual RMethod RMGetIndexParameters
		{
			get
			{
				if(r_MGetIndexParameters == null)
				{
					r_MGetIndexParameters = new(this, "GetIndexParameters", 0);
					r_MGetIndexParameters.SetBelong(this.instance);
				}
				return r_MGetIndexParameters;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetSetMethod(Boolean)
		/// </summary>
		protected RMethod r_MGetSetMethod_Boolean;
		public virtual RMethod RMGetSetMethod_Boolean
		{
			get
			{
				if(r_MGetSetMethod_Boolean == null)
				{
					r_MGetSetMethod_Boolean = new(this, "GetSetMethod", 0, typeof(System.Boolean));
					r_MGetSetMethod_Boolean.SetBelong(this.instance);
				}
				return r_MGetSetMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.Object, System.Object[])
		/// </summary>
		protected RMethod r_MGetValue_Object_ObjectArray;
		public virtual RMethod RMGetValue_Object_ObjectArray
		{
			get
			{
				if(r_MGetValue_Object_ObjectArray == null)
				{
					r_MGetValue_Object_ObjectArray = new(this, "GetValue", 0, typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_MGetValue_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_MGetValue_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RMGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_MGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_MGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "GetValue", 0, typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_MGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_MGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MIsDefined_Type_Boolean;
		public virtual RMethod RMIsDefined_Type_Boolean
		{
			get
			{
				if(r_MIsDefined_Type_Boolean == null)
				{
					r_MIsDefined_Type_Boolean = new(this, "IsDefined", 0, typeof(System.Type), typeof(System.Boolean));
					r_MIsDefined_Type_Boolean.SetBelong(this.instance);
				}
				return r_MIsDefined_Type_Boolean;
			}
		}

		/// <summary>
		/// Void SetConstant(System.Object)
		/// </summary>
		protected RMethod r_MSetConstant_Object;
		public virtual RMethod RMSetConstant_Object
		{
			get
			{
				if(r_MSetConstant_Object == null)
				{
					r_MSetConstant_Object = new(this, "SetConstant", 0, typeof(System.Object));
					r_MSetConstant_Object.SetBelong(this.instance);
				}
				return r_MSetConstant_Object;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder)
		/// </summary>
		protected RMethod r_MSetCustomAttribute_CustomAttributeBuilder;
		public virtual RMethod RMSetCustomAttribute_CustomAttributeBuilder
		{
			get
			{
				if(r_MSetCustomAttribute_CustomAttributeBuilder == null)
				{
					r_MSetCustomAttribute_CustomAttributeBuilder = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder));
					r_MSetCustomAttribute_CustomAttributeBuilder.SetBelong(this.instance);
				}
				return r_MSetCustomAttribute_CustomAttributeBuilder;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.ConstructorInfo, Byte[])
		/// </summary>
		protected RMethod r_MSetCustomAttribute_ConstructorInfo_ByteArray;
		public virtual RMethod RMSetCustomAttribute_ConstructorInfo_ByteArray
		{
			get
			{
				if(r_MSetCustomAttribute_ConstructorInfo_ByteArray == null)
				{
					r_MSetCustomAttribute_ConstructorInfo_ByteArray = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Byte).MakeArrayType());
					r_MSetCustomAttribute_ConstructorInfo_ByteArray.SetBelong(this.instance);
				}
				return r_MSetCustomAttribute_ConstructorInfo_ByteArray;
			}
		}

		/// <summary>
		/// Void SetGetMethod(System.Reflection.Emit.MethodBuilder)
		/// </summary>
		protected RMethod r_MSetGetMethod_MethodBuilder;
		public virtual RMethod RMSetGetMethod_MethodBuilder
		{
			get
			{
				if(r_MSetGetMethod_MethodBuilder == null)
				{
					r_MSetGetMethod_MethodBuilder = new(this, "SetGetMethod", 0, typeof(System.Reflection.Emit.MethodBuilder));
					r_MSetGetMethod_MethodBuilder.SetBelong(this.instance);
				}
				return r_MSetGetMethod_MethodBuilder;
			}
		}

		/// <summary>
		/// Void SetSetMethod(System.Reflection.Emit.MethodBuilder)
		/// </summary>
		protected RMethod r_MSetSetMethod_MethodBuilder;
		public virtual RMethod RMSetSetMethod_MethodBuilder
		{
			get
			{
				if(r_MSetSetMethod_MethodBuilder == null)
				{
					r_MSetSetMethod_MethodBuilder = new(this, "SetSetMethod", 0, typeof(System.Reflection.Emit.MethodBuilder));
					r_MSetSetMethod_MethodBuilder.SetBelong(this.instance);
				}
				return r_MSetSetMethod_MethodBuilder;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, System.Object, System.Object[])
		/// </summary>
		protected RMethod r_MSetValue_Object_Object_ObjectArray;
		public virtual RMethod RMSetValue_Object_Object_ObjectArray
		{
			get
			{
				if(r_MSetValue_Object_Object_ObjectArray == null)
				{
					r_MSetValue_Object_Object_ObjectArray = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_MSetValue_Object_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Object_ObjectArray;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RMSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_MSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_MSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_MSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Exception not_supported()
		/// </summary>
		protected RMethod r_Mnot_supported;
		public virtual RMethod RMnot_supported
		{
			get
			{
				if(r_Mnot_supported == null)
				{
					r_Mnot_supported = new(this, "not_supported", 0);
					r_Mnot_supported.SetBelong(this.instance);
				}
				return r_Mnot_supported;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetAccessors()
		/// </summary>
		protected RMethod r_MGetAccessors;
		public virtual RMethod RMGetAccessors
		{
			get
			{
				if(r_MGetAccessors == null)
				{
					r_MGetAccessors = new(this, "GetAccessors", 0);
					r_MGetAccessors.SetBelong(this.instance);
				}
				return r_MGetAccessors;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetGetMethod()
		/// </summary>
		protected RMethod r_MGetGetMethod;
		public virtual RMethod RMGetGetMethod
		{
			get
			{
				if(r_MGetGetMethod == null)
				{
					r_MGetGetMethod = new(this, "GetGetMethod", 0);
					r_MGetGetMethod.SetBelong(this.instance);
				}
				return r_MGetGetMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetSetMethod()
		/// </summary>
		protected RMethod r_MGetSetMethod;
		public virtual RMethod RMGetSetMethod
		{
			get
			{
				if(r_MGetSetMethod == null)
				{
					r_MGetSetMethod = new(this, "GetSetMethod", 0);
					r_MGetSetMethod.SetBelong(this.instance);
				}
				return r_MGetSetMethod;
			}
		}

		/// <summary>
		/// System.Type[] GetOptionalCustomModifiers()
		/// </summary>
		protected RMethod r_MGetOptionalCustomModifiers;
		public virtual RMethod RMGetOptionalCustomModifiers
		{
			get
			{
				if(r_MGetOptionalCustomModifiers == null)
				{
					r_MGetOptionalCustomModifiers = new(this, "GetOptionalCustomModifiers", 0);
					r_MGetOptionalCustomModifiers.SetBelong(this.instance);
				}
				return r_MGetOptionalCustomModifiers;
			}
		}

		/// <summary>
		/// System.Type[] GetRequiredCustomModifiers()
		/// </summary>
		protected RMethod r_MGetRequiredCustomModifiers;
		public virtual RMethod RMGetRequiredCustomModifiers
		{
			get
			{
				if(r_MGetRequiredCustomModifiers == null)
				{
					r_MGetRequiredCustomModifiers = new(this, "GetRequiredCustomModifiers", 0);
					r_MGetRequiredCustomModifiers.SetBelong(this.instance);
				}
				return r_MGetRequiredCustomModifiers;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.Object)
		/// </summary>
		protected RMethod r_MGetValue_Object;
		public virtual RMethod RMGetValue_Object
		{
			get
			{
				if(r_MGetValue_Object == null)
				{
					r_MGetValue_Object = new(this, "GetValue", 0, typeof(System.Object));
					r_MGetValue_Object.SetBelong(this.instance);
				}
				return r_MGetValue_Object;
			}
		}

		/// <summary>
		/// System.Object GetConstantValue()
		/// </summary>
		protected RMethod r_MGetConstantValue;
		public virtual RMethod RMGetConstantValue
		{
			get
			{
				if(r_MGetConstantValue == null)
				{
					r_MGetConstantValue = new(this, "GetConstantValue", 0);
					r_MGetConstantValue.SetBelong(this.instance);
				}
				return r_MGetConstantValue;
			}
		}

		/// <summary>
		/// System.Object GetRawConstantValue()
		/// </summary>
		protected RMethod r_MGetRawConstantValue;
		public virtual RMethod RMGetRawConstantValue
		{
			get
			{
				if(r_MGetRawConstantValue == null)
				{
					r_MGetRawConstantValue = new(this, "GetRawConstantValue", 0);
					r_MGetRawConstantValue.SetBelong(this.instance);
				}
				return r_MGetRawConstantValue;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, System.Object)
		/// </summary>
		protected RMethod r_MSetValue_Object_Object;
		public virtual RMethod RMSetValue_Object_Object
		{
			get
			{
				if(r_MSetValue_Object_Object == null)
				{
					r_MSetValue_Object_Object = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object));
					r_MSetValue_Object_Object.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Object;
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
		/// Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_MHasSameMetadataDefinitionAs_MemberInfo;
		public virtual RMethod RMHasSameMetadataDefinitionAs_MemberInfo
		{
			get
			{
				if(r_MHasSameMetadataDefinitionAs_MemberInfo == null)
				{
					r_MHasSameMetadataDefinitionAs_MemberInfo = new(this, "HasSameMetadataDefinitionAs", 0, typeof(System.Reflection.MemberInfo));
					r_MHasSameMetadataDefinitionAs_MemberInfo.SetBelong(this.instance);
				}
				return r_MHasSameMetadataDefinitionAs_MemberInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()
		/// </summary>
		protected RMethod r_MGetCustomAttributesData;
		public virtual RMethod RMGetCustomAttributesData
		{
			get
			{
				if(r_MGetCustomAttributesData == null)
				{
					r_MGetCustomAttributesData = new(this, "GetCustomAttributesData", 0);
					r_MGetCustomAttributesData.SetBelong(this.instance);
				}
				return r_MGetCustomAttributesData;
			}
		}

		/// <summary>
		/// Boolean CacheEquals(System.Object)
		/// </summary>
		protected RMethod r_MCacheEquals_Object;
		public virtual RMethod RMCacheEquals_Object
		{
			get
			{
				if(r_MCacheEquals_Object == null)
				{
					r_MCacheEquals_Object = new(this, "CacheEquals", 0, typeof(System.Object));
					r_MCacheEquals_Object.SetBelong(this.instance);
				}
				return r_MCacheEquals_Object;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAsCore[TOther](System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
		public virtual RMethod RMHasSameMetadataDefinitionAsCore_GTOther_MemberInfo
		{
			get
			{
				if(r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo == null)
				{
					r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo = new(this, "HasSameMetadataDefinitionAsCore", 1, typeof(System.Reflection.MemberInfo));
					r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.SetBelong(this.instance);
				}
				return r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
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


        public RPropertyBuilder() : base("System.Reflection.Emit.PropertyBuilder")
        {
        }

        public RPropertyBuilder(System.Object instance) : base("System.Reflection.Emit.PropertyBuilder")
		{
            SetInstance(instance);
		}

        public RPropertyBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPropertyBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___PropertyBuilder__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___PropertyBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddOtherMethod(System.Reflection.Emit.MethodBuilder @mdBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mdBuilder};
            var ___result = RMAddOtherMethod_MethodBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.MethodInfo[] GetAccessors(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetAccessors_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RMGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Reflection.MethodInfo GetGetMethod(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetGetMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.ParameterInfo[] GetIndexParameters()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIndexParameters.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ParameterInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetSetMethod(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetSetMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Object GetValue(System.Object @obj, System.Object[] @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @index};
            var ___result = RMGetValue_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Object @obj, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object[] @index, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @invokeAttr, @binder, @index, @culture};
            var ___result = RMGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetConstant(System.Object @defaultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultValue};
            var ___result = RMSetConstant_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder @customBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder};
            var ___result = RMSetCustomAttribute_CustomAttributeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.ConstructorInfo @con, System.Byte[] @binaryAttribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con, @binaryAttribute};
            var ___result = RMSetCustomAttribute_ConstructorInfo_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGetMethod(System.Reflection.Emit.MethodBuilder @mdBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mdBuilder};
            var ___result = RMSetGetMethod_MethodBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSetMethod(System.Reflection.Emit.MethodBuilder @mdBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mdBuilder};
            var ___result = RMSetSetMethod_MethodBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object @obj, System.Object @value, System.Object[] @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value, @index};
            var ___result = RMSetValue_Object_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object @obj, System.Object @value, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object[] @index, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value, @invokeAttr, @binder, @index, @culture};
            var ___result = RMSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception not_supported()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMnot_supported.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Reflection.MethodInfo[] GetAccessors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAccessors.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetGetMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGetMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetSetMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSetMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Type[] GetOptionalCustomModifiers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOptionalCustomModifiers.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetRequiredCustomModifiers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRequiredCustomModifiers.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Object GetValue(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMGetValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetConstantValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetConstantValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetRawConstantValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRawConstantValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetValue(System.Object @obj, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value};
            var ___result = RMSetValue_Object_Object.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Boolean CacheEquals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMCacheEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAsCore<TOther>(System.Reflection.MemberInfo @other) where TOther : System.Reflection.MemberInfo
        {

            var ___genericsType = new Type[] {typeof(TOther)};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
