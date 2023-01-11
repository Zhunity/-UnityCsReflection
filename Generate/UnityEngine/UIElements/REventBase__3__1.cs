using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.EventBase`1
	/// </summary>
    public partial class REventBase<T> : RMember // where T : UnityEngine.UIElements.EventBase<T>, new()
    {

		/// <summary>
		/// System.Int64 s_TypeId
		/// </summary>
		protected static RSystem.RInt64 r_s_TypeId;
		public static RSystem.RInt64 Rs_TypeId
		{
			get
			{
				if(r_s_TypeId == null)
				{
					r_s_TypeId = new(typeof(UnityEngine.UIElements.EventBase<>), "s_TypeId");
					r_s_TypeId.SetBelong(null);
				}
				return r_s_TypeId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ObjectPool`1[T] s_Pool
		/// </summary>
		protected static RUnityEngine.RUIElements.RObjectPool<RField> r_s_Pool;
		public static RUnityEngine.RUIElements.RObjectPool<RField> Rs_Pool
		{
			get
			{
				if(r_s_Pool == null)
				{
					r_s_Pool = new(typeof(UnityEngine.UIElements.EventBase<>), "s_Pool");
					r_s_Pool.SetBelong(null);
				}
				return r_s_Pool;
			}
		}

		/// <summary>
		/// System.Int32 m_RefCount
		/// </summary>
		protected RSystem.RInt32 r_m_RefCount;
		public virtual RSystem.RInt32 Rm_RefCount
		{
			get
			{
				if(r_m_RefCount == null)
				{
					r_m_RefCount = new(this, "m_RefCount");
					r_m_RefCount.SetBelong(this.instance);
				}
				return r_m_RefCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory EventCategory
		/// </summary>
		protected static RField r_EventCategory;
		public static RField REventCategory
		{
			get
			{
				if(r_EventCategory == null)
				{
					r_EventCategory = new(typeof(UnityEngine.UIElements.EventBase<>), "EventCategory");
					r_EventCategory.SetBelong(null);
				}
				return r_EventCategory;
			}
		}

		/// <summary>
		/// Int64 eventTypeId
		/// </summary>
		protected RSystem.RInt64 r_eventTypeId;
		public virtual RSystem.RInt64 ReventTypeId
		{
			get
			{
				if(r_eventTypeId == null)
				{
					r_eventTypeId = new(this, "eventTypeId", -1);
					r_eventTypeId.SetBelong(this.instance);
				}
				return r_eventTypeId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory eventCategory
		/// </summary>
		protected RProperty r_eventCategory;
		public virtual RProperty ReventCategory
		{
			get
			{
				if(r_eventCategory == null)
				{
					r_eventCategory = new(this, "eventCategory", -1);
					r_eventCategory.SetBelong(this.instance);
				}
				return r_eventCategory;
			}
		}

		/// <summary>
		/// Int64 timestamp
		/// </summary>
		protected RSystem.RInt64 r_timestamp;
		public virtual RSystem.RInt64 Rtimestamp
		{
			get
			{
				if(r_timestamp == null)
				{
					r_timestamp = new(this, "timestamp", -1);
					r_timestamp.SetBelong(this.instance);
				}
				return r_timestamp;
			}
		}

		/// <summary>
		/// UInt64 eventId
		/// </summary>
		protected RSystem.RUInt64 r_eventId;
		public virtual RSystem.RUInt64 ReventId
		{
			get
			{
				if(r_eventId == null)
				{
					r_eventId = new(this, "eventId", -1);
					r_eventId.SetBelong(this.instance);
				}
				return r_eventId;
			}
		}

		/// <summary>
		/// UInt64 triggerEventId
		/// </summary>
		protected RSystem.RUInt64 r_triggerEventId;
		public virtual RSystem.RUInt64 RtriggerEventId
		{
			get
			{
				if(r_triggerEventId == null)
				{
					r_triggerEventId = new(this, "triggerEventId", -1);
					r_triggerEventId.SetBelong(this.instance);
				}
				return r_triggerEventId;
			}
		}

		/// <summary>
		/// EventPropagation propagation
		/// </summary>
		protected RProperty r_propagation;
		public virtual RProperty Rpropagation
		{
			get
			{
				if(r_propagation == null)
				{
					r_propagation = new(this, "propagation", -1);
					r_propagation.SetBelong(this.instance);
				}
				return r_propagation;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPaths path
		/// </summary>
		protected RUnityEngine.RUIElements.RPropagationPaths r_path;
		public virtual RUnityEngine.RUIElements.RPropagationPaths Rpath
		{
			get
			{
				if(r_path == null)
				{
					r_path = new(this, "path", -1);
					r_path.SetBelong(this.instance);
				}
				return r_path;
			}
		}

		/// <summary>
		/// Boolean bubbles
		/// </summary>
		protected RSystem.RBoolean r_bubbles;
		public virtual RSystem.RBoolean Rbubbles
		{
			get
			{
				if(r_bubbles == null)
				{
					r_bubbles = new(this, "bubbles", -1);
					r_bubbles.SetBelong(this.instance);
				}
				return r_bubbles;
			}
		}

		/// <summary>
		/// Boolean tricklesDown
		/// </summary>
		protected RSystem.RBoolean r_tricklesDown;
		public virtual RSystem.RBoolean RtricklesDown
		{
			get
			{
				if(r_tricklesDown == null)
				{
					r_tricklesDown = new(this, "tricklesDown", -1);
					r_tricklesDown.SetBelong(this.instance);
				}
				return r_tricklesDown;
			}
		}

		/// <summary>
		/// Boolean bubblesOrTricklesDown
		/// </summary>
		protected RSystem.RBoolean r_bubblesOrTricklesDown;
		public virtual RSystem.RBoolean RbubblesOrTricklesDown
		{
			get
			{
				if(r_bubblesOrTricklesDown == null)
				{
					r_bubblesOrTricklesDown = new(this, "bubblesOrTricklesDown", -1);
					r_bubblesOrTricklesDown.SetBelong(this.instance);
				}
				return r_bubblesOrTricklesDown;
			}
		}

		/// <summary>
		/// Boolean skipDisabledElements
		/// </summary>
		protected RSystem.RBoolean r_skipDisabledElements;
		public virtual RSystem.RBoolean RskipDisabledElements
		{
			get
			{
				if(r_skipDisabledElements == null)
				{
					r_skipDisabledElements = new(this, "skipDisabledElements", -1);
					r_skipDisabledElements.SetBelong(this.instance);
				}
				return r_skipDisabledElements;
			}
		}

		/// <summary>
		/// Boolean ignoreCompositeRoots
		/// </summary>
		protected RSystem.RBoolean r_ignoreCompositeRoots;
		public virtual RSystem.RBoolean RignoreCompositeRoots
		{
			get
			{
				if(r_ignoreCompositeRoots == null)
				{
					r_ignoreCompositeRoots = new(this, "ignoreCompositeRoots", -1);
					r_ignoreCompositeRoots.SetBelong(this.instance);
				}
				return r_ignoreCompositeRoots;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler leafTarget
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_leafTarget;
		public virtual RUnityEngine.RUIElements.RIEventHandler RleafTarget
		{
			get
			{
				if(r_leafTarget == null)
				{
					r_leafTarget = new(this, "leafTarget", -1);
					r_leafTarget.SetBelong(this.instance);
				}
				return r_leafTarget;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler target
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_target;
		public virtual RUnityEngine.RUIElements.RIEventHandler Rtarget
		{
			get
			{
				if(r_target == null)
				{
					r_target = new(this, "target", -1);
					r_target.SetBelong(this.instance);
				}
				return r_target;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.IEventHandler] skipElements
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RIEventHandler> r_skipElements;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RIEventHandler> RskipElements
		{
			get
			{
				if(r_skipElements == null)
				{
					r_skipElements = new(this, "skipElements", -1);
					r_skipElements.SetBelong(this.instance);
				}
				return r_skipElements;
			}
		}

		/// <summary>
		/// Boolean isPropagationStopped
		/// </summary>
		protected RSystem.RBoolean r_isPropagationStopped;
		public virtual RSystem.RBoolean RisPropagationStopped
		{
			get
			{
				if(r_isPropagationStopped == null)
				{
					r_isPropagationStopped = new(this, "isPropagationStopped", -1);
					r_isPropagationStopped.SetBelong(this.instance);
				}
				return r_isPropagationStopped;
			}
		}

		/// <summary>
		/// Boolean isImmediatePropagationStopped
		/// </summary>
		protected RSystem.RBoolean r_isImmediatePropagationStopped;
		public virtual RSystem.RBoolean RisImmediatePropagationStopped
		{
			get
			{
				if(r_isImmediatePropagationStopped == null)
				{
					r_isImmediatePropagationStopped = new(this, "isImmediatePropagationStopped", -1);
					r_isImmediatePropagationStopped.SetBelong(this.instance);
				}
				return r_isImmediatePropagationStopped;
			}
		}

		/// <summary>
		/// Boolean isDefaultPrevented
		/// </summary>
		protected RSystem.RBoolean r_isDefaultPrevented;
		public virtual RSystem.RBoolean RisDefaultPrevented
		{
			get
			{
				if(r_isDefaultPrevented == null)
				{
					r_isDefaultPrevented = new(this, "isDefaultPrevented", -1);
					r_isDefaultPrevented.SetBelong(this.instance);
				}
				return r_isDefaultPrevented;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPhase propagationPhase
		/// </summary>
		protected RProperty r_propagationPhase;
		public virtual RProperty RpropagationPhase
		{
			get
			{
				if(r_propagationPhase == null)
				{
					r_propagationPhase = new(this, "propagationPhase", -1);
					r_propagationPhase.SetBelong(this.instance);
				}
				return r_propagationPhase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler currentTarget
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_currentTarget;
		public virtual RUnityEngine.RUIElements.RIEventHandler RcurrentTarget
		{
			get
			{
				if(r_currentTarget == null)
				{
					r_currentTarget = new(this, "currentTarget", -1);
					r_currentTarget.SetBelong(this.instance);
				}
				return r_currentTarget;
			}
		}

		/// <summary>
		/// Boolean dispatch
		/// </summary>
		protected RSystem.RBoolean r_dispatch;
		public virtual RSystem.RBoolean Rdispatch
		{
			get
			{
				if(r_dispatch == null)
				{
					r_dispatch = new(this, "dispatch", -1);
					r_dispatch.SetBelong(this.instance);
				}
				return r_dispatch;
			}
		}

		/// <summary>
		/// Boolean processed
		/// </summary>
		protected RSystem.RBoolean r_processed;
		public virtual RSystem.RBoolean Rprocessed
		{
			get
			{
				if(r_processed == null)
				{
					r_processed = new(this, "processed", -1);
					r_processed.SetBelong(this.instance);
				}
				return r_processed;
			}
		}

		/// <summary>
		/// Boolean processedByFocusController
		/// </summary>
		protected RSystem.RBoolean r_processedByFocusController;
		public virtual RSystem.RBoolean RprocessedByFocusController
		{
			get
			{
				if(r_processedByFocusController == null)
				{
					r_processedByFocusController = new(this, "processedByFocusController", -1);
					r_processedByFocusController.SetBelong(this.instance);
				}
				return r_processedByFocusController;
			}
		}

		/// <summary>
		/// Boolean stopDispatch
		/// </summary>
		protected RSystem.RBoolean r_stopDispatch;
		public virtual RSystem.RBoolean RstopDispatch
		{
			get
			{
				if(r_stopDispatch == null)
				{
					r_stopDispatch = new(this, "stopDispatch", -1);
					r_stopDispatch.SetBelong(this.instance);
				}
				return r_stopDispatch;
			}
		}

		/// <summary>
		/// Boolean propagateToIMGUI
		/// </summary>
		protected RSystem.RBoolean r_propagateToIMGUI;
		public virtual RSystem.RBoolean RpropagateToIMGUI
		{
			get
			{
				if(r_propagateToIMGUI == null)
				{
					r_propagateToIMGUI = new(this, "propagateToIMGUI", -1);
					r_propagateToIMGUI.SetBelong(this.instance);
				}
				return r_propagateToIMGUI;
			}
		}

		/// <summary>
		/// UnityEngine.Event imguiEvent
		/// </summary>
		protected RUnityEngine.REvent r_imguiEvent;
		public virtual RUnityEngine.REvent RimguiEvent
		{
			get
			{
				if(r_imguiEvent == null)
				{
					r_imguiEvent = new(this, "imguiEvent", -1);
					r_imguiEvent.SetBelong(this.instance);
				}
				return r_imguiEvent;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 originalMousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_originalMousePosition;
		public virtual RUnityEngine.RVector2 RoriginalMousePosition
		{
			get
			{
				if(r_originalMousePosition == null)
				{
					r_originalMousePosition = new(this, "originalMousePosition", -1);
					r_originalMousePosition.SetBelong(this.instance);
				}
				return r_originalMousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDebugger eventLogger
		/// </summary>
		protected RUnityEngine.RUIElements.REventDebugger r_eventLogger;
		public virtual RUnityEngine.RUIElements.REventDebugger ReventLogger
		{
			get
			{
				if(r_eventLogger == null)
				{
					r_eventLogger = new(this, "eventLogger", -1);
					r_eventLogger.SetBelong(this.instance);
				}
				return r_eventLogger;
			}
		}

		/// <summary>
		/// Boolean log
		/// </summary>
		protected RSystem.RBoolean r_log;
		public virtual RSystem.RBoolean Rlog
		{
			get
			{
				if(r_log == null)
				{
					r_log = new(this, "log", -1);
					r_log.SetBelong(this.instance);
				}
				return r_log;
			}
		}

		/// <summary>
		/// Boolean pooled
		/// </summary>
		protected RSystem.RBoolean r_pooled;
		public virtual RSystem.RBoolean Rpooled
		{
			get
			{
				if(r_pooled == null)
				{
					r_pooled = new(this, "pooled", -1);
					r_pooled.SetBelong(this.instance);
				}
				return r_pooled;
			}
		}

		/// <summary>
		/// Void SetCreateFunction(System.Func`1[T])
		/// </summary>
		protected static RMethod r_SetCreateFunction_Func_d_T_p_;
		public static RMethod RSetCreateFunction_Func_d_T_p_
		{
			get
			{
				if(r_SetCreateFunction_Func_d_T_p_ == null)
				{
					r_SetCreateFunction_Func_d_T_p_ = new(typeof(UnityEngine.UIElements.EventBase<>), "SetCreateFunction", 0, typeof(System.Func<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_SetCreateFunction_Func_d_T_p_.SetBelong(null);
				}
				return r_SetCreateFunction_Func_d_T_p_;
			}
		}

		/// <summary>
		/// Int64 TypeId()
		/// </summary>
		protected static RMethod r_TypeId;
		public static RMethod RTypeId
		{
			get
			{
				if(r_TypeId == null)
				{
					r_TypeId = new(typeof(UnityEngine.UIElements.EventBase<>), "TypeId", 0);
					r_TypeId.SetBelong(null);
				}
				return r_TypeId;
			}
		}

		/// <summary>
		/// Void Init()
		/// </summary>
		protected RMethod r_Init;
		public virtual RMethod RInit
		{
			get
			{
				if(r_Init == null)
				{
					r_Init = new(this, "Init", 0);
					r_Init.SetBelong(this.instance);
				}
				return r_Init;
			}
		}

		/// <summary>
		/// T GetPooled()
		/// </summary>
		protected static RMethod r_GetPooled;
		public static RMethod RGetPooled
		{
			get
			{
				if(r_GetPooled == null)
				{
					r_GetPooled = new(typeof(UnityEngine.UIElements.EventBase<>), "GetPooled", 0);
					r_GetPooled.SetBelong(null);
				}
				return r_GetPooled;
			}
		}

		/// <summary>
		/// T GetPooled(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected static RMethod r_GetPooled_EventBase;
		public static RMethod RGetPooled_EventBase
		{
			get
			{
				if(r_GetPooled_EventBase == null)
				{
					r_GetPooled_EventBase = new(typeof(UnityEngine.UIElements.EventBase<>), "GetPooled", 0, typeof(UnityEngine.UIElements.EventBase));
					r_GetPooled_EventBase.SetBelong(null);
				}
				return r_GetPooled_EventBase;
			}
		}

		/// <summary>
		/// Void ReleasePooled(T)
		/// </summary>
		protected static RMethod r_ReleasePooled_T;
		public static RMethod RReleasePooled_T
		{
			get
			{
				if(r_ReleasePooled_T == null)
				{
					r_ReleasePooled_T = new(typeof(UnityEngine.UIElements.EventBase<>), "ReleasePooled", 0, Type.MakeGenericMethodParameter(0));
					r_ReleasePooled_T.SetBelong(null);
				}
				return r_ReleasePooled_T;
			}
		}

		/// <summary>
		/// Void Acquire()
		/// </summary>
		protected RMethod r_Acquire;
		public virtual RMethod RAcquire
		{
			get
			{
				if(r_Acquire == null)
				{
					r_Acquire = new(this, "Acquire", 0);
					r_Acquire.SetBelong(this.instance);
				}
				return r_Acquire;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void SetTriggerEventId(UInt64)
		/// </summary>
		protected RMethod r_SetTriggerEventId_UInt64;
		public virtual RMethod RSetTriggerEventId_UInt64
		{
			get
			{
				if(r_SetTriggerEventId_UInt64 == null)
				{
					r_SetTriggerEventId_UInt64 = new(this, "SetTriggerEventId", 0, typeof(System.UInt64));
					r_SetTriggerEventId_UInt64.SetBelong(this.instance);
				}
				return r_SetTriggerEventId_UInt64;
			}
		}

		/// <summary>
		/// Void PreDispatch()
		/// </summary>
		protected RMethod r_PreDispatch;
		public virtual RMethod RPreDispatch
		{
			get
			{
				if(r_PreDispatch == null)
				{
					r_PreDispatch = new(this, "PreDispatch", 0);
					r_PreDispatch.SetBelong(this.instance);
				}
				return r_PreDispatch;
			}
		}

		/// <summary>
		/// Void PreDispatch(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_PreDispatch_IPanel;
		public virtual RMethod RPreDispatch_IPanel
		{
			get
			{
				if(r_PreDispatch_IPanel == null)
				{
					r_PreDispatch_IPanel = new(this, "PreDispatch", 0, typeof(UnityEngine.UIElements.IPanel));
					r_PreDispatch_IPanel.SetBelong(this.instance);
				}
				return r_PreDispatch_IPanel;
			}
		}

		/// <summary>
		/// Void PostDispatch()
		/// </summary>
		protected RMethod r_PostDispatch;
		public virtual RMethod RPostDispatch
		{
			get
			{
				if(r_PostDispatch == null)
				{
					r_PostDispatch = new(this, "PostDispatch", 0);
					r_PostDispatch.SetBelong(this.instance);
				}
				return r_PostDispatch;
			}
		}

		/// <summary>
		/// Void PostDispatch(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_PostDispatch_IPanel;
		public virtual RMethod RPostDispatch_IPanel
		{
			get
			{
				if(r_PostDispatch_IPanel == null)
				{
					r_PostDispatch_IPanel = new(this, "PostDispatch", 0, typeof(UnityEngine.UIElements.IPanel));
					r_PostDispatch_IPanel.SetBelong(this.instance);
				}
				return r_PostDispatch_IPanel;
			}
		}

		/// <summary>
		/// Boolean Skip(UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_Skip_IEventHandler;
		public virtual RMethod RSkip_IEventHandler
		{
			get
			{
				if(r_Skip_IEventHandler == null)
				{
					r_Skip_IEventHandler = new(this, "Skip", 0, typeof(UnityEngine.UIElements.IEventHandler));
					r_Skip_IEventHandler.SetBelong(this.instance);
				}
				return r_Skip_IEventHandler;
			}
		}

		/// <summary>
		/// Void StopPropagation()
		/// </summary>
		protected RMethod r_StopPropagation;
		public virtual RMethod RStopPropagation
		{
			get
			{
				if(r_StopPropagation == null)
				{
					r_StopPropagation = new(this, "StopPropagation", 0);
					r_StopPropagation.SetBelong(this.instance);
				}
				return r_StopPropagation;
			}
		}

		/// <summary>
		/// Void StopImmediatePropagation()
		/// </summary>
		protected RMethod r_StopImmediatePropagation;
		public virtual RMethod RStopImmediatePropagation
		{
			get
			{
				if(r_StopImmediatePropagation == null)
				{
					r_StopImmediatePropagation = new(this, "StopImmediatePropagation", 0);
					r_StopImmediatePropagation.SetBelong(this.instance);
				}
				return r_StopImmediatePropagation;
			}
		}

		/// <summary>
		/// Void PreventDefault()
		/// </summary>
		protected RMethod r_PreventDefault;
		public virtual RMethod RPreventDefault
		{
			get
			{
				if(r_PreventDefault == null)
				{
					r_PreventDefault = new(this, "PreventDefault", 0);
					r_PreventDefault.SetBelong(this.instance);
				}
				return r_PreventDefault;
			}
		}

		/// <summary>
		/// Void MarkReceivedByDispatcher()
		/// </summary>
		protected RMethod r_MarkReceivedByDispatcher;
		public virtual RMethod RMarkReceivedByDispatcher
		{
			get
			{
				if(r_MarkReceivedByDispatcher == null)
				{
					r_MarkReceivedByDispatcher = new(this, "MarkReceivedByDispatcher", 0);
					r_MarkReceivedByDispatcher.SetBelong(this.instance);
				}
				return r_MarkReceivedByDispatcher;
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


        public REventBase() : base("UnityEngine.UIElements.EventBase`1")
        {
        }

        public REventBase(System.Object instance) : base("UnityEngine.UIElements.EventBase`1")
		{
            SetInstance(instance);
		}

        public REventBase(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventBase(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void SetCreateFunction(System.Func<T> @createMethod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@createMethod};
            var ___result = RSetCreateFunction_Func_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int64 TypeId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTypeId.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            
        }


        public static T GetPooled()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPooled.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetPooled(UnityEngine.UIElements.EventBase @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RGetPooled_EventBase.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static void ReleasePooled(T @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RReleasePooled_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Acquire()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAcquire.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriggerEventId(System.UInt64 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSetTriggerEventId_UInt64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreDispatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPreDispatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreDispatch(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RPreDispatch_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PostDispatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPostDispatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PostDispatch(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RPostDispatch_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Skip(UnityEngine.UIElements.IEventHandler @h)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@h};
            var ___result = RSkip_IEventHandler.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void StopPropagation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopPropagation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopImmediatePropagation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopImmediatePropagation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreventDefault()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPreventDefault.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkReceivedByDispatcher()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkReceivedByDispatcher.Invoke(___genericsType, ___parameters);

            
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
