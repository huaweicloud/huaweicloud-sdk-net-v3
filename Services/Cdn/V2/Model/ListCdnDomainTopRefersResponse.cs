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
    public class ListCdnDomainTopRefersResponse : SdkResponse
    {

        /// <summary>
        /// 详情数据对象。
        /// </summary>
        [JsonProperty("top_refer_summary", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopReferSummary> TopReferSummary { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCdnDomainTopRefersResponse {\n");
            sb.Append("  topReferSummary: ").Append(TopReferSummary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCdnDomainTopRefersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCdnDomainTopRefersResponse input)
        {
            if (input == null) return false;
            if (this.TopReferSummary != input.TopReferSummary || (this.TopReferSummary != null && input.TopReferSummary != null && !this.TopReferSummary.SequenceEqual(input.TopReferSummary))) return false;

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
                if (this.TopReferSummary != null) hashCode = hashCode * 59 + this.TopReferSummary.GetHashCode();
                return hashCode;
            }
        }
    }
}
