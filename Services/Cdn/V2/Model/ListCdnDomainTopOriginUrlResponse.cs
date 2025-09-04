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
    public class ListCdnDomainTopOriginUrlResponse : SdkResponse
    {

        /// <summary>
        /// 详情数据对象。
        /// </summary>
        [JsonProperty("top_origin_url_summary", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopOriginUrlSummary> TopOriginUrlSummary { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCdnDomainTopOriginUrlResponse {\n");
            sb.Append("  topOriginUrlSummary: ").Append(TopOriginUrlSummary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCdnDomainTopOriginUrlResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCdnDomainTopOriginUrlResponse input)
        {
            if (input == null) return false;
            if (this.TopOriginUrlSummary != input.TopOriginUrlSummary || (this.TopOriginUrlSummary != null && input.TopOriginUrlSummary != null && !this.TopOriginUrlSummary.SequenceEqual(input.TopOriginUrlSummary))) return false;

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
                if (this.TopOriginUrlSummary != null) hashCode = hashCode * 59 + this.TopOriginUrlSummary.GetHashCode();
                return hashCode;
            }
        }
    }
}
