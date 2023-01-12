using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IVisualTreeEditorUpdater
	/// </summary>
    public partial class RIVisualTreeEditorUpdater : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeEditorUpdatePhase)
		/// </summary>
		protected RMethod r_MGetUpdater_VisualTreeEditorUpdatePhase;
		public virtual RMethod RMGetUpdater_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_MGetUpdater_VisualTreeEditorUpdatePhase == null)
				{
					r_MGetUpdater_VisualTreeEditorUpdatePhase = new(this, "GetUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
					r_MGetUpdater_VisualTreeEditorUpdatePhase.SetBelong(this.instance);
				}
				return r_MGetUpdater_VisualTreeEditorUpdatePhase;
			}
		}

		/// <summary>
		/// Void SetUpdater(UnityEngine.UIElements.IVisualTreeUpdater, UnityEngine.UIElements.VisualTreeEditorUpdatePhase)
		/// </summary>
		protected RMethod r_MSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase;
		public virtual RMethod RMSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_MSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase == null)
				{
					r_MSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase = new(this, "SetUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IVisualTreeUpdater"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
					r_MSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase.SetBelong(this.instance);
				}
				return r_MSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_MUpdate;
		public virtual RMethod RMUpdate
		{
			get
			{
				if(r_MUpdate == null)
				{
					r_MUpdate = new(this, "Update", 0);
					r_MUpdate.SetBelong(this.instance);
				}
				return r_MUpdate;
			}
		}

		/// <summary>
		/// Void UpdateVisualTreePhase(UnityEngine.UIElements.VisualTreeEditorUpdatePhase)
		/// </summary>
		protected RMethod r_MUpdateVisualTreePhase_VisualTreeEditorUpdatePhase;
		public virtual RMethod RMUpdateVisualTreePhase_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_MUpdateVisualTreePhase_VisualTreeEditorUpdatePhase == null)
				{
					r_MUpdateVisualTreePhase_VisualTreeEditorUpdatePhase = new(this, "UpdateVisualTreePhase", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
					r_MUpdateVisualTreePhase_VisualTreeEditorUpdatePhase.SetBelong(this.instance);
				}
				return r_MUpdateVisualTreePhase_VisualTreeEditorUpdatePhase;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_MOnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod RMOnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_MOnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_MOnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_MOnVersionChanged_VisualElement_VersionChangeType.SetBelong(this.instance);
				}
				return r_MOnVersionChanged_VisualElement_VersionChangeType;
			}
		}


        public RIVisualTreeEditorUpdater() : base("UnityEngine.UIElements.IVisualTreeEditorUpdater")
        {
        }

        public RIVisualTreeEditorUpdater(System.Object instance) : base("UnityEngine.UIElements.IVisualTreeEditorUpdater")
		{
            SetInstance(instance);
		}

        public RIVisualTreeEditorUpdater(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIVisualTreeEditorUpdater(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual RUnityEngine.RUIElements.RIVisualTreeUpdater GetUpdater(RUnityEngine.RUIElements.RVisualTreeEditorUpdatePhase @phase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@phase.Value};
            var ___result = RMGetUpdater_VisualTreeEditorUpdatePhase.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RIVisualTreeUpdater(___result);
        }


        public virtual void SetUpdater(RUnityEngine.RUIElements.RIVisualTreeUpdater @updater, RUnityEngine.RUIElements.RVisualTreeEditorUpdatePhase @phase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updater.Value, @phase.Value};
            var ___result = RMSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateVisualTreePhase(RUnityEngine.RUIElements.RVisualTreeEditorUpdatePhase @phase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@phase.Value};
            var ___result = RMUpdateVisualTreePhase_VisualTreeEditorUpdatePhase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVersionChanged(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RVersionChangeType @versionChangeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @versionChangeType.Value};
            var ___result = RMOnVersionChanged_VisualElement_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


    }
}
