using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RYoga
{
	/// <summary>
	/// UnityEngine.Yoga.YogaNode
	/// </summary>
    public partial class RYogaNode : RMember //
    {

		/// <summary>
		/// System.IntPtr _ygNode
		/// </summary>
		protected RSystem.RIntPtr r_F_ygNode;
		public virtual RSystem.RIntPtr RF_ygNode
		{
			get
			{
				if(r_F_ygNode == null)
				{
					r_F_ygNode = new(this, "_ygNode");
					r_F_ygNode.SetBelong(this.instance);
				}
				return r_F_ygNode;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaConfig _config
		/// </summary>
		protected RUnityEngine.RYoga.RYogaConfig r_F_config;
		public virtual RUnityEngine.RYoga.RYogaConfig RF_config
		{
			get
			{
				if(r_F_config == null)
				{
					r_F_config = new(this, "_config");
					r_F_config.SetBelong(this.instance);
				}
				return r_F_config;
			}
		}

		/// <summary>
		/// System.WeakReference _parent
		/// </summary>
		protected RSystem.RWeakReference r_F_parent;
		public virtual RSystem.RWeakReference RF_parent
		{
			get
			{
				if(r_F_parent == null)
				{
					r_F_parent = new(this, "_parent");
					r_F_parent.SetBelong(this.instance);
				}
				return r_F_parent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Yoga.YogaNode] _children
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RYoga.RYogaNode> r_F_children;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RYoga.RYogaNode> RF_children
		{
			get
			{
				if(r_F_children == null)
				{
					r_F_children = new(this, "_children");
					r_F_children.SetBelong(this.instance);
				}
				return r_F_children;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.MeasureFunction _measureFunction
		/// </summary>
		protected RUnityEngine.RYoga.RMeasureFunction r_F_measureFunction;
		public virtual RUnityEngine.RYoga.RMeasureFunction RF_measureFunction
		{
			get
			{
				if(r_F_measureFunction == null)
				{
					r_F_measureFunction = new(this, "_measureFunction");
					r_F_measureFunction.SetBelong(this.instance);
				}
				return r_F_measureFunction;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.BaselineFunction _baselineFunction
		/// </summary>
		protected RUnityEngine.RYoga.RBaselineFunction r_F_baselineFunction;
		public virtual RUnityEngine.RYoga.RBaselineFunction RF_baselineFunction
		{
			get
			{
				if(r_F_baselineFunction == null)
				{
					r_F_baselineFunction = new(this, "_baselineFunction");
					r_F_baselineFunction.SetBelong(this.instance);
				}
				return r_F_baselineFunction;
			}
		}

		/// <summary>
		/// System.Object _data
		/// </summary>
		protected RSystem.RObject r_F_data;
		public virtual RSystem.RObject RF_data
		{
			get
			{
				if(r_F_data == null)
				{
					r_F_data = new(this, "_data");
					r_F_data.SetBelong(this.instance);
				}
				return r_F_data;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaConfig Config
		/// </summary>
		protected RUnityEngine.RYoga.RYogaConfig r_PConfig;
		public virtual RUnityEngine.RYoga.RYogaConfig RPConfig
		{
			get
			{
				if(r_PConfig == null)
				{
					r_PConfig = new(this, "Config", -1);
					r_PConfig.SetBelong(this.instance);
				}
				return r_PConfig;
			}
		}

		/// <summary>
		/// Boolean IsDirty
		/// </summary>
		protected RSystem.RBoolean r_PIsDirty;
		public virtual RSystem.RBoolean RPIsDirty
		{
			get
			{
				if(r_PIsDirty == null)
				{
					r_PIsDirty = new(this, "IsDirty", -1);
					r_PIsDirty.SetBelong(this.instance);
				}
				return r_PIsDirty;
			}
		}

		/// <summary>
		/// Boolean HasNewLayout
		/// </summary>
		protected RSystem.RBoolean r_PHasNewLayout;
		public virtual RSystem.RBoolean RPHasNewLayout
		{
			get
			{
				if(r_PHasNewLayout == null)
				{
					r_PHasNewLayout = new(this, "HasNewLayout", -1);
					r_PHasNewLayout.SetBelong(this.instance);
				}
				return r_PHasNewLayout;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode Parent
		/// </summary>
		protected RUnityEngine.RYoga.RYogaNode r_PParent;
		public virtual RUnityEngine.RYoga.RYogaNode RPParent
		{
			get
			{
				if(r_PParent == null)
				{
					r_PParent = new(this, "Parent", -1);
					r_PParent.SetBelong(this.instance);
				}
				return r_PParent;
			}
		}

		/// <summary>
		/// Boolean IsMeasureDefined
		/// </summary>
		protected RSystem.RBoolean r_PIsMeasureDefined;
		public virtual RSystem.RBoolean RPIsMeasureDefined
		{
			get
			{
				if(r_PIsMeasureDefined == null)
				{
					r_PIsMeasureDefined = new(this, "IsMeasureDefined", -1);
					r_PIsMeasureDefined.SetBelong(this.instance);
				}
				return r_PIsMeasureDefined;
			}
		}

		/// <summary>
		/// Boolean IsBaselineDefined
		/// </summary>
		protected RSystem.RBoolean r_PIsBaselineDefined;
		public virtual RSystem.RBoolean RPIsBaselineDefined
		{
			get
			{
				if(r_PIsBaselineDefined == null)
				{
					r_PIsBaselineDefined = new(this, "IsBaselineDefined", -1);
					r_PIsBaselineDefined.SetBelong(this.instance);
				}
				return r_PIsBaselineDefined;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaDirection StyleDirection
		/// </summary>
		protected RUnityEngine.RYoga.RYogaDirection r_PStyleDirection;
		public virtual RUnityEngine.RYoga.RYogaDirection RPStyleDirection
		{
			get
			{
				if(r_PStyleDirection == null)
				{
					r_PStyleDirection = new(this, "StyleDirection", -1);
					r_PStyleDirection.SetBelong(this.instance);
				}
				return r_PStyleDirection;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaFlexDirection FlexDirection
		/// </summary>
		protected RUnityEngine.RYoga.RYogaFlexDirection r_PFlexDirection;
		public virtual RUnityEngine.RYoga.RYogaFlexDirection RPFlexDirection
		{
			get
			{
				if(r_PFlexDirection == null)
				{
					r_PFlexDirection = new(this, "FlexDirection", -1);
					r_PFlexDirection.SetBelong(this.instance);
				}
				return r_PFlexDirection;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaJustify JustifyContent
		/// </summary>
		protected RUnityEngine.RYoga.RYogaJustify r_PJustifyContent;
		public virtual RUnityEngine.RYoga.RYogaJustify RPJustifyContent
		{
			get
			{
				if(r_PJustifyContent == null)
				{
					r_PJustifyContent = new(this, "JustifyContent", -1);
					r_PJustifyContent.SetBelong(this.instance);
				}
				return r_PJustifyContent;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaDisplay Display
		/// </summary>
		protected RUnityEngine.RYoga.RYogaDisplay r_PDisplay;
		public virtual RUnityEngine.RYoga.RYogaDisplay RPDisplay
		{
			get
			{
				if(r_PDisplay == null)
				{
					r_PDisplay = new(this, "Display", -1);
					r_PDisplay.SetBelong(this.instance);
				}
				return r_PDisplay;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaAlign AlignItems
		/// </summary>
		protected RUnityEngine.RYoga.RYogaAlign r_PAlignItems;
		public virtual RUnityEngine.RYoga.RYogaAlign RPAlignItems
		{
			get
			{
				if(r_PAlignItems == null)
				{
					r_PAlignItems = new(this, "AlignItems", -1);
					r_PAlignItems.SetBelong(this.instance);
				}
				return r_PAlignItems;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaAlign AlignSelf
		/// </summary>
		protected RUnityEngine.RYoga.RYogaAlign r_PAlignSelf;
		public virtual RUnityEngine.RYoga.RYogaAlign RPAlignSelf
		{
			get
			{
				if(r_PAlignSelf == null)
				{
					r_PAlignSelf = new(this, "AlignSelf", -1);
					r_PAlignSelf.SetBelong(this.instance);
				}
				return r_PAlignSelf;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaAlign AlignContent
		/// </summary>
		protected RUnityEngine.RYoga.RYogaAlign r_PAlignContent;
		public virtual RUnityEngine.RYoga.RYogaAlign RPAlignContent
		{
			get
			{
				if(r_PAlignContent == null)
				{
					r_PAlignContent = new(this, "AlignContent", -1);
					r_PAlignContent.SetBelong(this.instance);
				}
				return r_PAlignContent;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaPositionType PositionType
		/// </summary>
		protected RUnityEngine.RYoga.RYogaPositionType r_PPositionType;
		public virtual RUnityEngine.RYoga.RYogaPositionType RPPositionType
		{
			get
			{
				if(r_PPositionType == null)
				{
					r_PPositionType = new(this, "PositionType", -1);
					r_PPositionType.SetBelong(this.instance);
				}
				return r_PPositionType;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaWrap Wrap
		/// </summary>
		protected RUnityEngine.RYoga.RYogaWrap r_PWrap;
		public virtual RUnityEngine.RYoga.RYogaWrap RPWrap
		{
			get
			{
				if(r_PWrap == null)
				{
					r_PWrap = new(this, "Wrap", -1);
					r_PWrap.SetBelong(this.instance);
				}
				return r_PWrap;
			}
		}

		/// <summary>
		/// Single Flex
		/// </summary>
		protected RSystem.RSingle r_PFlex;
		public virtual RSystem.RSingle RPFlex
		{
			get
			{
				if(r_PFlex == null)
				{
					r_PFlex = new(this, "Flex", -1);
					r_PFlex.SetBelong(this.instance);
				}
				return r_PFlex;
			}
		}

		/// <summary>
		/// Single FlexGrow
		/// </summary>
		protected RSystem.RSingle r_PFlexGrow;
		public virtual RSystem.RSingle RPFlexGrow
		{
			get
			{
				if(r_PFlexGrow == null)
				{
					r_PFlexGrow = new(this, "FlexGrow", -1);
					r_PFlexGrow.SetBelong(this.instance);
				}
				return r_PFlexGrow;
			}
		}

		/// <summary>
		/// Single FlexShrink
		/// </summary>
		protected RSystem.RSingle r_PFlexShrink;
		public virtual RSystem.RSingle RPFlexShrink
		{
			get
			{
				if(r_PFlexShrink == null)
				{
					r_PFlexShrink = new(this, "FlexShrink", -1);
					r_PFlexShrink.SetBelong(this.instance);
				}
				return r_PFlexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue FlexBasis
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PFlexBasis;
		public virtual RUnityEngine.RYoga.RYogaValue RPFlexBasis
		{
			get
			{
				if(r_PFlexBasis == null)
				{
					r_PFlexBasis = new(this, "FlexBasis", -1);
					r_PFlexBasis.SetBelong(this.instance);
				}
				return r_PFlexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Width
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PWidth;
		public virtual RUnityEngine.RYoga.RYogaValue RPWidth
		{
			get
			{
				if(r_PWidth == null)
				{
					r_PWidth = new(this, "Width", -1);
					r_PWidth.SetBelong(this.instance);
				}
				return r_PWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Height
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PHeight;
		public virtual RUnityEngine.RYoga.RYogaValue RPHeight
		{
			get
			{
				if(r_PHeight == null)
				{
					r_PHeight = new(this, "Height", -1);
					r_PHeight.SetBelong(this.instance);
				}
				return r_PHeight;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MaxWidth
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PMaxWidth;
		public virtual RUnityEngine.RYoga.RYogaValue RPMaxWidth
		{
			get
			{
				if(r_PMaxWidth == null)
				{
					r_PMaxWidth = new(this, "MaxWidth", -1);
					r_PMaxWidth.SetBelong(this.instance);
				}
				return r_PMaxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MaxHeight
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PMaxHeight;
		public virtual RUnityEngine.RYoga.RYogaValue RPMaxHeight
		{
			get
			{
				if(r_PMaxHeight == null)
				{
					r_PMaxHeight = new(this, "MaxHeight", -1);
					r_PMaxHeight.SetBelong(this.instance);
				}
				return r_PMaxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MinWidth
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PMinWidth;
		public virtual RUnityEngine.RYoga.RYogaValue RPMinWidth
		{
			get
			{
				if(r_PMinWidth == null)
				{
					r_PMinWidth = new(this, "MinWidth", -1);
					r_PMinWidth.SetBelong(this.instance);
				}
				return r_PMinWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MinHeight
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PMinHeight;
		public virtual RUnityEngine.RYoga.RYogaValue RPMinHeight
		{
			get
			{
				if(r_PMinHeight == null)
				{
					r_PMinHeight = new(this, "MinHeight", -1);
					r_PMinHeight.SetBelong(this.instance);
				}
				return r_PMinHeight;
			}
		}

		/// <summary>
		/// Single AspectRatio
		/// </summary>
		protected RSystem.RSingle r_PAspectRatio;
		public virtual RSystem.RSingle RPAspectRatio
		{
			get
			{
				if(r_PAspectRatio == null)
				{
					r_PAspectRatio = new(this, "AspectRatio", -1);
					r_PAspectRatio.SetBelong(this.instance);
				}
				return r_PAspectRatio;
			}
		}

		/// <summary>
		/// Single LayoutX
		/// </summary>
		protected RSystem.RSingle r_PLayoutX;
		public virtual RSystem.RSingle RPLayoutX
		{
			get
			{
				if(r_PLayoutX == null)
				{
					r_PLayoutX = new(this, "LayoutX", -1);
					r_PLayoutX.SetBelong(this.instance);
				}
				return r_PLayoutX;
			}
		}

		/// <summary>
		/// Single LayoutY
		/// </summary>
		protected RSystem.RSingle r_PLayoutY;
		public virtual RSystem.RSingle RPLayoutY
		{
			get
			{
				if(r_PLayoutY == null)
				{
					r_PLayoutY = new(this, "LayoutY", -1);
					r_PLayoutY.SetBelong(this.instance);
				}
				return r_PLayoutY;
			}
		}

		/// <summary>
		/// Single LayoutRight
		/// </summary>
		protected RSystem.RSingle r_PLayoutRight;
		public virtual RSystem.RSingle RPLayoutRight
		{
			get
			{
				if(r_PLayoutRight == null)
				{
					r_PLayoutRight = new(this, "LayoutRight", -1);
					r_PLayoutRight.SetBelong(this.instance);
				}
				return r_PLayoutRight;
			}
		}

		/// <summary>
		/// Single LayoutBottom
		/// </summary>
		protected RSystem.RSingle r_PLayoutBottom;
		public virtual RSystem.RSingle RPLayoutBottom
		{
			get
			{
				if(r_PLayoutBottom == null)
				{
					r_PLayoutBottom = new(this, "LayoutBottom", -1);
					r_PLayoutBottom.SetBelong(this.instance);
				}
				return r_PLayoutBottom;
			}
		}

		/// <summary>
		/// Single LayoutWidth
		/// </summary>
		protected RSystem.RSingle r_PLayoutWidth;
		public virtual RSystem.RSingle RPLayoutWidth
		{
			get
			{
				if(r_PLayoutWidth == null)
				{
					r_PLayoutWidth = new(this, "LayoutWidth", -1);
					r_PLayoutWidth.SetBelong(this.instance);
				}
				return r_PLayoutWidth;
			}
		}

		/// <summary>
		/// Single LayoutHeight
		/// </summary>
		protected RSystem.RSingle r_PLayoutHeight;
		public virtual RSystem.RSingle RPLayoutHeight
		{
			get
			{
				if(r_PLayoutHeight == null)
				{
					r_PLayoutHeight = new(this, "LayoutHeight", -1);
					r_PLayoutHeight.SetBelong(this.instance);
				}
				return r_PLayoutHeight;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaDirection LayoutDirection
		/// </summary>
		protected RUnityEngine.RYoga.RYogaDirection r_PLayoutDirection;
		public virtual RUnityEngine.RYoga.RYogaDirection RPLayoutDirection
		{
			get
			{
				if(r_PLayoutDirection == null)
				{
					r_PLayoutDirection = new(this, "LayoutDirection", -1);
					r_PLayoutDirection.SetBelong(this.instance);
				}
				return r_PLayoutDirection;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaOverflow Overflow
		/// </summary>
		protected RUnityEngine.RYoga.RYogaOverflow r_POverflow;
		public virtual RUnityEngine.RYoga.RYogaOverflow RPOverflow
		{
			get
			{
				if(r_POverflow == null)
				{
					r_POverflow = new(this, "Overflow", -1);
					r_POverflow.SetBelong(this.instance);
				}
				return r_POverflow;
			}
		}

		/// <summary>
		/// System.Object Data
		/// </summary>
		protected RSystem.RObject r_PData;
		public virtual RSystem.RObject RPData
		{
			get
			{
				if(r_PData == null)
				{
					r_PData = new(this, "Data", -1);
					r_PData.SetBelong(this.instance);
				}
				return r_PData;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode Item [Int32]
		/// </summary>
		protected RUnityEngine.RYoga.RYogaNode r_PItem_Int32;
		public virtual RUnityEngine.RYoga.RYogaNode RPItem_Int32
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
		/// Int32 Count
		/// </summary>
		protected RSystem.RInt32 r_PCount;
		public virtual RSystem.RInt32 RPCount
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
		/// UnityEngine.Yoga.YogaValue Left
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PLeft;
		public virtual RUnityEngine.RYoga.RYogaValue RPLeft
		{
			get
			{
				if(r_PLeft == null)
				{
					r_PLeft = new(this, "Left", -1);
					r_PLeft.SetBelong(this.instance);
				}
				return r_PLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Top
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PTop;
		public virtual RUnityEngine.RYoga.RYogaValue RPTop
		{
			get
			{
				if(r_PTop == null)
				{
					r_PTop = new(this, "Top", -1);
					r_PTop.SetBelong(this.instance);
				}
				return r_PTop;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Right
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PRight;
		public virtual RUnityEngine.RYoga.RYogaValue RPRight
		{
			get
			{
				if(r_PRight == null)
				{
					r_PRight = new(this, "Right", -1);
					r_PRight.SetBelong(this.instance);
				}
				return r_PRight;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Bottom
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PBottom;
		public virtual RUnityEngine.RYoga.RYogaValue RPBottom
		{
			get
			{
				if(r_PBottom == null)
				{
					r_PBottom = new(this, "Bottom", -1);
					r_PBottom.SetBelong(this.instance);
				}
				return r_PBottom;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Start
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PStart;
		public virtual RUnityEngine.RYoga.RYogaValue RPStart
		{
			get
			{
				if(r_PStart == null)
				{
					r_PStart = new(this, "Start", -1);
					r_PStart.SetBelong(this.instance);
				}
				return r_PStart;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue End
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PEnd;
		public virtual RUnityEngine.RYoga.RYogaValue RPEnd
		{
			get
			{
				if(r_PEnd == null)
				{
					r_PEnd = new(this, "End", -1);
					r_PEnd.SetBelong(this.instance);
				}
				return r_PEnd;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginLeft
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PMarginLeft;
		public virtual RUnityEngine.RYoga.RYogaValue RPMarginLeft
		{
			get
			{
				if(r_PMarginLeft == null)
				{
					r_PMarginLeft = new(this, "MarginLeft", -1);
					r_PMarginLeft.SetBelong(this.instance);
				}
				return r_PMarginLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginTop
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PMarginTop;
		public virtual RUnityEngine.RYoga.RYogaValue RPMarginTop
		{
			get
			{
				if(r_PMarginTop == null)
				{
					r_PMarginTop = new(this, "MarginTop", -1);
					r_PMarginTop.SetBelong(this.instance);
				}
				return r_PMarginTop;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginRight
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PMarginRight;
		public virtual RUnityEngine.RYoga.RYogaValue RPMarginRight
		{
			get
			{
				if(r_PMarginRight == null)
				{
					r_PMarginRight = new(this, "MarginRight", -1);
					r_PMarginRight.SetBelong(this.instance);
				}
				return r_PMarginRight;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginBottom
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PMarginBottom;
		public virtual RUnityEngine.RYoga.RYogaValue RPMarginBottom
		{
			get
			{
				if(r_PMarginBottom == null)
				{
					r_PMarginBottom = new(this, "MarginBottom", -1);
					r_PMarginBottom.SetBelong(this.instance);
				}
				return r_PMarginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginStart
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PMarginStart;
		public virtual RUnityEngine.RYoga.RYogaValue RPMarginStart
		{
			get
			{
				if(r_PMarginStart == null)
				{
					r_PMarginStart = new(this, "MarginStart", -1);
					r_PMarginStart.SetBelong(this.instance);
				}
				return r_PMarginStart;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginEnd
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PMarginEnd;
		public virtual RUnityEngine.RYoga.RYogaValue RPMarginEnd
		{
			get
			{
				if(r_PMarginEnd == null)
				{
					r_PMarginEnd = new(this, "MarginEnd", -1);
					r_PMarginEnd.SetBelong(this.instance);
				}
				return r_PMarginEnd;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginHorizontal
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PMarginHorizontal;
		public virtual RUnityEngine.RYoga.RYogaValue RPMarginHorizontal
		{
			get
			{
				if(r_PMarginHorizontal == null)
				{
					r_PMarginHorizontal = new(this, "MarginHorizontal", -1);
					r_PMarginHorizontal.SetBelong(this.instance);
				}
				return r_PMarginHorizontal;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginVertical
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PMarginVertical;
		public virtual RUnityEngine.RYoga.RYogaValue RPMarginVertical
		{
			get
			{
				if(r_PMarginVertical == null)
				{
					r_PMarginVertical = new(this, "MarginVertical", -1);
					r_PMarginVertical.SetBelong(this.instance);
				}
				return r_PMarginVertical;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Margin
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PMargin;
		public virtual RUnityEngine.RYoga.RYogaValue RPMargin
		{
			get
			{
				if(r_PMargin == null)
				{
					r_PMargin = new(this, "Margin", -1);
					r_PMargin.SetBelong(this.instance);
				}
				return r_PMargin;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingLeft
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PPaddingLeft;
		public virtual RUnityEngine.RYoga.RYogaValue RPPaddingLeft
		{
			get
			{
				if(r_PPaddingLeft == null)
				{
					r_PPaddingLeft = new(this, "PaddingLeft", -1);
					r_PPaddingLeft.SetBelong(this.instance);
				}
				return r_PPaddingLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingTop
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PPaddingTop;
		public virtual RUnityEngine.RYoga.RYogaValue RPPaddingTop
		{
			get
			{
				if(r_PPaddingTop == null)
				{
					r_PPaddingTop = new(this, "PaddingTop", -1);
					r_PPaddingTop.SetBelong(this.instance);
				}
				return r_PPaddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingRight
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PPaddingRight;
		public virtual RUnityEngine.RYoga.RYogaValue RPPaddingRight
		{
			get
			{
				if(r_PPaddingRight == null)
				{
					r_PPaddingRight = new(this, "PaddingRight", -1);
					r_PPaddingRight.SetBelong(this.instance);
				}
				return r_PPaddingRight;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingBottom
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PPaddingBottom;
		public virtual RUnityEngine.RYoga.RYogaValue RPPaddingBottom
		{
			get
			{
				if(r_PPaddingBottom == null)
				{
					r_PPaddingBottom = new(this, "PaddingBottom", -1);
					r_PPaddingBottom.SetBelong(this.instance);
				}
				return r_PPaddingBottom;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingStart
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PPaddingStart;
		public virtual RUnityEngine.RYoga.RYogaValue RPPaddingStart
		{
			get
			{
				if(r_PPaddingStart == null)
				{
					r_PPaddingStart = new(this, "PaddingStart", -1);
					r_PPaddingStart.SetBelong(this.instance);
				}
				return r_PPaddingStart;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingEnd
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PPaddingEnd;
		public virtual RUnityEngine.RYoga.RYogaValue RPPaddingEnd
		{
			get
			{
				if(r_PPaddingEnd == null)
				{
					r_PPaddingEnd = new(this, "PaddingEnd", -1);
					r_PPaddingEnd.SetBelong(this.instance);
				}
				return r_PPaddingEnd;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingHorizontal
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PPaddingHorizontal;
		public virtual RUnityEngine.RYoga.RYogaValue RPPaddingHorizontal
		{
			get
			{
				if(r_PPaddingHorizontal == null)
				{
					r_PPaddingHorizontal = new(this, "PaddingHorizontal", -1);
					r_PPaddingHorizontal.SetBelong(this.instance);
				}
				return r_PPaddingHorizontal;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingVertical
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PPaddingVertical;
		public virtual RUnityEngine.RYoga.RYogaValue RPPaddingVertical
		{
			get
			{
				if(r_PPaddingVertical == null)
				{
					r_PPaddingVertical = new(this, "PaddingVertical", -1);
					r_PPaddingVertical.SetBelong(this.instance);
				}
				return r_PPaddingVertical;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Padding
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PPadding;
		public virtual RUnityEngine.RYoga.RYogaValue RPPadding
		{
			get
			{
				if(r_PPadding == null)
				{
					r_PPadding = new(this, "Padding", -1);
					r_PPadding.SetBelong(this.instance);
				}
				return r_PPadding;
			}
		}

		/// <summary>
		/// Single BorderLeftWidth
		/// </summary>
		protected RSystem.RSingle r_PBorderLeftWidth;
		public virtual RSystem.RSingle RPBorderLeftWidth
		{
			get
			{
				if(r_PBorderLeftWidth == null)
				{
					r_PBorderLeftWidth = new(this, "BorderLeftWidth", -1);
					r_PBorderLeftWidth.SetBelong(this.instance);
				}
				return r_PBorderLeftWidth;
			}
		}

		/// <summary>
		/// Single BorderTopWidth
		/// </summary>
		protected RSystem.RSingle r_PBorderTopWidth;
		public virtual RSystem.RSingle RPBorderTopWidth
		{
			get
			{
				if(r_PBorderTopWidth == null)
				{
					r_PBorderTopWidth = new(this, "BorderTopWidth", -1);
					r_PBorderTopWidth.SetBelong(this.instance);
				}
				return r_PBorderTopWidth;
			}
		}

		/// <summary>
		/// Single BorderRightWidth
		/// </summary>
		protected RSystem.RSingle r_PBorderRightWidth;
		public virtual RSystem.RSingle RPBorderRightWidth
		{
			get
			{
				if(r_PBorderRightWidth == null)
				{
					r_PBorderRightWidth = new(this, "BorderRightWidth", -1);
					r_PBorderRightWidth.SetBelong(this.instance);
				}
				return r_PBorderRightWidth;
			}
		}

		/// <summary>
		/// Single BorderBottomWidth
		/// </summary>
		protected RSystem.RSingle r_PBorderBottomWidth;
		public virtual RSystem.RSingle RPBorderBottomWidth
		{
			get
			{
				if(r_PBorderBottomWidth == null)
				{
					r_PBorderBottomWidth = new(this, "BorderBottomWidth", -1);
					r_PBorderBottomWidth.SetBelong(this.instance);
				}
				return r_PBorderBottomWidth;
			}
		}

		/// <summary>
		/// Single BorderStartWidth
		/// </summary>
		protected RSystem.RSingle r_PBorderStartWidth;
		public virtual RSystem.RSingle RPBorderStartWidth
		{
			get
			{
				if(r_PBorderStartWidth == null)
				{
					r_PBorderStartWidth = new(this, "BorderStartWidth", -1);
					r_PBorderStartWidth.SetBelong(this.instance);
				}
				return r_PBorderStartWidth;
			}
		}

		/// <summary>
		/// Single BorderEndWidth
		/// </summary>
		protected RSystem.RSingle r_PBorderEndWidth;
		public virtual RSystem.RSingle RPBorderEndWidth
		{
			get
			{
				if(r_PBorderEndWidth == null)
				{
					r_PBorderEndWidth = new(this, "BorderEndWidth", -1);
					r_PBorderEndWidth.SetBelong(this.instance);
				}
				return r_PBorderEndWidth;
			}
		}

		/// <summary>
		/// Single BorderWidth
		/// </summary>
		protected RSystem.RSingle r_PBorderWidth;
		public virtual RSystem.RSingle RPBorderWidth
		{
			get
			{
				if(r_PBorderWidth == null)
				{
					r_PBorderWidth = new(this, "BorderWidth", -1);
					r_PBorderWidth.SetBelong(this.instance);
				}
				return r_PBorderWidth;
			}
		}

		/// <summary>
		/// Single LayoutMarginLeft
		/// </summary>
		protected RSystem.RSingle r_PLayoutMarginLeft;
		public virtual RSystem.RSingle RPLayoutMarginLeft
		{
			get
			{
				if(r_PLayoutMarginLeft == null)
				{
					r_PLayoutMarginLeft = new(this, "LayoutMarginLeft", -1);
					r_PLayoutMarginLeft.SetBelong(this.instance);
				}
				return r_PLayoutMarginLeft;
			}
		}

		/// <summary>
		/// Single LayoutMarginTop
		/// </summary>
		protected RSystem.RSingle r_PLayoutMarginTop;
		public virtual RSystem.RSingle RPLayoutMarginTop
		{
			get
			{
				if(r_PLayoutMarginTop == null)
				{
					r_PLayoutMarginTop = new(this, "LayoutMarginTop", -1);
					r_PLayoutMarginTop.SetBelong(this.instance);
				}
				return r_PLayoutMarginTop;
			}
		}

		/// <summary>
		/// Single LayoutMarginRight
		/// </summary>
		protected RSystem.RSingle r_PLayoutMarginRight;
		public virtual RSystem.RSingle RPLayoutMarginRight
		{
			get
			{
				if(r_PLayoutMarginRight == null)
				{
					r_PLayoutMarginRight = new(this, "LayoutMarginRight", -1);
					r_PLayoutMarginRight.SetBelong(this.instance);
				}
				return r_PLayoutMarginRight;
			}
		}

		/// <summary>
		/// Single LayoutMarginBottom
		/// </summary>
		protected RSystem.RSingle r_PLayoutMarginBottom;
		public virtual RSystem.RSingle RPLayoutMarginBottom
		{
			get
			{
				if(r_PLayoutMarginBottom == null)
				{
					r_PLayoutMarginBottom = new(this, "LayoutMarginBottom", -1);
					r_PLayoutMarginBottom.SetBelong(this.instance);
				}
				return r_PLayoutMarginBottom;
			}
		}

		/// <summary>
		/// Single LayoutMarginStart
		/// </summary>
		protected RSystem.RSingle r_PLayoutMarginStart;
		public virtual RSystem.RSingle RPLayoutMarginStart
		{
			get
			{
				if(r_PLayoutMarginStart == null)
				{
					r_PLayoutMarginStart = new(this, "LayoutMarginStart", -1);
					r_PLayoutMarginStart.SetBelong(this.instance);
				}
				return r_PLayoutMarginStart;
			}
		}

		/// <summary>
		/// Single LayoutMarginEnd
		/// </summary>
		protected RSystem.RSingle r_PLayoutMarginEnd;
		public virtual RSystem.RSingle RPLayoutMarginEnd
		{
			get
			{
				if(r_PLayoutMarginEnd == null)
				{
					r_PLayoutMarginEnd = new(this, "LayoutMarginEnd", -1);
					r_PLayoutMarginEnd.SetBelong(this.instance);
				}
				return r_PLayoutMarginEnd;
			}
		}

		/// <summary>
		/// Single LayoutPaddingLeft
		/// </summary>
		protected RSystem.RSingle r_PLayoutPaddingLeft;
		public virtual RSystem.RSingle RPLayoutPaddingLeft
		{
			get
			{
				if(r_PLayoutPaddingLeft == null)
				{
					r_PLayoutPaddingLeft = new(this, "LayoutPaddingLeft", -1);
					r_PLayoutPaddingLeft.SetBelong(this.instance);
				}
				return r_PLayoutPaddingLeft;
			}
		}

		/// <summary>
		/// Single LayoutPaddingTop
		/// </summary>
		protected RSystem.RSingle r_PLayoutPaddingTop;
		public virtual RSystem.RSingle RPLayoutPaddingTop
		{
			get
			{
				if(r_PLayoutPaddingTop == null)
				{
					r_PLayoutPaddingTop = new(this, "LayoutPaddingTop", -1);
					r_PLayoutPaddingTop.SetBelong(this.instance);
				}
				return r_PLayoutPaddingTop;
			}
		}

		/// <summary>
		/// Single LayoutPaddingRight
		/// </summary>
		protected RSystem.RSingle r_PLayoutPaddingRight;
		public virtual RSystem.RSingle RPLayoutPaddingRight
		{
			get
			{
				if(r_PLayoutPaddingRight == null)
				{
					r_PLayoutPaddingRight = new(this, "LayoutPaddingRight", -1);
					r_PLayoutPaddingRight.SetBelong(this.instance);
				}
				return r_PLayoutPaddingRight;
			}
		}

		/// <summary>
		/// Single LayoutPaddingBottom
		/// </summary>
		protected RSystem.RSingle r_PLayoutPaddingBottom;
		public virtual RSystem.RSingle RPLayoutPaddingBottom
		{
			get
			{
				if(r_PLayoutPaddingBottom == null)
				{
					r_PLayoutPaddingBottom = new(this, "LayoutPaddingBottom", -1);
					r_PLayoutPaddingBottom.SetBelong(this.instance);
				}
				return r_PLayoutPaddingBottom;
			}
		}

		/// <summary>
		/// Single LayoutBorderLeft
		/// </summary>
		protected RSystem.RSingle r_PLayoutBorderLeft;
		public virtual RSystem.RSingle RPLayoutBorderLeft
		{
			get
			{
				if(r_PLayoutBorderLeft == null)
				{
					r_PLayoutBorderLeft = new(this, "LayoutBorderLeft", -1);
					r_PLayoutBorderLeft.SetBelong(this.instance);
				}
				return r_PLayoutBorderLeft;
			}
		}

		/// <summary>
		/// Single LayoutBorderTop
		/// </summary>
		protected RSystem.RSingle r_PLayoutBorderTop;
		public virtual RSystem.RSingle RPLayoutBorderTop
		{
			get
			{
				if(r_PLayoutBorderTop == null)
				{
					r_PLayoutBorderTop = new(this, "LayoutBorderTop", -1);
					r_PLayoutBorderTop.SetBelong(this.instance);
				}
				return r_PLayoutBorderTop;
			}
		}

		/// <summary>
		/// Single LayoutBorderRight
		/// </summary>
		protected RSystem.RSingle r_PLayoutBorderRight;
		public virtual RSystem.RSingle RPLayoutBorderRight
		{
			get
			{
				if(r_PLayoutBorderRight == null)
				{
					r_PLayoutBorderRight = new(this, "LayoutBorderRight", -1);
					r_PLayoutBorderRight.SetBelong(this.instance);
				}
				return r_PLayoutBorderRight;
			}
		}

		/// <summary>
		/// Single LayoutBorderBottom
		/// </summary>
		protected RSystem.RSingle r_PLayoutBorderBottom;
		public virtual RSystem.RSingle RPLayoutBorderBottom
		{
			get
			{
				if(r_PLayoutBorderBottom == null)
				{
					r_PLayoutBorderBottom = new(this, "LayoutBorderBottom", -1);
					r_PLayoutBorderBottom.SetBelong(this.instance);
				}
				return r_PLayoutBorderBottom;
			}
		}

		/// <summary>
		/// Single LayoutPaddingStart
		/// </summary>
		protected RSystem.RSingle r_PLayoutPaddingStart;
		public virtual RSystem.RSingle RPLayoutPaddingStart
		{
			get
			{
				if(r_PLayoutPaddingStart == null)
				{
					r_PLayoutPaddingStart = new(this, "LayoutPaddingStart", -1);
					r_PLayoutPaddingStart.SetBelong(this.instance);
				}
				return r_PLayoutPaddingStart;
			}
		}

		/// <summary>
		/// Single LayoutPaddingEnd
		/// </summary>
		protected RSystem.RSingle r_PLayoutPaddingEnd;
		public virtual RSystem.RSingle RPLayoutPaddingEnd
		{
			get
			{
				if(r_PLayoutPaddingEnd == null)
				{
					r_PLayoutPaddingEnd = new(this, "LayoutPaddingEnd", -1);
					r_PLayoutPaddingEnd.SetBelong(this.instance);
				}
				return r_PLayoutPaddingEnd;
			}
		}

		/// <summary>
		/// Single ComputedFlexBasis
		/// </summary>
		protected RSystem.RSingle r_PComputedFlexBasis;
		public virtual RSystem.RSingle RPComputedFlexBasis
		{
			get
			{
				if(r_PComputedFlexBasis == null)
				{
					r_PComputedFlexBasis = new(this, "ComputedFlexBasis", -1);
					r_PComputedFlexBasis.SetBelong(this.instance);
				}
				return r_PComputedFlexBasis;
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
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
					r_MReset.SetBelong(this.instance);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// Void MarkDirty()
		/// </summary>
		protected RMethod r_MMarkDirty;
		public virtual RMethod RMMarkDirty
		{
			get
			{
				if(r_MMarkDirty == null)
				{
					r_MMarkDirty = new(this, "MarkDirty", 0);
					r_MMarkDirty.SetBelong(this.instance);
				}
				return r_MMarkDirty;
			}
		}

		/// <summary>
		/// Void MarkHasNewLayout()
		/// </summary>
		protected RMethod r_MMarkHasNewLayout;
		public virtual RMethod RMMarkHasNewLayout
		{
			get
			{
				if(r_MMarkHasNewLayout == null)
				{
					r_MMarkHasNewLayout = new(this, "MarkHasNewLayout", 0);
					r_MMarkHasNewLayout.SetBelong(this.instance);
				}
				return r_MMarkHasNewLayout;
			}
		}

		/// <summary>
		/// Void CopyStyle(UnityEngine.Yoga.YogaNode)
		/// </summary>
		protected RMethod r_MCopyStyle_YogaNode;
		public virtual RMethod RMCopyStyle_YogaNode
		{
			get
			{
				if(r_MCopyStyle_YogaNode == null)
				{
					r_MCopyStyle_YogaNode = new(this, "CopyStyle", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"));
					r_MCopyStyle_YogaNode.SetBelong(this.instance);
				}
				return r_MCopyStyle_YogaNode;
			}
		}

		/// <summary>
		/// Void MarkLayoutSeen()
		/// </summary>
		protected RMethod r_MMarkLayoutSeen;
		public virtual RMethod RMMarkLayoutSeen
		{
			get
			{
				if(r_MMarkLayoutSeen == null)
				{
					r_MMarkLayoutSeen = new(this, "MarkLayoutSeen", 0);
					r_MMarkLayoutSeen.SetBelong(this.instance);
				}
				return r_MMarkLayoutSeen;
			}
		}

		/// <summary>
		/// Boolean ValuesEqual(Single, Single)
		/// </summary>
		protected RMethod r_MValuesEqual_Single_Single;
		public virtual RMethod RMValuesEqual_Single_Single
		{
			get
			{
				if(r_MValuesEqual_Single_Single == null)
				{
					r_MValuesEqual_Single_Single = new(this, "ValuesEqual", 0, typeof(System.Single), typeof(System.Single));
					r_MValuesEqual_Single_Single.SetBelong(this.instance);
				}
				return r_MValuesEqual_Single_Single;
			}
		}

		/// <summary>
		/// Void Insert(Int32, UnityEngine.Yoga.YogaNode)
		/// </summary>
		protected RMethod r_MInsert_Int32_YogaNode;
		public virtual RMethod RMInsert_Int32_YogaNode
		{
			get
			{
				if(r_MInsert_Int32_YogaNode == null)
				{
					r_MInsert_Int32_YogaNode = new(this, "Insert", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"));
					r_MInsert_Int32_YogaNode.SetBelong(this.instance);
				}
				return r_MInsert_Int32_YogaNode;
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
		/// Void AddChild(UnityEngine.Yoga.YogaNode)
		/// </summary>
		protected RMethod r_MAddChild_YogaNode;
		public virtual RMethod RMAddChild_YogaNode
		{
			get
			{
				if(r_MAddChild_YogaNode == null)
				{
					r_MAddChild_YogaNode = new(this, "AddChild", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"));
					r_MAddChild_YogaNode.SetBelong(this.instance);
				}
				return r_MAddChild_YogaNode;
			}
		}

		/// <summary>
		/// Void RemoveChild(UnityEngine.Yoga.YogaNode)
		/// </summary>
		protected RMethod r_MRemoveChild_YogaNode;
		public virtual RMethod RMRemoveChild_YogaNode
		{
			get
			{
				if(r_MRemoveChild_YogaNode == null)
				{
					r_MRemoveChild_YogaNode = new(this, "RemoveChild", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"));
					r_MRemoveChild_YogaNode.SetBelong(this.instance);
				}
				return r_MRemoveChild_YogaNode;
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
		/// Int32 IndexOf(UnityEngine.Yoga.YogaNode)
		/// </summary>
		protected RMethod r_MIndexOf_YogaNode;
		public virtual RMethod RMIndexOf_YogaNode
		{
			get
			{
				if(r_MIndexOf_YogaNode == null)
				{
					r_MIndexOf_YogaNode = new(this, "IndexOf", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"));
					r_MIndexOf_YogaNode.SetBelong(this.instance);
				}
				return r_MIndexOf_YogaNode;
			}
		}

		/// <summary>
		/// Void SetMeasureFunction(UnityEngine.Yoga.MeasureFunction)
		/// </summary>
		protected RMethod r_MSetMeasureFunction_MeasureFunction;
		public virtual RMethod RMSetMeasureFunction_MeasureFunction
		{
			get
			{
				if(r_MSetMeasureFunction_MeasureFunction == null)
				{
					r_MSetMeasureFunction_MeasureFunction = new(this, "SetMeasureFunction", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.MeasureFunction"));
					r_MSetMeasureFunction_MeasureFunction.SetBelong(this.instance);
				}
				return r_MSetMeasureFunction_MeasureFunction;
			}
		}

		/// <summary>
		/// Void SetBaselineFunction(UnityEngine.Yoga.BaselineFunction)
		/// </summary>
		protected RMethod r_MSetBaselineFunction_BaselineFunction;
		public virtual RMethod RMSetBaselineFunction_BaselineFunction
		{
			get
			{
				if(r_MSetBaselineFunction_BaselineFunction == null)
				{
					r_MSetBaselineFunction_BaselineFunction = new(this, "SetBaselineFunction", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.BaselineFunction"));
					r_MSetBaselineFunction_BaselineFunction.SetBelong(this.instance);
				}
				return r_MSetBaselineFunction_BaselineFunction;
			}
		}

		/// <summary>
		/// Void CalculateLayout(Single, Single)
		/// </summary>
		protected RMethod r_MCalculateLayout_Single_Single;
		public virtual RMethod RMCalculateLayout_Single_Single
		{
			get
			{
				if(r_MCalculateLayout_Single_Single == null)
				{
					r_MCalculateLayout_Single_Single = new(this, "CalculateLayout", 0, typeof(System.Single), typeof(System.Single));
					r_MCalculateLayout_Single_Single.SetBelong(this.instance);
				}
				return r_MCalculateLayout_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaSize MeasureInternal(UnityEngine.Yoga.YogaNode, Single, UnityEngine.Yoga.YogaMeasureMode, Single, UnityEngine.Yoga.YogaMeasureMode)
		/// </summary>
		protected static RMethod r_MMeasureInternal_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
		public static RMethod RMMeasureInternal_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode
		{
			get
			{
				if(r_MMeasureInternal_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode == null)
				{
					r_MMeasureInternal_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"), "MeasureInternal", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"));
					r_MMeasureInternal_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.SetBelong(null);
				}
				return r_MMeasureInternal_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
			}
		}

		/// <summary>
		/// Single BaselineInternal(UnityEngine.Yoga.YogaNode, Single, Single)
		/// </summary>
		protected static RMethod r_MBaselineInternal_YogaNode_Single_Single;
		public static RMethod RMBaselineInternal_YogaNode_Single_Single
		{
			get
			{
				if(r_MBaselineInternal_YogaNode_Single_Single == null)
				{
					r_MBaselineInternal_YogaNode_Single_Single = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"), "BaselineInternal", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"), typeof(System.Single), typeof(System.Single));
					r_MBaselineInternal_YogaNode_Single_Single.SetBelong(null);
				}
				return r_MBaselineInternal_YogaNode_Single_Single;
			}
		}

		/// <summary>
		/// System.String Print(UnityEngine.Yoga.YogaPrintOptions)
		/// </summary>
		protected RMethod r_MPrint_YogaPrintOptions;
		public virtual RMethod RMPrint_YogaPrintOptions
		{
			get
			{
				if(r_MPrint_YogaPrintOptions == null)
				{
					r_MPrint_YogaPrintOptions = new(this, "Print", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaPrintOptions"));
					r_MPrint_YogaPrintOptions.SetBelong(this.instance);
				}
				return r_MPrint_YogaPrintOptions;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[UnityEngine.Yoga.YogaNode] GetEnumerator()
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
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
			}
		}

		/// <summary>
		/// Int32 GetInstanceCount()
		/// </summary>
		protected static RMethod r_MGetInstanceCount;
		public static RMethod RMGetInstanceCount
		{
			get
			{
				if(r_MGetInstanceCount == null)
				{
					r_MGetInstanceCount = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"), "GetInstanceCount", 0);
					r_MGetInstanceCount.SetBelong(null);
				}
				return r_MGetInstanceCount;
			}
		}

		/// <summary>
		/// Void SetStylePosition(UnityEngine.Yoga.YogaEdge, UnityEngine.Yoga.YogaValue)
		/// </summary>
		protected RMethod r_MSetStylePosition_YogaEdge_YogaValue;
		public virtual RMethod RMSetStylePosition_YogaEdge_YogaValue
		{
			get
			{
				if(r_MSetStylePosition_YogaEdge_YogaValue == null)
				{
					r_MSetStylePosition_YogaEdge_YogaValue = new(this, "SetStylePosition", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaEdge"),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"));
					r_MSetStylePosition_YogaEdge_YogaValue.SetBelong(this.instance);
				}
				return r_MSetStylePosition_YogaEdge_YogaValue;
			}
		}

		/// <summary>
		/// Void SetStyleMargin(UnityEngine.Yoga.YogaEdge, UnityEngine.Yoga.YogaValue)
		/// </summary>
		protected RMethod r_MSetStyleMargin_YogaEdge_YogaValue;
		public virtual RMethod RMSetStyleMargin_YogaEdge_YogaValue
		{
			get
			{
				if(r_MSetStyleMargin_YogaEdge_YogaValue == null)
				{
					r_MSetStyleMargin_YogaEdge_YogaValue = new(this, "SetStyleMargin", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaEdge"),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"));
					r_MSetStyleMargin_YogaEdge_YogaValue.SetBelong(this.instance);
				}
				return r_MSetStyleMargin_YogaEdge_YogaValue;
			}
		}

		/// <summary>
		/// Void SetStylePadding(UnityEngine.Yoga.YogaEdge, UnityEngine.Yoga.YogaValue)
		/// </summary>
		protected RMethod r_MSetStylePadding_YogaEdge_YogaValue;
		public virtual RMethod RMSetStylePadding_YogaEdge_YogaValue
		{
			get
			{
				if(r_MSetStylePadding_YogaEdge_YogaValue == null)
				{
					r_MSetStylePadding_YogaEdge_YogaValue = new(this, "SetStylePadding", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaEdge"),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"));
					r_MSetStylePadding_YogaEdge_YogaValue.SetBelong(this.instance);
				}
				return r_MSetStylePadding_YogaEdge_YogaValue;
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


        public RYogaNode() : base("UnityEngine.Yoga.YogaNode")
        {
        }

        public RYogaNode(System.Object instance) : base("UnityEngine.Yoga.YogaNode")
		{
            SetInstance(instance);
		}

        public RYogaNode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RYogaNode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkHasNewLayout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkHasNewLayout.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyStyle(RUnityEngine.RYoga.RYogaNode @srcNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srcNode.Value};
            var ___result = RMCopyStyle_YogaNode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkLayoutSeen()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkLayoutSeen.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ValuesEqual(System.Single @f1, System.Single @f2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f1, @f2};
            var ___result = RMValuesEqual_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Insert(System.Int32 @index, RUnityEngine.RYoga.RYogaNode @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @node.Value};
            var ___result = RMInsert_Int32_YogaNode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddChild(RUnityEngine.RYoga.RYogaNode @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child.Value};
            var ___result = RMAddChild_YogaNode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveChild(RUnityEngine.RYoga.RYogaNode @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child.Value};
            var ___result = RMRemoveChild_YogaNode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 IndexOf(RUnityEngine.RYoga.RYogaNode @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value};
            var ___result = RMIndexOf_YogaNode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetMeasureFunction(RUnityEngine.RYoga.RMeasureFunction @measureFunction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@measureFunction.Value};
            var ___result = RMSetMeasureFunction_MeasureFunction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBaselineFunction(RUnityEngine.RYoga.RBaselineFunction @baselineFunction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baselineFunction.Value};
            var ___result = RMSetBaselineFunction_BaselineFunction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CalculateLayout(System.Single @width, System.Single @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height};
            var ___result = RMCalculateLayout_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static RUnityEngine.RYoga.RYogaSize MeasureInternal(RUnityEngine.RYoga.RYogaNode @node, System.Single @width, RUnityEngine.RYoga.RYogaMeasureMode @widthMode, System.Single @height, RUnityEngine.RYoga.RYogaMeasureMode @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value, @width, @widthMode.Value, @height, @heightMode.Value};
            var ___result = RMMeasureInternal_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RYoga.RYogaSize(___result);
        }


        public static System.Single BaselineInternal(RUnityEngine.RYoga.RYogaNode @node, System.Single @width, System.Single @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value, @width, @height};
            var ___result = RMBaselineInternal_YogaNode_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.String Print(RUnityEngine.RYoga.RYogaPrintOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@options.Value};
            var ___result = RMPrint_YogaPrintOptions.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual RSystem.RCollections.RGeneric.RIEnumerator<RUnityEngine.RYoga.RYogaNode> GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return new RSystem.RCollections.RGeneric.RIEnumerator<RUnityEngine.RYoga.RYogaNode>(___result);
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public static System.Int32 GetInstanceCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetStylePosition(RUnityEngine.RYoga.RYogaEdge @edge, RUnityEngine.RYoga.RYogaValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@edge.Value, @value.Value};
            var ___result = RMSetStylePosition_YogaEdge_YogaValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStyleMargin(RUnityEngine.RYoga.RYogaEdge @edge, RUnityEngine.RYoga.RYogaValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@edge.Value, @value.Value};
            var ___result = RMSetStyleMargin_YogaEdge_YogaValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStylePadding(RUnityEngine.RYoga.RYogaEdge @edge, RUnityEngine.RYoga.RYogaValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@edge.Value, @value.Value};
            var ___result = RMSetStylePadding_YogaEdge_YogaValue.Invoke(___genericsType, ___parameters);

            
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
