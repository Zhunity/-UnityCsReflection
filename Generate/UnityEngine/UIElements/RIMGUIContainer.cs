using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IMGUIContainer
	/// </summary>
    public partial class RIMGUIContainer : RMember //
    {

		/// <summary>
		/// System.Action m_OnGUIHandler
		/// </summary>
		protected RSystem.RAction r_Fm_OnGUIHandler;
		public virtual RSystem.RAction RFm_OnGUIHandler
		{
			get
			{
				if(r_Fm_OnGUIHandler == null)
				{
					r_Fm_OnGUIHandler = new(this, "m_OnGUIHandler");
					r_Fm_OnGUIHandler.SetBelong(this.instance);
				}
				return r_Fm_OnGUIHandler;
			}
		}

		/// <summary>
		/// UnityEngine.ObjectGUIState m_ObjectGUIState
		/// </summary>
		protected RUnityEngine.RObjectGUIState r_Fm_ObjectGUIState;
		public virtual RUnityEngine.RObjectGUIState RFm_ObjectGUIState
		{
			get
			{
				if(r_Fm_ObjectGUIState == null)
				{
					r_Fm_ObjectGUIState = new(this, "m_ObjectGUIState");
					r_Fm_ObjectGUIState.SetBelong(this.instance);
				}
				return r_Fm_ObjectGUIState;
			}
		}

		/// <summary>
		/// System.Boolean useOwnerObjectGUIState
		/// </summary>
		protected RSystem.RBoolean r_FuseOwnerObjectGUIState;
		public virtual RSystem.RBoolean RFuseOwnerObjectGUIState
		{
			get
			{
				if(r_FuseOwnerObjectGUIState == null)
				{
					r_FuseOwnerObjectGUIState = new(this, "useOwnerObjectGUIState");
					r_FuseOwnerObjectGUIState.SetBelong(this.instance);
				}
				return r_FuseOwnerObjectGUIState;
			}
		}

		/// <summary>
		/// UnityEngine.Rect <lastWorldClip>k__BackingField
		/// </summary>
		protected RUnityEngine.RRect r_F__0__lastWorldClip__1__k__BackingField;
		public virtual RUnityEngine.RRect RF__0__lastWorldClip__1__k__BackingField
		{
			get
			{
				if(r_F__0__lastWorldClip__1__k__BackingField == null)
				{
					r_F__0__lastWorldClip__1__k__BackingField = new(this, "<lastWorldClip>k__BackingField");
					r_F__0__lastWorldClip__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__lastWorldClip__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean m_CullingEnabled
		/// </summary>
		protected RSystem.RBoolean r_Fm_CullingEnabled;
		public virtual RSystem.RBoolean RFm_CullingEnabled
		{
			get
			{
				if(r_Fm_CullingEnabled == null)
				{
					r_Fm_CullingEnabled = new(this, "m_CullingEnabled");
					r_Fm_CullingEnabled.SetBelong(this.instance);
				}
				return r_Fm_CullingEnabled;
			}
		}

		/// <summary>
		/// System.Boolean m_IsFocusDelegated
		/// </summary>
		protected RSystem.RBoolean r_Fm_IsFocusDelegated;
		public virtual RSystem.RBoolean RFm_IsFocusDelegated
		{
			get
			{
				if(r_Fm_IsFocusDelegated == null)
				{
					r_Fm_IsFocusDelegated = new(this, "m_IsFocusDelegated");
					r_Fm_IsFocusDelegated.SetBelong(this.instance);
				}
				return r_Fm_IsFocusDelegated;
			}
		}

		/// <summary>
		/// System.Boolean m_RefreshCachedLayout
		/// </summary>
		protected RSystem.RBoolean r_Fm_RefreshCachedLayout;
		public virtual RSystem.RBoolean RFm_RefreshCachedLayout
		{
			get
			{
				if(r_Fm_RefreshCachedLayout == null)
				{
					r_Fm_RefreshCachedLayout = new(this, "m_RefreshCachedLayout");
					r_Fm_RefreshCachedLayout.SetBelong(this.instance);
				}
				return r_Fm_RefreshCachedLayout;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutUtility+LayoutCache m_Cache
		/// </summary>
		protected RUnityEngine.RGUILayoutUtility.RLayoutCache r_Fm_Cache;
		public virtual RUnityEngine.RGUILayoutUtility.RLayoutCache RFm_Cache
		{
			get
			{
				if(r_Fm_Cache == null)
				{
					r_Fm_Cache = new(this, "m_Cache");
					r_Fm_Cache.SetBelong(this.instance);
				}
				return r_Fm_Cache;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_CachedClippingRect
		/// </summary>
		protected RUnityEngine.RRect r_Fm_CachedClippingRect;
		public virtual RUnityEngine.RRect RFm_CachedClippingRect
		{
			get
			{
				if(r_Fm_CachedClippingRect == null)
				{
					r_Fm_CachedClippingRect = new(this, "m_CachedClippingRect");
					r_Fm_CachedClippingRect.SetBelong(this.instance);
				}
				return r_Fm_CachedClippingRect;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_CachedTransform
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_Fm_CachedTransform;
		public virtual RUnityEngine.RMatrix4x4 RFm_CachedTransform
		{
			get
			{
				if(r_Fm_CachedTransform == null)
				{
					r_Fm_CachedTransform = new(this, "m_CachedTransform");
					r_Fm_CachedTransform.SetBelong(this.instance);
				}
				return r_Fm_CachedTransform;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ContextType <contextType>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RContextType r_F__0__contextType__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RContextType RF__0__contextType__1__k__BackingField
		{
			get
			{
				if(r_F__0__contextType__1__k__BackingField == null)
				{
					r_F__0__contextType__1__k__BackingField = new(this, "<contextType>k__BackingField");
					r_F__0__contextType__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__contextType__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean lostFocus
		/// </summary>
		protected RSystem.RBoolean r_FlostFocus;
		public virtual RSystem.RBoolean RFlostFocus
		{
			get
			{
				if(r_FlostFocus == null)
				{
					r_FlostFocus = new(this, "lostFocus");
					r_FlostFocus.SetBelong(this.instance);
				}
				return r_FlostFocus;
			}
		}

		/// <summary>
		/// System.Boolean receivedFocus
		/// </summary>
		protected RSystem.RBoolean r_FreceivedFocus;
		public virtual RSystem.RBoolean RFreceivedFocus
		{
			get
			{
				if(r_FreceivedFocus == null)
				{
					r_FreceivedFocus = new(this, "receivedFocus");
					r_FreceivedFocus.SetBelong(this.instance);
				}
				return r_FreceivedFocus;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusChangeDirection focusChangeDirection
		/// </summary>
		protected RUnityEngine.RUIElements.RFocusChangeDirection r_FfocusChangeDirection;
		public virtual RUnityEngine.RUIElements.RFocusChangeDirection RFfocusChangeDirection
		{
			get
			{
				if(r_FfocusChangeDirection == null)
				{
					r_FfocusChangeDirection = new(this, "focusChangeDirection");
					r_FfocusChangeDirection.SetBelong(this.instance);
				}
				return r_FfocusChangeDirection;
			}
		}

		/// <summary>
		/// System.Boolean hasFocusableControls
		/// </summary>
		protected RSystem.RBoolean r_FhasFocusableControls;
		public virtual RSystem.RBoolean RFhasFocusableControls
		{
			get
			{
				if(r_FhasFocusableControls == null)
				{
					r_FhasFocusableControls = new(this, "hasFocusableControls");
					r_FhasFocusableControls.SetBelong(this.instance);
				}
				return r_FhasFocusableControls;
			}
		}

		/// <summary>
		/// System.Int32 newKeyboardFocusControlID
		/// </summary>
		protected RSystem.RInt32 r_FnewKeyboardFocusControlID;
		public virtual RSystem.RInt32 RFnewKeyboardFocusControlID
		{
			get
			{
				if(r_FnewKeyboardFocusControlID == null)
				{
					r_FnewKeyboardFocusControlID = new(this, "newKeyboardFocusControlID");
					r_FnewKeyboardFocusControlID.SetBelong(this.instance);
				}
				return r_FnewKeyboardFocusControlID;
			}
		}

		/// <summary>
		/// System.Boolean <focusOnlyIfHasFocusableControls>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__focusOnlyIfHasFocusableControls__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__focusOnlyIfHasFocusableControls__1__k__BackingField
		{
			get
			{
				if(r_F__0__focusOnlyIfHasFocusableControls__1__k__BackingField == null)
				{
					r_F__0__focusOnlyIfHasFocusableControls__1__k__BackingField = new(this, "<focusOnlyIfHasFocusableControls>k__BackingField");
					r_F__0__focusOnlyIfHasFocusableControls__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__focusOnlyIfHasFocusableControls__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String ussClassName
		/// </summary>
		protected static RSystem.RString r_FussClassName;
		public static RSystem.RString RFussClassName
		{
			get
			{
				if(r_FussClassName == null)
				{
					r_FussClassName = new(typeof(UnityEngine.UIElements.IMGUIContainer), "ussClassName");
					r_FussClassName.SetBelong(null);
				}
				return r_FussClassName;
			}
		}

		/// <summary>
		/// System.String ussFoldoutChildDepthClassName
		/// </summary>
		protected static RSystem.RString r_FussFoldoutChildDepthClassName;
		public static RSystem.RString RFussFoldoutChildDepthClassName
		{
			get
			{
				if(r_FussFoldoutChildDepthClassName == null)
				{
					r_FussFoldoutChildDepthClassName = new(typeof(UnityEngine.UIElements.IMGUIContainer), "ussFoldoutChildDepthClassName");
					r_FussFoldoutChildDepthClassName.SetBelong(null);
				}
				return r_FussFoldoutChildDepthClassName;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] ussFoldoutChildDepthClassNames
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RSystem.RString> r_FussFoldoutChildDepthClassNames;
		public static RSystem.RCollections.RGeneric.RList<RSystem.RString> RFussFoldoutChildDepthClassNames
		{
			get
			{
				if(r_FussFoldoutChildDepthClassNames == null)
				{
					r_FussFoldoutChildDepthClassNames = new(typeof(UnityEngine.UIElements.IMGUIContainer), "ussFoldoutChildDepthClassNames");
					r_FussFoldoutChildDepthClassNames.SetBelong(null);
				}
				return r_FussFoldoutChildDepthClassNames;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IMGUIContainer+GUIGlobals m_GUIGlobals
		/// </summary>
		protected RUnityEngine.RUIElements.RIMGUIContainer.RGUIGlobals r_Fm_GUIGlobals;
		public virtual RUnityEngine.RUIElements.RIMGUIContainer.RGUIGlobals RFm_GUIGlobals
		{
			get
			{
				if(r_Fm_GUIGlobals == null)
				{
					r_Fm_GUIGlobals = new(this, "m_GUIGlobals");
					r_Fm_GUIGlobals.SetBelong(this.instance);
				}
				return r_Fm_GUIGlobals;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_OnGUIMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fk_OnGUIMarker;
		public static RUnity.RProfiling.RProfilerMarker RFk_OnGUIMarker
		{
			get
			{
				if(r_Fk_OnGUIMarker == null)
				{
					r_Fk_OnGUIMarker = new(typeof(UnityEngine.UIElements.IMGUIContainer), "k_OnGUIMarker");
					r_Fk_OnGUIMarker.SetBelong(null);
				}
				return r_Fk_OnGUIMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_ImmediateCallbackMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fk_ImmediateCallbackMarker;
		public static RUnity.RProfiling.RProfilerMarker RFk_ImmediateCallbackMarker
		{
			get
			{
				if(r_Fk_ImmediateCallbackMarker == null)
				{
					r_Fk_ImmediateCallbackMarker = new(typeof(UnityEngine.UIElements.IMGUIContainer), "k_ImmediateCallbackMarker");
					r_Fk_ImmediateCallbackMarker.SetBelong(null);
				}
				return r_Fk_ImmediateCallbackMarker;
			}
		}

		/// <summary>
		/// UnityEngine.Event s_DefaultMeasureEvent
		/// </summary>
		protected static RUnityEngine.REvent r_Fs_DefaultMeasureEvent;
		public static RUnityEngine.REvent RFs_DefaultMeasureEvent
		{
			get
			{
				if(r_Fs_DefaultMeasureEvent == null)
				{
					r_Fs_DefaultMeasureEvent = new(typeof(UnityEngine.UIElements.IMGUIContainer), "s_DefaultMeasureEvent");
					r_Fs_DefaultMeasureEvent.SetBelong(null);
				}
				return r_Fs_DefaultMeasureEvent;
			}
		}

		/// <summary>
		/// UnityEngine.Event s_MeasureEvent
		/// </summary>
		protected static RUnityEngine.REvent r_Fs_MeasureEvent;
		public static RUnityEngine.REvent RFs_MeasureEvent
		{
			get
			{
				if(r_Fs_MeasureEvent == null)
				{
					r_Fs_MeasureEvent = new(typeof(UnityEngine.UIElements.IMGUIContainer), "s_MeasureEvent");
					r_Fs_MeasureEvent.SetBelong(null);
				}
				return r_Fs_MeasureEvent;
			}
		}

		/// <summary>
		/// UnityEngine.Event s_CurrentEvent
		/// </summary>
		protected static RUnityEngine.REvent r_Fs_CurrentEvent;
		public static RUnityEngine.REvent RFs_CurrentEvent
		{
			get
			{
				if(r_Fs_CurrentEvent == null)
				{
					r_Fs_CurrentEvent = new(typeof(UnityEngine.UIElements.IMGUIContainer), "s_CurrentEvent");
					r_Fs_CurrentEvent.SetBelong(null);
				}
				return r_Fs_CurrentEvent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags m_Flags
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElementFlags r_Fm_Flags;
		public virtual RUnityEngine.RUIElements.RVisualElementFlags RFm_Flags
		{
			get
			{
				if(r_Fm_Flags == null)
				{
					r_Fm_Flags = new(this, "m_Flags");
					r_Fm_Flags.SetBelong(this.instance);
				}
				return r_Fm_Flags;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastLayout
		/// </summary>
		protected RUnityEngine.RRect r_FlastLayout;
		public virtual RUnityEngine.RRect RFlastLayout
		{
			get
			{
				if(r_FlastLayout == null)
				{
					r_FlastLayout = new(this, "lastLayout");
					r_FlastLayout.SetBelong(this.instance);
				}
				return r_FlastLayout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastPseudoPadding
		/// </summary>
		protected RUnityEngine.RRect r_FlastPseudoPadding;
		public virtual RUnityEngine.RRect RFlastPseudoPadding
		{
			get
			{
				if(r_FlastPseudoPadding == null)
				{
					r_FlastPseudoPadding = new(this, "lastPseudoPadding");
					r_FlastPseudoPadding.SetBelong(this.instance);
				}
				return r_FlastPseudoPadding;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainVEData renderChainData
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainVEData r_FrenderChainData;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainVEData RFrenderChainData
		{
			get
			{
				if(r_FrenderChainData == null)
				{
					r_FrenderChainData = new(this, "renderChainData");
					r_FrenderChainData.SetBelong(this.instance);
				}
				return r_FrenderChainData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates triggerPseudoMask
		/// </summary>
		protected RUnityEngine.RUIElements.RPseudoStates r_FtriggerPseudoMask;
		public virtual RUnityEngine.RUIElements.RPseudoStates RFtriggerPseudoMask
		{
			get
			{
				if(r_FtriggerPseudoMask == null)
				{
					r_FtriggerPseudoMask = new(this, "triggerPseudoMask");
					r_FtriggerPseudoMask.SetBelong(this.instance);
				}
				return r_FtriggerPseudoMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates dependencyPseudoMask
		/// </summary>
		protected RUnityEngine.RUIElements.RPseudoStates r_FdependencyPseudoMask;
		public virtual RUnityEngine.RUIElements.RPseudoStates RFdependencyPseudoMask
		{
			get
			{
				if(r_FdependencyPseudoMask == null)
				{
					r_FdependencyPseudoMask = new(this, "dependencyPseudoMask");
					r_FdependencyPseudoMask.SetBelong(this.instance);
				}
				return r_FdependencyPseudoMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle m_Style
		/// </summary>
		protected RUnityEngine.RUIElements.RComputedStyle r_Fm_Style;
		public virtual RUnityEngine.RUIElements.RComputedStyle RFm_Style
		{
			get
			{
				if(r_Fm_Style == null)
				{
					r_Fm_Style = new(this, "m_Style");
					r_Fm_Style.SetBelong(this.instance);
				}
				return r_Fm_Style;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableContext variableContext
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleVariableContext r_FvariableContext;
		public virtual RUnityEngine.RUIElements.RStyleVariableContext RFvariableContext
		{
			get
			{
				if(r_FvariableContext == null)
				{
					r_FvariableContext = new(this, "variableContext");
					r_FvariableContext.SetBelong(this.instance);
				}
				return r_FvariableContext;
			}
		}

		/// <summary>
		/// System.Int32 inheritedStylesHash
		/// </summary>
		protected RSystem.RInt32 r_FinheritedStylesHash;
		public virtual RSystem.RInt32 RFinheritedStylesHash
		{
			get
			{
				if(r_FinheritedStylesHash == null)
				{
					r_FinheritedStylesHash = new(this, "inheritedStylesHash");
					r_FinheritedStylesHash.SetBelong(this.instance);
				}
				return r_FinheritedStylesHash;
			}
		}

		/// <summary>
		/// System.UInt32 controlid
		/// </summary>
		protected RSystem.RUInt32 r_Fcontrolid;
		public virtual RSystem.RUInt32 RFcontrolid
		{
			get
			{
				if(r_Fcontrolid == null)
				{
					r_Fcontrolid = new(this, "controlid");
					r_Fcontrolid.SetBelong(this.instance);
				}
				return r_Fcontrolid;
			}
		}

		/// <summary>
		/// System.Int32 imguiContainerDescendantCount
		/// </summary>
		protected RSystem.RInt32 r_FimguiContainerDescendantCount;
		public virtual RSystem.RInt32 RFimguiContainerDescendantCount
		{
			get
			{
				if(r_FimguiContainerDescendantCount == null)
				{
					r_FimguiContainerDescendantCount = new(this, "imguiContainerDescendantCount");
					r_FimguiContainerDescendantCount.SetBelong(this.instance);
				}
				return r_FimguiContainerDescendantCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.InlineStyleAccess inlineStyleAccess
		/// </summary>
		protected RUnityEngine.RUIElements.RInlineStyleAccess r_FinlineStyleAccess;
		public virtual RUnityEngine.RUIElements.RInlineStyleAccess RFinlineStyleAccess
		{
			get
			{
				if(r_FinlineStyleAccess == null)
				{
					r_FinlineStyleAccess = new(this, "inlineStyleAccess");
					r_FinlineStyleAccess.SetBelong(this.instance);
				}
				return r_FinlineStyleAccess;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] styleSheetList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> r_FstyleSheetList;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> RFstyleSheetList
		{
			get
			{
				if(r_FstyleSheetList == null)
				{
					r_FstyleSheetList = new(this, "styleSheetList");
					r_FstyleSheetList.SetBelong(this.instance);
				}
				return r_FstyleSheetList;
			}
		}

		/// <summary>
		/// System.Boolean isIMGUIContainer
		/// </summary>
		protected RSystem.RBoolean r_FisIMGUIContainer;
		public virtual RSystem.RBoolean RFisIMGUIContainer
		{
			get
			{
				if(r_FisIMGUIContainer == null)
				{
					r_FisIMGUIContainer = new(this, "isIMGUIContainer");
					r_FisIMGUIContainer.SetBelong(this.instance);
				}
				return r_FisIMGUIContainer;
			}
		}

		/// <summary>
		/// System.Action onGUIHandler
		/// </summary>
		protected RSystem.RAction r_PonGUIHandler;
		public virtual RSystem.RAction RPonGUIHandler
		{
			get
			{
				if(r_PonGUIHandler == null)
				{
					r_PonGUIHandler = new(this, "onGUIHandler", -1);
					r_PonGUIHandler.SetBelong(this.instance);
				}
				return r_PonGUIHandler;
			}
		}

		/// <summary>
		/// UnityEngine.ObjectGUIState guiState
		/// </summary>
		protected RUnityEngine.RObjectGUIState r_PguiState;
		public virtual RUnityEngine.RObjectGUIState RPguiState
		{
			get
			{
				if(r_PguiState == null)
				{
					r_PguiState = new(this, "guiState", -1);
					r_PguiState.SetBelong(this.instance);
				}
				return r_PguiState;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastWorldClip
		/// </summary>
		protected RUnityEngine.RRect r_PlastWorldClip;
		public virtual RUnityEngine.RRect RPlastWorldClip
		{
			get
			{
				if(r_PlastWorldClip == null)
				{
					r_PlastWorldClip = new(this, "lastWorldClip", -1);
					r_PlastWorldClip.SetBelong(this.instance);
				}
				return r_PlastWorldClip;
			}
		}

		/// <summary>
		/// Boolean cullingEnabled
		/// </summary>
		protected RSystem.RBoolean r_PcullingEnabled;
		public virtual RSystem.RBoolean RPcullingEnabled
		{
			get
			{
				if(r_PcullingEnabled == null)
				{
					r_PcullingEnabled = new(this, "cullingEnabled", -1);
					r_PcullingEnabled.SetBelong(this.instance);
				}
				return r_PcullingEnabled;
			}
		}

		/// <summary>
		/// LayoutCache cache
		/// </summary>
		protected RUnityEngine.RGUILayoutUtility.RLayoutCache r_Pcache;
		public virtual RUnityEngine.RGUILayoutUtility.RLayoutCache RPcache
		{
			get
			{
				if(r_Pcache == null)
				{
					r_Pcache = new(this, "cache", -1);
					r_Pcache.SetBelong(this.instance);
				}
				return r_Pcache;
			}
		}

		/// <summary>
		/// Single layoutMeasuredWidth
		/// </summary>
		protected RSystem.RSingle r_PlayoutMeasuredWidth;
		public virtual RSystem.RSingle RPlayoutMeasuredWidth
		{
			get
			{
				if(r_PlayoutMeasuredWidth == null)
				{
					r_PlayoutMeasuredWidth = new(this, "layoutMeasuredWidth", -1);
					r_PlayoutMeasuredWidth.SetBelong(this.instance);
				}
				return r_PlayoutMeasuredWidth;
			}
		}

		/// <summary>
		/// Single layoutMeasuredHeight
		/// </summary>
		protected RSystem.RSingle r_PlayoutMeasuredHeight;
		public virtual RSystem.RSingle RPlayoutMeasuredHeight
		{
			get
			{
				if(r_PlayoutMeasuredHeight == null)
				{
					r_PlayoutMeasuredHeight = new(this, "layoutMeasuredHeight", -1);
					r_PlayoutMeasuredHeight.SetBelong(this.instance);
				}
				return r_PlayoutMeasuredHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ContextType contextType
		/// </summary>
		protected RUnityEngine.RUIElements.RContextType r_PcontextType;
		public virtual RUnityEngine.RUIElements.RContextType RPcontextType
		{
			get
			{
				if(r_PcontextType == null)
				{
					r_PcontextType = new(this, "contextType", -1);
					r_PcontextType.SetBelong(this.instance);
				}
				return r_PcontextType;
			}
		}

		/// <summary>
		/// Boolean focusOnlyIfHasFocusableControls
		/// </summary>
		protected RSystem.RBoolean r_PfocusOnlyIfHasFocusableControls;
		public virtual RSystem.RBoolean RPfocusOnlyIfHasFocusableControls
		{
			get
			{
				if(r_PfocusOnlyIfHasFocusableControls == null)
				{
					r_PfocusOnlyIfHasFocusableControls = new(this, "focusOnlyIfHasFocusableControls", -1);
					r_PfocusOnlyIfHasFocusableControls.SetBelong(this.instance);
				}
				return r_PfocusOnlyIfHasFocusableControls;
			}
		}

		/// <summary>
		/// Boolean canGrabFocus
		/// </summary>
		protected RSystem.RBoolean r_PcanGrabFocus;
		public virtual RSystem.RBoolean RPcanGrabFocus
		{
			get
			{
				if(r_PcanGrabFocus == null)
				{
					r_PcanGrabFocus = new(this, "canGrabFocus", -1);
					r_PcanGrabFocus.SetBelong(this.instance);
				}
				return r_PcanGrabFocus;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IResolvedStyle resolvedStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RIResolvedStyle r_PresolvedStyle;
		public virtual RUnityEngine.RUIElements.RIResolvedStyle RPresolvedStyle
		{
			get
			{
				if(r_PresolvedStyle == null)
				{
					r_PresolvedStyle = new(this, "resolvedStyle", -1);
					r_PresolvedStyle.SetBelong(this.instance);
				}
				return r_PresolvedStyle;
			}
		}

		/// <summary>
		/// Boolean hasRunningAnimations
		/// </summary>
		protected RSystem.RBoolean r_PhasRunningAnimations;
		public virtual RSystem.RBoolean RPhasRunningAnimations
		{
			get
			{
				if(r_PhasRunningAnimations == null)
				{
					r_PhasRunningAnimations = new(this, "hasRunningAnimations", -1);
					r_PhasRunningAnimations.SetBelong(this.instance);
				}
				return r_PhasRunningAnimations;
			}
		}

		/// <summary>
		/// Boolean hasCompletedAnimations
		/// </summary>
		protected RSystem.RBoolean r_PhasCompletedAnimations;
		public virtual RSystem.RBoolean RPhasCompletedAnimations
		{
			get
			{
				if(r_PhasCompletedAnimations == null)
				{
					r_PhasCompletedAnimations = new(this, "hasCompletedAnimations", -1);
					r_PhasCompletedAnimations.SetBelong(this.instance);
				}
				return r_PhasCompletedAnimations;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStylePropertyAnimations styleAnimation
		/// </summary>
		protected RUnityEngine.RUIElements.RIStylePropertyAnimations r_PstyleAnimation;
		public virtual RUnityEngine.RUIElements.RIStylePropertyAnimations RPstyleAnimation
		{
			get
			{
				if(r_PstyleAnimation == null)
				{
					r_PstyleAnimation = new(this, "styleAnimation", -1);
					r_PstyleAnimation.SetBelong(this.instance);
				}
				return r_PstyleAnimation;
			}
		}

		/// <summary>
		/// Boolean isCompositeRoot
		/// </summary>
		protected RSystem.RBoolean r_PisCompositeRoot;
		public virtual RSystem.RBoolean RPisCompositeRoot
		{
			get
			{
				if(r_PisCompositeRoot == null)
				{
					r_PisCompositeRoot = new(this, "isCompositeRoot", -1);
					r_PisCompositeRoot.SetBelong(this.instance);
				}
				return r_PisCompositeRoot;
			}
		}

		/// <summary>
		/// Boolean isHierarchyDisplayed
		/// </summary>
		protected RSystem.RBoolean r_PisHierarchyDisplayed;
		public virtual RSystem.RBoolean RPisHierarchyDisplayed
		{
			get
			{
				if(r_PisHierarchyDisplayed == null)
				{
					r_PisHierarchyDisplayed = new(this, "isHierarchyDisplayed", -1);
					r_PisHierarchyDisplayed.SetBelong(this.instance);
				}
				return r_PisHierarchyDisplayed;
			}
		}

		/// <summary>
		/// System.String viewDataKey
		/// </summary>
		protected RSystem.RString r_PviewDataKey;
		public virtual RSystem.RString RPviewDataKey
		{
			get
			{
				if(r_PviewDataKey == null)
				{
					r_PviewDataKey = new(this, "viewDataKey", -1);
					r_PviewDataKey.SetBelong(this.instance);
				}
				return r_PviewDataKey;
			}
		}

		/// <summary>
		/// Boolean enableViewDataPersistence
		/// </summary>
		protected RSystem.RBoolean r_PenableViewDataPersistence;
		public virtual RSystem.RBoolean RPenableViewDataPersistence
		{
			get
			{
				if(r_PenableViewDataPersistence == null)
				{
					r_PenableViewDataPersistence = new(this, "enableViewDataPersistence", -1);
					r_PenableViewDataPersistence.SetBelong(this.instance);
				}
				return r_PenableViewDataPersistence;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected RSystem.RObject r_PuserData;
		public virtual RSystem.RObject RPuserData
		{
			get
			{
				if(r_PuserData == null)
				{
					r_PuserData = new(this, "userData", -1);
					r_PuserData.SetBelong(this.instance);
				}
				return r_PuserData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusController focusController
		/// </summary>
		protected RUnityEngine.RUIElements.RFocusController r_PfocusController;
		public virtual RUnityEngine.RUIElements.RFocusController RPfocusController
		{
			get
			{
				if(r_PfocusController == null)
				{
					r_PfocusController = new(this, "focusController", -1);
					r_PfocusController.SetBelong(this.instance);
				}
				return r_PfocusController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UsageHints usageHints
		/// </summary>
		protected RUnityEngine.RUIElements.RUsageHints r_PusageHints;
		public virtual RUnityEngine.RUIElements.RUsageHints RPusageHints
		{
			get
			{
				if(r_PusageHints == null)
				{
					r_PusageHints = new(this, "usageHints", -1);
					r_PusageHints.SetBelong(this.instance);
				}
				return r_PusageHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RenderHints renderHints
		/// </summary>
		protected RUnityEngine.RUIElements.RRenderHints r_PrenderHints;
		public virtual RUnityEngine.RUIElements.RRenderHints RPrenderHints
		{
			get
			{
				if(r_PrenderHints == null)
				{
					r_PrenderHints = new(this, "renderHints", -1);
					r_PrenderHints.SetBelong(this.instance);
				}
				return r_PrenderHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ITransform transform
		/// </summary>
		protected RUnityEngine.RUIElements.RITransform r_Ptransform;
		public virtual RUnityEngine.RUIElements.RITransform RPtransform
		{
			get
			{
				if(r_Ptransform == null)
				{
					r_Ptransform = new(this, "transform", -1);
					r_Ptransform.SetBelong(this.instance);
				}
				return r_Ptransform;
			}
		}

		/// <summary>
		/// Boolean isLayoutManual
		/// </summary>
		protected RSystem.RBoolean r_PisLayoutManual;
		public virtual RSystem.RBoolean RPisLayoutManual
		{
			get
			{
				if(r_PisLayoutManual == null)
				{
					r_PisLayoutManual = new(this, "isLayoutManual", -1);
					r_PisLayoutManual.SetBelong(this.instance);
				}
				return r_PisLayoutManual;
			}
		}

		/// <summary>
		/// Single scaledPixelsPerPoint
		/// </summary>
		protected RSystem.RSingle r_PscaledPixelsPerPoint;
		public virtual RSystem.RSingle RPscaledPixelsPerPoint
		{
			get
			{
				if(r_PscaledPixelsPerPoint == null)
				{
					r_PscaledPixelsPerPoint = new(this, "scaledPixelsPerPoint", -1);
					r_PscaledPixelsPerPoint.SetBelong(this.instance);
				}
				return r_PscaledPixelsPerPoint;
			}
		}

		/// <summary>
		/// UnityEngine.Rect layout
		/// </summary>
		protected RUnityEngine.RRect r_Playout;
		public virtual RUnityEngine.RRect RPlayout
		{
			get
			{
				if(r_Playout == null)
				{
					r_Playout = new(this, "layout", -1);
					r_Playout.SetBelong(this.instance);
				}
				return r_Playout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect contentRect
		/// </summary>
		protected RUnityEngine.RRect r_PcontentRect;
		public virtual RUnityEngine.RRect RPcontentRect
		{
			get
			{
				if(r_PcontentRect == null)
				{
					r_PcontentRect = new(this, "contentRect", -1);
					r_PcontentRect.SetBelong(this.instance);
				}
				return r_PcontentRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect paddingRect
		/// </summary>
		protected RUnityEngine.RRect r_PpaddingRect;
		public virtual RUnityEngine.RRect RPpaddingRect
		{
			get
			{
				if(r_PpaddingRect == null)
				{
					r_PpaddingRect = new(this, "paddingRect", -1);
					r_PpaddingRect.SetBelong(this.instance);
				}
				return r_PpaddingRect;
			}
		}

		/// <summary>
		/// Boolean isBoundingBoxDirty
		/// </summary>
		protected RSystem.RBoolean r_PisBoundingBoxDirty;
		public virtual RSystem.RBoolean RPisBoundingBoxDirty
		{
			get
			{
				if(r_PisBoundingBoxDirty == null)
				{
					r_PisBoundingBoxDirty = new(this, "isBoundingBoxDirty", -1);
					r_PisBoundingBoxDirty.SetBelong(this.instance);
				}
				return r_PisBoundingBoxDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldBoundingBoxDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldBoundingBoxDirty;
		public virtual RSystem.RBoolean RPisWorldBoundingBoxDirty
		{
			get
			{
				if(r_PisWorldBoundingBoxDirty == null)
				{
					r_PisWorldBoundingBoxDirty = new(this, "isWorldBoundingBoxDirty", -1);
					r_PisWorldBoundingBoxDirty.SetBelong(this.instance);
				}
				return r_PisWorldBoundingBoxDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldBoundingBoxOrDependenciesDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldBoundingBoxOrDependenciesDirty;
		public virtual RSystem.RBoolean RPisWorldBoundingBoxOrDependenciesDirty
		{
			get
			{
				if(r_PisWorldBoundingBoxOrDependenciesDirty == null)
				{
					r_PisWorldBoundingBoxOrDependenciesDirty = new(this, "isWorldBoundingBoxOrDependenciesDirty", -1);
					r_PisWorldBoundingBoxOrDependenciesDirty.SetBelong(this.instance);
				}
				return r_PisWorldBoundingBoxOrDependenciesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Rect boundingBox
		/// </summary>
		protected RUnityEngine.RRect r_PboundingBox;
		public virtual RUnityEngine.RRect RPboundingBox
		{
			get
			{
				if(r_PboundingBox == null)
				{
					r_PboundingBox = new(this, "boundingBox", -1);
					r_PboundingBox.SetBelong(this.instance);
				}
				return r_PboundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldBoundingBox
		/// </summary>
		protected RUnityEngine.RRect r_PworldBoundingBox;
		public virtual RUnityEngine.RRect RPworldBoundingBox
		{
			get
			{
				if(r_PworldBoundingBox == null)
				{
					r_PworldBoundingBox = new(this, "worldBoundingBox", -1);
					r_PworldBoundingBox.SetBelong(this.instance);
				}
				return r_PworldBoundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldBound
		/// </summary>
		protected RUnityEngine.RRect r_PworldBound;
		public virtual RUnityEngine.RRect RPworldBound
		{
			get
			{
				if(r_PworldBound == null)
				{
					r_PworldBound = new(this, "worldBound", -1);
					r_PworldBound.SetBelong(this.instance);
				}
				return r_PworldBound;
			}
		}

		/// <summary>
		/// UnityEngine.Rect localBound
		/// </summary>
		protected RUnityEngine.RRect r_PlocalBound;
		public virtual RUnityEngine.RRect RPlocalBound
		{
			get
			{
				if(r_PlocalBound == null)
				{
					r_PlocalBound = new(this, "localBound", -1);
					r_PlocalBound.SetBelong(this.instance);
				}
				return r_PlocalBound;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected RUnityEngine.RRect r_Prect;
		public virtual RUnityEngine.RRect RPrect
		{
			get
			{
				if(r_Prect == null)
				{
					r_Prect = new(this, "rect", -1);
					r_Prect.SetBelong(this.instance);
				}
				return r_Prect;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldTransformDirty;
		public virtual RSystem.RBoolean RPisWorldTransformDirty
		{
			get
			{
				if(r_PisWorldTransformDirty == null)
				{
					r_PisWorldTransformDirty = new(this, "isWorldTransformDirty", -1);
					r_PisWorldTransformDirty.SetBelong(this.instance);
				}
				return r_PisWorldTransformDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformInverseDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldTransformInverseDirty;
		public virtual RSystem.RBoolean RPisWorldTransformInverseDirty
		{
			get
			{
				if(r_PisWorldTransformInverseDirty == null)
				{
					r_PisWorldTransformInverseDirty = new(this, "isWorldTransformInverseDirty", -1);
					r_PisWorldTransformInverseDirty.SetBelong(this.instance);
				}
				return r_PisWorldTransformInverseDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformInverseOrDependenciesDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldTransformInverseOrDependenciesDirty;
		public virtual RSystem.RBoolean RPisWorldTransformInverseOrDependenciesDirty
		{
			get
			{
				if(r_PisWorldTransformInverseOrDependenciesDirty == null)
				{
					r_PisWorldTransformInverseOrDependenciesDirty = new(this, "isWorldTransformInverseOrDependenciesDirty", -1);
					r_PisWorldTransformInverseOrDependenciesDirty.SetBelong(this.instance);
				}
				return r_PisWorldTransformInverseOrDependenciesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 worldTransform
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_PworldTransform;
		public virtual RUnityEngine.RMatrix4x4 RPworldTransform
		{
			get
			{
				if(r_PworldTransform == null)
				{
					r_PworldTransform = new(this, "worldTransform", -1);
					r_PworldTransform.SetBelong(this.instance);
				}
				return r_PworldTransform;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4& worldTransformRef
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_PworldTransformRef;
		public virtual RUnityEngine.RMatrix4x4 RPworldTransformRef
		{
			get
			{
				if(r_PworldTransformRef == null)
				{
					r_PworldTransformRef = new(this, "worldTransformRef", -1);
					r_PworldTransformRef.SetBelong(this.instance);
				}
				return r_PworldTransformRef;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4& worldTransformInverse
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_PworldTransformInverse;
		public virtual RUnityEngine.RMatrix4x4 RPworldTransformInverse
		{
			get
			{
				if(r_PworldTransformInverse == null)
				{
					r_PworldTransformInverse = new(this, "worldTransformInverse", -1);
					r_PworldTransformInverse.SetBelong(this.instance);
				}
				return r_PworldTransformInverse;
			}
		}

		/// <summary>
		/// Boolean isWorldClipDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldClipDirty;
		public virtual RSystem.RBoolean RPisWorldClipDirty
		{
			get
			{
				if(r_PisWorldClipDirty == null)
				{
					r_PisWorldClipDirty = new(this, "isWorldClipDirty", -1);
					r_PisWorldClipDirty.SetBelong(this.instance);
				}
				return r_PisWorldClipDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldClip
		/// </summary>
		protected RUnityEngine.RRect r_PworldClip;
		public virtual RUnityEngine.RRect RPworldClip
		{
			get
			{
				if(r_PworldClip == null)
				{
					r_PworldClip = new(this, "worldClip", -1);
					r_PworldClip.SetBelong(this.instance);
				}
				return r_PworldClip;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldClipMinusGroup
		/// </summary>
		protected RUnityEngine.RRect r_PworldClipMinusGroup;
		public virtual RUnityEngine.RRect RPworldClipMinusGroup
		{
			get
			{
				if(r_PworldClipMinusGroup == null)
				{
					r_PworldClipMinusGroup = new(this, "worldClipMinusGroup", -1);
					r_PworldClipMinusGroup.SetBelong(this.instance);
				}
				return r_PworldClipMinusGroup;
			}
		}

		/// <summary>
		/// Boolean worldClipIsInfinite
		/// </summary>
		protected RSystem.RBoolean r_PworldClipIsInfinite;
		public virtual RSystem.RBoolean RPworldClipIsInfinite
		{
			get
			{
				if(r_PworldClipIsInfinite == null)
				{
					r_PworldClipIsInfinite = new(this, "worldClipIsInfinite", -1);
					r_PworldClipIsInfinite.SetBelong(this.instance);
				}
				return r_PworldClipIsInfinite;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates pseudoStates
		/// </summary>
		protected RUnityEngine.RUIElements.RPseudoStates r_PpseudoStates;
		public virtual RUnityEngine.RUIElements.RPseudoStates RPpseudoStates
		{
			get
			{
				if(r_PpseudoStates == null)
				{
					r_PpseudoStates = new(this, "pseudoStates", -1);
					r_PpseudoStates.SetBelong(this.instance);
				}
				return r_PpseudoStates;
			}
		}

		/// <summary>
		/// Int32 containedPointerIds
		/// </summary>
		protected RSystem.RInt32 r_PcontainedPointerIds;
		public virtual RSystem.RInt32 RPcontainedPointerIds
		{
			get
			{
				if(r_PcontainedPointerIds == null)
				{
					r_PcontainedPointerIds = new(this, "containedPointerIds", -1);
					r_PcontainedPointerIds.SetBelong(this.instance);
				}
				return r_PcontainedPointerIds;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PickingMode pickingMode
		/// </summary>
		protected RUnityEngine.RUIElements.RPickingMode r_PpickingMode;
		public virtual RUnityEngine.RUIElements.RPickingMode RPpickingMode
		{
			get
			{
				if(r_PpickingMode == null)
				{
					r_PpickingMode = new(this, "pickingMode", -1);
					r_PpickingMode.SetBelong(this.instance);
				}
				return r_PpickingMode;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_Pname;
		public virtual RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] classList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RString> r_PclassList;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RString> RPclassList
		{
			get
			{
				if(r_PclassList == null)
				{
					r_PclassList = new(this, "classList", -1);
					r_PclassList.SetBelong(this.instance);
				}
				return r_PclassList;
			}
		}

		/// <summary>
		/// System.String fullTypeName
		/// </summary>
		protected RSystem.RString r_PfullTypeName;
		public virtual RSystem.RString RPfullTypeName
		{
			get
			{
				if(r_PfullTypeName == null)
				{
					r_PfullTypeName = new(this, "fullTypeName", -1);
					r_PfullTypeName.SetBelong(this.instance);
				}
				return r_PfullTypeName;
			}
		}

		/// <summary>
		/// System.String typeName
		/// </summary>
		protected RSystem.RString r_PtypeName;
		public virtual RSystem.RString RPtypeName
		{
			get
			{
				if(r_PtypeName == null)
				{
					r_PtypeName = new(this, "typeName", -1);
					r_PtypeName.SetBelong(this.instance);
				}
				return r_PtypeName;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode yogaNode
		/// </summary>
		protected RUnityEngine.RYoga.RYogaNode r_PyogaNode;
		public virtual RUnityEngine.RYoga.RYogaNode RPyogaNode
		{
			get
			{
				if(r_PyogaNode == null)
				{
					r_PyogaNode = new(this, "yogaNode", -1);
					r_PyogaNode.SetBelong(this.instance);
				}
				return r_PyogaNode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle& computedStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RComputedStyle r_PcomputedStyle;
		public virtual RUnityEngine.RUIElements.RComputedStyle RPcomputedStyle
		{
			get
			{
				if(r_PcomputedStyle == null)
				{
					r_PcomputedStyle = new(this, "computedStyle", -1);
					r_PcomputedStyle.SetBelong(this.instance);
				}
				return r_PcomputedStyle;
			}
		}

		/// <summary>
		/// Boolean hasInlineStyle
		/// </summary>
		protected RSystem.RBoolean r_PhasInlineStyle;
		public virtual RSystem.RBoolean RPhasInlineStyle
		{
			get
			{
				if(r_PhasInlineStyle == null)
				{
					r_PhasInlineStyle = new(this, "hasInlineStyle", -1);
					r_PhasInlineStyle.SetBelong(this.instance);
				}
				return r_PhasInlineStyle;
			}
		}

		/// <summary>
		/// Boolean styleInitialized
		/// </summary>
		protected RSystem.RBoolean r_PstyleInitialized;
		public virtual RSystem.RBoolean RPstyleInitialized
		{
			get
			{
				if(r_PstyleInitialized == null)
				{
					r_PstyleInitialized = new(this, "styleInitialized", -1);
					r_PstyleInitialized.SetBelong(this.instance);
				}
				return r_PstyleInitialized;
			}
		}

		/// <summary>
		/// Single opacity
		/// </summary>
		protected RSystem.RSingle r_Popacity;
		public virtual RSystem.RSingle RPopacity
		{
			get
			{
				if(r_Popacity == null)
				{
					r_Popacity = new(this, "opacity", -1);
					r_Popacity.SetBelong(this.instance);
				}
				return r_Popacity;
			}
		}

		/// <summary>
		/// Boolean enabledInHierarchy
		/// </summary>
		protected RSystem.RBoolean r_PenabledInHierarchy;
		public virtual RSystem.RBoolean RPenabledInHierarchy
		{
			get
			{
				if(r_PenabledInHierarchy == null)
				{
					r_PenabledInHierarchy = new(this, "enabledInHierarchy", -1);
					r_PenabledInHierarchy.SetBelong(this.instance);
				}
				return r_PenabledInHierarchy;
			}
		}

		/// <summary>
		/// Boolean enabledSelf
		/// </summary>
		protected RSystem.RBoolean r_PenabledSelf;
		public virtual RSystem.RBoolean RPenabledSelf
		{
			get
			{
				if(r_PenabledSelf == null)
				{
					r_PenabledSelf = new(this, "enabledSelf", -1);
					r_PenabledSelf.SetBelong(this.instance);
				}
				return r_PenabledSelf;
			}
		}

		/// <summary>
		/// Boolean visible
		/// </summary>
		protected RSystem.RBoolean r_Pvisible;
		public virtual RSystem.RBoolean RPvisible
		{
			get
			{
				if(r_Pvisible == null)
				{
					r_Pvisible = new(this, "visible", -1);
					r_Pvisible.SetBelong(this.instance);
				}
				return r_Pvisible;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.MeshGenerationContext] generateVisualContent
		/// </summary>
		protected RSystem.RAction<RUnityEngine.RUIElements.RMeshGenerationContext> r_PgenerateVisualContent;
		public virtual RSystem.RAction<RUnityEngine.RUIElements.RMeshGenerationContext> RPgenerateVisualContent
		{
			get
			{
				if(r_PgenerateVisualContent == null)
				{
					r_PgenerateVisualContent = new(this, "generateVisualContent", -1);
					r_PgenerateVisualContent.SetBelong(this.instance);
				}
				return r_PgenerateVisualContent;
			}
		}

		/// <summary>
		/// Boolean requireMeasureFunction
		/// </summary>
		protected RSystem.RBoolean r_PrequireMeasureFunction;
		public virtual RSystem.RBoolean RPrequireMeasureFunction
		{
			get
			{
				if(r_PrequireMeasureFunction == null)
				{
					r_PrequireMeasureFunction = new(this, "requireMeasureFunction", -1);
					r_PrequireMeasureFunction.SetBelong(this.instance);
				}
				return r_PrequireMeasureFunction;
			}
		}

		/// <summary>
		/// RenderTargetMode subRenderTargetMode
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RRenderTargetMode r_PsubRenderTargetMode;
		public virtual RUnityEngine.RUIElements.RVisualElement.RRenderTargetMode RPsubRenderTargetMode
		{
			get
			{
				if(r_PsubRenderTargetMode == null)
				{
					r_PsubRenderTargetMode = new(this, "subRenderTargetMode", -1);
					r_PsubRenderTargetMode.SetBelong(this.instance);
				}
				return r_PsubRenderTargetMode;
			}
		}

		/// <summary>
		/// UnityEngine.Material defaultMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_PdefaultMaterial;
		public virtual RUnityEngine.RMaterial RPdefaultMaterial
		{
			get
			{
				if(r_PdefaultMaterial == null)
				{
					r_PdefaultMaterial = new(this, "defaultMaterial", -1);
					r_PdefaultMaterial.SetBelong(this.instance);
				}
				return r_PdefaultMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement nextParentWithEventCallback
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_PnextParentWithEventCallback;
		public virtual RUnityEngine.RUIElements.RVisualElement RPnextParentWithEventCallback
		{
			get
			{
				if(r_PnextParentWithEventCallback == null)
				{
					r_PnextParentWithEventCallback = new(this, "nextParentWithEventCallback", -1);
					r_PnextParentWithEventCallback.SetBelong(this.instance);
				}
				return r_PnextParentWithEventCallback;
			}
		}

		/// <summary>
		/// Int32 eventCallbackCategories
		/// </summary>
		protected RSystem.RInt32 r_PeventCallbackCategories;
		public virtual RSystem.RInt32 RPeventCallbackCategories
		{
			get
			{
				if(r_PeventCallbackCategories == null)
				{
					r_PeventCallbackCategories = new(this, "eventCallbackCategories", -1);
					r_PeventCallbackCategories.SetBelong(this.instance);
				}
				return r_PeventCallbackCategories;
			}
		}

		/// <summary>
		/// Int32 eventCallbackParentCategories
		/// </summary>
		protected RSystem.RInt32 r_PeventCallbackParentCategories;
		public virtual RSystem.RInt32 RPeventCallbackParentCategories
		{
			get
			{
				if(r_PeventCallbackParentCategories == null)
				{
					r_PeventCallbackParentCategories = new(this, "eventCallbackParentCategories", -1);
					r_PeventCallbackParentCategories.SetBelong(this.instance);
				}
				return r_PeventCallbackParentCategories;
			}
		}

		/// <summary>
		/// Boolean isEventCallbackParentCategoriesDirty
		/// </summary>
		protected RSystem.RBoolean r_PisEventCallbackParentCategoriesDirty;
		public virtual RSystem.RBoolean RPisEventCallbackParentCategoriesDirty
		{
			get
			{
				if(r_PisEventCallbackParentCategoriesDirty == null)
				{
					r_PisEventCallbackParentCategoriesDirty = new(this, "isEventCallbackParentCategoriesDirty", -1);
					r_PisEventCallbackParentCategoriesDirty.SetBelong(this.instance);
				}
				return r_PisEventCallbackParentCategoriesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IExperimentalFeatures experimental
		/// </summary>
		protected RUnityEngine.RUIElements.RIExperimentalFeatures r_Pexperimental;
		public virtual RUnityEngine.RUIElements.RIExperimentalFeatures RPexperimental
		{
			get
			{
				if(r_Pexperimental == null)
				{
					r_Pexperimental = new(this, "experimental", -1);
					r_Pexperimental.SetBelong(this.instance);
				}
				return r_Pexperimental;
			}
		}

		/// <summary>
		/// Hierarchy hierarchy
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RHierarchy r_Phierarchy;
		public virtual RUnityEngine.RUIElements.RVisualElement.RHierarchy RPhierarchy
		{
			get
			{
				if(r_Phierarchy == null)
				{
					r_Phierarchy = new(this, "hierarchy", -1);
					r_Phierarchy.SetBelong(this.instance);
				}
				return r_Phierarchy;
			}
		}

		/// <summary>
		/// Boolean isRootVisualContainer
		/// </summary>
		protected RSystem.RBoolean r_PisRootVisualContainer;
		public virtual RSystem.RBoolean RPisRootVisualContainer
		{
			get
			{
				if(r_PisRootVisualContainer == null)
				{
					r_PisRootVisualContainer = new(this, "isRootVisualContainer", -1);
					r_PisRootVisualContainer.SetBelong(this.instance);
				}
				return r_PisRootVisualContainer;
			}
		}

		/// <summary>
		/// Boolean cacheAsBitmap
		/// </summary>
		protected RSystem.RBoolean r_PcacheAsBitmap;
		public virtual RSystem.RBoolean RPcacheAsBitmap
		{
			get
			{
				if(r_PcacheAsBitmap == null)
				{
					r_PcacheAsBitmap = new(this, "cacheAsBitmap", -1);
					r_PcacheAsBitmap.SetBelong(this.instance);
				}
				return r_PcacheAsBitmap;
			}
		}

		/// <summary>
		/// Boolean disableClipping
		/// </summary>
		protected RSystem.RBoolean r_PdisableClipping;
		public virtual RSystem.RBoolean RPdisableClipping
		{
			get
			{
				if(r_PdisableClipping == null)
				{
					r_PdisableClipping = new(this, "disableClipping", -1);
					r_PdisableClipping.SetBelong(this.instance);
				}
				return r_PdisableClipping;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement parent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Pparent;
		public virtual RUnityEngine.RUIElements.RVisualElement RPparent
		{
			get
			{
				if(r_Pparent == null)
				{
					r_Pparent = new(this, "parent", -1);
					r_Pparent.SetBelong(this.instance);
				}
				return r_Pparent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel elementPanel
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseVisualElementPanel r_PelementPanel;
		public virtual RUnityEngine.RUIElements.RBaseVisualElementPanel RPelementPanel
		{
			get
			{
				if(r_PelementPanel == null)
				{
					r_PelementPanel = new(this, "elementPanel", -1);
					r_PelementPanel.SetBelong(this.instance);
				}
				return r_PelementPanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanel panel
		/// </summary>
		protected RUnityEngine.RUIElements.RIPanel r_Ppanel;
		public virtual RUnityEngine.RUIElements.RIPanel RPpanel
		{
			get
			{
				if(r_Ppanel == null)
				{
					r_Ppanel = new(this, "panel", -1);
					r_Ppanel.SetBelong(this.instance);
				}
				return r_Ppanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement contentContainer
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_PcontentContainer;
		public virtual RUnityEngine.RUIElements.RVisualElement RPcontentContainer
		{
			get
			{
				if(r_PcontentContainer == null)
				{
					r_PcontentContainer = new(this, "contentContainer", -1);
					r_PcontentContainer.SetBelong(this.instance);
				}
				return r_PcontentContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset visualTreeAssetSource
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualTreeAsset r_PvisualTreeAssetSource;
		public virtual RUnityEngine.RUIElements.RVisualTreeAsset RPvisualTreeAssetSource
		{
			get
			{
				if(r_PvisualTreeAssetSource == null)
				{
					r_PvisualTreeAssetSource = new(this, "visualTreeAssetSource", -1);
					r_PvisualTreeAssetSource.SetBelong(this.instance);
				}
				return r_PvisualTreeAssetSource;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Item [Int32]
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_PItem_Int32;
		public virtual RUnityEngine.RUIElements.RVisualElement RPItem_Int32
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
		/// Int32 childCount
		/// </summary>
		protected RSystem.RInt32 r_PchildCount;
		public virtual RSystem.RInt32 RPchildCount
		{
			get
			{
				if(r_PchildCount == null)
				{
					r_PchildCount = new(this, "childCount", -1);
					r_PchildCount.SetBelong(this.instance);
				}
				return r_PchildCount;
			}
		}

		/// <summary>
		/// Boolean hasDefaultRotationAndScale
		/// </summary>
		protected RSystem.RBoolean r_PhasDefaultRotationAndScale;
		public virtual RSystem.RBoolean RPhasDefaultRotationAndScale
		{
			get
			{
				if(r_PhasDefaultRotationAndScale == null)
				{
					r_PhasDefaultRotationAndScale = new(this, "hasDefaultRotationAndScale", -1);
					r_PhasDefaultRotationAndScale.SetBelong(this.instance);
				}
				return r_PhasDefaultRotationAndScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduler schedule
		/// </summary>
		protected RUnityEngine.RUIElements.RIVisualElementScheduler r_Pschedule;
		public virtual RUnityEngine.RUIElements.RIVisualElementScheduler RPschedule
		{
			get
			{
				if(r_Pschedule == null)
				{
					r_Pschedule = new(this, "schedule", -1);
					r_Pschedule.SetBelong(this.instance);
				}
				return r_Pschedule;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStyle style
		/// </summary>
		protected RUnityEngine.RUIElements.RIStyle r_Pstyle;
		public virtual RUnityEngine.RUIElements.RIStyle RPstyle
		{
			get
			{
				if(r_Pstyle == null)
				{
					r_Pstyle = new(this, "style", -1);
					r_Pstyle.SetBelong(this.instance);
				}
				return r_Pstyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ICustomStyle customStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RICustomStyle r_PcustomStyle;
		public virtual RUnityEngine.RUIElements.RICustomStyle RPcustomStyle
		{
			get
			{
				if(r_PcustomStyle == null)
				{
					r_PcustomStyle = new(this, "customStyle", -1);
					r_PcustomStyle.SetBelong(this.instance);
				}
				return r_PcustomStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementStyleSheetSet styleSheets
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElementStyleSheetSet r_PstyleSheets;
		public virtual RUnityEngine.RUIElements.RVisualElementStyleSheetSet RPstyleSheets
		{
			get
			{
				if(r_PstyleSheets == null)
				{
					r_PstyleSheets = new(this, "styleSheets", -1);
					r_PstyleSheets.SetBelong(this.instance);
				}
				return r_PstyleSheets;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected RSystem.RString r_Ptooltip;
		public virtual RSystem.RString RPtooltip
		{
			get
			{
				if(r_Ptooltip == null)
				{
					r_Ptooltip = new(this, "tooltip", -1);
					r_Ptooltip.SetBelong(this.instance);
				}
				return r_Ptooltip;
			}
		}

		/// <summary>
		/// Boolean focusable
		/// </summary>
		protected RSystem.RBoolean r_Pfocusable;
		public virtual RSystem.RBoolean RPfocusable
		{
			get
			{
				if(r_Pfocusable == null)
				{
					r_Pfocusable = new(this, "focusable", -1);
					r_Pfocusable.SetBelong(this.instance);
				}
				return r_Pfocusable;
			}
		}

		/// <summary>
		/// Int32 tabIndex
		/// </summary>
		protected RSystem.RInt32 r_PtabIndex;
		public virtual RSystem.RInt32 RPtabIndex
		{
			get
			{
				if(r_PtabIndex == null)
				{
					r_PtabIndex = new(this, "tabIndex", -1);
					r_PtabIndex.SetBelong(this.instance);
				}
				return r_PtabIndex;
			}
		}

		/// <summary>
		/// Boolean delegatesFocus
		/// </summary>
		protected RSystem.RBoolean r_PdelegatesFocus;
		public virtual RSystem.RBoolean RPdelegatesFocus
		{
			get
			{
				if(r_PdelegatesFocus == null)
				{
					r_PdelegatesFocus = new(this, "delegatesFocus", -1);
					r_PdelegatesFocus.SetBelong(this.instance);
				}
				return r_PdelegatesFocus;
			}
		}

		/// <summary>
		/// Boolean excludeFromFocusRing
		/// </summary>
		protected RSystem.RBoolean r_PexcludeFromFocusRing;
		public virtual RSystem.RBoolean RPexcludeFromFocusRing
		{
			get
			{
				if(r_PexcludeFromFocusRing == null)
				{
					r_PexcludeFromFocusRing = new(this, "excludeFromFocusRing", -1);
					r_PexcludeFromFocusRing.SetBelong(this.instance);
				}
				return r_PexcludeFromFocusRing;
			}
		}

		/// <summary>
		/// Void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext)
		/// </summary>
		protected RMethod r_MOnGenerateVisualContent_MeshGenerationContext;
		public virtual RMethod RMOnGenerateVisualContent_MeshGenerationContext
		{
			get
			{
				if(r_MOnGenerateVisualContent_MeshGenerationContext == null)
				{
					r_MOnGenerateVisualContent_MeshGenerationContext = new(this, "OnGenerateVisualContent", 0, typeof(UnityEngine.UIElements.MeshGenerationContext));
					r_MOnGenerateVisualContent_MeshGenerationContext.SetBelong(this.instance);
				}
				return r_MOnGenerateVisualContent_MeshGenerationContext;
			}
		}

		/// <summary>
		/// Void SaveGlobals()
		/// </summary>
		protected RMethod r_MSaveGlobals;
		public virtual RMethod RMSaveGlobals
		{
			get
			{
				if(r_MSaveGlobals == null)
				{
					r_MSaveGlobals = new(this, "SaveGlobals", 0);
					r_MSaveGlobals.SetBelong(this.instance);
				}
				return r_MSaveGlobals;
			}
		}

		/// <summary>
		/// Void RestoreGlobals()
		/// </summary>
		protected RMethod r_MRestoreGlobals;
		public virtual RMethod RMRestoreGlobals
		{
			get
			{
				if(r_MRestoreGlobals == null)
				{
					r_MRestoreGlobals = new(this, "RestoreGlobals", 0);
					r_MRestoreGlobals.SetBelong(this.instance);
				}
				return r_MRestoreGlobals;
			}
		}

		/// <summary>
		/// Void DoOnGUI(UnityEngine.Event, UnityEngine.Matrix4x4, UnityEngine.Rect, Boolean, UnityEngine.Rect, System.Action, Boolean)
		/// </summary>
		protected RMethod r_MDoOnGUI_Event_Matrix4x4_Rect_Boolean_Rect_Action_Boolean;
		public virtual RMethod RMDoOnGUI_Event_Matrix4x4_Rect_Boolean_Rect_Action_Boolean
		{
			get
			{
				if(r_MDoOnGUI_Event_Matrix4x4_Rect_Boolean_Rect_Action_Boolean == null)
				{
					r_MDoOnGUI_Event_Matrix4x4_Rect_Boolean_Rect_Action_Boolean = new(this, "DoOnGUI", 0, typeof(UnityEngine.Event), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(UnityEngine.Rect), typeof(System.Action), typeof(System.Boolean));
					r_MDoOnGUI_Event_Matrix4x4_Rect_Boolean_Rect_Action_Boolean.SetBelong(this.instance);
				}
				return r_MDoOnGUI_Event_Matrix4x4_Rect_Boolean_Rect_Action_Boolean;
			}
		}

		/// <summary>
		/// Void MarkDirtyLayout()
		/// </summary>
		protected RMethod r_MMarkDirtyLayout;
		public virtual RMethod RMMarkDirtyLayout
		{
			get
			{
				if(r_MMarkDirtyLayout == null)
				{
					r_MMarkDirtyLayout = new(this, "MarkDirtyLayout", 0);
					r_MMarkDirtyLayout.SetBelong(this.instance);
				}
				return r_MMarkDirtyLayout;
			}
		}

		/// <summary>
		/// Void ProcessEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MProcessEvent_EventBase;
		public virtual RMethod RMProcessEvent_EventBase
		{
			get
			{
				if(r_MProcessEvent_EventBase == null)
				{
					r_MProcessEvent_EventBase = new(this, "ProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MProcessEvent_EventBase.SetBelong(this.instance);
				}
				return r_MProcessEvent_EventBase;
			}
		}

		/// <summary>
		/// Void DoIMGUIRepaint()
		/// </summary>
		protected RMethod r_MDoIMGUIRepaint;
		public virtual RMethod RMDoIMGUIRepaint
		{
			get
			{
				if(r_MDoIMGUIRepaint == null)
				{
					r_MDoIMGUIRepaint = new(this, "DoIMGUIRepaint", 0);
					r_MDoIMGUIRepaint.SetBelong(this.instance);
				}
				return r_MDoIMGUIRepaint;
			}
		}

		/// <summary>
		/// Boolean SendEventToIMGUI(UnityEngine.UIElements.EventBase, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MSendEventToIMGUI_EventBase_Boolean_Boolean;
		public virtual RMethod RMSendEventToIMGUI_EventBase_Boolean_Boolean
		{
			get
			{
				if(r_MSendEventToIMGUI_EventBase_Boolean_Boolean == null)
				{
					r_MSendEventToIMGUI_EventBase_Boolean_Boolean = new(this, "SendEventToIMGUI", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Boolean), typeof(System.Boolean));
					r_MSendEventToIMGUI_EventBase_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MSendEventToIMGUI_EventBase_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean SendEventToIMGUIRaw(UnityEngine.UIElements.EventBase, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MSendEventToIMGUIRaw_EventBase_Boolean_Boolean;
		public virtual RMethod RMSendEventToIMGUIRaw_EventBase_Boolean_Boolean
		{
			get
			{
				if(r_MSendEventToIMGUIRaw_EventBase_Boolean_Boolean == null)
				{
					r_MSendEventToIMGUIRaw_EventBase_Boolean_Boolean = new(this, "SendEventToIMGUIRaw", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Boolean), typeof(System.Boolean));
					r_MSendEventToIMGUIRaw_EventBase_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MSendEventToIMGUIRaw_EventBase_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean VerifyBounds(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MVerifyBounds_EventBase;
		public virtual RMethod RMVerifyBounds_EventBase
		{
			get
			{
				if(r_MVerifyBounds_EventBase == null)
				{
					r_MVerifyBounds_EventBase = new(this, "VerifyBounds", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MVerifyBounds_EventBase.SetBelong(this.instance);
				}
				return r_MVerifyBounds_EventBase;
			}
		}

		/// <summary>
		/// Boolean IsContainerCapturingTheMouse()
		/// </summary>
		protected RMethod r_MIsContainerCapturingTheMouse;
		public virtual RMethod RMIsContainerCapturingTheMouse
		{
			get
			{
				if(r_MIsContainerCapturingTheMouse == null)
				{
					r_MIsContainerCapturingTheMouse = new(this, "IsContainerCapturingTheMouse", 0);
					r_MIsContainerCapturingTheMouse.SetBelong(this.instance);
				}
				return r_MIsContainerCapturingTheMouse;
			}
		}

		/// <summary>
		/// Boolean IsLocalEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MIsLocalEvent_EventBase;
		public virtual RMethod RMIsLocalEvent_EventBase
		{
			get
			{
				if(r_MIsLocalEvent_EventBase == null)
				{
					r_MIsLocalEvent_EventBase = new(this, "IsLocalEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MIsLocalEvent_EventBase.SetBelong(this.instance);
				}
				return r_MIsLocalEvent_EventBase;
			}
		}

		/// <summary>
		/// Boolean IsEventInsideLocalWindow(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MIsEventInsideLocalWindow_EventBase;
		public virtual RMethod RMIsEventInsideLocalWindow_EventBase
		{
			get
			{
				if(r_MIsEventInsideLocalWindow_EventBase == null)
				{
					r_MIsEventInsideLocalWindow_EventBase = new(this, "IsEventInsideLocalWindow", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MIsEventInsideLocalWindow_EventBase.SetBelong(this.instance);
				}
				return r_MIsEventInsideLocalWindow_EventBase;
			}
		}

		/// <summary>
		/// Boolean IsDockAreaMouseUp(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected static RMethod r_MIsDockAreaMouseUp_EventBase;
		public static RMethod RMIsDockAreaMouseUp_EventBase
		{
			get
			{
				if(r_MIsDockAreaMouseUp_EventBase == null)
				{
					r_MIsDockAreaMouseUp_EventBase = new(typeof(UnityEngine.UIElements.IMGUIContainer), "IsDockAreaMouseUp", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MIsDockAreaMouseUp_EventBase.SetBelong(null);
				}
				return r_MIsDockAreaMouseUp_EventBase;
			}
		}

		/// <summary>
		/// Boolean HandleIMGUIEvent(UnityEngine.Event, Boolean)
		/// </summary>
		protected RMethod r_MHandleIMGUIEvent_Event_Boolean;
		public virtual RMethod RMHandleIMGUIEvent_Event_Boolean
		{
			get
			{
				if(r_MHandleIMGUIEvent_Event_Boolean == null)
				{
					r_MHandleIMGUIEvent_Event_Boolean = new(this, "HandleIMGUIEvent", 0, typeof(UnityEngine.Event), typeof(System.Boolean));
					r_MHandleIMGUIEvent_Event_Boolean.SetBelong(this.instance);
				}
				return r_MHandleIMGUIEvent_Event_Boolean;
			}
		}

		/// <summary>
		/// Boolean HandleIMGUIEvent(UnityEngine.Event, System.Action, Boolean)
		/// </summary>
		protected RMethod r_MHandleIMGUIEvent_Event_Action_Boolean;
		public virtual RMethod RMHandleIMGUIEvent_Event_Action_Boolean
		{
			get
			{
				if(r_MHandleIMGUIEvent_Event_Action_Boolean == null)
				{
					r_MHandleIMGUIEvent_Event_Action_Boolean = new(this, "HandleIMGUIEvent", 0, typeof(UnityEngine.Event), typeof(System.Action), typeof(System.Boolean));
					r_MHandleIMGUIEvent_Event_Action_Boolean.SetBelong(this.instance);
				}
				return r_MHandleIMGUIEvent_Event_Action_Boolean;
			}
		}

		/// <summary>
		/// Boolean HandleIMGUIEvent(UnityEngine.Event, UnityEngine.Matrix4x4, UnityEngine.Rect, System.Action, Boolean)
		/// </summary>
		protected RMethod r_MHandleIMGUIEvent_Event_Matrix4x4_Rect_Action_Boolean;
		public virtual RMethod RMHandleIMGUIEvent_Event_Matrix4x4_Rect_Action_Boolean
		{
			get
			{
				if(r_MHandleIMGUIEvent_Event_Matrix4x4_Rect_Action_Boolean == null)
				{
					r_MHandleIMGUIEvent_Event_Matrix4x4_Rect_Action_Boolean = new(this, "HandleIMGUIEvent", 0, typeof(UnityEngine.Event), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Rect), typeof(System.Action), typeof(System.Boolean));
					r_MHandleIMGUIEvent_Event_Matrix4x4_Rect_Action_Boolean.SetBelong(this.instance);
				}
				return r_MHandleIMGUIEvent_Event_Matrix4x4_Rect_Action_Boolean;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultAction_EventBase;
		public virtual RMethod RMExecuteDefaultAction_EventBase
		{
			get
			{
				if(r_MExecuteDefaultAction_EventBase == null)
				{
					r_MExecuteDefaultAction_EventBase = new(this, "ExecuteDefaultAction", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MExecuteDefaultAction_EventBase.SetBelong(this.instance);
				}
				return r_MExecuteDefaultAction_EventBase;
			}
		}

		/// <summary>
		/// Void SetFoldoutDepthClass()
		/// </summary>
		protected RMethod r_MSetFoldoutDepthClass;
		public virtual RMethod RMSetFoldoutDepthClass
		{
			get
			{
				if(r_MSetFoldoutDepthClass == null)
				{
					r_MSetFoldoutDepthClass = new(this, "SetFoldoutDepthClass", 0);
					r_MSetFoldoutDepthClass.SetBelong(this.instance);
				}
				return r_MSetFoldoutDepthClass;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 DoMeasure(Single, MeasureMode, Single, MeasureMode)
		/// </summary>
		protected RMethod r_MDoMeasure_Single_MeasureMode_Single_MeasureMode;
		public virtual RMethod RMDoMeasure_Single_MeasureMode_Single_MeasureMode
		{
			get
			{
				if(r_MDoMeasure_Single_MeasureMode_Single_MeasureMode == null)
				{
					r_MDoMeasure_Single_MeasureMode_Single_MeasureMode = new(this, "DoMeasure", 0, typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+MeasureMode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+MeasureMode"));
					r_MDoMeasure_Single_MeasureMode_Single_MeasureMode.SetBelong(this.instance);
				}
				return r_MDoMeasure_Single_MeasureMode_Single_MeasureMode;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetCurrentClipRect()
		/// </summary>
		protected RMethod r_MGetCurrentClipRect;
		public virtual RMethod RMGetCurrentClipRect
		{
			get
			{
				if(r_MGetCurrentClipRect == null)
				{
					r_MGetCurrentClipRect = new(this, "GetCurrentClipRect", 0);
					r_MGetCurrentClipRect.SetBelong(this.instance);
				}
				return r_MGetCurrentClipRect;
			}
		}

		/// <summary>
		/// Void GetCurrentTransformAndClip(UnityEngine.UIElements.IMGUIContainer, UnityEngine.Event, UnityEngine.Matrix4x4 ByRef, UnityEngine.Rect ByRef)
		/// </summary>
		protected static RMethod r_MGetCurrentTransformAndClip_IMGUIContainer_Event_Out_Matrix4x4_Out_Rect;
		public static RMethod RMGetCurrentTransformAndClip_IMGUIContainer_Event_Out_Matrix4x4_Out_Rect
		{
			get
			{
				if(r_MGetCurrentTransformAndClip_IMGUIContainer_Event_Out_Matrix4x4_Out_Rect == null)
				{
					r_MGetCurrentTransformAndClip_IMGUIContainer_Event_Out_Matrix4x4_Out_Rect = new(typeof(UnityEngine.UIElements.IMGUIContainer), "GetCurrentTransformAndClip", 0, typeof(UnityEngine.UIElements.IMGUIContainer), typeof(UnityEngine.Event), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType());
					r_MGetCurrentTransformAndClip_IMGUIContainer_Event_Out_Matrix4x4_Out_Rect.SetBelong(null);
				}
				return r_MGetCurrentTransformAndClip_IMGUIContainer_Event_Out_Matrix4x4_Out_Rect;
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
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_MDispose_Boolean.SetBelong(this.instance);
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// Void <DoOnGUI>b__56_0()
		/// </summary>
		protected RMethod r_M__0__DoOnGUI__1__b__56_0;
		public virtual RMethod RM__0__DoOnGUI__1__b__56_0
		{
			get
			{
				if(r_M__0__DoOnGUI__1__b__56_0 == null)
				{
					r_M__0__DoOnGUI__1__b__56_0 = new(this, "<DoOnGUI>b__56_0", 0);
					r_M__0__DoOnGUI__1__b__56_0.SetBelong(this.instance);
				}
				return r_M__0__DoOnGUI__1__b__56_0;
			}
		}

		/// <summary>
		/// Boolean TryConvertLengthUnits(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Length ByRef, UnityEngine.UIElements.Length ByRef, Int32)
		/// </summary>
		protected RMethod r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32;
		public virtual RMethod RMTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32
		{
			get
			{
				if(r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32 == null)
				{
					r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32 = new(this, "TryConvertLengthUnits", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Length).MakeByRefType(), typeof(UnityEngine.UIElements.Length).MakeByRefType(), typeof(System.Int32));
					r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32.SetBelong(this.instance);
				}
				return r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32;
			}
		}

		/// <summary>
		/// Boolean TryConvertTransformOriginUnits(UnityEngine.UIElements.TransformOrigin ByRef, UnityEngine.UIElements.TransformOrigin ByRef)
		/// </summary>
		protected RMethod r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin;
		public virtual RMethod RMTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin
		{
			get
			{
				if(r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin == null)
				{
					r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin = new(this, "TryConvertTransformOriginUnits", 0, typeof(UnityEngine.UIElements.TransformOrigin).MakeByRefType(), typeof(UnityEngine.UIElements.TransformOrigin).MakeByRefType());
					r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin.SetBelong(this.instance);
				}
				return r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin;
			}
		}

		/// <summary>
		/// Boolean TryConvertTranslateUnits(UnityEngine.UIElements.Translate ByRef, UnityEngine.UIElements.Translate ByRef)
		/// </summary>
		protected RMethod r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate;
		public virtual RMethod RMTryConvertTranslateUnits_Ref_Translate_Ref_Translate
		{
			get
			{
				if(r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate == null)
				{
					r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate = new(this, "TryConvertTranslateUnits", 0, typeof(UnityEngine.UIElements.Translate).MakeByRefType(), typeof(UnityEngine.UIElements.Translate).MakeByRefType());
					r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate.SetBelong(this.instance);
				}
				return r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate;
			}
		}

		/// <summary>
		/// Boolean TryConvertBackgroundPositionUnits(UnityEngine.UIElements.BackgroundPosition ByRef, UnityEngine.UIElements.BackgroundPosition ByRef)
		/// </summary>
		protected RMethod r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition;
		public virtual RMethod RMTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition
		{
			get
			{
				if(r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition == null)
				{
					r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition = new(this, "TryConvertBackgroundPositionUnits", 0, typeof(UnityEngine.UIElements.BackgroundPosition).MakeByRefType(), typeof(UnityEngine.UIElements.BackgroundPosition).MakeByRefType());
					r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition.SetBelong(this.instance);
				}
				return r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition;
			}
		}

		/// <summary>
		/// Boolean TryConvertBackgroundSizeUnits(UnityEngine.UIElements.BackgroundSize ByRef, UnityEngine.UIElements.BackgroundSize ByRef)
		/// </summary>
		protected RMethod r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize;
		public virtual RMethod RMTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize
		{
			get
			{
				if(r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize == null)
				{
					r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize = new(this, "TryConvertBackgroundSizeUnits", 0, typeof(UnityEngine.UIElements.BackgroundSize).MakeByRefType(), typeof(UnityEngine.UIElements.BackgroundSize).MakeByRefType());
					r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize.SetBelong(this.instance);
				}
				return r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize;
			}
		}

		/// <summary>
		/// Void MarkRenderHintsClean()
		/// </summary>
		protected RMethod r_MMarkRenderHintsClean;
		public virtual RMethod RMMarkRenderHintsClean
		{
			get
			{
				if(r_MMarkRenderHintsClean == null)
				{
					r_MMarkRenderHintsClean = new(this, "MarkRenderHintsClean", 0);
					r_MMarkRenderHintsClean.SetBelong(this.instance);
				}
				return r_MMarkRenderHintsClean;
			}
		}

		/// <summary>
		/// Void UpdateBoundingBox()
		/// </summary>
		protected RMethod r_MUpdateBoundingBox;
		public virtual RMethod RMUpdateBoundingBox
		{
			get
			{
				if(r_MUpdateBoundingBox == null)
				{
					r_MUpdateBoundingBox = new(this, "UpdateBoundingBox", 0);
					r_MUpdateBoundingBox.SetBelong(this.instance);
				}
				return r_MUpdateBoundingBox;
			}
		}

		/// <summary>
		/// Void UpdateWorldBoundingBox()
		/// </summary>
		protected RMethod r_MUpdateWorldBoundingBox;
		public virtual RMethod RMUpdateWorldBoundingBox
		{
			get
			{
				if(r_MUpdateWorldBoundingBox == null)
				{
					r_MUpdateWorldBoundingBox = new(this, "UpdateWorldBoundingBox", 0);
					r_MUpdateWorldBoundingBox.SetBelong(this.instance);
				}
				return r_MUpdateWorldBoundingBox;
			}
		}

		/// <summary>
		/// Void UpdateWorldTransform()
		/// </summary>
		protected RMethod r_MUpdateWorldTransform;
		public virtual RMethod RMUpdateWorldTransform
		{
			get
			{
				if(r_MUpdateWorldTransform == null)
				{
					r_MUpdateWorldTransform = new(this, "UpdateWorldTransform", 0);
					r_MUpdateWorldTransform.SetBelong(this.instance);
				}
				return r_MUpdateWorldTransform;
			}
		}

		/// <summary>
		/// Void UpdateWorldTransformInverse()
		/// </summary>
		protected RMethod r_MUpdateWorldTransformInverse;
		public virtual RMethod RMUpdateWorldTransformInverse
		{
			get
			{
				if(r_MUpdateWorldTransformInverse == null)
				{
					r_MUpdateWorldTransformInverse = new(this, "UpdateWorldTransformInverse", 0);
					r_MUpdateWorldTransformInverse.SetBelong(this.instance);
				}
				return r_MUpdateWorldTransformInverse;
			}
		}

		/// <summary>
		/// Void EnsureWorldTransformAndClipUpToDate()
		/// </summary>
		protected RMethod r_MEnsureWorldTransformAndClipUpToDate;
		public virtual RMethod RMEnsureWorldTransformAndClipUpToDate
		{
			get
			{
				if(r_MEnsureWorldTransformAndClipUpToDate == null)
				{
					r_MEnsureWorldTransformAndClipUpToDate = new(this, "EnsureWorldTransformAndClipUpToDate", 0);
					r_MEnsureWorldTransformAndClipUpToDate.SetBelong(this.instance);
				}
				return r_MEnsureWorldTransformAndClipUpToDate;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetTooltipRect()
		/// </summary>
		protected RMethod r_MGetTooltipRect;
		public virtual RMethod RMGetTooltipRect
		{
			get
			{
				if(r_MGetTooltipRect == null)
				{
					r_MGetTooltipRect = new(this, "GetTooltipRect", 0);
					r_MGetTooltipRect.SetBelong(this.instance);
				}
				return r_MGetTooltipRect;
			}
		}

		/// <summary>
		/// Void Focus()
		/// </summary>
		protected RMethod r_MFocus;
		public virtual RMethod RMFocus
		{
			get
			{
				if(r_MFocus == null)
				{
					r_MFocus = new(this, "Focus", 0);
					r_MFocus.SetBelong(this.instance);
				}
				return r_MFocus;
			}
		}

		/// <summary>
		/// Void SetPanel(UnityEngine.UIElements.BaseVisualElementPanel)
		/// </summary>
		protected RMethod r_MSetPanel_BaseVisualElementPanel;
		public virtual RMethod RMSetPanel_BaseVisualElementPanel
		{
			get
			{
				if(r_MSetPanel_BaseVisualElementPanel == null)
				{
					r_MSetPanel_BaseVisualElementPanel = new(this, "SetPanel", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.BaseVisualElementPanel"));
					r_MSetPanel_BaseVisualElementPanel.SetBelong(this.instance);
				}
				return r_MSetPanel_BaseVisualElementPanel;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MSendEvent_EventBase;
		public virtual RMethod RMSendEvent_EventBase
		{
			get
			{
				if(r_MSendEvent_EventBase == null)
				{
					r_MSendEvent_EventBase = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MSendEvent_EventBase.SetBelong(this.instance);
				}
				return r_MSendEvent_EventBase;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_MSendEvent_EventBase_DispatchMode;
		public virtual RMethod RMSendEvent_EventBase_DispatchMode
		{
			get
			{
				if(r_MSendEvent_EventBase_DispatchMode == null)
				{
					r_MSendEvent_EventBase_DispatchMode = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_MSendEvent_EventBase_DispatchMode.SetBelong(this.instance);
				}
				return r_MSendEvent_EventBase_DispatchMode;
			}
		}

		/// <summary>
		/// Void IncrementVersion(UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_MIncrementVersion_VersionChangeType;
		public virtual RMethod RMIncrementVersion_VersionChangeType
		{
			get
			{
				if(r_MIncrementVersion_VersionChangeType == null)
				{
					r_MIncrementVersion_VersionChangeType = new(this, "IncrementVersion", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_MIncrementVersion_VersionChangeType.SetBelong(this.instance);
				}
				return r_MIncrementVersion_VersionChangeType;
			}
		}

		/// <summary>
		/// Void InvokeHierarchyChanged(UnityEngine.UIElements.HierarchyChangeType)
		/// </summary>
		protected RMethod r_MInvokeHierarchyChanged_HierarchyChangeType;
		public virtual RMethod RMInvokeHierarchyChanged_HierarchyChangeType
		{
			get
			{
				if(r_MInvokeHierarchyChanged_HierarchyChangeType == null)
				{
					r_MInvokeHierarchyChanged_HierarchyChangeType = new(this, "InvokeHierarchyChanged", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.HierarchyChangeType"));
					r_MInvokeHierarchyChanged_HierarchyChangeType.SetBelong(this.instance);
				}
				return r_MInvokeHierarchyChanged_HierarchyChangeType;
			}
		}

		/// <summary>
		/// Boolean SetEnabledFromHierarchy(Boolean)
		/// </summary>
		protected RMethod r_MSetEnabledFromHierarchy_Boolean;
		public virtual RMethod RMSetEnabledFromHierarchy_Boolean
		{
			get
			{
				if(r_MSetEnabledFromHierarchy_Boolean == null)
				{
					r_MSetEnabledFromHierarchy_Boolean = new(this, "SetEnabledFromHierarchy", 0, typeof(System.Boolean));
					r_MSetEnabledFromHierarchy_Boolean.SetBelong(this.instance);
				}
				return r_MSetEnabledFromHierarchy_Boolean;
			}
		}

		/// <summary>
		/// Void SetEnabled(Boolean)
		/// </summary>
		protected RMethod r_MSetEnabled_Boolean;
		public virtual RMethod RMSetEnabled_Boolean
		{
			get
			{
				if(r_MSetEnabled_Boolean == null)
				{
					r_MSetEnabled_Boolean = new(this, "SetEnabled", 0, typeof(System.Boolean));
					r_MSetEnabled_Boolean.SetBelong(this.instance);
				}
				return r_MSetEnabled_Boolean;
			}
		}

		/// <summary>
		/// Void MarkDirtyRepaint()
		/// </summary>
		protected RMethod r_MMarkDirtyRepaint;
		public virtual RMethod RMMarkDirtyRepaint
		{
			get
			{
				if(r_MMarkDirtyRepaint == null)
				{
					r_MMarkDirtyRepaint = new(this, "MarkDirtyRepaint", 0);
					r_MMarkDirtyRepaint.SetBelong(this.instance);
				}
				return r_MMarkDirtyRepaint;
			}
		}

		/// <summary>
		/// Void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext)
		/// </summary>
		protected RMethod r_MInvokeGenerateVisualContent_MeshGenerationContext;
		public virtual RMethod RMInvokeGenerateVisualContent_MeshGenerationContext
		{
			get
			{
				if(r_MInvokeGenerateVisualContent_MeshGenerationContext == null)
				{
					r_MInvokeGenerateVisualContent_MeshGenerationContext = new(this, "InvokeGenerateVisualContent", 0, typeof(UnityEngine.UIElements.MeshGenerationContext));
					r_MInvokeGenerateVisualContent_MeshGenerationContext.SetBelong(this.instance);
				}
				return r_MInvokeGenerateVisualContent_MeshGenerationContext;
			}
		}

		/// <summary>
		/// Void GetFullHierarchicalViewDataKey(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_MGetFullHierarchicalViewDataKey_StringBuilder;
		public virtual RMethod RMGetFullHierarchicalViewDataKey_StringBuilder
		{
			get
			{
				if(r_MGetFullHierarchicalViewDataKey_StringBuilder == null)
				{
					r_MGetFullHierarchicalViewDataKey_StringBuilder = new(this, "GetFullHierarchicalViewDataKey", 0, typeof(System.Text.StringBuilder));
					r_MGetFullHierarchicalViewDataKey_StringBuilder.SetBelong(this.instance);
				}
				return r_MGetFullHierarchicalViewDataKey_StringBuilder;
			}
		}

		/// <summary>
		/// System.String GetFullHierarchicalViewDataKey()
		/// </summary>
		protected RMethod r_MGetFullHierarchicalViewDataKey;
		public virtual RMethod RMGetFullHierarchicalViewDataKey
		{
			get
			{
				if(r_MGetFullHierarchicalViewDataKey == null)
				{
					r_MGetFullHierarchicalViewDataKey = new(this, "GetFullHierarchicalViewDataKey", 0);
					r_MGetFullHierarchicalViewDataKey.SetBelong(this.instance);
				}
				return r_MGetFullHierarchicalViewDataKey;
			}
		}

		/// <summary>
		/// T GetOrCreateViewData[T](System.Object, System.String)
		/// </summary>
		protected RMethod r_MGetOrCreateViewData_GT_Object_String;
		public virtual RMethod RMGetOrCreateViewData_GT_Object_String
		{
			get
			{
				if(r_MGetOrCreateViewData_GT_Object_String == null)
				{
					r_MGetOrCreateViewData_GT_Object_String = new(this, "GetOrCreateViewData", 1, typeof(System.Object), typeof(System.String));
					r_MGetOrCreateViewData_GT_Object_String.SetBelong(this.instance);
				}
				return r_MGetOrCreateViewData_GT_Object_String;
			}
		}

		/// <summary>
		/// T GetOrCreateViewData[T](UnityEngine.ScriptableObject, System.String)
		/// </summary>
		protected RMethod r_MGetOrCreateViewData_GT_ScriptableObject_String;
		public virtual RMethod RMGetOrCreateViewData_GT_ScriptableObject_String
		{
			get
			{
				if(r_MGetOrCreateViewData_GT_ScriptableObject_String == null)
				{
					r_MGetOrCreateViewData_GT_ScriptableObject_String = new(this, "GetOrCreateViewData", 1, typeof(UnityEngine.ScriptableObject), typeof(System.String));
					r_MGetOrCreateViewData_GT_ScriptableObject_String.SetBelong(this.instance);
				}
				return r_MGetOrCreateViewData_GT_ScriptableObject_String;
			}
		}

		/// <summary>
		/// Void OverwriteFromViewData(System.Object, System.String)
		/// </summary>
		protected RMethod r_MOverwriteFromViewData_Object_String;
		public virtual RMethod RMOverwriteFromViewData_Object_String
		{
			get
			{
				if(r_MOverwriteFromViewData_Object_String == null)
				{
					r_MOverwriteFromViewData_Object_String = new(this, "OverwriteFromViewData", 0, typeof(System.Object), typeof(System.String));
					r_MOverwriteFromViewData_Object_String.SetBelong(this.instance);
				}
				return r_MOverwriteFromViewData_Object_String;
			}
		}

		/// <summary>
		/// Void SaveViewData()
		/// </summary>
		protected RMethod r_MSaveViewData;
		public virtual RMethod RMSaveViewData
		{
			get
			{
				if(r_MSaveViewData == null)
				{
					r_MSaveViewData = new(this, "SaveViewData", 0);
					r_MSaveViewData.SetBelong(this.instance);
				}
				return r_MSaveViewData;
			}
		}

		/// <summary>
		/// Boolean IsViewDataPersitenceSupportedOnChildren(Boolean)
		/// </summary>
		protected RMethod r_MIsViewDataPersitenceSupportedOnChildren_Boolean;
		public virtual RMethod RMIsViewDataPersitenceSupportedOnChildren_Boolean
		{
			get
			{
				if(r_MIsViewDataPersitenceSupportedOnChildren_Boolean == null)
				{
					r_MIsViewDataPersitenceSupportedOnChildren_Boolean = new(this, "IsViewDataPersitenceSupportedOnChildren", 0, typeof(System.Boolean));
					r_MIsViewDataPersitenceSupportedOnChildren_Boolean.SetBelong(this.instance);
				}
				return r_MIsViewDataPersitenceSupportedOnChildren_Boolean;
			}
		}

		/// <summary>
		/// Void OnViewDataReady(Boolean)
		/// </summary>
		protected RMethod r_MOnViewDataReady_Boolean;
		public virtual RMethod RMOnViewDataReady_Boolean
		{
			get
			{
				if(r_MOnViewDataReady_Boolean == null)
				{
					r_MOnViewDataReady_Boolean = new(this, "OnViewDataReady", 0, typeof(System.Boolean));
					r_MOnViewDataReady_Boolean.SetBelong(this.instance);
				}
				return r_MOnViewDataReady_Boolean;
			}
		}

		/// <summary>
		/// Void OnViewDataReady()
		/// </summary>
		protected RMethod r_MOnViewDataReady;
		public virtual RMethod RMOnViewDataReady
		{
			get
			{
				if(r_MOnViewDataReady == null)
				{
					r_MOnViewDataReady = new(this, "OnViewDataReady", 0);
					r_MOnViewDataReady.SetBelong(this.instance);
				}
				return r_MOnViewDataReady;
			}
		}

		/// <summary>
		/// Boolean ContainsPoint(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MContainsPoint_Vector2;
		public virtual RMethod RMContainsPoint_Vector2
		{
			get
			{
				if(r_MContainsPoint_Vector2 == null)
				{
					r_MContainsPoint_Vector2 = new(this, "ContainsPoint", 0, typeof(UnityEngine.Vector2));
					r_MContainsPoint_Vector2.SetBelong(this.instance);
				}
				return r_MContainsPoint_Vector2;
			}
		}

		/// <summary>
		/// Boolean Overlaps(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MOverlaps_Rect;
		public virtual RMethod RMOverlaps_Rect
		{
			get
			{
				if(r_MOverlaps_Rect == null)
				{
					r_MOverlaps_Rect = new(this, "Overlaps", 0, typeof(UnityEngine.Rect));
					r_MOverlaps_Rect.SetBelong(this.instance);
				}
				return r_MOverlaps_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaSize Measure(UnityEngine.Yoga.YogaNode, Single, UnityEngine.Yoga.YogaMeasureMode, Single, UnityEngine.Yoga.YogaMeasureMode)
		/// </summary>
		protected RMethod r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
		public virtual RMethod RMMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode
		{
			get
			{
				if(r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode == null)
				{
					r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode = new(this, "Measure", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"));
					r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.SetBelong(this.instance);
				}
				return r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
			}
		}

		/// <summary>
		/// Void SetSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetSize_Vector2;
		public virtual RMethod RMSetSize_Vector2
		{
			get
			{
				if(r_MSetSize_Vector2 == null)
				{
					r_MSetSize_Vector2 = new(this, "SetSize", 0, typeof(UnityEngine.Vector2));
					r_MSetSize_Vector2.SetBelong(this.instance);
				}
				return r_MSetSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetInlineRule(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleRule)
		/// </summary>
		protected RMethod r_MSetInlineRule_StyleSheet_StyleRule;
		public virtual RMethod RMSetInlineRule_StyleSheet_StyleRule
		{
			get
			{
				if(r_MSetInlineRule_StyleSheet_StyleRule == null)
				{
					r_MSetInlineRule_StyleSheet_StyleRule = new(this, "SetInlineRule", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleRule"));
					r_MSetInlineRule_StyleSheet_StyleRule.SetBelong(this.instance);
				}
				return r_MSetInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Void UpdateInlineRule(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleRule)
		/// </summary>
		protected RMethod r_MUpdateInlineRule_StyleSheet_StyleRule;
		public virtual RMethod RMUpdateInlineRule_StyleSheet_StyleRule
		{
			get
			{
				if(r_MUpdateInlineRule_StyleSheet_StyleRule == null)
				{
					r_MUpdateInlineRule_StyleSheet_StyleRule = new(this, "UpdateInlineRule", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleRule"));
					r_MUpdateInlineRule_StyleSheet_StyleRule.SetBelong(this.instance);
				}
				return r_MUpdateInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Void SetComputedStyle(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MSetComputedStyle_Ref_ComputedStyle;
		public virtual RMethod RMSetComputedStyle_Ref_ComputedStyle
		{
			get
			{
				if(r_MSetComputedStyle_Ref_ComputedStyle == null)
				{
					r_MSetComputedStyle_Ref_ComputedStyle = new(this, "SetComputedStyle", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MSetComputedStyle_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_MSetComputedStyle_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ResetPositionProperties()
		/// </summary>
		protected RMethod r_MResetPositionProperties;
		public virtual RMethod RMResetPositionProperties
		{
			get
			{
				if(r_MResetPositionProperties == null)
				{
					r_MResetPositionProperties = new(this, "ResetPositionProperties", 0);
					r_MResetPositionProperties.SetBelong(this.instance);
				}
				return r_MResetPositionProperties;
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
		/// System.Collections.Generic.IEnumerable`1[System.String] GetClasses()
		/// </summary>
		protected RMethod r_MGetClasses;
		public virtual RMethod RMGetClasses
		{
			get
			{
				if(r_MGetClasses == null)
				{
					r_MGetClasses = new(this, "GetClasses", 0);
					r_MGetClasses.SetBelong(this.instance);
				}
				return r_MGetClasses;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetClassesForIteration()
		/// </summary>
		protected RMethod r_MGetClassesForIteration;
		public virtual RMethod RMGetClassesForIteration
		{
			get
			{
				if(r_MGetClassesForIteration == null)
				{
					r_MGetClassesForIteration = new(this, "GetClassesForIteration", 0);
					r_MGetClassesForIteration.SetBelong(this.instance);
				}
				return r_MGetClassesForIteration;
			}
		}

		/// <summary>
		/// Void ClearClassList()
		/// </summary>
		protected RMethod r_MClearClassList;
		public virtual RMethod RMClearClassList
		{
			get
			{
				if(r_MClearClassList == null)
				{
					r_MClearClassList = new(this, "ClearClassList", 0);
					r_MClearClassList.SetBelong(this.instance);
				}
				return r_MClearClassList;
			}
		}

		/// <summary>
		/// Void AddToClassList(System.String)
		/// </summary>
		protected RMethod r_MAddToClassList_String;
		public virtual RMethod RMAddToClassList_String
		{
			get
			{
				if(r_MAddToClassList_String == null)
				{
					r_MAddToClassList_String = new(this, "AddToClassList", 0, typeof(System.String));
					r_MAddToClassList_String.SetBelong(this.instance);
				}
				return r_MAddToClassList_String;
			}
		}

		/// <summary>
		/// Void RemoveFromClassList(System.String)
		/// </summary>
		protected RMethod r_MRemoveFromClassList_String;
		public virtual RMethod RMRemoveFromClassList_String
		{
			get
			{
				if(r_MRemoveFromClassList_String == null)
				{
					r_MRemoveFromClassList_String = new(this, "RemoveFromClassList", 0, typeof(System.String));
					r_MRemoveFromClassList_String.SetBelong(this.instance);
				}
				return r_MRemoveFromClassList_String;
			}
		}

		/// <summary>
		/// Void ToggleInClassList(System.String)
		/// </summary>
		protected RMethod r_MToggleInClassList_String;
		public virtual RMethod RMToggleInClassList_String
		{
			get
			{
				if(r_MToggleInClassList_String == null)
				{
					r_MToggleInClassList_String = new(this, "ToggleInClassList", 0, typeof(System.String));
					r_MToggleInClassList_String.SetBelong(this.instance);
				}
				return r_MToggleInClassList_String;
			}
		}

		/// <summary>
		/// Void EnableInClassList(System.String, Boolean)
		/// </summary>
		protected RMethod r_MEnableInClassList_String_Boolean;
		public virtual RMethod RMEnableInClassList_String_Boolean
		{
			get
			{
				if(r_MEnableInClassList_String_Boolean == null)
				{
					r_MEnableInClassList_String_Boolean = new(this, "EnableInClassList", 0, typeof(System.String), typeof(System.Boolean));
					r_MEnableInClassList_String_Boolean.SetBelong(this.instance);
				}
				return r_MEnableInClassList_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean ClassListContains(System.String)
		/// </summary>
		protected RMethod r_MClassListContains_String;
		public virtual RMethod RMClassListContains_String
		{
			get
			{
				if(r_MClassListContains_String == null)
				{
					r_MClassListContains_String = new(this, "ClassListContains", 0, typeof(System.String));
					r_MClassListContains_String.SetBelong(this.instance);
				}
				return r_MClassListContains_String;
			}
		}

		/// <summary>
		/// System.Object FindAncestorUserData()
		/// </summary>
		protected RMethod r_MFindAncestorUserData;
		public virtual RMethod RMFindAncestorUserData
		{
			get
			{
				if(r_MFindAncestorUserData == null)
				{
					r_MFindAncestorUserData = new(this, "FindAncestorUserData", 0);
					r_MFindAncestorUserData.SetBelong(this.instance);
				}
				return r_MFindAncestorUserData;
			}
		}

		/// <summary>
		/// System.Object GetProperty(UnityEngine.PropertyName)
		/// </summary>
		protected RMethod r_MGetProperty_PropertyName;
		public virtual RMethod RMGetProperty_PropertyName
		{
			get
			{
				if(r_MGetProperty_PropertyName == null)
				{
					r_MGetProperty_PropertyName = new(this, "GetProperty", 0, typeof(UnityEngine.PropertyName));
					r_MGetProperty_PropertyName.SetBelong(this.instance);
				}
				return r_MGetProperty_PropertyName;
			}
		}

		/// <summary>
		/// Void SetProperty(UnityEngine.PropertyName, System.Object)
		/// </summary>
		protected RMethod r_MSetProperty_PropertyName_Object;
		public virtual RMethod RMSetProperty_PropertyName_Object
		{
			get
			{
				if(r_MSetProperty_PropertyName_Object == null)
				{
					r_MSetProperty_PropertyName_Object = new(this, "SetProperty", 0, typeof(UnityEngine.PropertyName), typeof(System.Object));
					r_MSetProperty_PropertyName_Object.SetBelong(this.instance);
				}
				return r_MSetProperty_PropertyName_Object;
			}
		}

		/// <summary>
		/// Boolean HasProperty(UnityEngine.PropertyName)
		/// </summary>
		protected RMethod r_MHasProperty_PropertyName;
		public virtual RMethod RMHasProperty_PropertyName
		{
			get
			{
				if(r_MHasProperty_PropertyName == null)
				{
					r_MHasProperty_PropertyName = new(this, "HasProperty", 0, typeof(UnityEngine.PropertyName));
					r_MHasProperty_PropertyName.SetBelong(this.instance);
				}
				return r_MHasProperty_PropertyName;
			}
		}

		/// <summary>
		/// Void ApplyPlayerRenderingToEditorElement()
		/// </summary>
		protected RMethod r_MApplyPlayerRenderingToEditorElement;
		public virtual RMethod RMApplyPlayerRenderingToEditorElement
		{
			get
			{
				if(r_MApplyPlayerRenderingToEditorElement == null)
				{
					r_MApplyPlayerRenderingToEditorElement = new(this, "ApplyPlayerRenderingToEditorElement", 0);
					r_MApplyPlayerRenderingToEditorElement.SetBelong(this.instance);
				}
				return r_MApplyPlayerRenderingToEditorElement;
			}
		}

		/// <summary>
		/// Void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate)
		/// </summary>
		protected RMethod r_MRegisterAnimation_IValueAnimationUpdate;
		public virtual RMethod RMRegisterAnimation_IValueAnimationUpdate
		{
			get
			{
				if(r_MRegisterAnimation_IValueAnimationUpdate == null)
				{
					r_MRegisterAnimation_IValueAnimationUpdate = new(this, "RegisterAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate"));
					r_MRegisterAnimation_IValueAnimationUpdate.SetBelong(this.instance);
				}
				return r_MRegisterAnimation_IValueAnimationUpdate;
			}
		}

		/// <summary>
		/// Void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate)
		/// </summary>
		protected RMethod r_MUnregisterAnimation_IValueAnimationUpdate;
		public virtual RMethod RMUnregisterAnimation_IValueAnimationUpdate
		{
			get
			{
				if(r_MUnregisterAnimation_IValueAnimationUpdate == null)
				{
					r_MUnregisterAnimation_IValueAnimationUpdate = new(this, "UnregisterAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate"));
					r_MUnregisterAnimation_IValueAnimationUpdate.SetBelong(this.instance);
				}
				return r_MUnregisterAnimation_IValueAnimationUpdate;
			}
		}

		/// <summary>
		/// Boolean GetCachedNextParentWithEventCallback(UnityEngine.UIElements.VisualElement ByRef)
		/// </summary>
		protected RMethod r_MGetCachedNextParentWithEventCallback_Out_VisualElement;
		public virtual RMethod RMGetCachedNextParentWithEventCallback_Out_VisualElement
		{
			get
			{
				if(r_MGetCachedNextParentWithEventCallback_Out_VisualElement == null)
				{
					r_MGetCachedNextParentWithEventCallback_Out_VisualElement = new(this, "GetCachedNextParentWithEventCallback", 0, typeof(UnityEngine.UIElements.VisualElement).MakeByRefType());
					r_MGetCachedNextParentWithEventCallback_Out_VisualElement.SetBelong(this.instance);
				}
				return r_MGetCachedNextParentWithEventCallback_Out_VisualElement;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacks(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasEventCallbacks_EventCategory;
		public virtual RMethod RMHasEventCallbacks_EventCategory
		{
			get
			{
				if(r_MHasEventCallbacks_EventCategory == null)
				{
					r_MHasEventCallbacks_EventCategory = new(this, "HasEventCallbacks", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasEventCallbacks_EventCategory.SetBelong(this.instance);
				}
				return r_MHasEventCallbacks_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacks(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasParentEventCallbacks_EventCategory;
		public virtual RMethod RMHasParentEventCallbacks_EventCategory
		{
			get
			{
				if(r_MHasParentEventCallbacks_EventCategory == null)
				{
					r_MHasParentEventCallbacks_EventCategory = new(this, "HasParentEventCallbacks", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasParentEventCallbacks_EventCategory.SetBelong(this.instance);
				}
				return r_MHasParentEventCallbacks_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacksOrDefaultActions(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasParentEventCallbacksOrDefaultActions_EventCategory;
		public virtual RMethod RMHasParentEventCallbacksOrDefaultActions_EventCategory
		{
			get
			{
				if(r_MHasParentEventCallbacksOrDefaultActions_EventCategory == null)
				{
					r_MHasParentEventCallbacksOrDefaultActions_EventCategory = new(this, "HasParentEventCallbacksOrDefaultActions", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasParentEventCallbacksOrDefaultActions_EventCategory.SetBelong(this.instance);
				}
				return r_MHasParentEventCallbacksOrDefaultActions_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacksOrDefaultActions(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasEventCallbacksOrDefaultActions_EventCategory;
		public virtual RMethod RMHasEventCallbacksOrDefaultActions_EventCategory
		{
			get
			{
				if(r_MHasEventCallbacksOrDefaultActions_EventCategory == null)
				{
					r_MHasEventCallbacksOrDefaultActions_EventCategory = new(this, "HasEventCallbacksOrDefaultActions", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasEventCallbacksOrDefaultActions_EventCategory.SetBelong(this.instance);
				}
				return r_MHasEventCallbacksOrDefaultActions_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacksOrDefaultActionAtTarget(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory;
		public virtual RMethod RMHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory
		{
			get
			{
				if(r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory == null)
				{
					r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory = new(this, "HasParentEventCallbacksOrDefaultActionAtTarget", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory.SetBelong(this.instance);
				}
				return r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacksOrDefaultActionAtTarget(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory;
		public virtual RMethod RMHasEventCallbacksOrDefaultActionAtTarget_EventCategory
		{
			get
			{
				if(r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory == null)
				{
					r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory = new(this, "HasEventCallbacksOrDefaultActionAtTarget", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory.SetBelong(this.instance);
				}
				return r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasDefaultAction(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasDefaultAction_EventCategory;
		public virtual RMethod RMHasDefaultAction_EventCategory
		{
			get
			{
				if(r_MHasDefaultAction_EventCategory == null)
				{
					r_MHasDefaultAction_EventCategory = new(this, "HasDefaultAction", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasDefaultAction_EventCategory.SetBelong(this.instance);
				}
				return r_MHasDefaultAction_EventCategory;
			}
		}

		/// <summary>
		/// Boolean ShouldClip()
		/// </summary>
		protected RMethod r_MShouldClip;
		public virtual RMethod RMShouldClip
		{
			get
			{
				if(r_MShouldClip == null)
				{
					r_MShouldClip = new(this, "ShouldClip", 0);
					r_MShouldClip.SetBelong(this.instance);
				}
				return r_MShouldClip;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MAdd_VisualElement;
		public virtual RMethod RMAdd_VisualElement
		{
			get
			{
				if(r_MAdd_VisualElement == null)
				{
					r_MAdd_VisualElement = new(this, "Add", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MAdd_VisualElement.SetBelong(this.instance);
				}
				return r_MAdd_VisualElement;
			}
		}

		/// <summary>
		/// Void Insert(Int32, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MInsert_Int32_VisualElement;
		public virtual RMethod RMInsert_Int32_VisualElement
		{
			get
			{
				if(r_MInsert_Int32_VisualElement == null)
				{
					r_MInsert_Int32_VisualElement = new(this, "Insert", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.VisualElement));
					r_MInsert_Int32_VisualElement.SetBelong(this.instance);
				}
				return r_MInsert_Int32_VisualElement;
			}
		}

		/// <summary>
		/// Void Remove(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MRemove_VisualElement;
		public virtual RMethod RMRemove_VisualElement
		{
			get
			{
				if(r_MRemove_VisualElement == null)
				{
					r_MRemove_VisualElement = new(this, "Remove", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MRemove_VisualElement.SetBelong(this.instance);
				}
				return r_MRemove_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveAt(Int32)
		/// </summary>
		protected RMethod r_MRemoveAt_Int32;
		public virtual RMethod RMRemoveAt_Int32
		{
			get
			{
				if(r_MRemoveAt_Int32 == null)
				{
					r_MRemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
					r_MRemoveAt_Int32.SetBelong(this.instance);
				}
				return r_MRemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
					r_MClear.SetBelong(this.instance);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ElementAt(Int32)
		/// </summary>
		protected RMethod r_MElementAt_Int32;
		public virtual RMethod RMElementAt_Int32
		{
			get
			{
				if(r_MElementAt_Int32 == null)
				{
					r_MElementAt_Int32 = new(this, "ElementAt", 0, typeof(System.Int32));
					r_MElementAt_Int32.SetBelong(this.instance);
				}
				return r_MElementAt_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MIndexOf_VisualElement;
		public virtual RMethod RMIndexOf_VisualElement
		{
			get
			{
				if(r_MIndexOf_VisualElement == null)
				{
					r_MIndexOf_VisualElement = new(this, "IndexOf", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MIndexOf_VisualElement.SetBelong(this.instance);
				}
				return r_MIndexOf_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_MElementAtTreePath_List_d_Int32_p_;
		public virtual RMethod RMElementAtTreePath_List_d_Int32_p_
		{
			get
			{
				if(r_MElementAtTreePath_List_d_Int32_p_ == null)
				{
					r_MElementAtTreePath_List_d_Int32_p_ = new(this, "ElementAtTreePath", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_MElementAtTreePath_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MElementAtTreePath_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// Boolean FindElementInTree(UnityEngine.UIElements.VisualElement, System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_MFindElementInTree_VisualElement_List_d_Int32_p_;
		public virtual RMethod RMFindElementInTree_VisualElement_List_d_Int32_p_
		{
			get
			{
				if(r_MFindElementInTree_VisualElement_List_d_Int32_p_ == null)
				{
					r_MFindElementInTree_VisualElement_List_d_Int32_p_ = new(this, "FindElementInTree", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_MFindElementInTree_VisualElement_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MFindElementInTree_VisualElement_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.VisualElement] Children()
		/// </summary>
		protected RMethod r_MChildren;
		public virtual RMethod RMChildren
		{
			get
			{
				if(r_MChildren == null)
				{
					r_MChildren = new(this, "Children", 0);
					r_MChildren.SetBelong(this.instance);
				}
				return r_MChildren;
			}
		}

		/// <summary>
		/// Void Sort(System.Comparison`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_MSort_Comparison_d_VisualElement_p_;
		public virtual RMethod RMSort_Comparison_d_VisualElement_p_
		{
			get
			{
				if(r_MSort_Comparison_d_VisualElement_p_ == null)
				{
					r_MSort_Comparison_d_VisualElement_p_ = new(this, "Sort", 0, typeof(System.Comparison<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_MSort_Comparison_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_MSort_Comparison_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Void BringToFront()
		/// </summary>
		protected RMethod r_MBringToFront;
		public virtual RMethod RMBringToFront
		{
			get
			{
				if(r_MBringToFront == null)
				{
					r_MBringToFront = new(this, "BringToFront", 0);
					r_MBringToFront.SetBelong(this.instance);
				}
				return r_MBringToFront;
			}
		}

		/// <summary>
		/// Void SendToBack()
		/// </summary>
		protected RMethod r_MSendToBack;
		public virtual RMethod RMSendToBack
		{
			get
			{
				if(r_MSendToBack == null)
				{
					r_MSendToBack = new(this, "SendToBack", 0);
					r_MSendToBack.SetBelong(this.instance);
				}
				return r_MSendToBack;
			}
		}

		/// <summary>
		/// Void PlaceBehind(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MPlaceBehind_VisualElement;
		public virtual RMethod RMPlaceBehind_VisualElement
		{
			get
			{
				if(r_MPlaceBehind_VisualElement == null)
				{
					r_MPlaceBehind_VisualElement = new(this, "PlaceBehind", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MPlaceBehind_VisualElement.SetBelong(this.instance);
				}
				return r_MPlaceBehind_VisualElement;
			}
		}

		/// <summary>
		/// Void PlaceInFront(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MPlaceInFront_VisualElement;
		public virtual RMethod RMPlaceInFront_VisualElement
		{
			get
			{
				if(r_MPlaceInFront_VisualElement == null)
				{
					r_MPlaceInFront_VisualElement = new(this, "PlaceInFront", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MPlaceInFront_VisualElement.SetBelong(this.instance);
				}
				return r_MPlaceInFront_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveFromHierarchy()
		/// </summary>
		protected RMethod r_MRemoveFromHierarchy;
		public virtual RMethod RMRemoveFromHierarchy
		{
			get
			{
				if(r_MRemoveFromHierarchy == null)
				{
					r_MRemoveFromHierarchy = new(this, "RemoveFromHierarchy", 0);
					r_MRemoveFromHierarchy.SetBelong(this.instance);
				}
				return r_MRemoveFromHierarchy;
			}
		}

		/// <summary>
		/// T GetFirstOfType[T]()
		/// </summary>
		protected RMethod r_MGetFirstOfType_GT;
		public virtual RMethod RMGetFirstOfType_GT
		{
			get
			{
				if(r_MGetFirstOfType_GT == null)
				{
					r_MGetFirstOfType_GT = new(this, "GetFirstOfType", 1);
					r_MGetFirstOfType_GT.SetBelong(this.instance);
				}
				return r_MGetFirstOfType_GT;
			}
		}

		/// <summary>
		/// T GetFirstAncestorOfType[T]()
		/// </summary>
		protected RMethod r_MGetFirstAncestorOfType_GT;
		public virtual RMethod RMGetFirstAncestorOfType_GT
		{
			get
			{
				if(r_MGetFirstAncestorOfType_GT == null)
				{
					r_MGetFirstAncestorOfType_GT = new(this, "GetFirstAncestorOfType", 1);
					r_MGetFirstAncestorOfType_GT.SetBelong(this.instance);
				}
				return r_MGetFirstAncestorOfType_GT;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetFirstAncestorWhere(System.Predicate`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_;
		public virtual RMethod RMGetFirstAncestorWhere_Predicate_d_VisualElement_p_
		{
			get
			{
				if(r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_ == null)
				{
					r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_ = new(this, "GetFirstAncestorWhere", 0, typeof(System.Predicate<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MContains_VisualElement;
		public virtual RMethod RMContains_VisualElement
		{
			get
			{
				if(r_MContains_VisualElement == null)
				{
					r_MContains_VisualElement = new(this, "Contains", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MContains_VisualElement.SetBelong(this.instance);
				}
				return r_MContains_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MFindCommonAncestor_VisualElement;
		public virtual RMethod RMFindCommonAncestor_VisualElement
		{
			get
			{
				if(r_MFindCommonAncestor_VisualElement == null)
				{
					r_MFindCommonAncestor_VisualElement = new(this, "FindCommonAncestor", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MFindCommonAncestor_VisualElement.SetBelong(this.instance);
				}
				return r_MFindCommonAncestor_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetRoot()
		/// </summary>
		protected RMethod r_MGetRoot;
		public virtual RMethod RMGetRoot
		{
			get
			{
				if(r_MGetRoot == null)
				{
					r_MGetRoot = new(this, "GetRoot", 0);
					r_MGetRoot.SetBelong(this.instance);
				}
				return r_MGetRoot;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetRootVisualContainer()
		/// </summary>
		protected RMethod r_MGetRootVisualContainer;
		public virtual RMethod RMGetRootVisualContainer
		{
			get
			{
				if(r_MGetRootVisualContainer == null)
				{
					r_MGetRootVisualContainer = new(this, "GetRootVisualContainer", 0);
					r_MGetRootVisualContainer.SetBelong(this.instance);
				}
				return r_MGetRootVisualContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
		/// </summary>
		protected RMethod r_MGetNextElementDepthFirst;
		public virtual RMethod RMGetNextElementDepthFirst
		{
			get
			{
				if(r_MGetNextElementDepthFirst == null)
				{
					r_MGetNextElementDepthFirst = new(this, "GetNextElementDepthFirst", 0);
					r_MGetNextElementDepthFirst.SetBelong(this.instance);
				}
				return r_MGetNextElementDepthFirst;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
		/// </summary>
		protected RMethod r_MGetPreviousElementDepthFirst;
		public virtual RMethod RMGetPreviousElementDepthFirst
		{
			get
			{
				if(r_MGetPreviousElementDepthFirst == null)
				{
					r_MGetPreviousElementDepthFirst = new(this, "GetPreviousElementDepthFirst", 0);
					r_MGetPreviousElementDepthFirst.SetBelong(this.instance);
				}
				return r_MGetPreviousElementDepthFirst;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MRetargetElement_VisualElement;
		public virtual RMethod RMRetargetElement_VisualElement
		{
			get
			{
				if(r_MRetargetElement_VisualElement == null)
				{
					r_MRetargetElement_VisualElement = new(this, "RetargetElement", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MRetargetElement_VisualElement.SetBelong(this.instance);
				}
				return r_MRetargetElement_VisualElement;
			}
		}

		/// <summary>
		/// Void GetPivotedMatrixWithLayout(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MGetPivotedMatrixWithLayout_Out_Matrix4x4;
		public virtual RMethod RMGetPivotedMatrixWithLayout_Out_Matrix4x4
		{
			get
			{
				if(r_MGetPivotedMatrixWithLayout_Out_Matrix4x4 == null)
				{
					r_MGetPivotedMatrixWithLayout_Out_Matrix4x4 = new(this, "GetPivotedMatrixWithLayout", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_MGetPivotedMatrixWithLayout_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_MGetPivotedMatrixWithLayout_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void AddStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_MAddStyleSheetPath_String;
		public virtual RMethod RMAddStyleSheetPath_String
		{
			get
			{
				if(r_MAddStyleSheetPath_String == null)
				{
					r_MAddStyleSheetPath_String = new(this, "AddStyleSheetPath", 0, typeof(System.String));
					r_MAddStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_MAddStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Boolean HasStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_MHasStyleSheetPath_String;
		public virtual RMethod RMHasStyleSheetPath_String
		{
			get
			{
				if(r_MHasStyleSheetPath_String == null)
				{
					r_MHasStyleSheetPath_String = new(this, "HasStyleSheetPath", 0, typeof(System.String));
					r_MHasStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_MHasStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Void RemoveStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_MRemoveStyleSheetPath_String;
		public virtual RMethod RMRemoveStyleSheetPath_String
		{
			get
			{
				if(r_MRemoveStyleSheetPath_String == null)
				{
					r_MRemoveStyleSheetPath_String = new(this, "RemoveStyleSheetPath", 0, typeof(System.String));
					r_MRemoveStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_MRemoveStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Void Blur()
		/// </summary>
		protected RMethod r_MBlur;
		public virtual RMethod RMBlur
		{
			get
			{
				if(r_MBlur == null)
				{
					r_MBlur = new(this, "Blur", 0);
					r_MBlur.SetBelong(this.instance);
				}
				return r_MBlur;
			}
		}

		/// <summary>
		/// Void BlurImmediately()
		/// </summary>
		protected RMethod r_MBlurImmediately;
		public virtual RMethod RMBlurImmediately
		{
			get
			{
				if(r_MBlurImmediately == null)
				{
					r_MBlurImmediately = new(this, "BlurImmediately", 0);
					r_MBlurImmediately.SetBelong(this.instance);
				}
				return r_MBlurImmediately;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultActionDisabled_EventBase;
		public virtual RMethod RMExecuteDefaultActionDisabled_EventBase
		{
			get
			{
				if(r_MExecuteDefaultActionDisabled_EventBase == null)
				{
					r_MExecuteDefaultActionDisabled_EventBase = new(this, "ExecuteDefaultActionDisabled", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MExecuteDefaultActionDisabled_EventBase.SetBelong(this.instance);
				}
				return r_MExecuteDefaultActionDisabled_EventBase;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
		public virtual RMethod RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown
		{
			get
			{
				if(r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown == null)
				{
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown = new(this, "RegisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.UIElements.TrickleDown));
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType,TUserArgsType](UnityEngine.UIElements.EventCallback`2[TEventType,TUserArgsType], TUserArgsType, UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown;
		public virtual RMethod RMRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown
		{
			get
			{
				if(r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown == null)
				{
					r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown = new(this, "RegisterCallback", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), Type.MakeGenericMethodParameter(1), typeof(UnityEngine.UIElements.TrickleDown));
					r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown.SetBelong(this.instance);
				}
				return r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.InvokePolicy, UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown;
		public virtual RMethod RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown
		{
			get
			{
				if(r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown == null)
				{
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown = new(this, "RegisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("UnityEngine.UIElements.InvokePolicy"), typeof(UnityEngine.UIElements.TrickleDown));
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown.SetBelong(this.instance);
				}
				return r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown;
			}
		}

		/// <summary>
		/// Void UnregisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
		public virtual RMethod RMUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown
		{
			get
			{
				if(r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown == null)
				{
					r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown = new(this, "UnregisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.UIElements.TrickleDown));
					r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Void UnregisterCallback[TEventType,TUserArgsType](UnityEngine.UIElements.EventCallback`2[TEventType,TUserArgsType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown;
		public virtual RMethod RMUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown
		{
			get
			{
				if(r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown == null)
				{
					r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown = new(this, "UnregisterCallback", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(UnityEngine.UIElements.TrickleDown));
					r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Boolean TryGetUserArgs[TEventType,TCallbackArgs](UnityEngine.UIElements.EventCallback`2[TEventType,TCallbackArgs], UnityEngine.UIElements.TrickleDown, TCallbackArgs ByRef)
		/// </summary>
		protected RMethod r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs;
		public virtual RMethod RMTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs
		{
			get
			{
				if(r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs == null)
				{
					r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs = new(this, "TryGetUserArgs", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(UnityEngine.UIElements.TrickleDown), Type.MakeGenericMethodParameter(1).MakeByRefType());
					r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs.SetBelong(this.instance);
				}
				return r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs;
			}
		}

		/// <summary>
		/// Void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEventAtTargetPhase_EventBase;
		public virtual RMethod RMHandleEventAtTargetPhase_EventBase
		{
			get
			{
				if(r_MHandleEventAtTargetPhase_EventBase == null)
				{
					r_MHandleEventAtTargetPhase_EventBase = new(this, "HandleEventAtTargetPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEventAtTargetPhase_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEventAtTargetPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventAtTargetAndDefaultPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEventAtTargetAndDefaultPhase_EventBase;
		public virtual RMethod RMHandleEventAtTargetAndDefaultPhase_EventBase
		{
			get
			{
				if(r_MHandleEventAtTargetAndDefaultPhase_EventBase == null)
				{
					r_MHandleEventAtTargetAndDefaultPhase_EventBase = new(this, "HandleEventAtTargetAndDefaultPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEventAtTargetAndDefaultPhase_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEventAtTargetAndDefaultPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventAtCurrentTargetAndPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEventAtCurrentTargetAndPhase_EventBase;
		public virtual RMethod RMHandleEventAtCurrentTargetAndPhase_EventBase
		{
			get
			{
				if(r_MHandleEventAtCurrentTargetAndPhase_EventBase == null)
				{
					r_MHandleEventAtCurrentTargetAndPhase_EventBase = new(this, "HandleEventAtCurrentTargetAndPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEventAtCurrentTargetAndPhase_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEventAtCurrentTargetAndPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventEditorInternal(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEventEditorInternal_EventBase;
		public virtual RMethod RMHandleEventEditorInternal_EventBase
		{
			get
			{
				if(r_MHandleEventEditorInternal_EventBase == null)
				{
					r_MHandleEventEditorInternal_EventBase = new(this, "HandleEventEditorInternal", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEventEditorInternal_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEventEditorInternal_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEvent_EventBase;
		public virtual RMethod RMHandleEvent_EventBase
		{
			get
			{
				if(r_MHandleEvent_EventBase == null)
				{
					r_MHandleEvent_EventBase = new(this, "HandleEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEvent_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEvent_EventBase;
			}
		}

		/// <summary>
		/// Boolean HasTrickleDownHandlers()
		/// </summary>
		protected RMethod r_MHasTrickleDownHandlers;
		public virtual RMethod RMHasTrickleDownHandlers
		{
			get
			{
				if(r_MHasTrickleDownHandlers == null)
				{
					r_MHasTrickleDownHandlers = new(this, "HasTrickleDownHandlers", 0);
					r_MHasTrickleDownHandlers.SetBelong(this.instance);
				}
				return r_MHasTrickleDownHandlers;
			}
		}

		/// <summary>
		/// Boolean HasBubbleUpHandlers()
		/// </summary>
		protected RMethod r_MHasBubbleUpHandlers;
		public virtual RMethod RMHasBubbleUpHandlers
		{
			get
			{
				if(r_MHasBubbleUpHandlers == null)
				{
					r_MHasBubbleUpHandlers = new(this, "HasBubbleUpHandlers", 0);
					r_MHasBubbleUpHandlers.SetBelong(this.instance);
				}
				return r_MHasBubbleUpHandlers;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultActionAtTarget_EventBase;
		public virtual RMethod RMExecuteDefaultActionAtTarget_EventBase
		{
			get
			{
				if(r_MExecuteDefaultActionAtTarget_EventBase == null)
				{
					r_MExecuteDefaultActionAtTarget_EventBase = new(this, "ExecuteDefaultActionAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MExecuteDefaultActionAtTarget_EventBase.SetBelong(this.instance);
				}
				return r_MExecuteDefaultActionAtTarget_EventBase;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultActionDisabledAtTarget_EventBase;
		public virtual RMethod RMExecuteDefaultActionDisabledAtTarget_EventBase
		{
			get
			{
				if(r_MExecuteDefaultActionDisabledAtTarget_EventBase == null)
				{
					r_MExecuteDefaultActionDisabledAtTarget_EventBase = new(this, "ExecuteDefaultActionDisabledAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MExecuteDefaultActionDisabledAtTarget_EventBase.SetBelong(this.instance);
				}
				return r_MExecuteDefaultActionDisabledAtTarget_EventBase;
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


        public RIMGUIContainer() : base("UnityEngine.UIElements.IMGUIContainer")
        {
        }

        public RIMGUIContainer(System.Object instance) : base("UnityEngine.UIElements.IMGUIContainer")
		{
            SetInstance(instance);
		}

        public RIMGUIContainer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIMGUIContainer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext @mgc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mgc};
            var ___result = RMOnGenerateVisualContent_MeshGenerationContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveGlobals()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveGlobals.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestoreGlobals()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRestoreGlobals.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoOnGUI(UnityEngine.Event @evt, UnityEngine.Matrix4x4 @parentTransform, UnityEngine.Rect @clippingRect, System.Boolean @isComputingLayout, UnityEngine.Rect @layoutSize, System.Action @onGUIHandler, System.Boolean @canAffectFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @parentTransform, @clippingRect, @isComputingLayout, @layoutSize, @onGUIHandler, @canAffectFocus};
            var ___result = RMDoOnGUI_Event_Matrix4x4_Rect_Boolean_Rect_Action_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDirtyLayout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkDirtyLayout.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessEvent(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMProcessEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoIMGUIRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDoIMGUIRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SendEventToIMGUI(UnityEngine.UIElements.EventBase @evt, System.Boolean @canAffectFocus, System.Boolean @verifyBounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @canAffectFocus, @verifyBounds};
            var ___result = RMSendEventToIMGUI_EventBase_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SendEventToIMGUIRaw(UnityEngine.UIElements.EventBase @evt, System.Boolean @canAffectFocus, System.Boolean @verifyBounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @canAffectFocus, @verifyBounds};
            var ___result = RMSendEventToIMGUIRaw_EventBase_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean VerifyBounds(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMVerifyBounds_EventBase.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsContainerCapturingTheMouse()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsContainerCapturingTheMouse.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsLocalEvent(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMIsLocalEvent_EventBase.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsEventInsideLocalWindow(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMIsEventInsideLocalWindow_EventBase.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsDockAreaMouseUp(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMIsDockAreaMouseUp_EventBase.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HandleIMGUIEvent(UnityEngine.Event @e, System.Boolean @canAffectFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @canAffectFocus};
            var ___result = RMHandleIMGUIEvent_Event_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HandleIMGUIEvent(UnityEngine.Event @e, System.Action @onGUIHandler, System.Boolean @canAffectFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @onGUIHandler, @canAffectFocus};
            var ___result = RMHandleIMGUIEvent_Event_Action_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HandleIMGUIEvent(UnityEngine.Event @e, UnityEngine.Matrix4x4 @worldTransform, UnityEngine.Rect @clippingRect, System.Action @onGUIHandler, System.Boolean @canAffectFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @worldTransform, @clippingRect, @onGUIHandler, @canAffectFocus};
            var ___result = RMHandleIMGUIEvent_Event_Matrix4x4_Rect_Action_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ExecuteDefaultAction(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultAction_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFoldoutDepthClass()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetFoldoutDepthClass.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 DoMeasure(System.Single @desiredWidth, RUnityEngine.RUIElements.RVisualElement.RMeasureMode @widthMode, System.Single @desiredHeight, RUnityEngine.RUIElements.RVisualElement.RMeasureMode @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desiredWidth, @widthMode.Value, @desiredHeight, @heightMode.Value};
            var ___result = RMDoMeasure_Single_MeasureMode_Single_MeasureMode.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Rect GetCurrentClipRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCurrentClipRect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static void GetCurrentTransformAndClip(UnityEngine.UIElements.IMGUIContainer @container, UnityEngine.Event @evt, out UnityEngine.Matrix4x4 @transform, out UnityEngine.Rect @clipRect)
        {
			@transform = default;
			@clipRect = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container, @evt, @transform, @clipRect};
            var ___result = RMGetCurrentTransformAndClip_IMGUIContainer_Event_Out_Matrix4x4_Out_Rect.Invoke(___genericsType, ___parameters);
			@transform = (UnityEngine.Matrix4x4)___parameters[2];
			@clipRect = (UnityEngine.Rect)___parameters[3];

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposeManaged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposeManaged};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__DoOnGUI__1__b__56_0()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RM__0__DoOnGUI__1__b__56_0.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryConvertLengthUnits(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref UnityEngine.UIElements.Length @from, ref UnityEngine.UIElements.Length @to, System.Int32 @subPropertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @subPropertyIndex};
            var ___result = RMTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.Length)___parameters[1];
			@to = (UnityEngine.UIElements.Length)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertTransformOriginUnits(ref UnityEngine.UIElements.TransformOrigin @from, ref UnityEngine.UIElements.TransformOrigin @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.TransformOrigin)___parameters[0];
			@to = (UnityEngine.UIElements.TransformOrigin)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertTranslateUnits(ref UnityEngine.UIElements.Translate @from, ref UnityEngine.UIElements.Translate @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertTranslateUnits_Ref_Translate_Ref_Translate.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.Translate)___parameters[0];
			@to = (UnityEngine.UIElements.Translate)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertBackgroundPositionUnits(ref UnityEngine.UIElements.BackgroundPosition @from, ref UnityEngine.UIElements.BackgroundPosition @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.BackgroundPosition)___parameters[0];
			@to = (UnityEngine.UIElements.BackgroundPosition)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertBackgroundSizeUnits(ref UnityEngine.UIElements.BackgroundSize @from, ref UnityEngine.UIElements.BackgroundSize @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.BackgroundSize)___parameters[0];
			@to = (UnityEngine.UIElements.BackgroundSize)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void MarkRenderHintsClean()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkRenderHintsClean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateBoundingBox()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateBoundingBox.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldBoundingBox()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWorldBoundingBox.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldTransform()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWorldTransform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldTransformInverse()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWorldTransformInverse.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureWorldTransformAndClipUpToDate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnsureWorldTransformAndClipUpToDate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect GetTooltipRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTooltipRect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPanel(RUnityEngine.RUIElements.RBaseVisualElementPanel @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p.Value};
            var ___result = RMSetPanel_BaseVisualElementPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendEvent(UnityEngine.UIElements.EventBase @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMSendEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendEvent(UnityEngine.UIElements.EventBase @e, RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @dispatchMode.Value};
            var ___result = RMSendEvent_EventBase_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IncrementVersion(RUnityEngine.RUIElements.RVersionChangeType @changeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changeType.Value};
            var ___result = RMIncrementVersion_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeHierarchyChanged(RUnityEngine.RUIElements.RHierarchyChangeType @changeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changeType.Value};
            var ___result = RMInvokeHierarchyChanged_HierarchyChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetEnabledFromHierarchy(System.Boolean @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RMSetEnabledFromHierarchy_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetEnabled(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDirtyRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkDirtyRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext @mgc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mgc};
            var ___result = RMInvokeGenerateVisualContent_MeshGenerationContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetFullHierarchicalViewDataKey(System.Text.StringBuilder @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMGetFullHierarchicalViewDataKey_StringBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetFullHierarchicalViewDataKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFullHierarchicalViewDataKey.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual T GetOrCreateViewData<T>(System.Object @existing, System.String @key) where T : class, new()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@existing, @key};
            var ___result = RMGetOrCreateViewData_GT_Object_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetOrCreateViewData<T>(UnityEngine.ScriptableObject @existing, System.String @key) where T : UnityEngine.ScriptableObject
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@existing, @key};
            var ___result = RMGetOrCreateViewData_GT_ScriptableObject_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void OverwriteFromViewData(System.Object @obj, System.String @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @key};
            var ___result = RMOverwriteFromViewData_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsViewDataPersitenceSupportedOnChildren(System.Boolean @existingState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@existingState};
            var ___result = RMIsViewDataPersitenceSupportedOnChildren_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnViewDataReady(System.Boolean @enablePersistence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enablePersistence};
            var ___result = RMOnViewDataReady_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnViewDataReady()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnViewDataReady.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsPoint(UnityEngine.Vector2 @localPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPoint};
            var ___result = RMContainsPoint_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Overlaps(UnityEngine.Rect @rectangle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectangle};
            var ___result = RMOverlaps_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual RUnityEngine.RYoga.RYogaSize Measure(RUnityEngine.RYoga.RYogaNode @node, System.Single @width, RUnityEngine.RYoga.RYogaMeasureMode @widthMode, System.Single @height, RUnityEngine.RYoga.RYogaMeasureMode @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value, @width, @widthMode.Value, @height, @heightMode.Value};
            var ___result = RMMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RYoga.RYogaSize(___result);
        }


        public virtual void SetSize(UnityEngine.Vector2 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RMSetSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInlineRule(UnityEngine.UIElements.StyleSheet @sheet, RUnityEngine.RUIElements.RStyleRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @rule.Value};
            var ___result = RMSetInlineRule_StyleSheet_StyleRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInlineRule(UnityEngine.UIElements.StyleSheet @sheet, RUnityEngine.RUIElements.RStyleRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @rule.Value};
            var ___result = RMUpdateInlineRule_StyleSheet_StyleRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputedStyle(ref RUnityEngine.RUIElements.RComputedStyle @newStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newStyle.Value};
            var ___result = RMSetComputedStyle_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@newStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[0]);

            
        }


        public virtual void ResetPositionProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetPositionProperties.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<System.String> GetClasses()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetClasses.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.String>)___result;
        }


        public virtual System.Collections.Generic.List<System.String> GetClassesForIteration()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetClassesForIteration.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
        }


        public virtual void ClearClassList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearClassList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToClassList(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMAddToClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromClassList(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMRemoveFromClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ToggleInClassList(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMToggleInClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableInClassList(System.String @className, System.Boolean @enable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @enable};
            var ___result = RMEnableInClassList_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ClassListContains(System.String @cls)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cls};
            var ___result = RMClassListContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object FindAncestorUserData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFindAncestorUserData.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetProperty(UnityEngine.PropertyName @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMGetProperty_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetProperty(UnityEngine.PropertyName @key, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMSetProperty_PropertyName_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasProperty(UnityEngine.PropertyName @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMHasProperty_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ApplyPlayerRenderingToEditorElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApplyPlayerRenderingToEditorElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterAnimation(RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim.Value};
            var ___result = RMRegisterAnimation_IValueAnimationUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterAnimation(RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim.Value};
            var ___result = RMUnregisterAnimation_IValueAnimationUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetCachedNextParentWithEventCallback(out UnityEngine.UIElements.VisualElement @nextParent)
        {
			@nextParent = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nextParent};
            var ___result = RMGetCachedNextParentWithEventCallback_Out_VisualElement.Invoke(___genericsType, ___parameters);
			@nextParent = (UnityEngine.UIElements.VisualElement)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasEventCallbacks(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasEventCallbacks_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasParentEventCallbacks(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasParentEventCallbacks_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasParentEventCallbacksOrDefaultActions(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasParentEventCallbacksOrDefaultActions_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasEventCallbacksOrDefaultActions(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasEventCallbacksOrDefaultActions_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasParentEventCallbacksOrDefaultActionAtTarget(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasEventCallbacksOrDefaultActionAtTarget(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasEventCallbacksOrDefaultActionAtTarget_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasDefaultAction(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasDefaultAction_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ShouldClip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShouldClip.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Add(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMAdd_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Insert(System.Int32 @index, UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @element};
            var ___result = RMInsert_Int32_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMRemove_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMElementAt_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Int32 IndexOf(UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMIndexOf_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List<System.Int32> @childIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@childIndexes};
            var ___result = RMElementAtTreePath_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Boolean FindElementInTree(UnityEngine.UIElements.VisualElement @element, System.Collections.Generic.List<System.Int32> @outChildIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @outChildIndexes};
            var ___result = RMFindElementInTree_VisualElement_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMChildren.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement>)___result;
        }


        public virtual void Sort(System.Comparison<UnityEngine.UIElements.VisualElement> @comp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comp};
            var ___result = RMSort_Comparison_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BringToFront()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBringToFront.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendToBack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSendToBack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceBehind(UnityEngine.UIElements.VisualElement @sibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sibling};
            var ___result = RMPlaceBehind_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceInFront(UnityEngine.UIElements.VisualElement @sibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sibling};
            var ___result = RMPlaceInFront_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromHierarchy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveFromHierarchy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetFirstOfType<T>() where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetFirstOfType_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetFirstAncestorOfType<T>() where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetFirstAncestorOfType_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetFirstAncestorWhere(System.Predicate<UnityEngine.UIElements.VisualElement> @predicate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@predicate};
            var ___result = RMGetFirstAncestorWhere_Predicate_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Boolean Contains(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMContains_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMFindCommonAncestor_VisualElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRoot.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetRootVisualContainer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRootVisualContainer.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNextElementDepthFirst.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPreviousElementDepthFirst.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement @retargetAgainst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@retargetAgainst};
            var ___result = RMRetargetElement_VisualElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void GetPivotedMatrixWithLayout(out UnityEngine.Matrix4x4 @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RMGetPivotedMatrixWithLayout_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@result = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void AddStyleSheetPath(System.String @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RMAddStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasStyleSheetPath(System.String @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RMHasStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveStyleSheetPath(System.String @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RMRemoveStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blur()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBlur.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BlurImmediately()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBlurImmediately.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultActionDisabled_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType, TUserArgsType>(UnityEngine.UIElements.EventCallback<TEventType, TUserArgsType> @callback, TUserArgsType @userArgs, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TUserArgsType)};
            var ___parameters = new object[]{@callback, @userArgs, @useTrickleDown};
            var ___result = RMRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> @callback, RUnityEngine.RUIElements.RInvokePolicy @invokePolicy, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @invokePolicy.Value, @useTrickleDown};
            var ___result = RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RMUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallback<TEventType, TUserArgsType>(UnityEngine.UIElements.EventCallback<TEventType, TUserArgsType> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TUserArgsType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RMUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetUserArgs<TEventType, TCallbackArgs>(UnityEngine.UIElements.EventCallback<TEventType, TCallbackArgs> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown, out TCallbackArgs @userData) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {
			@userData = default;

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TCallbackArgs)};
            var ___parameters = new object[]{@callback, @useTrickleDown, @userData};
            var ___result = RMTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs.Invoke(___genericsType, ___parameters);
			@userData = (TCallbackArgs)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEventAtTargetPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventAtTargetAndDefaultPhase(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEventAtTargetAndDefaultPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventAtCurrentTargetAndPhase(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEventAtCurrentTargetAndPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventEditorInternal(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEventEditorInternal_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEvent(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasTrickleDownHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasTrickleDownHandlers.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasBubbleUpHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasBubbleUpHandlers.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultActionAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultActionDisabledAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
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


    }
}
