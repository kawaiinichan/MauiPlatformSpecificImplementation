using Android.Telephony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.PlatformServices
{
    public static partial class SmsMaster
    {
        public static void Send(string address, string message)
        {
            SmsManager smsM = SmsManager.Default;
            smsM.SendTextMessage(address, null, message, null, null);
        }
    }
}
