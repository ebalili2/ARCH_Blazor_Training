using Microsoft.AspNetCore.Components;

namespace BlazorServer.DataBinding.Components
{
    public class UserComponent: ComponentBase
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        protected void Click()
        {
            Name = $"{FirstName} {LastName}";
        }
    }
}
