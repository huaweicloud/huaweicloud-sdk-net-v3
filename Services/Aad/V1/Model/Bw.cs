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
    /// 黑白名单详情
    /// </summary>
    public class Bw 
    {

        /// <summary>
        /// 黑名单列表
        /// </summary>
        [JsonProperty("black_ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BlackIpList { get; set; }

        /// <summary>
        /// 白名单列表
        /// </summary>
        [JsonProperty("white_ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WhiteIpList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bw {\n");
            sb.Append("  blackIpList: ").Append(BlackIpList).Append("\n");
            sb.Append("  whiteIpList: ").Append(WhiteIpList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Bw);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Bw input)
        {
            if (input == null) return false;
            if (this.BlackIpList != input.BlackIpList || (this.BlackIpList != null && input.BlackIpList != null && !this.BlackIpList.SequenceEqual(input.BlackIpList))) return false;
            if (this.WhiteIpList != input.WhiteIpList || (this.WhiteIpList != null && input.WhiteIpList != null && !this.WhiteIpList.SequenceEqual(input.WhiteIpList))) return false;

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
                if (this.BlackIpList != null) hashCode = hashCode * 59 + this.BlackIpList.GetHashCode();
                if (this.WhiteIpList != null) hashCode = hashCode * 59 + this.WhiteIpList.GetHashCode();
                return hashCode;
            }
        }
    }
}
