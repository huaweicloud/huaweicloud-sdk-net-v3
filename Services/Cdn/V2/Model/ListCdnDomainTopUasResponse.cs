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
    public class ListCdnDomainTopUasResponse : SdkResponse
    {

        /// <summary>
        /// 详情数据对象。
        /// </summary>
        [JsonProperty("top_ua_summary", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopUaSummary> TopUaSummary { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCdnDomainTopUasResponse {\n");
            sb.Append("  topUaSummary: ").Append(TopUaSummary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCdnDomainTopUasResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCdnDomainTopUasResponse input)
        {
            if (input == null) return false;
            if (this.TopUaSummary != input.TopUaSummary || (this.TopUaSummary != null && input.TopUaSummary != null && !this.TopUaSummary.SequenceEqual(input.TopUaSummary))) return false;

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
                if (this.TopUaSummary != null) hashCode = hashCode * 59 + this.TopUaSummary.GetHashCode();
                return hashCode;
            }
        }
    }
}
