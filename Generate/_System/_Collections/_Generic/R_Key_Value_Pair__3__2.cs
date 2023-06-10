
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.KeyValuePair`2
	/// </summary>
    public partial class RKeyValuePair<TKey, TValue> : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Collections.Generic.KeyValuePair<, >).MakeGenericType(ReflectionUtils.GetType(typeof(TKey)), ReflectionUtils.GetType(typeof(TValue)));
            }
        }

        public RKeyValuePair() : base("System.Collections.Generic.KeyValuePair`2")
        {
        }

        public RKeyValuePair(System.Object instance) : base("System.Collections.Generic.KeyValuePair`2")
		{
            SetInstance(instance);
		}

        public RKeyValuePair(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RKeyValuePair(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// TKey key
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_Fkey;
		public virtual Hvak.Editor.Refleaction.RField RFkey
		{
			get
			{
				if(r_Fkey == null)
				{
					r_Fkey = new(this, "key");
				}
				return r_Fkey;
			}
		}

		/// <summary>
		/// TValue value
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_Fvalue;
		public virtual Hvak.Editor.Refleaction.RField RFvalue
		{
			get
			{
				if(r_Fvalue == null)
				{
					r_Fvalue = new(this, "value");
				}
				return r_Fvalue;
			}
		}

		/// <summary>
		/// TKey Key
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PKey;
		public virtual Hvak.Editor.Refleaction.RProperty RPKey
		{
			get
			{
				if(r_PKey == null)
				{
					r_PKey = new(this, "Key", -1);
				}
				return r_PKey;
			}
		}

		/// <summary>
		/// TValue Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PValue;
		public virtual Hvak.Editor.Refleaction.RProperty RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
				}
				return r_PValue;
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
		/// Void Deconstruct(TKey ByRef, TValue ByRef)
		/// </summary>
		protected RMethod r_MDeconstruct_Out_TKey_Out_TValue;
		public virtual RMethod RMDeconstruct_Out_TKey_Out_TValue
		{
			get
			{
				if(r_MDeconstruct_Out_TKey_Out_TValue == null)
				{
					r_MDeconstruct_Out_TKey_Out_TValue = new(this, "Deconstruct", 0, Type.MakeGenericMethodParameter(0).MakeByRefType(), Type.MakeGenericMethodParameter(1).MakeByRefType());
				}
				return r_MDeconstruct_Out_TKey_Out_TValue;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Deconstruct(out TKey @key, out TValue @value)
        {
			@key = default;
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMDeconstruct_Out_TKey_Out_TValue.Invoke(___genericsType, ___parameters);
			@key = (TKey)___parameters[0];
			@value = (TValue)___parameters[1];

            
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
