using System;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterceptor : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation) {}
        protected virtual void OnSuccess(IInvocation invocation) {}
        protected virtual void OnException(IInvocation invocation, Exception e) {}
        protected virtual void OnAfter(IInvocation invocation) {}

        public override void Intercept(IInvocation invocation)
        {
            bool isSuccess = true;
            
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
            
        }
    }
}