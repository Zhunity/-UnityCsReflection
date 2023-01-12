using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.PointerOutEvent
	/// </summary>
    public partial class RPointerOutEvent : RMember //
    {

		/// <summary>
		/// Int32 pointerId
		/// </summary>
		protected RSystem.RInt32 r_PpointerId;
		public virtual RSystem.RInt32 RPpointerId
		{
			get
			{
				if(r_PpointerId == null)
				{
					r_PpointerId = new(this, "pointerId", -1);
					r_PpointerId.SetBelong(this.instance);
				}
				return r_PpointerId;
			}
		}

		/// <summary>
		/// System.String pointerType
		/// </summary>
		protected RSystem.RString r_PpointerType;
		public virtual RSystem.RString RPpointerType
		{
			get
			{
				if(r_PpointerType == null)
				{
					r_PpointerType = new(this, "pointerType", -1);
					r_PpointerType.SetBelong(this.instance);
				}
				return r_PpointerType;
			}
		}

		/// <summary>
		/// Boolean isPrimary
		/// </summary>
		protected RSystem.RBoolean r_PisPrimary;
		public virtual RSystem.RBoolean RPisPrimary
		{
			get
			{
				if(r_PisPrimary == null)
				{
					r_PisPrimary = new(this, "isPrimary", -1);
					r_PisPrimary.SetBelong(this.instance);
				}
				return r_PisPrimary;
			}
		}

		/// <summary>
		/// Int32 button
		/// </summary>
		protected RSystem.RInt32 r_Pbutton;
		public virtual RSystem.RInt32 RPbutton
		{
			get
			{
				if(r_Pbutton == null)
				{
					r_Pbutton = new(this, "button", -1);
					r_Pbutton.SetBelong(this.instance);
				}
				return r_Pbutton;
			}
		}

		/// <summary>
		/// Int32 pressedButtons
		/// </summary>
		protected RSystem.RInt32 r_PpressedButtons;
		public virtual RSystem.RInt32 RPpressedButtons
		{
			get
			{
				if(r_PpressedButtons == null)
				{
					r_PpressedButtons = new(this, "pressedButtons", -1);
					r_PpressedButtons.SetBelong(this.instance);
				}
				return r_PpressedButtons;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 position
		/// </summary>
		protected RUnityEngine.RVector3 r_Pposition;
		public virtual RUnityEngine.RVector3 RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
					r_Pposition.SetBelong(this.instance);
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 localPosition
		/// </summary>
		protected RUnityEngine.RVector3 r_PlocalPosition;
		public virtual RUnityEngine.RVector3 RPlocalPosition
		{
			get
			{
				if(r_PlocalPosition == null)
				{
					r_PlocalPosition = new(this, "localPosition", -1);
					r_PlocalPosition.SetBelong(this.instance);
				}
				return r_PlocalPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 deltaPosition
		/// </summary>
		protected RUnityEngine.RVector3 r_PdeltaPosition;
		public virtual RUnityEngine.RVector3 RPdeltaPosition
		{
			get
			{
				if(r_PdeltaPosition == null)
				{
					r_PdeltaPosition = new(this, "deltaPosition", -1);
					r_PdeltaPosition.SetBelong(this.instance);
				}
				return r_PdeltaPosition;
			}
		}

		/// <summary>
		/// Single deltaTime
		/// </summary>
		protected RSystem.RSingle r_PdeltaTime;
		public virtual RSystem.RSingle RPdeltaTime
		{
			get
			{
				if(r_PdeltaTime == null)
				{
					r_PdeltaTime = new(this, "deltaTime", -1);
					r_PdeltaTime.SetBelong(this.instance);
				}
				return r_PdeltaTime;
			}
		}

		/// <summary>
		/// Int32 clickCount
		/// </summary>
		protected RSystem.RInt32 r_PclickCount;
		public virtual RSystem.RInt32 RPclickCount
		{
			get
			{
				if(r_PclickCount == null)
				{
					r_PclickCount = new(this, "clickCount", -1);
					r_PclickCount.SetBelong(this.instance);
				}
				return r_PclickCount;
			}
		}

		/// <summary>
		/// Single pressure
		/// </summary>
		protected RSystem.RSingle r_Ppressure;
		public virtual RSystem.RSingle RPpressure
		{
			get
			{
				if(r_Ppressure == null)
				{
					r_Ppressure = new(this, "pressure", -1);
					r_Ppressure.SetBelong(this.instance);
				}
				return r_Ppressure;
			}
		}

		/// <summary>
		/// Single tangentialPressure
		/// </summary>
		protected RSystem.RSingle r_PtangentialPressure;
		public virtual RSystem.RSingle RPtangentialPressure
		{
			get
			{
				if(r_PtangentialPressure == null)
				{
					r_PtangentialPressure = new(this, "tangentialPressure", -1);
					r_PtangentialPressure.SetBelong(this.instance);
				}
				return r_PtangentialPressure;
			}
		}

		/// <summary>
		/// Single altitudeAngle
		/// </summary>
		protected RSystem.RSingle r_PaltitudeAngle;
		public virtual RSystem.RSingle RPaltitudeAngle
		{
			get
			{
				if(r_PaltitudeAngle == null)
				{
					r_PaltitudeAngle = new(this, "altitudeAngle", -1);
					r_PaltitudeAngle.SetBelong(this.instance);
				}
				return r_PaltitudeAngle;
			}
		}

		/// <summary>
		/// Single azimuthAngle
		/// </summary>
		protected RSystem.RSingle r_PazimuthAngle;
		public virtual RSystem.RSingle RPazimuthAngle
		{
			get
			{
				if(r_PazimuthAngle == null)
				{
					r_PazimuthAngle = new(this, "azimuthAngle", -1);
					r_PazimuthAngle.SetBelong(this.instance);
				}
				return r_PazimuthAngle;
			}
		}

		/// <summary>
		/// Single twist
		/// </summary>
		protected RSystem.RSingle r_Ptwist;
		public virtual RSystem.RSingle RPtwist
		{
			get
			{
				if(r_Ptwist == null)
				{
					r_Ptwist = new(this, "twist", -1);
					r_Ptwist.SetBelong(this.instance);
				}
				return r_Ptwist;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 tilt
		/// </summary>
		protected RUnityEngine.RVector2 r_Ptilt;
		public virtual RUnityEngine.RVector2 RPtilt
		{
			get
			{
				if(r_Ptilt == null)
				{
					r_Ptilt = new(this, "tilt", -1);
					r_Ptilt.SetBelong(this.instance);
				}
				return r_Ptilt;
			}
		}

		/// <summary>
		/// UnityEngine.PenStatus penStatus
		/// </summary>
		protected RUnityEngine.RPenStatus r_PpenStatus;
		public virtual RUnityEngine.RPenStatus RPpenStatus
		{
			get
			{
				if(r_PpenStatus == null)
				{
					r_PpenStatus = new(this, "penStatus", -1);
					r_PpenStatus.SetBelong(this.instance);
				}
				return r_PpenStatus;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 radius
		/// </summary>
		protected RUnityEngine.RVector2 r_Pradius;
		public virtual RUnityEngine.RVector2 RPradius
		{
			get
			{
				if(r_Pradius == null)
				{
					r_Pradius = new(this, "radius", -1);
					r_Pradius.SetBelong(this.instance);
				}
				return r_Pradius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 radiusVariance
		/// </summary>
		protected RUnityEngine.RVector2 r_PradiusVariance;
		public virtual RUnityEngine.RVector2 RPradiusVariance
		{
			get
			{
				if(r_PradiusVariance == null)
				{
					r_PradiusVariance = new(this, "radiusVariance", -1);
					r_PradiusVariance.SetBelong(this.instance);
				}
				return r_PradiusVariance;
			}
		}

		/// <summary>
		/// UnityEngine.EventModifiers modifiers
		/// </summary>
		protected RUnityEngine.REventModifiers r_Pmodifiers;
		public virtual RUnityEngine.REventModifiers RPmodifiers
		{
			get
			{
				if(r_Pmodifiers == null)
				{
					r_Pmodifiers = new(this, "modifiers", -1);
					r_Pmodifiers.SetBelong(this.instance);
				}
				return r_Pmodifiers;
			}
		}

		/// <summary>
		/// Boolean shiftKey
		/// </summary>
		protected RSystem.RBoolean r_PshiftKey;
		public virtual RSystem.RBoolean RPshiftKey
		{
			get
			{
				if(r_PshiftKey == null)
				{
					r_PshiftKey = new(this, "shiftKey", -1);
					r_PshiftKey.SetBelong(this.instance);
				}
				return r_PshiftKey;
			}
		}

		/// <summary>
		/// Boolean ctrlKey
		/// </summary>
		protected RSystem.RBoolean r_PctrlKey;
		public virtual RSystem.RBoolean RPctrlKey
		{
			get
			{
				if(r_PctrlKey == null)
				{
					r_PctrlKey = new(this, "ctrlKey", -1);
					r_PctrlKey.SetBelong(this.instance);
				}
				return r_PctrlKey;
			}
		}

		/// <summary>
		/// Boolean commandKey
		/// </summary>
		protected RSystem.RBoolean r_PcommandKey;
		public virtual RSystem.RBoolean RPcommandKey
		{
			get
			{
				if(r_PcommandKey == null)
				{
					r_PcommandKey = new(this, "commandKey", -1);
					r_PcommandKey.SetBelong(this.instance);
				}
				return r_PcommandKey;
			}
		}

		/// <summary>
		/// Boolean altKey
		/// </summary>
		protected RSystem.RBoolean r_PaltKey;
		public virtual RSystem.RBoolean RPaltKey
		{
			get
			{
				if(r_PaltKey == null)
				{
					r_PaltKey = new(this, "altKey", -1);
					r_PaltKey.SetBelong(this.instance);
				}
				return r_PaltKey;
			}
		}

		/// <summary>
		/// Boolean actionKey
		/// </summary>
		protected RSystem.RBoolean r_PactionKey;
		public virtual RSystem.RBoolean RPactionKey
		{
			get
			{
				if(r_PactionKey == null)
				{
					r_PactionKey = new(this, "actionKey", -1);
					r_PactionKey.SetBelong(this.instance);
				}
				return r_PactionKey;
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


        public RPointerOutEvent() : base("UnityEngine.UIElements.PointerOutEvent")
        {
        }

        public RPointerOutEvent(System.Object instance) : base("UnityEngine.UIElements.PointerOutEvent")
		{
            SetInstance(instance);
		}

        public RPointerOutEvent(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPointerOutEvent(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreDispatch(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMPreDispatch_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PostDispatch(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMPostDispatch_IPanel.Invoke(___genericsType, ___parameters);

            
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


        public virtual void PostDispatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPostDispatch.Invoke(___genericsType, ___parameters);

            
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
