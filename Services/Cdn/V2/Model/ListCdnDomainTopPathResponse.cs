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
    public class ListCdnDomainTopPathResponse : SdkResponse
    {

        /// <summary>
        /// 详情数据对象。
        /// </summary>
        [JsonProperty("top_path_summary", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopPathSummary> TopPathSummary { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCdnDomainTopPathResponse {\n");
            sb.Append("  topPathSummary: ").Append(TopPathSummary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCdnDomainTopPathResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCdnDomainTopPathResponse input)
        {
            if (input == null) return false;
            if (this.TopPathSummary != input.TopPathSummary || (this.TopPathSummary != null && input.TopPathSummary != null && !this.TopPathSummary.SequenceEqual(input.TopPathSummary))) return false;

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
                if (this.TopPathSummary != null) hashCode = hashCode * 59 + this.TopPathSummary.GetHashCode();
                return hashCode;
            }
        }
    }
}
