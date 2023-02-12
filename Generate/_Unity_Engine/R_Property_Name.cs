
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.PropertyName
	/// </summary>
    public partial class RPropertyName : RMember //
    {

		/// <summary>
		/// System.Int32 id
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fid;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFid
		{
			get
			{
				if(r_Fid == null)
				{
					r_Fid = new(this, "id");
					r_Fid.SetBelong(this.instance);
				}
				return r_Fid;
			}
		}

		/// <summary>
		/// System.Int32 conflictIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FconflictIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFconflictIndex
		{
			get
			{
				if(r_FconflictIndex == null)
				{
					r_FconflictIndex = new(this, "conflictIndex");
					r_FconflictIndex.SetBelong(this.instance);
				}
				return r_FconflictIndex;
			}
		}

		/// <summary>
		/// Boolean IsNullOrEmpty(UnityEngine.PropertyName)
		/// </summary>
		protected static RMethod r_MIsNullOrEmpty_PropertyName;
		public static RMethod RMIsNullOrEmpty_PropertyName
		{
			get
			{
				if(r_MIsNullOrEmpty_PropertyName == null)
				{
					r_MIsNullOrEmpty_PropertyName = new(typeof(UnityEngine.PropertyName), "IsNullOrEmpty", 0, typeof(UnityEngine.PropertyName));
					r_MIsNullOrEmpty_PropertyName.SetBelong(null);
				}
				return r_MIsNullOrEmpty_PropertyName;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.PropertyName, UnityEngine.PropertyName)
		/// </summary>
		protected static RMethod r_Mop_Equality_PropertyName_PropertyName;
		public static RMethod RMop_Equality_PropertyName_PropertyName
		{
			get
			{
				if(r_Mop_Equality_PropertyName_PropertyName == null)
				{
					r_Mop_Equality_PropertyName_PropertyName = new(typeof(UnityEngine.PropertyName), "op_Equality", 0, typeof(UnityEngine.PropertyName), typeof(UnityEngine.PropertyName));
					r_Mop_Equality_PropertyName_PropertyName.SetBelong(null);
				}
				return r_Mop_Equality_PropertyName_PropertyName;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.PropertyName, UnityEngine.PropertyName)
		/// </summary>
		protected static RMethod r_Mop_Inequality_PropertyName_PropertyName;
		public static RMethod RMop_Inequality_PropertyName_PropertyName
		{
			get
			{
				if(r_Mop_Inequality_PropertyName_PropertyName == null)
				{
					r_Mop_Inequality_PropertyName_PropertyName = new(typeof(UnityEngine.PropertyName), "op_Inequality", 0, typeof(UnityEngine.PropertyName), typeof(UnityEngine.PropertyName));
					r_Mop_Inequality_PropertyName_PropertyName.SetBelong(null);
				}
				return r_Mop_Inequality_PropertyName_PropertyName;
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
		/// Boolean Equals(UnityEngine.PropertyName)
		/// </summary>
		protected RMethod r_MEquals_PropertyName;
		public virtual RMethod RMEquals_PropertyName
		{
			get
			{
				if(r_MEquals_PropertyName == null)
				{
					r_MEquals_PropertyName = new(this, "Equals", 0, typeof(UnityEngine.PropertyName));
					r_MEquals_PropertyName.SetBelong(this.instance);
				}
				return r_MEquals_PropertyName;
			}
		}

		/// <summary>
		/// UnityEngine.PropertyName op_Implicit(System.String)
		/// </summary>
		protected static RMethod r_Mop_Implicit_String;
		public static RMethod RMop_Implicit_String
		{
			get
			{
				if(r_Mop_Implicit_String == null)
				{
					r_Mop_Implicit_String = new(typeof(UnityEngine.PropertyName), "op_Implicit", 0, typeof(System.String));
					r_Mop_Implicit_String.SetBelong(null);
				}
				return r_Mop_Implicit_String;
			}
		}

		/// <summary>
		/// UnityEngine.PropertyName op_Implicit(Int32)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Int32;
		public static RMethod RMop_Implicit_Int32
		{
			get
			{
				if(r_Mop_Implicit_Int32 == null)
				{
					r_Mop_Implicit_Int32 = new(typeof(UnityEngine.PropertyName), "op_Implicit", 0, typeof(System.Int32));
					r_Mop_Implicit_Int32.SetBelong(null);
				}
				return r_Mop_Implicit_Int32;
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


        public RPropertyName() : base("UnityEngine.PropertyName")
        {
        }

        public RPropertyName(System.Object instance) : base("UnityEngine.PropertyName")
		{
            SetInstance(instance);
		}

        public RPropertyName(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPropertyName(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean IsNullOrEmpty(UnityEngine.PropertyName @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RMIsNullOrEmpty_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.PropertyName @lhs, UnityEngine.PropertyName @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_PropertyName_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.PropertyName @lhs, UnityEngine.PropertyName @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_PropertyName_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.PropertyName @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.PropertyName op_Implicit(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMop_Implicit_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.PropertyName)___result;
        }


        public static UnityEngine.PropertyName op_Implicit(System.Int32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RMop_Implicit_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.PropertyName)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
