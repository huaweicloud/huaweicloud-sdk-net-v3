using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListWksEdgeSitesResponse : SdkResponse
    {

        /// <summary>
        /// 边缘小站列表。
        /// </summary>
        [JsonProperty("wks_edge_sites", NullValueHandling = NullValueHandling.Ignore)]
        public List<WksEdgeSiteDetail> WksEdgeSites { get; set; }

        /// <summary>
        /// 站点总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWksEdgeSitesResponse {\n");
            sb.Append("  wksEdgeSites: ").Append(WksEdgeSites).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWksEdgeSitesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWksEdgeSitesResponse input)
        {
            if (input == null) return false;
            if (this.WksEdgeSites != input.WksEdgeSites || (this.WksEdgeSites != null && input.WksEdgeSites != null && !this.WksEdgeSites.SequenceEqual(input.WksEdgeSites))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.WksEdgeSites != null) hashCode = hashCode * 59 + this.WksEdgeSites.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
