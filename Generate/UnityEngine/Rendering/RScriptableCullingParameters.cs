using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.ScriptableCullingParameters
	/// </summary>
    public partial class RScriptableCullingParameters : RMember //
    {

		/// <summary>
		/// System.Int32 m_IsOrthographic
		/// </summary>
		protected RSystem.RInt32 r_Fm_IsOrthographic;
		public virtual RSystem.RInt32 RFm_IsOrthographic
		{
			get
			{
				if(r_Fm_IsOrthographic == null)
				{
					r_Fm_IsOrthographic = new(this, "m_IsOrthographic");
					r_Fm_IsOrthographic.SetBelong(this.instance);
				}
				return r_Fm_IsOrthographic;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LODParameters m_LODParameters
		/// </summary>
		protected RUnityEngine.RRendering.RLODParameters r_Fm_LODParameters;
		public virtual RUnityEngine.RRendering.RLODParameters RFm_LODParameters
		{
			get
			{
				if(r_Fm_LODParameters == null)
				{
					r_Fm_LODParameters = new(this, "m_LODParameters");
					r_Fm_LODParameters.SetBelong(this.instance);
				}
				return r_Fm_LODParameters;
			}
		}

		/// <summary>
		/// System.Int32 k_MaximumCullingPlaneCount
		/// </summary>
		protected static RSystem.RInt32 r_Fk_MaximumCullingPlaneCount;
		public static RSystem.RInt32 RFk_MaximumCullingPlaneCount
		{
			get
			{
				if(r_Fk_MaximumCullingPlaneCount == null)
				{
					r_Fk_MaximumCullingPlaneCount = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "k_MaximumCullingPlaneCount");
					r_Fk_MaximumCullingPlaneCount.SetBelong(null);
				}
				return r_Fk_MaximumCullingPlaneCount;
			}
		}

		/// <summary>
		/// System.Int32 maximumCullingPlaneCount
		/// </summary>
		protected static RSystem.RInt32 r_FmaximumCullingPlaneCount;
		public static RSystem.RInt32 RFmaximumCullingPlaneCount
		{
			get
			{
				if(r_FmaximumCullingPlaneCount == null)
				{
					r_FmaximumCullingPlaneCount = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "maximumCullingPlaneCount");
					r_FmaximumCullingPlaneCount.SetBelong(null);
				}
				return r_FmaximumCullingPlaneCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ScriptableCullingParameters+<m_CullingPlanes>e__FixedBuffer m_CullingPlanes
		/// </summary>
		protected RUnityEngine.RRendering.RScriptableCullingParameters.R__0__m_CullingPlanes__1__e__FixedBuffer r_Fm_CullingPlanes;
		public virtual RUnityEngine.RRendering.RScriptableCullingParameters.R__0__m_CullingPlanes__1__e__FixedBuffer RFm_CullingPlanes
		{
			get
			{
				if(r_Fm_CullingPlanes == null)
				{
					r_Fm_CullingPlanes = new(this, "m_CullingPlanes");
					r_Fm_CullingPlanes.SetBelong(this.instance);
				}
				return r_Fm_CullingPlanes;
			}
		}

		/// <summary>
		/// System.Int32 m_CullingPlaneCount
		/// </summary>
		protected RSystem.RInt32 r_Fm_CullingPlaneCount;
		public virtual RSystem.RInt32 RFm_CullingPlaneCount
		{
			get
			{
				if(r_Fm_CullingPlaneCount == null)
				{
					r_Fm_CullingPlaneCount = new(this, "m_CullingPlaneCount");
					r_Fm_CullingPlaneCount.SetBelong(this.instance);
				}
				return r_Fm_CullingPlaneCount;
			}
		}

		/// <summary>
		/// System.UInt32 m_CullingMask
		/// </summary>
		protected RSystem.RUInt32 r_Fm_CullingMask;
		public virtual RSystem.RUInt32 RFm_CullingMask
		{
			get
			{
				if(r_Fm_CullingMask == null)
				{
					r_Fm_CullingMask = new(this, "m_CullingMask");
					r_Fm_CullingMask.SetBelong(this.instance);
				}
				return r_Fm_CullingMask;
			}
		}

		/// <summary>
		/// System.UInt64 m_SceneMask
		/// </summary>
		protected RSystem.RUInt64 r_Fm_SceneMask;
		public virtual RSystem.RUInt64 RFm_SceneMask
		{
			get
			{
				if(r_Fm_SceneMask == null)
				{
					r_Fm_SceneMask = new(this, "m_SceneMask");
					r_Fm_SceneMask.SetBelong(this.instance);
				}
				return r_Fm_SceneMask;
			}
		}

		/// <summary>
		/// System.UInt64 m_ViewID
		/// </summary>
		protected RSystem.RUInt64 r_Fm_ViewID;
		public virtual RSystem.RUInt64 RFm_ViewID
		{
			get
			{
				if(r_Fm_ViewID == null)
				{
					r_Fm_ViewID = new(this, "m_ViewID");
					r_Fm_ViewID.SetBelong(this.instance);
				}
				return r_Fm_ViewID;
			}
		}

		/// <summary>
		/// System.Int32 k_LayerCount
		/// </summary>
		protected static RSystem.RInt32 r_Fk_LayerCount;
		public static RSystem.RInt32 RFk_LayerCount
		{
			get
			{
				if(r_Fk_LayerCount == null)
				{
					r_Fk_LayerCount = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "k_LayerCount");
					r_Fk_LayerCount.SetBelong(null);
				}
				return r_Fk_LayerCount;
			}
		}

		/// <summary>
		/// System.Int32 layerCount
		/// </summary>
		protected static RSystem.RInt32 r_FlayerCount;
		public static RSystem.RInt32 RFlayerCount
		{
			get
			{
				if(r_FlayerCount == null)
				{
					r_FlayerCount = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "layerCount");
					r_FlayerCount.SetBelong(null);
				}
				return r_FlayerCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ScriptableCullingParameters+<m_LayerFarCullDistances>e__FixedBuffer m_LayerFarCullDistances
		/// </summary>
		protected RUnityEngine.RRendering.RScriptableCullingParameters.R__0__m_LayerFarCullDistances__1__e__FixedBuffer r_Fm_LayerFarCullDistances;
		public virtual RUnityEngine.RRendering.RScriptableCullingParameters.R__0__m_LayerFarCullDistances__1__e__FixedBuffer RFm_LayerFarCullDistances
		{
			get
			{
				if(r_Fm_LayerFarCullDistances == null)
				{
					r_Fm_LayerFarCullDistances = new(this, "m_LayerFarCullDistances");
					r_Fm_LayerFarCullDistances.SetBelong(this.instance);
				}
				return r_Fm_LayerFarCullDistances;
			}
		}

		/// <summary>
		/// System.Int32 m_LayerCull
		/// </summary>
		protected RSystem.RInt32 r_Fm_LayerCull;
		public virtual RSystem.RInt32 RFm_LayerCull
		{
			get
			{
				if(r_Fm_LayerCull == null)
				{
					r_Fm_LayerCull = new(this, "m_LayerCull");
					r_Fm_LayerCull.SetBelong(this.instance);
				}
				return r_Fm_LayerCull;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_CullingMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_Fm_CullingMatrix;
		public virtual RUnityEngine.RMatrix4x4 RFm_CullingMatrix
		{
			get
			{
				if(r_Fm_CullingMatrix == null)
				{
					r_Fm_CullingMatrix = new(this, "m_CullingMatrix");
					r_Fm_CullingMatrix.SetBelong(this.instance);
				}
				return r_Fm_CullingMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_Origin
		/// </summary>
		protected RUnityEngine.RVector3 r_Fm_Origin;
		public virtual RUnityEngine.RVector3 RFm_Origin
		{
			get
			{
				if(r_Fm_Origin == null)
				{
					r_Fm_Origin = new(this, "m_Origin");
					r_Fm_Origin.SetBelong(this.instance);
				}
				return r_Fm_Origin;
			}
		}

		/// <summary>
		/// System.Single m_ShadowDistance
		/// </summary>
		protected RSystem.RSingle r_Fm_ShadowDistance;
		public virtual RSystem.RSingle RFm_ShadowDistance
		{
			get
			{
				if(r_Fm_ShadowDistance == null)
				{
					r_Fm_ShadowDistance = new(this, "m_ShadowDistance");
					r_Fm_ShadowDistance.SetBelong(this.instance);
				}
				return r_Fm_ShadowDistance;
			}
		}

		/// <summary>
		/// System.Single m_ShadowNearPlaneOffset
		/// </summary>
		protected RSystem.RSingle r_Fm_ShadowNearPlaneOffset;
		public virtual RSystem.RSingle RFm_ShadowNearPlaneOffset
		{
			get
			{
				if(r_Fm_ShadowNearPlaneOffset == null)
				{
					r_Fm_ShadowNearPlaneOffset = new(this, "m_ShadowNearPlaneOffset");
					r_Fm_ShadowNearPlaneOffset.SetBelong(this.instance);
				}
				return r_Fm_ShadowNearPlaneOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CullingOptions m_CullingOptions
		/// </summary>
		protected RUnityEngine.RRendering.RCullingOptions r_Fm_CullingOptions;
		public virtual RUnityEngine.RRendering.RCullingOptions RFm_CullingOptions
		{
			get
			{
				if(r_Fm_CullingOptions == null)
				{
					r_Fm_CullingOptions = new(this, "m_CullingOptions");
					r_Fm_CullingOptions.SetBelong(this.instance);
				}
				return r_Fm_CullingOptions;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria
		/// </summary>
		protected RUnityEngine.RRendering.RReflectionProbeSortingCriteria r_Fm_ReflectionProbeSortingCriteria;
		public virtual RUnityEngine.RRendering.RReflectionProbeSortingCriteria RFm_ReflectionProbeSortingCriteria
		{
			get
			{
				if(r_Fm_ReflectionProbeSortingCriteria == null)
				{
					r_Fm_ReflectionProbeSortingCriteria = new(this, "m_ReflectionProbeSortingCriteria");
					r_Fm_ReflectionProbeSortingCriteria.SetBelong(this.instance);
				}
				return r_Fm_ReflectionProbeSortingCriteria;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraProperties m_CameraProperties
		/// </summary>
		protected RUnityEngine.RRendering.RCameraProperties r_Fm_CameraProperties;
		public virtual RUnityEngine.RRendering.RCameraProperties RFm_CameraProperties
		{
			get
			{
				if(r_Fm_CameraProperties == null)
				{
					r_Fm_CameraProperties = new(this, "m_CameraProperties");
					r_Fm_CameraProperties.SetBelong(this.instance);
				}
				return r_Fm_CameraProperties;
			}
		}

		/// <summary>
		/// System.Single m_AccurateOcclusionThreshold
		/// </summary>
		protected RSystem.RSingle r_Fm_AccurateOcclusionThreshold;
		public virtual RSystem.RSingle RFm_AccurateOcclusionThreshold
		{
			get
			{
				if(r_Fm_AccurateOcclusionThreshold == null)
				{
					r_Fm_AccurateOcclusionThreshold = new(this, "m_AccurateOcclusionThreshold");
					r_Fm_AccurateOcclusionThreshold.SetBelong(this.instance);
				}
				return r_Fm_AccurateOcclusionThreshold;
			}
		}

		/// <summary>
		/// System.Int32 m_MaximumPortalCullingJobs
		/// </summary>
		protected RSystem.RInt32 r_Fm_MaximumPortalCullingJobs;
		public virtual RSystem.RInt32 RFm_MaximumPortalCullingJobs
		{
			get
			{
				if(r_Fm_MaximumPortalCullingJobs == null)
				{
					r_Fm_MaximumPortalCullingJobs = new(this, "m_MaximumPortalCullingJobs");
					r_Fm_MaximumPortalCullingJobs.SetBelong(this.instance);
				}
				return r_Fm_MaximumPortalCullingJobs;
			}
		}

		/// <summary>
		/// System.Int32 k_CullingJobCountLowerLimit
		/// </summary>
		protected static RSystem.RInt32 r_Fk_CullingJobCountLowerLimit;
		public static RSystem.RInt32 RFk_CullingJobCountLowerLimit
		{
			get
			{
				if(r_Fk_CullingJobCountLowerLimit == null)
				{
					r_Fk_CullingJobCountLowerLimit = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "k_CullingJobCountLowerLimit");
					r_Fk_CullingJobCountLowerLimit.SetBelong(null);
				}
				return r_Fk_CullingJobCountLowerLimit;
			}
		}

		/// <summary>
		/// System.Int32 k_CullingJobCountUpperLimit
		/// </summary>
		protected static RSystem.RInt32 r_Fk_CullingJobCountUpperLimit;
		public static RSystem.RInt32 RFk_CullingJobCountUpperLimit
		{
			get
			{
				if(r_Fk_CullingJobCountUpperLimit == null)
				{
					r_Fk_CullingJobCountUpperLimit = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "k_CullingJobCountUpperLimit");
					r_Fk_CullingJobCountUpperLimit.SetBelong(null);
				}
				return r_Fk_CullingJobCountUpperLimit;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_StereoViewMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_Fm_StereoViewMatrix;
		public virtual RUnityEngine.RMatrix4x4 RFm_StereoViewMatrix
		{
			get
			{
				if(r_Fm_StereoViewMatrix == null)
				{
					r_Fm_StereoViewMatrix = new(this, "m_StereoViewMatrix");
					r_Fm_StereoViewMatrix.SetBelong(this.instance);
				}
				return r_Fm_StereoViewMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_StereoProjectionMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_Fm_StereoProjectionMatrix;
		public virtual RUnityEngine.RMatrix4x4 RFm_StereoProjectionMatrix
		{
			get
			{
				if(r_Fm_StereoProjectionMatrix == null)
				{
					r_Fm_StereoProjectionMatrix = new(this, "m_StereoProjectionMatrix");
					r_Fm_StereoProjectionMatrix.SetBelong(this.instance);
				}
				return r_Fm_StereoProjectionMatrix;
			}
		}

		/// <summary>
		/// System.Single m_StereoSeparationDistance
		/// </summary>
		protected RSystem.RSingle r_Fm_StereoSeparationDistance;
		public virtual RSystem.RSingle RFm_StereoSeparationDistance
		{
			get
			{
				if(r_Fm_StereoSeparationDistance == null)
				{
					r_Fm_StereoSeparationDistance = new(this, "m_StereoSeparationDistance");
					r_Fm_StereoSeparationDistance.SetBelong(this.instance);
				}
				return r_Fm_StereoSeparationDistance;
			}
		}

		/// <summary>
		/// System.Int32 m_maximumVisibleLights
		/// </summary>
		protected RSystem.RInt32 r_Fm_maximumVisibleLights;
		public virtual RSystem.RInt32 RFm_maximumVisibleLights
		{
			get
			{
				if(r_Fm_maximumVisibleLights == null)
				{
					r_Fm_maximumVisibleLights = new(this, "m_maximumVisibleLights");
					r_Fm_maximumVisibleLights.SetBelong(this.instance);
				}
				return r_Fm_maximumVisibleLights;
			}
		}

		/// <summary>
		/// System.Boolean m_ConservativeEnclosingSphere
		/// </summary>
		protected RSystem.RBoolean r_Fm_ConservativeEnclosingSphere;
		public virtual RSystem.RBoolean RFm_ConservativeEnclosingSphere
		{
			get
			{
				if(r_Fm_ConservativeEnclosingSphere == null)
				{
					r_Fm_ConservativeEnclosingSphere = new(this, "m_ConservativeEnclosingSphere");
					r_Fm_ConservativeEnclosingSphere.SetBelong(this.instance);
				}
				return r_Fm_ConservativeEnclosingSphere;
			}
		}

		/// <summary>
		/// System.Int32 m_NumIterationsEnclosingSphere
		/// </summary>
		protected RSystem.RInt32 r_Fm_NumIterationsEnclosingSphere;
		public virtual RSystem.RInt32 RFm_NumIterationsEnclosingSphere
		{
			get
			{
				if(r_Fm_NumIterationsEnclosingSphere == null)
				{
					r_Fm_NumIterationsEnclosingSphere = new(this, "m_NumIterationsEnclosingSphere");
					r_Fm_NumIterationsEnclosingSphere.SetBelong(this.instance);
				}
				return r_Fm_NumIterationsEnclosingSphere;
			}
		}

		/// <summary>
		/// Int32 maximumVisibleLights
		/// </summary>
		protected RSystem.RInt32 r_PmaximumVisibleLights;
		public virtual RSystem.RInt32 RPmaximumVisibleLights
		{
			get
			{
				if(r_PmaximumVisibleLights == null)
				{
					r_PmaximumVisibleLights = new(this, "maximumVisibleLights", -1);
					r_PmaximumVisibleLights.SetBelong(this.instance);
				}
				return r_PmaximumVisibleLights;
			}
		}

		/// <summary>
		/// Boolean conservativeEnclosingSphere
		/// </summary>
		protected RSystem.RBoolean r_PconservativeEnclosingSphere;
		public virtual RSystem.RBoolean RPconservativeEnclosingSphere
		{
			get
			{
				if(r_PconservativeEnclosingSphere == null)
				{
					r_PconservativeEnclosingSphere = new(this, "conservativeEnclosingSphere", -1);
					r_PconservativeEnclosingSphere.SetBelong(this.instance);
				}
				return r_PconservativeEnclosingSphere;
			}
		}

		/// <summary>
		/// Int32 numIterationsEnclosingSphere
		/// </summary>
		protected RSystem.RInt32 r_PnumIterationsEnclosingSphere;
		public virtual RSystem.RInt32 RPnumIterationsEnclosingSphere
		{
			get
			{
				if(r_PnumIterationsEnclosingSphere == null)
				{
					r_PnumIterationsEnclosingSphere = new(this, "numIterationsEnclosingSphere", -1);
					r_PnumIterationsEnclosingSphere.SetBelong(this.instance);
				}
				return r_PnumIterationsEnclosingSphere;
			}
		}

		/// <summary>
		/// Int32 cullingPlaneCount
		/// </summary>
		protected RSystem.RInt32 r_PcullingPlaneCount;
		public virtual RSystem.RInt32 RPcullingPlaneCount
		{
			get
			{
				if(r_PcullingPlaneCount == null)
				{
					r_PcullingPlaneCount = new(this, "cullingPlaneCount", -1);
					r_PcullingPlaneCount.SetBelong(this.instance);
				}
				return r_PcullingPlaneCount;
			}
		}

		/// <summary>
		/// Boolean isOrthographic
		/// </summary>
		protected RSystem.RBoolean r_PisOrthographic;
		public virtual RSystem.RBoolean RPisOrthographic
		{
			get
			{
				if(r_PisOrthographic == null)
				{
					r_PisOrthographic = new(this, "isOrthographic", -1);
					r_PisOrthographic.SetBelong(this.instance);
				}
				return r_PisOrthographic;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LODParameters lodParameters
		/// </summary>
		protected RUnityEngine.RRendering.RLODParameters r_PlodParameters;
		public virtual RUnityEngine.RRendering.RLODParameters RPlodParameters
		{
			get
			{
				if(r_PlodParameters == null)
				{
					r_PlodParameters = new(this, "lodParameters", -1);
					r_PlodParameters.SetBelong(this.instance);
				}
				return r_PlodParameters;
			}
		}

		/// <summary>
		/// UInt32 cullingMask
		/// </summary>
		protected RSystem.RUInt32 r_PcullingMask;
		public virtual RSystem.RUInt32 RPcullingMask
		{
			get
			{
				if(r_PcullingMask == null)
				{
					r_PcullingMask = new(this, "cullingMask", -1);
					r_PcullingMask.SetBelong(this.instance);
				}
				return r_PcullingMask;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 cullingMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_PcullingMatrix;
		public virtual RUnityEngine.RMatrix4x4 RPcullingMatrix
		{
			get
			{
				if(r_PcullingMatrix == null)
				{
					r_PcullingMatrix = new(this, "cullingMatrix", -1);
					r_PcullingMatrix.SetBelong(this.instance);
				}
				return r_PcullingMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 origin
		/// </summary>
		protected RUnityEngine.RVector3 r_Porigin;
		public virtual RUnityEngine.RVector3 RPorigin
		{
			get
			{
				if(r_Porigin == null)
				{
					r_Porigin = new(this, "origin", -1);
					r_Porigin.SetBelong(this.instance);
				}
				return r_Porigin;
			}
		}

		/// <summary>
		/// Single shadowDistance
		/// </summary>
		protected RSystem.RSingle r_PshadowDistance;
		public virtual RSystem.RSingle RPshadowDistance
		{
			get
			{
				if(r_PshadowDistance == null)
				{
					r_PshadowDistance = new(this, "shadowDistance", -1);
					r_PshadowDistance.SetBelong(this.instance);
				}
				return r_PshadowDistance;
			}
		}

		/// <summary>
		/// Single shadowNearPlaneOffset
		/// </summary>
		protected RSystem.RSingle r_PshadowNearPlaneOffset;
		public virtual RSystem.RSingle RPshadowNearPlaneOffset
		{
			get
			{
				if(r_PshadowNearPlaneOffset == null)
				{
					r_PshadowNearPlaneOffset = new(this, "shadowNearPlaneOffset", -1);
					r_PshadowNearPlaneOffset.SetBelong(this.instance);
				}
				return r_PshadowNearPlaneOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CullingOptions cullingOptions
		/// </summary>
		protected RUnityEngine.RRendering.RCullingOptions r_PcullingOptions;
		public virtual RUnityEngine.RRendering.RCullingOptions RPcullingOptions
		{
			get
			{
				if(r_PcullingOptions == null)
				{
					r_PcullingOptions = new(this, "cullingOptions", -1);
					r_PcullingOptions.SetBelong(this.instance);
				}
				return r_PcullingOptions;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeSortingCriteria reflectionProbeSortingCriteria
		/// </summary>
		protected RUnityEngine.RRendering.RReflectionProbeSortingCriteria r_PreflectionProbeSortingCriteria;
		public virtual RUnityEngine.RRendering.RReflectionProbeSortingCriteria RPreflectionProbeSortingCriteria
		{
			get
			{
				if(r_PreflectionProbeSortingCriteria == null)
				{
					r_PreflectionProbeSortingCriteria = new(this, "reflectionProbeSortingCriteria", -1);
					r_PreflectionProbeSortingCriteria.SetBelong(this.instance);
				}
				return r_PreflectionProbeSortingCriteria;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraProperties cameraProperties
		/// </summary>
		protected RUnityEngine.RRendering.RCameraProperties r_PcameraProperties;
		public virtual RUnityEngine.RRendering.RCameraProperties RPcameraProperties
		{
			get
			{
				if(r_PcameraProperties == null)
				{
					r_PcameraProperties = new(this, "cameraProperties", -1);
					r_PcameraProperties.SetBelong(this.instance);
				}
				return r_PcameraProperties;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 stereoViewMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_PstereoViewMatrix;
		public virtual RUnityEngine.RMatrix4x4 RPstereoViewMatrix
		{
			get
			{
				if(r_PstereoViewMatrix == null)
				{
					r_PstereoViewMatrix = new(this, "stereoViewMatrix", -1);
					r_PstereoViewMatrix.SetBelong(this.instance);
				}
				return r_PstereoViewMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 stereoProjectionMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_PstereoProjectionMatrix;
		public virtual RUnityEngine.RMatrix4x4 RPstereoProjectionMatrix
		{
			get
			{
				if(r_PstereoProjectionMatrix == null)
				{
					r_PstereoProjectionMatrix = new(this, "stereoProjectionMatrix", -1);
					r_PstereoProjectionMatrix.SetBelong(this.instance);
				}
				return r_PstereoProjectionMatrix;
			}
		}

		/// <summary>
		/// Single stereoSeparationDistance
		/// </summary>
		protected RSystem.RSingle r_PstereoSeparationDistance;
		public virtual RSystem.RSingle RPstereoSeparationDistance
		{
			get
			{
				if(r_PstereoSeparationDistance == null)
				{
					r_PstereoSeparationDistance = new(this, "stereoSeparationDistance", -1);
					r_PstereoSeparationDistance.SetBelong(this.instance);
				}
				return r_PstereoSeparationDistance;
			}
		}

		/// <summary>
		/// Single accurateOcclusionThreshold
		/// </summary>
		protected RSystem.RSingle r_PaccurateOcclusionThreshold;
		public virtual RSystem.RSingle RPaccurateOcclusionThreshold
		{
			get
			{
				if(r_PaccurateOcclusionThreshold == null)
				{
					r_PaccurateOcclusionThreshold = new(this, "accurateOcclusionThreshold", -1);
					r_PaccurateOcclusionThreshold.SetBelong(this.instance);
				}
				return r_PaccurateOcclusionThreshold;
			}
		}

		/// <summary>
		/// Int32 maximumPortalCullingJobs
		/// </summary>
		protected RSystem.RInt32 r_PmaximumPortalCullingJobs;
		public virtual RSystem.RInt32 RPmaximumPortalCullingJobs
		{
			get
			{
				if(r_PmaximumPortalCullingJobs == null)
				{
					r_PmaximumPortalCullingJobs = new(this, "maximumPortalCullingJobs", -1);
					r_PmaximumPortalCullingJobs.SetBelong(this.instance);
				}
				return r_PmaximumPortalCullingJobs;
			}
		}

		/// <summary>
		/// Int32 cullingJobsLowerLimit
		/// </summary>
		protected static RSystem.RInt32 r_PcullingJobsLowerLimit;
		public static RSystem.RInt32 RPcullingJobsLowerLimit
		{
			get
			{
				if(r_PcullingJobsLowerLimit == null)
				{
					r_PcullingJobsLowerLimit = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "cullingJobsLowerLimit", -1);
					r_PcullingJobsLowerLimit.SetBelong(null);
				}
				return r_PcullingJobsLowerLimit;
			}
		}

		/// <summary>
		/// Int32 cullingJobsUpperLimit
		/// </summary>
		protected static RSystem.RInt32 r_PcullingJobsUpperLimit;
		public static RSystem.RInt32 RPcullingJobsUpperLimit
		{
			get
			{
				if(r_PcullingJobsUpperLimit == null)
				{
					r_PcullingJobsUpperLimit = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "cullingJobsUpperLimit", -1);
					r_PcullingJobsUpperLimit.SetBelong(null);
				}
				return r_PcullingJobsUpperLimit;
			}
		}

		/// <summary>
		/// Single GetLayerCullingDistance(Int32)
		/// </summary>
		protected RMethod r_MGetLayerCullingDistance_Int32;
		public virtual RMethod RMGetLayerCullingDistance_Int32
		{
			get
			{
				if(r_MGetLayerCullingDistance_Int32 == null)
				{
					r_MGetLayerCullingDistance_Int32 = new(this, "GetLayerCullingDistance", 0, typeof(System.Int32));
					r_MGetLayerCullingDistance_Int32.SetBelong(this.instance);
				}
				return r_MGetLayerCullingDistance_Int32;
			}
		}

		/// <summary>
		/// Void SetLayerCullingDistance(Int32, Single)
		/// </summary>
		protected RMethod r_MSetLayerCullingDistance_Int32_Single;
		public virtual RMethod RMSetLayerCullingDistance_Int32_Single
		{
			get
			{
				if(r_MSetLayerCullingDistance_Int32_Single == null)
				{
					r_MSetLayerCullingDistance_Int32_Single = new(this, "SetLayerCullingDistance", 0, typeof(System.Int32), typeof(System.Single));
					r_MSetLayerCullingDistance_Int32_Single.SetBelong(this.instance);
				}
				return r_MSetLayerCullingDistance_Int32_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Plane GetCullingPlane(Int32)
		/// </summary>
		protected RMethod r_MGetCullingPlane_Int32;
		public virtual RMethod RMGetCullingPlane_Int32
		{
			get
			{
				if(r_MGetCullingPlane_Int32 == null)
				{
					r_MGetCullingPlane_Int32 = new(this, "GetCullingPlane", 0, typeof(System.Int32));
					r_MGetCullingPlane_Int32.SetBelong(this.instance);
				}
				return r_MGetCullingPlane_Int32;
			}
		}

		/// <summary>
		/// Void SetCullingPlane(Int32, UnityEngine.Plane)
		/// </summary>
		protected RMethod r_MSetCullingPlane_Int32_Plane;
		public virtual RMethod RMSetCullingPlane_Int32_Plane
		{
			get
			{
				if(r_MSetCullingPlane_Int32_Plane == null)
				{
					r_MSetCullingPlane_Int32_Plane = new(this, "SetCullingPlane", 0, typeof(System.Int32), typeof(UnityEngine.Plane));
					r_MSetCullingPlane_Int32_Plane.SetBelong(this.instance);
				}
				return r_MSetCullingPlane_Int32_Plane;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Rendering.ScriptableCullingParameters)
		/// </summary>
		protected RMethod r_MEquals_ScriptableCullingParameters;
		public virtual RMethod RMEquals_ScriptableCullingParameters
		{
			get
			{
				if(r_MEquals_ScriptableCullingParameters == null)
				{
					r_MEquals_ScriptableCullingParameters = new(this, "Equals", 0, typeof(UnityEngine.Rendering.ScriptableCullingParameters));
					r_MEquals_ScriptableCullingParameters.SetBelong(this.instance);
				}
				return r_MEquals_ScriptableCullingParameters;
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
		/// Boolean op_Equality(UnityEngine.Rendering.ScriptableCullingParameters, UnityEngine.Rendering.ScriptableCullingParameters)
		/// </summary>
		protected static RMethod r_Mop_Equality_ScriptableCullingParameters_ScriptableCullingParameters;
		public static RMethod RMop_Equality_ScriptableCullingParameters_ScriptableCullingParameters
		{
			get
			{
				if(r_Mop_Equality_ScriptableCullingParameters_ScriptableCullingParameters == null)
				{
					r_Mop_Equality_ScriptableCullingParameters_ScriptableCullingParameters = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "op_Equality", 0, typeof(UnityEngine.Rendering.ScriptableCullingParameters), typeof(UnityEngine.Rendering.ScriptableCullingParameters));
					r_Mop_Equality_ScriptableCullingParameters_ScriptableCullingParameters.SetBelong(null);
				}
				return r_Mop_Equality_ScriptableCullingParameters_ScriptableCullingParameters;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.ScriptableCullingParameters, UnityEngine.Rendering.ScriptableCullingParameters)
		/// </summary>
		protected static RMethod r_Mop_Inequality_ScriptableCullingParameters_ScriptableCullingParameters;
		public static RMethod RMop_Inequality_ScriptableCullingParameters_ScriptableCullingParameters
		{
			get
			{
				if(r_Mop_Inequality_ScriptableCullingParameters_ScriptableCullingParameters == null)
				{
					r_Mop_Inequality_ScriptableCullingParameters_ScriptableCullingParameters = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "op_Inequality", 0, typeof(UnityEngine.Rendering.ScriptableCullingParameters), typeof(UnityEngine.Rendering.ScriptableCullingParameters));
					r_Mop_Inequality_ScriptableCullingParameters_ScriptableCullingParameters.SetBelong(null);
				}
				return r_Mop_Inequality_ScriptableCullingParameters_ScriptableCullingParameters;
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


        public RScriptableCullingParameters() : base("UnityEngine.Rendering.ScriptableCullingParameters")
        {
        }

        public RScriptableCullingParameters(System.Object instance) : base("UnityEngine.Rendering.ScriptableCullingParameters")
		{
            SetInstance(instance);
		}

        public RScriptableCullingParameters(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RScriptableCullingParameters(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Single GetLayerCullingDistance(System.Int32 @layerIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layerIndex};
            var ___result = RMGetLayerCullingDistance_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void SetLayerCullingDistance(System.Int32 @layerIndex, System.Single @distance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layerIndex, @distance};
            var ___result = RMSetLayerCullingDistance_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Plane GetCullingPlane(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetCullingPlane_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Plane)___result;
        }


        public virtual void SetCullingPlane(System.Int32 @index, UnityEngine.Plane @plane)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @plane};
            var ___result = RMSetCullingPlane_Int32_Plane.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.ScriptableCullingParameters @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_ScriptableCullingParameters.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public static System.Boolean op_Equality(UnityEngine.Rendering.ScriptableCullingParameters @left, UnityEngine.Rendering.ScriptableCullingParameters @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_ScriptableCullingParameters_ScriptableCullingParameters.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.ScriptableCullingParameters @left, UnityEngine.Rendering.ScriptableCullingParameters @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_ScriptableCullingParameters_ScriptableCullingParameters.Invoke(___genericsType, ___parameters);

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
