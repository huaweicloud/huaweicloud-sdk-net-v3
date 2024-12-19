using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowOrganizationConformancePackDetailedStatusesResponse : SdkResponse
    {

        /// <summary>
        /// 组织合规规则包查询列表。
        /// </summary>
        [JsonProperty("statuses", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrgConformancePackDetailedStatus> Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOrganizationConformancePackDetailedStatusesResponse {\n");
            sb.Append("  statuses: ").Append(Statuses).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOrganizationConformancePackDetailedStatusesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOrganizationConformancePackDetailedStatusesResponse input)
        {
            if (input == null) return false;
            if (this.Statuses != input.Statuses || (this.Statuses != null && input.Statuses != null && !this.Statuses.SequenceEqual(input.Statuses))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.Statuses != null) hashCode = hashCode * 59 + this.Statuses.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
