using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 串口重定向控制的选项。
    /// </summary>
    public class SerialPortRedirectionOptions 
    {

        /// <summary>
        /// 是否自动连接客户端串口。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("auto_connect_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoConnectEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SerialPortRedirectionOptions {\n");
            sb.Append("  autoConnectEnable: ").Append(AutoConnectEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SerialPortRedirectionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SerialPortRedirectionOptions input)
        {
            if (input == null) return false;
            if (this.AutoConnectEnable != input.AutoConnectEnable || (this.AutoConnectEnable != null && !this.AutoConnectEnable.Equals(input.AutoConnectEnable))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.AutoConnectEnable != null) hashCode = hashCode * 59 + this.AutoConnectEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
