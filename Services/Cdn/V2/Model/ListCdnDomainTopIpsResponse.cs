using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListCdnDomainTopIpsResponse : SdkResponse
    {

        /// <summary>
        /// 详情数据对象。
        /// </summary>
        [JsonProperty("top_ip_summary", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopIpSummary> TopIpSummary { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCdnDomainTopIpsResponse {\n");
            sb.Append("  topIpSummary: ").Append(TopIpSummary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCdnDomainTopIpsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCdnDomainTopIpsResponse input)
        {
            if (input == null) return false;
            if (this.TopIpSummary != input.TopIpSummary || (this.TopIpSummary != null && input.TopIpSummary != null && !this.TopIpSummary.SequenceEqual(input.TopIpSummary))) return false;

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
                if (this.TopIpSummary != null) hashCode = hashCode * 59 + this.TopIpSummary.GetHashCode();
                return hashCode;
            }
        }
    }
}
