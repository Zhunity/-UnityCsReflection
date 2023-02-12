
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.ValueListBuilder`1
	/// </summary>
    public partial class RValueListBuilder<T> : RMember //
    {

		/// <summary>
		/// System.Span`1[T] _span
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RField> r_F_span;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RField> RF_span
		{
			get
			{
				if(r_F_span == null)
				{
					r_F_span = new(this, "_span");
					r_F_span.SetBelong(this.instance);
				}
				return r_F_span;
			}
		}

		/// <summary>
		/// T[] _arrayFromPool
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RField> r_F_arrayFromPool;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RField> RF_arrayFromPool
		{
			get
			{
				if(r_F_arrayFromPool == null)
				{
					r_F_arrayFromPool = new(this, "_arrayFromPool");
					r_F_arrayFromPool.SetBelong(this.instance);
				}
				return r_F_arrayFromPool;
			}
		}

		/// <summary>
		/// System.Int32 _pos
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_F_pos;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RF_pos
		{
			get
			{
				if(r_F_pos == null)
				{
					r_F_pos = new(this, "_pos");
					r_F_pos.SetBelong(this.instance);
				}
				return r_F_pos;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PLength;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
					r_PLength.SetBelong(this.instance);
				}
				return r_PLength;
			}
		}

		/// <summary>
		/// T& Item [Int32]
		/// </summary>
		protected SMFrame.Editor.Refleaction.RProperty r_PItem_Int32;
		public virtual SMFrame.Editor.Refleaction.RProperty RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_PItem_Int32.SetBelong(this.instance);
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// Void Append(T)
		/// </summary>
		protected RMethod r_MAppend_T;
		public virtual RMethod RMAppend_T
		{
			get
			{
				if(r_MAppend_T == null)
				{
					r_MAppend_T = new(this, "Append", 0, Type.MakeGenericMethodParameter(0));
					r_MAppend_T.SetBelong(this.instance);
				}
				return r_MAppend_T;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] AsSpan()
		/// </summary>
		protected RMethod r_MAsSpan;
		public virtual RMethod RMAsSpan
		{
			get
			{
				if(r_MAsSpan == null)
				{
					r_MAsSpan = new(this, "AsSpan", 0);
					r_MAsSpan.SetBelong(this.instance);
				}
				return r_MAsSpan;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Grow()
		/// </summary>
		protected RMethod r_MGrow;
		public virtual RMethod RMGrow
		{
			get
			{
				if(r_MGrow == null)
				{
					r_MGrow = new(this, "Grow", 0);
					r_MGrow.SetBelong(this.instance);
				}
				return r_MGrow;
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


        public RValueListBuilder() : base("System.Collections.Generic.ValueListBuilder`1")
        {
        }

        public RValueListBuilder(System.Object instance) : base("System.Collections.Generic.ValueListBuilder`1")
		{
            SetInstance(instance);
		}

        public RValueListBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RValueListBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Append(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMAppend_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType> AsSpan()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAsSpan.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType>(___result);
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Grow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGrow.Invoke(___genericsType, ___parameters);

            
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
