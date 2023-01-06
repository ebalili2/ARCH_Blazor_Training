using Microsoft.JSInterop;

namespace BlazorServer.Interop.Helpers
{
    public static class JsInteropExtension
    {
        public static async Task ShowAlertMessage(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("ShowAlertMessage",message);
        }
    }
}
