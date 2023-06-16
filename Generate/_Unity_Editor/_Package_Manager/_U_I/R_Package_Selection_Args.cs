
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.PackageSelectionArgs
	/// </summary>
    public partial class RPackageSelectionArgs : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.PackageSelectionArgs");
            }
        }

        public RPackageSelectionArgs() : base("UnityEditor.PackageManager.UI.PackageSelectionArgs")
        {
        }

        public RPackageSelectionArgs(System.Object instance) : base("UnityEditor.PackageManager.UI.PackageSelectionArgs")
		{
            SetInstance(instance);
		}

        public RPackageSelectionArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageSelectionArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEditor.PackageManager.UI.IPackage <package>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackage r_F__0__package__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackage RF__0__package__1__k__BackingField
		{
			get
			{
				if(r_F__0__package__1__k__BackingField == null)
				{
					r_F__0__package__1__k__BackingField = new(this, "<package>k__BackingField");
				}
				return r_F__0__package__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IPackageVersion <packageVersion>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageVersion r_F__0__packageVersion__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageVersion RF__0__packageVersion__1__k__BackingField
		{
			get
			{
				if(r_F__0__packageVersion__1__k__BackingField == null)
				{
					r_F__0__packageVersion__1__k__BackingField = new(this, "<packageVersion>k__BackingField");
				}
				return r_F__0__packageVersion__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IPackageVersion[] <versions>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageVersion> r_F__0__versions__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageVersion> RF__0__versions__1__k__BackingField
		{
			get
			{
				if(r_F__0__versions__1__k__BackingField == null)
				{
					r_F__0__versions__1__k__BackingField = new(this, "<versions>k__BackingField");
				}
				return r_F__0__versions__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IWindow <window>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindow r_F__0__window__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindow RF__0__window__1__k__BackingField
		{
			get
			{
				if(r_F__0__window__1__k__BackingField == null)
				{
					r_F__0__window__1__k__BackingField = new(this, "<window>k__BackingField");
				}
				return r_F__0__window__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IPackage package
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackage r_Ppackage;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackage RPpackage
		{
			get
			{
				if(r_Ppackage == null)
				{
					r_Ppackage = new(this, "package", -1);
				}
				return r_Ppackage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IPackageVersion packageVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageVersion r_PpackageVersion;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageVersion RPpackageVersion
		{
			get
			{
				if(r_PpackageVersion == null)
				{
					r_PpackageVersion = new(this, "packageVersion", -1);
				}
				return r_PpackageVersion;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IPackageVersion[] versions
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageVersion> r_Pversions;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageVersion> RPversions
		{
			get
			{
				if(r_Pversions == null)
				{
					r_Pversions = new(this, "versions", -1);
				}
				return r_Pversions;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IWindow window
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindow r_Pwindow;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindow RPwindow
		{
			get
			{
				if(r_Pwindow == null)
				{
					r_Pwindow = new(this, "window", -1);
				}
				return r_Pwindow;
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
				}
				return r_MMemberwiseClone;
			}
		}


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
