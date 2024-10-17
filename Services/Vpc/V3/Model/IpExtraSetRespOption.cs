using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IpExtraSetRespOption 
    {

        /// <summary>
        /// 功能说明：单个IP地址、IP地址范围或ip地址网段，支持IPv4、IPv6
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 功能说明：IP的备注信息 取值范围：0-255个字符，不能包含“&lt;”和“&gt;”。
        /// </summary>
        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        public string Remarks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpExtraSetRespOption {\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  remarks: ").Append(Remarks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpExtraSetRespOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpExtraSetRespOption input)
        {
            if (input == null) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.Remarks != input.Remarks || (this.Remarks != null && !this.Remarks.Equals(input.Remarks))) return false;

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
                if (this.Remarks != null) hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                return hashCode;
            }
        }
    }
}
