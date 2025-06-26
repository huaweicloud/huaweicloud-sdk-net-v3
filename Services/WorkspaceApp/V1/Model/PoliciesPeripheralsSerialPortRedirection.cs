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
    /// 串口重定向。
    /// </summary>
    public class PoliciesPeripheralsSerialPortRedirection 
    {

        /// <summary>
        /// 是否开启串口重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("serial_port_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SerialPortEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public SerialPortRedirectionOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsSerialPortRedirection {\n");
            sb.Append("  serialPortEnable: ").Append(SerialPortEnable).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsSerialPortRedirection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsSerialPortRedirection input)
        {
            if (input == null) return false;
            if (this.SerialPortEnable != input.SerialPortEnable || (this.SerialPortEnable != null && !this.SerialPortEnable.Equals(input.SerialPortEnable))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;

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
                if (this.SerialPortEnable != null) hashCode = hashCode * 59 + this.SerialPortEnable.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
