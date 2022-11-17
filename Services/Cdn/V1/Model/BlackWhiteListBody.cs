using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BlackWhiteListBody 
    {

        /// <summary>
        /// IP黑白名单类型（0：关闭IP黑白名单功能，1：黑名单，2：白名单）
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// IP黑白名单列表（支持掩码且有掩码的情况下IP必须是该IP段的第一个IP）
        /// </summary>
        [JsonProperty("ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpList { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlackWhiteListBody {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  ipList: ").Append(IpList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BlackWhiteListBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BlackWhiteListBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IpList == input.IpList ||
                    this.IpList != null &&
                    input.IpList != null &&
                    this.IpList.SequenceEqual(input.IpList)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IpList != null)
                    hashCode = hashCode * 59 + this.IpList.GetHashCode();
                return hashCode;
            }
        }
    }
}
