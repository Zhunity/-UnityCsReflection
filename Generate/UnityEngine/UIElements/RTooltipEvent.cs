using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TooltipEvent
	/// </summary>
    public partial class RTooltipEvent : RMember //
    {

		/// <summary>
		/// System.String <tooltip>k__BackingField
		/// </summary>
		protected RSystem.RString r_F__0__tooltip__1__k__BackingField;
		public virtual RSystem.RString RF__0__tooltip__1__k__BackingField
		{
			get
			{
				if(r_F__0__tooltip__1__k__BackingField == null)
				{
					r_F__0__tooltip__1__k__BackingField = new(this, "<tooltip>k__BackingField");
					r_F__0__tooltip__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__tooltip__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Rect <rect>k__BackingField
		/// </summary>
		protected RUnityEngine.RRect r_F__0__rect__1__k__BackingField;
		public virtual RUnityEngine.RRect RF__0__rect__1__k__BackingField
		{
			get
			{
				if(r_F__0__rect__1__k__BackingField == null)
				{
					r_F__0__rect__1__k__BackingField = new(this, "<rect>k__BackingField");
					r_F__0__rect__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__rect__1__k__BackingField;
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
		/// Int64 eventTypeId
		/// </summary>
		protected RSystem.RInt64 r_PeventTypeId;
		public virtual RSystem.RInt64 RPeventTypeId
		{
			get
			{
				if(r_PeventTypeId == null)
				{
					r_PeventTypeId = new(this, "eventTypeId", -1);
					r_PeventTypeId.SetBelong(this.instance);
				}
				return r_PeventTypeId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory eventCategory
		/// </summary>
		protected RUnityEngine.RUIElements.REventCategory r_PeventCategory;
		public virtual RUnityEngine.RUIElements.REventCategory RPeventCategory
		{
			get
			{
				if(r_PeventCategory == null)
				{
					r_PeventCategory = new(this, "eventCategory", -1);
					r_PeventCategory.SetBelong(this.instance);
				}
				return r_PeventCategory;
			}
		}

		/// <summary>
		/// Int64 timestamp
		/// </summary>
		protected RSystem.RInt64 r_Ptimestamp;
		public virtual RSystem.RInt64 RPtimestamp
		{
			get
			{
				if(r_Ptimestamp == null)
				{
					r_Ptimestamp = new(this, "timestamp", -1);
					r_Ptimestamp.SetBelong(this.instance);
				}
				return r_Ptimestamp;
			}
		}

		/// <summary>
		/// UInt64 eventId
		/// </summary>
		protected RSystem.RUInt64 r_PeventId;
		public virtual RSystem.RUInt64 RPeventId
		{
			get
			{
				if(r_PeventId == null)
				{
					r_PeventId = new(this, "eventId", -1);
					r_PeventId.SetBelong(this.instance);
				}
				return r_PeventId;
			}
		}

		/// <summary>
		/// UInt64 triggerEventId
		/// </summary>
		protected RSystem.RUInt64 r_PtriggerEventId;
		public virtual RSystem.RUInt64 RPtriggerEventId
		{
			get
			{
				if(r_PtriggerEventId == null)
				{
					r_PtriggerEventId = new(this, "triggerEventId", -1);
					r_PtriggerEventId.SetBelong(this.instance);
				}
				return r_PtriggerEventId;
			}
		}

		/// <summary>
		/// EventPropagation propagation
		/// </summary>
		protected RUnityEngine.RUIElements.REventBase.REventPropagation r_Ppropagation;
		public virtual RUnityEngine.RUIElements.REventBase.REventPropagation RPpropagation
		{
			get
			{
				if(r_Ppropagation == null)
				{
					r_Ppropagation = new(this, "propagation", -1);
					r_Ppropagation.SetBelong(this.instance);
				}
				return r_Ppropagation;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPaths path
		/// </summary>
		protected RUnityEngine.RUIElements.RPropagationPaths r_Ppath;
		public virtual RUnityEngine.RUIElements.RPropagationPaths RPpath
		{
			get
			{
				if(r_Ppath == null)
				{
					r_Ppath = new(this, "path", -1);
					r_Ppath.SetBelong(this.instance);
				}
				return r_Ppath;
			}
		}

		/// <summary>
		/// Boolean bubbles
		/// </summary>
		protected RSystem.RBoolean r_Pbubbles;
		public virtual RSystem.RBoolean RPbubbles
		{
			get
			{
				if(r_Pbubbles == null)
				{
					r_Pbubbles = new(this, "bubbles", -1);
					r_Pbubbles.SetBelong(this.instance);
				}
				return r_Pbubbles;
			}
		}

		/// <summary>
		/// Boolean tricklesDown
		/// </summary>
		protected RSystem.RBoolean r_PtricklesDown;
		public virtual RSystem.RBoolean RPtricklesDown
		{
			get
			{
				if(r_PtricklesDown == null)
				{
					r_PtricklesDown = new(this, "tricklesDown", -1);
					r_PtricklesDown.SetBelong(this.instance);
				}
				return r_PtricklesDown;
			}
		}

		/// <summary>
		/// Boolean bubblesOrTricklesDown
		/// </summary>
		protected RSystem.RBoolean r_PbubblesOrTricklesDown;
		public virtual RSystem.RBoolean RPbubblesOrTricklesDown
		{
			get
			{
				if(r_PbubblesOrTricklesDown == null)
				{
					r_PbubblesOrTricklesDown = new(this, "bubblesOrTricklesDown", -1);
					r_PbubblesOrTricklesDown.SetBelong(this.instance);
				}
				return r_PbubblesOrTricklesDown;
			}
		}

		/// <summary>
		/// Boolean skipDisabledElements
		/// </summary>
		protected RSystem.RBoolean r_PskipDisabledElements;
		public virtual RSystem.RBoolean RPskipDisabledElements
		{
			get
			{
				if(r_PskipDisabledElements == null)
				{
					r_PskipDisabledElements = new(this, "skipDisabledElements", -1);
					r_PskipDisabledElements.SetBelong(this.instance);
				}
				return r_PskipDisabledElements;
			}
		}

		/// <summary>
		/// Boolean ignoreCompositeRoots
		/// </summary>
		protected RSystem.RBoolean r_PignoreCompositeRoots;
		public virtual RSystem.RBoolean RPignoreCompositeRoots
		{
			get
			{
				if(r_PignoreCompositeRoots == null)
				{
					r_PignoreCompositeRoots = new(this, "ignoreCompositeRoots", -1);
					r_PignoreCompositeRoots.SetBelong(this.instance);
				}
				return r_PignoreCompositeRoots;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler leafTarget
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_PleafTarget;
		public virtual RUnityEngine.RUIElements.RIEventHandler RPleafTarget
		{
			get
			{
				if(r_PleafTarget == null)
				{
					r_PleafTarget = new(this, "leafTarget", -1);
					r_PleafTarget.SetBelong(this.instance);
				}
				return r_PleafTarget;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler target
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_Ptarget;
		public virtual RUnityEngine.RUIElements.RIEventHandler RPtarget
		{
			get
			{
				if(r_Ptarget == null)
				{
					r_Ptarget = new(this, "target", -1);
					r_Ptarget.SetBelong(this.instance);
				}
				return r_Ptarget;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.IEventHandler] skipElements
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RIEventHandler> r_PskipElements;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RIEventHandler> RPskipElements
		{
			get
			{
				if(r_PskipElements == null)
				{
					r_PskipElements = new(this, "skipElements", -1);
					r_PskipElements.SetBelong(this.instance);
				}
				return r_PskipElements;
			}
		}

		/// <summary>
		/// Boolean isPropagationStopped
		/// </summary>
		protected RSystem.RBoolean r_PisPropagationStopped;
		public virtual RSystem.RBoolean RPisPropagationStopped
		{
			get
			{
				if(r_PisPropagationStopped == null)
				{
					r_PisPropagationStopped = new(this, "isPropagationStopped", -1);
					r_PisPropagationStopped.SetBelong(this.instance);
				}
				return r_PisPropagationStopped;
			}
		}

		/// <summary>
		/// Boolean isImmediatePropagationStopped
		/// </summary>
		protected RSystem.RBoolean r_PisImmediatePropagationStopped;
		public virtual RSystem.RBoolean RPisImmediatePropagationStopped
		{
			get
			{
				if(r_PisImmediatePropagationStopped == null)
				{
					r_PisImmediatePropagationStopped = new(this, "isImmediatePropagationStopped", -1);
					r_PisImmediatePropagationStopped.SetBelong(this.instance);
				}
				return r_PisImmediatePropagationStopped;
			}
		}

		/// <summary>
		/// Boolean isDefaultPrevented
		/// </summary>
		protected RSystem.RBoolean r_PisDefaultPrevented;
		public virtual RSystem.RBoolean RPisDefaultPrevented
		{
			get
			{
				if(r_PisDefaultPrevented == null)
				{
					r_PisDefaultPrevented = new(this, "isDefaultPrevented", -1);
					r_PisDefaultPrevented.SetBelong(this.instance);
				}
				return r_PisDefaultPrevented;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPhase propagationPhase
		/// </summary>
		protected RUnityEngine.RUIElements.RPropagationPhase r_PpropagationPhase;
		public virtual RUnityEngine.RUIElements.RPropagationPhase RPpropagationPhase
		{
			get
			{
				if(r_PpropagationPhase == null)
				{
					r_PpropagationPhase = new(this, "propagationPhase", -1);
					r_PpropagationPhase.SetBelong(this.instance);
				}
				return r_PpropagationPhase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler currentTarget
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_PcurrentTarget;
		public virtual RUnityEngine.RUIElements.RIEventHandler RPcurrentTarget
		{
			get
			{
				if(r_PcurrentTarget == null)
				{
					r_PcurrentTarget = new(this, "currentTarget", -1);
					r_PcurrentTarget.SetBelong(this.instance);
				}
				return r_PcurrentTarget;
			}
		}

		/// <summary>
		/// Boolean dispatch
		/// </summary>
		protected RSystem.RBoolean r_Pdispatch;
		public virtual RSystem.RBoolean RPdispatch
		{
			get
			{
				if(r_Pdispatch == null)
				{
					r_Pdispatch = new(this, "dispatch", -1);
					r_Pdispatch.SetBelong(this.instance);
				}
				return r_Pdispatch;
			}
		}

		/// <summary>
		/// Boolean processed
		/// </summary>
		protected RSystem.RBoolean r_Pprocessed;
		public virtual RSystem.RBoolean RPprocessed
		{
			get
			{
				if(r_Pprocessed == null)
				{
					r_Pprocessed = new(this, "processed", -1);
					r_Pprocessed.SetBelong(this.instance);
				}
				return r_Pprocessed;
			}
		}

		/// <summary>
		/// Boolean processedByFocusController
		/// </summary>
		protected RSystem.RBoolean r_PprocessedByFocusController;
		public virtual RSystem.RBoolean RPprocessedByFocusController
		{
			get
			{
				if(r_PprocessedByFocusController == null)
				{
					r_PprocessedByFocusController = new(this, "processedByFocusController", -1);
					r_PprocessedByFocusController.SetBelong(this.instance);
				}
				return r_PprocessedByFocusController;
			}
		}

		/// <summary>
		/// Boolean stopDispatch
		/// </summary>
		protected RSystem.RBoolean r_PstopDispatch;
		public virtual RSystem.RBoolean RPstopDispatch
		{
			get
			{
				if(r_PstopDispatch == null)
				{
					r_PstopDispatch = new(this, "stopDispatch", -1);
					r_PstopDispatch.SetBelong(this.instance);
				}
				return r_PstopDispatch;
			}
		}

		/// <summary>
		/// Boolean propagateToIMGUI
		/// </summary>
		protected RSystem.RBoolean r_PpropagateToIMGUI;
		public virtual RSystem.RBoolean RPpropagateToIMGUI
		{
			get
			{
				if(r_PpropagateToIMGUI == null)
				{
					r_PpropagateToIMGUI = new(this, "propagateToIMGUI", -1);
					r_PpropagateToIMGUI.SetBelong(this.instance);
				}
				return r_PpropagateToIMGUI;
			}
		}

		/// <summary>
		/// UnityEngine.Event imguiEvent
		/// </summary>
		protected RUnityEngine.REvent r_PimguiEvent;
		public virtual RUnityEngine.REvent RPimguiEvent
		{
			get
			{
				if(r_PimguiEvent == null)
				{
					r_PimguiEvent = new(this, "imguiEvent", -1);
					r_PimguiEvent.SetBelong(this.instance);
				}
				return r_PimguiEvent;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 originalMousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_PoriginalMousePosition;
		public virtual RUnityEngine.RVector2 RPoriginalMousePosition
		{
			get
			{
				if(r_PoriginalMousePosition == null)
				{
					r_PoriginalMousePosition = new(this, "originalMousePosition", -1);
					r_PoriginalMousePosition.SetBelong(this.instance);
				}
				return r_PoriginalMousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDebugger eventLogger
		/// </summary>
		protected RUnityEngine.RUIElements.REventDebugger r_PeventLogger;
		public virtual RUnityEngine.RUIElements.REventDebugger RPeventLogger
		{
			get
			{
				if(r_PeventLogger == null)
				{
					r_PeventLogger = new(this, "eventLogger", -1);
					r_PeventLogger.SetBelong(this.instance);
				}
				return r_PeventLogger;
			}
		}

		/// <summary>
		/// Boolean log
		/// </summary>
		protected RSystem.RBoolean r_Plog;
		public virtual RSystem.RBoolean RPlog
		{
			get
			{
				if(r_Plog == null)
				{
					r_Plog = new(this, "log", -1);
					r_Plog.SetBelong(this.instance);
				}
				return r_Plog;
			}
		}

		/// <summary>
		/// Boolean pooled
		/// </summary>
		protected RSystem.RBoolean r_Ppooled;
		public virtual RSystem.RBoolean RPpooled
		{
			get
			{
				if(r_Ppooled == null)
				{
					r_Ppooled = new(this, "pooled", -1);
					r_Ppooled.SetBelong(this.instance);
				}
				return r_Ppooled;
			}
		}

		/// <summary>
		/// Void Init()
		/// </summary>
		protected RMethod r_MInit;
		public virtual RMethod RMInit
		{
			get
			{
				if(r_MInit == null)
				{
					r_MInit = new(this, "Init", 0);
					r_MInit.SetBelong(this.instance);
				}
				return r_MInit;
			}
		}

		/// <summary>
		/// Void LocalInit()
		/// </summary>
		protected RMethod r_MLocalInit;
		public virtual RMethod RMLocalInit
		{
			get
			{
				if(r_MLocalInit == null)
				{
					r_MLocalInit = new(this, "LocalInit", 0);
					r_MLocalInit.SetBelong(this.instance);
				}
				return r_MLocalInit;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TooltipEvent GetPooled(System.String, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_MGetPooled_String_Rect;
		public static RMethod RMGetPooled_String_Rect
		{
			get
			{
				if(r_MGetPooled_String_Rect == null)
				{
					r_MGetPooled_String_Rect = new(typeof(UnityEngine.UIElements.TooltipEvent), "GetPooled", 0, typeof(System.String), typeof(UnityEngine.Rect));
					r_MGetPooled_String_Rect.SetBelong(null);
				}
				return r_MGetPooled_String_Rect;
			}
		}

		/// <summary>
		/// Void Acquire()
		/// </summary>
		protected RMethod r_MAcquire;
		public virtual RMethod RMAcquire
		{
			get
			{
				if(r_MAcquire == null)
				{
					r_MAcquire = new(this, "Acquire", 0);
					r_MAcquire.SetBelong(this.instance);
				}
				return r_MAcquire;
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
		/// Void SetTriggerEventId(UInt64)
		/// </summary>
		protected RMethod r_MSetTriggerEventId_UInt64;
		public virtual RMethod RMSetTriggerEventId_UInt64
		{
			get
			{
				if(r_MSetTriggerEventId_UInt64 == null)
				{
					r_MSetTriggerEventId_UInt64 = new(this, "SetTriggerEventId", 0, typeof(System.UInt64));
					r_MSetTriggerEventId_UInt64.SetBelong(this.instance);
				}
				return r_MSetTriggerEventId_UInt64;
			}
		}

		/// <summary>
		/// Void PreDispatch()
		/// </summary>
		protected RMethod r_MPreDispatch;
		public virtual RMethod RMPreDispatch
		{
			get
			{
				if(r_MPreDispatch == null)
				{
					r_MPreDispatch = new(this, "PreDispatch", 0);
					r_MPreDispatch.SetBelong(this.instance);
				}
				return r_MPreDispatch;
			}
		}

		/// <summary>
		/// Void PreDispatch(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MPreDispatch_IPanel;
		public virtual RMethod RMPreDispatch_IPanel
		{
			get
			{
				if(r_MPreDispatch_IPanel == null)
				{
					r_MPreDispatch_IPanel = new(this, "PreDispatch", 0, typeof(UnityEngine.UIElements.IPanel));
					r_MPreDispatch_IPanel.SetBelong(this.instance);
				}
				return r_MPreDispatch_IPanel;
			}
		}

		/// <summary>
		/// Void PostDispatch()
		/// </summary>
		protected RMethod r_MPostDispatch;
		public virtual RMethod RMPostDispatch
		{
			get
			{
				if(r_MPostDispatch == null)
				{
					r_MPostDispatch = new(this, "PostDispatch", 0);
					r_MPostDispatch.SetBelong(this.instance);
				}
				return r_MPostDispatch;
			}
		}

		/// <summary>
		/// Void PostDispatch(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MPostDispatch_IPanel;
		public virtual RMethod RMPostDispatch_IPanel
		{
			get
			{
				if(r_MPostDispatch_IPanel == null)
				{
					r_MPostDispatch_IPanel = new(this, "PostDispatch", 0, typeof(UnityEngine.UIElements.IPanel));
					r_MPostDispatch_IPanel.SetBelong(this.instance);
				}
				return r_MPostDispatch_IPanel;
			}
		}

		/// <summary>
		/// Boolean Skip(UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MSkip_IEventHandler;
		public virtual RMethod RMSkip_IEventHandler
		{
			get
			{
				if(r_MSkip_IEventHandler == null)
				{
					r_MSkip_IEventHandler = new(this, "Skip", 0, typeof(UnityEngine.UIElements.IEventHandler));
					r_MSkip_IEventHandler.SetBelong(this.instance);
				}
				return r_MSkip_IEventHandler;
			}
		}

		/// <summary>
		/// Void StopPropagation()
		/// </summary>
		protected RMethod r_MStopPropagation;
		public virtual RMethod RMStopPropagation
		{
			get
			{
				if(r_MStopPropagation == null)
				{
					r_MStopPropagation = new(this, "StopPropagation", 0);
					r_MStopPropagation.SetBelong(this.instance);
				}
				return r_MStopPropagation;
			}
		}

		/// <summary>
		/// Void StopImmediatePropagation()
		/// </summary>
		protected RMethod r_MStopImmediatePropagation;
		public virtual RMethod RMStopImmediatePropagation
		{
			get
			{
				if(r_MStopImmediatePropagation == null)
				{
					r_MStopImmediatePropagation = new(this, "StopImmediatePropagation", 0);
					r_MStopImmediatePropagation.SetBelong(this.instance);
				}
				return r_MStopImmediatePropagation;
			}
		}

		/// <summary>
		/// Void PreventDefault()
		/// </summary>
		protected RMethod r_MPreventDefault;
		public virtual RMethod RMPreventDefault
		{
			get
			{
				if(r_MPreventDefault == null)
				{
					r_MPreventDefault = new(this, "PreventDefault", 0);
					r_MPreventDefault.SetBelong(this.instance);
				}
				return r_MPreventDefault;
			}
		}

		/// <summary>
		/// Void MarkReceivedByDispatcher()
		/// </summary>
		protected RMethod r_MMarkReceivedByDispatcher;
		public virtual RMethod RMMarkReceivedByDispatcher
		{
			get
			{
				if(r_MMarkReceivedByDispatcher == null)
				{
					r_MMarkReceivedByDispatcher = new(this, "MarkReceivedByDispatcher", 0);
					r_MMarkReceivedByDispatcher.SetBelong(this.instance);
				}
				return r_MMarkReceivedByDispatcher;
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


        public RTooltipEvent() : base("UnityEngine.UIElements.TooltipEvent")
        {
        }

        public RTooltipEvent(System.Object instance) : base("UnityEngine.UIElements.TooltipEvent")
		{
            SetInstance(instance);
		}

        public RTooltipEvent(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTooltipEvent(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LocalInit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLocalInit.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.UIElements.TooltipEvent GetPooled(System.String @tooltip, UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tooltip, @rect};
            var ___result = RMGetPooled_String_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TooltipEvent)___result;
        }


        public virtual void Acquire()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAcquire.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriggerEventId(System.UInt64 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RMSetTriggerEventId_UInt64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreDispatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPreDispatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreDispatch(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMPreDispatch_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PostDispatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPostDispatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PostDispatch(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMPostDispatch_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Skip(UnityEngine.UIElements.IEventHandler @h)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@h};
            var ___result = RMSkip_IEventHandler.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void StopPropagation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStopPropagation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopImmediatePropagation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStopImmediatePropagation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreventDefault()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPreventDefault.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkReceivedByDispatcher()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkReceivedByDispatcher.Invoke(___genericsType, ___parameters);

            
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
