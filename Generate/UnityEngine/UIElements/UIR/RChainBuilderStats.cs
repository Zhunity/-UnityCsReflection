using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.ChainBuilderStats
	/// </summary>
    public partial class RChainBuilderStats : RMember //
    {

		/// <summary>
		/// System.UInt32 elementsAdded
		/// </summary>
		protected RSystem.RUInt32 r_elementsAdded;
		public virtual RSystem.RUInt32 RelementsAdded
		{
			get
			{
				if(r_elementsAdded == null)
				{
					r_elementsAdded = new(this, "elementsAdded");
					r_elementsAdded.SetBelong(this.instance);
				}
				return r_elementsAdded;
			}
		}

		/// <summary>
		/// System.UInt32 elementsRemoved
		/// </summary>
		protected RSystem.RUInt32 r_elementsRemoved;
		public virtual RSystem.RUInt32 RelementsRemoved
		{
			get
			{
				if(r_elementsRemoved == null)
				{
					r_elementsRemoved = new(this, "elementsRemoved");
					r_elementsRemoved.SetBelong(this.instance);
				}
				return r_elementsRemoved;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveClipUpdates
		/// </summary>
		protected RSystem.RUInt32 r_recursiveClipUpdates;
		public virtual RSystem.RUInt32 RrecursiveClipUpdates
		{
			get
			{
				if(r_recursiveClipUpdates == null)
				{
					r_recursiveClipUpdates = new(this, "recursiveClipUpdates");
					r_recursiveClipUpdates.SetBelong(this.instance);
				}
				return r_recursiveClipUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveClipUpdatesExpanded
		/// </summary>
		protected RSystem.RUInt32 r_recursiveClipUpdatesExpanded;
		public virtual RSystem.RUInt32 RrecursiveClipUpdatesExpanded
		{
			get
			{
				if(r_recursiveClipUpdatesExpanded == null)
				{
					r_recursiveClipUpdatesExpanded = new(this, "recursiveClipUpdatesExpanded");
					r_recursiveClipUpdatesExpanded.SetBelong(this.instance);
				}
				return r_recursiveClipUpdatesExpanded;
			}
		}

		/// <summary>
		/// System.UInt32 nonRecursiveClipUpdates
		/// </summary>
		protected RSystem.RUInt32 r_nonRecursiveClipUpdates;
		public virtual RSystem.RUInt32 RnonRecursiveClipUpdates
		{
			get
			{
				if(r_nonRecursiveClipUpdates == null)
				{
					r_nonRecursiveClipUpdates = new(this, "nonRecursiveClipUpdates");
					r_nonRecursiveClipUpdates.SetBelong(this.instance);
				}
				return r_nonRecursiveClipUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveTransformUpdates
		/// </summary>
		protected RSystem.RUInt32 r_recursiveTransformUpdates;
		public virtual RSystem.RUInt32 RrecursiveTransformUpdates
		{
			get
			{
				if(r_recursiveTransformUpdates == null)
				{
					r_recursiveTransformUpdates = new(this, "recursiveTransformUpdates");
					r_recursiveTransformUpdates.SetBelong(this.instance);
				}
				return r_recursiveTransformUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveTransformUpdatesExpanded
		/// </summary>
		protected RSystem.RUInt32 r_recursiveTransformUpdatesExpanded;
		public virtual RSystem.RUInt32 RrecursiveTransformUpdatesExpanded
		{
			get
			{
				if(r_recursiveTransformUpdatesExpanded == null)
				{
					r_recursiveTransformUpdatesExpanded = new(this, "recursiveTransformUpdatesExpanded");
					r_recursiveTransformUpdatesExpanded.SetBelong(this.instance);
				}
				return r_recursiveTransformUpdatesExpanded;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveOpacityUpdates
		/// </summary>
		protected RSystem.RUInt32 r_recursiveOpacityUpdates;
		public virtual RSystem.RUInt32 RrecursiveOpacityUpdates
		{
			get
			{
				if(r_recursiveOpacityUpdates == null)
				{
					r_recursiveOpacityUpdates = new(this, "recursiveOpacityUpdates");
					r_recursiveOpacityUpdates.SetBelong(this.instance);
				}
				return r_recursiveOpacityUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveOpacityUpdatesExpanded
		/// </summary>
		protected RSystem.RUInt32 r_recursiveOpacityUpdatesExpanded;
		public virtual RSystem.RUInt32 RrecursiveOpacityUpdatesExpanded
		{
			get
			{
				if(r_recursiveOpacityUpdatesExpanded == null)
				{
					r_recursiveOpacityUpdatesExpanded = new(this, "recursiveOpacityUpdatesExpanded");
					r_recursiveOpacityUpdatesExpanded.SetBelong(this.instance);
				}
				return r_recursiveOpacityUpdatesExpanded;
			}
		}

		/// <summary>
		/// System.UInt32 opacityIdUpdates
		/// </summary>
		protected RSystem.RUInt32 r_opacityIdUpdates;
		public virtual RSystem.RUInt32 RopacityIdUpdates
		{
			get
			{
				if(r_opacityIdUpdates == null)
				{
					r_opacityIdUpdates = new(this, "opacityIdUpdates");
					r_opacityIdUpdates.SetBelong(this.instance);
				}
				return r_opacityIdUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 colorUpdates
		/// </summary>
		protected RSystem.RUInt32 r_colorUpdates;
		public virtual RSystem.RUInt32 RcolorUpdates
		{
			get
			{
				if(r_colorUpdates == null)
				{
					r_colorUpdates = new(this, "colorUpdates");
					r_colorUpdates.SetBelong(this.instance);
				}
				return r_colorUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 colorUpdatesExpanded
		/// </summary>
		protected RSystem.RUInt32 r_colorUpdatesExpanded;
		public virtual RSystem.RUInt32 RcolorUpdatesExpanded
		{
			get
			{
				if(r_colorUpdatesExpanded == null)
				{
					r_colorUpdatesExpanded = new(this, "colorUpdatesExpanded");
					r_colorUpdatesExpanded.SetBelong(this.instance);
				}
				return r_colorUpdatesExpanded;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveVisualUpdates
		/// </summary>
		protected RSystem.RUInt32 r_recursiveVisualUpdates;
		public virtual RSystem.RUInt32 RrecursiveVisualUpdates
		{
			get
			{
				if(r_recursiveVisualUpdates == null)
				{
					r_recursiveVisualUpdates = new(this, "recursiveVisualUpdates");
					r_recursiveVisualUpdates.SetBelong(this.instance);
				}
				return r_recursiveVisualUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveVisualUpdatesExpanded
		/// </summary>
		protected RSystem.RUInt32 r_recursiveVisualUpdatesExpanded;
		public virtual RSystem.RUInt32 RrecursiveVisualUpdatesExpanded
		{
			get
			{
				if(r_recursiveVisualUpdatesExpanded == null)
				{
					r_recursiveVisualUpdatesExpanded = new(this, "recursiveVisualUpdatesExpanded");
					r_recursiveVisualUpdatesExpanded.SetBelong(this.instance);
				}
				return r_recursiveVisualUpdatesExpanded;
			}
		}

		/// <summary>
		/// System.UInt32 nonRecursiveVisualUpdates
		/// </summary>
		protected RSystem.RUInt32 r_nonRecursiveVisualUpdates;
		public virtual RSystem.RUInt32 RnonRecursiveVisualUpdates
		{
			get
			{
				if(r_nonRecursiveVisualUpdates == null)
				{
					r_nonRecursiveVisualUpdates = new(this, "nonRecursiveVisualUpdates");
					r_nonRecursiveVisualUpdates.SetBelong(this.instance);
				}
				return r_nonRecursiveVisualUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 dirtyProcessed
		/// </summary>
		protected RSystem.RUInt32 r_dirtyProcessed;
		public virtual RSystem.RUInt32 RdirtyProcessed
		{
			get
			{
				if(r_dirtyProcessed == null)
				{
					r_dirtyProcessed = new(this, "dirtyProcessed");
					r_dirtyProcessed.SetBelong(this.instance);
				}
				return r_dirtyProcessed;
			}
		}

		/// <summary>
		/// System.UInt32 nudgeTransformed
		/// </summary>
		protected RSystem.RUInt32 r_nudgeTransformed;
		public virtual RSystem.RUInt32 RnudgeTransformed
		{
			get
			{
				if(r_nudgeTransformed == null)
				{
					r_nudgeTransformed = new(this, "nudgeTransformed");
					r_nudgeTransformed.SetBelong(this.instance);
				}
				return r_nudgeTransformed;
			}
		}

		/// <summary>
		/// System.UInt32 boneTransformed
		/// </summary>
		protected RSystem.RUInt32 r_boneTransformed;
		public virtual RSystem.RUInt32 RboneTransformed
		{
			get
			{
				if(r_boneTransformed == null)
				{
					r_boneTransformed = new(this, "boneTransformed");
					r_boneTransformed.SetBelong(this.instance);
				}
				return r_boneTransformed;
			}
		}

		/// <summary>
		/// System.UInt32 skipTransformed
		/// </summary>
		protected RSystem.RUInt32 r_skipTransformed;
		public virtual RSystem.RUInt32 RskipTransformed
		{
			get
			{
				if(r_skipTransformed == null)
				{
					r_skipTransformed = new(this, "skipTransformed");
					r_skipTransformed.SetBelong(this.instance);
				}
				return r_skipTransformed;
			}
		}

		/// <summary>
		/// System.UInt32 visualUpdateTransformed
		/// </summary>
		protected RSystem.RUInt32 r_visualUpdateTransformed;
		public virtual RSystem.RUInt32 RvisualUpdateTransformed
		{
			get
			{
				if(r_visualUpdateTransformed == null)
				{
					r_visualUpdateTransformed = new(this, "visualUpdateTransformed");
					r_visualUpdateTransformed.SetBelong(this.instance);
				}
				return r_visualUpdateTransformed;
			}
		}

		/// <summary>
		/// System.UInt32 updatedMeshAllocations
		/// </summary>
		protected RSystem.RUInt32 r_updatedMeshAllocations;
		public virtual RSystem.RUInt32 RupdatedMeshAllocations
		{
			get
			{
				if(r_updatedMeshAllocations == null)
				{
					r_updatedMeshAllocations = new(this, "updatedMeshAllocations");
					r_updatedMeshAllocations.SetBelong(this.instance);
				}
				return r_updatedMeshAllocations;
			}
		}

		/// <summary>
		/// System.UInt32 newMeshAllocations
		/// </summary>
		protected RSystem.RUInt32 r_newMeshAllocations;
		public virtual RSystem.RUInt32 RnewMeshAllocations
		{
			get
			{
				if(r_newMeshAllocations == null)
				{
					r_newMeshAllocations = new(this, "newMeshAllocations");
					r_newMeshAllocations.SetBelong(this.instance);
				}
				return r_newMeshAllocations;
			}
		}

		/// <summary>
		/// System.UInt32 groupTransformElementsChanged
		/// </summary>
		protected RSystem.RUInt32 r_groupTransformElementsChanged;
		public virtual RSystem.RUInt32 RgroupTransformElementsChanged
		{
			get
			{
				if(r_groupTransformElementsChanged == null)
				{
					r_groupTransformElementsChanged = new(this, "groupTransformElementsChanged");
					r_groupTransformElementsChanged.SetBelong(this.instance);
				}
				return r_groupTransformElementsChanged;
			}
		}

		/// <summary>
		/// System.UInt32 immedateRenderersActive
		/// </summary>
		protected RSystem.RUInt32 r_immedateRenderersActive;
		public virtual RSystem.RUInt32 RimmedateRenderersActive
		{
			get
			{
				if(r_immedateRenderersActive == null)
				{
					r_immedateRenderersActive = new(this, "immedateRenderersActive");
					r_immedateRenderersActive.SetBelong(this.instance);
				}
				return r_immedateRenderersActive;
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


        public RChainBuilderStats() : base("UnityEngine.UIElements.UIR.ChainBuilderStats")
        {
        }

        public RChainBuilderStats(System.Object instance) : base("UnityEngine.UIElements.UIR.ChainBuilderStats")
		{
            SetInstance(instance);
		}

        public RChainBuilderStats(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RChainBuilderStats(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
