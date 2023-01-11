using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RCompilerServices
{
	/// <summary>
	/// System.Runtime.CompilerServices.TaskAwaiter
	/// </summary>
    public partial class RTaskAwaiter : RMember //
    {

		/// <summary>
		/// System.Threading.Tasks.Task m_task
		/// </summary>
		protected RSystem.RThreading.RTasks.RTask r_m_task;
		public virtual RSystem.RThreading.RTasks.RTask Rm_task
		{
			get
			{
				if(r_m_task == null)
				{
					r_m_task = new(this, "m_task");
					r_m_task.SetBelong(this.instance);
				}
				return r_m_task;
			}
		}

		/// <summary>
		/// Boolean IsCompleted
		/// </summary>
		protected RSystem.RBoolean r_IsCompleted;
		public virtual RSystem.RBoolean RIsCompleted
		{
			get
			{
				if(r_IsCompleted == null)
				{
					r_IsCompleted = new(this, "IsCompleted", -1);
					r_IsCompleted.SetBelong(this.instance);
				}
				return r_IsCompleted;
			}
		}

		/// <summary>
		/// Void OnCompleted(System.Action)
		/// </summary>
		protected RMethod r_OnCompleted_Action;
		public virtual RMethod ROnCompleted_Action
		{
			get
			{
				if(r_OnCompleted_Action == null)
				{
					r_OnCompleted_Action = new(this, "OnCompleted", 0, typeof(System.Action));
					r_OnCompleted_Action.SetBelong(this.instance);
				}
				return r_OnCompleted_Action;
			}
		}

		/// <summary>
		/// Void UnsafeOnCompleted(System.Action)
		/// </summary>
		protected RMethod r_UnsafeOnCompleted_Action;
		public virtual RMethod RUnsafeOnCompleted_Action
		{
			get
			{
				if(r_UnsafeOnCompleted_Action == null)
				{
					r_UnsafeOnCompleted_Action = new(this, "UnsafeOnCompleted", 0, typeof(System.Action));
					r_UnsafeOnCompleted_Action.SetBelong(this.instance);
				}
				return r_UnsafeOnCompleted_Action;
			}
		}

		/// <summary>
		/// Void GetResult()
		/// </summary>
		protected RMethod r_GetResult;
		public virtual RMethod RGetResult
		{
			get
			{
				if(r_GetResult == null)
				{
					r_GetResult = new(this, "GetResult", 0);
					r_GetResult.SetBelong(this.instance);
				}
				return r_GetResult;
			}
		}

		/// <summary>
		/// Void ValidateEnd(System.Threading.Tasks.Task)
		/// </summary>
		protected static RMethod r_ValidateEnd_Task;
		public static RMethod RValidateEnd_Task
		{
			get
			{
				if(r_ValidateEnd_Task == null)
				{
					r_ValidateEnd_Task = new(typeof(System.Runtime.CompilerServices.TaskAwaiter), "ValidateEnd", 0, typeof(System.Threading.Tasks.Task));
					r_ValidateEnd_Task.SetBelong(null);
				}
				return r_ValidateEnd_Task;
			}
		}

		/// <summary>
		/// Void HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
		/// </summary>
		protected static RMethod r_HandleNonSuccessAndDebuggerNotification_Task;
		public static RMethod RHandleNonSuccessAndDebuggerNotification_Task
		{
			get
			{
				if(r_HandleNonSuccessAndDebuggerNotification_Task == null)
				{
					r_HandleNonSuccessAndDebuggerNotification_Task = new(typeof(System.Runtime.CompilerServices.TaskAwaiter), "HandleNonSuccessAndDebuggerNotification", 0, typeof(System.Threading.Tasks.Task));
					r_HandleNonSuccessAndDebuggerNotification_Task.SetBelong(null);
				}
				return r_HandleNonSuccessAndDebuggerNotification_Task;
			}
		}

		/// <summary>
		/// Void ThrowForNonSuccess(System.Threading.Tasks.Task)
		/// </summary>
		protected static RMethod r_ThrowForNonSuccess_Task;
		public static RMethod RThrowForNonSuccess_Task
		{
			get
			{
				if(r_ThrowForNonSuccess_Task == null)
				{
					r_ThrowForNonSuccess_Task = new(typeof(System.Runtime.CompilerServices.TaskAwaiter), "ThrowForNonSuccess", 0, typeof(System.Threading.Tasks.Task));
					r_ThrowForNonSuccess_Task.SetBelong(null);
				}
				return r_ThrowForNonSuccess_Task;
			}
		}

		/// <summary>
		/// Void OnCompletedInternal(System.Threading.Tasks.Task, System.Action, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_OnCompletedInternal_Task_Action_Boolean_Boolean;
		public static RMethod ROnCompletedInternal_Task_Action_Boolean_Boolean
		{
			get
			{
				if(r_OnCompletedInternal_Task_Action_Boolean_Boolean == null)
				{
					r_OnCompletedInternal_Task_Action_Boolean_Boolean = new(typeof(System.Runtime.CompilerServices.TaskAwaiter), "OnCompletedInternal", 0, typeof(System.Threading.Tasks.Task), typeof(System.Action), typeof(System.Boolean), typeof(System.Boolean));
					r_OnCompletedInternal_Task_Action_Boolean_Boolean.SetBelong(null);
				}
				return r_OnCompletedInternal_Task_Action_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Action OutputWaitEtwEvents(System.Threading.Tasks.Task, System.Action)
		/// </summary>
		protected static RMethod r_OutputWaitEtwEvents_Task_Action;
		public static RMethod ROutputWaitEtwEvents_Task_Action
		{
			get
			{
				if(r_OutputWaitEtwEvents_Task_Action == null)
				{
					r_OutputWaitEtwEvents_Task_Action = new(typeof(System.Runtime.CompilerServices.TaskAwaiter), "OutputWaitEtwEvents", 0, typeof(System.Threading.Tasks.Task), typeof(System.Action));
					r_OutputWaitEtwEvents_Task_Action.SetBelong(null);
				}
				return r_OutputWaitEtwEvents_Task_Action;
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


        public RTaskAwaiter() : base("System.Runtime.CompilerServices.TaskAwaiter")
        {
        }

        public RTaskAwaiter(System.Object instance) : base("System.Runtime.CompilerServices.TaskAwaiter")
		{
            SetInstance(instance);
		}

        public RTaskAwaiter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTaskAwaiter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnCompleted(System.Action @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation};
            var ___result = ROnCompleted_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnsafeOnCompleted(System.Action @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation};
            var ___result = RUnsafeOnCompleted_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetResult()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetResult.Invoke(___genericsType, ___parameters);

            
        }


        public static void ValidateEnd(System.Threading.Tasks.Task @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RValidateEnd_Task.Invoke(___genericsType, ___parameters);

            
        }


        public static void HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RHandleNonSuccessAndDebuggerNotification_Task.Invoke(___genericsType, ___parameters);

            
        }


        public static void ThrowForNonSuccess(System.Threading.Tasks.Task @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RThrowForNonSuccess_Task.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnCompletedInternal(System.Threading.Tasks.Task @task, System.Action @continuation, System.Boolean @continueOnCapturedContext, System.Boolean @flowExecutionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @continuation, @continueOnCapturedContext, @flowExecutionContext};
            var ___result = ROnCompletedInternal_Task_Action_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Action OutputWaitEtwEvents(System.Threading.Tasks.Task @task, System.Action @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @continuation};
            var ___result = ROutputWaitEtwEvents_Task_Action.Invoke(___genericsType, ___parameters);

            return (System.Action)___result;
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
