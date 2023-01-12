using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Sprite
	/// </summary>
    public partial class RSprite : RMember //
    {

		/// <summary>
		/// UnityEngine.Bounds bounds
		/// </summary>
		protected RUnityEngine.RBounds r_Pbounds;
		public virtual RUnityEngine.RBounds RPbounds
		{
			get
			{
				if(r_Pbounds == null)
				{
					r_Pbounds = new(this, "bounds", -1);
					r_Pbounds.SetBelong(this.instance);
				}
				return r_Pbounds;
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
		/// UnityEngine.Vector4 border
		/// </summary>
		protected RUnityEngine.RVector4 r_Pborder;
		public virtual RUnityEngine.RVector4 RPborder
		{
			get
			{
				if(r_Pborder == null)
				{
					r_Pborder = new(this, "border", -1);
					r_Pborder.SetBelong(this.instance);
				}
				return r_Pborder;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D texture
		/// </summary>
		protected RUnityEngine.RTexture2D r_Ptexture;
		public virtual RUnityEngine.RTexture2D RPtexture
		{
			get
			{
				if(r_Ptexture == null)
				{
					r_Ptexture = new(this, "texture", -1);
					r_Ptexture.SetBelong(this.instance);
				}
				return r_Ptexture;
			}
		}

		/// <summary>
		/// Single pixelsPerUnit
		/// </summary>
		protected RSystem.RSingle r_PpixelsPerUnit;
		public virtual RSystem.RSingle RPpixelsPerUnit
		{
			get
			{
				if(r_PpixelsPerUnit == null)
				{
					r_PpixelsPerUnit = new(this, "pixelsPerUnit", -1);
					r_PpixelsPerUnit.SetBelong(this.instance);
				}
				return r_PpixelsPerUnit;
			}
		}

		/// <summary>
		/// Single spriteAtlasTextureScale
		/// </summary>
		protected RSystem.RSingle r_PspriteAtlasTextureScale;
		public virtual RSystem.RSingle RPspriteAtlasTextureScale
		{
			get
			{
				if(r_PspriteAtlasTextureScale == null)
				{
					r_PspriteAtlasTextureScale = new(this, "spriteAtlasTextureScale", -1);
					r_PspriteAtlasTextureScale.SetBelong(this.instance);
				}
				return r_PspriteAtlasTextureScale;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D associatedAlphaSplitTexture
		/// </summary>
		protected RUnityEngine.RTexture2D r_PassociatedAlphaSplitTexture;
		public virtual RUnityEngine.RTexture2D RPassociatedAlphaSplitTexture
		{
			get
			{
				if(r_PassociatedAlphaSplitTexture == null)
				{
					r_PassociatedAlphaSplitTexture = new(this, "associatedAlphaSplitTexture", -1);
					r_PassociatedAlphaSplitTexture.SetBelong(this.instance);
				}
				return r_PassociatedAlphaSplitTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 pivot
		/// </summary>
		protected RUnityEngine.RVector2 r_Ppivot;
		public virtual RUnityEngine.RVector2 RPpivot
		{
			get
			{
				if(r_Ppivot == null)
				{
					r_Ppivot = new(this, "pivot", -1);
					r_Ppivot.SetBelong(this.instance);
				}
				return r_Ppivot;
			}
		}

		/// <summary>
		/// Boolean packed
		/// </summary>
		protected RSystem.RBoolean r_Ppacked;
		public virtual RSystem.RBoolean RPpacked
		{
			get
			{
				if(r_Ppacked == null)
				{
					r_Ppacked = new(this, "packed", -1);
					r_Ppacked.SetBelong(this.instance);
				}
				return r_Ppacked;
			}
		}

		/// <summary>
		/// UnityEngine.SpritePackingMode packingMode
		/// </summary>
		protected RUnityEngine.RSpritePackingMode r_PpackingMode;
		public virtual RUnityEngine.RSpritePackingMode RPpackingMode
		{
			get
			{
				if(r_PpackingMode == null)
				{
					r_PpackingMode = new(this, "packingMode", -1);
					r_PpackingMode.SetBelong(this.instance);
				}
				return r_PpackingMode;
			}
		}

		/// <summary>
		/// UnityEngine.SpritePackingRotation packingRotation
		/// </summary>
		protected RUnityEngine.RSpritePackingRotation r_PpackingRotation;
		public virtual RUnityEngine.RSpritePackingRotation RPpackingRotation
		{
			get
			{
				if(r_PpackingRotation == null)
				{
					r_PpackingRotation = new(this, "packingRotation", -1);
					r_PpackingRotation.SetBelong(this.instance);
				}
				return r_PpackingRotation;
			}
		}

		/// <summary>
		/// UnityEngine.Rect textureRect
		/// </summary>
		protected RUnityEngine.RRect r_PtextureRect;
		public virtual RUnityEngine.RRect RPtextureRect
		{
			get
			{
				if(r_PtextureRect == null)
				{
					r_PtextureRect = new(this, "textureRect", -1);
					r_PtextureRect.SetBelong(this.instance);
				}
				return r_PtextureRect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 textureRectOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_PtextureRectOffset;
		public virtual RUnityEngine.RVector2 RPtextureRectOffset
		{
			get
			{
				if(r_PtextureRectOffset == null)
				{
					r_PtextureRectOffset = new(this, "textureRectOffset", -1);
					r_PtextureRectOffset.SetBelong(this.instance);
				}
				return r_PtextureRectOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] vertices
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector2> r_Pvertices;
		public virtual RPropertyArray<RUnityEngine.RVector2> RPvertices
		{
			get
			{
				if(r_Pvertices == null)
				{
					r_Pvertices = new(this, "vertices", -1);
					r_Pvertices.SetBelong(this.instance);
				}
				return r_Pvertices;
			}
		}

		/// <summary>
		/// UInt16[] triangles
		/// </summary>
		protected RPropertyArray<RSystem.RUInt16> r_Ptriangles;
		public virtual RPropertyArray<RSystem.RUInt16> RPtriangles
		{
			get
			{
				if(r_Ptriangles == null)
				{
					r_Ptriangles = new(this, "triangles", -1);
					r_Ptriangles.SetBelong(this.instance);
				}
				return r_Ptriangles;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector2> r_Puv;
		public virtual RPropertyArray<RUnityEngine.RVector2> RPuv
		{
			get
			{
				if(r_Puv == null)
				{
					r_Puv = new(this, "uv", -1);
					r_Puv.SetBelong(this.instance);
				}
				return r_Puv;
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
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RUnityEngine.RHideFlags r_PhideFlags;
		public virtual RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
					r_PhideFlags.SetBelong(this.instance);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Int32 GetPackingMode()
		/// </summary>
		protected RMethod r_MGetPackingMode;
		public virtual RMethod RMGetPackingMode
		{
			get
			{
				if(r_MGetPackingMode == null)
				{
					r_MGetPackingMode = new(this, "GetPackingMode", 0);
					r_MGetPackingMode.SetBelong(this.instance);
				}
				return r_MGetPackingMode;
			}
		}

		/// <summary>
		/// Int32 GetPackingRotation()
		/// </summary>
		protected RMethod r_MGetPackingRotation;
		public virtual RMethod RMGetPackingRotation
		{
			get
			{
				if(r_MGetPackingRotation == null)
				{
					r_MGetPackingRotation = new(this, "GetPackingRotation", 0);
					r_MGetPackingRotation.SetBelong(this.instance);
				}
				return r_MGetPackingRotation;
			}
		}

		/// <summary>
		/// Int32 GetPacked()
		/// </summary>
		protected RMethod r_MGetPacked;
		public virtual RMethod RMGetPacked
		{
			get
			{
				if(r_MGetPacked == null)
				{
					r_MGetPacked = new(this, "GetPacked", 0);
					r_MGetPacked.SetBelong(this.instance);
				}
				return r_MGetPacked;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetTextureRect()
		/// </summary>
		protected RMethod r_MGetTextureRect;
		public virtual RMethod RMGetTextureRect
		{
			get
			{
				if(r_MGetTextureRect == null)
				{
					r_MGetTextureRect = new(this, "GetTextureRect", 0);
					r_MGetTextureRect.SetBelong(this.instance);
				}
				return r_MGetTextureRect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTextureRectOffset()
		/// </summary>
		protected RMethod r_MGetTextureRectOffset;
		public virtual RMethod RMGetTextureRectOffset
		{
			get
			{
				if(r_MGetTextureRectOffset == null)
				{
					r_MGetTextureRectOffset = new(this, "GetTextureRectOffset", 0);
					r_MGetTextureRectOffset.SetBelong(this.instance);
				}
				return r_MGetTextureRectOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetInnerUVs()
		/// </summary>
		protected RMethod r_MGetInnerUVs;
		public virtual RMethod RMGetInnerUVs
		{
			get
			{
				if(r_MGetInnerUVs == null)
				{
					r_MGetInnerUVs = new(this, "GetInnerUVs", 0);
					r_MGetInnerUVs.SetBelong(this.instance);
				}
				return r_MGetInnerUVs;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetOuterUVs()
		/// </summary>
		protected RMethod r_MGetOuterUVs;
		public virtual RMethod RMGetOuterUVs
		{
			get
			{
				if(r_MGetOuterUVs == null)
				{
					r_MGetOuterUVs = new(this, "GetOuterUVs", 0);
					r_MGetOuterUVs.SetBelong(this.instance);
				}
				return r_MGetOuterUVs;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetPadding()
		/// </summary>
		protected RMethod r_MGetPadding;
		public virtual RMethod RMGetPadding
		{
			get
			{
				if(r_MGetPadding == null)
				{
					r_MGetPadding = new(this, "GetPadding", 0);
					r_MGetPadding.SetBelong(this.instance);
				}
				return r_MGetPadding;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite CreateSpriteWithoutTextureScripting(UnityEngine.Rect, UnityEngine.Vector2, Single, UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_MCreateSpriteWithoutTextureScripting_Rect_Vector2_Single_Texture2D;
		public static RMethod RMCreateSpriteWithoutTextureScripting_Rect_Vector2_Single_Texture2D
		{
			get
			{
				if(r_MCreateSpriteWithoutTextureScripting_Rect_Vector2_Single_Texture2D == null)
				{
					r_MCreateSpriteWithoutTextureScripting_Rect_Vector2_Single_Texture2D = new(typeof(UnityEngine.Sprite), "CreateSpriteWithoutTextureScripting", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Texture2D));
					r_MCreateSpriteWithoutTextureScripting_Rect_Vector2_Single_Texture2D.SetBelong(null);
				}
				return r_MCreateSpriteWithoutTextureScripting_Rect_Vector2_Single_Texture2D;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, Single, UInt32, UnityEngine.SpriteMeshType, UnityEngine.Vector4, Boolean, UnityEngine.SecondarySpriteTexture[])
		/// </summary>
		protected static RMethod r_MCreateSprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray;
		public static RMethod RMCreateSprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray
		{
			get
			{
				if(r_MCreateSprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray == null)
				{
					r_MCreateSprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray = new(typeof(UnityEngine.Sprite), "CreateSprite", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.UInt32), typeof(UnityEngine.SpriteMeshType), typeof(UnityEngine.Vector4), typeof(System.Boolean), typeof(UnityEngine.SecondarySpriteTexture).MakeArrayType());
					r_MCreateSprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray.SetBelong(null);
				}
				return r_MCreateSprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D GetSecondaryTexture(Int32)
		/// </summary>
		protected RMethod r_MGetSecondaryTexture_Int32;
		public virtual RMethod RMGetSecondaryTexture_Int32
		{
			get
			{
				if(r_MGetSecondaryTexture_Int32 == null)
				{
					r_MGetSecondaryTexture_Int32 = new(this, "GetSecondaryTexture", 0, typeof(System.Int32));
					r_MGetSecondaryTexture_Int32.SetBelong(this.instance);
				}
				return r_MGetSecondaryTexture_Int32;
			}
		}

		/// <summary>
		/// Int32 GetSecondaryTextureCount()
		/// </summary>
		protected RMethod r_MGetSecondaryTextureCount;
		public virtual RMethod RMGetSecondaryTextureCount
		{
			get
			{
				if(r_MGetSecondaryTextureCount == null)
				{
					r_MGetSecondaryTextureCount = new(this, "GetSecondaryTextureCount", 0);
					r_MGetSecondaryTextureCount.SetBelong(this.instance);
				}
				return r_MGetSecondaryTextureCount;
			}
		}

		/// <summary>
		/// Int32 GetSecondaryTextures(UnityEngine.SecondarySpriteTexture[])
		/// </summary>
		protected RMethod r_MGetSecondaryTextures_SecondarySpriteTextureArray;
		public virtual RMethod RMGetSecondaryTextures_SecondarySpriteTextureArray
		{
			get
			{
				if(r_MGetSecondaryTextures_SecondarySpriteTextureArray == null)
				{
					r_MGetSecondaryTextures_SecondarySpriteTextureArray = new(this, "GetSecondaryTextures", 0, typeof(UnityEngine.SecondarySpriteTexture).MakeArrayType());
					r_MGetSecondaryTextures_SecondarySpriteTextureArray.SetBelong(this.instance);
				}
				return r_MGetSecondaryTextures_SecondarySpriteTextureArray;
			}
		}

		/// <summary>
		/// Int32 GetPhysicsShapeCount()
		/// </summary>
		protected RMethod r_MGetPhysicsShapeCount;
		public virtual RMethod RMGetPhysicsShapeCount
		{
			get
			{
				if(r_MGetPhysicsShapeCount == null)
				{
					r_MGetPhysicsShapeCount = new(this, "GetPhysicsShapeCount", 0);
					r_MGetPhysicsShapeCount.SetBelong(this.instance);
				}
				return r_MGetPhysicsShapeCount;
			}
		}

		/// <summary>
		/// Int32 GetPhysicsShapePointCount(Int32)
		/// </summary>
		protected RMethod r_MGetPhysicsShapePointCount_Int32;
		public virtual RMethod RMGetPhysicsShapePointCount_Int32
		{
			get
			{
				if(r_MGetPhysicsShapePointCount_Int32 == null)
				{
					r_MGetPhysicsShapePointCount_Int32 = new(this, "GetPhysicsShapePointCount", 0, typeof(System.Int32));
					r_MGetPhysicsShapePointCount_Int32.SetBelong(this.instance);
				}
				return r_MGetPhysicsShapePointCount_Int32;
			}
		}

		/// <summary>
		/// Int32 Internal_GetPhysicsShapePointCount(Int32)
		/// </summary>
		protected RMethod r_MInternal_GetPhysicsShapePointCount_Int32;
		public virtual RMethod RMInternal_GetPhysicsShapePointCount_Int32
		{
			get
			{
				if(r_MInternal_GetPhysicsShapePointCount_Int32 == null)
				{
					r_MInternal_GetPhysicsShapePointCount_Int32 = new(this, "Internal_GetPhysicsShapePointCount", 0, typeof(System.Int32));
					r_MInternal_GetPhysicsShapePointCount_Int32.SetBelong(this.instance);
				}
				return r_MInternal_GetPhysicsShapePointCount_Int32;
			}
		}

		/// <summary>
		/// Int32 GetPhysicsShape(Int32, System.Collections.Generic.List`1[UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_MGetPhysicsShape_Int32_List_d_Vector2_p_;
		public virtual RMethod RMGetPhysicsShape_Int32_List_d_Vector2_p_
		{
			get
			{
				if(r_MGetPhysicsShape_Int32_List_d_Vector2_p_ == null)
				{
					r_MGetPhysicsShape_Int32_List_d_Vector2_p_ = new(this, "GetPhysicsShape", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector2)));
					r_MGetPhysicsShape_Int32_List_d_Vector2_p_.SetBelong(this.instance);
				}
				return r_MGetPhysicsShape_Int32_List_d_Vector2_p_;
			}
		}

		/// <summary>
		/// Void GetPhysicsShapeImpl(UnityEngine.Sprite, Int32, System.Collections.Generic.List`1[UnityEngine.Vector2])
		/// </summary>
		protected static RMethod r_MGetPhysicsShapeImpl_Sprite_Int32_List_d_Vector2_p_;
		public static RMethod RMGetPhysicsShapeImpl_Sprite_Int32_List_d_Vector2_p_
		{
			get
			{
				if(r_MGetPhysicsShapeImpl_Sprite_Int32_List_d_Vector2_p_ == null)
				{
					r_MGetPhysicsShapeImpl_Sprite_Int32_List_d_Vector2_p_ = new(typeof(UnityEngine.Sprite), "GetPhysicsShapeImpl", 0, typeof(UnityEngine.Sprite), typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector2)));
					r_MGetPhysicsShapeImpl_Sprite_Int32_List_d_Vector2_p_.SetBelong(null);
				}
				return r_MGetPhysicsShapeImpl_Sprite_Int32_List_d_Vector2_p_;
			}
		}

		/// <summary>
		/// Void OverridePhysicsShape(System.Collections.Generic.IList`1[UnityEngine.Vector2[]])
		/// </summary>
		protected RMethod r_MOverridePhysicsShape_IList_d_Vector2Array_p_;
		public virtual RMethod RMOverridePhysicsShape_IList_d_Vector2Array_p_
		{
			get
			{
				if(r_MOverridePhysicsShape_IList_d_Vector2Array_p_ == null)
				{
					r_MOverridePhysicsShape_IList_d_Vector2Array_p_ = new(this, "OverridePhysicsShape", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(UnityEngine.Vector2).MakeArrayType()));
					r_MOverridePhysicsShape_IList_d_Vector2Array_p_.SetBelong(this.instance);
				}
				return r_MOverridePhysicsShape_IList_d_Vector2Array_p_;
			}
		}

		/// <summary>
		/// Void OverridePhysicsShapeCount(UnityEngine.Sprite, Int32)
		/// </summary>
		protected static RMethod r_MOverridePhysicsShapeCount_Sprite_Int32;
		public static RMethod RMOverridePhysicsShapeCount_Sprite_Int32
		{
			get
			{
				if(r_MOverridePhysicsShapeCount_Sprite_Int32 == null)
				{
					r_MOverridePhysicsShapeCount_Sprite_Int32 = new(typeof(UnityEngine.Sprite), "OverridePhysicsShapeCount", 0, typeof(UnityEngine.Sprite), typeof(System.Int32));
					r_MOverridePhysicsShapeCount_Sprite_Int32.SetBelong(null);
				}
				return r_MOverridePhysicsShapeCount_Sprite_Int32;
			}
		}

		/// <summary>
		/// Void OverridePhysicsShape(UnityEngine.Sprite, UnityEngine.Vector2[], Int32)
		/// </summary>
		protected static RMethod r_MOverridePhysicsShape_Sprite_Vector2Array_Int32;
		public static RMethod RMOverridePhysicsShape_Sprite_Vector2Array_Int32
		{
			get
			{
				if(r_MOverridePhysicsShape_Sprite_Vector2Array_Int32 == null)
				{
					r_MOverridePhysicsShape_Sprite_Vector2Array_Int32 = new(typeof(UnityEngine.Sprite), "OverridePhysicsShape", 0, typeof(UnityEngine.Sprite), typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.Int32));
					r_MOverridePhysicsShape_Sprite_Vector2Array_Int32.SetBelong(null);
				}
				return r_MOverridePhysicsShape_Sprite_Vector2Array_Int32;
			}
		}

		/// <summary>
		/// Void OverrideGeometry(UnityEngine.Vector2[], UInt16[])
		/// </summary>
		protected RMethod r_MOverrideGeometry_Vector2Array_UInt16Array;
		public virtual RMethod RMOverrideGeometry_Vector2Array_UInt16Array
		{
			get
			{
				if(r_MOverrideGeometry_Vector2Array_UInt16Array == null)
				{
					r_MOverrideGeometry_Vector2Array_UInt16Array = new(this, "OverrideGeometry", 0, typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.UInt16).MakeArrayType());
					r_MOverrideGeometry_Vector2Array_UInt16Array.SetBelong(this.instance);
				}
				return r_MOverrideGeometry_Vector2Array_UInt16Array;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Rect, UnityEngine.Vector2, Single, UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_MCreate_Rect_Vector2_Single_Texture2D;
		public static RMethod RMCreate_Rect_Vector2_Single_Texture2D
		{
			get
			{
				if(r_MCreate_Rect_Vector2_Single_Texture2D == null)
				{
					r_MCreate_Rect_Vector2_Single_Texture2D = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Texture2D));
					r_MCreate_Rect_Vector2_Single_Texture2D.SetBelong(null);
				}
				return r_MCreate_Rect_Vector2_Single_Texture2D;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Rect, UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_MCreate_Rect_Vector2_Single;
		public static RMethod RMCreate_Rect_Vector2_Single
		{
			get
			{
				if(r_MCreate_Rect_Vector2_Single == null)
				{
					r_MCreate_Rect_Vector2_Single = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single));
					r_MCreate_Rect_Vector2_Single.SetBelong(null);
				}
				return r_MCreate_Rect_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, Single, UInt32, UnityEngine.SpriteMeshType, UnityEngine.Vector4, Boolean)
		/// </summary>
		protected static RMethod r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean;
		public static RMethod RMCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean
		{
			get
			{
				if(r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean == null)
				{
					r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.UInt32), typeof(UnityEngine.SpriteMeshType), typeof(UnityEngine.Vector4), typeof(System.Boolean));
					r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean.SetBelong(null);
				}
				return r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, Single, UInt32, UnityEngine.SpriteMeshType, UnityEngine.Vector4, Boolean, UnityEngine.SecondarySpriteTexture[])
		/// </summary>
		protected static RMethod r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray;
		public static RMethod RMCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray
		{
			get
			{
				if(r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray == null)
				{
					r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.UInt32), typeof(UnityEngine.SpriteMeshType), typeof(UnityEngine.Vector4), typeof(System.Boolean), typeof(UnityEngine.SecondarySpriteTexture).MakeArrayType());
					r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray.SetBelong(null);
				}
				return r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, Single, UInt32, UnityEngine.SpriteMeshType, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4;
		public static RMethod RMCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4
		{
			get
			{
				if(r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4 == null)
				{
					r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4 = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.UInt32), typeof(UnityEngine.SpriteMeshType), typeof(UnityEngine.Vector4));
					r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4.SetBelong(null);
				}
				return r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, Single, UInt32, UnityEngine.SpriteMeshType)
		/// </summary>
		protected static RMethod r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType;
		public static RMethod RMCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType
		{
			get
			{
				if(r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType == null)
				{
					r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.UInt32), typeof(UnityEngine.SpriteMeshType));
					r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType.SetBelong(null);
				}
				return r_MCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, Single, UInt32)
		/// </summary>
		protected static RMethod r_MCreate_Texture2D_Rect_Vector2_Single_UInt32;
		public static RMethod RMCreate_Texture2D_Rect_Vector2_Single_UInt32
		{
			get
			{
				if(r_MCreate_Texture2D_Rect_Vector2_Single_UInt32 == null)
				{
					r_MCreate_Texture2D_Rect_Vector2_Single_UInt32 = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.UInt32));
					r_MCreate_Texture2D_Rect_Vector2_Single_UInt32.SetBelong(null);
				}
				return r_MCreate_Texture2D_Rect_Vector2_Single_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_MCreate_Texture2D_Rect_Vector2_Single;
		public static RMethod RMCreate_Texture2D_Rect_Vector2_Single
		{
			get
			{
				if(r_MCreate_Texture2D_Rect_Vector2_Single == null)
				{
					r_MCreate_Texture2D_Rect_Vector2_Single = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single));
					r_MCreate_Texture2D_Rect_Vector2_Single.SetBelong(null);
				}
				return r_MCreate_Texture2D_Rect_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MCreate_Texture2D_Rect_Vector2;
		public static RMethod RMCreate_Texture2D_Rect_Vector2
		{
			get
			{
				if(r_MCreate_Texture2D_Rect_Vector2 == null)
				{
					r_MCreate_Texture2D_Rect_Vector2 = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_MCreate_Texture2D_Rect_Vector2.SetBelong(null);
				}
				return r_MCreate_Texture2D_Rect_Vector2;
			}
		}

		/// <summary>
		/// Void GetTextureRect_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_MGetTextureRect_Injected_Out_Rect;
		public virtual RMethod RMGetTextureRect_Injected_Out_Rect
		{
			get
			{
				if(r_MGetTextureRect_Injected_Out_Rect == null)
				{
					r_MGetTextureRect_Injected_Out_Rect = new(this, "GetTextureRect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_MGetTextureRect_Injected_Out_Rect.SetBelong(this.instance);
				}
				return r_MGetTextureRect_Injected_Out_Rect;
			}
		}

		/// <summary>
		/// Void GetTextureRectOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MGetTextureRectOffset_Injected_Out_Vector2;
		public virtual RMethod RMGetTextureRectOffset_Injected_Out_Vector2
		{
			get
			{
				if(r_MGetTextureRectOffset_Injected_Out_Vector2 == null)
				{
					r_MGetTextureRectOffset_Injected_Out_Vector2 = new(this, "GetTextureRectOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_MGetTextureRectOffset_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_MGetTextureRectOffset_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void GetInnerUVs_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MGetInnerUVs_Injected_Out_Vector4;
		public virtual RMethod RMGetInnerUVs_Injected_Out_Vector4
		{
			get
			{
				if(r_MGetInnerUVs_Injected_Out_Vector4 == null)
				{
					r_MGetInnerUVs_Injected_Out_Vector4 = new(this, "GetInnerUVs_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_MGetInnerUVs_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_MGetInnerUVs_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void GetOuterUVs_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MGetOuterUVs_Injected_Out_Vector4;
		public virtual RMethod RMGetOuterUVs_Injected_Out_Vector4
		{
			get
			{
				if(r_MGetOuterUVs_Injected_Out_Vector4 == null)
				{
					r_MGetOuterUVs_Injected_Out_Vector4 = new(this, "GetOuterUVs_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_MGetOuterUVs_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_MGetOuterUVs_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void GetPadding_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MGetPadding_Injected_Out_Vector4;
		public virtual RMethod RMGetPadding_Injected_Out_Vector4
		{
			get
			{
				if(r_MGetPadding_Injected_Out_Vector4 == null)
				{
					r_MGetPadding_Injected_Out_Vector4 = new(this, "GetPadding_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_MGetPadding_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_MGetPadding_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite CreateSpriteWithoutTextureScripting_Injected(UnityEngine.Rect ByRef, UnityEngine.Vector2 ByRef, Single, UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_MCreateSpriteWithoutTextureScripting_Injected_Ref_Rect_Ref_Vector2_Single_Texture2D;
		public static RMethod RMCreateSpriteWithoutTextureScripting_Injected_Ref_Rect_Ref_Vector2_Single_Texture2D
		{
			get
			{
				if(r_MCreateSpriteWithoutTextureScripting_Injected_Ref_Rect_Ref_Vector2_Single_Texture2D == null)
				{
					r_MCreateSpriteWithoutTextureScripting_Injected_Ref_Rect_Ref_Vector2_Single_Texture2D = new(typeof(UnityEngine.Sprite), "CreateSpriteWithoutTextureScripting_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Texture2D));
					r_MCreateSpriteWithoutTextureScripting_Injected_Ref_Rect_Ref_Vector2_Single_Texture2D.SetBelong(null);
				}
				return r_MCreateSpriteWithoutTextureScripting_Injected_Ref_Rect_Ref_Vector2_Single_Texture2D;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite CreateSprite_Injected(UnityEngine.Texture2D, UnityEngine.Rect ByRef, UnityEngine.Vector2 ByRef, Single, UInt32, UnityEngine.SpriteMeshType, UnityEngine.Vector4 ByRef, Boolean, UnityEngine.SecondarySpriteTexture[])
		/// </summary>
		protected static RMethod r_MCreateSprite_Injected_Texture2D_Ref_Rect_Ref_Vector2_Single_UInt32_SpriteMeshType_Ref_Vector4_Boolean_SecondarySpriteTextureArray;
		public static RMethod RMCreateSprite_Injected_Texture2D_Ref_Rect_Ref_Vector2_Single_UInt32_SpriteMeshType_Ref_Vector4_Boolean_SecondarySpriteTextureArray
		{
			get
			{
				if(r_MCreateSprite_Injected_Texture2D_Ref_Rect_Ref_Vector2_Single_UInt32_SpriteMeshType_Ref_Vector4_Boolean_SecondarySpriteTextureArray == null)
				{
					r_MCreateSprite_Injected_Texture2D_Ref_Rect_Ref_Vector2_Single_UInt32_SpriteMeshType_Ref_Vector4_Boolean_SecondarySpriteTextureArray = new(typeof(UnityEngine.Sprite), "CreateSprite_Injected", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Single), typeof(System.UInt32), typeof(UnityEngine.SpriteMeshType), typeof(UnityEngine.Vector4).MakeByRefType(), typeof(System.Boolean), typeof(UnityEngine.SecondarySpriteTexture).MakeArrayType());
					r_MCreateSprite_Injected_Texture2D_Ref_Rect_Ref_Vector2_Single_UInt32_SpriteMeshType_Ref_Vector4_Boolean_SecondarySpriteTextureArray.SetBelong(null);
				}
				return r_MCreateSprite_Injected_Texture2D_Ref_Rect_Ref_Vector2_Single_UInt32_SpriteMeshType_Ref_Vector4_Boolean_SecondarySpriteTextureArray;
			}
		}

		/// <summary>
		/// Void get_bounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_Mget_bounds_Injected_Out_Bounds;
		public virtual RMethod RMget_bounds_Injected_Out_Bounds
		{
			get
			{
				if(r_Mget_bounds_Injected_Out_Bounds == null)
				{
					r_Mget_bounds_Injected_Out_Bounds = new(this, "get_bounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_Mget_bounds_Injected_Out_Bounds.SetBelong(this.instance);
				}
				return r_Mget_bounds_Injected_Out_Bounds;
			}
		}

		/// <summary>
		/// Void get_rect_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_Mget_rect_Injected_Out_Rect;
		public virtual RMethod RMget_rect_Injected_Out_Rect
		{
			get
			{
				if(r_Mget_rect_Injected_Out_Rect == null)
				{
					r_Mget_rect_Injected_Out_Rect = new(this, "get_rect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_Mget_rect_Injected_Out_Rect.SetBelong(this.instance);
				}
				return r_Mget_rect_Injected_Out_Rect;
			}
		}

		/// <summary>
		/// Void get_border_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Mget_border_Injected_Out_Vector4;
		public virtual RMethod RMget_border_Injected_Out_Vector4
		{
			get
			{
				if(r_Mget_border_Injected_Out_Vector4 == null)
				{
					r_Mget_border_Injected_Out_Vector4 = new(this, "get_border_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Mget_border_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_Mget_border_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void get_pivot_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mget_pivot_Injected_Out_Vector2;
		public virtual RMethod RMget_pivot_Injected_Out_Vector2
		{
			get
			{
				if(r_Mget_pivot_Injected_Out_Vector2 == null)
				{
					r_Mget_pivot_Injected_Out_Vector2 = new(this, "get_pivot_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Mget_pivot_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_Mget_pivot_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
					r_MGetInstanceID.SetBelong(this.instance);
				}
				return r_MGetInstanceID;
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


        public RSprite() : base("UnityEngine.Sprite")
        {
        }

        public RSprite(System.Object instance) : base("UnityEngine.Sprite")
		{
            SetInstance(instance);
		}

        public RSprite(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSprite(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetPackingMode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPackingMode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetPackingRotation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPackingRotation.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetPacked()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPacked.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Rect GetTextureRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTextureRect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual UnityEngine.Vector2 GetTextureRectOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTextureRectOffset.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector4 GetInnerUVs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInnerUVs.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual UnityEngine.Vector4 GetOuterUVs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOuterUVs.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual UnityEngine.Vector4 GetPadding()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPadding.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Sprite CreateSpriteWithoutTextureScripting(UnityEngine.Rect @rect, UnityEngine.Vector2 @pivot, System.Single @pixelsToUnits, UnityEngine.Texture2D @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @pivot, @pixelsToUnits, @texture};
            var ___result = RMCreateSpriteWithoutTextureScripting_Rect_Vector2_Single_Texture2D.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D @texture, UnityEngine.Rect @rect, UnityEngine.Vector2 @pivot, System.Single @pixelsPerUnit, System.UInt32 @extrude, UnityEngine.SpriteMeshType @meshType, UnityEngine.Vector4 @border, System.Boolean @generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] @secondaryTexture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit, @extrude, @meshType, @border, @generateFallbackPhysicsShape, @secondaryTexture};
            var ___result = RMCreateSprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public virtual UnityEngine.Texture2D GetSecondaryTexture(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetSecondaryTexture_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public virtual System.Int32 GetSecondaryTextureCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSecondaryTextureCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetSecondaryTextures(UnityEngine.SecondarySpriteTexture[] @secondaryTexture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@secondaryTexture};
            var ___result = RMGetSecondaryTextures_SecondarySpriteTextureArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetPhysicsShapeCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPhysicsShapeCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetPhysicsShapePointCount(System.Int32 @shapeIdx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeIdx};
            var ___result = RMGetPhysicsShapePointCount_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Internal_GetPhysicsShapePointCount(System.Int32 @shapeIdx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeIdx};
            var ___result = RMInternal_GetPhysicsShapePointCount_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetPhysicsShape(System.Int32 @shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2> @physicsShape)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeIdx, @physicsShape};
            var ___result = RMGetPhysicsShape_Int32_List_d_Vector2_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void GetPhysicsShapeImpl(UnityEngine.Sprite @sprite, System.Int32 @shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2> @physicsShape)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sprite, @shapeIdx, @physicsShape};
            var ___result = RMGetPhysicsShapeImpl_Sprite_Int32_List_d_Vector2_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OverridePhysicsShape(System.Collections.Generic.IList<UnityEngine.Vector2[]> @physicsShapes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@physicsShapes};
            var ___result = RMOverridePhysicsShape_IList_d_Vector2Array_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void OverridePhysicsShapeCount(UnityEngine.Sprite @sprite, System.Int32 @physicsShapeCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sprite, @physicsShapeCount};
            var ___result = RMOverridePhysicsShapeCount_Sprite_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void OverridePhysicsShape(UnityEngine.Sprite @sprite, UnityEngine.Vector2[] @physicsShape, System.Int32 @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sprite, @physicsShape, @idx};
            var ___result = RMOverridePhysicsShape_Sprite_Vector2Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OverrideGeometry(UnityEngine.Vector2[] @vertices, System.UInt16[] @triangles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices, @triangles};
            var ___result = RMOverrideGeometry_Vector2Array_UInt16Array.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Sprite Create(UnityEngine.Rect @rect, UnityEngine.Vector2 @pivot, System.Single @pixelsToUnits, UnityEngine.Texture2D @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @pivot, @pixelsToUnits, @texture};
            var ___result = RMCreate_Rect_Vector2_Single_Texture2D.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Rect @rect, UnityEngine.Vector2 @pivot, System.Single @pixelsToUnits)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @pivot, @pixelsToUnits};
            var ___result = RMCreate_Rect_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Texture2D @texture, UnityEngine.Rect @rect, UnityEngine.Vector2 @pivot, System.Single @pixelsPerUnit, System.UInt32 @extrude, UnityEngine.SpriteMeshType @meshType, UnityEngine.Vector4 @border, System.Boolean @generateFallbackPhysicsShape)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit, @extrude, @meshType, @border, @generateFallbackPhysicsShape};
            var ___result = RMCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Texture2D @texture, UnityEngine.Rect @rect, UnityEngine.Vector2 @pivot, System.Single @pixelsPerUnit, System.UInt32 @extrude, UnityEngine.SpriteMeshType @meshType, UnityEngine.Vector4 @border, System.Boolean @generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] @secondaryTextures)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit, @extrude, @meshType, @border, @generateFallbackPhysicsShape, @secondaryTextures};
            var ___result = RMCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Texture2D @texture, UnityEngine.Rect @rect, UnityEngine.Vector2 @pivot, System.Single @pixelsPerUnit, System.UInt32 @extrude, UnityEngine.SpriteMeshType @meshType, UnityEngine.Vector4 @border)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit, @extrude, @meshType, @border};
            var ___result = RMCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Texture2D @texture, UnityEngine.Rect @rect, UnityEngine.Vector2 @pivot, System.Single @pixelsPerUnit, System.UInt32 @extrude, UnityEngine.SpriteMeshType @meshType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit, @extrude, @meshType};
            var ___result = RMCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Texture2D @texture, UnityEngine.Rect @rect, UnityEngine.Vector2 @pivot, System.Single @pixelsPerUnit, System.UInt32 @extrude)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit, @extrude};
            var ___result = RMCreate_Texture2D_Rect_Vector2_Single_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Texture2D @texture, UnityEngine.Rect @rect, UnityEngine.Vector2 @pivot, System.Single @pixelsPerUnit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit};
            var ___result = RMCreate_Texture2D_Rect_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Texture2D @texture, UnityEngine.Rect @rect, UnityEngine.Vector2 @pivot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot};
            var ___result = RMCreate_Texture2D_Rect_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public virtual void GetTextureRect_Injected(out UnityEngine.Rect @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetTextureRect_Injected_Out_Rect.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void GetTextureRectOffset_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetTextureRectOffset_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void GetInnerUVs_Injected(out UnityEngine.Vector4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetInnerUVs_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void GetOuterUVs_Injected(out UnityEngine.Vector4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetOuterUVs_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void GetPadding_Injected(out UnityEngine.Vector4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetPadding_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public static UnityEngine.Sprite CreateSpriteWithoutTextureScripting_Injected(ref UnityEngine.Rect @rect, ref UnityEngine.Vector2 @pivot, System.Single @pixelsToUnits, UnityEngine.Texture2D @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @pivot, @pixelsToUnits, @texture};
            var ___result = RMCreateSpriteWithoutTextureScripting_Injected_Ref_Rect_Ref_Vector2_Single_Texture2D.Invoke(___genericsType, ___parameters);
			@rect = (UnityEngine.Rect)___parameters[0];
			@pivot = (UnityEngine.Vector2)___parameters[1];

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite CreateSprite_Injected(UnityEngine.Texture2D @texture, ref UnityEngine.Rect @rect, ref UnityEngine.Vector2 @pivot, System.Single @pixelsPerUnit, System.UInt32 @extrude, UnityEngine.SpriteMeshType @meshType, ref UnityEngine.Vector4 @border, System.Boolean @generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] @secondaryTexture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit, @extrude, @meshType, @border, @generateFallbackPhysicsShape, @secondaryTexture};
            var ___result = RMCreateSprite_Injected_Texture2D_Ref_Rect_Ref_Vector2_Single_UInt32_SpriteMeshType_Ref_Vector4_Boolean_SecondarySpriteTextureArray.Invoke(___genericsType, ___parameters);
			@rect = (UnityEngine.Rect)___parameters[1];
			@pivot = (UnityEngine.Vector2)___parameters[2];
			@border = (UnityEngine.Vector4)___parameters[6];

            return (UnityEngine.Sprite)___result;
        }


        public virtual void get_bounds_Injected(out UnityEngine.Bounds @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_bounds_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void get_rect_Injected(out UnityEngine.Rect @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_rect_Injected_Out_Rect.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void get_border_Injected(out UnityEngine.Vector4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_border_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void get_pivot_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_pivot_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
