using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.PlatformServices
{
    public static partial class SmsMaster
	{
        public static void SendSMS(string cellNumber, string smsText) => Send(cellNumber, smsText);
    }
}
