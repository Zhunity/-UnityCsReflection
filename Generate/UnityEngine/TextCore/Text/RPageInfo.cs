using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.PageInfo
	/// </summary>
    public partial class RPageInfo : RMember //
    {

		/// <summary>
		/// System.Int32 firstCharacterIndex
		/// </summary>
		protected RSystem.RInt32 r_FfirstCharacterIndex;
		public virtual RSystem.RInt32 RFfirstCharacterIndex
		{
			get
			{
				if(r_FfirstCharacterIndex == null)
				{
					r_FfirstCharacterIndex = new(this, "firstCharacterIndex");
					r_FfirstCharacterIndex.SetBelong(this.instance);
				}
				return r_FfirstCharacterIndex;
			}
		}

		/// <summary>
		/// System.Int32 lastCharacterIndex
		/// </summary>
		protected RSystem.RInt32 r_FlastCharacterIndex;
		public virtual RSystem.RInt32 RFlastCharacterIndex
		{
			get
			{
				if(r_FlastCharacterIndex == null)
				{
					r_FlastCharacterIndex = new(this, "lastCharacterIndex");
					r_FlastCharacterIndex.SetBelong(this.instance);
				}
				return r_FlastCharacterIndex;
			}
		}

		/// <summary>
		/// System.Single ascender
		/// </summary>
		protected RSystem.RSingle r_Fascender;
		public virtual RSystem.RSingle RFascender
		{
			get
			{
				if(r_Fascender == null)
				{
					r_Fascender = new(this, "ascender");
					r_Fascender.SetBelong(this.instance);
				}
				return r_Fascender;
			}
		}

		/// <summary>
		/// System.Single baseLine
		/// </summary>
		protected RSystem.RSingle r_FbaseLine;
		public virtual RSystem.RSingle RFbaseLine
		{
			get
			{
				if(r_FbaseLine == null)
				{
					r_FbaseLine = new(this, "baseLine");
					r_FbaseLine.SetBelong(this.instance);
				}
				return r_FbaseLine;
			}
		}

		/// <summary>
		/// System.Single descender
		/// </summary>
		protected RSystem.RSingle r_Fdescender;
		public virtual RSystem.RSingle RFdescender
		{
			get
			{
				if(r_Fdescender == null)
				{
					r_Fdescender = new(this, "descender");
					r_Fdescender.SetBelong(this.instance);
				}
				return r_Fdescender;
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


        public RPageInfo() : base("UnityEngine.TextCore.Text.PageInfo")
        {
        }

        public RPageInfo(System.Object instance) : base("UnityEngine.TextCore.Text.PageInfo")
		{
            SetInstance(instance);
		}

        public RPageInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPageInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
