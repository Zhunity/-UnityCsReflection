using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.EventInterests
	/// </summary>
    public partial class REventInterests : RMember //
    {

		/// <summary>
		/// System.Boolean <wantsMouseMove>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__wantsMouseMove__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__wantsMouseMove__1__k__BackingField
		{
			get
			{
				if(r_F__0__wantsMouseMove__1__k__BackingField == null)
				{
					r_F__0__wantsMouseMove__1__k__BackingField = new(this, "<wantsMouseMove>k__BackingField");
					r_F__0__wantsMouseMove__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__wantsMouseMove__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <wantsMouseEnterLeaveWindow>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__wantsMouseEnterLeaveWindow__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__wantsMouseEnterLeaveWindow__1__k__BackingField
		{
			get
			{
				if(r_F__0__wantsMouseEnterLeaveWindow__1__k__BackingField == null)
				{
					r_F__0__wantsMouseEnterLeaveWindow__1__k__BackingField = new(this, "<wantsMouseEnterLeaveWindow>k__BackingField");
					r_F__0__wantsMouseEnterLeaveWindow__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__wantsMouseEnterLeaveWindow__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <wantsLessLayoutEvents>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__wantsLessLayoutEvents__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__wantsLessLayoutEvents__1__k__BackingField
		{
			get
			{
				if(r_F__0__wantsLessLayoutEvents__1__k__BackingField == null)
				{
					r_F__0__wantsLessLayoutEvents__1__k__BackingField = new(this, "<wantsLessLayoutEvents>k__BackingField");
					r_F__0__wantsLessLayoutEvents__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__wantsLessLayoutEvents__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean wantsMouseMove
		/// </summary>
		protected RSystem.RBoolean r_PwantsMouseMove;
		public virtual RSystem.RBoolean RPwantsMouseMove
		{
			get
			{
				if(r_PwantsMouseMove == null)
				{
					r_PwantsMouseMove = new(this, "wantsMouseMove", -1);
					r_PwantsMouseMove.SetBelong(this.instance);
				}
				return r_PwantsMouseMove;
			}
		}

		/// <summary>
		/// Boolean wantsMouseEnterLeaveWindow
		/// </summary>
		protected RSystem.RBoolean r_PwantsMouseEnterLeaveWindow;
		public virtual RSystem.RBoolean RPwantsMouseEnterLeaveWindow
		{
			get
			{
				if(r_PwantsMouseEnterLeaveWindow == null)
				{
					r_PwantsMouseEnterLeaveWindow = new(this, "wantsMouseEnterLeaveWindow", -1);
					r_PwantsMouseEnterLeaveWindow.SetBelong(this.instance);
				}
				return r_PwantsMouseEnterLeaveWindow;
			}
		}

		/// <summary>
		/// Boolean wantsLessLayoutEvents
		/// </summary>
		protected RSystem.RBoolean r_PwantsLessLayoutEvents;
		public virtual RSystem.RBoolean RPwantsLessLayoutEvents
		{
			get
			{
				if(r_PwantsLessLayoutEvents == null)
				{
					r_PwantsLessLayoutEvents = new(this, "wantsLessLayoutEvents", -1);
					r_PwantsLessLayoutEvents.SetBelong(this.instance);
				}
				return r_PwantsLessLayoutEvents;
			}
		}

		/// <summary>
		/// Boolean WantsEvent(UnityEngine.EventType)
		/// </summary>
		protected RMethod r_MWantsEvent_EventType;
		public virtual RMethod RMWantsEvent_EventType
		{
			get
			{
				if(r_MWantsEvent_EventType == null)
				{
					r_MWantsEvent_EventType = new(this, "WantsEvent", 0, typeof(UnityEngine.EventType));
					r_MWantsEvent_EventType.SetBelong(this.instance);
				}
				return r_MWantsEvent_EventType;
			}
		}

		/// <summary>
		/// Boolean WantsLayoutPass(UnityEngine.EventType)
		/// </summary>
		protected RMethod r_MWantsLayoutPass_EventType;
		public virtual RMethod RMWantsLayoutPass_EventType
		{
			get
			{
				if(r_MWantsLayoutPass_EventType == null)
				{
					r_MWantsLayoutPass_EventType = new(this, "WantsLayoutPass", 0, typeof(UnityEngine.EventType));
					r_MWantsLayoutPass_EventType.SetBelong(this.instance);
				}
				return r_MWantsLayoutPass_EventType;
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


        public REventInterests() : base("UnityEngine.EventInterests")
        {
        }

        public REventInterests(System.Object instance) : base("UnityEngine.EventInterests")
		{
            SetInstance(instance);
		}

        public REventInterests(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventInterests(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean WantsEvent(UnityEngine.EventType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMWantsEvent_EventType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WantsLayoutPass(UnityEngine.EventType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMWantsLayoutPass_EventType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
