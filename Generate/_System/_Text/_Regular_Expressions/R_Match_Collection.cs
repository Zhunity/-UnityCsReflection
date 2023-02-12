
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.MatchCollection
	/// </summary>
    public partial class RMatchCollection : RMember //
    {

		/// <summary>
		/// System.Text.RegularExpressions.Regex _regex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex r_F_regex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex RF_regex
		{
			get
			{
				if(r_F_regex == null)
				{
					r_F_regex = new(this, "_regex");
					r_F_regex.SetBelong(this.instance);
				}
				return r_F_regex;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Text.RegularExpressions.Match] _matches
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RMatch> r_F_matches;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RMatch> RF_matches
		{
			get
			{
				if(r_F_matches == null)
				{
					r_F_matches = new(this, "_matches");
					r_F_matches.SetBelong(this.instance);
				}
				return r_F_matches;
			}
		}

		/// <summary>
		/// System.Boolean _done
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_F_done;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RF_done
		{
			get
			{
				if(r_F_done == null)
				{
					r_F_done = new(this, "_done");
					r_F_done.SetBelong(this.instance);
				}
				return r_F_done;
			}
		}

		/// <summary>
		/// System.String _input
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_F_input;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RF_input
		{
			get
			{
				if(r_F_input == null)
				{
					r_F_input = new(this, "_input");
					r_F_input.SetBelong(this.instance);
				}
				return r_F_input;
			}
		}

		/// <summary>
		/// System.Int32 _beginning
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_F_beginning;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RF_beginning
		{
			get
			{
				if(r_F_beginning == null)
				{
					r_F_beginning = new(this, "_beginning");
					r_F_beginning.SetBelong(this.instance);
				}
				return r_F_beginning;
			}
		}

		/// <summary>
		/// System.Int32 _length
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_F_length;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RF_length
		{
			get
			{
				if(r_F_length == null)
				{
					r_F_length = new(this, "_length");
					r_F_length.SetBelong(this.instance);
				}
				return r_F_length;
			}
		}

		/// <summary>
		/// System.Int32 _startat
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_F_startat;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RF_startat
		{
			get
			{
				if(r_F_startat == null)
				{
					r_F_startat = new(this, "_startat");
					r_F_startat.SetBelong(this.instance);
				}
				return r_F_startat;
			}
		}

		/// <summary>
		/// System.Int32 _prevlen
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_F_prevlen;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RF_prevlen
		{
			get
			{
				if(r_F_prevlen == null)
				{
					r_F_prevlen = new(this, "_prevlen");
					r_F_prevlen.SetBelong(this.instance);
				}
				return r_F_prevlen;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsReadOnly;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsReadOnly
		{
			get
			{
				if(r_PIsReadOnly == null)
				{
					r_PIsReadOnly = new(this, "IsReadOnly", -1);
					r_PIsReadOnly.SetBelong(this.instance);
				}
				return r_PIsReadOnly;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
					r_PCount.SetBelong(this.instance);
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Item [Int32]
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RMatch r_PItem_Int32;
		public virtual SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RMatch RPItem_Int32
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
		/// Boolean IsSynchronized
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSynchronized;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSynchronized
		{
			get
			{
				if(r_PIsSynchronized == null)
				{
					r_PIsSynchronized = new(this, "IsSynchronized", -1);
					r_PIsSynchronized.SetBelong(this.instance);
				}
				return r_PIsSynchronized;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PSyncRoot;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPSyncRoot
		{
			get
			{
				if(r_PSyncRoot == null)
				{
					r_PSyncRoot = new(this, "SyncRoot", -1);
					r_PSyncRoot.SetBelong(this.instance);
				}
				return r_PSyncRoot;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Item [Int32]
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RMatch r_PSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Item_Int32;
		public virtual SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RMatch RPSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Item_Int32
		{
			get
			{
				if(r_PSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Item_Int32 == null)
				{
					r_PSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Item_Int32 = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Item", -1, typeof(System.Int32));
					r_PSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Item_Int32.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Item_Int32;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.IsFixedSize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PSystem__2__Collections__2__IList__2__IsFixedSize;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPSystem__2__Collections__2__IList__2__IsFixedSize
		{
			get
			{
				if(r_PSystem__2__Collections__2__IList__2__IsFixedSize == null)
				{
					r_PSystem__2__Collections__2__IList__2__IsFixedSize = new(this, "System.Collections.IList.IsFixedSize", -1);
					r_PSystem__2__Collections__2__IList__2__IsFixedSize.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__IList__2__IsFixedSize;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IList.Item [Int32]
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PSystem__2__Collections__2__IList__2__Item_Int32;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPSystem__2__Collections__2__IList__2__Item_Int32
		{
			get
			{
				if(r_PSystem__2__Collections__2__IList__2__Item_Int32 == null)
				{
					r_PSystem__2__Collections__2__IList__2__Item_Int32 = new(this, "System.Collections.IList.Item", -1, typeof(System.Int32));
					r_PSystem__2__Collections__2__IList__2__Item_Int32.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__IList__2__Item_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
					r_MGetEnumerator.SetBelong(this.instance);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[System.Text.RegularExpressions.Match] System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator", 0);
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match GetMatch(Int32)
		/// </summary>
		protected RMethod r_MGetMatch_Int32;
		public virtual RMethod RMGetMatch_Int32
		{
			get
			{
				if(r_MGetMatch_Int32 == null)
				{
					r_MGetMatch_Int32 = new(this, "GetMatch", 0, typeof(System.Int32));
					r_MGetMatch_Int32.SetBelong(this.instance);
				}
				return r_MGetMatch_Int32;
			}
		}

		/// <summary>
		/// Void EnsureInitialized()
		/// </summary>
		protected RMethod r_MEnsureInitialized;
		public virtual RMethod RMEnsureInitialized
		{
			get
			{
				if(r_MEnsureInitialized == null)
				{
					r_MEnsureInitialized = new(this, "EnsureInitialized", 0);
					r_MEnsureInitialized.SetBelong(this.instance);
				}
				return r_MEnsureInitialized;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_MCopyTo_Array_Int32;
		public virtual RMethod RMCopyTo_Array_Int32
		{
			get
			{
				if(r_MCopyTo_Array_Int32 == null)
				{
					r_MCopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_MCopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_MCopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Text.RegularExpressions.Match[], Int32)
		/// </summary>
		protected RMethod r_MCopyTo_MatchArray_Int32;
		public virtual RMethod RMCopyTo_MatchArray_Int32
		{
			get
			{
				if(r_MCopyTo_MatchArray_Int32 == null)
				{
					r_MCopyTo_MatchArray_Int32 = new(this, "CopyTo", 0, typeof(System.Text.RegularExpressions.Match).MakeArrayType(), typeof(System.Int32));
					r_MCopyTo_MatchArray_Int32.SetBelong(this.instance);
				}
				return r_MCopyTo_MatchArray_Int32;
			}
		}

		/// <summary>
		/// Int32 System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf_Match;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf_Match
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf_Match == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf_Match = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf", 0, typeof(System.Text.RegularExpressions.Match));
					r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf_Match.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf_Match;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(Int32, System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert_Int32_Match;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert_Int32_Match
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert_Int32_Match == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert_Int32_Match = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert", 0, typeof(System.Int32), typeof(System.Text.RegularExpressions.Match));
					r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert_Int32_Match.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert_Int32_Match;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt_Int32;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt_Int32
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt_Int32 == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt_Int32 = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt", 0, typeof(System.Int32));
					r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add_Match;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add_Match
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add_Match == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add_Match = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add", 0, typeof(System.Text.RegularExpressions.Match));
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add_Match.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add_Match;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear", 0);
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains_Match;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains_Match
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains_Match == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains_Match = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains", 0, typeof(System.Text.RegularExpressions.Match));
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains_Match.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains_Match;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove_Match;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove_Match
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove_Match == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove_Match = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove", 0, typeof(System.Text.RegularExpressions.Match));
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove_Match.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove_Match;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.Add(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__Add_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__Add_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__Add_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__Add_Object = new(this, "System.Collections.IList.Add", 0, typeof(System.Object));
					r_MSystem__2__Collections__2__IList__2__Add_Object.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IList__2__Add_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Clear()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__Clear;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__Clear
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__Clear == null)
				{
					r_MSystem__2__Collections__2__IList__2__Clear = new(this, "System.Collections.IList.Clear", 0);
					r_MSystem__2__Collections__2__IList__2__Clear.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IList__2__Clear;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.Contains(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__Contains_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__Contains_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__Contains_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__Contains_Object = new(this, "System.Collections.IList.Contains", 0, typeof(System.Object));
					r_MSystem__2__Collections__2__IList__2__Contains_Object.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IList__2__Contains_Object;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.IndexOf(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__IndexOf_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__IndexOf_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__IndexOf_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__IndexOf_Object = new(this, "System.Collections.IList.IndexOf", 0, typeof(System.Object));
					r_MSystem__2__Collections__2__IList__2__IndexOf_Object.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IList__2__IndexOf_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__Insert_Int32_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__Insert_Int32_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__Insert_Int32_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__Insert_Int32_Object = new(this, "System.Collections.IList.Insert", 0, typeof(System.Int32), typeof(System.Object));
					r_MSystem__2__Collections__2__IList__2__Insert_Int32_Object.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IList__2__Insert_Int32_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Remove(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__Remove_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__Remove_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__Remove_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__Remove_Object = new(this, "System.Collections.IList.Remove", 0, typeof(System.Object));
					r_MSystem__2__Collections__2__IList__2__Remove_Object.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IList__2__Remove_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__RemoveAt_Int32;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__RemoveAt_Int32
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__RemoveAt_Int32 == null)
				{
					r_MSystem__2__Collections__2__IList__2__RemoveAt_Int32 = new(this, "System.Collections.IList.RemoveAt", 0, typeof(System.Int32));
					r_MSystem__2__Collections__2__IList__2__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IList__2__RemoveAt_Int32;
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


        public RMatchCollection() : base("System.Text.RegularExpressions.MatchCollection")
        {
        }

        public RMatchCollection(System.Object instance) : base("System.Text.RegularExpressions.MatchCollection")
		{
            SetInstance(instance);
		}

        public RMatchCollection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMatchCollection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match>)___result;
        }


        public virtual System.Text.RegularExpressions.Match GetMatch(System.Int32 @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RMGetMatch_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual void EnsureInitialized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnsureInitialized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Text.RegularExpressions.Match[] @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMCopyTo_MatchArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf(System.Text.RegularExpressions.Match @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf_Match.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert(System.Int32 @index, System.Text.RegularExpressions.Match @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RMSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert_Int32_Match.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add(System.Text.RegularExpressions.Match @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add_Match.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains(System.Text.RegularExpressions.Match @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains_Match.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove(System.Text.RegularExpressions.Match @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove_Match.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 System__2__Collections__2__IList__2__Add(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSystem__2__Collections__2__IList__2__Add_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__2__Collections__2__IList__2__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IList__2__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__2__Collections__2__IList__2__Contains(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSystem__2__Collections__2__IList__2__Contains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 System__2__Collections__2__IList__2__IndexOf(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSystem__2__Collections__2__IList__2__IndexOf_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__2__Collections__2__IList__2__Insert(System.Int32 @index, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMSystem__2__Collections__2__IList__2__Insert_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__IList__2__Remove(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSystem__2__Collections__2__IList__2__Remove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__IList__2__RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMSystem__2__Collections__2__IList__2__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
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
