using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.KeyCode
	/// </summary>
    public partial class RKeyCode : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected RSystem.RInt32 r_Fvalue__;
		public virtual RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
					r_Fvalue__.SetBelong(this.instance);
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode None
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FNone;
		public static RUnityEngine.RKeyCode RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new(typeof(UnityEngine.KeyCode), "None");
					r_FNone.SetBelong(null);
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Backspace
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FBackspace;
		public static RUnityEngine.RKeyCode RFBackspace
		{
			get
			{
				if(r_FBackspace == null)
				{
					r_FBackspace = new(typeof(UnityEngine.KeyCode), "Backspace");
					r_FBackspace.SetBelong(null);
				}
				return r_FBackspace;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Delete
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FDelete;
		public static RUnityEngine.RKeyCode RFDelete
		{
			get
			{
				if(r_FDelete == null)
				{
					r_FDelete = new(typeof(UnityEngine.KeyCode), "Delete");
					r_FDelete.SetBelong(null);
				}
				return r_FDelete;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Tab
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FTab;
		public static RUnityEngine.RKeyCode RFTab
		{
			get
			{
				if(r_FTab == null)
				{
					r_FTab = new(typeof(UnityEngine.KeyCode), "Tab");
					r_FTab.SetBelong(null);
				}
				return r_FTab;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Clear
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FClear;
		public static RUnityEngine.RKeyCode RFClear
		{
			get
			{
				if(r_FClear == null)
				{
					r_FClear = new(typeof(UnityEngine.KeyCode), "Clear");
					r_FClear.SetBelong(null);
				}
				return r_FClear;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Return
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FReturn;
		public static RUnityEngine.RKeyCode RFReturn
		{
			get
			{
				if(r_FReturn == null)
				{
					r_FReturn = new(typeof(UnityEngine.KeyCode), "Return");
					r_FReturn.SetBelong(null);
				}
				return r_FReturn;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Pause
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FPause;
		public static RUnityEngine.RKeyCode RFPause
		{
			get
			{
				if(r_FPause == null)
				{
					r_FPause = new(typeof(UnityEngine.KeyCode), "Pause");
					r_FPause.SetBelong(null);
				}
				return r_FPause;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Escape
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FEscape;
		public static RUnityEngine.RKeyCode RFEscape
		{
			get
			{
				if(r_FEscape == null)
				{
					r_FEscape = new(typeof(UnityEngine.KeyCode), "Escape");
					r_FEscape.SetBelong(null);
				}
				return r_FEscape;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Space
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FSpace;
		public static RUnityEngine.RKeyCode RFSpace
		{
			get
			{
				if(r_FSpace == null)
				{
					r_FSpace = new(typeof(UnityEngine.KeyCode), "Space");
					r_FSpace.SetBelong(null);
				}
				return r_FSpace;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad0
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypad0;
		public static RUnityEngine.RKeyCode RFKeypad0
		{
			get
			{
				if(r_FKeypad0 == null)
				{
					r_FKeypad0 = new(typeof(UnityEngine.KeyCode), "Keypad0");
					r_FKeypad0.SetBelong(null);
				}
				return r_FKeypad0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad1
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypad1;
		public static RUnityEngine.RKeyCode RFKeypad1
		{
			get
			{
				if(r_FKeypad1 == null)
				{
					r_FKeypad1 = new(typeof(UnityEngine.KeyCode), "Keypad1");
					r_FKeypad1.SetBelong(null);
				}
				return r_FKeypad1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad2
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypad2;
		public static RUnityEngine.RKeyCode RFKeypad2
		{
			get
			{
				if(r_FKeypad2 == null)
				{
					r_FKeypad2 = new(typeof(UnityEngine.KeyCode), "Keypad2");
					r_FKeypad2.SetBelong(null);
				}
				return r_FKeypad2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad3
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypad3;
		public static RUnityEngine.RKeyCode RFKeypad3
		{
			get
			{
				if(r_FKeypad3 == null)
				{
					r_FKeypad3 = new(typeof(UnityEngine.KeyCode), "Keypad3");
					r_FKeypad3.SetBelong(null);
				}
				return r_FKeypad3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad4
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypad4;
		public static RUnityEngine.RKeyCode RFKeypad4
		{
			get
			{
				if(r_FKeypad4 == null)
				{
					r_FKeypad4 = new(typeof(UnityEngine.KeyCode), "Keypad4");
					r_FKeypad4.SetBelong(null);
				}
				return r_FKeypad4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad5
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypad5;
		public static RUnityEngine.RKeyCode RFKeypad5
		{
			get
			{
				if(r_FKeypad5 == null)
				{
					r_FKeypad5 = new(typeof(UnityEngine.KeyCode), "Keypad5");
					r_FKeypad5.SetBelong(null);
				}
				return r_FKeypad5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad6
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypad6;
		public static RUnityEngine.RKeyCode RFKeypad6
		{
			get
			{
				if(r_FKeypad6 == null)
				{
					r_FKeypad6 = new(typeof(UnityEngine.KeyCode), "Keypad6");
					r_FKeypad6.SetBelong(null);
				}
				return r_FKeypad6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad7
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypad7;
		public static RUnityEngine.RKeyCode RFKeypad7
		{
			get
			{
				if(r_FKeypad7 == null)
				{
					r_FKeypad7 = new(typeof(UnityEngine.KeyCode), "Keypad7");
					r_FKeypad7.SetBelong(null);
				}
				return r_FKeypad7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad8
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypad8;
		public static RUnityEngine.RKeyCode RFKeypad8
		{
			get
			{
				if(r_FKeypad8 == null)
				{
					r_FKeypad8 = new(typeof(UnityEngine.KeyCode), "Keypad8");
					r_FKeypad8.SetBelong(null);
				}
				return r_FKeypad8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad9
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypad9;
		public static RUnityEngine.RKeyCode RFKeypad9
		{
			get
			{
				if(r_FKeypad9 == null)
				{
					r_FKeypad9 = new(typeof(UnityEngine.KeyCode), "Keypad9");
					r_FKeypad9.SetBelong(null);
				}
				return r_FKeypad9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode KeypadPeriod
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypadPeriod;
		public static RUnityEngine.RKeyCode RFKeypadPeriod
		{
			get
			{
				if(r_FKeypadPeriod == null)
				{
					r_FKeypadPeriod = new(typeof(UnityEngine.KeyCode), "KeypadPeriod");
					r_FKeypadPeriod.SetBelong(null);
				}
				return r_FKeypadPeriod;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode KeypadDivide
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypadDivide;
		public static RUnityEngine.RKeyCode RFKeypadDivide
		{
			get
			{
				if(r_FKeypadDivide == null)
				{
					r_FKeypadDivide = new(typeof(UnityEngine.KeyCode), "KeypadDivide");
					r_FKeypadDivide.SetBelong(null);
				}
				return r_FKeypadDivide;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode KeypadMultiply
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypadMultiply;
		public static RUnityEngine.RKeyCode RFKeypadMultiply
		{
			get
			{
				if(r_FKeypadMultiply == null)
				{
					r_FKeypadMultiply = new(typeof(UnityEngine.KeyCode), "KeypadMultiply");
					r_FKeypadMultiply.SetBelong(null);
				}
				return r_FKeypadMultiply;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode KeypadMinus
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypadMinus;
		public static RUnityEngine.RKeyCode RFKeypadMinus
		{
			get
			{
				if(r_FKeypadMinus == null)
				{
					r_FKeypadMinus = new(typeof(UnityEngine.KeyCode), "KeypadMinus");
					r_FKeypadMinus.SetBelong(null);
				}
				return r_FKeypadMinus;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode KeypadPlus
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypadPlus;
		public static RUnityEngine.RKeyCode RFKeypadPlus
		{
			get
			{
				if(r_FKeypadPlus == null)
				{
					r_FKeypadPlus = new(typeof(UnityEngine.KeyCode), "KeypadPlus");
					r_FKeypadPlus.SetBelong(null);
				}
				return r_FKeypadPlus;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode KeypadEnter
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypadEnter;
		public static RUnityEngine.RKeyCode RFKeypadEnter
		{
			get
			{
				if(r_FKeypadEnter == null)
				{
					r_FKeypadEnter = new(typeof(UnityEngine.KeyCode), "KeypadEnter");
					r_FKeypadEnter.SetBelong(null);
				}
				return r_FKeypadEnter;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode KeypadEquals
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FKeypadEquals;
		public static RUnityEngine.RKeyCode RFKeypadEquals
		{
			get
			{
				if(r_FKeypadEquals == null)
				{
					r_FKeypadEquals = new(typeof(UnityEngine.KeyCode), "KeypadEquals");
					r_FKeypadEquals.SetBelong(null);
				}
				return r_FKeypadEquals;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode UpArrow
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FUpArrow;
		public static RUnityEngine.RKeyCode RFUpArrow
		{
			get
			{
				if(r_FUpArrow == null)
				{
					r_FUpArrow = new(typeof(UnityEngine.KeyCode), "UpArrow");
					r_FUpArrow.SetBelong(null);
				}
				return r_FUpArrow;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode DownArrow
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FDownArrow;
		public static RUnityEngine.RKeyCode RFDownArrow
		{
			get
			{
				if(r_FDownArrow == null)
				{
					r_FDownArrow = new(typeof(UnityEngine.KeyCode), "DownArrow");
					r_FDownArrow.SetBelong(null);
				}
				return r_FDownArrow;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightArrow
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FRightArrow;
		public static RUnityEngine.RKeyCode RFRightArrow
		{
			get
			{
				if(r_FRightArrow == null)
				{
					r_FRightArrow = new(typeof(UnityEngine.KeyCode), "RightArrow");
					r_FRightArrow.SetBelong(null);
				}
				return r_FRightArrow;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftArrow
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FLeftArrow;
		public static RUnityEngine.RKeyCode RFLeftArrow
		{
			get
			{
				if(r_FLeftArrow == null)
				{
					r_FLeftArrow = new(typeof(UnityEngine.KeyCode), "LeftArrow");
					r_FLeftArrow.SetBelong(null);
				}
				return r_FLeftArrow;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Insert
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FInsert;
		public static RUnityEngine.RKeyCode RFInsert
		{
			get
			{
				if(r_FInsert == null)
				{
					r_FInsert = new(typeof(UnityEngine.KeyCode), "Insert");
					r_FInsert.SetBelong(null);
				}
				return r_FInsert;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Home
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FHome;
		public static RUnityEngine.RKeyCode RFHome
		{
			get
			{
				if(r_FHome == null)
				{
					r_FHome = new(typeof(UnityEngine.KeyCode), "Home");
					r_FHome.SetBelong(null);
				}
				return r_FHome;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode End
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FEnd;
		public static RUnityEngine.RKeyCode RFEnd
		{
			get
			{
				if(r_FEnd == null)
				{
					r_FEnd = new(typeof(UnityEngine.KeyCode), "End");
					r_FEnd.SetBelong(null);
				}
				return r_FEnd;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode PageUp
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FPageUp;
		public static RUnityEngine.RKeyCode RFPageUp
		{
			get
			{
				if(r_FPageUp == null)
				{
					r_FPageUp = new(typeof(UnityEngine.KeyCode), "PageUp");
					r_FPageUp.SetBelong(null);
				}
				return r_FPageUp;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode PageDown
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FPageDown;
		public static RUnityEngine.RKeyCode RFPageDown
		{
			get
			{
				if(r_FPageDown == null)
				{
					r_FPageDown = new(typeof(UnityEngine.KeyCode), "PageDown");
					r_FPageDown.SetBelong(null);
				}
				return r_FPageDown;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F1
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF1;
		public static RUnityEngine.RKeyCode RFF1
		{
			get
			{
				if(r_FF1 == null)
				{
					r_FF1 = new(typeof(UnityEngine.KeyCode), "F1");
					r_FF1.SetBelong(null);
				}
				return r_FF1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F2
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF2;
		public static RUnityEngine.RKeyCode RFF2
		{
			get
			{
				if(r_FF2 == null)
				{
					r_FF2 = new(typeof(UnityEngine.KeyCode), "F2");
					r_FF2.SetBelong(null);
				}
				return r_FF2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F3
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF3;
		public static RUnityEngine.RKeyCode RFF3
		{
			get
			{
				if(r_FF3 == null)
				{
					r_FF3 = new(typeof(UnityEngine.KeyCode), "F3");
					r_FF3.SetBelong(null);
				}
				return r_FF3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F4
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF4;
		public static RUnityEngine.RKeyCode RFF4
		{
			get
			{
				if(r_FF4 == null)
				{
					r_FF4 = new(typeof(UnityEngine.KeyCode), "F4");
					r_FF4.SetBelong(null);
				}
				return r_FF4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F5
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF5;
		public static RUnityEngine.RKeyCode RFF5
		{
			get
			{
				if(r_FF5 == null)
				{
					r_FF5 = new(typeof(UnityEngine.KeyCode), "F5");
					r_FF5.SetBelong(null);
				}
				return r_FF5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F6
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF6;
		public static RUnityEngine.RKeyCode RFF6
		{
			get
			{
				if(r_FF6 == null)
				{
					r_FF6 = new(typeof(UnityEngine.KeyCode), "F6");
					r_FF6.SetBelong(null);
				}
				return r_FF6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F7
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF7;
		public static RUnityEngine.RKeyCode RFF7
		{
			get
			{
				if(r_FF7 == null)
				{
					r_FF7 = new(typeof(UnityEngine.KeyCode), "F7");
					r_FF7.SetBelong(null);
				}
				return r_FF7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F8
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF8;
		public static RUnityEngine.RKeyCode RFF8
		{
			get
			{
				if(r_FF8 == null)
				{
					r_FF8 = new(typeof(UnityEngine.KeyCode), "F8");
					r_FF8.SetBelong(null);
				}
				return r_FF8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F9
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF9;
		public static RUnityEngine.RKeyCode RFF9
		{
			get
			{
				if(r_FF9 == null)
				{
					r_FF9 = new(typeof(UnityEngine.KeyCode), "F9");
					r_FF9.SetBelong(null);
				}
				return r_FF9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F10
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF10;
		public static RUnityEngine.RKeyCode RFF10
		{
			get
			{
				if(r_FF10 == null)
				{
					r_FF10 = new(typeof(UnityEngine.KeyCode), "F10");
					r_FF10.SetBelong(null);
				}
				return r_FF10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F11
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF11;
		public static RUnityEngine.RKeyCode RFF11
		{
			get
			{
				if(r_FF11 == null)
				{
					r_FF11 = new(typeof(UnityEngine.KeyCode), "F11");
					r_FF11.SetBelong(null);
				}
				return r_FF11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F12
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF12;
		public static RUnityEngine.RKeyCode RFF12
		{
			get
			{
				if(r_FF12 == null)
				{
					r_FF12 = new(typeof(UnityEngine.KeyCode), "F12");
					r_FF12.SetBelong(null);
				}
				return r_FF12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F13
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF13;
		public static RUnityEngine.RKeyCode RFF13
		{
			get
			{
				if(r_FF13 == null)
				{
					r_FF13 = new(typeof(UnityEngine.KeyCode), "F13");
					r_FF13.SetBelong(null);
				}
				return r_FF13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F14
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF14;
		public static RUnityEngine.RKeyCode RFF14
		{
			get
			{
				if(r_FF14 == null)
				{
					r_FF14 = new(typeof(UnityEngine.KeyCode), "F14");
					r_FF14.SetBelong(null);
				}
				return r_FF14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F15
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF15;
		public static RUnityEngine.RKeyCode RFF15
		{
			get
			{
				if(r_FF15 == null)
				{
					r_FF15 = new(typeof(UnityEngine.KeyCode), "F15");
					r_FF15.SetBelong(null);
				}
				return r_FF15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha0
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FAlpha0;
		public static RUnityEngine.RKeyCode RFAlpha0
		{
			get
			{
				if(r_FAlpha0 == null)
				{
					r_FAlpha0 = new(typeof(UnityEngine.KeyCode), "Alpha0");
					r_FAlpha0.SetBelong(null);
				}
				return r_FAlpha0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha1
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FAlpha1;
		public static RUnityEngine.RKeyCode RFAlpha1
		{
			get
			{
				if(r_FAlpha1 == null)
				{
					r_FAlpha1 = new(typeof(UnityEngine.KeyCode), "Alpha1");
					r_FAlpha1.SetBelong(null);
				}
				return r_FAlpha1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha2
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FAlpha2;
		public static RUnityEngine.RKeyCode RFAlpha2
		{
			get
			{
				if(r_FAlpha2 == null)
				{
					r_FAlpha2 = new(typeof(UnityEngine.KeyCode), "Alpha2");
					r_FAlpha2.SetBelong(null);
				}
				return r_FAlpha2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha3
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FAlpha3;
		public static RUnityEngine.RKeyCode RFAlpha3
		{
			get
			{
				if(r_FAlpha3 == null)
				{
					r_FAlpha3 = new(typeof(UnityEngine.KeyCode), "Alpha3");
					r_FAlpha3.SetBelong(null);
				}
				return r_FAlpha3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha4
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FAlpha4;
		public static RUnityEngine.RKeyCode RFAlpha4
		{
			get
			{
				if(r_FAlpha4 == null)
				{
					r_FAlpha4 = new(typeof(UnityEngine.KeyCode), "Alpha4");
					r_FAlpha4.SetBelong(null);
				}
				return r_FAlpha4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha5
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FAlpha5;
		public static RUnityEngine.RKeyCode RFAlpha5
		{
			get
			{
				if(r_FAlpha5 == null)
				{
					r_FAlpha5 = new(typeof(UnityEngine.KeyCode), "Alpha5");
					r_FAlpha5.SetBelong(null);
				}
				return r_FAlpha5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha6
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FAlpha6;
		public static RUnityEngine.RKeyCode RFAlpha6
		{
			get
			{
				if(r_FAlpha6 == null)
				{
					r_FAlpha6 = new(typeof(UnityEngine.KeyCode), "Alpha6");
					r_FAlpha6.SetBelong(null);
				}
				return r_FAlpha6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha7
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FAlpha7;
		public static RUnityEngine.RKeyCode RFAlpha7
		{
			get
			{
				if(r_FAlpha7 == null)
				{
					r_FAlpha7 = new(typeof(UnityEngine.KeyCode), "Alpha7");
					r_FAlpha7.SetBelong(null);
				}
				return r_FAlpha7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha8
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FAlpha8;
		public static RUnityEngine.RKeyCode RFAlpha8
		{
			get
			{
				if(r_FAlpha8 == null)
				{
					r_FAlpha8 = new(typeof(UnityEngine.KeyCode), "Alpha8");
					r_FAlpha8.SetBelong(null);
				}
				return r_FAlpha8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha9
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FAlpha9;
		public static RUnityEngine.RKeyCode RFAlpha9
		{
			get
			{
				if(r_FAlpha9 == null)
				{
					r_FAlpha9 = new(typeof(UnityEngine.KeyCode), "Alpha9");
					r_FAlpha9.SetBelong(null);
				}
				return r_FAlpha9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Exclaim
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FExclaim;
		public static RUnityEngine.RKeyCode RFExclaim
		{
			get
			{
				if(r_FExclaim == null)
				{
					r_FExclaim = new(typeof(UnityEngine.KeyCode), "Exclaim");
					r_FExclaim.SetBelong(null);
				}
				return r_FExclaim;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode DoubleQuote
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FDoubleQuote;
		public static RUnityEngine.RKeyCode RFDoubleQuote
		{
			get
			{
				if(r_FDoubleQuote == null)
				{
					r_FDoubleQuote = new(typeof(UnityEngine.KeyCode), "DoubleQuote");
					r_FDoubleQuote.SetBelong(null);
				}
				return r_FDoubleQuote;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Hash
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FHash;
		public static RUnityEngine.RKeyCode RFHash
		{
			get
			{
				if(r_FHash == null)
				{
					r_FHash = new(typeof(UnityEngine.KeyCode), "Hash");
					r_FHash.SetBelong(null);
				}
				return r_FHash;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Dollar
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FDollar;
		public static RUnityEngine.RKeyCode RFDollar
		{
			get
			{
				if(r_FDollar == null)
				{
					r_FDollar = new(typeof(UnityEngine.KeyCode), "Dollar");
					r_FDollar.SetBelong(null);
				}
				return r_FDollar;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Percent
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FPercent;
		public static RUnityEngine.RKeyCode RFPercent
		{
			get
			{
				if(r_FPercent == null)
				{
					r_FPercent = new(typeof(UnityEngine.KeyCode), "Percent");
					r_FPercent.SetBelong(null);
				}
				return r_FPercent;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Ampersand
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FAmpersand;
		public static RUnityEngine.RKeyCode RFAmpersand
		{
			get
			{
				if(r_FAmpersand == null)
				{
					r_FAmpersand = new(typeof(UnityEngine.KeyCode), "Ampersand");
					r_FAmpersand.SetBelong(null);
				}
				return r_FAmpersand;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Quote
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FQuote;
		public static RUnityEngine.RKeyCode RFQuote
		{
			get
			{
				if(r_FQuote == null)
				{
					r_FQuote = new(typeof(UnityEngine.KeyCode), "Quote");
					r_FQuote.SetBelong(null);
				}
				return r_FQuote;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftParen
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FLeftParen;
		public static RUnityEngine.RKeyCode RFLeftParen
		{
			get
			{
				if(r_FLeftParen == null)
				{
					r_FLeftParen = new(typeof(UnityEngine.KeyCode), "LeftParen");
					r_FLeftParen.SetBelong(null);
				}
				return r_FLeftParen;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightParen
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FRightParen;
		public static RUnityEngine.RKeyCode RFRightParen
		{
			get
			{
				if(r_FRightParen == null)
				{
					r_FRightParen = new(typeof(UnityEngine.KeyCode), "RightParen");
					r_FRightParen.SetBelong(null);
				}
				return r_FRightParen;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Asterisk
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FAsterisk;
		public static RUnityEngine.RKeyCode RFAsterisk
		{
			get
			{
				if(r_FAsterisk == null)
				{
					r_FAsterisk = new(typeof(UnityEngine.KeyCode), "Asterisk");
					r_FAsterisk.SetBelong(null);
				}
				return r_FAsterisk;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Plus
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FPlus;
		public static RUnityEngine.RKeyCode RFPlus
		{
			get
			{
				if(r_FPlus == null)
				{
					r_FPlus = new(typeof(UnityEngine.KeyCode), "Plus");
					r_FPlus.SetBelong(null);
				}
				return r_FPlus;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Comma
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FComma;
		public static RUnityEngine.RKeyCode RFComma
		{
			get
			{
				if(r_FComma == null)
				{
					r_FComma = new(typeof(UnityEngine.KeyCode), "Comma");
					r_FComma.SetBelong(null);
				}
				return r_FComma;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Minus
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FMinus;
		public static RUnityEngine.RKeyCode RFMinus
		{
			get
			{
				if(r_FMinus == null)
				{
					r_FMinus = new(typeof(UnityEngine.KeyCode), "Minus");
					r_FMinus.SetBelong(null);
				}
				return r_FMinus;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Period
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FPeriod;
		public static RUnityEngine.RKeyCode RFPeriod
		{
			get
			{
				if(r_FPeriod == null)
				{
					r_FPeriod = new(typeof(UnityEngine.KeyCode), "Period");
					r_FPeriod.SetBelong(null);
				}
				return r_FPeriod;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Slash
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FSlash;
		public static RUnityEngine.RKeyCode RFSlash
		{
			get
			{
				if(r_FSlash == null)
				{
					r_FSlash = new(typeof(UnityEngine.KeyCode), "Slash");
					r_FSlash.SetBelong(null);
				}
				return r_FSlash;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Colon
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FColon;
		public static RUnityEngine.RKeyCode RFColon
		{
			get
			{
				if(r_FColon == null)
				{
					r_FColon = new(typeof(UnityEngine.KeyCode), "Colon");
					r_FColon.SetBelong(null);
				}
				return r_FColon;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Semicolon
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FSemicolon;
		public static RUnityEngine.RKeyCode RFSemicolon
		{
			get
			{
				if(r_FSemicolon == null)
				{
					r_FSemicolon = new(typeof(UnityEngine.KeyCode), "Semicolon");
					r_FSemicolon.SetBelong(null);
				}
				return r_FSemicolon;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Less
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FLess;
		public static RUnityEngine.RKeyCode RFLess
		{
			get
			{
				if(r_FLess == null)
				{
					r_FLess = new(typeof(UnityEngine.KeyCode), "Less");
					r_FLess.SetBelong(null);
				}
				return r_FLess;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Equals
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FEquals;
		public static RUnityEngine.RKeyCode RFEquals
		{
			get
			{
				if(r_FEquals == null)
				{
					r_FEquals = new(typeof(UnityEngine.KeyCode), "Equals");
					r_FEquals.SetBelong(null);
				}
				return r_FEquals;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Greater
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FGreater;
		public static RUnityEngine.RKeyCode RFGreater
		{
			get
			{
				if(r_FGreater == null)
				{
					r_FGreater = new(typeof(UnityEngine.KeyCode), "Greater");
					r_FGreater.SetBelong(null);
				}
				return r_FGreater;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Question
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FQuestion;
		public static RUnityEngine.RKeyCode RFQuestion
		{
			get
			{
				if(r_FQuestion == null)
				{
					r_FQuestion = new(typeof(UnityEngine.KeyCode), "Question");
					r_FQuestion.SetBelong(null);
				}
				return r_FQuestion;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode At
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FAt;
		public static RUnityEngine.RKeyCode RFAt
		{
			get
			{
				if(r_FAt == null)
				{
					r_FAt = new(typeof(UnityEngine.KeyCode), "At");
					r_FAt.SetBelong(null);
				}
				return r_FAt;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftBracket
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FLeftBracket;
		public static RUnityEngine.RKeyCode RFLeftBracket
		{
			get
			{
				if(r_FLeftBracket == null)
				{
					r_FLeftBracket = new(typeof(UnityEngine.KeyCode), "LeftBracket");
					r_FLeftBracket.SetBelong(null);
				}
				return r_FLeftBracket;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Backslash
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FBackslash;
		public static RUnityEngine.RKeyCode RFBackslash
		{
			get
			{
				if(r_FBackslash == null)
				{
					r_FBackslash = new(typeof(UnityEngine.KeyCode), "Backslash");
					r_FBackslash.SetBelong(null);
				}
				return r_FBackslash;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightBracket
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FRightBracket;
		public static RUnityEngine.RKeyCode RFRightBracket
		{
			get
			{
				if(r_FRightBracket == null)
				{
					r_FRightBracket = new(typeof(UnityEngine.KeyCode), "RightBracket");
					r_FRightBracket.SetBelong(null);
				}
				return r_FRightBracket;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Caret
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FCaret;
		public static RUnityEngine.RKeyCode RFCaret
		{
			get
			{
				if(r_FCaret == null)
				{
					r_FCaret = new(typeof(UnityEngine.KeyCode), "Caret");
					r_FCaret.SetBelong(null);
				}
				return r_FCaret;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Underscore
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FUnderscore;
		public static RUnityEngine.RKeyCode RFUnderscore
		{
			get
			{
				if(r_FUnderscore == null)
				{
					r_FUnderscore = new(typeof(UnityEngine.KeyCode), "Underscore");
					r_FUnderscore.SetBelong(null);
				}
				return r_FUnderscore;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode BackQuote
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FBackQuote;
		public static RUnityEngine.RKeyCode RFBackQuote
		{
			get
			{
				if(r_FBackQuote == null)
				{
					r_FBackQuote = new(typeof(UnityEngine.KeyCode), "BackQuote");
					r_FBackQuote.SetBelong(null);
				}
				return r_FBackQuote;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode A
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FA;
		public static RUnityEngine.RKeyCode RFA
		{
			get
			{
				if(r_FA == null)
				{
					r_FA = new(typeof(UnityEngine.KeyCode), "A");
					r_FA.SetBelong(null);
				}
				return r_FA;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode B
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FB;
		public static RUnityEngine.RKeyCode RFB
		{
			get
			{
				if(r_FB == null)
				{
					r_FB = new(typeof(UnityEngine.KeyCode), "B");
					r_FB.SetBelong(null);
				}
				return r_FB;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode C
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FC;
		public static RUnityEngine.RKeyCode RFC
		{
			get
			{
				if(r_FC == null)
				{
					r_FC = new(typeof(UnityEngine.KeyCode), "C");
					r_FC.SetBelong(null);
				}
				return r_FC;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode D
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FD;
		public static RUnityEngine.RKeyCode RFD
		{
			get
			{
				if(r_FD == null)
				{
					r_FD = new(typeof(UnityEngine.KeyCode), "D");
					r_FD.SetBelong(null);
				}
				return r_FD;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode E
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FE;
		public static RUnityEngine.RKeyCode RFE
		{
			get
			{
				if(r_FE == null)
				{
					r_FE = new(typeof(UnityEngine.KeyCode), "E");
					r_FE.SetBelong(null);
				}
				return r_FE;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FF;
		public static RUnityEngine.RKeyCode RFF
		{
			get
			{
				if(r_FF == null)
				{
					r_FF = new(typeof(UnityEngine.KeyCode), "F");
					r_FF.SetBelong(null);
				}
				return r_FF;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode G
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FG;
		public static RUnityEngine.RKeyCode RFG
		{
			get
			{
				if(r_FG == null)
				{
					r_FG = new(typeof(UnityEngine.KeyCode), "G");
					r_FG.SetBelong(null);
				}
				return r_FG;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode H
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FH;
		public static RUnityEngine.RKeyCode RFH
		{
			get
			{
				if(r_FH == null)
				{
					r_FH = new(typeof(UnityEngine.KeyCode), "H");
					r_FH.SetBelong(null);
				}
				return r_FH;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode I
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FI;
		public static RUnityEngine.RKeyCode RFI
		{
			get
			{
				if(r_FI == null)
				{
					r_FI = new(typeof(UnityEngine.KeyCode), "I");
					r_FI.SetBelong(null);
				}
				return r_FI;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode J
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJ;
		public static RUnityEngine.RKeyCode RFJ
		{
			get
			{
				if(r_FJ == null)
				{
					r_FJ = new(typeof(UnityEngine.KeyCode), "J");
					r_FJ.SetBelong(null);
				}
				return r_FJ;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode K
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FK;
		public static RUnityEngine.RKeyCode RFK
		{
			get
			{
				if(r_FK == null)
				{
					r_FK = new(typeof(UnityEngine.KeyCode), "K");
					r_FK.SetBelong(null);
				}
				return r_FK;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode L
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FL;
		public static RUnityEngine.RKeyCode RFL
		{
			get
			{
				if(r_FL == null)
				{
					r_FL = new(typeof(UnityEngine.KeyCode), "L");
					r_FL.SetBelong(null);
				}
				return r_FL;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode M
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FM;
		public static RUnityEngine.RKeyCode RFM
		{
			get
			{
				if(r_FM == null)
				{
					r_FM = new(typeof(UnityEngine.KeyCode), "M");
					r_FM.SetBelong(null);
				}
				return r_FM;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode N
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FN;
		public static RUnityEngine.RKeyCode RFN
		{
			get
			{
				if(r_FN == null)
				{
					r_FN = new(typeof(UnityEngine.KeyCode), "N");
					r_FN.SetBelong(null);
				}
				return r_FN;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode O
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FO;
		public static RUnityEngine.RKeyCode RFO
		{
			get
			{
				if(r_FO == null)
				{
					r_FO = new(typeof(UnityEngine.KeyCode), "O");
					r_FO.SetBelong(null);
				}
				return r_FO;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode P
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FP;
		public static RUnityEngine.RKeyCode RFP
		{
			get
			{
				if(r_FP == null)
				{
					r_FP = new(typeof(UnityEngine.KeyCode), "P");
					r_FP.SetBelong(null);
				}
				return r_FP;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Q
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FQ;
		public static RUnityEngine.RKeyCode RFQ
		{
			get
			{
				if(r_FQ == null)
				{
					r_FQ = new(typeof(UnityEngine.KeyCode), "Q");
					r_FQ.SetBelong(null);
				}
				return r_FQ;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode R
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FR;
		public static RUnityEngine.RKeyCode RFR
		{
			get
			{
				if(r_FR == null)
				{
					r_FR = new(typeof(UnityEngine.KeyCode), "R");
					r_FR.SetBelong(null);
				}
				return r_FR;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode S
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FS;
		public static RUnityEngine.RKeyCode RFS
		{
			get
			{
				if(r_FS == null)
				{
					r_FS = new(typeof(UnityEngine.KeyCode), "S");
					r_FS.SetBelong(null);
				}
				return r_FS;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode T
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FT;
		public static RUnityEngine.RKeyCode RFT
		{
			get
			{
				if(r_FT == null)
				{
					r_FT = new(typeof(UnityEngine.KeyCode), "T");
					r_FT.SetBelong(null);
				}
				return r_FT;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode U
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FU;
		public static RUnityEngine.RKeyCode RFU
		{
			get
			{
				if(r_FU == null)
				{
					r_FU = new(typeof(UnityEngine.KeyCode), "U");
					r_FU.SetBelong(null);
				}
				return r_FU;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode V
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FV;
		public static RUnityEngine.RKeyCode RFV
		{
			get
			{
				if(r_FV == null)
				{
					r_FV = new(typeof(UnityEngine.KeyCode), "V");
					r_FV.SetBelong(null);
				}
				return r_FV;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode W
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FW;
		public static RUnityEngine.RKeyCode RFW
		{
			get
			{
				if(r_FW == null)
				{
					r_FW = new(typeof(UnityEngine.KeyCode), "W");
					r_FW.SetBelong(null);
				}
				return r_FW;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode X
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FX;
		public static RUnityEngine.RKeyCode RFX
		{
			get
			{
				if(r_FX == null)
				{
					r_FX = new(typeof(UnityEngine.KeyCode), "X");
					r_FX.SetBelong(null);
				}
				return r_FX;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Y
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FY;
		public static RUnityEngine.RKeyCode RFY
		{
			get
			{
				if(r_FY == null)
				{
					r_FY = new(typeof(UnityEngine.KeyCode), "Y");
					r_FY.SetBelong(null);
				}
				return r_FY;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Z
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FZ;
		public static RUnityEngine.RKeyCode RFZ
		{
			get
			{
				if(r_FZ == null)
				{
					r_FZ = new(typeof(UnityEngine.KeyCode), "Z");
					r_FZ.SetBelong(null);
				}
				return r_FZ;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftCurlyBracket
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FLeftCurlyBracket;
		public static RUnityEngine.RKeyCode RFLeftCurlyBracket
		{
			get
			{
				if(r_FLeftCurlyBracket == null)
				{
					r_FLeftCurlyBracket = new(typeof(UnityEngine.KeyCode), "LeftCurlyBracket");
					r_FLeftCurlyBracket.SetBelong(null);
				}
				return r_FLeftCurlyBracket;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Pipe
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FPipe;
		public static RUnityEngine.RKeyCode RFPipe
		{
			get
			{
				if(r_FPipe == null)
				{
					r_FPipe = new(typeof(UnityEngine.KeyCode), "Pipe");
					r_FPipe.SetBelong(null);
				}
				return r_FPipe;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightCurlyBracket
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FRightCurlyBracket;
		public static RUnityEngine.RKeyCode RFRightCurlyBracket
		{
			get
			{
				if(r_FRightCurlyBracket == null)
				{
					r_FRightCurlyBracket = new(typeof(UnityEngine.KeyCode), "RightCurlyBracket");
					r_FRightCurlyBracket.SetBelong(null);
				}
				return r_FRightCurlyBracket;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Tilde
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FTilde;
		public static RUnityEngine.RKeyCode RFTilde
		{
			get
			{
				if(r_FTilde == null)
				{
					r_FTilde = new(typeof(UnityEngine.KeyCode), "Tilde");
					r_FTilde.SetBelong(null);
				}
				return r_FTilde;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Numlock
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FNumlock;
		public static RUnityEngine.RKeyCode RFNumlock
		{
			get
			{
				if(r_FNumlock == null)
				{
					r_FNumlock = new(typeof(UnityEngine.KeyCode), "Numlock");
					r_FNumlock.SetBelong(null);
				}
				return r_FNumlock;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode CapsLock
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FCapsLock;
		public static RUnityEngine.RKeyCode RFCapsLock
		{
			get
			{
				if(r_FCapsLock == null)
				{
					r_FCapsLock = new(typeof(UnityEngine.KeyCode), "CapsLock");
					r_FCapsLock.SetBelong(null);
				}
				return r_FCapsLock;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode ScrollLock
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FScrollLock;
		public static RUnityEngine.RKeyCode RFScrollLock
		{
			get
			{
				if(r_FScrollLock == null)
				{
					r_FScrollLock = new(typeof(UnityEngine.KeyCode), "ScrollLock");
					r_FScrollLock.SetBelong(null);
				}
				return r_FScrollLock;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightShift
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FRightShift;
		public static RUnityEngine.RKeyCode RFRightShift
		{
			get
			{
				if(r_FRightShift == null)
				{
					r_FRightShift = new(typeof(UnityEngine.KeyCode), "RightShift");
					r_FRightShift.SetBelong(null);
				}
				return r_FRightShift;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftShift
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FLeftShift;
		public static RUnityEngine.RKeyCode RFLeftShift
		{
			get
			{
				if(r_FLeftShift == null)
				{
					r_FLeftShift = new(typeof(UnityEngine.KeyCode), "LeftShift");
					r_FLeftShift.SetBelong(null);
				}
				return r_FLeftShift;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightControl
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FRightControl;
		public static RUnityEngine.RKeyCode RFRightControl
		{
			get
			{
				if(r_FRightControl == null)
				{
					r_FRightControl = new(typeof(UnityEngine.KeyCode), "RightControl");
					r_FRightControl.SetBelong(null);
				}
				return r_FRightControl;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftControl
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FLeftControl;
		public static RUnityEngine.RKeyCode RFLeftControl
		{
			get
			{
				if(r_FLeftControl == null)
				{
					r_FLeftControl = new(typeof(UnityEngine.KeyCode), "LeftControl");
					r_FLeftControl.SetBelong(null);
				}
				return r_FLeftControl;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightAlt
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FRightAlt;
		public static RUnityEngine.RKeyCode RFRightAlt
		{
			get
			{
				if(r_FRightAlt == null)
				{
					r_FRightAlt = new(typeof(UnityEngine.KeyCode), "RightAlt");
					r_FRightAlt.SetBelong(null);
				}
				return r_FRightAlt;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftAlt
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FLeftAlt;
		public static RUnityEngine.RKeyCode RFLeftAlt
		{
			get
			{
				if(r_FLeftAlt == null)
				{
					r_FLeftAlt = new(typeof(UnityEngine.KeyCode), "LeftAlt");
					r_FLeftAlt.SetBelong(null);
				}
				return r_FLeftAlt;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftMeta
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FLeftMeta;
		public static RUnityEngine.RKeyCode RFLeftMeta
		{
			get
			{
				if(r_FLeftMeta == null)
				{
					r_FLeftMeta = new(typeof(UnityEngine.KeyCode), "LeftMeta");
					r_FLeftMeta.SetBelong(null);
				}
				return r_FLeftMeta;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftCommand
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FLeftCommand;
		public static RUnityEngine.RKeyCode RFLeftCommand
		{
			get
			{
				if(r_FLeftCommand == null)
				{
					r_FLeftCommand = new(typeof(UnityEngine.KeyCode), "LeftCommand");
					r_FLeftCommand.SetBelong(null);
				}
				return r_FLeftCommand;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftApple
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FLeftApple;
		public static RUnityEngine.RKeyCode RFLeftApple
		{
			get
			{
				if(r_FLeftApple == null)
				{
					r_FLeftApple = new(typeof(UnityEngine.KeyCode), "LeftApple");
					r_FLeftApple.SetBelong(null);
				}
				return r_FLeftApple;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftWindows
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FLeftWindows;
		public static RUnityEngine.RKeyCode RFLeftWindows
		{
			get
			{
				if(r_FLeftWindows == null)
				{
					r_FLeftWindows = new(typeof(UnityEngine.KeyCode), "LeftWindows");
					r_FLeftWindows.SetBelong(null);
				}
				return r_FLeftWindows;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightMeta
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FRightMeta;
		public static RUnityEngine.RKeyCode RFRightMeta
		{
			get
			{
				if(r_FRightMeta == null)
				{
					r_FRightMeta = new(typeof(UnityEngine.KeyCode), "RightMeta");
					r_FRightMeta.SetBelong(null);
				}
				return r_FRightMeta;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightCommand
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FRightCommand;
		public static RUnityEngine.RKeyCode RFRightCommand
		{
			get
			{
				if(r_FRightCommand == null)
				{
					r_FRightCommand = new(typeof(UnityEngine.KeyCode), "RightCommand");
					r_FRightCommand.SetBelong(null);
				}
				return r_FRightCommand;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightApple
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FRightApple;
		public static RUnityEngine.RKeyCode RFRightApple
		{
			get
			{
				if(r_FRightApple == null)
				{
					r_FRightApple = new(typeof(UnityEngine.KeyCode), "RightApple");
					r_FRightApple.SetBelong(null);
				}
				return r_FRightApple;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightWindows
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FRightWindows;
		public static RUnityEngine.RKeyCode RFRightWindows
		{
			get
			{
				if(r_FRightWindows == null)
				{
					r_FRightWindows = new(typeof(UnityEngine.KeyCode), "RightWindows");
					r_FRightWindows.SetBelong(null);
				}
				return r_FRightWindows;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode AltGr
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FAltGr;
		public static RUnityEngine.RKeyCode RFAltGr
		{
			get
			{
				if(r_FAltGr == null)
				{
					r_FAltGr = new(typeof(UnityEngine.KeyCode), "AltGr");
					r_FAltGr.SetBelong(null);
				}
				return r_FAltGr;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Help
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FHelp;
		public static RUnityEngine.RKeyCode RFHelp
		{
			get
			{
				if(r_FHelp == null)
				{
					r_FHelp = new(typeof(UnityEngine.KeyCode), "Help");
					r_FHelp.SetBelong(null);
				}
				return r_FHelp;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Print
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FPrint;
		public static RUnityEngine.RKeyCode RFPrint
		{
			get
			{
				if(r_FPrint == null)
				{
					r_FPrint = new(typeof(UnityEngine.KeyCode), "Print");
					r_FPrint.SetBelong(null);
				}
				return r_FPrint;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode SysReq
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FSysReq;
		public static RUnityEngine.RKeyCode RFSysReq
		{
			get
			{
				if(r_FSysReq == null)
				{
					r_FSysReq = new(typeof(UnityEngine.KeyCode), "SysReq");
					r_FSysReq.SetBelong(null);
				}
				return r_FSysReq;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Break
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FBreak;
		public static RUnityEngine.RKeyCode RFBreak
		{
			get
			{
				if(r_FBreak == null)
				{
					r_FBreak = new(typeof(UnityEngine.KeyCode), "Break");
					r_FBreak.SetBelong(null);
				}
				return r_FBreak;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Menu
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FMenu;
		public static RUnityEngine.RKeyCode RFMenu
		{
			get
			{
				if(r_FMenu == null)
				{
					r_FMenu = new(typeof(UnityEngine.KeyCode), "Menu");
					r_FMenu.SetBelong(null);
				}
				return r_FMenu;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Mouse0
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FMouse0;
		public static RUnityEngine.RKeyCode RFMouse0
		{
			get
			{
				if(r_FMouse0 == null)
				{
					r_FMouse0 = new(typeof(UnityEngine.KeyCode), "Mouse0");
					r_FMouse0.SetBelong(null);
				}
				return r_FMouse0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Mouse1
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FMouse1;
		public static RUnityEngine.RKeyCode RFMouse1
		{
			get
			{
				if(r_FMouse1 == null)
				{
					r_FMouse1 = new(typeof(UnityEngine.KeyCode), "Mouse1");
					r_FMouse1.SetBelong(null);
				}
				return r_FMouse1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Mouse2
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FMouse2;
		public static RUnityEngine.RKeyCode RFMouse2
		{
			get
			{
				if(r_FMouse2 == null)
				{
					r_FMouse2 = new(typeof(UnityEngine.KeyCode), "Mouse2");
					r_FMouse2.SetBelong(null);
				}
				return r_FMouse2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Mouse3
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FMouse3;
		public static RUnityEngine.RKeyCode RFMouse3
		{
			get
			{
				if(r_FMouse3 == null)
				{
					r_FMouse3 = new(typeof(UnityEngine.KeyCode), "Mouse3");
					r_FMouse3.SetBelong(null);
				}
				return r_FMouse3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Mouse4
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FMouse4;
		public static RUnityEngine.RKeyCode RFMouse4
		{
			get
			{
				if(r_FMouse4 == null)
				{
					r_FMouse4 = new(typeof(UnityEngine.KeyCode), "Mouse4");
					r_FMouse4.SetBelong(null);
				}
				return r_FMouse4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Mouse5
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FMouse5;
		public static RUnityEngine.RKeyCode RFMouse5
		{
			get
			{
				if(r_FMouse5 == null)
				{
					r_FMouse5 = new(typeof(UnityEngine.KeyCode), "Mouse5");
					r_FMouse5.SetBelong(null);
				}
				return r_FMouse5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Mouse6
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FMouse6;
		public static RUnityEngine.RKeyCode RFMouse6
		{
			get
			{
				if(r_FMouse6 == null)
				{
					r_FMouse6 = new(typeof(UnityEngine.KeyCode), "Mouse6");
					r_FMouse6.SetBelong(null);
				}
				return r_FMouse6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton0
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton0;
		public static RUnityEngine.RKeyCode RFJoystickButton0
		{
			get
			{
				if(r_FJoystickButton0 == null)
				{
					r_FJoystickButton0 = new(typeof(UnityEngine.KeyCode), "JoystickButton0");
					r_FJoystickButton0.SetBelong(null);
				}
				return r_FJoystickButton0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton1
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton1;
		public static RUnityEngine.RKeyCode RFJoystickButton1
		{
			get
			{
				if(r_FJoystickButton1 == null)
				{
					r_FJoystickButton1 = new(typeof(UnityEngine.KeyCode), "JoystickButton1");
					r_FJoystickButton1.SetBelong(null);
				}
				return r_FJoystickButton1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton2
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton2;
		public static RUnityEngine.RKeyCode RFJoystickButton2
		{
			get
			{
				if(r_FJoystickButton2 == null)
				{
					r_FJoystickButton2 = new(typeof(UnityEngine.KeyCode), "JoystickButton2");
					r_FJoystickButton2.SetBelong(null);
				}
				return r_FJoystickButton2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton3
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton3;
		public static RUnityEngine.RKeyCode RFJoystickButton3
		{
			get
			{
				if(r_FJoystickButton3 == null)
				{
					r_FJoystickButton3 = new(typeof(UnityEngine.KeyCode), "JoystickButton3");
					r_FJoystickButton3.SetBelong(null);
				}
				return r_FJoystickButton3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton4
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton4;
		public static RUnityEngine.RKeyCode RFJoystickButton4
		{
			get
			{
				if(r_FJoystickButton4 == null)
				{
					r_FJoystickButton4 = new(typeof(UnityEngine.KeyCode), "JoystickButton4");
					r_FJoystickButton4.SetBelong(null);
				}
				return r_FJoystickButton4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton5
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton5;
		public static RUnityEngine.RKeyCode RFJoystickButton5
		{
			get
			{
				if(r_FJoystickButton5 == null)
				{
					r_FJoystickButton5 = new(typeof(UnityEngine.KeyCode), "JoystickButton5");
					r_FJoystickButton5.SetBelong(null);
				}
				return r_FJoystickButton5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton6
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton6;
		public static RUnityEngine.RKeyCode RFJoystickButton6
		{
			get
			{
				if(r_FJoystickButton6 == null)
				{
					r_FJoystickButton6 = new(typeof(UnityEngine.KeyCode), "JoystickButton6");
					r_FJoystickButton6.SetBelong(null);
				}
				return r_FJoystickButton6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton7
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton7;
		public static RUnityEngine.RKeyCode RFJoystickButton7
		{
			get
			{
				if(r_FJoystickButton7 == null)
				{
					r_FJoystickButton7 = new(typeof(UnityEngine.KeyCode), "JoystickButton7");
					r_FJoystickButton7.SetBelong(null);
				}
				return r_FJoystickButton7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton8
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton8;
		public static RUnityEngine.RKeyCode RFJoystickButton8
		{
			get
			{
				if(r_FJoystickButton8 == null)
				{
					r_FJoystickButton8 = new(typeof(UnityEngine.KeyCode), "JoystickButton8");
					r_FJoystickButton8.SetBelong(null);
				}
				return r_FJoystickButton8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton9
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton9;
		public static RUnityEngine.RKeyCode RFJoystickButton9
		{
			get
			{
				if(r_FJoystickButton9 == null)
				{
					r_FJoystickButton9 = new(typeof(UnityEngine.KeyCode), "JoystickButton9");
					r_FJoystickButton9.SetBelong(null);
				}
				return r_FJoystickButton9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton10
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton10;
		public static RUnityEngine.RKeyCode RFJoystickButton10
		{
			get
			{
				if(r_FJoystickButton10 == null)
				{
					r_FJoystickButton10 = new(typeof(UnityEngine.KeyCode), "JoystickButton10");
					r_FJoystickButton10.SetBelong(null);
				}
				return r_FJoystickButton10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton11
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton11;
		public static RUnityEngine.RKeyCode RFJoystickButton11
		{
			get
			{
				if(r_FJoystickButton11 == null)
				{
					r_FJoystickButton11 = new(typeof(UnityEngine.KeyCode), "JoystickButton11");
					r_FJoystickButton11.SetBelong(null);
				}
				return r_FJoystickButton11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton12
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton12;
		public static RUnityEngine.RKeyCode RFJoystickButton12
		{
			get
			{
				if(r_FJoystickButton12 == null)
				{
					r_FJoystickButton12 = new(typeof(UnityEngine.KeyCode), "JoystickButton12");
					r_FJoystickButton12.SetBelong(null);
				}
				return r_FJoystickButton12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton13
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton13;
		public static RUnityEngine.RKeyCode RFJoystickButton13
		{
			get
			{
				if(r_FJoystickButton13 == null)
				{
					r_FJoystickButton13 = new(typeof(UnityEngine.KeyCode), "JoystickButton13");
					r_FJoystickButton13.SetBelong(null);
				}
				return r_FJoystickButton13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton14
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton14;
		public static RUnityEngine.RKeyCode RFJoystickButton14
		{
			get
			{
				if(r_FJoystickButton14 == null)
				{
					r_FJoystickButton14 = new(typeof(UnityEngine.KeyCode), "JoystickButton14");
					r_FJoystickButton14.SetBelong(null);
				}
				return r_FJoystickButton14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton15
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton15;
		public static RUnityEngine.RKeyCode RFJoystickButton15
		{
			get
			{
				if(r_FJoystickButton15 == null)
				{
					r_FJoystickButton15 = new(typeof(UnityEngine.KeyCode), "JoystickButton15");
					r_FJoystickButton15.SetBelong(null);
				}
				return r_FJoystickButton15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton16
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton16;
		public static RUnityEngine.RKeyCode RFJoystickButton16
		{
			get
			{
				if(r_FJoystickButton16 == null)
				{
					r_FJoystickButton16 = new(typeof(UnityEngine.KeyCode), "JoystickButton16");
					r_FJoystickButton16.SetBelong(null);
				}
				return r_FJoystickButton16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton17
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton17;
		public static RUnityEngine.RKeyCode RFJoystickButton17
		{
			get
			{
				if(r_FJoystickButton17 == null)
				{
					r_FJoystickButton17 = new(typeof(UnityEngine.KeyCode), "JoystickButton17");
					r_FJoystickButton17.SetBelong(null);
				}
				return r_FJoystickButton17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton18
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton18;
		public static RUnityEngine.RKeyCode RFJoystickButton18
		{
			get
			{
				if(r_FJoystickButton18 == null)
				{
					r_FJoystickButton18 = new(typeof(UnityEngine.KeyCode), "JoystickButton18");
					r_FJoystickButton18.SetBelong(null);
				}
				return r_FJoystickButton18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton19
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystickButton19;
		public static RUnityEngine.RKeyCode RFJoystickButton19
		{
			get
			{
				if(r_FJoystickButton19 == null)
				{
					r_FJoystickButton19 = new(typeof(UnityEngine.KeyCode), "JoystickButton19");
					r_FJoystickButton19.SetBelong(null);
				}
				return r_FJoystickButton19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button0
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button0;
		public static RUnityEngine.RKeyCode RFJoystick1Button0
		{
			get
			{
				if(r_FJoystick1Button0 == null)
				{
					r_FJoystick1Button0 = new(typeof(UnityEngine.KeyCode), "Joystick1Button0");
					r_FJoystick1Button0.SetBelong(null);
				}
				return r_FJoystick1Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button1
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button1;
		public static RUnityEngine.RKeyCode RFJoystick1Button1
		{
			get
			{
				if(r_FJoystick1Button1 == null)
				{
					r_FJoystick1Button1 = new(typeof(UnityEngine.KeyCode), "Joystick1Button1");
					r_FJoystick1Button1.SetBelong(null);
				}
				return r_FJoystick1Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button2
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button2;
		public static RUnityEngine.RKeyCode RFJoystick1Button2
		{
			get
			{
				if(r_FJoystick1Button2 == null)
				{
					r_FJoystick1Button2 = new(typeof(UnityEngine.KeyCode), "Joystick1Button2");
					r_FJoystick1Button2.SetBelong(null);
				}
				return r_FJoystick1Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button3
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button3;
		public static RUnityEngine.RKeyCode RFJoystick1Button3
		{
			get
			{
				if(r_FJoystick1Button3 == null)
				{
					r_FJoystick1Button3 = new(typeof(UnityEngine.KeyCode), "Joystick1Button3");
					r_FJoystick1Button3.SetBelong(null);
				}
				return r_FJoystick1Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button4
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button4;
		public static RUnityEngine.RKeyCode RFJoystick1Button4
		{
			get
			{
				if(r_FJoystick1Button4 == null)
				{
					r_FJoystick1Button4 = new(typeof(UnityEngine.KeyCode), "Joystick1Button4");
					r_FJoystick1Button4.SetBelong(null);
				}
				return r_FJoystick1Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button5
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button5;
		public static RUnityEngine.RKeyCode RFJoystick1Button5
		{
			get
			{
				if(r_FJoystick1Button5 == null)
				{
					r_FJoystick1Button5 = new(typeof(UnityEngine.KeyCode), "Joystick1Button5");
					r_FJoystick1Button5.SetBelong(null);
				}
				return r_FJoystick1Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button6
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button6;
		public static RUnityEngine.RKeyCode RFJoystick1Button6
		{
			get
			{
				if(r_FJoystick1Button6 == null)
				{
					r_FJoystick1Button6 = new(typeof(UnityEngine.KeyCode), "Joystick1Button6");
					r_FJoystick1Button6.SetBelong(null);
				}
				return r_FJoystick1Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button7
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button7;
		public static RUnityEngine.RKeyCode RFJoystick1Button7
		{
			get
			{
				if(r_FJoystick1Button7 == null)
				{
					r_FJoystick1Button7 = new(typeof(UnityEngine.KeyCode), "Joystick1Button7");
					r_FJoystick1Button7.SetBelong(null);
				}
				return r_FJoystick1Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button8
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button8;
		public static RUnityEngine.RKeyCode RFJoystick1Button8
		{
			get
			{
				if(r_FJoystick1Button8 == null)
				{
					r_FJoystick1Button8 = new(typeof(UnityEngine.KeyCode), "Joystick1Button8");
					r_FJoystick1Button8.SetBelong(null);
				}
				return r_FJoystick1Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button9
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button9;
		public static RUnityEngine.RKeyCode RFJoystick1Button9
		{
			get
			{
				if(r_FJoystick1Button9 == null)
				{
					r_FJoystick1Button9 = new(typeof(UnityEngine.KeyCode), "Joystick1Button9");
					r_FJoystick1Button9.SetBelong(null);
				}
				return r_FJoystick1Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button10
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button10;
		public static RUnityEngine.RKeyCode RFJoystick1Button10
		{
			get
			{
				if(r_FJoystick1Button10 == null)
				{
					r_FJoystick1Button10 = new(typeof(UnityEngine.KeyCode), "Joystick1Button10");
					r_FJoystick1Button10.SetBelong(null);
				}
				return r_FJoystick1Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button11
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button11;
		public static RUnityEngine.RKeyCode RFJoystick1Button11
		{
			get
			{
				if(r_FJoystick1Button11 == null)
				{
					r_FJoystick1Button11 = new(typeof(UnityEngine.KeyCode), "Joystick1Button11");
					r_FJoystick1Button11.SetBelong(null);
				}
				return r_FJoystick1Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button12
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button12;
		public static RUnityEngine.RKeyCode RFJoystick1Button12
		{
			get
			{
				if(r_FJoystick1Button12 == null)
				{
					r_FJoystick1Button12 = new(typeof(UnityEngine.KeyCode), "Joystick1Button12");
					r_FJoystick1Button12.SetBelong(null);
				}
				return r_FJoystick1Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button13
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button13;
		public static RUnityEngine.RKeyCode RFJoystick1Button13
		{
			get
			{
				if(r_FJoystick1Button13 == null)
				{
					r_FJoystick1Button13 = new(typeof(UnityEngine.KeyCode), "Joystick1Button13");
					r_FJoystick1Button13.SetBelong(null);
				}
				return r_FJoystick1Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button14
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button14;
		public static RUnityEngine.RKeyCode RFJoystick1Button14
		{
			get
			{
				if(r_FJoystick1Button14 == null)
				{
					r_FJoystick1Button14 = new(typeof(UnityEngine.KeyCode), "Joystick1Button14");
					r_FJoystick1Button14.SetBelong(null);
				}
				return r_FJoystick1Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button15
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button15;
		public static RUnityEngine.RKeyCode RFJoystick1Button15
		{
			get
			{
				if(r_FJoystick1Button15 == null)
				{
					r_FJoystick1Button15 = new(typeof(UnityEngine.KeyCode), "Joystick1Button15");
					r_FJoystick1Button15.SetBelong(null);
				}
				return r_FJoystick1Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button16
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button16;
		public static RUnityEngine.RKeyCode RFJoystick1Button16
		{
			get
			{
				if(r_FJoystick1Button16 == null)
				{
					r_FJoystick1Button16 = new(typeof(UnityEngine.KeyCode), "Joystick1Button16");
					r_FJoystick1Button16.SetBelong(null);
				}
				return r_FJoystick1Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button17
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button17;
		public static RUnityEngine.RKeyCode RFJoystick1Button17
		{
			get
			{
				if(r_FJoystick1Button17 == null)
				{
					r_FJoystick1Button17 = new(typeof(UnityEngine.KeyCode), "Joystick1Button17");
					r_FJoystick1Button17.SetBelong(null);
				}
				return r_FJoystick1Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button18
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button18;
		public static RUnityEngine.RKeyCode RFJoystick1Button18
		{
			get
			{
				if(r_FJoystick1Button18 == null)
				{
					r_FJoystick1Button18 = new(typeof(UnityEngine.KeyCode), "Joystick1Button18");
					r_FJoystick1Button18.SetBelong(null);
				}
				return r_FJoystick1Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button19
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick1Button19;
		public static RUnityEngine.RKeyCode RFJoystick1Button19
		{
			get
			{
				if(r_FJoystick1Button19 == null)
				{
					r_FJoystick1Button19 = new(typeof(UnityEngine.KeyCode), "Joystick1Button19");
					r_FJoystick1Button19.SetBelong(null);
				}
				return r_FJoystick1Button19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button0
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button0;
		public static RUnityEngine.RKeyCode RFJoystick2Button0
		{
			get
			{
				if(r_FJoystick2Button0 == null)
				{
					r_FJoystick2Button0 = new(typeof(UnityEngine.KeyCode), "Joystick2Button0");
					r_FJoystick2Button0.SetBelong(null);
				}
				return r_FJoystick2Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button1
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button1;
		public static RUnityEngine.RKeyCode RFJoystick2Button1
		{
			get
			{
				if(r_FJoystick2Button1 == null)
				{
					r_FJoystick2Button1 = new(typeof(UnityEngine.KeyCode), "Joystick2Button1");
					r_FJoystick2Button1.SetBelong(null);
				}
				return r_FJoystick2Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button2
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button2;
		public static RUnityEngine.RKeyCode RFJoystick2Button2
		{
			get
			{
				if(r_FJoystick2Button2 == null)
				{
					r_FJoystick2Button2 = new(typeof(UnityEngine.KeyCode), "Joystick2Button2");
					r_FJoystick2Button2.SetBelong(null);
				}
				return r_FJoystick2Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button3
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button3;
		public static RUnityEngine.RKeyCode RFJoystick2Button3
		{
			get
			{
				if(r_FJoystick2Button3 == null)
				{
					r_FJoystick2Button3 = new(typeof(UnityEngine.KeyCode), "Joystick2Button3");
					r_FJoystick2Button3.SetBelong(null);
				}
				return r_FJoystick2Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button4
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button4;
		public static RUnityEngine.RKeyCode RFJoystick2Button4
		{
			get
			{
				if(r_FJoystick2Button4 == null)
				{
					r_FJoystick2Button4 = new(typeof(UnityEngine.KeyCode), "Joystick2Button4");
					r_FJoystick2Button4.SetBelong(null);
				}
				return r_FJoystick2Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button5
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button5;
		public static RUnityEngine.RKeyCode RFJoystick2Button5
		{
			get
			{
				if(r_FJoystick2Button5 == null)
				{
					r_FJoystick2Button5 = new(typeof(UnityEngine.KeyCode), "Joystick2Button5");
					r_FJoystick2Button5.SetBelong(null);
				}
				return r_FJoystick2Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button6
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button6;
		public static RUnityEngine.RKeyCode RFJoystick2Button6
		{
			get
			{
				if(r_FJoystick2Button6 == null)
				{
					r_FJoystick2Button6 = new(typeof(UnityEngine.KeyCode), "Joystick2Button6");
					r_FJoystick2Button6.SetBelong(null);
				}
				return r_FJoystick2Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button7
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button7;
		public static RUnityEngine.RKeyCode RFJoystick2Button7
		{
			get
			{
				if(r_FJoystick2Button7 == null)
				{
					r_FJoystick2Button7 = new(typeof(UnityEngine.KeyCode), "Joystick2Button7");
					r_FJoystick2Button7.SetBelong(null);
				}
				return r_FJoystick2Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button8
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button8;
		public static RUnityEngine.RKeyCode RFJoystick2Button8
		{
			get
			{
				if(r_FJoystick2Button8 == null)
				{
					r_FJoystick2Button8 = new(typeof(UnityEngine.KeyCode), "Joystick2Button8");
					r_FJoystick2Button8.SetBelong(null);
				}
				return r_FJoystick2Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button9
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button9;
		public static RUnityEngine.RKeyCode RFJoystick2Button9
		{
			get
			{
				if(r_FJoystick2Button9 == null)
				{
					r_FJoystick2Button9 = new(typeof(UnityEngine.KeyCode), "Joystick2Button9");
					r_FJoystick2Button9.SetBelong(null);
				}
				return r_FJoystick2Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button10
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button10;
		public static RUnityEngine.RKeyCode RFJoystick2Button10
		{
			get
			{
				if(r_FJoystick2Button10 == null)
				{
					r_FJoystick2Button10 = new(typeof(UnityEngine.KeyCode), "Joystick2Button10");
					r_FJoystick2Button10.SetBelong(null);
				}
				return r_FJoystick2Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button11
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button11;
		public static RUnityEngine.RKeyCode RFJoystick2Button11
		{
			get
			{
				if(r_FJoystick2Button11 == null)
				{
					r_FJoystick2Button11 = new(typeof(UnityEngine.KeyCode), "Joystick2Button11");
					r_FJoystick2Button11.SetBelong(null);
				}
				return r_FJoystick2Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button12
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button12;
		public static RUnityEngine.RKeyCode RFJoystick2Button12
		{
			get
			{
				if(r_FJoystick2Button12 == null)
				{
					r_FJoystick2Button12 = new(typeof(UnityEngine.KeyCode), "Joystick2Button12");
					r_FJoystick2Button12.SetBelong(null);
				}
				return r_FJoystick2Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button13
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button13;
		public static RUnityEngine.RKeyCode RFJoystick2Button13
		{
			get
			{
				if(r_FJoystick2Button13 == null)
				{
					r_FJoystick2Button13 = new(typeof(UnityEngine.KeyCode), "Joystick2Button13");
					r_FJoystick2Button13.SetBelong(null);
				}
				return r_FJoystick2Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button14
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button14;
		public static RUnityEngine.RKeyCode RFJoystick2Button14
		{
			get
			{
				if(r_FJoystick2Button14 == null)
				{
					r_FJoystick2Button14 = new(typeof(UnityEngine.KeyCode), "Joystick2Button14");
					r_FJoystick2Button14.SetBelong(null);
				}
				return r_FJoystick2Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button15
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button15;
		public static RUnityEngine.RKeyCode RFJoystick2Button15
		{
			get
			{
				if(r_FJoystick2Button15 == null)
				{
					r_FJoystick2Button15 = new(typeof(UnityEngine.KeyCode), "Joystick2Button15");
					r_FJoystick2Button15.SetBelong(null);
				}
				return r_FJoystick2Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button16
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button16;
		public static RUnityEngine.RKeyCode RFJoystick2Button16
		{
			get
			{
				if(r_FJoystick2Button16 == null)
				{
					r_FJoystick2Button16 = new(typeof(UnityEngine.KeyCode), "Joystick2Button16");
					r_FJoystick2Button16.SetBelong(null);
				}
				return r_FJoystick2Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button17
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button17;
		public static RUnityEngine.RKeyCode RFJoystick2Button17
		{
			get
			{
				if(r_FJoystick2Button17 == null)
				{
					r_FJoystick2Button17 = new(typeof(UnityEngine.KeyCode), "Joystick2Button17");
					r_FJoystick2Button17.SetBelong(null);
				}
				return r_FJoystick2Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button18
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button18;
		public static RUnityEngine.RKeyCode RFJoystick2Button18
		{
			get
			{
				if(r_FJoystick2Button18 == null)
				{
					r_FJoystick2Button18 = new(typeof(UnityEngine.KeyCode), "Joystick2Button18");
					r_FJoystick2Button18.SetBelong(null);
				}
				return r_FJoystick2Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button19
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick2Button19;
		public static RUnityEngine.RKeyCode RFJoystick2Button19
		{
			get
			{
				if(r_FJoystick2Button19 == null)
				{
					r_FJoystick2Button19 = new(typeof(UnityEngine.KeyCode), "Joystick2Button19");
					r_FJoystick2Button19.SetBelong(null);
				}
				return r_FJoystick2Button19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button0
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button0;
		public static RUnityEngine.RKeyCode RFJoystick3Button0
		{
			get
			{
				if(r_FJoystick3Button0 == null)
				{
					r_FJoystick3Button0 = new(typeof(UnityEngine.KeyCode), "Joystick3Button0");
					r_FJoystick3Button0.SetBelong(null);
				}
				return r_FJoystick3Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button1
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button1;
		public static RUnityEngine.RKeyCode RFJoystick3Button1
		{
			get
			{
				if(r_FJoystick3Button1 == null)
				{
					r_FJoystick3Button1 = new(typeof(UnityEngine.KeyCode), "Joystick3Button1");
					r_FJoystick3Button1.SetBelong(null);
				}
				return r_FJoystick3Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button2
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button2;
		public static RUnityEngine.RKeyCode RFJoystick3Button2
		{
			get
			{
				if(r_FJoystick3Button2 == null)
				{
					r_FJoystick3Button2 = new(typeof(UnityEngine.KeyCode), "Joystick3Button2");
					r_FJoystick3Button2.SetBelong(null);
				}
				return r_FJoystick3Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button3
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button3;
		public static RUnityEngine.RKeyCode RFJoystick3Button3
		{
			get
			{
				if(r_FJoystick3Button3 == null)
				{
					r_FJoystick3Button3 = new(typeof(UnityEngine.KeyCode), "Joystick3Button3");
					r_FJoystick3Button3.SetBelong(null);
				}
				return r_FJoystick3Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button4
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button4;
		public static RUnityEngine.RKeyCode RFJoystick3Button4
		{
			get
			{
				if(r_FJoystick3Button4 == null)
				{
					r_FJoystick3Button4 = new(typeof(UnityEngine.KeyCode), "Joystick3Button4");
					r_FJoystick3Button4.SetBelong(null);
				}
				return r_FJoystick3Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button5
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button5;
		public static RUnityEngine.RKeyCode RFJoystick3Button5
		{
			get
			{
				if(r_FJoystick3Button5 == null)
				{
					r_FJoystick3Button5 = new(typeof(UnityEngine.KeyCode), "Joystick3Button5");
					r_FJoystick3Button5.SetBelong(null);
				}
				return r_FJoystick3Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button6
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button6;
		public static RUnityEngine.RKeyCode RFJoystick3Button6
		{
			get
			{
				if(r_FJoystick3Button6 == null)
				{
					r_FJoystick3Button6 = new(typeof(UnityEngine.KeyCode), "Joystick3Button6");
					r_FJoystick3Button6.SetBelong(null);
				}
				return r_FJoystick3Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button7
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button7;
		public static RUnityEngine.RKeyCode RFJoystick3Button7
		{
			get
			{
				if(r_FJoystick3Button7 == null)
				{
					r_FJoystick3Button7 = new(typeof(UnityEngine.KeyCode), "Joystick3Button7");
					r_FJoystick3Button7.SetBelong(null);
				}
				return r_FJoystick3Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button8
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button8;
		public static RUnityEngine.RKeyCode RFJoystick3Button8
		{
			get
			{
				if(r_FJoystick3Button8 == null)
				{
					r_FJoystick3Button8 = new(typeof(UnityEngine.KeyCode), "Joystick3Button8");
					r_FJoystick3Button8.SetBelong(null);
				}
				return r_FJoystick3Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button9
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button9;
		public static RUnityEngine.RKeyCode RFJoystick3Button9
		{
			get
			{
				if(r_FJoystick3Button9 == null)
				{
					r_FJoystick3Button9 = new(typeof(UnityEngine.KeyCode), "Joystick3Button9");
					r_FJoystick3Button9.SetBelong(null);
				}
				return r_FJoystick3Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button10
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button10;
		public static RUnityEngine.RKeyCode RFJoystick3Button10
		{
			get
			{
				if(r_FJoystick3Button10 == null)
				{
					r_FJoystick3Button10 = new(typeof(UnityEngine.KeyCode), "Joystick3Button10");
					r_FJoystick3Button10.SetBelong(null);
				}
				return r_FJoystick3Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button11
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button11;
		public static RUnityEngine.RKeyCode RFJoystick3Button11
		{
			get
			{
				if(r_FJoystick3Button11 == null)
				{
					r_FJoystick3Button11 = new(typeof(UnityEngine.KeyCode), "Joystick3Button11");
					r_FJoystick3Button11.SetBelong(null);
				}
				return r_FJoystick3Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button12
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button12;
		public static RUnityEngine.RKeyCode RFJoystick3Button12
		{
			get
			{
				if(r_FJoystick3Button12 == null)
				{
					r_FJoystick3Button12 = new(typeof(UnityEngine.KeyCode), "Joystick3Button12");
					r_FJoystick3Button12.SetBelong(null);
				}
				return r_FJoystick3Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button13
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button13;
		public static RUnityEngine.RKeyCode RFJoystick3Button13
		{
			get
			{
				if(r_FJoystick3Button13 == null)
				{
					r_FJoystick3Button13 = new(typeof(UnityEngine.KeyCode), "Joystick3Button13");
					r_FJoystick3Button13.SetBelong(null);
				}
				return r_FJoystick3Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button14
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button14;
		public static RUnityEngine.RKeyCode RFJoystick3Button14
		{
			get
			{
				if(r_FJoystick3Button14 == null)
				{
					r_FJoystick3Button14 = new(typeof(UnityEngine.KeyCode), "Joystick3Button14");
					r_FJoystick3Button14.SetBelong(null);
				}
				return r_FJoystick3Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button15
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button15;
		public static RUnityEngine.RKeyCode RFJoystick3Button15
		{
			get
			{
				if(r_FJoystick3Button15 == null)
				{
					r_FJoystick3Button15 = new(typeof(UnityEngine.KeyCode), "Joystick3Button15");
					r_FJoystick3Button15.SetBelong(null);
				}
				return r_FJoystick3Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button16
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button16;
		public static RUnityEngine.RKeyCode RFJoystick3Button16
		{
			get
			{
				if(r_FJoystick3Button16 == null)
				{
					r_FJoystick3Button16 = new(typeof(UnityEngine.KeyCode), "Joystick3Button16");
					r_FJoystick3Button16.SetBelong(null);
				}
				return r_FJoystick3Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button17
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button17;
		public static RUnityEngine.RKeyCode RFJoystick3Button17
		{
			get
			{
				if(r_FJoystick3Button17 == null)
				{
					r_FJoystick3Button17 = new(typeof(UnityEngine.KeyCode), "Joystick3Button17");
					r_FJoystick3Button17.SetBelong(null);
				}
				return r_FJoystick3Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button18
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button18;
		public static RUnityEngine.RKeyCode RFJoystick3Button18
		{
			get
			{
				if(r_FJoystick3Button18 == null)
				{
					r_FJoystick3Button18 = new(typeof(UnityEngine.KeyCode), "Joystick3Button18");
					r_FJoystick3Button18.SetBelong(null);
				}
				return r_FJoystick3Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button19
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick3Button19;
		public static RUnityEngine.RKeyCode RFJoystick3Button19
		{
			get
			{
				if(r_FJoystick3Button19 == null)
				{
					r_FJoystick3Button19 = new(typeof(UnityEngine.KeyCode), "Joystick3Button19");
					r_FJoystick3Button19.SetBelong(null);
				}
				return r_FJoystick3Button19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button0
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button0;
		public static RUnityEngine.RKeyCode RFJoystick4Button0
		{
			get
			{
				if(r_FJoystick4Button0 == null)
				{
					r_FJoystick4Button0 = new(typeof(UnityEngine.KeyCode), "Joystick4Button0");
					r_FJoystick4Button0.SetBelong(null);
				}
				return r_FJoystick4Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button1
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button1;
		public static RUnityEngine.RKeyCode RFJoystick4Button1
		{
			get
			{
				if(r_FJoystick4Button1 == null)
				{
					r_FJoystick4Button1 = new(typeof(UnityEngine.KeyCode), "Joystick4Button1");
					r_FJoystick4Button1.SetBelong(null);
				}
				return r_FJoystick4Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button2
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button2;
		public static RUnityEngine.RKeyCode RFJoystick4Button2
		{
			get
			{
				if(r_FJoystick4Button2 == null)
				{
					r_FJoystick4Button2 = new(typeof(UnityEngine.KeyCode), "Joystick4Button2");
					r_FJoystick4Button2.SetBelong(null);
				}
				return r_FJoystick4Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button3
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button3;
		public static RUnityEngine.RKeyCode RFJoystick4Button3
		{
			get
			{
				if(r_FJoystick4Button3 == null)
				{
					r_FJoystick4Button3 = new(typeof(UnityEngine.KeyCode), "Joystick4Button3");
					r_FJoystick4Button3.SetBelong(null);
				}
				return r_FJoystick4Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button4
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button4;
		public static RUnityEngine.RKeyCode RFJoystick4Button4
		{
			get
			{
				if(r_FJoystick4Button4 == null)
				{
					r_FJoystick4Button4 = new(typeof(UnityEngine.KeyCode), "Joystick4Button4");
					r_FJoystick4Button4.SetBelong(null);
				}
				return r_FJoystick4Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button5
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button5;
		public static RUnityEngine.RKeyCode RFJoystick4Button5
		{
			get
			{
				if(r_FJoystick4Button5 == null)
				{
					r_FJoystick4Button5 = new(typeof(UnityEngine.KeyCode), "Joystick4Button5");
					r_FJoystick4Button5.SetBelong(null);
				}
				return r_FJoystick4Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button6
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button6;
		public static RUnityEngine.RKeyCode RFJoystick4Button6
		{
			get
			{
				if(r_FJoystick4Button6 == null)
				{
					r_FJoystick4Button6 = new(typeof(UnityEngine.KeyCode), "Joystick4Button6");
					r_FJoystick4Button6.SetBelong(null);
				}
				return r_FJoystick4Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button7
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button7;
		public static RUnityEngine.RKeyCode RFJoystick4Button7
		{
			get
			{
				if(r_FJoystick4Button7 == null)
				{
					r_FJoystick4Button7 = new(typeof(UnityEngine.KeyCode), "Joystick4Button7");
					r_FJoystick4Button7.SetBelong(null);
				}
				return r_FJoystick4Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button8
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button8;
		public static RUnityEngine.RKeyCode RFJoystick4Button8
		{
			get
			{
				if(r_FJoystick4Button8 == null)
				{
					r_FJoystick4Button8 = new(typeof(UnityEngine.KeyCode), "Joystick4Button8");
					r_FJoystick4Button8.SetBelong(null);
				}
				return r_FJoystick4Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button9
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button9;
		public static RUnityEngine.RKeyCode RFJoystick4Button9
		{
			get
			{
				if(r_FJoystick4Button9 == null)
				{
					r_FJoystick4Button9 = new(typeof(UnityEngine.KeyCode), "Joystick4Button9");
					r_FJoystick4Button9.SetBelong(null);
				}
				return r_FJoystick4Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button10
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button10;
		public static RUnityEngine.RKeyCode RFJoystick4Button10
		{
			get
			{
				if(r_FJoystick4Button10 == null)
				{
					r_FJoystick4Button10 = new(typeof(UnityEngine.KeyCode), "Joystick4Button10");
					r_FJoystick4Button10.SetBelong(null);
				}
				return r_FJoystick4Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button11
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button11;
		public static RUnityEngine.RKeyCode RFJoystick4Button11
		{
			get
			{
				if(r_FJoystick4Button11 == null)
				{
					r_FJoystick4Button11 = new(typeof(UnityEngine.KeyCode), "Joystick4Button11");
					r_FJoystick4Button11.SetBelong(null);
				}
				return r_FJoystick4Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button12
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button12;
		public static RUnityEngine.RKeyCode RFJoystick4Button12
		{
			get
			{
				if(r_FJoystick4Button12 == null)
				{
					r_FJoystick4Button12 = new(typeof(UnityEngine.KeyCode), "Joystick4Button12");
					r_FJoystick4Button12.SetBelong(null);
				}
				return r_FJoystick4Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button13
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button13;
		public static RUnityEngine.RKeyCode RFJoystick4Button13
		{
			get
			{
				if(r_FJoystick4Button13 == null)
				{
					r_FJoystick4Button13 = new(typeof(UnityEngine.KeyCode), "Joystick4Button13");
					r_FJoystick4Button13.SetBelong(null);
				}
				return r_FJoystick4Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button14
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button14;
		public static RUnityEngine.RKeyCode RFJoystick4Button14
		{
			get
			{
				if(r_FJoystick4Button14 == null)
				{
					r_FJoystick4Button14 = new(typeof(UnityEngine.KeyCode), "Joystick4Button14");
					r_FJoystick4Button14.SetBelong(null);
				}
				return r_FJoystick4Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button15
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button15;
		public static RUnityEngine.RKeyCode RFJoystick4Button15
		{
			get
			{
				if(r_FJoystick4Button15 == null)
				{
					r_FJoystick4Button15 = new(typeof(UnityEngine.KeyCode), "Joystick4Button15");
					r_FJoystick4Button15.SetBelong(null);
				}
				return r_FJoystick4Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button16
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button16;
		public static RUnityEngine.RKeyCode RFJoystick4Button16
		{
			get
			{
				if(r_FJoystick4Button16 == null)
				{
					r_FJoystick4Button16 = new(typeof(UnityEngine.KeyCode), "Joystick4Button16");
					r_FJoystick4Button16.SetBelong(null);
				}
				return r_FJoystick4Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button17
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button17;
		public static RUnityEngine.RKeyCode RFJoystick4Button17
		{
			get
			{
				if(r_FJoystick4Button17 == null)
				{
					r_FJoystick4Button17 = new(typeof(UnityEngine.KeyCode), "Joystick4Button17");
					r_FJoystick4Button17.SetBelong(null);
				}
				return r_FJoystick4Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button18
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button18;
		public static RUnityEngine.RKeyCode RFJoystick4Button18
		{
			get
			{
				if(r_FJoystick4Button18 == null)
				{
					r_FJoystick4Button18 = new(typeof(UnityEngine.KeyCode), "Joystick4Button18");
					r_FJoystick4Button18.SetBelong(null);
				}
				return r_FJoystick4Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button19
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick4Button19;
		public static RUnityEngine.RKeyCode RFJoystick4Button19
		{
			get
			{
				if(r_FJoystick4Button19 == null)
				{
					r_FJoystick4Button19 = new(typeof(UnityEngine.KeyCode), "Joystick4Button19");
					r_FJoystick4Button19.SetBelong(null);
				}
				return r_FJoystick4Button19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button0
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button0;
		public static RUnityEngine.RKeyCode RFJoystick5Button0
		{
			get
			{
				if(r_FJoystick5Button0 == null)
				{
					r_FJoystick5Button0 = new(typeof(UnityEngine.KeyCode), "Joystick5Button0");
					r_FJoystick5Button0.SetBelong(null);
				}
				return r_FJoystick5Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button1
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button1;
		public static RUnityEngine.RKeyCode RFJoystick5Button1
		{
			get
			{
				if(r_FJoystick5Button1 == null)
				{
					r_FJoystick5Button1 = new(typeof(UnityEngine.KeyCode), "Joystick5Button1");
					r_FJoystick5Button1.SetBelong(null);
				}
				return r_FJoystick5Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button2
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button2;
		public static RUnityEngine.RKeyCode RFJoystick5Button2
		{
			get
			{
				if(r_FJoystick5Button2 == null)
				{
					r_FJoystick5Button2 = new(typeof(UnityEngine.KeyCode), "Joystick5Button2");
					r_FJoystick5Button2.SetBelong(null);
				}
				return r_FJoystick5Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button3
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button3;
		public static RUnityEngine.RKeyCode RFJoystick5Button3
		{
			get
			{
				if(r_FJoystick5Button3 == null)
				{
					r_FJoystick5Button3 = new(typeof(UnityEngine.KeyCode), "Joystick5Button3");
					r_FJoystick5Button3.SetBelong(null);
				}
				return r_FJoystick5Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button4
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button4;
		public static RUnityEngine.RKeyCode RFJoystick5Button4
		{
			get
			{
				if(r_FJoystick5Button4 == null)
				{
					r_FJoystick5Button4 = new(typeof(UnityEngine.KeyCode), "Joystick5Button4");
					r_FJoystick5Button4.SetBelong(null);
				}
				return r_FJoystick5Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button5
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button5;
		public static RUnityEngine.RKeyCode RFJoystick5Button5
		{
			get
			{
				if(r_FJoystick5Button5 == null)
				{
					r_FJoystick5Button5 = new(typeof(UnityEngine.KeyCode), "Joystick5Button5");
					r_FJoystick5Button5.SetBelong(null);
				}
				return r_FJoystick5Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button6
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button6;
		public static RUnityEngine.RKeyCode RFJoystick5Button6
		{
			get
			{
				if(r_FJoystick5Button6 == null)
				{
					r_FJoystick5Button6 = new(typeof(UnityEngine.KeyCode), "Joystick5Button6");
					r_FJoystick5Button6.SetBelong(null);
				}
				return r_FJoystick5Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button7
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button7;
		public static RUnityEngine.RKeyCode RFJoystick5Button7
		{
			get
			{
				if(r_FJoystick5Button7 == null)
				{
					r_FJoystick5Button7 = new(typeof(UnityEngine.KeyCode), "Joystick5Button7");
					r_FJoystick5Button7.SetBelong(null);
				}
				return r_FJoystick5Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button8
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button8;
		public static RUnityEngine.RKeyCode RFJoystick5Button8
		{
			get
			{
				if(r_FJoystick5Button8 == null)
				{
					r_FJoystick5Button8 = new(typeof(UnityEngine.KeyCode), "Joystick5Button8");
					r_FJoystick5Button8.SetBelong(null);
				}
				return r_FJoystick5Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button9
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button9;
		public static RUnityEngine.RKeyCode RFJoystick5Button9
		{
			get
			{
				if(r_FJoystick5Button9 == null)
				{
					r_FJoystick5Button9 = new(typeof(UnityEngine.KeyCode), "Joystick5Button9");
					r_FJoystick5Button9.SetBelong(null);
				}
				return r_FJoystick5Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button10
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button10;
		public static RUnityEngine.RKeyCode RFJoystick5Button10
		{
			get
			{
				if(r_FJoystick5Button10 == null)
				{
					r_FJoystick5Button10 = new(typeof(UnityEngine.KeyCode), "Joystick5Button10");
					r_FJoystick5Button10.SetBelong(null);
				}
				return r_FJoystick5Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button11
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button11;
		public static RUnityEngine.RKeyCode RFJoystick5Button11
		{
			get
			{
				if(r_FJoystick5Button11 == null)
				{
					r_FJoystick5Button11 = new(typeof(UnityEngine.KeyCode), "Joystick5Button11");
					r_FJoystick5Button11.SetBelong(null);
				}
				return r_FJoystick5Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button12
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button12;
		public static RUnityEngine.RKeyCode RFJoystick5Button12
		{
			get
			{
				if(r_FJoystick5Button12 == null)
				{
					r_FJoystick5Button12 = new(typeof(UnityEngine.KeyCode), "Joystick5Button12");
					r_FJoystick5Button12.SetBelong(null);
				}
				return r_FJoystick5Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button13
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button13;
		public static RUnityEngine.RKeyCode RFJoystick5Button13
		{
			get
			{
				if(r_FJoystick5Button13 == null)
				{
					r_FJoystick5Button13 = new(typeof(UnityEngine.KeyCode), "Joystick5Button13");
					r_FJoystick5Button13.SetBelong(null);
				}
				return r_FJoystick5Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button14
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button14;
		public static RUnityEngine.RKeyCode RFJoystick5Button14
		{
			get
			{
				if(r_FJoystick5Button14 == null)
				{
					r_FJoystick5Button14 = new(typeof(UnityEngine.KeyCode), "Joystick5Button14");
					r_FJoystick5Button14.SetBelong(null);
				}
				return r_FJoystick5Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button15
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button15;
		public static RUnityEngine.RKeyCode RFJoystick5Button15
		{
			get
			{
				if(r_FJoystick5Button15 == null)
				{
					r_FJoystick5Button15 = new(typeof(UnityEngine.KeyCode), "Joystick5Button15");
					r_FJoystick5Button15.SetBelong(null);
				}
				return r_FJoystick5Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button16
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button16;
		public static RUnityEngine.RKeyCode RFJoystick5Button16
		{
			get
			{
				if(r_FJoystick5Button16 == null)
				{
					r_FJoystick5Button16 = new(typeof(UnityEngine.KeyCode), "Joystick5Button16");
					r_FJoystick5Button16.SetBelong(null);
				}
				return r_FJoystick5Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button17
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button17;
		public static RUnityEngine.RKeyCode RFJoystick5Button17
		{
			get
			{
				if(r_FJoystick5Button17 == null)
				{
					r_FJoystick5Button17 = new(typeof(UnityEngine.KeyCode), "Joystick5Button17");
					r_FJoystick5Button17.SetBelong(null);
				}
				return r_FJoystick5Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button18
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button18;
		public static RUnityEngine.RKeyCode RFJoystick5Button18
		{
			get
			{
				if(r_FJoystick5Button18 == null)
				{
					r_FJoystick5Button18 = new(typeof(UnityEngine.KeyCode), "Joystick5Button18");
					r_FJoystick5Button18.SetBelong(null);
				}
				return r_FJoystick5Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button19
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick5Button19;
		public static RUnityEngine.RKeyCode RFJoystick5Button19
		{
			get
			{
				if(r_FJoystick5Button19 == null)
				{
					r_FJoystick5Button19 = new(typeof(UnityEngine.KeyCode), "Joystick5Button19");
					r_FJoystick5Button19.SetBelong(null);
				}
				return r_FJoystick5Button19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button0
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button0;
		public static RUnityEngine.RKeyCode RFJoystick6Button0
		{
			get
			{
				if(r_FJoystick6Button0 == null)
				{
					r_FJoystick6Button0 = new(typeof(UnityEngine.KeyCode), "Joystick6Button0");
					r_FJoystick6Button0.SetBelong(null);
				}
				return r_FJoystick6Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button1
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button1;
		public static RUnityEngine.RKeyCode RFJoystick6Button1
		{
			get
			{
				if(r_FJoystick6Button1 == null)
				{
					r_FJoystick6Button1 = new(typeof(UnityEngine.KeyCode), "Joystick6Button1");
					r_FJoystick6Button1.SetBelong(null);
				}
				return r_FJoystick6Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button2
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button2;
		public static RUnityEngine.RKeyCode RFJoystick6Button2
		{
			get
			{
				if(r_FJoystick6Button2 == null)
				{
					r_FJoystick6Button2 = new(typeof(UnityEngine.KeyCode), "Joystick6Button2");
					r_FJoystick6Button2.SetBelong(null);
				}
				return r_FJoystick6Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button3
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button3;
		public static RUnityEngine.RKeyCode RFJoystick6Button3
		{
			get
			{
				if(r_FJoystick6Button3 == null)
				{
					r_FJoystick6Button3 = new(typeof(UnityEngine.KeyCode), "Joystick6Button3");
					r_FJoystick6Button3.SetBelong(null);
				}
				return r_FJoystick6Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button4
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button4;
		public static RUnityEngine.RKeyCode RFJoystick6Button4
		{
			get
			{
				if(r_FJoystick6Button4 == null)
				{
					r_FJoystick6Button4 = new(typeof(UnityEngine.KeyCode), "Joystick6Button4");
					r_FJoystick6Button4.SetBelong(null);
				}
				return r_FJoystick6Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button5
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button5;
		public static RUnityEngine.RKeyCode RFJoystick6Button5
		{
			get
			{
				if(r_FJoystick6Button5 == null)
				{
					r_FJoystick6Button5 = new(typeof(UnityEngine.KeyCode), "Joystick6Button5");
					r_FJoystick6Button5.SetBelong(null);
				}
				return r_FJoystick6Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button6
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button6;
		public static RUnityEngine.RKeyCode RFJoystick6Button6
		{
			get
			{
				if(r_FJoystick6Button6 == null)
				{
					r_FJoystick6Button6 = new(typeof(UnityEngine.KeyCode), "Joystick6Button6");
					r_FJoystick6Button6.SetBelong(null);
				}
				return r_FJoystick6Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button7
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button7;
		public static RUnityEngine.RKeyCode RFJoystick6Button7
		{
			get
			{
				if(r_FJoystick6Button7 == null)
				{
					r_FJoystick6Button7 = new(typeof(UnityEngine.KeyCode), "Joystick6Button7");
					r_FJoystick6Button7.SetBelong(null);
				}
				return r_FJoystick6Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button8
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button8;
		public static RUnityEngine.RKeyCode RFJoystick6Button8
		{
			get
			{
				if(r_FJoystick6Button8 == null)
				{
					r_FJoystick6Button8 = new(typeof(UnityEngine.KeyCode), "Joystick6Button8");
					r_FJoystick6Button8.SetBelong(null);
				}
				return r_FJoystick6Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button9
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button9;
		public static RUnityEngine.RKeyCode RFJoystick6Button9
		{
			get
			{
				if(r_FJoystick6Button9 == null)
				{
					r_FJoystick6Button9 = new(typeof(UnityEngine.KeyCode), "Joystick6Button9");
					r_FJoystick6Button9.SetBelong(null);
				}
				return r_FJoystick6Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button10
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button10;
		public static RUnityEngine.RKeyCode RFJoystick6Button10
		{
			get
			{
				if(r_FJoystick6Button10 == null)
				{
					r_FJoystick6Button10 = new(typeof(UnityEngine.KeyCode), "Joystick6Button10");
					r_FJoystick6Button10.SetBelong(null);
				}
				return r_FJoystick6Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button11
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button11;
		public static RUnityEngine.RKeyCode RFJoystick6Button11
		{
			get
			{
				if(r_FJoystick6Button11 == null)
				{
					r_FJoystick6Button11 = new(typeof(UnityEngine.KeyCode), "Joystick6Button11");
					r_FJoystick6Button11.SetBelong(null);
				}
				return r_FJoystick6Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button12
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button12;
		public static RUnityEngine.RKeyCode RFJoystick6Button12
		{
			get
			{
				if(r_FJoystick6Button12 == null)
				{
					r_FJoystick6Button12 = new(typeof(UnityEngine.KeyCode), "Joystick6Button12");
					r_FJoystick6Button12.SetBelong(null);
				}
				return r_FJoystick6Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button13
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button13;
		public static RUnityEngine.RKeyCode RFJoystick6Button13
		{
			get
			{
				if(r_FJoystick6Button13 == null)
				{
					r_FJoystick6Button13 = new(typeof(UnityEngine.KeyCode), "Joystick6Button13");
					r_FJoystick6Button13.SetBelong(null);
				}
				return r_FJoystick6Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button14
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button14;
		public static RUnityEngine.RKeyCode RFJoystick6Button14
		{
			get
			{
				if(r_FJoystick6Button14 == null)
				{
					r_FJoystick6Button14 = new(typeof(UnityEngine.KeyCode), "Joystick6Button14");
					r_FJoystick6Button14.SetBelong(null);
				}
				return r_FJoystick6Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button15
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button15;
		public static RUnityEngine.RKeyCode RFJoystick6Button15
		{
			get
			{
				if(r_FJoystick6Button15 == null)
				{
					r_FJoystick6Button15 = new(typeof(UnityEngine.KeyCode), "Joystick6Button15");
					r_FJoystick6Button15.SetBelong(null);
				}
				return r_FJoystick6Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button16
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button16;
		public static RUnityEngine.RKeyCode RFJoystick6Button16
		{
			get
			{
				if(r_FJoystick6Button16 == null)
				{
					r_FJoystick6Button16 = new(typeof(UnityEngine.KeyCode), "Joystick6Button16");
					r_FJoystick6Button16.SetBelong(null);
				}
				return r_FJoystick6Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button17
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button17;
		public static RUnityEngine.RKeyCode RFJoystick6Button17
		{
			get
			{
				if(r_FJoystick6Button17 == null)
				{
					r_FJoystick6Button17 = new(typeof(UnityEngine.KeyCode), "Joystick6Button17");
					r_FJoystick6Button17.SetBelong(null);
				}
				return r_FJoystick6Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button18
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button18;
		public static RUnityEngine.RKeyCode RFJoystick6Button18
		{
			get
			{
				if(r_FJoystick6Button18 == null)
				{
					r_FJoystick6Button18 = new(typeof(UnityEngine.KeyCode), "Joystick6Button18");
					r_FJoystick6Button18.SetBelong(null);
				}
				return r_FJoystick6Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button19
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick6Button19;
		public static RUnityEngine.RKeyCode RFJoystick6Button19
		{
			get
			{
				if(r_FJoystick6Button19 == null)
				{
					r_FJoystick6Button19 = new(typeof(UnityEngine.KeyCode), "Joystick6Button19");
					r_FJoystick6Button19.SetBelong(null);
				}
				return r_FJoystick6Button19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button0
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button0;
		public static RUnityEngine.RKeyCode RFJoystick7Button0
		{
			get
			{
				if(r_FJoystick7Button0 == null)
				{
					r_FJoystick7Button0 = new(typeof(UnityEngine.KeyCode), "Joystick7Button0");
					r_FJoystick7Button0.SetBelong(null);
				}
				return r_FJoystick7Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button1
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button1;
		public static RUnityEngine.RKeyCode RFJoystick7Button1
		{
			get
			{
				if(r_FJoystick7Button1 == null)
				{
					r_FJoystick7Button1 = new(typeof(UnityEngine.KeyCode), "Joystick7Button1");
					r_FJoystick7Button1.SetBelong(null);
				}
				return r_FJoystick7Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button2
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button2;
		public static RUnityEngine.RKeyCode RFJoystick7Button2
		{
			get
			{
				if(r_FJoystick7Button2 == null)
				{
					r_FJoystick7Button2 = new(typeof(UnityEngine.KeyCode), "Joystick7Button2");
					r_FJoystick7Button2.SetBelong(null);
				}
				return r_FJoystick7Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button3
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button3;
		public static RUnityEngine.RKeyCode RFJoystick7Button3
		{
			get
			{
				if(r_FJoystick7Button3 == null)
				{
					r_FJoystick7Button3 = new(typeof(UnityEngine.KeyCode), "Joystick7Button3");
					r_FJoystick7Button3.SetBelong(null);
				}
				return r_FJoystick7Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button4
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button4;
		public static RUnityEngine.RKeyCode RFJoystick7Button4
		{
			get
			{
				if(r_FJoystick7Button4 == null)
				{
					r_FJoystick7Button4 = new(typeof(UnityEngine.KeyCode), "Joystick7Button4");
					r_FJoystick7Button4.SetBelong(null);
				}
				return r_FJoystick7Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button5
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button5;
		public static RUnityEngine.RKeyCode RFJoystick7Button5
		{
			get
			{
				if(r_FJoystick7Button5 == null)
				{
					r_FJoystick7Button5 = new(typeof(UnityEngine.KeyCode), "Joystick7Button5");
					r_FJoystick7Button5.SetBelong(null);
				}
				return r_FJoystick7Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button6
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button6;
		public static RUnityEngine.RKeyCode RFJoystick7Button6
		{
			get
			{
				if(r_FJoystick7Button6 == null)
				{
					r_FJoystick7Button6 = new(typeof(UnityEngine.KeyCode), "Joystick7Button6");
					r_FJoystick7Button6.SetBelong(null);
				}
				return r_FJoystick7Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button7
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button7;
		public static RUnityEngine.RKeyCode RFJoystick7Button7
		{
			get
			{
				if(r_FJoystick7Button7 == null)
				{
					r_FJoystick7Button7 = new(typeof(UnityEngine.KeyCode), "Joystick7Button7");
					r_FJoystick7Button7.SetBelong(null);
				}
				return r_FJoystick7Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button8
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button8;
		public static RUnityEngine.RKeyCode RFJoystick7Button8
		{
			get
			{
				if(r_FJoystick7Button8 == null)
				{
					r_FJoystick7Button8 = new(typeof(UnityEngine.KeyCode), "Joystick7Button8");
					r_FJoystick7Button8.SetBelong(null);
				}
				return r_FJoystick7Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button9
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button9;
		public static RUnityEngine.RKeyCode RFJoystick7Button9
		{
			get
			{
				if(r_FJoystick7Button9 == null)
				{
					r_FJoystick7Button9 = new(typeof(UnityEngine.KeyCode), "Joystick7Button9");
					r_FJoystick7Button9.SetBelong(null);
				}
				return r_FJoystick7Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button10
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button10;
		public static RUnityEngine.RKeyCode RFJoystick7Button10
		{
			get
			{
				if(r_FJoystick7Button10 == null)
				{
					r_FJoystick7Button10 = new(typeof(UnityEngine.KeyCode), "Joystick7Button10");
					r_FJoystick7Button10.SetBelong(null);
				}
				return r_FJoystick7Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button11
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button11;
		public static RUnityEngine.RKeyCode RFJoystick7Button11
		{
			get
			{
				if(r_FJoystick7Button11 == null)
				{
					r_FJoystick7Button11 = new(typeof(UnityEngine.KeyCode), "Joystick7Button11");
					r_FJoystick7Button11.SetBelong(null);
				}
				return r_FJoystick7Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button12
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button12;
		public static RUnityEngine.RKeyCode RFJoystick7Button12
		{
			get
			{
				if(r_FJoystick7Button12 == null)
				{
					r_FJoystick7Button12 = new(typeof(UnityEngine.KeyCode), "Joystick7Button12");
					r_FJoystick7Button12.SetBelong(null);
				}
				return r_FJoystick7Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button13
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button13;
		public static RUnityEngine.RKeyCode RFJoystick7Button13
		{
			get
			{
				if(r_FJoystick7Button13 == null)
				{
					r_FJoystick7Button13 = new(typeof(UnityEngine.KeyCode), "Joystick7Button13");
					r_FJoystick7Button13.SetBelong(null);
				}
				return r_FJoystick7Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button14
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button14;
		public static RUnityEngine.RKeyCode RFJoystick7Button14
		{
			get
			{
				if(r_FJoystick7Button14 == null)
				{
					r_FJoystick7Button14 = new(typeof(UnityEngine.KeyCode), "Joystick7Button14");
					r_FJoystick7Button14.SetBelong(null);
				}
				return r_FJoystick7Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button15
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button15;
		public static RUnityEngine.RKeyCode RFJoystick7Button15
		{
			get
			{
				if(r_FJoystick7Button15 == null)
				{
					r_FJoystick7Button15 = new(typeof(UnityEngine.KeyCode), "Joystick7Button15");
					r_FJoystick7Button15.SetBelong(null);
				}
				return r_FJoystick7Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button16
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button16;
		public static RUnityEngine.RKeyCode RFJoystick7Button16
		{
			get
			{
				if(r_FJoystick7Button16 == null)
				{
					r_FJoystick7Button16 = new(typeof(UnityEngine.KeyCode), "Joystick7Button16");
					r_FJoystick7Button16.SetBelong(null);
				}
				return r_FJoystick7Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button17
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button17;
		public static RUnityEngine.RKeyCode RFJoystick7Button17
		{
			get
			{
				if(r_FJoystick7Button17 == null)
				{
					r_FJoystick7Button17 = new(typeof(UnityEngine.KeyCode), "Joystick7Button17");
					r_FJoystick7Button17.SetBelong(null);
				}
				return r_FJoystick7Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button18
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button18;
		public static RUnityEngine.RKeyCode RFJoystick7Button18
		{
			get
			{
				if(r_FJoystick7Button18 == null)
				{
					r_FJoystick7Button18 = new(typeof(UnityEngine.KeyCode), "Joystick7Button18");
					r_FJoystick7Button18.SetBelong(null);
				}
				return r_FJoystick7Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button19
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick7Button19;
		public static RUnityEngine.RKeyCode RFJoystick7Button19
		{
			get
			{
				if(r_FJoystick7Button19 == null)
				{
					r_FJoystick7Button19 = new(typeof(UnityEngine.KeyCode), "Joystick7Button19");
					r_FJoystick7Button19.SetBelong(null);
				}
				return r_FJoystick7Button19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button0
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button0;
		public static RUnityEngine.RKeyCode RFJoystick8Button0
		{
			get
			{
				if(r_FJoystick8Button0 == null)
				{
					r_FJoystick8Button0 = new(typeof(UnityEngine.KeyCode), "Joystick8Button0");
					r_FJoystick8Button0.SetBelong(null);
				}
				return r_FJoystick8Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button1
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button1;
		public static RUnityEngine.RKeyCode RFJoystick8Button1
		{
			get
			{
				if(r_FJoystick8Button1 == null)
				{
					r_FJoystick8Button1 = new(typeof(UnityEngine.KeyCode), "Joystick8Button1");
					r_FJoystick8Button1.SetBelong(null);
				}
				return r_FJoystick8Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button2
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button2;
		public static RUnityEngine.RKeyCode RFJoystick8Button2
		{
			get
			{
				if(r_FJoystick8Button2 == null)
				{
					r_FJoystick8Button2 = new(typeof(UnityEngine.KeyCode), "Joystick8Button2");
					r_FJoystick8Button2.SetBelong(null);
				}
				return r_FJoystick8Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button3
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button3;
		public static RUnityEngine.RKeyCode RFJoystick8Button3
		{
			get
			{
				if(r_FJoystick8Button3 == null)
				{
					r_FJoystick8Button3 = new(typeof(UnityEngine.KeyCode), "Joystick8Button3");
					r_FJoystick8Button3.SetBelong(null);
				}
				return r_FJoystick8Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button4
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button4;
		public static RUnityEngine.RKeyCode RFJoystick8Button4
		{
			get
			{
				if(r_FJoystick8Button4 == null)
				{
					r_FJoystick8Button4 = new(typeof(UnityEngine.KeyCode), "Joystick8Button4");
					r_FJoystick8Button4.SetBelong(null);
				}
				return r_FJoystick8Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button5
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button5;
		public static RUnityEngine.RKeyCode RFJoystick8Button5
		{
			get
			{
				if(r_FJoystick8Button5 == null)
				{
					r_FJoystick8Button5 = new(typeof(UnityEngine.KeyCode), "Joystick8Button5");
					r_FJoystick8Button5.SetBelong(null);
				}
				return r_FJoystick8Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button6
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button6;
		public static RUnityEngine.RKeyCode RFJoystick8Button6
		{
			get
			{
				if(r_FJoystick8Button6 == null)
				{
					r_FJoystick8Button6 = new(typeof(UnityEngine.KeyCode), "Joystick8Button6");
					r_FJoystick8Button6.SetBelong(null);
				}
				return r_FJoystick8Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button7
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button7;
		public static RUnityEngine.RKeyCode RFJoystick8Button7
		{
			get
			{
				if(r_FJoystick8Button7 == null)
				{
					r_FJoystick8Button7 = new(typeof(UnityEngine.KeyCode), "Joystick8Button7");
					r_FJoystick8Button7.SetBelong(null);
				}
				return r_FJoystick8Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button8
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button8;
		public static RUnityEngine.RKeyCode RFJoystick8Button8
		{
			get
			{
				if(r_FJoystick8Button8 == null)
				{
					r_FJoystick8Button8 = new(typeof(UnityEngine.KeyCode), "Joystick8Button8");
					r_FJoystick8Button8.SetBelong(null);
				}
				return r_FJoystick8Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button9
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button9;
		public static RUnityEngine.RKeyCode RFJoystick8Button9
		{
			get
			{
				if(r_FJoystick8Button9 == null)
				{
					r_FJoystick8Button9 = new(typeof(UnityEngine.KeyCode), "Joystick8Button9");
					r_FJoystick8Button9.SetBelong(null);
				}
				return r_FJoystick8Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button10
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button10;
		public static RUnityEngine.RKeyCode RFJoystick8Button10
		{
			get
			{
				if(r_FJoystick8Button10 == null)
				{
					r_FJoystick8Button10 = new(typeof(UnityEngine.KeyCode), "Joystick8Button10");
					r_FJoystick8Button10.SetBelong(null);
				}
				return r_FJoystick8Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button11
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button11;
		public static RUnityEngine.RKeyCode RFJoystick8Button11
		{
			get
			{
				if(r_FJoystick8Button11 == null)
				{
					r_FJoystick8Button11 = new(typeof(UnityEngine.KeyCode), "Joystick8Button11");
					r_FJoystick8Button11.SetBelong(null);
				}
				return r_FJoystick8Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button12
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button12;
		public static RUnityEngine.RKeyCode RFJoystick8Button12
		{
			get
			{
				if(r_FJoystick8Button12 == null)
				{
					r_FJoystick8Button12 = new(typeof(UnityEngine.KeyCode), "Joystick8Button12");
					r_FJoystick8Button12.SetBelong(null);
				}
				return r_FJoystick8Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button13
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button13;
		public static RUnityEngine.RKeyCode RFJoystick8Button13
		{
			get
			{
				if(r_FJoystick8Button13 == null)
				{
					r_FJoystick8Button13 = new(typeof(UnityEngine.KeyCode), "Joystick8Button13");
					r_FJoystick8Button13.SetBelong(null);
				}
				return r_FJoystick8Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button14
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button14;
		public static RUnityEngine.RKeyCode RFJoystick8Button14
		{
			get
			{
				if(r_FJoystick8Button14 == null)
				{
					r_FJoystick8Button14 = new(typeof(UnityEngine.KeyCode), "Joystick8Button14");
					r_FJoystick8Button14.SetBelong(null);
				}
				return r_FJoystick8Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button15
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button15;
		public static RUnityEngine.RKeyCode RFJoystick8Button15
		{
			get
			{
				if(r_FJoystick8Button15 == null)
				{
					r_FJoystick8Button15 = new(typeof(UnityEngine.KeyCode), "Joystick8Button15");
					r_FJoystick8Button15.SetBelong(null);
				}
				return r_FJoystick8Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button16
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button16;
		public static RUnityEngine.RKeyCode RFJoystick8Button16
		{
			get
			{
				if(r_FJoystick8Button16 == null)
				{
					r_FJoystick8Button16 = new(typeof(UnityEngine.KeyCode), "Joystick8Button16");
					r_FJoystick8Button16.SetBelong(null);
				}
				return r_FJoystick8Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button17
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button17;
		public static RUnityEngine.RKeyCode RFJoystick8Button17
		{
			get
			{
				if(r_FJoystick8Button17 == null)
				{
					r_FJoystick8Button17 = new(typeof(UnityEngine.KeyCode), "Joystick8Button17");
					r_FJoystick8Button17.SetBelong(null);
				}
				return r_FJoystick8Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button18
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button18;
		public static RUnityEngine.RKeyCode RFJoystick8Button18
		{
			get
			{
				if(r_FJoystick8Button18 == null)
				{
					r_FJoystick8Button18 = new(typeof(UnityEngine.KeyCode), "Joystick8Button18");
					r_FJoystick8Button18.SetBelong(null);
				}
				return r_FJoystick8Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button19
		/// </summary>
		protected static RUnityEngine.RKeyCode r_FJoystick8Button19;
		public static RUnityEngine.RKeyCode RFJoystick8Button19
		{
			get
			{
				if(r_FJoystick8Button19 == null)
				{
					r_FJoystick8Button19 = new(typeof(UnityEngine.KeyCode), "Joystick8Button19");
					r_FJoystick8Button19.SetBelong(null);
				}
				return r_FJoystick8Button19;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
					r_MGetValue.SetBelong(this.instance);
				}
				return r_MGetValue;
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
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_MCompareTo_Object.SetBelong(this.instance);
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
					r_MToString_String.SetBelong(this.instance);
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
					r_MToString_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
					r_MHasFlag_Enum.SetBelong(this.instance);
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
					r_MGetTypeCode.SetBelong(this.instance);
				}
				return r_MGetTypeCode;
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


        public RKeyCode() : base("UnityEngine.KeyCode")
        {
        }

        public RKeyCode(System.Object instance) : base("UnityEngine.KeyCode")
		{
            SetInstance(instance);
		}

        public RKeyCode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RKeyCode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
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
