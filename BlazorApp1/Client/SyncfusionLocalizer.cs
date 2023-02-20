using BlazorApp1.Client.Resources;
using Syncfusion.Blazor;

namespace LocalizationServer.Shared
{
    public class SyncfusionLocalizer : ISyncfusionStringLocalizer
    {
        // To get the locale key from mapped resources file
        public string GetText(string key)
        {
            return ResourceManager.GetString(key);
        }

        // To access the resource file and get the exact value for locale key

        public System.Resources.ResourceManager ResourceManager
        {
            get
            {
                // Replace the ApplicationNamespace with your application name.
                return SfResources.ResourceManager;
            }
        }
    }
}
