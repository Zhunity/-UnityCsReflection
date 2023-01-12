using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RIMGUIContainer
{
	
	/// <summary>
	/// UnityEngine.UIElements.IMGUIContainer+GUIGlobals
	/// </summary>
    public partial class RGUIGlobals : RMember //
    {

		/// <summary>
		/// UnityEngine.Matrix4x4 matrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_Fmatrix;
		public virtual RUnityEngine.RMatrix4x4 RFmatrix
		{
			get
			{
				if(r_Fmatrix == null)
				{
					r_Fmatrix = new(this, "matrix");
					r_Fmatrix.SetBelong(this.instance);
				}
				return r_Fmatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_Fcolor;
		public virtual RUnityEngine.RColor RFcolor
		{
			get
			{
				if(r_Fcolor == null)
				{
					r_Fcolor = new(this, "color");
					r_Fcolor.SetBelong(this.instance);
				}
				return r_Fcolor;
			}
		}

		/// <summary>
		/// UnityEngine.Color contentColor
		/// </summary>
		protected RUnityEngine.RColor r_FcontentColor;
		public virtual RUnityEngine.RColor RFcontentColor
		{
			get
			{
				if(r_FcontentColor == null)
				{
					r_FcontentColor = new(this, "contentColor");
					r_FcontentColor.SetBelong(this.instance);
				}
				return r_FcontentColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color backgroundColor
		/// </summary>
		protected RUnityEngine.RColor r_FbackgroundColor;
		public virtual RUnityEngine.RColor RFbackgroundColor
		{
			get
			{
				if(r_FbackgroundColor == null)
				{
					r_FbackgroundColor = new(this, "backgroundColor");
					r_FbackgroundColor.SetBelong(this.instance);
				}
				return r_FbackgroundColor;
			}
		}

		/// <summary>
		/// System.Boolean enabled
		/// </summary>
		protected RSystem.RBoolean r_Fenabled;
		public virtual RSystem.RBoolean RFenabled
		{
			get
			{
				if(r_Fenabled == null)
				{
					r_Fenabled = new(this, "enabled");
					r_Fenabled.SetBelong(this.instance);
				}
				return r_Fenabled;
			}
		}

		/// <summary>
		/// System.Boolean changed
		/// </summary>
		protected RSystem.RBoolean r_Fchanged;
		public virtual RSystem.RBoolean RFchanged
		{
			get
			{
				if(r_Fchanged == null)
				{
					r_Fchanged = new(this, "changed");
					r_Fchanged.SetBelong(this.instance);
				}
				return r_Fchanged;
			}
		}

		/// <summary>
		/// System.Int32 displayIndex
		/// </summary>
		protected RSystem.RInt32 r_FdisplayIndex;
		public virtual RSystem.RInt32 RFdisplayIndex
		{
			get
			{
				if(r_FdisplayIndex == null)
				{
					r_FdisplayIndex = new(this, "displayIndex");
					r_FdisplayIndex.SetBelong(this.instance);
				}
				return r_FdisplayIndex;
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


        public RGUIGlobals() : base("UnityEngine.UIElements.IMGUIContainer+GUIGlobals")
        {
        }

        public RGUIGlobals(System.Object instance) : base("UnityEngine.UIElements.IMGUIContainer+GUIGlobals")
		{
            SetInstance(instance);
		}

        public RGUIGlobals(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGUIGlobals(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}