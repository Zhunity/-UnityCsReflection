using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.TextureFormat
	/// </summary>
    public partial class RTextureFormat : RMember //
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
		/// UnityEngine.TextureFormat Alpha8
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FAlpha8;
		public static RUnityEngine.RTextureFormat RFAlpha8
		{
			get
			{
				if(r_FAlpha8 == null)
				{
					r_FAlpha8 = new(typeof(UnityEngine.TextureFormat), "Alpha8");
					r_FAlpha8.SetBelong(null);
				}
				return r_FAlpha8;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ARGB4444
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FARGB4444;
		public static RUnityEngine.RTextureFormat RFARGB4444
		{
			get
			{
				if(r_FARGB4444 == null)
				{
					r_FARGB4444 = new(typeof(UnityEngine.TextureFormat), "ARGB4444");
					r_FARGB4444.SetBelong(null);
				}
				return r_FARGB4444;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RGB24
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRGB24;
		public static RUnityEngine.RTextureFormat RFRGB24
		{
			get
			{
				if(r_FRGB24 == null)
				{
					r_FRGB24 = new(typeof(UnityEngine.TextureFormat), "RGB24");
					r_FRGB24.SetBelong(null);
				}
				return r_FRGB24;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RGBA32
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRGBA32;
		public static RUnityEngine.RTextureFormat RFRGBA32
		{
			get
			{
				if(r_FRGBA32 == null)
				{
					r_FRGBA32 = new(typeof(UnityEngine.TextureFormat), "RGBA32");
					r_FRGBA32.SetBelong(null);
				}
				return r_FRGBA32;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ARGB32
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FARGB32;
		public static RUnityEngine.RTextureFormat RFARGB32
		{
			get
			{
				if(r_FARGB32 == null)
				{
					r_FARGB32 = new(typeof(UnityEngine.TextureFormat), "ARGB32");
					r_FARGB32.SetBelong(null);
				}
				return r_FARGB32;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RGB565
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRGB565;
		public static RUnityEngine.RTextureFormat RFRGB565
		{
			get
			{
				if(r_FRGB565 == null)
				{
					r_FRGB565 = new(typeof(UnityEngine.TextureFormat), "RGB565");
					r_FRGB565.SetBelong(null);
				}
				return r_FRGB565;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat R16
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FR16;
		public static RUnityEngine.RTextureFormat RFR16
		{
			get
			{
				if(r_FR16 == null)
				{
					r_FR16 = new(typeof(UnityEngine.TextureFormat), "R16");
					r_FR16.SetBelong(null);
				}
				return r_FR16;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat DXT1
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FDXT1;
		public static RUnityEngine.RTextureFormat RFDXT1
		{
			get
			{
				if(r_FDXT1 == null)
				{
					r_FDXT1 = new(typeof(UnityEngine.TextureFormat), "DXT1");
					r_FDXT1.SetBelong(null);
				}
				return r_FDXT1;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat DXT5
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FDXT5;
		public static RUnityEngine.RTextureFormat RFDXT5
		{
			get
			{
				if(r_FDXT5 == null)
				{
					r_FDXT5 = new(typeof(UnityEngine.TextureFormat), "DXT5");
					r_FDXT5.SetBelong(null);
				}
				return r_FDXT5;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RGBA4444
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRGBA4444;
		public static RUnityEngine.RTextureFormat RFRGBA4444
		{
			get
			{
				if(r_FRGBA4444 == null)
				{
					r_FRGBA4444 = new(typeof(UnityEngine.TextureFormat), "RGBA4444");
					r_FRGBA4444.SetBelong(null);
				}
				return r_FRGBA4444;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat BGRA32
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FBGRA32;
		public static RUnityEngine.RTextureFormat RFBGRA32
		{
			get
			{
				if(r_FBGRA32 == null)
				{
					r_FBGRA32 = new(typeof(UnityEngine.TextureFormat), "BGRA32");
					r_FBGRA32.SetBelong(null);
				}
				return r_FBGRA32;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RHalf
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRHalf;
		public static RUnityEngine.RTextureFormat RFRHalf
		{
			get
			{
				if(r_FRHalf == null)
				{
					r_FRHalf = new(typeof(UnityEngine.TextureFormat), "RHalf");
					r_FRHalf.SetBelong(null);
				}
				return r_FRHalf;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RGHalf
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRGHalf;
		public static RUnityEngine.RTextureFormat RFRGHalf
		{
			get
			{
				if(r_FRGHalf == null)
				{
					r_FRGHalf = new(typeof(UnityEngine.TextureFormat), "RGHalf");
					r_FRGHalf.SetBelong(null);
				}
				return r_FRGHalf;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RGBAHalf
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRGBAHalf;
		public static RUnityEngine.RTextureFormat RFRGBAHalf
		{
			get
			{
				if(r_FRGBAHalf == null)
				{
					r_FRGBAHalf = new(typeof(UnityEngine.TextureFormat), "RGBAHalf");
					r_FRGBAHalf.SetBelong(null);
				}
				return r_FRGBAHalf;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RFloat
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRFloat;
		public static RUnityEngine.RTextureFormat RFRFloat
		{
			get
			{
				if(r_FRFloat == null)
				{
					r_FRFloat = new(typeof(UnityEngine.TextureFormat), "RFloat");
					r_FRFloat.SetBelong(null);
				}
				return r_FRFloat;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RGFloat
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRGFloat;
		public static RUnityEngine.RTextureFormat RFRGFloat
		{
			get
			{
				if(r_FRGFloat == null)
				{
					r_FRGFloat = new(typeof(UnityEngine.TextureFormat), "RGFloat");
					r_FRGFloat.SetBelong(null);
				}
				return r_FRGFloat;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RGBAFloat
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRGBAFloat;
		public static RUnityEngine.RTextureFormat RFRGBAFloat
		{
			get
			{
				if(r_FRGBAFloat == null)
				{
					r_FRGBAFloat = new(typeof(UnityEngine.TextureFormat), "RGBAFloat");
					r_FRGBAFloat.SetBelong(null);
				}
				return r_FRGBAFloat;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat YUY2
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FYUY2;
		public static RUnityEngine.RTextureFormat RFYUY2
		{
			get
			{
				if(r_FYUY2 == null)
				{
					r_FYUY2 = new(typeof(UnityEngine.TextureFormat), "YUY2");
					r_FYUY2.SetBelong(null);
				}
				return r_FYUY2;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RGB9e5Float
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRGB9e5Float;
		public static RUnityEngine.RTextureFormat RFRGB9e5Float
		{
			get
			{
				if(r_FRGB9e5Float == null)
				{
					r_FRGB9e5Float = new(typeof(UnityEngine.TextureFormat), "RGB9e5Float");
					r_FRGB9e5Float.SetBelong(null);
				}
				return r_FRGB9e5Float;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat BC4
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FBC4;
		public static RUnityEngine.RTextureFormat RFBC4
		{
			get
			{
				if(r_FBC4 == null)
				{
					r_FBC4 = new(typeof(UnityEngine.TextureFormat), "BC4");
					r_FBC4.SetBelong(null);
				}
				return r_FBC4;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat BC5
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FBC5;
		public static RUnityEngine.RTextureFormat RFBC5
		{
			get
			{
				if(r_FBC5 == null)
				{
					r_FBC5 = new(typeof(UnityEngine.TextureFormat), "BC5");
					r_FBC5.SetBelong(null);
				}
				return r_FBC5;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat BC6H
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FBC6H;
		public static RUnityEngine.RTextureFormat RFBC6H
		{
			get
			{
				if(r_FBC6H == null)
				{
					r_FBC6H = new(typeof(UnityEngine.TextureFormat), "BC6H");
					r_FBC6H.SetBelong(null);
				}
				return r_FBC6H;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat BC7
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FBC7;
		public static RUnityEngine.RTextureFormat RFBC7
		{
			get
			{
				if(r_FBC7 == null)
				{
					r_FBC7 = new(typeof(UnityEngine.TextureFormat), "BC7");
					r_FBC7.SetBelong(null);
				}
				return r_FBC7;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat DXT1Crunched
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FDXT1Crunched;
		public static RUnityEngine.RTextureFormat RFDXT1Crunched
		{
			get
			{
				if(r_FDXT1Crunched == null)
				{
					r_FDXT1Crunched = new(typeof(UnityEngine.TextureFormat), "DXT1Crunched");
					r_FDXT1Crunched.SetBelong(null);
				}
				return r_FDXT1Crunched;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat DXT5Crunched
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FDXT5Crunched;
		public static RUnityEngine.RTextureFormat RFDXT5Crunched
		{
			get
			{
				if(r_FDXT5Crunched == null)
				{
					r_FDXT5Crunched = new(typeof(UnityEngine.TextureFormat), "DXT5Crunched");
					r_FDXT5Crunched.SetBelong(null);
				}
				return r_FDXT5Crunched;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat PVRTC_RGB2
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FPVRTC_RGB2;
		public static RUnityEngine.RTextureFormat RFPVRTC_RGB2
		{
			get
			{
				if(r_FPVRTC_RGB2 == null)
				{
					r_FPVRTC_RGB2 = new(typeof(UnityEngine.TextureFormat), "PVRTC_RGB2");
					r_FPVRTC_RGB2.SetBelong(null);
				}
				return r_FPVRTC_RGB2;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat PVRTC_RGBA2
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FPVRTC_RGBA2;
		public static RUnityEngine.RTextureFormat RFPVRTC_RGBA2
		{
			get
			{
				if(r_FPVRTC_RGBA2 == null)
				{
					r_FPVRTC_RGBA2 = new(typeof(UnityEngine.TextureFormat), "PVRTC_RGBA2");
					r_FPVRTC_RGBA2.SetBelong(null);
				}
				return r_FPVRTC_RGBA2;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat PVRTC_RGB4
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FPVRTC_RGB4;
		public static RUnityEngine.RTextureFormat RFPVRTC_RGB4
		{
			get
			{
				if(r_FPVRTC_RGB4 == null)
				{
					r_FPVRTC_RGB4 = new(typeof(UnityEngine.TextureFormat), "PVRTC_RGB4");
					r_FPVRTC_RGB4.SetBelong(null);
				}
				return r_FPVRTC_RGB4;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat PVRTC_RGBA4
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FPVRTC_RGBA4;
		public static RUnityEngine.RTextureFormat RFPVRTC_RGBA4
		{
			get
			{
				if(r_FPVRTC_RGBA4 == null)
				{
					r_FPVRTC_RGBA4 = new(typeof(UnityEngine.TextureFormat), "PVRTC_RGBA4");
					r_FPVRTC_RGBA4.SetBelong(null);
				}
				return r_FPVRTC_RGBA4;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ETC_RGB4
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FETC_RGB4;
		public static RUnityEngine.RTextureFormat RFETC_RGB4
		{
			get
			{
				if(r_FETC_RGB4 == null)
				{
					r_FETC_RGB4 = new(typeof(UnityEngine.TextureFormat), "ETC_RGB4");
					r_FETC_RGB4.SetBelong(null);
				}
				return r_FETC_RGB4;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ATC_RGB4
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FATC_RGB4;
		public static RUnityEngine.RTextureFormat RFATC_RGB4
		{
			get
			{
				if(r_FATC_RGB4 == null)
				{
					r_FATC_RGB4 = new(typeof(UnityEngine.TextureFormat), "ATC_RGB4");
					r_FATC_RGB4.SetBelong(null);
				}
				return r_FATC_RGB4;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ATC_RGBA8
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FATC_RGBA8;
		public static RUnityEngine.RTextureFormat RFATC_RGBA8
		{
			get
			{
				if(r_FATC_RGBA8 == null)
				{
					r_FATC_RGBA8 = new(typeof(UnityEngine.TextureFormat), "ATC_RGBA8");
					r_FATC_RGBA8.SetBelong(null);
				}
				return r_FATC_RGBA8;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat EAC_R
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FEAC_R;
		public static RUnityEngine.RTextureFormat RFEAC_R
		{
			get
			{
				if(r_FEAC_R == null)
				{
					r_FEAC_R = new(typeof(UnityEngine.TextureFormat), "EAC_R");
					r_FEAC_R.SetBelong(null);
				}
				return r_FEAC_R;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat EAC_R_SIGNED
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FEAC_R_SIGNED;
		public static RUnityEngine.RTextureFormat RFEAC_R_SIGNED
		{
			get
			{
				if(r_FEAC_R_SIGNED == null)
				{
					r_FEAC_R_SIGNED = new(typeof(UnityEngine.TextureFormat), "EAC_R_SIGNED");
					r_FEAC_R_SIGNED.SetBelong(null);
				}
				return r_FEAC_R_SIGNED;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat EAC_RG
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FEAC_RG;
		public static RUnityEngine.RTextureFormat RFEAC_RG
		{
			get
			{
				if(r_FEAC_RG == null)
				{
					r_FEAC_RG = new(typeof(UnityEngine.TextureFormat), "EAC_RG");
					r_FEAC_RG.SetBelong(null);
				}
				return r_FEAC_RG;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat EAC_RG_SIGNED
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FEAC_RG_SIGNED;
		public static RUnityEngine.RTextureFormat RFEAC_RG_SIGNED
		{
			get
			{
				if(r_FEAC_RG_SIGNED == null)
				{
					r_FEAC_RG_SIGNED = new(typeof(UnityEngine.TextureFormat), "EAC_RG_SIGNED");
					r_FEAC_RG_SIGNED.SetBelong(null);
				}
				return r_FEAC_RG_SIGNED;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ETC2_RGB
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FETC2_RGB;
		public static RUnityEngine.RTextureFormat RFETC2_RGB
		{
			get
			{
				if(r_FETC2_RGB == null)
				{
					r_FETC2_RGB = new(typeof(UnityEngine.TextureFormat), "ETC2_RGB");
					r_FETC2_RGB.SetBelong(null);
				}
				return r_FETC2_RGB;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ETC2_RGBA1
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FETC2_RGBA1;
		public static RUnityEngine.RTextureFormat RFETC2_RGBA1
		{
			get
			{
				if(r_FETC2_RGBA1 == null)
				{
					r_FETC2_RGBA1 = new(typeof(UnityEngine.TextureFormat), "ETC2_RGBA1");
					r_FETC2_RGBA1.SetBelong(null);
				}
				return r_FETC2_RGBA1;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ETC2_RGBA8
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FETC2_RGBA8;
		public static RUnityEngine.RTextureFormat RFETC2_RGBA8
		{
			get
			{
				if(r_FETC2_RGBA8 == null)
				{
					r_FETC2_RGBA8 = new(typeof(UnityEngine.TextureFormat), "ETC2_RGBA8");
					r_FETC2_RGBA8.SetBelong(null);
				}
				return r_FETC2_RGBA8;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_4x4
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_4x4;
		public static RUnityEngine.RTextureFormat RFASTC_4x4
		{
			get
			{
				if(r_FASTC_4x4 == null)
				{
					r_FASTC_4x4 = new(typeof(UnityEngine.TextureFormat), "ASTC_4x4");
					r_FASTC_4x4.SetBelong(null);
				}
				return r_FASTC_4x4;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_5x5
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_5x5;
		public static RUnityEngine.RTextureFormat RFASTC_5x5
		{
			get
			{
				if(r_FASTC_5x5 == null)
				{
					r_FASTC_5x5 = new(typeof(UnityEngine.TextureFormat), "ASTC_5x5");
					r_FASTC_5x5.SetBelong(null);
				}
				return r_FASTC_5x5;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_6x6
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_6x6;
		public static RUnityEngine.RTextureFormat RFASTC_6x6
		{
			get
			{
				if(r_FASTC_6x6 == null)
				{
					r_FASTC_6x6 = new(typeof(UnityEngine.TextureFormat), "ASTC_6x6");
					r_FASTC_6x6.SetBelong(null);
				}
				return r_FASTC_6x6;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_8x8
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_8x8;
		public static RUnityEngine.RTextureFormat RFASTC_8x8
		{
			get
			{
				if(r_FASTC_8x8 == null)
				{
					r_FASTC_8x8 = new(typeof(UnityEngine.TextureFormat), "ASTC_8x8");
					r_FASTC_8x8.SetBelong(null);
				}
				return r_FASTC_8x8;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_10x10
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_10x10;
		public static RUnityEngine.RTextureFormat RFASTC_10x10
		{
			get
			{
				if(r_FASTC_10x10 == null)
				{
					r_FASTC_10x10 = new(typeof(UnityEngine.TextureFormat), "ASTC_10x10");
					r_FASTC_10x10.SetBelong(null);
				}
				return r_FASTC_10x10;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_12x12
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_12x12;
		public static RUnityEngine.RTextureFormat RFASTC_12x12
		{
			get
			{
				if(r_FASTC_12x12 == null)
				{
					r_FASTC_12x12 = new(typeof(UnityEngine.TextureFormat), "ASTC_12x12");
					r_FASTC_12x12.SetBelong(null);
				}
				return r_FASTC_12x12;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ETC_RGB4_3DS
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FETC_RGB4_3DS;
		public static RUnityEngine.RTextureFormat RFETC_RGB4_3DS
		{
			get
			{
				if(r_FETC_RGB4_3DS == null)
				{
					r_FETC_RGB4_3DS = new(typeof(UnityEngine.TextureFormat), "ETC_RGB4_3DS");
					r_FETC_RGB4_3DS.SetBelong(null);
				}
				return r_FETC_RGB4_3DS;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ETC_RGBA8_3DS
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FETC_RGBA8_3DS;
		public static RUnityEngine.RTextureFormat RFETC_RGBA8_3DS
		{
			get
			{
				if(r_FETC_RGBA8_3DS == null)
				{
					r_FETC_RGBA8_3DS = new(typeof(UnityEngine.TextureFormat), "ETC_RGBA8_3DS");
					r_FETC_RGBA8_3DS.SetBelong(null);
				}
				return r_FETC_RGBA8_3DS;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RG16
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRG16;
		public static RUnityEngine.RTextureFormat RFRG16
		{
			get
			{
				if(r_FRG16 == null)
				{
					r_FRG16 = new(typeof(UnityEngine.TextureFormat), "RG16");
					r_FRG16.SetBelong(null);
				}
				return r_FRG16;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat R8
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FR8;
		public static RUnityEngine.RTextureFormat RFR8
		{
			get
			{
				if(r_FR8 == null)
				{
					r_FR8 = new(typeof(UnityEngine.TextureFormat), "R8");
					r_FR8.SetBelong(null);
				}
				return r_FR8;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ETC_RGB4Crunched
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FETC_RGB4Crunched;
		public static RUnityEngine.RTextureFormat RFETC_RGB4Crunched
		{
			get
			{
				if(r_FETC_RGB4Crunched == null)
				{
					r_FETC_RGB4Crunched = new(typeof(UnityEngine.TextureFormat), "ETC_RGB4Crunched");
					r_FETC_RGB4Crunched.SetBelong(null);
				}
				return r_FETC_RGB4Crunched;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ETC2_RGBA8Crunched
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FETC2_RGBA8Crunched;
		public static RUnityEngine.RTextureFormat RFETC2_RGBA8Crunched
		{
			get
			{
				if(r_FETC2_RGBA8Crunched == null)
				{
					r_FETC2_RGBA8Crunched = new(typeof(UnityEngine.TextureFormat), "ETC2_RGBA8Crunched");
					r_FETC2_RGBA8Crunched.SetBelong(null);
				}
				return r_FETC2_RGBA8Crunched;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_HDR_4x4
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_HDR_4x4;
		public static RUnityEngine.RTextureFormat RFASTC_HDR_4x4
		{
			get
			{
				if(r_FASTC_HDR_4x4 == null)
				{
					r_FASTC_HDR_4x4 = new(typeof(UnityEngine.TextureFormat), "ASTC_HDR_4x4");
					r_FASTC_HDR_4x4.SetBelong(null);
				}
				return r_FASTC_HDR_4x4;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_HDR_5x5
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_HDR_5x5;
		public static RUnityEngine.RTextureFormat RFASTC_HDR_5x5
		{
			get
			{
				if(r_FASTC_HDR_5x5 == null)
				{
					r_FASTC_HDR_5x5 = new(typeof(UnityEngine.TextureFormat), "ASTC_HDR_5x5");
					r_FASTC_HDR_5x5.SetBelong(null);
				}
				return r_FASTC_HDR_5x5;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_HDR_6x6
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_HDR_6x6;
		public static RUnityEngine.RTextureFormat RFASTC_HDR_6x6
		{
			get
			{
				if(r_FASTC_HDR_6x6 == null)
				{
					r_FASTC_HDR_6x6 = new(typeof(UnityEngine.TextureFormat), "ASTC_HDR_6x6");
					r_FASTC_HDR_6x6.SetBelong(null);
				}
				return r_FASTC_HDR_6x6;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_HDR_8x8
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_HDR_8x8;
		public static RUnityEngine.RTextureFormat RFASTC_HDR_8x8
		{
			get
			{
				if(r_FASTC_HDR_8x8 == null)
				{
					r_FASTC_HDR_8x8 = new(typeof(UnityEngine.TextureFormat), "ASTC_HDR_8x8");
					r_FASTC_HDR_8x8.SetBelong(null);
				}
				return r_FASTC_HDR_8x8;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_HDR_10x10
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_HDR_10x10;
		public static RUnityEngine.RTextureFormat RFASTC_HDR_10x10
		{
			get
			{
				if(r_FASTC_HDR_10x10 == null)
				{
					r_FASTC_HDR_10x10 = new(typeof(UnityEngine.TextureFormat), "ASTC_HDR_10x10");
					r_FASTC_HDR_10x10.SetBelong(null);
				}
				return r_FASTC_HDR_10x10;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_HDR_12x12
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_HDR_12x12;
		public static RUnityEngine.RTextureFormat RFASTC_HDR_12x12
		{
			get
			{
				if(r_FASTC_HDR_12x12 == null)
				{
					r_FASTC_HDR_12x12 = new(typeof(UnityEngine.TextureFormat), "ASTC_HDR_12x12");
					r_FASTC_HDR_12x12.SetBelong(null);
				}
				return r_FASTC_HDR_12x12;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RG32
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRG32;
		public static RUnityEngine.RTextureFormat RFRG32
		{
			get
			{
				if(r_FRG32 == null)
				{
					r_FRG32 = new(typeof(UnityEngine.TextureFormat), "RG32");
					r_FRG32.SetBelong(null);
				}
				return r_FRG32;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RGB48
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRGB48;
		public static RUnityEngine.RTextureFormat RFRGB48
		{
			get
			{
				if(r_FRGB48 == null)
				{
					r_FRGB48 = new(typeof(UnityEngine.TextureFormat), "RGB48");
					r_FRGB48.SetBelong(null);
				}
				return r_FRGB48;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat RGBA64
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FRGBA64;
		public static RUnityEngine.RTextureFormat RFRGBA64
		{
			get
			{
				if(r_FRGBA64 == null)
				{
					r_FRGBA64 = new(typeof(UnityEngine.TextureFormat), "RGBA64");
					r_FRGBA64.SetBelong(null);
				}
				return r_FRGBA64;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_RGB_4x4
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_RGB_4x4;
		public static RUnityEngine.RTextureFormat RFASTC_RGB_4x4
		{
			get
			{
				if(r_FASTC_RGB_4x4 == null)
				{
					r_FASTC_RGB_4x4 = new(typeof(UnityEngine.TextureFormat), "ASTC_RGB_4x4");
					r_FASTC_RGB_4x4.SetBelong(null);
				}
				return r_FASTC_RGB_4x4;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_RGB_5x5
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_RGB_5x5;
		public static RUnityEngine.RTextureFormat RFASTC_RGB_5x5
		{
			get
			{
				if(r_FASTC_RGB_5x5 == null)
				{
					r_FASTC_RGB_5x5 = new(typeof(UnityEngine.TextureFormat), "ASTC_RGB_5x5");
					r_FASTC_RGB_5x5.SetBelong(null);
				}
				return r_FASTC_RGB_5x5;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_RGB_6x6
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_RGB_6x6;
		public static RUnityEngine.RTextureFormat RFASTC_RGB_6x6
		{
			get
			{
				if(r_FASTC_RGB_6x6 == null)
				{
					r_FASTC_RGB_6x6 = new(typeof(UnityEngine.TextureFormat), "ASTC_RGB_6x6");
					r_FASTC_RGB_6x6.SetBelong(null);
				}
				return r_FASTC_RGB_6x6;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_RGB_8x8
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_RGB_8x8;
		public static RUnityEngine.RTextureFormat RFASTC_RGB_8x8
		{
			get
			{
				if(r_FASTC_RGB_8x8 == null)
				{
					r_FASTC_RGB_8x8 = new(typeof(UnityEngine.TextureFormat), "ASTC_RGB_8x8");
					r_FASTC_RGB_8x8.SetBelong(null);
				}
				return r_FASTC_RGB_8x8;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_RGB_10x10
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_RGB_10x10;
		public static RUnityEngine.RTextureFormat RFASTC_RGB_10x10
		{
			get
			{
				if(r_FASTC_RGB_10x10 == null)
				{
					r_FASTC_RGB_10x10 = new(typeof(UnityEngine.TextureFormat), "ASTC_RGB_10x10");
					r_FASTC_RGB_10x10.SetBelong(null);
				}
				return r_FASTC_RGB_10x10;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_RGB_12x12
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_RGB_12x12;
		public static RUnityEngine.RTextureFormat RFASTC_RGB_12x12
		{
			get
			{
				if(r_FASTC_RGB_12x12 == null)
				{
					r_FASTC_RGB_12x12 = new(typeof(UnityEngine.TextureFormat), "ASTC_RGB_12x12");
					r_FASTC_RGB_12x12.SetBelong(null);
				}
				return r_FASTC_RGB_12x12;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_RGBA_4x4
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_RGBA_4x4;
		public static RUnityEngine.RTextureFormat RFASTC_RGBA_4x4
		{
			get
			{
				if(r_FASTC_RGBA_4x4 == null)
				{
					r_FASTC_RGBA_4x4 = new(typeof(UnityEngine.TextureFormat), "ASTC_RGBA_4x4");
					r_FASTC_RGBA_4x4.SetBelong(null);
				}
				return r_FASTC_RGBA_4x4;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_RGBA_5x5
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_RGBA_5x5;
		public static RUnityEngine.RTextureFormat RFASTC_RGBA_5x5
		{
			get
			{
				if(r_FASTC_RGBA_5x5 == null)
				{
					r_FASTC_RGBA_5x5 = new(typeof(UnityEngine.TextureFormat), "ASTC_RGBA_5x5");
					r_FASTC_RGBA_5x5.SetBelong(null);
				}
				return r_FASTC_RGBA_5x5;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_RGBA_6x6
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_RGBA_6x6;
		public static RUnityEngine.RTextureFormat RFASTC_RGBA_6x6
		{
			get
			{
				if(r_FASTC_RGBA_6x6 == null)
				{
					r_FASTC_RGBA_6x6 = new(typeof(UnityEngine.TextureFormat), "ASTC_RGBA_6x6");
					r_FASTC_RGBA_6x6.SetBelong(null);
				}
				return r_FASTC_RGBA_6x6;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_RGBA_8x8
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_RGBA_8x8;
		public static RUnityEngine.RTextureFormat RFASTC_RGBA_8x8
		{
			get
			{
				if(r_FASTC_RGBA_8x8 == null)
				{
					r_FASTC_RGBA_8x8 = new(typeof(UnityEngine.TextureFormat), "ASTC_RGBA_8x8");
					r_FASTC_RGBA_8x8.SetBelong(null);
				}
				return r_FASTC_RGBA_8x8;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_RGBA_10x10
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_RGBA_10x10;
		public static RUnityEngine.RTextureFormat RFASTC_RGBA_10x10
		{
			get
			{
				if(r_FASTC_RGBA_10x10 == null)
				{
					r_FASTC_RGBA_10x10 = new(typeof(UnityEngine.TextureFormat), "ASTC_RGBA_10x10");
					r_FASTC_RGBA_10x10.SetBelong(null);
				}
				return r_FASTC_RGBA_10x10;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat ASTC_RGBA_12x12
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FASTC_RGBA_12x12;
		public static RUnityEngine.RTextureFormat RFASTC_RGBA_12x12
		{
			get
			{
				if(r_FASTC_RGBA_12x12 == null)
				{
					r_FASTC_RGBA_12x12 = new(typeof(UnityEngine.TextureFormat), "ASTC_RGBA_12x12");
					r_FASTC_RGBA_12x12.SetBelong(null);
				}
				return r_FASTC_RGBA_12x12;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat PVRTC_2BPP_RGB
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FPVRTC_2BPP_RGB;
		public static RUnityEngine.RTextureFormat RFPVRTC_2BPP_RGB
		{
			get
			{
				if(r_FPVRTC_2BPP_RGB == null)
				{
					r_FPVRTC_2BPP_RGB = new(typeof(UnityEngine.TextureFormat), "PVRTC_2BPP_RGB");
					r_FPVRTC_2BPP_RGB.SetBelong(null);
				}
				return r_FPVRTC_2BPP_RGB;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat PVRTC_2BPP_RGBA
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FPVRTC_2BPP_RGBA;
		public static RUnityEngine.RTextureFormat RFPVRTC_2BPP_RGBA
		{
			get
			{
				if(r_FPVRTC_2BPP_RGBA == null)
				{
					r_FPVRTC_2BPP_RGBA = new(typeof(UnityEngine.TextureFormat), "PVRTC_2BPP_RGBA");
					r_FPVRTC_2BPP_RGBA.SetBelong(null);
				}
				return r_FPVRTC_2BPP_RGBA;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat PVRTC_4BPP_RGB
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FPVRTC_4BPP_RGB;
		public static RUnityEngine.RTextureFormat RFPVRTC_4BPP_RGB
		{
			get
			{
				if(r_FPVRTC_4BPP_RGB == null)
				{
					r_FPVRTC_4BPP_RGB = new(typeof(UnityEngine.TextureFormat), "PVRTC_4BPP_RGB");
					r_FPVRTC_4BPP_RGB.SetBelong(null);
				}
				return r_FPVRTC_4BPP_RGB;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat PVRTC_4BPP_RGBA
		/// </summary>
		protected static RUnityEngine.RTextureFormat r_FPVRTC_4BPP_RGBA;
		public static RUnityEngine.RTextureFormat RFPVRTC_4BPP_RGBA
		{
			get
			{
				if(r_FPVRTC_4BPP_RGBA == null)
				{
					r_FPVRTC_4BPP_RGBA = new(typeof(UnityEngine.TextureFormat), "PVRTC_4BPP_RGBA");
					r_FPVRTC_4BPP_RGBA.SetBelong(null);
				}
				return r_FPVRTC_4BPP_RGBA;
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


        public RTextureFormat() : base("UnityEngine.TextureFormat")
        {
        }

        public RTextureFormat(System.Object instance) : base("UnityEngine.TextureFormat")
		{
            SetInstance(instance);
		}

        public RTextureFormat(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextureFormat(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
