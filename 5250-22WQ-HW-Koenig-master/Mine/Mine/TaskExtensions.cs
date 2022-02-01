using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace Mine
{
    public static class TaskExtensions
    {
        // NOTE: Async void is intentional here. This is provide a way to call all 
        //async method from constructor
        // while communicating intent to fire and forget, amd allow handling of 
        //exception
        public static async void SafeFireAndForget(this Task task, bool
            returntoCallingContext, Action<Exception> onException = null)
        {
            try
            {
                await task.ConfigureAwait(returntoCallingContext);
            }
            // If the provided action is not null, catch and pass the thrown 
            //excecption
            catch (Exception ex) when (onException != null)
            {
                onException(ex);
            }
        }
    }
}
