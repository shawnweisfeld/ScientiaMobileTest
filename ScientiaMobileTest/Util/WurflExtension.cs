using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WURFL;

namespace ScientiaMobileTest.Util
{
    public static class WurflExtension
    {
        public static IDevice DeviceInfo(this HttpRequest request)
        {
            return WURFLManagerBuilder.Instance.GetDeviceForRequest(request.UserAgent);
        }
    }
}