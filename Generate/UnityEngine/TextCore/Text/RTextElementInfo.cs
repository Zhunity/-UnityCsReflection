using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.TextElementInfo
	/// </summary>
    public partial class RTextElementInfo : RMember //
    {

		/// <summary>
		/// System.Char character
		/// </summary>
		protected RSystem.RChar r_Fcharacter;
		public virtual RSystem.RChar RFcharacter
		{
			get
			{
				if(r_Fcharacter == null)
				{
					r_Fcharacter = new(this, "character");
					r_Fcharacter.SetBelong(this.instance);
				}
				return r_Fcharacter;
			}
		}

		/// <summary>
		/// System.Int32 index
		/// </summary>
		protected RSystem.RInt32 r_Findex;
		public virtual RSystem.RInt32 RFindex
		{
			get
			{
				if(r_Findex == null)
				{
					r_Findex = new(this, "index");
					r_Findex.SetBelong(this.instance);
				}
				return r_Findex;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextElementType elementType
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextElementType r_FelementType;
		public virtual RUnityEngine.RTextCore.RText.RTextElementType RFelementType
		{
			get
			{
				if(r_FelementType == null)
				{
					r_FelementType = new(this, "elementType");
					r_FelementType.SetBelong(this.instance);
				}
				return r_FelementType;
			}
		}

		/// <summary>
		/// System.Int32 stringLength
		/// </summary>
		protected RSystem.RInt32 r_FstringLength;
		public virtual RSystem.RInt32 RFstringLength
		{
			get
			{
				if(r_FstringLength == null)
				{
					r_FstringLength = new(this, "stringLength");
					r_FstringLength.SetBelong(this.instance);
				}
				return r_FstringLength;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextElement textElement
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextElement r_FtextElement;
		public virtual RUnityEngine.RTextCore.RText.RTextElement RFtextElement
		{
			get
			{
				if(r_FtextElement == null)
				{
					r_FtextElement = new(this, "textElement");
					r_FtextElement.SetBelong(this.instance);
				}
				return r_FtextElement;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Glyph alternativeGlyph
		/// </summary>
		protected RUnityEngine.RTextCore.RGlyph r_FalternativeGlyph;
		public virtual RUnityEngine.RTextCore.RGlyph RFalternativeGlyph
		{
			get
			{
				if(r_FalternativeGlyph == null)
				{
					r_FalternativeGlyph = new(this, "alternativeGlyph");
					r_FalternativeGlyph.SetBelong(this.instance);
				}
				return r_FalternativeGlyph;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset fontAsset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontAsset r_FfontAsset;
		public virtual RUnityEngine.RTextCore.RText.RFontAsset RFfontAsset
		{
			get
			{
				if(r_FfontAsset == null)
				{
					r_FfontAsset = new(this, "fontAsset");
					r_FfontAsset.SetBelong(this.instance);
				}
				return r_FfontAsset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset spriteAsset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RSpriteAsset r_FspriteAsset;
		public virtual RUnityEngine.RTextCore.RText.RSpriteAsset RFspriteAsset
		{
			get
			{
				if(r_FspriteAsset == null)
				{
					r_FspriteAsset = new(this, "spriteAsset");
					r_FspriteAsset.SetBelong(this.instance);
				}
				return r_FspriteAsset;
			}
		}

		/// <summary>
		/// System.Int32 spriteIndex
		/// </summary>
		protected RSystem.RInt32 r_FspriteIndex;
		public virtual RSystem.RInt32 RFspriteIndex
		{
			get
			{
				if(r_FspriteIndex == null)
				{
					r_FspriteIndex = new(this, "spriteIndex");
					r_FspriteIndex.SetBelong(this.instance);
				}
				return r_FspriteIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected RUnityEngine.RMaterial r_Fmaterial;
		public virtual RUnityEngine.RMaterial RFmaterial
		{
			get
			{
				if(r_Fmaterial == null)
				{
					r_Fmaterial = new(this, "material");
					r_Fmaterial.SetBelong(this.instance);
				}
				return r_Fmaterial;
			}
		}

		/// <summary>
		/// System.Int32 materialReferenceIndex
		/// </summary>
		protected RSystem.RInt32 r_FmaterialReferenceIndex;
		public virtual RSystem.RInt32 RFmaterialReferenceIndex
		{
			get
			{
				if(r_FmaterialReferenceIndex == null)
				{
					r_FmaterialReferenceIndex = new(this, "materialReferenceIndex");
					r_FmaterialReferenceIndex.SetBelong(this.instance);
				}
				return r_FmaterialReferenceIndex;
			}
		}

		/// <summary>
		/// System.Boolean isUsingAlternateTypeface
		/// </summary>
		protected RSystem.RBoolean r_FisUsingAlternateTypeface;
		public virtual RSystem.RBoolean RFisUsingAlternateTypeface
		{
			get
			{
				if(r_FisUsingAlternateTypeface == null)
				{
					r_FisUsingAlternateTypeface = new(this, "isUsingAlternateTypeface");
					r_FisUsingAlternateTypeface.SetBelong(this.instance);
				}
				return r_FisUsingAlternateTypeface;
			}
		}

		/// <summary>
		/// System.Single pointSize
		/// </summary>
		protected RSystem.RSingle r_FpointSize;
		public virtual RSystem.RSingle RFpointSize
		{
			get
			{
				if(r_FpointSize == null)
				{
					r_FpointSize = new(this, "pointSize");
					r_FpointSize.SetBelong(this.instance);
				}
				return r_FpointSize;
			}
		}

		/// <summary>
		/// System.Int32 lineNumber
		/// </summary>
		protected RSystem.RInt32 r_FlineNumber;
		public virtual RSystem.RInt32 RFlineNumber
		{
			get
			{
				if(r_FlineNumber == null)
				{
					r_FlineNumber = new(this, "lineNumber");
					r_FlineNumber.SetBelong(this.instance);
				}
				return r_FlineNumber;
			}
		}

		/// <summary>
		/// System.Int32 pageNumber
		/// </summary>
		protected RSystem.RInt32 r_FpageNumber;
		public virtual RSystem.RInt32 RFpageNumber
		{
			get
			{
				if(r_FpageNumber == null)
				{
					r_FpageNumber = new(this, "pageNumber");
					r_FpageNumber.SetBelong(this.instance);
				}
				return r_FpageNumber;
			}
		}

		/// <summary>
		/// System.Int32 vertexIndex
		/// </summary>
		protected RSystem.RInt32 r_FvertexIndex;
		public virtual RSystem.RInt32 RFvertexIndex
		{
			get
			{
				if(r_FvertexIndex == null)
				{
					r_FvertexIndex = new(this, "vertexIndex");
					r_FvertexIndex.SetBelong(this.instance);
				}
				return r_FvertexIndex;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextVertex vertexTopLeft
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextVertex r_FvertexTopLeft;
		public virtual RUnityEngine.RTextCore.RText.RTextVertex RFvertexTopLeft
		{
			get
			{
				if(r_FvertexTopLeft == null)
				{
					r_FvertexTopLeft = new(this, "vertexTopLeft");
					r_FvertexTopLeft.SetBelong(this.instance);
				}
				return r_FvertexTopLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextVertex vertexBottomLeft
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextVertex r_FvertexBottomLeft;
		public virtual RUnityEngine.RTextCore.RText.RTextVertex RFvertexBottomLeft
		{
			get
			{
				if(r_FvertexBottomLeft == null)
				{
					r_FvertexBottomLeft = new(this, "vertexBottomLeft");
					r_FvertexBottomLeft.SetBelong(this.instance);
				}
				return r_FvertexBottomLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextVertex vertexTopRight
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextVertex r_FvertexTopRight;
		public virtual RUnityEngine.RTextCore.RText.RTextVertex RFvertexTopRight
		{
			get
			{
				if(r_FvertexTopRight == null)
				{
					r_FvertexTopRight = new(this, "vertexTopRight");
					r_FvertexTopRight.SetBelong(this.instance);
				}
				return r_FvertexTopRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextVertex vertexBottomRight
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextVertex r_FvertexBottomRight;
		public virtual RUnityEngine.RTextCore.RText.RTextVertex RFvertexBottomRight
		{
			get
			{
				if(r_FvertexBottomRight == null)
				{
					r_FvertexBottomRight = new(this, "vertexBottomRight");
					r_FvertexBottomRight.SetBelong(this.instance);
				}
				return r_FvertexBottomRight;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 topLeft
		/// </summary>
		protected RUnityEngine.RVector3 r_FtopLeft;
		public virtual RUnityEngine.RVector3 RFtopLeft
		{
			get
			{
				if(r_FtopLeft == null)
				{
					r_FtopLeft = new(this, "topLeft");
					r_FtopLeft.SetBelong(this.instance);
				}
				return r_FtopLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 bottomLeft
		/// </summary>
		protected RUnityEngine.RVector3 r_FbottomLeft;
		public virtual RUnityEngine.RVector3 RFbottomLeft
		{
			get
			{
				if(r_FbottomLeft == null)
				{
					r_FbottomLeft = new(this, "bottomLeft");
					r_FbottomLeft.SetBelong(this.instance);
				}
				return r_FbottomLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 topRight
		/// </summary>
		protected RUnityEngine.RVector3 r_FtopRight;
		public virtual RUnityEngine.RVector3 RFtopRight
		{
			get
			{
				if(r_FtopRight == null)
				{
					r_FtopRight = new(this, "topRight");
					r_FtopRight.SetBelong(this.instance);
				}
				return r_FtopRight;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 bottomRight
		/// </summary>
		protected RUnityEngine.RVector3 r_FbottomRight;
		public virtual RUnityEngine.RVector3 RFbottomRight
		{
			get
			{
				if(r_FbottomRight == null)
				{
					r_FbottomRight = new(this, "bottomRight");
					r_FbottomRight.SetBelong(this.instance);
				}
				return r_FbottomRight;
			}
		}

		/// <summary>
		/// System.Single origin
		/// </summary>
		protected RSystem.RSingle r_Forigin;
		public virtual RSystem.RSingle RForigin
		{
			get
			{
				if(r_Forigin == null)
				{
					r_Forigin = new(this, "origin");
					r_Forigin.SetBelong(this.instance);
				}
				return r_Forigin;
			}
		}

		/// <summary>
		/// System.Single ascender
		/// </summary>
		protected RSystem.RSingle r_Fascender;
		public virtual RSystem.RSingle RFascender
		{
			get
			{
				if(r_Fascender == null)
				{
					r_Fascender = new(this, "ascender");
					r_Fascender.SetBelong(this.instance);
				}
				return r_Fascender;
			}
		}

		/// <summary>
		/// System.Single baseLine
		/// </summary>
		protected RSystem.RSingle r_FbaseLine;
		public virtual RSystem.RSingle RFbaseLine
		{
			get
			{
				if(r_FbaseLine == null)
				{
					r_FbaseLine = new(this, "baseLine");
					r_FbaseLine.SetBelong(this.instance);
				}
				return r_FbaseLine;
			}
		}

		/// <summary>
		/// System.Single descender
		/// </summary>
		protected RSystem.RSingle r_Fdescender;
		public virtual RSystem.RSingle RFdescender
		{
			get
			{
				if(r_Fdescender == null)
				{
					r_Fdescender = new(this, "descender");
					r_Fdescender.SetBelong(this.instance);
				}
				return r_Fdescender;
			}
		}

		/// <summary>
		/// System.Single adjustedAscender
		/// </summary>
		protected RSystem.RSingle r_FadjustedAscender;
		public virtual RSystem.RSingle RFadjustedAscender
		{
			get
			{
				if(r_FadjustedAscender == null)
				{
					r_FadjustedAscender = new(this, "adjustedAscender");
					r_FadjustedAscender.SetBelong(this.instance);
				}
				return r_FadjustedAscender;
			}
		}

		/// <summary>
		/// System.Single adjustedDescender
		/// </summary>
		protected RSystem.RSingle r_FadjustedDescender;
		public virtual RSystem.RSingle RFadjustedDescender
		{
			get
			{
				if(r_FadjustedDescender == null)
				{
					r_FadjustedDescender = new(this, "adjustedDescender");
					r_FadjustedDescender.SetBelong(this.instance);
				}
				return r_FadjustedDescender;
			}
		}

		/// <summary>
		/// System.Single adjustedHorizontalAdvance
		/// </summary>
		protected RSystem.RSingle r_FadjustedHorizontalAdvance;
		public virtual RSystem.RSingle RFadjustedHorizontalAdvance
		{
			get
			{
				if(r_FadjustedHorizontalAdvance == null)
				{
					r_FadjustedHorizontalAdvance = new(this, "adjustedHorizontalAdvance");
					r_FadjustedHorizontalAdvance.SetBelong(this.instance);
				}
				return r_FadjustedHorizontalAdvance;
			}
		}

		/// <summary>
		/// System.Single xAdvance
		/// </summary>
		protected RSystem.RSingle r_FxAdvance;
		public virtual RSystem.RSingle RFxAdvance
		{
			get
			{
				if(r_FxAdvance == null)
				{
					r_FxAdvance = new(this, "xAdvance");
					r_FxAdvance.SetBelong(this.instance);
				}
				return r_FxAdvance;
			}
		}

		/// <summary>
		/// System.Single aspectRatio
		/// </summary>
		protected RSystem.RSingle r_FaspectRatio;
		public virtual RSystem.RSingle RFaspectRatio
		{
			get
			{
				if(r_FaspectRatio == null)
				{
					r_FaspectRatio = new(this, "aspectRatio");
					r_FaspectRatio.SetBelong(this.instance);
				}
				return r_FaspectRatio;
			}
		}

		/// <summary>
		/// System.Single scale
		/// </summary>
		protected RSystem.RSingle r_Fscale;
		public virtual RSystem.RSingle RFscale
		{
			get
			{
				if(r_Fscale == null)
				{
					r_Fscale = new(this, "scale");
					r_Fscale.SetBelong(this.instance);
				}
				return r_Fscale;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 color
		/// </summary>
		protected RUnityEngine.RColor32 r_Fcolor;
		public virtual RUnityEngine.RColor32 RFcolor
		{
			get
			{
				if(r_Fcolor == null)
				{
					r_Fcolor = new(this, "color");
					r_Fcolor.SetBelong(this.instance);
				}
				return r_Fcolor;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 underlineColor
		/// </summary>
		protected RUnityEngine.RColor32 r_FunderlineColor;
		public virtual RUnityEngine.RColor32 RFunderlineColor
		{
			get
			{
				if(r_FunderlineColor == null)
				{
					r_FunderlineColor = new(this, "underlineColor");
					r_FunderlineColor.SetBelong(this.instance);
				}
				return r_FunderlineColor;
			}
		}

		/// <summary>
		/// System.Int32 underlineVertexIndex
		/// </summary>
		protected RSystem.RInt32 r_FunderlineVertexIndex;
		public virtual RSystem.RInt32 RFunderlineVertexIndex
		{
			get
			{
				if(r_FunderlineVertexIndex == null)
				{
					r_FunderlineVertexIndex = new(this, "underlineVertexIndex");
					r_FunderlineVertexIndex.SetBelong(this.instance);
				}
				return r_FunderlineVertexIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 strikethroughColor
		/// </summary>
		protected RUnityEngine.RColor32 r_FstrikethroughColor;
		public virtual RUnityEngine.RColor32 RFstrikethroughColor
		{
			get
			{
				if(r_FstrikethroughColor == null)
				{
					r_FstrikethroughColor = new(this, "strikethroughColor");
					r_FstrikethroughColor.SetBelong(this.instance);
				}
				return r_FstrikethroughColor;
			}
		}

		/// <summary>
		/// System.Int32 strikethroughVertexIndex
		/// </summary>
		protected RSystem.RInt32 r_FstrikethroughVertexIndex;
		public virtual RSystem.RInt32 RFstrikethroughVertexIndex
		{
			get
			{
				if(r_FstrikethroughVertexIndex == null)
				{
					r_FstrikethroughVertexIndex = new(this, "strikethroughVertexIndex");
					r_FstrikethroughVertexIndex.SetBelong(this.instance);
				}
				return r_FstrikethroughVertexIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 highlightColor
		/// </summary>
		protected RUnityEngine.RColor32 r_FhighlightColor;
		public virtual RUnityEngine.RColor32 RFhighlightColor
		{
			get
			{
				if(r_FhighlightColor == null)
				{
					r_FhighlightColor = new(this, "highlightColor");
					r_FhighlightColor.SetBelong(this.instance);
				}
				return r_FhighlightColor;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.HighlightState highlightState
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RHighlightState r_FhighlightState;
		public virtual RUnityEngine.RTextCore.RText.RHighlightState RFhighlightState
		{
			get
			{
				if(r_FhighlightState == null)
				{
					r_FhighlightState = new(this, "highlightState");
					r_FhighlightState.SetBelong(this.instance);
				}
				return r_FhighlightState;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles style
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontStyles r_Fstyle;
		public virtual RUnityEngine.RTextCore.RText.RFontStyles RFstyle
		{
			get
			{
				if(r_Fstyle == null)
				{
					r_Fstyle = new(this, "style");
					r_Fstyle.SetBelong(this.instance);
				}
				return r_Fstyle;
			}
		}

		/// <summary>
		/// System.Boolean isVisible
		/// </summary>
		protected RSystem.RBoolean r_FisVisible;
		public virtual RSystem.RBoolean RFisVisible
		{
			get
			{
				if(r_FisVisible == null)
				{
					r_FisVisible = new(this, "isVisible");
					r_FisVisible.SetBelong(this.instance);
				}
				return r_FisVisible;
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


        public RTextElementInfo() : base("UnityEngine.TextCore.Text.TextElementInfo")
        {
        }

        public RTextElementInfo(System.Object instance) : base("UnityEngine.TextCore.Text.TextElementInfo")
		{
            SetInstance(instance);
		}

        public RTextElementInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextElementInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
