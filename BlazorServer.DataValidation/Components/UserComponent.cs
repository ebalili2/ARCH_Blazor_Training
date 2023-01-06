using BlazorServer.DataValidation.Helpers;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.DataValidation.Components
{
    public class UserComponent: ComponentBase
    {
        [Inject] ILogger<UserComponent> logger { get; set; }
        protected string Name { get; set; }
        protected void OnShowName(string name)
        {
            try
            {
                //throw new Exception("Sample Error");

                logger.LogInformation("From ILogger: Setting data to property Name");
                Name = name;
                LogHelper.Information("From LogHelper: Done setting data to property Name");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
        }
    }
}
