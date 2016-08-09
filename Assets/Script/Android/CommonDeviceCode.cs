using UnityEngine;

namespace UniLibs.Android
{
    public class CommonDeviceCode
    {
        /// <summary>
        /// 设备序列号
        /// </summary>
        public static string SerialNumber
        {
            get
            {
                AndroidJavaObject jo = new AndroidJavaObject("android.os.Build");
                return jo.GetStatic<string>("SERIAL");
            }
        }
    }
}
