using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// 重启裸金属服务器接口请求结构体
    /// </summary>
    public class RebootBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("reboot", NullValueHandling = NullValueHandling.Ignore)]
        public ServersInfoType Reboot { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RebootBody {\n");
            sb.Append("  reboot: ").Append(Reboot).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RebootBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RebootBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reboot == input.Reboot ||
                    (this.Reboot != null &&
                    this.Reboot.Equals(input.Reboot))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Reboot != null)
                    hashCode = hashCode * 59 + this.Reboot.GetHashCode();
                return hashCode;
            }
        }
    }
}
