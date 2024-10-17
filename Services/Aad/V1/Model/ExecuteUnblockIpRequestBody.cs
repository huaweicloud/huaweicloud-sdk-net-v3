using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExecuteUnblockIpRequestBody 
    {

        /// <summary>
        /// ip地址
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 用于查询IP的封堵时间
        /// </summary>
        [JsonProperty("blocking_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? BlockingTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteUnblockIpRequestBody {\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  blockingTime: ").Append(BlockingTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteUnblockIpRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteUnblockIpRequestBody input)
        {
            if (input == null) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.BlockingTime != input.BlockingTime || (this.BlockingTime != null && !this.BlockingTime.Equals(input.BlockingTime))) return false;

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
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.BlockingTime != null) hashCode = hashCode * 59 + this.BlockingTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
