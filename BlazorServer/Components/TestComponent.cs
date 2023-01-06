using BlazorServer.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace BlazorServer.Components
{
    public class TestComponent : ComponentBase
    {
        [Parameter] public int Id { get; set; }
        [Inject] public IHttpClientFactory HttpClientFactory { get; set; }
        [Inject] public ConfigHelper ConfigHelper { get; set; }
        [Inject] public IConfiguration Configuration { get; set; }
        [Inject] public IOptionsSnapshot<AppSetting> Configuration1 { get; set; }

        protected override Task OnInitializedAsync()
        {
            var test = Configuration["TestConn"];
            var test1 = Configuration1.Value.TestConn;
            return base.OnInitializedAsync();
        }
    }
}
