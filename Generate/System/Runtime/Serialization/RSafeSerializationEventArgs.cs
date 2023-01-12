using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RSerialization
{
	/// <summary>
	/// System.Runtime.Serialization.SafeSerializationEventArgs
	/// </summary>
    public partial class RSafeSerializationEventArgs : RMember //
    {

		/// <summary>
		/// System.Runtime.Serialization.StreamingContext m_streamingContext
		/// </summary>
		protected RSystem.RRuntime.RSerialization.RStreamingContext r_Fm_streamingContext;
		public virtual RSystem.RRuntime.RSerialization.RStreamingContext RFm_streamingContext
		{
			get
			{
				if(r_Fm_streamingContext == null)
				{
					r_Fm_streamingContext = new(this, "m_streamingContext");
					r_Fm_streamingContext.SetBelong(this.instance);
				}
				return r_Fm_streamingContext;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Object] m_serializedStates
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RObject> r_Fm_serializedStates;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RObject> RFm_serializedStates
		{
			get
			{
				if(r_Fm_serializedStates == null)
				{
					r_Fm_serializedStates = new(this, "m_serializedStates");
					r_Fm_serializedStates.SetBelong(this.instance);
				}
				return r_Fm_serializedStates;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Object] SerializedStates
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RObject> r_PSerializedStates;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RObject> RPSerializedStates
		{
			get
			{
				if(r_PSerializedStates == null)
				{
					r_PSerializedStates = new(this, "SerializedStates", -1);
					r_PSerializedStates.SetBelong(this.instance);
				}
				return r_PSerializedStates;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.StreamingContext StreamingContext
		/// </summary>
		protected RSystem.RRuntime.RSerialization.RStreamingContext r_PStreamingContext;
		public virtual RSystem.RRuntime.RSerialization.RStreamingContext RPStreamingContext
		{
			get
			{
				if(r_PStreamingContext == null)
				{
					r_PStreamingContext = new(this, "StreamingContext", -1);
					r_PStreamingContext.SetBelong(this.instance);
				}
				return r_PStreamingContext;
			}
		}

		/// <summary>
		/// Void AddSerializedState(System.Runtime.Serialization.ISafeSerializationData)
		/// </summary>
		protected RMethod r_MAddSerializedState_ISafeSerializationData;
		public virtual RMethod RMAddSerializedState_ISafeSerializationData
		{
			get
			{
				if(r_MAddSerializedState_ISafeSerializationData == null)
				{
					r_MAddSerializedState_ISafeSerializationData = new(this, "AddSerializedState", 0, typeof(System.Runtime.Serialization.ISafeSerializationData));
					r_MAddSerializedState_ISafeSerializationData.SetBelong(this.instance);
				}
				return r_MAddSerializedState_ISafeSerializationData;
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


        public RSafeSerializationEventArgs() : base("System.Runtime.Serialization.SafeSerializationEventArgs")
        {
        }

        public RSafeSerializationEventArgs(System.Object instance) : base("System.Runtime.Serialization.SafeSerializationEventArgs")
		{
            SetInstance(instance);
		}

        public RSafeSerializationEventArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSafeSerializationEventArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddSerializedState(System.Runtime.Serialization.ISafeSerializationData @serializedState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serializedState};
            var ___result = RMAddSerializedState_ISafeSerializationData.Invoke(___genericsType, ___parameters);

            
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
