
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadManager
	/// </summary>
    public partial class RAssetStoreDownloadManager : RMember //
    {

		/// <summary>
		/// System.Action`2[UnityEditor.PackageManager.UI.Internal.IOperation,UnityEditor.PackageManager.UI.Internal.UIError] onDownloadError
		/// </summary>
		protected REvent r_EonDownloadError;
		public virtual REvent REonDownloadError
		{
			get
			{
				if(r_EonDownloadError == null)
				{
					r_EonDownloadError = new(this, "onDownloadError");
					r_EonDownloadError.SetBelong(this.instance);
				}
				return r_EonDownloadError;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onDownloadFinalized
		/// </summary>
		protected REvent r_EonDownloadFinalized;
		public virtual REvent REonDownloadFinalized
		{
			get
			{
				if(r_EonDownloadFinalized == null)
				{
					r_EonDownloadFinalized = new(this, "onDownloadFinalized");
					r_EonDownloadFinalized.SetBelong(this.instance);
				}
				return r_EonDownloadFinalized;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onDownloadProgress
		/// </summary>
		protected REvent r_EonDownloadProgress;
		public virtual REvent REonDownloadProgress
		{
			get
			{
				if(r_EonDownloadProgress == null)
				{
					r_EonDownloadProgress = new(this, "onDownloadProgress");
					r_EonDownloadProgress.SetBelong(this.instance);
				}
				return r_EonDownloadProgress;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onDownloadPaused
		/// </summary>
		protected REvent r_EonDownloadPaused;
		public virtual REvent REonDownloadPaused
		{
			get
			{
				if(r_EonDownloadPaused == null)
				{
					r_EonDownloadPaused = new(this, "onDownloadPaused");
					r_EonDownloadPaused.SetBelong(this.instance);
				}
				return r_EonDownloadPaused;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEditor.PackageManager.UI.Internal.IOperation,UnityEditor.PackageManager.UI.Internal.UIError] onDownloadError
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> r_FonDownloadError;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> RFonDownloadError
		{
			get
			{
				if(r_FonDownloadError == null)
				{
					r_FonDownloadError = new(this, "onDownloadError");
					r_FonDownloadError.SetBelong(this.instance);
				}
				return r_FonDownloadError;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onDownloadFinalized
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_FonDownloadFinalized;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFonDownloadFinalized
		{
			get
			{
				if(r_FonDownloadFinalized == null)
				{
					r_FonDownloadFinalized = new(this, "onDownloadFinalized");
					r_FonDownloadFinalized.SetBelong(this.instance);
				}
				return r_FonDownloadFinalized;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onDownloadProgress
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_FonDownloadProgress;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFonDownloadProgress
		{
			get
			{
				if(r_FonDownloadProgress == null)
				{
					r_FonDownloadProgress = new(this, "onDownloadProgress");
					r_FonDownloadProgress.SetBelong(this.instance);
				}
				return r_FonDownloadProgress;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onDownloadPaused
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_FonDownloadPaused;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFonDownloadPaused
		{
			get
			{
				if(r_FonDownloadPaused == null)
				{
					r_FonDownloadPaused = new(this, "onDownloadPaused");
					r_FonDownloadPaused.SetBelong(this.instance);
				}
				return r_FonDownloadPaused;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadOperation] m_DownloadOperations
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RSystem.RString, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadOperation> r_Fm_DownloadOperations;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RSystem.RString, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadOperation> RFm_DownloadOperations
		{
			get
			{
				if(r_Fm_DownloadOperations == null)
				{
					r_Fm_DownloadOperations = new(this, "m_DownloadOperations");
					r_Fm_DownloadOperations.SetBelong(this.instance);
				}
				return r_Fm_DownloadOperations;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadOperation[] m_SerializedDownloadOperations
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadOperation> r_Fm_SerializedDownloadOperations;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadOperation> RFm_SerializedDownloadOperations
		{
			get
			{
				if(r_Fm_SerializedDownloadOperations == null)
				{
					r_Fm_SerializedDownloadOperations = new(this, "m_SerializedDownloadOperations");
					r_Fm_SerializedDownloadOperations.SetBelong(this.instance);
				}
				return r_Fm_SerializedDownloadOperations;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.ApplicationProxy m_Application
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy r_Fm_Application;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy RFm_Application
		{
			get
			{
				if(r_Fm_Application == null)
				{
					r_Fm_Application = new(this, "m_Application");
					r_Fm_Application.SetBelong(this.instance);
				}
				return r_Fm_Application;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.HttpClientFactory m_HttpClientFactory
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RHttpClientFactory r_Fm_HttpClientFactory;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RHttpClientFactory RFm_HttpClientFactory
		{
			get
			{
				if(r_Fm_HttpClientFactory == null)
				{
					r_Fm_HttpClientFactory = new(this, "m_HttpClientFactory");
					r_Fm_HttpClientFactory.SetBelong(this.instance);
				}
				return r_Fm_HttpClientFactory;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UnityConnectProxy m_UnityConnect
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy r_Fm_UnityConnect;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy RFm_UnityConnect
		{
			get
			{
				if(r_Fm_UnityConnect == null)
				{
					r_Fm_UnityConnect = new(this, "m_UnityConnect");
					r_Fm_UnityConnect.SetBelong(this.instance);
				}
				return r_Fm_UnityConnect;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IOProxy m_IOProxy
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy r_Fm_IOProxy;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy RFm_IOProxy
		{
			get
			{
				if(r_Fm_IOProxy == null)
				{
					r_Fm_IOProxy = new(this, "m_IOProxy");
					r_Fm_IOProxy.SetBelong(this.instance);
				}
				return r_Fm_IOProxy;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreCache m_AssetStoreCache
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCache r_Fm_AssetStoreCache;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCache RFm_AssetStoreCache
		{
			get
			{
				if(r_Fm_AssetStoreCache == null)
				{
					r_Fm_AssetStoreCache = new(this, "m_AssetStoreCache");
					r_Fm_AssetStoreCache.SetBelong(this.instance);
				}
				return r_Fm_AssetStoreCache;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreUtils m_AssetStoreUtils
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils r_Fm_AssetStoreUtils;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils RFm_AssetStoreUtils
		{
			get
			{
				if(r_Fm_AssetStoreUtils == null)
				{
					r_Fm_AssetStoreUtils = new(this, "m_AssetStoreUtils");
					r_Fm_AssetStoreUtils.SetBelong(this.instance);
				}
				return r_Fm_AssetStoreUtils;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI m_AssetStoreRestAPI
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreRestAPI r_Fm_AssetStoreRestAPI;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreRestAPI RFm_AssetStoreRestAPI
		{
			get
			{
				if(r_Fm_AssetStoreRestAPI == null)
				{
					r_Fm_AssetStoreRestAPI = new(this, "m_AssetStoreRestAPI");
					r_Fm_AssetStoreRestAPI.SetBelong(this.instance);
				}
				return r_Fm_AssetStoreRestAPI;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreCachePathProxy m_AssetStoreCachePathProxy
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCachePathProxy r_Fm_AssetStoreCachePathProxy;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCachePathProxy RFm_AssetStoreCachePathProxy
		{
			get
			{
				if(r_Fm_AssetStoreCachePathProxy == null)
				{
					r_Fm_AssetStoreCachePathProxy = new(this, "m_AssetStoreCachePathProxy");
					r_Fm_AssetStoreCachePathProxy.SetBelong(this.instance);
				}
				return r_Fm_AssetStoreCachePathProxy;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadManager+DownloadDelegateHandler m_DownloadDelegateHandler
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadManager.RDownloadDelegateHandler r_Fm_DownloadDelegateHandler;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadManager.RDownloadDelegateHandler RFm_DownloadDelegateHandler
		{
			get
			{
				if(r_Fm_DownloadDelegateHandler == null)
				{
					r_Fm_DownloadDelegateHandler = new(this, "m_DownloadDelegateHandler");
					r_Fm_DownloadDelegateHandler.SetBelong(this.instance);
				}
				return r_Fm_DownloadDelegateHandler;
			}
		}

		/// <summary>
		/// System.Int32 m_DownloadDelegateHandlerInstanceId
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_DownloadDelegateHandlerInstanceId;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_DownloadDelegateHandlerInstanceId
		{
			get
			{
				if(r_Fm_DownloadDelegateHandlerInstanceId == null)
				{
					r_Fm_DownloadDelegateHandlerInstanceId = new(this, "m_DownloadDelegateHandlerInstanceId");
					r_Fm_DownloadDelegateHandlerInstanceId.SetBelong(this.instance);
				}
				return r_Fm_DownloadDelegateHandlerInstanceId;
			}
		}

		/// <summary>
		/// System.Boolean m_DelegateRegistered
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_DelegateRegistered;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_DelegateRegistered
		{
			get
			{
				if(r_Fm_DelegateRegistered == null)
				{
					r_Fm_DelegateRegistered = new(this, "m_DelegateRegistered");
					r_Fm_DelegateRegistered.SetBelong(this.instance);
				}
				return r_Fm_DelegateRegistered;
			}
		}

		/// <summary>
		/// DownloadDelegateHandler downloadDelegateHandler
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadManager.RDownloadDelegateHandler r_PdownloadDelegateHandler;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadManager.RDownloadDelegateHandler RPdownloadDelegateHandler
		{
			get
			{
				if(r_PdownloadDelegateHandler == null)
				{
					r_PdownloadDelegateHandler = new(this, "downloadDelegateHandler", -1);
					r_PdownloadDelegateHandler.SetBelong(this.instance);
				}
				return r_PdownloadDelegateHandler;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.ApplicationProxy, UnityEditor.PackageManager.UI.Internal.HttpClientFactory, UnityEditor.PackageManager.UI.Internal.UnityConnectProxy, UnityEditor.PackageManager.UI.Internal.IOProxy, UnityEditor.PackageManager.UI.Internal.AssetStoreCache, UnityEditor.PackageManager.UI.Internal.AssetStoreUtils, UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI, UnityEditor.PackageManager.UI.Internal.AssetStoreCachePathProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_ApplicationProxy_HttpClientFactory_UnityConnectProxy_IOProxy_AssetStoreCache_AssetStoreUtils_AssetStoreRestAPI_AssetStoreCachePathProxy;
		public virtual RMethod RMResolveDependencies_ApplicationProxy_HttpClientFactory_UnityConnectProxy_IOProxy_AssetStoreCache_AssetStoreUtils_AssetStoreRestAPI_AssetStoreCachePathProxy
		{
			get
			{
				if(r_MResolveDependencies_ApplicationProxy_HttpClientFactory_UnityConnectProxy_IOProxy_AssetStoreCache_AssetStoreUtils_AssetStoreRestAPI_AssetStoreCachePathProxy == null)
				{
					r_MResolveDependencies_ApplicationProxy_HttpClientFactory_UnityConnectProxy_IOProxy_AssetStoreCache_AssetStoreUtils_AssetStoreRestAPI_AssetStoreCachePathProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ApplicationProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.HttpClientFactory"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UnityConnectProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUtils"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreCachePathProxy"));
					r_MResolveDependencies_ApplicationProxy_HttpClientFactory_UnityConnectProxy_IOProxy_AssetStoreCache_AssetStoreUtils_AssetStoreRestAPI_AssetStoreCachePathProxy.SetBelong(this.instance);
				}
				return r_MResolveDependencies_ApplicationProxy_HttpClientFactory_UnityConnectProxy_IOProxy_AssetStoreCache_AssetStoreUtils_AssetStoreRestAPI_AssetStoreCachePathProxy;
			}
		}

		/// <summary>
		/// Void RegisterDownloadDelegate()
		/// </summary>
		protected RMethod r_MRegisterDownloadDelegate;
		public virtual RMethod RMRegisterDownloadDelegate
		{
			get
			{
				if(r_MRegisterDownloadDelegate == null)
				{
					r_MRegisterDownloadDelegate = new(this, "RegisterDownloadDelegate", 0);
					r_MRegisterDownloadDelegate.SetBelong(this.instance);
				}
				return r_MRegisterDownloadDelegate;
			}
		}

		/// <summary>
		/// Void UnRegisterDownloadDelegate()
		/// </summary>
		protected RMethod r_MUnRegisterDownloadDelegate;
		public virtual RMethod RMUnRegisterDownloadDelegate
		{
			get
			{
				if(r_MUnRegisterDownloadDelegate == null)
				{
					r_MUnRegisterDownloadDelegate = new(this, "UnRegisterDownloadDelegate", 0);
					r_MUnRegisterDownloadDelegate.SetBelong(this.instance);
				}
				return r_MUnRegisterDownloadDelegate;
			}
		}

		/// <summary>
		/// Boolean IsAnyDownloadInProgress()
		/// </summary>
		protected RMethod r_MIsAnyDownloadInProgress;
		public virtual RMethod RMIsAnyDownloadInProgress
		{
			get
			{
				if(r_MIsAnyDownloadInProgress == null)
				{
					r_MIsAnyDownloadInProgress = new(this, "IsAnyDownloadInProgress", 0);
					r_MIsAnyDownloadInProgress.SetBelong(this.instance);
				}
				return r_MIsAnyDownloadInProgress;
			}
		}

		/// <summary>
		/// Boolean IsAnyDownloadInProgressOrPause()
		/// </summary>
		protected RMethod r_MIsAnyDownloadInProgressOrPause;
		public virtual RMethod RMIsAnyDownloadInProgressOrPause
		{
			get
			{
				if(r_MIsAnyDownloadInProgressOrPause == null)
				{
					r_MIsAnyDownloadInProgressOrPause = new(this, "IsAnyDownloadInProgressOrPause", 0);
					r_MIsAnyDownloadInProgressOrPause.SetBelong(this.instance);
				}
				return r_MIsAnyDownloadInProgressOrPause;
			}
		}

		/// <summary>
		/// Int32 DownloadInProgressCount()
		/// </summary>
		protected RMethod r_MDownloadInProgressCount;
		public virtual RMethod RMDownloadInProgressCount
		{
			get
			{
				if(r_MDownloadInProgressCount == null)
				{
					r_MDownloadInProgressCount = new(this, "DownloadInProgressCount", 0);
					r_MDownloadInProgressCount.SetBelong(this.instance);
				}
				return r_MDownloadInProgressCount;
			}
		}

		/// <summary>
		/// Void Download(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MDownload_IPackage;
		public virtual RMethod RMDownload_IPackage
		{
			get
			{
				if(r_MDownload_IPackage == null)
				{
					r_MDownload_IPackage = new(this, "Download", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
					r_MDownload_IPackage.SetBelong(this.instance);
				}
				return r_MDownload_IPackage;
			}
		}

		/// <summary>
		/// Void ClearCache()
		/// </summary>
		protected RMethod r_MClearCache;
		public virtual RMethod RMClearCache
		{
			get
			{
				if(r_MClearCache == null)
				{
					r_MClearCache = new(this, "ClearCache", 0);
					r_MClearCache.SetBelong(this.instance);
				}
				return r_MClearCache;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadOperation GetDownloadOperation(System.String)
		/// </summary>
		protected RMethod r_MGetDownloadOperation_String;
		public virtual RMethod RMGetDownloadOperation_String
		{
			get
			{
				if(r_MGetDownloadOperation_String == null)
				{
					r_MGetDownloadOperation_String = new(this, "GetDownloadOperation", 0, typeof(System.String));
					r_MGetDownloadOperation_String.SetBelong(this.instance);
				}
				return r_MGetDownloadOperation_String;
			}
		}

		/// <summary>
		/// Void SetupDownloadOperation(UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadOperation)
		/// </summary>
		protected RMethod r_MSetupDownloadOperation_AssetStoreDownloadOperation;
		public virtual RMethod RMSetupDownloadOperation_AssetStoreDownloadOperation
		{
			get
			{
				if(r_MSetupDownloadOperation_AssetStoreDownloadOperation == null)
				{
					r_MSetupDownloadOperation_AssetStoreDownloadOperation = new(this, "SetupDownloadOperation", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadOperation"));
					r_MSetupDownloadOperation_AssetStoreDownloadOperation.SetBelong(this.instance);
				}
				return r_MSetupDownloadOperation_AssetStoreDownloadOperation;
			}
		}

		/// <summary>
		/// Void OnDownloadFinalized(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_MOnDownloadFinalized_IOperation;
		public virtual RMethod RMOnDownloadFinalized_IOperation
		{
			get
			{
				if(r_MOnDownloadFinalized_IOperation == null)
				{
					r_MOnDownloadFinalized_IOperation = new(this, "OnDownloadFinalized", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
					r_MOnDownloadFinalized_IOperation.SetBelong(this.instance);
				}
				return r_MOnDownloadFinalized_IOperation;
			}
		}

		/// <summary>
		/// Void RemoveDownloadOperation(System.String)
		/// </summary>
		protected RMethod r_MRemoveDownloadOperation_String;
		public virtual RMethod RMRemoveDownloadOperation_String
		{
			get
			{
				if(r_MRemoveDownloadOperation_String == null)
				{
					r_MRemoveDownloadOperation_String = new(this, "RemoveDownloadOperation", 0, typeof(System.String));
					r_MRemoveDownloadOperation_String.SetBelong(this.instance);
				}
				return r_MRemoveDownloadOperation_String;
			}
		}

		/// <summary>
		/// Void OnDownloadProgress(System.String, System.String, UInt64, UInt64, Int32)
		/// </summary>
		protected RMethod r_MOnDownloadProgress_String_String_UInt64_UInt64_Int32;
		public virtual RMethod RMOnDownloadProgress_String_String_UInt64_UInt64_Int32
		{
			get
			{
				if(r_MOnDownloadProgress_String_String_UInt64_UInt64_Int32 == null)
				{
					r_MOnDownloadProgress_String_String_UInt64_UInt64_Int32 = new(this, "OnDownloadProgress", 0, typeof(System.String), typeof(System.String), typeof(System.UInt64), typeof(System.UInt64), typeof(System.Int32));
					r_MOnDownloadProgress_String_String_UInt64_UInt64_Int32.SetBelong(this.instance);
				}
				return r_MOnDownloadProgress_String_String_UInt64_UInt64_Int32;
			}
		}

		/// <summary>
		/// Void AbortAllDownloads()
		/// </summary>
		protected RMethod r_MAbortAllDownloads;
		public virtual RMethod RMAbortAllDownloads
		{
			get
			{
				if(r_MAbortAllDownloads == null)
				{
					r_MAbortAllDownloads = new(this, "AbortAllDownloads", 0);
					r_MAbortAllDownloads.SetBelong(this.instance);
				}
				return r_MAbortAllDownloads;
			}
		}

		/// <summary>
		/// Void AbortDownload(System.String)
		/// </summary>
		protected RMethod r_MAbortDownload_String;
		public virtual RMethod RMAbortDownload_String
		{
			get
			{
				if(r_MAbortDownload_String == null)
				{
					r_MAbortDownload_String = new(this, "AbortDownload", 0, typeof(System.String));
					r_MAbortDownload_String.SetBelong(this.instance);
				}
				return r_MAbortDownload_String;
			}
		}

		/// <summary>
		/// Void PauseDownload(System.String)
		/// </summary>
		protected RMethod r_MPauseDownload_String;
		public virtual RMethod RMPauseDownload_String
		{
			get
			{
				if(r_MPauseDownload_String == null)
				{
					r_MPauseDownload_String = new(this, "PauseDownload", 0, typeof(System.String));
					r_MPauseDownload_String.SetBelong(this.instance);
				}
				return r_MPauseDownload_String;
			}
		}

		/// <summary>
		/// Void ResumeDownload(System.String)
		/// </summary>
		protected RMethod r_MResumeDownload_String;
		public virtual RMethod RMResumeDownload_String
		{
			get
			{
				if(r_MResumeDownload_String == null)
				{
					r_MResumeDownload_String = new(this, "ResumeDownload", 0, typeof(System.String));
					r_MResumeDownload_String.SetBelong(this.instance);
				}
				return r_MResumeDownload_String;
			}
		}

		/// <summary>
		/// Void OnPlayModeStateChanged(UnityEditor.PlayModeStateChange)
		/// </summary>
		protected RMethod r_MOnPlayModeStateChanged_PlayModeStateChange;
		public virtual RMethod RMOnPlayModeStateChanged_PlayModeStateChange
		{
			get
			{
				if(r_MOnPlayModeStateChanged_PlayModeStateChange == null)
				{
					r_MOnPlayModeStateChanged_PlayModeStateChange = new(this, "OnPlayModeStateChanged", 0, typeof(UnityEditor.PlayModeStateChange));
					r_MOnPlayModeStateChanged_PlayModeStateChange.SetBelong(this.instance);
				}
				return r_MOnPlayModeStateChanged_PlayModeStateChange;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_MOnEnable;
		public virtual RMethod RMOnEnable
		{
			get
			{
				if(r_MOnEnable == null)
				{
					r_MOnEnable = new(this, "OnEnable", 0);
					r_MOnEnable.SetBelong(this.instance);
				}
				return r_MOnEnable;
			}
		}

		/// <summary>
		/// Void OnDisable()
		/// </summary>
		protected RMethod r_MOnDisable;
		public virtual RMethod RMOnDisable
		{
			get
			{
				if(r_MOnDisable == null)
				{
					r_MOnDisable = new(this, "OnDisable", 0);
					r_MOnDisable.SetBelong(this.instance);
				}
				return r_MOnDisable;
			}
		}

		/// <summary>
		/// Void OnUserLoginStateChange(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MOnUserLoginStateChange_Boolean_Boolean;
		public virtual RMethod RMOnUserLoginStateChange_Boolean_Boolean
		{
			get
			{
				if(r_MOnUserLoginStateChange_Boolean_Boolean == null)
				{
					r_MOnUserLoginStateChange_Boolean_Boolean = new(this, "OnUserLoginStateChange", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_MOnUserLoginStateChange_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MOnUserLoginStateChange_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void OnAssetStoreCacheConfigChange(CachePathConfig)
		/// </summary>
		protected RMethod r_MOnAssetStoreCacheConfigChange_CachePathConfig;
		public virtual RMethod RMOnAssetStoreCacheConfigChange_CachePathConfig
		{
			get
			{
				if(r_MOnAssetStoreCacheConfigChange_CachePathConfig == null)
				{
					r_MOnAssetStoreCacheConfigChange_CachePathConfig = new(this, "OnAssetStoreCacheConfigChange", 0,  ReflectionUtils.GetType("UnityEditorInternal.AssetStoreCachePathManager+CachePathConfig"));
					r_MOnAssetStoreCacheConfigChange_CachePathConfig.SetBelong(this.instance);
				}
				return r_MOnAssetStoreCacheConfigChange_CachePathConfig;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_MOnBeforeSerialize;
		public virtual RMethod RMOnBeforeSerialize
		{
			get
			{
				if(r_MOnBeforeSerialize == null)
				{
					r_MOnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_MOnBeforeSerialize.SetBelong(this.instance);
				}
				return r_MOnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_MOnAfterDeserialize;
		public virtual RMethod RMOnAfterDeserialize
		{
			get
			{
				if(r_MOnAfterDeserialize == null)
				{
					r_MOnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_MOnAfterDeserialize.SetBelong(this.instance);
				}
				return r_MOnAfterDeserialize;
			}
		}

		/// <summary>
		/// Void <SetupDownloadOperation>b__37_0(UnityEditor.PackageManager.UI.Internal.IOperation, UnityEditor.PackageManager.UI.Internal.UIError)
		/// </summary>
		protected RMethod r_M__0__SetupDownloadOperation__1__b__37_0_IOperation_UIError;
		public virtual RMethod RM__0__SetupDownloadOperation__1__b__37_0_IOperation_UIError
		{
			get
			{
				if(r_M__0__SetupDownloadOperation__1__b__37_0_IOperation_UIError == null)
				{
					r_M__0__SetupDownloadOperation__1__b__37_0_IOperation_UIError = new(this, "<SetupDownloadOperation>b__37_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError"));
					r_M__0__SetupDownloadOperation__1__b__37_0_IOperation_UIError.SetBelong(this.instance);
				}
				return r_M__0__SetupDownloadOperation__1__b__37_0_IOperation_UIError;
			}
		}

		/// <summary>
		/// Void <SetupDownloadOperation>b__37_1(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_M__0__SetupDownloadOperation__1__b__37_1_IOperation;
		public virtual RMethod RM__0__SetupDownloadOperation__1__b__37_1_IOperation
		{
			get
			{
				if(r_M__0__SetupDownloadOperation__1__b__37_1_IOperation == null)
				{
					r_M__0__SetupDownloadOperation__1__b__37_1_IOperation = new(this, "<SetupDownloadOperation>b__37_1", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
					r_M__0__SetupDownloadOperation__1__b__37_1_IOperation.SetBelong(this.instance);
				}
				return r_M__0__SetupDownloadOperation__1__b__37_1_IOperation;
			}
		}

		/// <summary>
		/// Void <SetupDownloadOperation>b__37_2(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_M__0__SetupDownloadOperation__1__b__37_2_IOperation;
		public virtual RMethod RM__0__SetupDownloadOperation__1__b__37_2_IOperation
		{
			get
			{
				if(r_M__0__SetupDownloadOperation__1__b__37_2_IOperation == null)
				{
					r_M__0__SetupDownloadOperation__1__b__37_2_IOperation = new(this, "<SetupDownloadOperation>b__37_2", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
					r_M__0__SetupDownloadOperation__1__b__37_2_IOperation.SetBelong(this.instance);
				}
				return r_M__0__SetupDownloadOperation__1__b__37_2_IOperation;
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


        public RAssetStoreDownloadManager() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadManager")
        {
        }

        public RAssetStoreDownloadManager(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadManager")
		{
            SetInstance(instance);
		}

        public RAssetStoreDownloadManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStoreDownloadManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResolveDependencies(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy @application, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RHttpClientFactory @httpClientFactory, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy @unityConnect, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy @ioProxy, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCache @assetStoreCache, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils @assetStoreUtils, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreRestAPI @assetStoreRestAPI, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCachePathProxy @assetStoreCachePathProxy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@application.Value, @httpClientFactory.Value, @unityConnect.Value, @ioProxy.Value, @assetStoreCache.Value, @assetStoreUtils.Value, @assetStoreRestAPI.Value, @assetStoreCachePathProxy.Value};
            var ___result = RMResolveDependencies_ApplicationProxy_HttpClientFactory_UnityConnectProxy_IOProxy_AssetStoreCache_AssetStoreUtils_AssetStoreRestAPI_AssetStoreCachePathProxy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterDownloadDelegate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRegisterDownloadDelegate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnRegisterDownloadDelegate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnRegisterDownloadDelegate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsAnyDownloadInProgress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsAnyDownloadInProgress.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAnyDownloadInProgressOrPause()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsAnyDownloadInProgressOrPause.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 DownloadInProgressCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDownloadInProgressCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Download(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMDownload_IPackage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearCache.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadOperation GetDownloadOperation(System.String @productId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId};
            var ___result = RMGetDownloadOperation_String.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadOperation(___result);
        }


        public virtual void SetupDownloadOperation(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMSetupDownloadOperation_AssetStoreDownloadOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDownloadFinalized(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMOnDownloadFinalized_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveDownloadOperation(System.String @productId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId};
            var ___result = RMRemoveDownloadOperation_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDownloadProgress(System.String @downloadId, System.String @message, System.UInt64 @bytes, System.UInt64 @total, System.Int32 @errorCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@downloadId, @message, @bytes, @total, @errorCode};
            var ___result = RMOnDownloadProgress_String_String_UInt64_UInt64_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AbortAllDownloads()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAbortAllDownloads.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AbortDownload(System.String @productId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId};
            var ___result = RMAbortDownload_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PauseDownload(System.String @productId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId};
            var ___result = RMPauseDownload_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResumeDownload(System.String @productId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId};
            var ___result = RMResumeDownload_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPlayModeStateChanged(UnityEditor.PlayModeStateChange @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RMOnPlayModeStateChanged_PlayModeStateChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDisable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUserLoginStateChange(System.Boolean @userInfoReady, System.Boolean @loggedIn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@userInfoReady, @loggedIn};
            var ___result = RMOnUserLoginStateChange_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAssetStoreCacheConfigChange(SMFrame.Editor.Refleaction.RUnityEditorInternal.RAssetStoreCachePathManager.RCachePathConfig @config)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@config.Value};
            var ___result = RMOnAssetStoreCacheConfigChange_CachePathConfig.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__SetupDownloadOperation__1__b__37_0(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @op, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError @error)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@op.Value, @error.Value};
            var ___result = RM__0__SetupDownloadOperation__1__b__37_0_IOperation_UIError.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__SetupDownloadOperation__1__b__37_1(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @op)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@op.Value};
            var ___result = RM__0__SetupDownloadOperation__1__b__37_1_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__SetupDownloadOperation__1__b__37_2(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @op)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@op.Value};
            var ___result = RM__0__SetupDownloadOperation__1__b__37_2_IOperation.Invoke(___genericsType, ___parameters);

            
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
