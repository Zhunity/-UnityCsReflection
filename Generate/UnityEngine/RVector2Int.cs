using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Vector2Int
	/// </summary>
    public partial class RVector2Int : RMember //
    {

		/// <summary>
		/// System.Int32 m_X
		/// </summary>
		protected RField r_m_X;
		public virtual RField Rm_X
		{
			get
			{
				if(r_m_X == null)
				{
					r_m_X = new(this, "m_X");
					r_m_X.SetBelong(this.instance);
				}
				return r_m_X;
			}
		}

		/// <summary>
		/// System.Int32 m_Y
		/// </summary>
		protected RField r_m_Y;
		public virtual RField Rm_Y
		{
			get
			{
				if(r_m_Y == null)
				{
					r_m_Y = new(this, "m_Y");
					r_m_Y.SetBelong(this.instance);
				}
				return r_m_Y;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int s_Zero
		/// </summary>
		protected static RUnityEngine.RVector2Int r_s_Zero;
		public static RUnityEngine.RVector2Int Rs_Zero
		{
			get
			{
				if(r_s_Zero == null)
				{
					r_s_Zero = new(typeof(UnityEngine.Vector2Int), "s_Zero");
					r_s_Zero.SetBelong(null);
				}
				return r_s_Zero;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int s_One
		/// </summary>
		protected static RUnityEngine.RVector2Int r_s_One;
		public static RUnityEngine.RVector2Int Rs_One
		{
			get
			{
				if(r_s_One == null)
				{
					r_s_One = new(typeof(UnityEngine.Vector2Int), "s_One");
					r_s_One.SetBelong(null);
				}
				return r_s_One;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int s_Up
		/// </summary>
		protected static RUnityEngine.RVector2Int r_s_Up;
		public static RUnityEngine.RVector2Int Rs_Up
		{
			get
			{
				if(r_s_Up == null)
				{
					r_s_Up = new(typeof(UnityEngine.Vector2Int), "s_Up");
					r_s_Up.SetBelong(null);
				}
				return r_s_Up;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int s_Down
		/// </summary>
		protected static RUnityEngine.RVector2Int r_s_Down;
		public static RUnityEngine.RVector2Int Rs_Down
		{
			get
			{
				if(r_s_Down == null)
				{
					r_s_Down = new(typeof(UnityEngine.Vector2Int), "s_Down");
					r_s_Down.SetBelong(null);
				}
				return r_s_Down;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int s_Left
		/// </summary>
		protected static RUnityEngine.RVector2Int r_s_Left;
		public static RUnityEngine.RVector2Int Rs_Left
		{
			get
			{
				if(r_s_Left == null)
				{
					r_s_Left = new(typeof(UnityEngine.Vector2Int), "s_Left");
					r_s_Left.SetBelong(null);
				}
				return r_s_Left;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int s_Right
		/// </summary>
		protected static RUnityEngine.RVector2Int r_s_Right;
		public static RUnityEngine.RVector2Int Rs_Right
		{
			get
			{
				if(r_s_Right == null)
				{
					r_s_Right = new(typeof(UnityEngine.Vector2Int), "s_Right");
					r_s_Right.SetBelong(null);
				}
				return r_s_Right;
			}
		}

		/// <summary>
		/// Int32 x
		/// </summary>
		protected RProperty r_x;
		public virtual RProperty Rx
		{
			get
			{
				if(r_x == null)
				{
					r_x = new(this, "x", -1);
					r_x.SetBelong(this.instance);
				}
				return r_x;
			}
		}

		/// <summary>
		/// Int32 y
		/// </summary>
		protected RProperty r_y;
		public virtual RProperty Ry
		{
			get
			{
				if(r_y == null)
				{
					r_y = new(this, "y", -1);
					r_y.SetBelong(this.instance);
				}
				return r_y;
			}
		}

		/// <summary>
		/// Int32 Item [Int32]
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
		/// Single magnitude
		/// </summary>
		protected RProperty r_magnitude;
		public virtual RProperty Rmagnitude
		{
			get
			{
				if(r_magnitude == null)
				{
					r_magnitude = new(this, "magnitude", -1);
					r_magnitude.SetBelong(this.instance);
				}
				return r_magnitude;
			}
		}

		/// <summary>
		/// Int32 sqrMagnitude
		/// </summary>
		protected RProperty r_sqrMagnitude;
		public virtual RProperty RsqrMagnitude
		{
			get
			{
				if(r_sqrMagnitude == null)
				{
					r_sqrMagnitude = new(this, "sqrMagnitude", -1);
					r_sqrMagnitude.SetBelong(this.instance);
				}
				return r_sqrMagnitude;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int zero
		/// </summary>
		protected static RUnityEngine.RVector2Int r_zero;
		public static RUnityEngine.RVector2Int Rzero
		{
			get
			{
				if(r_zero == null)
				{
					r_zero = new(typeof(UnityEngine.Vector2Int), "zero", -1);
					r_zero.SetBelong(null);
				}
				return r_zero;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int one
		/// </summary>
		protected static RUnityEngine.RVector2Int r_one;
		public static RUnityEngine.RVector2Int Rone
		{
			get
			{
				if(r_one == null)
				{
					r_one = new(typeof(UnityEngine.Vector2Int), "one", -1);
					r_one.SetBelong(null);
				}
				return r_one;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int up
		/// </summary>
		protected static RUnityEngine.RVector2Int r_up;
		public static RUnityEngine.RVector2Int Rup
		{
			get
			{
				if(r_up == null)
				{
					r_up = new(typeof(UnityEngine.Vector2Int), "up", -1);
					r_up.SetBelong(null);
				}
				return r_up;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int down
		/// </summary>
		protected static RUnityEngine.RVector2Int r_down;
		public static RUnityEngine.RVector2Int Rdown
		{
			get
			{
				if(r_down == null)
				{
					r_down = new(typeof(UnityEngine.Vector2Int), "down", -1);
					r_down.SetBelong(null);
				}
				return r_down;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int left
		/// </summary>
		protected static RUnityEngine.RVector2Int r_left;
		public static RUnityEngine.RVector2Int Rleft
		{
			get
			{
				if(r_left == null)
				{
					r_left = new(typeof(UnityEngine.Vector2Int), "left", -1);
					r_left.SetBelong(null);
				}
				return r_left;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int right
		/// </summary>
		protected static RUnityEngine.RVector2Int r_right;
		public static RUnityEngine.RVector2Int Rright
		{
			get
			{
				if(r_right == null)
				{
					r_right = new(typeof(UnityEngine.Vector2Int), "right", -1);
					r_right.SetBelong(null);
				}
				return r_right;
			}
		}

		/// <summary>
		/// Void Set(Int32, Int32)
		/// </summary>
		protected RMethod r_Set_Int32_Int32;
		public virtual RMethod RSet_Int32_Int32
		{
			get
			{
				if(r_Set_Int32_Int32 == null)
				{
					r_Set_Int32_Int32 = new(this, "Set", 0, typeof(System.Int32), typeof(System.Int32));
					r_Set_Int32_Int32.SetBelong(this.instance);
				}
				return r_Set_Int32_Int32;
			}
		}

		/// <summary>
		/// Single Distance(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_Distance_Vector2Int_Vector2Int;
		public static RMethod RDistance_Vector2Int_Vector2Int
		{
			get
			{
				if(r_Distance_Vector2Int_Vector2Int == null)
				{
					r_Distance_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "Distance", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_Distance_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_Distance_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int Min(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_Min_Vector2Int_Vector2Int;
		public static RMethod RMin_Vector2Int_Vector2Int
		{
			get
			{
				if(r_Min_Vector2Int_Vector2Int == null)
				{
					r_Min_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "Min", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_Min_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_Min_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int Max(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_Max_Vector2Int_Vector2Int;
		public static RMethod RMax_Vector2Int_Vector2Int
		{
			get
			{
				if(r_Max_Vector2Int_Vector2Int == null)
				{
					r_Max_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "Max", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_Max_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_Max_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int Scale(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_Scale_Vector2Int_Vector2Int;
		public static RMethod RScale_Vector2Int_Vector2Int
		{
			get
			{
				if(r_Scale_Vector2Int_Vector2Int == null)
				{
					r_Scale_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "Scale", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_Scale_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_Scale_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// Void Scale(UnityEngine.Vector2Int)
		/// </summary>
		protected RMethod r_Scale_Vector2Int;
		public virtual RMethod RScale_Vector2Int
		{
			get
			{
				if(r_Scale_Vector2Int == null)
				{
					r_Scale_Vector2Int = new(this, "Scale", 0, typeof(UnityEngine.Vector2Int));
					r_Scale_Vector2Int.SetBelong(this.instance);
				}
				return r_Scale_Vector2Int;
			}
		}

		/// <summary>
		/// Void Clamp(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected RMethod r_Clamp_Vector2Int_Vector2Int;
		public virtual RMethod RClamp_Vector2Int_Vector2Int
		{
			get
			{
				if(r_Clamp_Vector2Int_Vector2Int == null)
				{
					r_Clamp_Vector2Int_Vector2Int = new(this, "Clamp", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_Clamp_Vector2Int_Vector2Int.SetBelong(this.instance);
				}
				return r_Clamp_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Implicit(UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_op_Implicit_Vector2Int;
		public static RMethod Rop_Implicit_Vector2Int
		{
			get
			{
				if(r_op_Implicit_Vector2Int == null)
				{
					r_op_Implicit_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Implicit", 0, typeof(UnityEngine.Vector2Int));
					r_op_Implicit_Vector2Int.SetBelong(null);
				}
				return r_op_Implicit_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_Explicit(UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_op_Explicit_Vector2Int;
		public static RMethod Rop_Explicit_Vector2Int
		{
			get
			{
				if(r_op_Explicit_Vector2Int == null)
				{
					r_op_Explicit_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Explicit", 0, typeof(UnityEngine.Vector2Int));
					r_op_Explicit_Vector2Int.SetBelong(null);
				}
				return r_op_Explicit_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int FloorToInt(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_FloorToInt_Vector2;
		public static RMethod RFloorToInt_Vector2
		{
			get
			{
				if(r_FloorToInt_Vector2 == null)
				{
					r_FloorToInt_Vector2 = new(typeof(UnityEngine.Vector2Int), "FloorToInt", 0, typeof(UnityEngine.Vector2));
					r_FloorToInt_Vector2.SetBelong(null);
				}
				return r_FloorToInt_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int CeilToInt(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_CeilToInt_Vector2;
		public static RMethod RCeilToInt_Vector2
		{
			get
			{
				if(r_CeilToInt_Vector2 == null)
				{
					r_CeilToInt_Vector2 = new(typeof(UnityEngine.Vector2Int), "CeilToInt", 0, typeof(UnityEngine.Vector2));
					r_CeilToInt_Vector2.SetBelong(null);
				}
				return r_CeilToInt_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int RoundToInt(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RoundToInt_Vector2;
		public static RMethod RRoundToInt_Vector2
		{
			get
			{
				if(r_RoundToInt_Vector2 == null)
				{
					r_RoundToInt_Vector2 = new(typeof(UnityEngine.Vector2Int), "RoundToInt", 0, typeof(UnityEngine.Vector2));
					r_RoundToInt_Vector2.SetBelong(null);
				}
				return r_RoundToInt_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_UnaryNegation(UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_op_UnaryNegation_Vector2Int;
		public static RMethod Rop_UnaryNegation_Vector2Int
		{
			get
			{
				if(r_op_UnaryNegation_Vector2Int == null)
				{
					r_op_UnaryNegation_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_UnaryNegation", 0, typeof(UnityEngine.Vector2Int));
					r_op_UnaryNegation_Vector2Int.SetBelong(null);
				}
				return r_op_UnaryNegation_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_Addition(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_op_Addition_Vector2Int_Vector2Int;
		public static RMethod Rop_Addition_Vector2Int_Vector2Int
		{
			get
			{
				if(r_op_Addition_Vector2Int_Vector2Int == null)
				{
					r_op_Addition_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Addition", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_op_Addition_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_op_Addition_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_Subtraction(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_op_Subtraction_Vector2Int_Vector2Int;
		public static RMethod Rop_Subtraction_Vector2Int_Vector2Int
		{
			get
			{
				if(r_op_Subtraction_Vector2Int_Vector2Int == null)
				{
					r_op_Subtraction_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Subtraction", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_op_Subtraction_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_op_Subtraction_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_Multiply(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_op_Multiply_Vector2Int_Vector2Int;
		public static RMethod Rop_Multiply_Vector2Int_Vector2Int
		{
			get
			{
				if(r_op_Multiply_Vector2Int_Vector2Int == null)
				{
					r_op_Multiply_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Multiply", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_op_Multiply_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_op_Multiply_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_Multiply(Int32, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_op_Multiply_Int32_Vector2Int;
		public static RMethod Rop_Multiply_Int32_Vector2Int
		{
			get
			{
				if(r_op_Multiply_Int32_Vector2Int == null)
				{
					r_op_Multiply_Int32_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Multiply", 0, typeof(System.Int32), typeof(UnityEngine.Vector2Int));
					r_op_Multiply_Int32_Vector2Int.SetBelong(null);
				}
				return r_op_Multiply_Int32_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_Multiply(UnityEngine.Vector2Int, Int32)
		/// </summary>
		protected static RMethod r_op_Multiply_Vector2Int_Int32;
		public static RMethod Rop_Multiply_Vector2Int_Int32
		{
			get
			{
				if(r_op_Multiply_Vector2Int_Int32 == null)
				{
					r_op_Multiply_Vector2Int_Int32 = new(typeof(UnityEngine.Vector2Int), "op_Multiply", 0, typeof(UnityEngine.Vector2Int), typeof(System.Int32));
					r_op_Multiply_Vector2Int_Int32.SetBelong(null);
				}
				return r_op_Multiply_Vector2Int_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_Division(UnityEngine.Vector2Int, Int32)
		/// </summary>
		protected static RMethod r_op_Division_Vector2Int_Int32;
		public static RMethod Rop_Division_Vector2Int_Int32
		{
			get
			{
				if(r_op_Division_Vector2Int_Int32 == null)
				{
					r_op_Division_Vector2Int_Int32 = new(typeof(UnityEngine.Vector2Int), "op_Division", 0, typeof(UnityEngine.Vector2Int), typeof(System.Int32));
					r_op_Division_Vector2Int_Int32.SetBelong(null);
				}
				return r_op_Division_Vector2Int_Int32;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_op_Equality_Vector2Int_Vector2Int;
		public static RMethod Rop_Equality_Vector2Int_Vector2Int
		{
			get
			{
				if(r_op_Equality_Vector2Int_Vector2Int == null)
				{
					r_op_Equality_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Equality", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_op_Equality_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_op_Equality_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_op_Inequality_Vector2Int_Vector2Int;
		public static RMethod Rop_Inequality_Vector2Int_Vector2Int
		{
			get
			{
				if(r_op_Inequality_Vector2Int_Vector2Int == null)
				{
					r_op_Inequality_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Inequality", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_op_Inequality_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_op_Inequality_Vector2Int_Vector2Int;
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
		/// Boolean Equals(UnityEngine.Vector2Int)
		/// </summary>
		protected RMethod r_Equals_Vector2Int;
		public virtual RMethod REquals_Vector2Int
		{
			get
			{
				if(r_Equals_Vector2Int == null)
				{
					r_Equals_Vector2Int = new(this, "Equals", 0, typeof(UnityEngine.Vector2Int));
					r_Equals_Vector2Int.SetBelong(this.instance);
				}
				return r_Equals_Vector2Int;
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
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_ToString_String;
		public virtual RMethod RToString_String
		{
			get
			{
				if(r_ToString_String == null)
				{
					r_ToString_String = new(this, "ToString", 0, typeof(System.String));
					r_ToString_String.SetBelong(this.instance);
				}
				return r_ToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToString_String_IFormatProvider;
		public virtual RMethod RToString_String_IFormatProvider
		{
			get
			{
				if(r_ToString_String_IFormatProvider == null)
				{
					r_ToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_ToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToString_String_IFormatProvider;
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


        public RVector2Int() : base("UnityEngine.Vector2Int")
        {
        }

        public RVector2Int(System.Object instance) : base("UnityEngine.Vector2Int")
		{
            SetInstance(instance);
		}

        public RVector2Int(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVector2Int(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Set(System.Int32 @x, System.Int32 @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RSet_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single Distance(UnityEngine.Vector2Int @a, UnityEngine.Vector2Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RDistance_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector2Int Min(UnityEngine.Vector2Int @lhs, UnityEngine.Vector2Int @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMin_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int Max(UnityEngine.Vector2Int @lhs, UnityEngine.Vector2Int @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMax_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int Scale(UnityEngine.Vector2Int @a, UnityEngine.Vector2Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RScale_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public virtual void Scale(UnityEngine.Vector2Int @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = RScale_Vector2Int.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clamp(UnityEngine.Vector2Int @min, UnityEngine.Vector2Int @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min, @max};
            var ___result = RClamp_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector2 op_Implicit(UnityEngine.Vector2Int @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector3Int op_Explicit(UnityEngine.Vector2Int @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Explicit_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector2Int FloorToInt(UnityEngine.Vector2 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RFloorToInt_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int CeilToInt(UnityEngine.Vector2 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RCeilToInt_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int RoundToInt(UnityEngine.Vector2 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RRoundToInt_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int op_UnaryNegation(UnityEngine.Vector2Int @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_UnaryNegation_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int op_Addition(UnityEngine.Vector2Int @a, UnityEngine.Vector2Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Addition_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int op_Subtraction(UnityEngine.Vector2Int @a, UnityEngine.Vector2Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Subtraction_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int op_Multiply(UnityEngine.Vector2Int @a, UnityEngine.Vector2Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Multiply_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int op_Multiply(System.Int32 @a, UnityEngine.Vector2Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Multiply_Int32_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int op_Multiply(UnityEngine.Vector2Int @a, System.Int32 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Multiply_Vector2Int_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int op_Division(UnityEngine.Vector2Int @a, System.Int32 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Division_Vector2Int_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Vector2Int @lhs, UnityEngine.Vector2Int @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Vector2Int @lhs, UnityEngine.Vector2Int @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Vector2Int @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Vector2Int.Invoke(___genericsType, ___parameters);

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


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

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
