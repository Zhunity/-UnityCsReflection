
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.GlyphAnchorPoint
	/// </summary>
    public partial class RGlyphAnchorPoint : RMember //
    {

		/// <summary>
		/// System.Single m_XCoordinate
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Fm_XCoordinate;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFm_XCoordinate
		{
			get
			{
				if(r_Fm_XCoordinate == null)
				{
					r_Fm_XCoordinate = new(this, "m_XCoordinate");
					r_Fm_XCoordinate.SetBelong(this.instance);
				}
				return r_Fm_XCoordinate;
			}
		}

		/// <summary>
		/// System.Single m_YCoordinate
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Fm_YCoordinate;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFm_YCoordinate
		{
			get
			{
				if(r_Fm_YCoordinate == null)
				{
					r_Fm_YCoordinate = new(this, "m_YCoordinate");
					r_Fm_YCoordinate.SetBelong(this.instance);
				}
				return r_Fm_YCoordinate;
			}
		}

		/// <summary>
		/// Single xCoordinate
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_PxCoordinate;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RPxCoordinate
		{
			get
			{
				if(r_PxCoordinate == null)
				{
					r_PxCoordinate = new(this, "xCoordinate", -1);
					r_PxCoordinate.SetBelong(this.instance);
				}
				return r_PxCoordinate;
			}
		}

		/// <summary>
		/// Single yCoordinate
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_PyCoordinate;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RPyCoordinate
		{
			get
			{
				if(r_PyCoordinate == null)
				{
					r_PyCoordinate = new(this, "yCoordinate", -1);
					r_PyCoordinate.SetBelong(this.instance);
				}
				return r_PyCoordinate;
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


        public RGlyphAnchorPoint() : base("UnityEngine.TextCore.LowLevel.GlyphAnchorPoint")
        {
        }

        public RGlyphAnchorPoint(System.Object instance) : base("UnityEngine.TextCore.LowLevel.GlyphAnchorPoint")
		{
            SetInstance(instance);
		}

        public RGlyphAnchorPoint(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGlyphAnchorPoint(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
