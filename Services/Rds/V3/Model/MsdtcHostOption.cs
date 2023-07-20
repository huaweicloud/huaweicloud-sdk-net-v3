using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MsdtcHostOption 
    {

        /// <summary>
        /// 主机名称 hostname
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// 主机ip
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MsdtcHostOption {\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MsdtcHostOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MsdtcHostOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
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
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                return hashCode;
            }
        }
    }
}
