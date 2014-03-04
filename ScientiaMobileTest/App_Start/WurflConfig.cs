using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WURFL;
using WURFL.Config;

namespace ScientiaMobileTest
{
    public class WurflConfig
    {
        private const String WurflDataFilePath = "~/App_Data/wurfl-latest.zip";
        //public const String WurflPatchFilePath = "~/App_Data/web_browsers_patch.xml";
        private const string WurflManagerCacheKey = "WurflManagerCache";

        public static void Register()
        {
            var wurflDataFile = HttpContext.Current.Server.MapPath(WurflDataFilePath);
            //var wurflPatchFile = HttpContext.Current.Server.MapPath(WurflPatchFilePath);
            var configurer = new InMemoryConfigurer()
                     .MainFile(wurflDataFile);
                     //.PatchFile(wurflPatchFile);
            var manager = WURFLManagerBuilder.Build(configurer);
            //HttpContext.Current.Cache[WurflManagerCacheKey] = manager;
        }

    }
}