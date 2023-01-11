using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.TextGenerationSettings
	/// </summary>
    public partial class RTextGenerationSettings : RMember //
    {

		/// <summary>
		/// System.String text
		/// </summary>
		protected RSystem.RString r_text;
		public virtual RSystem.RString Rtext
		{
			get
			{
				if(r_text == null)
				{
					r_text = new(this, "text");
					r_text.SetBelong(this.instance);
				}
				return r_text;
			}
		}

		/// <summary>
		/// UnityEngine.Rect screenRect
		/// </summary>
		protected RUnityEngine.RRect r_screenRect;
		public virtual RUnityEngine.RRect RscreenRect
		{
			get
			{
				if(r_screenRect == null)
				{
					r_screenRect = new(this, "screenRect");
					r_screenRect.SetBelong(this.instance);
				}
				return r_screenRect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 margins
		/// </summary>
		protected RUnityEngine.RVector4 r_margins;
		public virtual RUnityEngine.RVector4 Rmargins
		{
			get
			{
				if(r_margins == null)
				{
					r_margins = new(this, "margins");
					r_margins.SetBelong(this.instance);
				}
				return r_margins;
			}
		}

		/// <summary>
		/// System.Single scale
		/// </summary>
		protected RSystem.RSingle r_scale;
		public virtual RSystem.RSingle Rscale
		{
			get
			{
				if(r_scale == null)
				{
					r_scale = new(this, "scale");
					r_scale.SetBelong(this.instance);
				}
				return r_scale;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset fontAsset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontAsset r_fontAsset;
		public virtual RUnityEngine.RTextCore.RText.RFontAsset RfontAsset
		{
			get
			{
				if(r_fontAsset == null)
				{
					r_fontAsset = new(this, "fontAsset");
					r_fontAsset.SetBelong(this.instance);
				}
				return r_fontAsset;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected RUnityEngine.RMaterial r_material;
		public virtual RUnityEngine.RMaterial Rmaterial
		{
			get
			{
				if(r_material == null)
				{
					r_material = new(this, "material");
					r_material.SetBelong(this.instance);
				}
				return r_material;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset spriteAsset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RSpriteAsset r_spriteAsset;
		public virtual RUnityEngine.RTextCore.RText.RSpriteAsset RspriteAsset
		{
			get
			{
				if(r_spriteAsset == null)
				{
					r_spriteAsset = new(this, "spriteAsset");
					r_spriteAsset.SetBelong(this.instance);
				}
				return r_spriteAsset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextStyleSheet styleSheet
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextStyleSheet r_styleSheet;
		public virtual RUnityEngine.RTextCore.RText.RTextStyleSheet RstyleSheet
		{
			get
			{
				if(r_styleSheet == null)
				{
					r_styleSheet = new(this, "styleSheet");
					r_styleSheet.SetBelong(this.instance);
				}
				return r_styleSheet;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles fontStyle
		/// </summary>
		protected RField r_fontStyle;
		public virtual RField RfontStyle
		{
			get
			{
				if(r_fontStyle == null)
				{
					r_fontStyle = new(this, "fontStyle");
					r_fontStyle.SetBelong(this.instance);
				}
				return r_fontStyle;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextSettings textSettings
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextSettings r_textSettings;
		public virtual RUnityEngine.RTextCore.RText.RTextSettings RtextSettings
		{
			get
			{
				if(r_textSettings == null)
				{
					r_textSettings = new(this, "textSettings");
					r_textSettings.SetBelong(this.instance);
				}
				return r_textSettings;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment textAlignment
		/// </summary>
		protected RField r_textAlignment;
		public virtual RField RtextAlignment
		{
			get
			{
				if(r_textAlignment == null)
				{
					r_textAlignment = new(this, "textAlignment");
					r_textAlignment.SetBelong(this.instance);
				}
				return r_textAlignment;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextOverflowMode overflowMode
		/// </summary>
		protected RField r_overflowMode;
		public virtual RField RoverflowMode
		{
			get
			{
				if(r_overflowMode == null)
				{
					r_overflowMode = new(this, "overflowMode");
					r_overflowMode.SetBelong(this.instance);
				}
				return r_overflowMode;
			}
		}

		/// <summary>
		/// System.Boolean wordWrap
		/// </summary>
		protected RSystem.RBoolean r_wordWrap;
		public virtual RSystem.RBoolean RwordWrap
		{
			get
			{
				if(r_wordWrap == null)
				{
					r_wordWrap = new(this, "wordWrap");
					r_wordWrap.SetBelong(this.instance);
				}
				return r_wordWrap;
			}
		}

		/// <summary>
		/// System.Single wordWrappingRatio
		/// </summary>
		protected RSystem.RSingle r_wordWrappingRatio;
		public virtual RSystem.RSingle RwordWrappingRatio
		{
			get
			{
				if(r_wordWrappingRatio == null)
				{
					r_wordWrappingRatio = new(this, "wordWrappingRatio");
					r_wordWrappingRatio.SetBelong(this.instance);
				}
				return r_wordWrappingRatio;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_color;
		public virtual RUnityEngine.RColor Rcolor
		{
			get
			{
				if(r_color == null)
				{
					r_color = new(this, "color");
					r_color.SetBelong(this.instance);
				}
				return r_color;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextColorGradient fontColorGradient
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextColorGradient r_fontColorGradient;
		public virtual RUnityEngine.RTextCore.RText.RTextColorGradient RfontColorGradient
		{
			get
			{
				if(r_fontColorGradient == null)
				{
					r_fontColorGradient = new(this, "fontColorGradient");
					r_fontColorGradient.SetBelong(this.instance);
				}
				return r_fontColorGradient;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextColorGradient fontColorGradientPreset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextColorGradient r_fontColorGradientPreset;
		public virtual RUnityEngine.RTextCore.RText.RTextColorGradient RfontColorGradientPreset
		{
			get
			{
				if(r_fontColorGradientPreset == null)
				{
					r_fontColorGradientPreset = new(this, "fontColorGradientPreset");
					r_fontColorGradientPreset.SetBelong(this.instance);
				}
				return r_fontColorGradientPreset;
			}
		}

		/// <summary>
		/// System.Boolean tintSprites
		/// </summary>
		protected RSystem.RBoolean r_tintSprites;
		public virtual RSystem.RBoolean RtintSprites
		{
			get
			{
				if(r_tintSprites == null)
				{
					r_tintSprites = new(this, "tintSprites");
					r_tintSprites.SetBelong(this.instance);
				}
				return r_tintSprites;
			}
		}

		/// <summary>
		/// System.Boolean overrideRichTextColors
		/// </summary>
		protected RSystem.RBoolean r_overrideRichTextColors;
		public virtual RSystem.RBoolean RoverrideRichTextColors
		{
			get
			{
				if(r_overrideRichTextColors == null)
				{
					r_overrideRichTextColors = new(this, "overrideRichTextColors");
					r_overrideRichTextColors.SetBelong(this.instance);
				}
				return r_overrideRichTextColors;
			}
		}

		/// <summary>
		/// System.Boolean shouldConvertToLinearSpace
		/// </summary>
		protected RSystem.RBoolean r_shouldConvertToLinearSpace;
		public virtual RSystem.RBoolean RshouldConvertToLinearSpace
		{
			get
			{
				if(r_shouldConvertToLinearSpace == null)
				{
					r_shouldConvertToLinearSpace = new(this, "shouldConvertToLinearSpace");
					r_shouldConvertToLinearSpace.SetBelong(this.instance);
				}
				return r_shouldConvertToLinearSpace;
			}
		}

		/// <summary>
		/// System.Single fontSize
		/// </summary>
		protected RSystem.RSingle r_fontSize;
		public virtual RSystem.RSingle RfontSize
		{
			get
			{
				if(r_fontSize == null)
				{
					r_fontSize = new(this, "fontSize");
					r_fontSize.SetBelong(this.instance);
				}
				return r_fontSize;
			}
		}

		/// <summary>
		/// System.Boolean autoSize
		/// </summary>
		protected RSystem.RBoolean r_autoSize;
		public virtual RSystem.RBoolean RautoSize
		{
			get
			{
				if(r_autoSize == null)
				{
					r_autoSize = new(this, "autoSize");
					r_autoSize.SetBelong(this.instance);
				}
				return r_autoSize;
			}
		}

		/// <summary>
		/// System.Single fontSizeMin
		/// </summary>
		protected RSystem.RSingle r_fontSizeMin;
		public virtual RSystem.RSingle RfontSizeMin
		{
			get
			{
				if(r_fontSizeMin == null)
				{
					r_fontSizeMin = new(this, "fontSizeMin");
					r_fontSizeMin.SetBelong(this.instance);
				}
				return r_fontSizeMin;
			}
		}

		/// <summary>
		/// System.Single fontSizeMax
		/// </summary>
		protected RSystem.RSingle r_fontSizeMax;
		public virtual RSystem.RSingle RfontSizeMax
		{
			get
			{
				if(r_fontSizeMax == null)
				{
					r_fontSizeMax = new(this, "fontSizeMax");
					r_fontSizeMax.SetBelong(this.instance);
				}
				return r_fontSizeMax;
			}
		}

		/// <summary>
		/// System.Boolean enableKerning
		/// </summary>
		protected RSystem.RBoolean r_enableKerning;
		public virtual RSystem.RBoolean RenableKerning
		{
			get
			{
				if(r_enableKerning == null)
				{
					r_enableKerning = new(this, "enableKerning");
					r_enableKerning.SetBelong(this.instance);
				}
				return r_enableKerning;
			}
		}

		/// <summary>
		/// System.Boolean richText
		/// </summary>
		protected RSystem.RBoolean r_richText;
		public virtual RSystem.RBoolean RrichText
		{
			get
			{
				if(r_richText == null)
				{
					r_richText = new(this, "richText");
					r_richText.SetBelong(this.instance);
				}
				return r_richText;
			}
		}

		/// <summary>
		/// System.Boolean isRightToLeft
		/// </summary>
		protected RSystem.RBoolean r_isRightToLeft;
		public virtual RSystem.RBoolean RisRightToLeft
		{
			get
			{
				if(r_isRightToLeft == null)
				{
					r_isRightToLeft = new(this, "isRightToLeft");
					r_isRightToLeft.SetBelong(this.instance);
				}
				return r_isRightToLeft;
			}
		}

		/// <summary>
		/// System.Boolean extraPadding
		/// </summary>
		protected RSystem.RBoolean r_extraPadding;
		public virtual RSystem.RBoolean RextraPadding
		{
			get
			{
				if(r_extraPadding == null)
				{
					r_extraPadding = new(this, "extraPadding");
					r_extraPadding.SetBelong(this.instance);
				}
				return r_extraPadding;
			}
		}

		/// <summary>
		/// System.Boolean parseControlCharacters
		/// </summary>
		protected RSystem.RBoolean r_parseControlCharacters;
		public virtual RSystem.RBoolean RparseControlCharacters
		{
			get
			{
				if(r_parseControlCharacters == null)
				{
					r_parseControlCharacters = new(this, "parseControlCharacters");
					r_parseControlCharacters.SetBelong(this.instance);
				}
				return r_parseControlCharacters;
			}
		}

		/// <summary>
		/// System.Boolean isOrthographic
		/// </summary>
		protected RSystem.RBoolean r_isOrthographic;
		public virtual RSystem.RBoolean RisOrthographic
		{
			get
			{
				if(r_isOrthographic == null)
				{
					r_isOrthographic = new(this, "isOrthographic");
					r_isOrthographic.SetBelong(this.instance);
				}
				return r_isOrthographic;
			}
		}

		/// <summary>
		/// System.Boolean tagNoParsing
		/// </summary>
		protected RSystem.RBoolean r_tagNoParsing;
		public virtual RSystem.RBoolean RtagNoParsing
		{
			get
			{
				if(r_tagNoParsing == null)
				{
					r_tagNoParsing = new(this, "tagNoParsing");
					r_tagNoParsing.SetBelong(this.instance);
				}
				return r_tagNoParsing;
			}
		}

		/// <summary>
		/// System.Single characterSpacing
		/// </summary>
		protected RSystem.RSingle r_characterSpacing;
		public virtual RSystem.RSingle RcharacterSpacing
		{
			get
			{
				if(r_characterSpacing == null)
				{
					r_characterSpacing = new(this, "characterSpacing");
					r_characterSpacing.SetBelong(this.instance);
				}
				return r_characterSpacing;
			}
		}

		/// <summary>
		/// System.Single wordSpacing
		/// </summary>
		protected RSystem.RSingle r_wordSpacing;
		public virtual RSystem.RSingle RwordSpacing
		{
			get
			{
				if(r_wordSpacing == null)
				{
					r_wordSpacing = new(this, "wordSpacing");
					r_wordSpacing.SetBelong(this.instance);
				}
				return r_wordSpacing;
			}
		}

		/// <summary>
		/// System.Single lineSpacing
		/// </summary>
		protected RSystem.RSingle r_lineSpacing;
		public virtual RSystem.RSingle RlineSpacing
		{
			get
			{
				if(r_lineSpacing == null)
				{
					r_lineSpacing = new(this, "lineSpacing");
					r_lineSpacing.SetBelong(this.instance);
				}
				return r_lineSpacing;
			}
		}

		/// <summary>
		/// System.Single paragraphSpacing
		/// </summary>
		protected RSystem.RSingle r_paragraphSpacing;
		public virtual RSystem.RSingle RparagraphSpacing
		{
			get
			{
				if(r_paragraphSpacing == null)
				{
					r_paragraphSpacing = new(this, "paragraphSpacing");
					r_paragraphSpacing.SetBelong(this.instance);
				}
				return r_paragraphSpacing;
			}
		}

		/// <summary>
		/// System.Single lineSpacingMax
		/// </summary>
		protected RSystem.RSingle r_lineSpacingMax;
		public virtual RSystem.RSingle RlineSpacingMax
		{
			get
			{
				if(r_lineSpacingMax == null)
				{
					r_lineSpacingMax = new(this, "lineSpacingMax");
					r_lineSpacingMax.SetBelong(this.instance);
				}
				return r_lineSpacingMax;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextWrappingMode textWrappingMode
		/// </summary>
		protected RField r_textWrappingMode;
		public virtual RField RtextWrappingMode
		{
			get
			{
				if(r_textWrappingMode == null)
				{
					r_textWrappingMode = new(this, "textWrappingMode");
					r_textWrappingMode.SetBelong(this.instance);
				}
				return r_textWrappingMode;
			}
		}

		/// <summary>
		/// System.Int32 maxVisibleCharacters
		/// </summary>
		protected RSystem.RInt32 r_maxVisibleCharacters;
		public virtual RSystem.RInt32 RmaxVisibleCharacters
		{
			get
			{
				if(r_maxVisibleCharacters == null)
				{
					r_maxVisibleCharacters = new(this, "maxVisibleCharacters");
					r_maxVisibleCharacters.SetBelong(this.instance);
				}
				return r_maxVisibleCharacters;
			}
		}

		/// <summary>
		/// System.Int32 maxVisibleWords
		/// </summary>
		protected RSystem.RInt32 r_maxVisibleWords;
		public virtual RSystem.RInt32 RmaxVisibleWords
		{
			get
			{
				if(r_maxVisibleWords == null)
				{
					r_maxVisibleWords = new(this, "maxVisibleWords");
					r_maxVisibleWords.SetBelong(this.instance);
				}
				return r_maxVisibleWords;
			}
		}

		/// <summary>
		/// System.Int32 maxVisibleLines
		/// </summary>
		protected RSystem.RInt32 r_maxVisibleLines;
		public virtual RSystem.RInt32 RmaxVisibleLines
		{
			get
			{
				if(r_maxVisibleLines == null)
				{
					r_maxVisibleLines = new(this, "maxVisibleLines");
					r_maxVisibleLines.SetBelong(this.instance);
				}
				return r_maxVisibleLines;
			}
		}

		/// <summary>
		/// System.Int32 firstVisibleCharacter
		/// </summary>
		protected RSystem.RInt32 r_firstVisibleCharacter;
		public virtual RSystem.RInt32 RfirstVisibleCharacter
		{
			get
			{
				if(r_firstVisibleCharacter == null)
				{
					r_firstVisibleCharacter = new(this, "firstVisibleCharacter");
					r_firstVisibleCharacter.SetBelong(this.instance);
				}
				return r_firstVisibleCharacter;
			}
		}

		/// <summary>
		/// System.Boolean useMaxVisibleDescender
		/// </summary>
		protected RSystem.RBoolean r_useMaxVisibleDescender;
		public virtual RSystem.RBoolean RuseMaxVisibleDescender
		{
			get
			{
				if(r_useMaxVisibleDescender == null)
				{
					r_useMaxVisibleDescender = new(this, "useMaxVisibleDescender");
					r_useMaxVisibleDescender.SetBelong(this.instance);
				}
				return r_useMaxVisibleDescender;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextFontWeight fontWeight
		/// </summary>
		protected RField r_fontWeight;
		public virtual RField RfontWeight
		{
			get
			{
				if(r_fontWeight == null)
				{
					r_fontWeight = new(this, "fontWeight");
					r_fontWeight.SetBelong(this.instance);
				}
				return r_fontWeight;
			}
		}

		/// <summary>
		/// System.Int32 pageToDisplay
		/// </summary>
		protected RSystem.RInt32 r_pageToDisplay;
		public virtual RSystem.RInt32 RpageToDisplay
		{
			get
			{
				if(r_pageToDisplay == null)
				{
					r_pageToDisplay = new(this, "pageToDisplay");
					r_pageToDisplay.SetBelong(this.instance);
				}
				return r_pageToDisplay;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextureMapping horizontalMapping
		/// </summary>
		protected RField r_horizontalMapping;
		public virtual RField RhorizontalMapping
		{
			get
			{
				if(r_horizontalMapping == null)
				{
					r_horizontalMapping = new(this, "horizontalMapping");
					r_horizontalMapping.SetBelong(this.instance);
				}
				return r_horizontalMapping;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextureMapping verticalMapping
		/// </summary>
		protected RField r_verticalMapping;
		public virtual RField RverticalMapping
		{
			get
			{
				if(r_verticalMapping == null)
				{
					r_verticalMapping = new(this, "verticalMapping");
					r_verticalMapping.SetBelong(this.instance);
				}
				return r_verticalMapping;
			}
		}

		/// <summary>
		/// System.Single uvLineOffset
		/// </summary>
		protected RSystem.RSingle r_uvLineOffset;
		public virtual RSystem.RSingle RuvLineOffset
		{
			get
			{
				if(r_uvLineOffset == null)
				{
					r_uvLineOffset = new(this, "uvLineOffset");
					r_uvLineOffset.SetBelong(this.instance);
				}
				return r_uvLineOffset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.VertexSortingOrder geometrySortingOrder
		/// </summary>
		protected RField r_geometrySortingOrder;
		public virtual RField RgeometrySortingOrder
		{
			get
			{
				if(r_geometrySortingOrder == null)
				{
					r_geometrySortingOrder = new(this, "geometrySortingOrder");
					r_geometrySortingOrder.SetBelong(this.instance);
				}
				return r_geometrySortingOrder;
			}
		}

		/// <summary>
		/// System.Boolean inverseYAxis
		/// </summary>
		protected RSystem.RBoolean r_inverseYAxis;
		public virtual RSystem.RBoolean RinverseYAxis
		{
			get
			{
				if(r_inverseYAxis == null)
				{
					r_inverseYAxis = new(this, "inverseYAxis");
					r_inverseYAxis.SetBelong(this.instance);
				}
				return r_inverseYAxis;
			}
		}

		/// <summary>
		/// System.Single charWidthMaxAdj
		/// </summary>
		protected RSystem.RSingle r_charWidthMaxAdj;
		public virtual RSystem.RSingle RcharWidthMaxAdj
		{
			get
			{
				if(r_charWidthMaxAdj == null)
				{
					r_charWidthMaxAdj = new(this, "charWidthMaxAdj");
					r_charWidthMaxAdj.SetBelong(this.instance);
				}
				return r_charWidthMaxAdj;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInputSource inputSource
		/// </summary>
		protected RField r_inputSource;
		public virtual RField RinputSource
		{
			get
			{
				if(r_inputSource == null)
				{
					r_inputSource = new(this, "inputSource");
					r_inputSource.SetBelong(this.instance);
				}
				return r_inputSource;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_Equals_TextGenerationSettings;
		public virtual RMethod REquals_TextGenerationSettings
		{
			get
			{
				if(r_Equals_TextGenerationSettings == null)
				{
					r_Equals_TextGenerationSettings = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_Equals_TextGenerationSettings.SetBelong(this.instance);
				}
				return r_Equals_TextGenerationSettings;
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
		/// Boolean op_Equality(UnityEngine.TextCore.Text.TextGenerationSettings, UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected static RMethod r_op_Equality_TextGenerationSettings_TextGenerationSettings;
		public static RMethod Rop_Equality_TextGenerationSettings_TextGenerationSettings
		{
			get
			{
				if(r_op_Equality_TextGenerationSettings_TextGenerationSettings == null)
				{
					r_op_Equality_TextGenerationSettings_TextGenerationSettings = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"),  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_op_Equality_TextGenerationSettings_TextGenerationSettings.SetBelong(null);
				}
				return r_op_Equality_TextGenerationSettings_TextGenerationSettings;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.Text.TextGenerationSettings, UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected static RMethod r_op_Inequality_TextGenerationSettings_TextGenerationSettings;
		public static RMethod Rop_Inequality_TextGenerationSettings_TextGenerationSettings
		{
			get
			{
				if(r_op_Inequality_TextGenerationSettings_TextGenerationSettings == null)
				{
					r_op_Inequality_TextGenerationSettings_TextGenerationSettings = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"),  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_op_Inequality_TextGenerationSettings_TextGenerationSettings.SetBelong(null);
				}
				return r_op_Inequality_TextGenerationSettings_TextGenerationSettings;
			}
		}

		/// <summary>
		/// Void Copy(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_Copy_TextGenerationSettings;
		public virtual RMethod RCopy_TextGenerationSettings
		{
			get
			{
				if(r_Copy_TextGenerationSettings == null)
				{
					r_Copy_TextGenerationSettings = new(this, "Copy", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_Copy_TextGenerationSettings.SetBelong(this.instance);
				}
				return r_Copy_TextGenerationSettings;
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


        public RTextGenerationSettings() : base("UnityEngine.TextCore.Text.TextGenerationSettings")
        {
        }

        public RTextGenerationSettings(System.Object instance) : base("UnityEngine.TextCore.Text.TextGenerationSettings")
		{
            SetInstance(instance);
		}

        public RTextGenerationSettings(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextGenerationSettings(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(RUnityEngine.RTextCore.RText.RTextGenerationSettings @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = REquals_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(RUnityEngine.RTextCore.RText.RTextGenerationSettings @left, RUnityEngine.RTextCore.RText.RTextGenerationSettings @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = Rop_Equality_TextGenerationSettings_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(RUnityEngine.RTextCore.RText.RTextGenerationSettings @left, RUnityEngine.RTextCore.RText.RTextGenerationSettings @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = Rop_Inequality_TextGenerationSettings_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Copy(RUnityEngine.RTextCore.RText.RTextGenerationSettings @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RCopy_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
