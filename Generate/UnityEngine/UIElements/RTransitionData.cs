using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TransitionData
	/// </summary>
    public partial class RTransitionData : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TimeValue] transitionDelay
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTimeValue> r_transitionDelay;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTimeValue> RtransitionDelay
		{
			get
			{
				if(r_transitionDelay == null)
				{
					r_transitionDelay = new(this, "transitionDelay");
					r_transitionDelay.SetBelong(this.instance);
				}
				return r_transitionDelay;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TimeValue] transitionDuration
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTimeValue> r_transitionDuration;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTimeValue> RtransitionDuration
		{
			get
			{
				if(r_transitionDuration == null)
				{
					r_transitionDuration = new(this, "transitionDuration");
					r_transitionDuration.SetBelong(this.instance);
				}
				return r_transitionDuration;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StylePropertyName] transitionProperty
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStylePropertyName> r_transitionProperty;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStylePropertyName> RtransitionProperty
		{
			get
			{
				if(r_transitionProperty == null)
				{
					r_transitionProperty = new(this, "transitionProperty");
					r_transitionProperty.SetBelong(this.instance);
				}
				return r_transitionProperty;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.EasingFunction] transitionTimingFunction
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.REasingFunction> r_transitionTimingFunction;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.REasingFunction> RtransitionTimingFunction
		{
			get
			{
				if(r_transitionTimingFunction == null)
				{
					r_transitionTimingFunction = new(this, "transitionTimingFunction");
					r_transitionTimingFunction.SetBelong(this.instance);
				}
				return r_transitionTimingFunction;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TransitionData Copy()
		/// </summary>
		protected RMethod r_Copy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_Copy == null)
				{
					r_Copy = new(this, "Copy", 0);
					r_Copy.SetBelong(this.instance);
				}
				return r_Copy;
			}
		}

		/// <summary>
		/// Void CopyFrom(UnityEngine.UIElements.TransitionData ByRef)
		/// </summary>
		protected RMethod r_CopyFrom_Ref_TransitionData;
		public virtual RMethod RCopyFrom_Ref_TransitionData
		{
			get
			{
				if(r_CopyFrom_Ref_TransitionData == null)
				{
					r_CopyFrom_Ref_TransitionData = new(this, "CopyFrom", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData").MakeByRefType());
					r_CopyFrom_Ref_TransitionData.SetBelong(this.instance);
				}
				return r_CopyFrom_Ref_TransitionData;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.TransitionData, UnityEngine.UIElements.TransitionData)
		/// </summary>
		protected static RMethod r_op_Equality_TransitionData_TransitionData;
		public static RMethod Rop_Equality_TransitionData_TransitionData
		{
			get
			{
				if(r_op_Equality_TransitionData_TransitionData == null)
				{
					r_op_Equality_TransitionData_TransitionData = new( ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData"),  ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData"));
					r_op_Equality_TransitionData_TransitionData.SetBelong(null);
				}
				return r_op_Equality_TransitionData_TransitionData;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TransitionData, UnityEngine.UIElements.TransitionData)
		/// </summary>
		protected static RMethod r_op_Inequality_TransitionData_TransitionData;
		public static RMethod Rop_Inequality_TransitionData_TransitionData
		{
			get
			{
				if(r_op_Inequality_TransitionData_TransitionData == null)
				{
					r_op_Inequality_TransitionData_TransitionData = new( ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData"),  ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData"));
					r_op_Inequality_TransitionData_TransitionData.SetBelong(null);
				}
				return r_op_Inequality_TransitionData_TransitionData;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.TransitionData)
		/// </summary>
		protected RMethod r_Equals_TransitionData;
		public virtual RMethod REquals_TransitionData
		{
			get
			{
				if(r_Equals_TransitionData == null)
				{
					r_Equals_TransitionData = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData"));
					r_Equals_TransitionData.SetBelong(this.instance);
				}
				return r_Equals_TransitionData;
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


        public RTransitionData() : base("UnityEngine.UIElements.TransitionData")
        {
        }

        public RTransitionData(System.Object instance) : base("UnityEngine.UIElements.TransitionData")
		{
            SetInstance(instance);
		}

        public RTransitionData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTransitionData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual RUnityEngine.RUIElements.RTransitionData Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RTransitionData(___result);
        }


        public virtual void CopyFrom(ref RUnityEngine.RUIElements.RTransitionData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RCopyFrom_Ref_TransitionData.Invoke(___genericsType, ___parameters);
			@other = new RUnityEngine.RUIElements.RTransitionData(___parameters[0]);

            
        }


        public static System.Boolean op_Equality(RUnityEngine.RUIElements.RTransitionData @lhs, RUnityEngine.RUIElements.RTransitionData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = Rop_Equality_TransitionData_TransitionData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(RUnityEngine.RUIElements.RTransitionData @lhs, RUnityEngine.RUIElements.RTransitionData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = Rop_Inequality_TransitionData_TransitionData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(RUnityEngine.RUIElements.RTransitionData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = REquals_TransitionData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
