using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace TOCOMA_ERP_System.Data
{
    public static class IJSRuntimeExtentionMethod
    {
        public static async ValueTask InitializeInactivityTimer<T>(this IJSRuntime js,
            DotNetObjectReference<T> dotNetObjectReference) where T : class
        {
            await js.InvokeVoidAsync("initializeInactivityTimer", dotNetObjectReference);
        }
    }
}
