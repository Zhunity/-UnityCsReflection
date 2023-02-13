
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager
{
	/// <summary>
	/// UnityEditor.PackageManager.RepositoryInfo
	/// </summary>
    public partial class RRepositoryInfo : RMember //
    {

		/// <summary>
		/// System.String m_Type
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_Type;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_Type
		{
			get
			{
				if(r_Fm_Type == null)
				{
					r_Fm_Type = new(this, "m_Type");
					r_Fm_Type.SetBelong(this.instance);
				}
				return r_Fm_Type;
			}
		}

		/// <summary>
		/// System.String m_Url
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_Url;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_Url
		{
			get
			{
				if(r_Fm_Url == null)
				{
					r_Fm_Url = new(this, "m_Url");
					r_Fm_Url.SetBelong(this.instance);
				}
				return r_Fm_Url;
			}
		}

		/// <summary>
		/// System.String m_Revision
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_Revision;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_Revision
		{
			get
			{
				if(r_Fm_Revision == null)
				{
					r_Fm_Revision = new(this, "m_Revision");
					r_Fm_Revision.SetBelong(this.instance);
				}
				return r_Fm_Revision;
			}
		}

		/// <summary>
		/// System.String m_Path
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_Path;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_Path
		{
			get
			{
				if(r_Fm_Path == null)
				{
					r_Fm_Path = new(this, "m_Path");
					r_Fm_Path.SetBelong(this.instance);
				}
				return r_Fm_Path;
			}
		}

		/// <summary>
		/// System.String type
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Ptype;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPtype
		{
			get
			{
				if(r_Ptype == null)
				{
					r_Ptype = new(this, "type", -1);
					r_Ptype.SetBelong(this.instance);
				}
				return r_Ptype;
			}
		}

		/// <summary>
		/// System.String url
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Purl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPurl
		{
			get
			{
				if(r_Purl == null)
				{
					r_Purl = new(this, "url", -1);
					r_Purl.SetBelong(this.instance);
				}
				return r_Purl;
			}
		}

		/// <summary>
		/// System.String revision
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Prevision;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPrevision
		{
			get
			{
				if(r_Prevision == null)
				{
					r_Prevision = new(this, "revision", -1);
					r_Prevision.SetBelong(this.instance);
				}
				return r_Prevision;
			}
		}

		/// <summary>
		/// System.String path
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Ppath;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPpath
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


        public RRepositoryInfo() : base("UnityEditor.PackageManager.RepositoryInfo")
        {
        }

        public RRepositoryInfo(System.Object instance) : base("UnityEditor.PackageManager.RepositoryInfo")
		{
            SetInstance(instance);
		}

        public RRepositoryInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRepositoryInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
