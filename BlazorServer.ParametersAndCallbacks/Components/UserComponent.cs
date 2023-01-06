using Microsoft.AspNetCore.Components;

namespace BlazorServer.ParametersAndCallbacks.Components
{
    public class UserComponent: ComponentBase
    {
        protected string Name { get; set; }
        protected void OnShowName(string name)
        {
            Name = name;
        }
    }
}
