using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace pjjfirstpush
{
    public static class Constants
    {
        public const string SenderID = "400187949142"; // Google API Project Number
        public const string ListenConnectionString = "Endpoint=sb://pjjfirstnamespace.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=bxNx7bUc/swbZy8DeGhSVTPAXZq7a8lUwxI7+VH9rHY=";
        public const string NotificationHubName = "pjjfirstnotificationhub";
    }
}