using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.TextEditOp
	/// </summary>
    public partial class RTextEditOp : RMember //
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
		/// UnityEngine.TextEditOp MoveLeft
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveLeft;
		public static RUnityEngine.RTextEditOp RFMoveLeft
		{
			get
			{
				if(r_FMoveLeft == null)
				{
					r_FMoveLeft = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveLeft");
					r_FMoveLeft.SetBelong(null);
				}
				return r_FMoveLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveRight
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveRight;
		public static RUnityEngine.RTextEditOp RFMoveRight
		{
			get
			{
				if(r_FMoveRight == null)
				{
					r_FMoveRight = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveRight");
					r_FMoveRight.SetBelong(null);
				}
				return r_FMoveRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveUp
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveUp;
		public static RUnityEngine.RTextEditOp RFMoveUp
		{
			get
			{
				if(r_FMoveUp == null)
				{
					r_FMoveUp = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveUp");
					r_FMoveUp.SetBelong(null);
				}
				return r_FMoveUp;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveDown
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveDown;
		public static RUnityEngine.RTextEditOp RFMoveDown
		{
			get
			{
				if(r_FMoveDown == null)
				{
					r_FMoveDown = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveDown");
					r_FMoveDown.SetBelong(null);
				}
				return r_FMoveDown;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveLineStart
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveLineStart;
		public static RUnityEngine.RTextEditOp RFMoveLineStart
		{
			get
			{
				if(r_FMoveLineStart == null)
				{
					r_FMoveLineStart = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveLineStart");
					r_FMoveLineStart.SetBelong(null);
				}
				return r_FMoveLineStart;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveLineEnd
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveLineEnd;
		public static RUnityEngine.RTextEditOp RFMoveLineEnd
		{
			get
			{
				if(r_FMoveLineEnd == null)
				{
					r_FMoveLineEnd = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveLineEnd");
					r_FMoveLineEnd.SetBelong(null);
				}
				return r_FMoveLineEnd;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveTextStart
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveTextStart;
		public static RUnityEngine.RTextEditOp RFMoveTextStart
		{
			get
			{
				if(r_FMoveTextStart == null)
				{
					r_FMoveTextStart = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveTextStart");
					r_FMoveTextStart.SetBelong(null);
				}
				return r_FMoveTextStart;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveTextEnd
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveTextEnd;
		public static RUnityEngine.RTextEditOp RFMoveTextEnd
		{
			get
			{
				if(r_FMoveTextEnd == null)
				{
					r_FMoveTextEnd = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveTextEnd");
					r_FMoveTextEnd.SetBelong(null);
				}
				return r_FMoveTextEnd;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MovePageUp
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMovePageUp;
		public static RUnityEngine.RTextEditOp RFMovePageUp
		{
			get
			{
				if(r_FMovePageUp == null)
				{
					r_FMovePageUp = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MovePageUp");
					r_FMovePageUp.SetBelong(null);
				}
				return r_FMovePageUp;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MovePageDown
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMovePageDown;
		public static RUnityEngine.RTextEditOp RFMovePageDown
		{
			get
			{
				if(r_FMovePageDown == null)
				{
					r_FMovePageDown = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MovePageDown");
					r_FMovePageDown.SetBelong(null);
				}
				return r_FMovePageDown;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveGraphicalLineStart
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveGraphicalLineStart;
		public static RUnityEngine.RTextEditOp RFMoveGraphicalLineStart
		{
			get
			{
				if(r_FMoveGraphicalLineStart == null)
				{
					r_FMoveGraphicalLineStart = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveGraphicalLineStart");
					r_FMoveGraphicalLineStart.SetBelong(null);
				}
				return r_FMoveGraphicalLineStart;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveGraphicalLineEnd
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveGraphicalLineEnd;
		public static RUnityEngine.RTextEditOp RFMoveGraphicalLineEnd
		{
			get
			{
				if(r_FMoveGraphicalLineEnd == null)
				{
					r_FMoveGraphicalLineEnd = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveGraphicalLineEnd");
					r_FMoveGraphicalLineEnd.SetBelong(null);
				}
				return r_FMoveGraphicalLineEnd;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveWordLeft
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveWordLeft;
		public static RUnityEngine.RTextEditOp RFMoveWordLeft
		{
			get
			{
				if(r_FMoveWordLeft == null)
				{
					r_FMoveWordLeft = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveWordLeft");
					r_FMoveWordLeft.SetBelong(null);
				}
				return r_FMoveWordLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveWordRight
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveWordRight;
		public static RUnityEngine.RTextEditOp RFMoveWordRight
		{
			get
			{
				if(r_FMoveWordRight == null)
				{
					r_FMoveWordRight = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveWordRight");
					r_FMoveWordRight.SetBelong(null);
				}
				return r_FMoveWordRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveParagraphForward
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveParagraphForward;
		public static RUnityEngine.RTextEditOp RFMoveParagraphForward
		{
			get
			{
				if(r_FMoveParagraphForward == null)
				{
					r_FMoveParagraphForward = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveParagraphForward");
					r_FMoveParagraphForward.SetBelong(null);
				}
				return r_FMoveParagraphForward;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveParagraphBackward
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveParagraphBackward;
		public static RUnityEngine.RTextEditOp RFMoveParagraphBackward
		{
			get
			{
				if(r_FMoveParagraphBackward == null)
				{
					r_FMoveParagraphBackward = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveParagraphBackward");
					r_FMoveParagraphBackward.SetBelong(null);
				}
				return r_FMoveParagraphBackward;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveToStartOfNextWord
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveToStartOfNextWord;
		public static RUnityEngine.RTextEditOp RFMoveToStartOfNextWord
		{
			get
			{
				if(r_FMoveToStartOfNextWord == null)
				{
					r_FMoveToStartOfNextWord = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveToStartOfNextWord");
					r_FMoveToStartOfNextWord.SetBelong(null);
				}
				return r_FMoveToStartOfNextWord;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveToEndOfPreviousWord
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FMoveToEndOfPreviousWord;
		public static RUnityEngine.RTextEditOp RFMoveToEndOfPreviousWord
		{
			get
			{
				if(r_FMoveToEndOfPreviousWord == null)
				{
					r_FMoveToEndOfPreviousWord = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "MoveToEndOfPreviousWord");
					r_FMoveToEndOfPreviousWord.SetBelong(null);
				}
				return r_FMoveToEndOfPreviousWord;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectLeft
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectLeft;
		public static RUnityEngine.RTextEditOp RFSelectLeft
		{
			get
			{
				if(r_FSelectLeft == null)
				{
					r_FSelectLeft = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectLeft");
					r_FSelectLeft.SetBelong(null);
				}
				return r_FSelectLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectRight
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectRight;
		public static RUnityEngine.RTextEditOp RFSelectRight
		{
			get
			{
				if(r_FSelectRight == null)
				{
					r_FSelectRight = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectRight");
					r_FSelectRight.SetBelong(null);
				}
				return r_FSelectRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectUp
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectUp;
		public static RUnityEngine.RTextEditOp RFSelectUp
		{
			get
			{
				if(r_FSelectUp == null)
				{
					r_FSelectUp = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectUp");
					r_FSelectUp.SetBelong(null);
				}
				return r_FSelectUp;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectDown
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectDown;
		public static RUnityEngine.RTextEditOp RFSelectDown
		{
			get
			{
				if(r_FSelectDown == null)
				{
					r_FSelectDown = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectDown");
					r_FSelectDown.SetBelong(null);
				}
				return r_FSelectDown;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectTextStart
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectTextStart;
		public static RUnityEngine.RTextEditOp RFSelectTextStart
		{
			get
			{
				if(r_FSelectTextStart == null)
				{
					r_FSelectTextStart = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectTextStart");
					r_FSelectTextStart.SetBelong(null);
				}
				return r_FSelectTextStart;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectTextEnd
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectTextEnd;
		public static RUnityEngine.RTextEditOp RFSelectTextEnd
		{
			get
			{
				if(r_FSelectTextEnd == null)
				{
					r_FSelectTextEnd = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectTextEnd");
					r_FSelectTextEnd.SetBelong(null);
				}
				return r_FSelectTextEnd;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectPageUp
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectPageUp;
		public static RUnityEngine.RTextEditOp RFSelectPageUp
		{
			get
			{
				if(r_FSelectPageUp == null)
				{
					r_FSelectPageUp = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectPageUp");
					r_FSelectPageUp.SetBelong(null);
				}
				return r_FSelectPageUp;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectPageDown
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectPageDown;
		public static RUnityEngine.RTextEditOp RFSelectPageDown
		{
			get
			{
				if(r_FSelectPageDown == null)
				{
					r_FSelectPageDown = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectPageDown");
					r_FSelectPageDown.SetBelong(null);
				}
				return r_FSelectPageDown;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp ExpandSelectGraphicalLineStart
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FExpandSelectGraphicalLineStart;
		public static RUnityEngine.RTextEditOp RFExpandSelectGraphicalLineStart
		{
			get
			{
				if(r_FExpandSelectGraphicalLineStart == null)
				{
					r_FExpandSelectGraphicalLineStart = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "ExpandSelectGraphicalLineStart");
					r_FExpandSelectGraphicalLineStart.SetBelong(null);
				}
				return r_FExpandSelectGraphicalLineStart;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp ExpandSelectGraphicalLineEnd
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FExpandSelectGraphicalLineEnd;
		public static RUnityEngine.RTextEditOp RFExpandSelectGraphicalLineEnd
		{
			get
			{
				if(r_FExpandSelectGraphicalLineEnd == null)
				{
					r_FExpandSelectGraphicalLineEnd = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "ExpandSelectGraphicalLineEnd");
					r_FExpandSelectGraphicalLineEnd.SetBelong(null);
				}
				return r_FExpandSelectGraphicalLineEnd;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectGraphicalLineStart
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectGraphicalLineStart;
		public static RUnityEngine.RTextEditOp RFSelectGraphicalLineStart
		{
			get
			{
				if(r_FSelectGraphicalLineStart == null)
				{
					r_FSelectGraphicalLineStart = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectGraphicalLineStart");
					r_FSelectGraphicalLineStart.SetBelong(null);
				}
				return r_FSelectGraphicalLineStart;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectGraphicalLineEnd
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectGraphicalLineEnd;
		public static RUnityEngine.RTextEditOp RFSelectGraphicalLineEnd
		{
			get
			{
				if(r_FSelectGraphicalLineEnd == null)
				{
					r_FSelectGraphicalLineEnd = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectGraphicalLineEnd");
					r_FSelectGraphicalLineEnd.SetBelong(null);
				}
				return r_FSelectGraphicalLineEnd;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectWordLeft
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectWordLeft;
		public static RUnityEngine.RTextEditOp RFSelectWordLeft
		{
			get
			{
				if(r_FSelectWordLeft == null)
				{
					r_FSelectWordLeft = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectWordLeft");
					r_FSelectWordLeft.SetBelong(null);
				}
				return r_FSelectWordLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectWordRight
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectWordRight;
		public static RUnityEngine.RTextEditOp RFSelectWordRight
		{
			get
			{
				if(r_FSelectWordRight == null)
				{
					r_FSelectWordRight = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectWordRight");
					r_FSelectWordRight.SetBelong(null);
				}
				return r_FSelectWordRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectToEndOfPreviousWord
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectToEndOfPreviousWord;
		public static RUnityEngine.RTextEditOp RFSelectToEndOfPreviousWord
		{
			get
			{
				if(r_FSelectToEndOfPreviousWord == null)
				{
					r_FSelectToEndOfPreviousWord = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectToEndOfPreviousWord");
					r_FSelectToEndOfPreviousWord.SetBelong(null);
				}
				return r_FSelectToEndOfPreviousWord;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectToStartOfNextWord
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectToStartOfNextWord;
		public static RUnityEngine.RTextEditOp RFSelectToStartOfNextWord
		{
			get
			{
				if(r_FSelectToStartOfNextWord == null)
				{
					r_FSelectToStartOfNextWord = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectToStartOfNextWord");
					r_FSelectToStartOfNextWord.SetBelong(null);
				}
				return r_FSelectToStartOfNextWord;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectParagraphBackward
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectParagraphBackward;
		public static RUnityEngine.RTextEditOp RFSelectParagraphBackward
		{
			get
			{
				if(r_FSelectParagraphBackward == null)
				{
					r_FSelectParagraphBackward = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectParagraphBackward");
					r_FSelectParagraphBackward.SetBelong(null);
				}
				return r_FSelectParagraphBackward;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectParagraphForward
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectParagraphForward;
		public static RUnityEngine.RTextEditOp RFSelectParagraphForward
		{
			get
			{
				if(r_FSelectParagraphForward == null)
				{
					r_FSelectParagraphForward = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectParagraphForward");
					r_FSelectParagraphForward.SetBelong(null);
				}
				return r_FSelectParagraphForward;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp Delete
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FDelete;
		public static RUnityEngine.RTextEditOp RFDelete
		{
			get
			{
				if(r_FDelete == null)
				{
					r_FDelete = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "Delete");
					r_FDelete.SetBelong(null);
				}
				return r_FDelete;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp Backspace
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FBackspace;
		public static RUnityEngine.RTextEditOp RFBackspace
		{
			get
			{
				if(r_FBackspace == null)
				{
					r_FBackspace = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "Backspace");
					r_FBackspace.SetBelong(null);
				}
				return r_FBackspace;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp DeleteWordBack
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FDeleteWordBack;
		public static RUnityEngine.RTextEditOp RFDeleteWordBack
		{
			get
			{
				if(r_FDeleteWordBack == null)
				{
					r_FDeleteWordBack = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "DeleteWordBack");
					r_FDeleteWordBack.SetBelong(null);
				}
				return r_FDeleteWordBack;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp DeleteWordForward
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FDeleteWordForward;
		public static RUnityEngine.RTextEditOp RFDeleteWordForward
		{
			get
			{
				if(r_FDeleteWordForward == null)
				{
					r_FDeleteWordForward = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "DeleteWordForward");
					r_FDeleteWordForward.SetBelong(null);
				}
				return r_FDeleteWordForward;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp DeleteLineBack
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FDeleteLineBack;
		public static RUnityEngine.RTextEditOp RFDeleteLineBack
		{
			get
			{
				if(r_FDeleteLineBack == null)
				{
					r_FDeleteLineBack = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "DeleteLineBack");
					r_FDeleteLineBack.SetBelong(null);
				}
				return r_FDeleteLineBack;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp Cut
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FCut;
		public static RUnityEngine.RTextEditOp RFCut
		{
			get
			{
				if(r_FCut == null)
				{
					r_FCut = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "Cut");
					r_FCut.SetBelong(null);
				}
				return r_FCut;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp Copy
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FCopy;
		public static RUnityEngine.RTextEditOp RFCopy
		{
			get
			{
				if(r_FCopy == null)
				{
					r_FCopy = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "Copy");
					r_FCopy.SetBelong(null);
				}
				return r_FCopy;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp Paste
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FPaste;
		public static RUnityEngine.RTextEditOp RFPaste
		{
			get
			{
				if(r_FPaste == null)
				{
					r_FPaste = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "Paste");
					r_FPaste.SetBelong(null);
				}
				return r_FPaste;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectAll
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectAll;
		public static RUnityEngine.RTextEditOp RFSelectAll
		{
			get
			{
				if(r_FSelectAll == null)
				{
					r_FSelectAll = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectAll");
					r_FSelectAll.SetBelong(null);
				}
				return r_FSelectAll;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp SelectNone
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FSelectNone;
		public static RUnityEngine.RTextEditOp RFSelectNone
		{
			get
			{
				if(r_FSelectNone == null)
				{
					r_FSelectNone = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "SelectNone");
					r_FSelectNone.SetBelong(null);
				}
				return r_FSelectNone;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp ScrollStart
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FScrollStart;
		public static RUnityEngine.RTextEditOp RFScrollStart
		{
			get
			{
				if(r_FScrollStart == null)
				{
					r_FScrollStart = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "ScrollStart");
					r_FScrollStart.SetBelong(null);
				}
				return r_FScrollStart;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp ScrollEnd
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FScrollEnd;
		public static RUnityEngine.RTextEditOp RFScrollEnd
		{
			get
			{
				if(r_FScrollEnd == null)
				{
					r_FScrollEnd = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "ScrollEnd");
					r_FScrollEnd.SetBelong(null);
				}
				return r_FScrollEnd;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp ScrollPageUp
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FScrollPageUp;
		public static RUnityEngine.RTextEditOp RFScrollPageUp
		{
			get
			{
				if(r_FScrollPageUp == null)
				{
					r_FScrollPageUp = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "ScrollPageUp");
					r_FScrollPageUp.SetBelong(null);
				}
				return r_FScrollPageUp;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp ScrollPageDown
		/// </summary>
		protected static RUnityEngine.RTextEditOp r_FScrollPageDown;
		public static RUnityEngine.RTextEditOp RFScrollPageDown
		{
			get
			{
				if(r_FScrollPageDown == null)
				{
					r_FScrollPageDown = new( ReflectionUtils.GetType("UnityEngine.TextEditOp"), "ScrollPageDown");
					r_FScrollPageDown.SetBelong(null);
				}
				return r_FScrollPageDown;
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


        public RTextEditOp() : base("UnityEngine.TextEditOp")
        {
        }

        public RTextEditOp(System.Object instance) : base("UnityEngine.TextEditOp")
		{
            SetInstance(instance);
		}

        public RTextEditOp(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextEditOp(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
