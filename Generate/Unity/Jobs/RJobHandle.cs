using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnity.RJobs
{
	/// <summary>
	/// Unity.Jobs.JobHandle
	/// </summary>
    public partial class RJobHandle : RMember //
    {

		/// <summary>
		/// System.UInt64 jobGroup
		/// </summary>
		protected RSystem.RUInt64 r_FjobGroup;
		public virtual RSystem.RUInt64 RFjobGroup
		{
			get
			{
				if(r_FjobGroup == null)
				{
					r_FjobGroup = new(this, "jobGroup");
					r_FjobGroup.SetBelong(this.instance);
				}
				return r_FjobGroup;
			}
		}

		/// <summary>
		/// System.Int32 version
		/// </summary>
		protected RSystem.RInt32 r_Fversion;
		public virtual RSystem.RInt32 RFversion
		{
			get
			{
				if(r_Fversion == null)
				{
					r_Fversion = new(this, "version");
					r_Fversion.SetBelong(this.instance);
				}
				return r_Fversion;
			}
		}

		/// <summary>
		/// System.Int32 debugVersion
		/// </summary>
		protected RSystem.RInt32 r_FdebugVersion;
		public virtual RSystem.RInt32 RFdebugVersion
		{
			get
			{
				if(r_FdebugVersion == null)
				{
					r_FdebugVersion = new(this, "debugVersion");
					r_FdebugVersion.SetBelong(this.instance);
				}
				return r_FdebugVersion;
			}
		}

		/// <summary>
		/// System.IntPtr debugInfo
		/// </summary>
		protected RSystem.RIntPtr r_FdebugInfo;
		public virtual RSystem.RIntPtr RFdebugInfo
		{
			get
			{
				if(r_FdebugInfo == null)
				{
					r_FdebugInfo = new(this, "debugInfo");
					r_FdebugInfo.SetBelong(this.instance);
				}
				return r_FdebugInfo;
			}
		}

		/// <summary>
		/// Boolean IsCompleted
		/// </summary>
		protected RSystem.RBoolean r_PIsCompleted;
		public virtual RSystem.RBoolean RPIsCompleted
		{
			get
			{
				if(r_PIsCompleted == null)
				{
					r_PIsCompleted = new(this, "IsCompleted", -1);
					r_PIsCompleted.SetBelong(this.instance);
				}
				return r_PIsCompleted;
			}
		}

		/// <summary>
		/// Void Complete()
		/// </summary>
		protected RMethod r_MComplete;
		public virtual RMethod RMComplete
		{
			get
			{
				if(r_MComplete == null)
				{
					r_MComplete = new(this, "Complete", 0);
					r_MComplete.SetBelong(this.instance);
				}
				return r_MComplete;
			}
		}

		/// <summary>
		/// Void CompleteAll(Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_MCompleteAll_Ref_JobHandle_Ref_JobHandle;
		public static RMethod RMCompleteAll_Ref_JobHandle_Ref_JobHandle
		{
			get
			{
				if(r_MCompleteAll_Ref_JobHandle_Ref_JobHandle == null)
				{
					r_MCompleteAll_Ref_JobHandle_Ref_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CompleteAll", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_MCompleteAll_Ref_JobHandle_Ref_JobHandle.SetBelong(null);
				}
				return r_MCompleteAll_Ref_JobHandle_Ref_JobHandle;
			}
		}

		/// <summary>
		/// Void CompleteAll(Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_MCompleteAll_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle;
		public static RMethod RMCompleteAll_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle
		{
			get
			{
				if(r_MCompleteAll_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle == null)
				{
					r_MCompleteAll_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CompleteAll", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_MCompleteAll_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle.SetBelong(null);
				}
				return r_MCompleteAll_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle;
			}
		}

		/// <summary>
		/// Void CompleteAll(Unity.Collections.NativeArray`1[Unity.Jobs.JobHandle])
		/// </summary>
		protected static RMethod r_MCompleteAll_NativeArray_d_JobHandle_p_;
		public static RMethod RMCompleteAll_NativeArray_d_JobHandle_p_
		{
			get
			{
				if(r_MCompleteAll_NativeArray_d_JobHandle_p_ == null)
				{
					r_MCompleteAll_NativeArray_d_JobHandle_p_ = new(typeof(Unity.Jobs.JobHandle), "CompleteAll", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(Unity.Jobs.JobHandle)));
					r_MCompleteAll_NativeArray_d_JobHandle_p_.SetBelong(null);
				}
				return r_MCompleteAll_NativeArray_d_JobHandle_p_;
			}
		}

		/// <summary>
		/// Void ScheduleBatchedJobs()
		/// </summary>
		protected static RMethod r_MScheduleBatchedJobs;
		public static RMethod RMScheduleBatchedJobs
		{
			get
			{
				if(r_MScheduleBatchedJobs == null)
				{
					r_MScheduleBatchedJobs = new(typeof(Unity.Jobs.JobHandle), "ScheduleBatchedJobs", 0);
					r_MScheduleBatchedJobs.SetBelong(null);
				}
				return r_MScheduleBatchedJobs;
			}
		}

		/// <summary>
		/// Void ScheduleBatchedJobsAndComplete(Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_MScheduleBatchedJobsAndComplete_Ref_JobHandle;
		public static RMethod RMScheduleBatchedJobsAndComplete_Ref_JobHandle
		{
			get
			{
				if(r_MScheduleBatchedJobsAndComplete_Ref_JobHandle == null)
				{
					r_MScheduleBatchedJobsAndComplete_Ref_JobHandle = new(typeof(Unity.Jobs.JobHandle), "ScheduleBatchedJobsAndComplete", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_MScheduleBatchedJobsAndComplete_Ref_JobHandle.SetBelong(null);
				}
				return r_MScheduleBatchedJobsAndComplete_Ref_JobHandle;
			}
		}

		/// <summary>
		/// Boolean ScheduleBatchedJobsAndIsCompleted(Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_MScheduleBatchedJobsAndIsCompleted_Ref_JobHandle;
		public static RMethod RMScheduleBatchedJobsAndIsCompleted_Ref_JobHandle
		{
			get
			{
				if(r_MScheduleBatchedJobsAndIsCompleted_Ref_JobHandle == null)
				{
					r_MScheduleBatchedJobsAndIsCompleted_Ref_JobHandle = new(typeof(Unity.Jobs.JobHandle), "ScheduleBatchedJobsAndIsCompleted", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_MScheduleBatchedJobsAndIsCompleted_Ref_JobHandle.SetBelong(null);
				}
				return r_MScheduleBatchedJobsAndIsCompleted_Ref_JobHandle;
			}
		}

		/// <summary>
		/// Void ScheduleBatchedJobsAndCompleteAll(Void*, Int32)
		/// </summary>
		protected static RMethod r_MScheduleBatchedJobsAndCompleteAll_VoidPointer_Int32;
		public static RMethod RMScheduleBatchedJobsAndCompleteAll_VoidPointer_Int32
		{
			get
			{
				if(r_MScheduleBatchedJobsAndCompleteAll_VoidPointer_Int32 == null)
				{
					r_MScheduleBatchedJobsAndCompleteAll_VoidPointer_Int32 = new(typeof(Unity.Jobs.JobHandle), "ScheduleBatchedJobsAndCompleteAll", 0, typeof(void).MakePointerType(), typeof(System.Int32));
					r_MScheduleBatchedJobsAndCompleteAll_VoidPointer_Int32.SetBelong(null);
				}
				return r_MScheduleBatchedJobsAndCompleteAll_VoidPointer_Int32;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle, Unity.Jobs.JobHandle)
		/// </summary>
		protected static RMethod r_MCombineDependencies_JobHandle_JobHandle;
		public static RMethod RMCombineDependencies_JobHandle_JobHandle
		{
			get
			{
				if(r_MCombineDependencies_JobHandle_JobHandle == null)
				{
					r_MCombineDependencies_JobHandle_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CombineDependencies", 0, typeof(Unity.Jobs.JobHandle), typeof(Unity.Jobs.JobHandle));
					r_MCombineDependencies_JobHandle_JobHandle.SetBelong(null);
				}
				return r_MCombineDependencies_JobHandle_JobHandle;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle, Unity.Jobs.JobHandle, Unity.Jobs.JobHandle)
		/// </summary>
		protected static RMethod r_MCombineDependencies_JobHandle_JobHandle_JobHandle;
		public static RMethod RMCombineDependencies_JobHandle_JobHandle_JobHandle
		{
			get
			{
				if(r_MCombineDependencies_JobHandle_JobHandle_JobHandle == null)
				{
					r_MCombineDependencies_JobHandle_JobHandle_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CombineDependencies", 0, typeof(Unity.Jobs.JobHandle), typeof(Unity.Jobs.JobHandle), typeof(Unity.Jobs.JobHandle));
					r_MCombineDependencies_JobHandle_JobHandle_JobHandle.SetBelong(null);
				}
				return r_MCombineDependencies_JobHandle_JobHandle_JobHandle;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeArray`1[Unity.Jobs.JobHandle])
		/// </summary>
		protected static RMethod r_MCombineDependencies_NativeArray_d_JobHandle_p_;
		public static RMethod RMCombineDependencies_NativeArray_d_JobHandle_p_
		{
			get
			{
				if(r_MCombineDependencies_NativeArray_d_JobHandle_p_ == null)
				{
					r_MCombineDependencies_NativeArray_d_JobHandle_p_ = new(typeof(Unity.Jobs.JobHandle), "CombineDependencies", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(Unity.Jobs.JobHandle)));
					r_MCombineDependencies_NativeArray_d_JobHandle_p_.SetBelong(null);
				}
				return r_MCombineDependencies_NativeArray_d_JobHandle_p_;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeSlice`1[Unity.Jobs.JobHandle])
		/// </summary>
		protected static RMethod r_MCombineDependencies_NativeSlice_d_JobHandle_p_;
		public static RMethod RMCombineDependencies_NativeSlice_d_JobHandle_p_
		{
			get
			{
				if(r_MCombineDependencies_NativeSlice_d_JobHandle_p_ == null)
				{
					r_MCombineDependencies_NativeSlice_d_JobHandle_p_ = new(typeof(Unity.Jobs.JobHandle), "CombineDependencies", 0, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(Unity.Jobs.JobHandle)));
					r_MCombineDependencies_NativeSlice_d_JobHandle_p_.SetBelong(null);
				}
				return r_MCombineDependencies_NativeSlice_d_JobHandle_p_;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle CombineDependenciesInternal2(Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_MCombineDependenciesInternal2_Ref_JobHandle_Ref_JobHandle;
		public static RMethod RMCombineDependenciesInternal2_Ref_JobHandle_Ref_JobHandle
		{
			get
			{
				if(r_MCombineDependenciesInternal2_Ref_JobHandle_Ref_JobHandle == null)
				{
					r_MCombineDependenciesInternal2_Ref_JobHandle_Ref_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CombineDependenciesInternal2", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_MCombineDependenciesInternal2_Ref_JobHandle_Ref_JobHandle.SetBelong(null);
				}
				return r_MCombineDependenciesInternal2_Ref_JobHandle_Ref_JobHandle;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle CombineDependenciesInternal3(Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_MCombineDependenciesInternal3_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle;
		public static RMethod RMCombineDependenciesInternal3_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle
		{
			get
			{
				if(r_MCombineDependenciesInternal3_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle == null)
				{
					r_MCombineDependenciesInternal3_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CombineDependenciesInternal3", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_MCombineDependenciesInternal3_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle.SetBelong(null);
				}
				return r_MCombineDependenciesInternal3_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle CombineDependenciesInternalPtr(Void*, Int32)
		/// </summary>
		protected static RMethod r_MCombineDependenciesInternalPtr_VoidPointer_Int32;
		public static RMethod RMCombineDependenciesInternalPtr_VoidPointer_Int32
		{
			get
			{
				if(r_MCombineDependenciesInternalPtr_VoidPointer_Int32 == null)
				{
					r_MCombineDependenciesInternalPtr_VoidPointer_Int32 = new(typeof(Unity.Jobs.JobHandle), "CombineDependenciesInternalPtr", 0, typeof(void).MakePointerType(), typeof(System.Int32));
					r_MCombineDependenciesInternalPtr_VoidPointer_Int32.SetBelong(null);
				}
				return r_MCombineDependenciesInternalPtr_VoidPointer_Int32;
			}
		}

		/// <summary>
		/// Boolean CheckFenceIsDependencyOrDidSyncFence(Unity.Jobs.JobHandle, Unity.Jobs.JobHandle)
		/// </summary>
		protected static RMethod r_MCheckFenceIsDependencyOrDidSyncFence_JobHandle_JobHandle;
		public static RMethod RMCheckFenceIsDependencyOrDidSyncFence_JobHandle_JobHandle
		{
			get
			{
				if(r_MCheckFenceIsDependencyOrDidSyncFence_JobHandle_JobHandle == null)
				{
					r_MCheckFenceIsDependencyOrDidSyncFence_JobHandle_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CheckFenceIsDependencyOrDidSyncFence", 0, typeof(Unity.Jobs.JobHandle), typeof(Unity.Jobs.JobHandle));
					r_MCheckFenceIsDependencyOrDidSyncFence_JobHandle_JobHandle.SetBelong(null);
				}
				return r_MCheckFenceIsDependencyOrDidSyncFence_JobHandle_JobHandle;
			}
		}

		/// <summary>
		/// Boolean Equals(Unity.Jobs.JobHandle)
		/// </summary>
		protected RMethod r_MEquals_JobHandle;
		public virtual RMethod RMEquals_JobHandle
		{
			get
			{
				if(r_MEquals_JobHandle == null)
				{
					r_MEquals_JobHandle = new(this, "Equals", 0, typeof(Unity.Jobs.JobHandle));
					r_MEquals_JobHandle.SetBelong(this.instance);
				}
				return r_MEquals_JobHandle;
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
		/// Boolean op_Equality(Unity.Jobs.JobHandle, Unity.Jobs.JobHandle)
		/// </summary>
		protected static RMethod r_Mop_Equality_JobHandle_JobHandle;
		public static RMethod RMop_Equality_JobHandle_JobHandle
		{
			get
			{
				if(r_Mop_Equality_JobHandle_JobHandle == null)
				{
					r_Mop_Equality_JobHandle_JobHandle = new(typeof(Unity.Jobs.JobHandle), "op_Equality", 0, typeof(Unity.Jobs.JobHandle), typeof(Unity.Jobs.JobHandle));
					r_Mop_Equality_JobHandle_JobHandle.SetBelong(null);
				}
				return r_Mop_Equality_JobHandle_JobHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Unity.Jobs.JobHandle, Unity.Jobs.JobHandle)
		/// </summary>
		protected static RMethod r_Mop_Inequality_JobHandle_JobHandle;
		public static RMethod RMop_Inequality_JobHandle_JobHandle
		{
			get
			{
				if(r_Mop_Inequality_JobHandle_JobHandle == null)
				{
					r_Mop_Inequality_JobHandle_JobHandle = new(typeof(Unity.Jobs.JobHandle), "op_Inequality", 0, typeof(Unity.Jobs.JobHandle), typeof(Unity.Jobs.JobHandle));
					r_Mop_Inequality_JobHandle_JobHandle.SetBelong(null);
				}
				return r_Mop_Inequality_JobHandle_JobHandle;
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
		/// Void CombineDependenciesInternal2_Injected(Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_MCombineDependenciesInternal2_Injected_Ref_JobHandle_Ref_JobHandle_Out_JobHandle;
		public static RMethod RMCombineDependenciesInternal2_Injected_Ref_JobHandle_Ref_JobHandle_Out_JobHandle
		{
			get
			{
				if(r_MCombineDependenciesInternal2_Injected_Ref_JobHandle_Ref_JobHandle_Out_JobHandle == null)
				{
					r_MCombineDependenciesInternal2_Injected_Ref_JobHandle_Ref_JobHandle_Out_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CombineDependenciesInternal2_Injected", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_MCombineDependenciesInternal2_Injected_Ref_JobHandle_Ref_JobHandle_Out_JobHandle.SetBelong(null);
				}
				return r_MCombineDependenciesInternal2_Injected_Ref_JobHandle_Ref_JobHandle_Out_JobHandle;
			}
		}

		/// <summary>
		/// Void CombineDependenciesInternal3_Injected(Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_MCombineDependenciesInternal3_Injected_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle_Out_JobHandle;
		public static RMethod RMCombineDependenciesInternal3_Injected_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle_Out_JobHandle
		{
			get
			{
				if(r_MCombineDependenciesInternal3_Injected_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle_Out_JobHandle == null)
				{
					r_MCombineDependenciesInternal3_Injected_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle_Out_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CombineDependenciesInternal3_Injected", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_MCombineDependenciesInternal3_Injected_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle_Out_JobHandle.SetBelong(null);
				}
				return r_MCombineDependenciesInternal3_Injected_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle_Out_JobHandle;
			}
		}

		/// <summary>
		/// Void CombineDependenciesInternalPtr_Injected(Void*, Int32, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_MCombineDependenciesInternalPtr_Injected_VoidPointer_Int32_Out_JobHandle;
		public static RMethod RMCombineDependenciesInternalPtr_Injected_VoidPointer_Int32_Out_JobHandle
		{
			get
			{
				if(r_MCombineDependenciesInternalPtr_Injected_VoidPointer_Int32_Out_JobHandle == null)
				{
					r_MCombineDependenciesInternalPtr_Injected_VoidPointer_Int32_Out_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CombineDependenciesInternalPtr_Injected", 0, typeof(void).MakePointerType(), typeof(System.Int32), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_MCombineDependenciesInternalPtr_Injected_VoidPointer_Int32_Out_JobHandle.SetBelong(null);
				}
				return r_MCombineDependenciesInternalPtr_Injected_VoidPointer_Int32_Out_JobHandle;
			}
		}

		/// <summary>
		/// Boolean CheckFenceIsDependencyOrDidSyncFence_Injected(Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_MCheckFenceIsDependencyOrDidSyncFence_Injected_Ref_JobHandle_Ref_JobHandle;
		public static RMethod RMCheckFenceIsDependencyOrDidSyncFence_Injected_Ref_JobHandle_Ref_JobHandle
		{
			get
			{
				if(r_MCheckFenceIsDependencyOrDidSyncFence_Injected_Ref_JobHandle_Ref_JobHandle == null)
				{
					r_MCheckFenceIsDependencyOrDidSyncFence_Injected_Ref_JobHandle_Ref_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CheckFenceIsDependencyOrDidSyncFence_Injected", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_MCheckFenceIsDependencyOrDidSyncFence_Injected_Ref_JobHandle_Ref_JobHandle.SetBelong(null);
				}
				return r_MCheckFenceIsDependencyOrDidSyncFence_Injected_Ref_JobHandle_Ref_JobHandle;
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


        public RJobHandle() : base("Unity.Jobs.JobHandle")
        {
        }

        public RJobHandle(System.Object instance) : base("Unity.Jobs.JobHandle")
		{
            SetInstance(instance);
		}

        public RJobHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RJobHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Complete()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMComplete.Invoke(___genericsType, ___parameters);

            
        }


        public static void CompleteAll(ref Unity.Jobs.JobHandle @job0, ref Unity.Jobs.JobHandle @job1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1};
            var ___result = RMCompleteAll_Ref_JobHandle_Ref_JobHandle.Invoke(___genericsType, ___parameters);
			@job0 = (Unity.Jobs.JobHandle)___parameters[0];
			@job1 = (Unity.Jobs.JobHandle)___parameters[1];

            
        }


        public static void CompleteAll(ref Unity.Jobs.JobHandle @job0, ref Unity.Jobs.JobHandle @job1, ref Unity.Jobs.JobHandle @job2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1, @job2};
            var ___result = RMCompleteAll_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle.Invoke(___genericsType, ___parameters);
			@job0 = (Unity.Jobs.JobHandle)___parameters[0];
			@job1 = (Unity.Jobs.JobHandle)___parameters[1];
			@job2 = (Unity.Jobs.JobHandle)___parameters[2];

            
        }


        public static void CompleteAll(RUnity.RCollections.RNativeArray<RUnity.RJobs.RJobHandle> @jobs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@jobs.Value};
            var ___result = RMCompleteAll_NativeArray_d_JobHandle_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void ScheduleBatchedJobs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMScheduleBatchedJobs.Invoke(___genericsType, ___parameters);

            
        }


        public static void ScheduleBatchedJobsAndComplete(ref Unity.Jobs.JobHandle @job)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job};
            var ___result = RMScheduleBatchedJobsAndComplete_Ref_JobHandle.Invoke(___genericsType, ___parameters);
			@job = (Unity.Jobs.JobHandle)___parameters[0];

            
        }


        public static System.Boolean ScheduleBatchedJobsAndIsCompleted(ref Unity.Jobs.JobHandle @job)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job};
            var ___result = RMScheduleBatchedJobsAndIsCompleted_Ref_JobHandle.Invoke(___genericsType, ___parameters);
			@job = (Unity.Jobs.JobHandle)___parameters[0];

            return (System.Boolean)___result;
        }


        public unsafe static void ScheduleBatchedJobsAndCompleteAll(void* @jobs, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@jobs, typeof(void)), @count};
            var ___result = RMScheduleBatchedJobsAndCompleteAll_VoidPointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle @job0, Unity.Jobs.JobHandle @job1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1};
            var ___result = RMCombineDependencies_JobHandle_JobHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Jobs.JobHandle)___result;
        }


        public static Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle @job0, Unity.Jobs.JobHandle @job1, Unity.Jobs.JobHandle @job2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1, @job2};
            var ___result = RMCombineDependencies_JobHandle_JobHandle_JobHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Jobs.JobHandle)___result;
        }


        public static Unity.Jobs.JobHandle CombineDependencies(RUnity.RCollections.RNativeArray<RUnity.RJobs.RJobHandle> @jobs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@jobs.Value};
            var ___result = RMCombineDependencies_NativeArray_d_JobHandle_p_.Invoke(___genericsType, ___parameters);

            return (Unity.Jobs.JobHandle)___result;
        }


        public static Unity.Jobs.JobHandle CombineDependencies(RUnity.RCollections.RNativeSlice<RUnity.RJobs.RJobHandle> @jobs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@jobs.Value};
            var ___result = RMCombineDependencies_NativeSlice_d_JobHandle_p_.Invoke(___genericsType, ___parameters);

            return (Unity.Jobs.JobHandle)___result;
        }


        public static Unity.Jobs.JobHandle CombineDependenciesInternal2(ref Unity.Jobs.JobHandle @job0, ref Unity.Jobs.JobHandle @job1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1};
            var ___result = RMCombineDependenciesInternal2_Ref_JobHandle_Ref_JobHandle.Invoke(___genericsType, ___parameters);
			@job0 = (Unity.Jobs.JobHandle)___parameters[0];
			@job1 = (Unity.Jobs.JobHandle)___parameters[1];

            return (Unity.Jobs.JobHandle)___result;
        }


        public static Unity.Jobs.JobHandle CombineDependenciesInternal3(ref Unity.Jobs.JobHandle @job0, ref Unity.Jobs.JobHandle @job1, ref Unity.Jobs.JobHandle @job2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1, @job2};
            var ___result = RMCombineDependenciesInternal3_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle.Invoke(___genericsType, ___parameters);
			@job0 = (Unity.Jobs.JobHandle)___parameters[0];
			@job1 = (Unity.Jobs.JobHandle)___parameters[1];
			@job2 = (Unity.Jobs.JobHandle)___parameters[2];

            return (Unity.Jobs.JobHandle)___result;
        }


        public unsafe static Unity.Jobs.JobHandle CombineDependenciesInternalPtr(void* @jobs, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@jobs, typeof(void)), @count};
            var ___result = RMCombineDependenciesInternalPtr_VoidPointer_Int32.Invoke(___genericsType, ___parameters);

            return (Unity.Jobs.JobHandle)___result;
        }


        public static System.Boolean CheckFenceIsDependencyOrDidSyncFence(Unity.Jobs.JobHandle @jobHandle, Unity.Jobs.JobHandle @dependsOn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@jobHandle, @dependsOn};
            var ___result = RMCheckFenceIsDependencyOrDidSyncFence_JobHandle_JobHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(Unity.Jobs.JobHandle @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_JobHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(Unity.Jobs.JobHandle @a, Unity.Jobs.JobHandle @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_JobHandle_JobHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(Unity.Jobs.JobHandle @a, Unity.Jobs.JobHandle @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_JobHandle_JobHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void CombineDependenciesInternal2_Injected(ref Unity.Jobs.JobHandle @job0, ref Unity.Jobs.JobHandle @job1, out Unity.Jobs.JobHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1, @ret};
            var ___result = RMCombineDependenciesInternal2_Injected_Ref_JobHandle_Ref_JobHandle_Out_JobHandle.Invoke(___genericsType, ___parameters);
			@job0 = (Unity.Jobs.JobHandle)___parameters[0];
			@job1 = (Unity.Jobs.JobHandle)___parameters[1];
			@ret = (Unity.Jobs.JobHandle)___parameters[2];

            
        }


        public static void CombineDependenciesInternal3_Injected(ref Unity.Jobs.JobHandle @job0, ref Unity.Jobs.JobHandle @job1, ref Unity.Jobs.JobHandle @job2, out Unity.Jobs.JobHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1, @job2, @ret};
            var ___result = RMCombineDependenciesInternal3_Injected_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle_Out_JobHandle.Invoke(___genericsType, ___parameters);
			@job0 = (Unity.Jobs.JobHandle)___parameters[0];
			@job1 = (Unity.Jobs.JobHandle)___parameters[1];
			@job2 = (Unity.Jobs.JobHandle)___parameters[2];
			@ret = (Unity.Jobs.JobHandle)___parameters[3];

            
        }


        public unsafe static void CombineDependenciesInternalPtr_Injected(void* @jobs, System.Int32 @count, out Unity.Jobs.JobHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@jobs, typeof(void)), @count, @ret};
            var ___result = RMCombineDependenciesInternalPtr_Injected_VoidPointer_Int32_Out_JobHandle.Invoke(___genericsType, ___parameters);
			@ret = (Unity.Jobs.JobHandle)___parameters[2];

            
        }


        public static System.Boolean CheckFenceIsDependencyOrDidSyncFence_Injected(ref Unity.Jobs.JobHandle @jobHandle, ref Unity.Jobs.JobHandle @dependsOn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@jobHandle, @dependsOn};
            var ___result = RMCheckFenceIsDependencyOrDidSyncFence_Injected_Ref_JobHandle_Ref_JobHandle.Invoke(___genericsType, ___parameters);
			@jobHandle = (Unity.Jobs.JobHandle)___parameters[0];
			@dependsOn = (Unity.Jobs.JobHandle)___parameters[1];

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
