using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AljabhaAldemokratiaAlshaabia.Client
{
    public static class FileUtil
    {
        public static ValueTask<object> SaveAs(this IJSRuntime js, string filename, string url)
       => js.InvokeAsync<object>(
           "triggerFileDownload",
           filename,
           url);
    }
}
