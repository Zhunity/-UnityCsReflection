
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.RepaintData
	/// </summary>
    public partial class RRepaintData : RMember //
    {

		/// <summary>
		/// UnityEngine.Matrix4x4 <currentOffset>k__BackingField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_F__0__currentOffset__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 RF__0__currentOffset__1__k__BackingField
		{
			get
			{
				if(r_F__0__currentOffset__1__k__BackingField == null)
				{
					r_F__0__currentOffset__1__k__BackingField = new(this, "<currentOffset>k__BackingField");
					r_F__0__currentOffset__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__currentOffset__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <mousePosition>k__BackingField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2 r_F__0__mousePosition__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2 RF__0__mousePosition__1__k__BackingField
		{
			get
			{
				if(r_F__0__mousePosition__1__k__BackingField == null)
				{
					r_F__0__mousePosition__1__k__BackingField = new(this, "<mousePosition>k__BackingField");
					r_F__0__mousePosition__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__mousePosition__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Rect <currentWorldClip>k__BackingField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RRect r_F__0__currentWorldClip__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RRect RF__0__currentWorldClip__1__k__BackingField
		{
			get
			{
				if(r_F__0__currentWorldClip__1__k__BackingField == null)
				{
					r_F__0__currentWorldClip__1__k__BackingField = new(this, "<currentWorldClip>k__BackingField");
					r_F__0__currentWorldClip__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__currentWorldClip__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Event <repaintEvent>k__BackingField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.REvent r_F__0__repaintEvent__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.REvent RF__0__repaintEvent__1__k__BackingField
		{
			get
			{
				if(r_F__0__repaintEvent__1__k__BackingField == null)
				{
					r_F__0__repaintEvent__1__k__BackingField = new(this, "<repaintEvent>k__BackingField");
					r_F__0__repaintEvent__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__repaintEvent__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 currentOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PcurrentOffset;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPcurrentOffset
		{
			get
			{
				if(r_PcurrentOffset == null)
				{
					r_PcurrentOffset = new(this, "currentOffset", -1);
					r_PcurrentOffset.SetBelong(this.instance);
				}
				return r_PcurrentOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mousePosition
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2 r_PmousePosition;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2 RPmousePosition
		{
			get
			{
				if(r_PmousePosition == null)
				{
					r_PmousePosition = new(this, "mousePosition", -1);
					r_PmousePosition.SetBelong(this.instance);
				}
				return r_PmousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.Rect currentWorldClip
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RRect r_PcurrentWorldClip;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RRect RPcurrentWorldClip
		{
			get
			{
				if(r_PcurrentWorldClip == null)
				{
					r_PcurrentWorldClip = new(this, "currentWorldClip", -1);
					r_PcurrentWorldClip.SetBelong(this.instance);
				}
				return r_PcurrentWorldClip;
			}
		}

		/// <summary>
		/// UnityEngine.Event repaintEvent
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.REvent r_PrepaintEvent;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.REvent RPrepaintEvent
		{
			get
			{
				if(r_PrepaintEvent == null)
				{
					r_PrepaintEvent = new(this, "repaintEvent", -1);
					r_PrepaintEvent.SetBelong(this.instance);
				}
				return r_PrepaintEvent;
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


        public RRepaintData() : base("UnityEngine.UIElements.RepaintData")
        {
        }

        public RRepaintData(System.Object instance) : base("UnityEngine.UIElements.RepaintData")
		{
            SetInstance(instance);
		}

        public RRepaintData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRepaintData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
