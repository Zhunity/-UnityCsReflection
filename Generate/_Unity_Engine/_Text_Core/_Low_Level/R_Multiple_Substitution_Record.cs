
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord
	/// </summary>
    public partial class RMultipleSubstitutionRecord : RMember //
    {

		/// <summary>
		/// System.UInt32 m_TargetGlyphID
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_Fm_TargetGlyphID;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFm_TargetGlyphID
		{
			get
			{
				if(r_Fm_TargetGlyphID == null)
				{
					r_Fm_TargetGlyphID = new(this, "m_TargetGlyphID");
					r_Fm_TargetGlyphID.SetBelong(this.instance);
				}
				return r_Fm_TargetGlyphID;
			}
		}

		/// <summary>
		/// System.UInt32[] m_SubstituteGlyphIDs
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RUInt32> r_Fm_SubstituteGlyphIDs;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RUInt32> RFm_SubstituteGlyphIDs
		{
			get
			{
				if(r_Fm_SubstituteGlyphIDs == null)
				{
					r_Fm_SubstituteGlyphIDs = new(this, "m_SubstituteGlyphIDs");
					r_Fm_SubstituteGlyphIDs.SetBelong(this.instance);
				}
				return r_Fm_SubstituteGlyphIDs;
			}
		}

		/// <summary>
		/// UInt32 targetGlyphID
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_PtargetGlyphID;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPtargetGlyphID
		{
			get
			{
				if(r_PtargetGlyphID == null)
				{
					r_PtargetGlyphID = new(this, "targetGlyphID", -1);
					r_PtargetGlyphID.SetBelong(this.instance);
				}
				return r_PtargetGlyphID;
			}
		}

		/// <summary>
		/// UInt32[] substituteGlyphIDs
		/// </summary>
		protected SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RUInt32> r_PsubstituteGlyphIDs;
		public virtual SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RUInt32> RPsubstituteGlyphIDs
		{
			get
			{
				if(r_PsubstituteGlyphIDs == null)
				{
					r_PsubstituteGlyphIDs = new(this, "substituteGlyphIDs", -1);
					r_PsubstituteGlyphIDs.SetBelong(this.instance);
				}
				return r_PsubstituteGlyphIDs;
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


        public RMultipleSubstitutionRecord() : base("UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord")
        {
        }

        public RMultipleSubstitutionRecord(System.Object instance) : base("UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord")
		{
            SetInstance(instance);
		}

        public RMultipleSubstitutionRecord(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMultipleSubstitutionRecord(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
