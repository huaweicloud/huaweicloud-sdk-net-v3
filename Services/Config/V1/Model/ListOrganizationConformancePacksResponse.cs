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
    public class ListOrganizationConformancePacksResponse : SdkResponse
    {

        /// <summary>
        /// 组织合规规则包查询列表。
        /// </summary>
        [JsonProperty("organization_conformance_packs", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrgConformancePackResponse> OrganizationConformancePacks { get; set; }

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
            sb.Append("class ListOrganizationConformancePacksResponse {\n");
            sb.Append("  organizationConformancePacks: ").Append(OrganizationConformancePacks).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOrganizationConformancePacksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOrganizationConformancePacksResponse input)
        {
            if (input == null) return false;
            if (this.OrganizationConformancePacks != input.OrganizationConformancePacks || (this.OrganizationConformancePacks != null && input.OrganizationConformancePacks != null && !this.OrganizationConformancePacks.SequenceEqual(input.OrganizationConformancePacks))) return false;
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
                if (this.OrganizationConformancePacks != null) hashCode = hashCode * 59 + this.OrganizationConformancePacks.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
