
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.ManifestResourceInfo
	/// </summary>
    public partial class RManifestResourceInfo : RMember //
    {

		/// <summary>
		/// System.Reflection.Assembly <ReferencedAssembly>k__BackingField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RAssembly r_F__0__ReferencedAssembly__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RAssembly RF__0__ReferencedAssembly__1__k__BackingField
		{
			get
			{
				if(r_F__0__ReferencedAssembly__1__k__BackingField == null)
				{
					r_F__0__ReferencedAssembly__1__k__BackingField = new(this, "<ReferencedAssembly>k__BackingField");
					r_F__0__ReferencedAssembly__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__ReferencedAssembly__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <FileName>k__BackingField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_F__0__FileName__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RF__0__FileName__1__k__BackingField
		{
			get
			{
				if(r_F__0__FileName__1__k__BackingField == null)
				{
					r_F__0__FileName__1__k__BackingField = new(this, "<FileName>k__BackingField");
					r_F__0__FileName__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__FileName__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Reflection.ResourceLocation <ResourceLocation>k__BackingField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RResourceLocation r_F__0__ResourceLocation__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RResourceLocation RF__0__ResourceLocation__1__k__BackingField
		{
			get
			{
				if(r_F__0__ResourceLocation__1__k__BackingField == null)
				{
					r_F__0__ResourceLocation__1__k__BackingField = new(this, "<ResourceLocation>k__BackingField");
					r_F__0__ResourceLocation__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__ResourceLocation__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly ReferencedAssembly
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RAssembly r_PReferencedAssembly;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RAssembly RPReferencedAssembly
		{
			get
			{
				if(r_PReferencedAssembly == null)
				{
					r_PReferencedAssembly = new(this, "ReferencedAssembly", -1);
					r_PReferencedAssembly.SetBelong(this.instance);
				}
				return r_PReferencedAssembly;
			}
		}

		/// <summary>
		/// System.String FileName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PFileName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPFileName
		{
			get
			{
				if(r_PFileName == null)
				{
					r_PFileName = new(this, "FileName", -1);
					r_PFileName.SetBelong(this.instance);
				}
				return r_PFileName;
			}
		}

		/// <summary>
		/// System.Reflection.ResourceLocation ResourceLocation
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RResourceLocation r_PResourceLocation;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RResourceLocation RPResourceLocation
		{
			get
			{
				if(r_PResourceLocation == null)
				{
					r_PResourceLocation = new(this, "ResourceLocation", -1);
					r_PResourceLocation.SetBelong(this.instance);
				}
				return r_PResourceLocation;
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


        public RManifestResourceInfo() : base("System.Reflection.ManifestResourceInfo")
        {
        }

        public RManifestResourceInfo(System.Object instance) : base("System.Reflection.ManifestResourceInfo")
		{
            SetInstance(instance);
		}

        public RManifestResourceInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RManifestResourceInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
