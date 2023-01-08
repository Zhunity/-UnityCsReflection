using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ILiveReloadAssetTracker`1
	/// </summary>
    public partial class RILiveReloadAssetTracker<T> : RMember // where T : UnityEngine.ScriptableObject
    {

		/// <summary>
		/// Int32 StartTrackingAsset(T)
		/// </summary>
		protected RMethod r_StartTrackingAsset_T;
		public virtual RMethod RStartTrackingAsset_T
		{
			get
			{
				if(r_StartTrackingAsset_T == null)
				{
					r_StartTrackingAsset_T = new(this, "StartTrackingAsset", 0, Type.MakeGenericMethodParameter(0));
					r_StartTrackingAsset_T.SetBelong(this.instance);
				}
				return r_StartTrackingAsset_T;
			}
		}

		/// <summary>
		/// Void StopTrackingAsset(T)
		/// </summary>
		protected RMethod r_StopTrackingAsset_T;
		public virtual RMethod RStopTrackingAsset_T
		{
			get
			{
				if(r_StopTrackingAsset_T == null)
				{
					r_StopTrackingAsset_T = new(this, "StopTrackingAsset", 0, Type.MakeGenericMethodParameter(0));
					r_StopTrackingAsset_T.SetBelong(this.instance);
				}
				return r_StopTrackingAsset_T;
			}
		}

		/// <summary>
		/// Boolean IsTrackingAsset(T)
		/// </summary>
		protected RMethod r_IsTrackingAsset_T;
		public virtual RMethod RIsTrackingAsset_T
		{
			get
			{
				if(r_IsTrackingAsset_T == null)
				{
					r_IsTrackingAsset_T = new(this, "IsTrackingAsset", 0, Type.MakeGenericMethodParameter(0));
					r_IsTrackingAsset_T.SetBelong(this.instance);
				}
				return r_IsTrackingAsset_T;
			}
		}

		/// <summary>
		/// Boolean IsTrackingAssets()
		/// </summary>
		protected RMethod r_IsTrackingAssets;
		public virtual RMethod RIsTrackingAssets
		{
			get
			{
				if(r_IsTrackingAssets == null)
				{
					r_IsTrackingAssets = new(this, "IsTrackingAssets", 0);
					r_IsTrackingAssets.SetBelong(this.instance);
				}
				return r_IsTrackingAssets;
			}
		}

		/// <summary>
		/// Boolean CheckTrackedAssetsDirty()
		/// </summary>
		protected RMethod r_CheckTrackedAssetsDirty;
		public virtual RMethod RCheckTrackedAssetsDirty
		{
			get
			{
				if(r_CheckTrackedAssetsDirty == null)
				{
					r_CheckTrackedAssetsDirty = new(this, "CheckTrackedAssetsDirty", 0);
					r_CheckTrackedAssetsDirty.SetBelong(this.instance);
				}
				return r_CheckTrackedAssetsDirty;
			}
		}

		/// <summary>
		/// Void UpdateAssetTrackerCounts(T, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_UpdateAssetTrackerCounts_T_Int32_Int32_Int32_Int32;
		public virtual RMethod RUpdateAssetTrackerCounts_T_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_UpdateAssetTrackerCounts_T_Int32_Int32_Int32_Int32 == null)
				{
					r_UpdateAssetTrackerCounts_T_Int32_Int32_Int32_Int32 = new(this, "UpdateAssetTrackerCounts", 0, Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_UpdateAssetTrackerCounts_T_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_UpdateAssetTrackerCounts_T_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean OnAssetsImported(System.Collections.Generic.HashSet`1[T], System.Collections.Generic.HashSet`1[System.String])
		/// </summary>
		protected RMethod r_OnAssetsImported_HashSet_d_T_p__HashSet_d_String_p_;
		public virtual RMethod ROnAssetsImported_HashSet_d_T_p__HashSet_d_String_p_
		{
			get
			{
				if(r_OnAssetsImported_HashSet_d_T_p__HashSet_d_String_p_ == null)
				{
					r_OnAssetsImported_HashSet_d_T_p__HashSet_d_String_p_ = new(this, "OnAssetsImported", 0, typeof(System.Collections.Generic.HashSet<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(System.String)));
					r_OnAssetsImported_HashSet_d_T_p__HashSet_d_String_p_.SetBelong(this.instance);
				}
				return r_OnAssetsImported_HashSet_d_T_p__HashSet_d_String_p_;
			}
		}

		/// <summary>
		/// Void OnTrackedAssetChanged()
		/// </summary>
		protected RMethod r_OnTrackedAssetChanged;
		public virtual RMethod ROnTrackedAssetChanged
		{
			get
			{
				if(r_OnTrackedAssetChanged == null)
				{
					r_OnTrackedAssetChanged = new(this, "OnTrackedAssetChanged", 0);
					r_OnTrackedAssetChanged.SetBelong(this.instance);
				}
				return r_OnTrackedAssetChanged;
			}
		}


        public RILiveReloadAssetTracker() : base("UnityEngine.UIElements.ILiveReloadAssetTracker`1")
        {
        }

        public RILiveReloadAssetTracker(System.Object instance) : base("UnityEngine.UIElements.ILiveReloadAssetTracker`1")
		{
            SetInstance(instance);
		}

        public RILiveReloadAssetTracker(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RILiveReloadAssetTracker(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 StartTrackingAsset(T @asset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asset};
            var ___result = RStartTrackingAsset_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void StopTrackingAsset(T @asset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asset};
            var ___result = RStopTrackingAsset_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsTrackingAsset(T @asset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asset};
            var ___result = RIsTrackingAsset_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsTrackingAssets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsTrackingAssets.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CheckTrackedAssetsDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckTrackedAssetsDirty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UpdateAssetTrackerCounts(T @asset, System.Int32 @newDirtyCount, System.Int32 @newElementCount, System.Int32 @newInlinePropertiesCount, System.Int32 @newAttributePropertiesDirtyCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asset, @newDirtyCount, @newElementCount, @newInlinePropertiesCount, @newAttributePropertiesDirtyCount};
            var ___result = RUpdateAssetTrackerCounts_T_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean OnAssetsImported(System.Collections.Generic.HashSet<T> @changedAssets, System.Collections.Generic.HashSet<System.String> @deletedAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changedAssets, @deletedAssets};
            var ___result = ROnAssetsImported_HashSet_d_T_p__HashSet_d_String_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnTrackedAssetChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnTrackedAssetChanged.Invoke(___genericsType, ___parameters);

            
        }


    }
}
