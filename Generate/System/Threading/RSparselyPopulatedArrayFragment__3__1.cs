using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.SparselyPopulatedArrayFragment`1
	/// </summary>
    public partial class RSparselyPopulatedArrayFragment<T> : RMember // where T : class
    {

		/// <summary>
		/// T[] _elements
		/// </summary>
		protected RFieldArray<RField> r__elements;
		public virtual RFieldArray<RField> R_elements
		{
			get
			{
				if(r__elements == null)
				{
					r__elements = new(this, "_elements");
					r__elements.SetBelong(this.instance);
				}
				return r__elements;
			}
		}

		/// <summary>
		/// System.Int32 _freeCount
		/// </summary>
		protected RField r__freeCount;
		public virtual RField R_freeCount
		{
			get
			{
				if(r__freeCount == null)
				{
					r__freeCount = new(this, "_freeCount");
					r__freeCount.SetBelong(this.instance);
				}
				return r__freeCount;
			}
		}

		/// <summary>
		/// System.Threading.SparselyPopulatedArrayFragment`1[T] _next
		/// </summary>
		protected RSystem.RThreading.RSparselyPopulatedArrayFragment<RField> r__next;
		public virtual RSystem.RThreading.RSparselyPopulatedArrayFragment<RField> R_next
		{
			get
			{
				if(r__next == null)
				{
					r__next = new(this, "_next");
					r__next.SetBelong(this.instance);
				}
				return r__next;
			}
		}

		/// <summary>
		/// System.Threading.SparselyPopulatedArrayFragment`1[T] _prev
		/// </summary>
		protected RSystem.RThreading.RSparselyPopulatedArrayFragment<RField> r__prev;
		public virtual RSystem.RThreading.RSparselyPopulatedArrayFragment<RField> R_prev
		{
			get
			{
				if(r__prev == null)
				{
					r__prev = new(this, "_prev");
					r__prev.SetBelong(this.instance);
				}
				return r__prev;
			}
		}

		/// <summary>
		/// T Item [Int32]
		/// </summary>
		protected RProperty r_Item_Int32;
		public virtual RProperty RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RProperty r_Length;
		public virtual RProperty RLength
		{
			get
			{
				if(r_Length == null)
				{
					r_Length = new(this, "Length", -1);
					r_Length.SetBelong(this.instance);
				}
				return r_Length;
			}
		}

		/// <summary>
		/// System.Threading.SparselyPopulatedArrayFragment`1[T] Prev
		/// </summary>
		protected RSystem.RThreading.RSparselyPopulatedArrayFragment<RProperty> r_Prev;
		public virtual RSystem.RThreading.RSparselyPopulatedArrayFragment<RProperty> RPrev
		{
			get
			{
				if(r_Prev == null)
				{
					r_Prev = new(this, "Prev", -1);
					r_Prev.SetBelong(this.instance);
				}
				return r_Prev;
			}
		}

		/// <summary>
		/// T SafeAtomicRemove(Int32, T)
		/// </summary>
		protected RMethod r_SafeAtomicRemove_Int32_T;
		public virtual RMethod RSafeAtomicRemove_Int32_T
		{
			get
			{
				if(r_SafeAtomicRemove_Int32_T == null)
				{
					r_SafeAtomicRemove_Int32_T = new(this, "SafeAtomicRemove", 0, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_SafeAtomicRemove_Int32_T.SetBelong(this.instance);
				}
				return r_SafeAtomicRemove_Int32_T;
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


        public RSparselyPopulatedArrayFragment() : base("System.Threading.SparselyPopulatedArrayFragment`1")
        {
        }

        public RSparselyPopulatedArrayFragment(System.Object instance) : base("System.Threading.SparselyPopulatedArrayFragment`1")
		{
            SetInstance(instance);
		}

        public RSparselyPopulatedArrayFragment(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSparselyPopulatedArrayFragment(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual T SafeAtomicRemove(System.Int32 @index, T @expectedElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @expectedElement};
            var ___result = RSafeAtomicRemove_Int32_T.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
