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
    /// Request Object
    /// </summary>
    public class ListOrganizationConformancePacksRequest 
    {

        /// <summary>
        /// 组织ID。
        /// </summary>
        [SDKProperty("organization_id", IsPath = true)]
        [JsonProperty("organization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 最大的返回数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页参数，通过上一个请求中返回的marker信息作为输入，获取当前页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 组织合规规则包ID。
        /// </summary>
        [SDKProperty("organization_conformance_pack_id", IsQuery = true)]
        [JsonProperty("organization_conformance_pack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationConformancePackId { get; set; }

        /// <summary>
        /// 合规规则包名称。
        /// </summary>
        [SDKProperty("conformance_pack_name", IsQuery = true)]
        [JsonProperty("conformance_pack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConformancePackName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOrganizationConformancePacksRequest {\n");
            sb.Append("  organizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  organizationConformancePackId: ").Append(OrganizationConformancePackId).Append("\n");
            sb.Append("  conformancePackName: ").Append(ConformancePackName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOrganizationConformancePacksRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOrganizationConformancePacksRequest input)
        {
            if (input == null) return false;
            if (this.OrganizationId != input.OrganizationId || (this.OrganizationId != null && !this.OrganizationId.Equals(input.OrganizationId))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.OrganizationConformancePackId != input.OrganizationConformancePackId || (this.OrganizationConformancePackId != null && !this.OrganizationConformancePackId.Equals(input.OrganizationConformancePackId))) return false;
            if (this.ConformancePackName != input.ConformancePackName || (this.ConformancePackName != null && !this.ConformancePackName.Equals(input.ConformancePackName))) return false;

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
                if (this.OrganizationId != null) hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.OrganizationConformancePackId != null) hashCode = hashCode * 59 + this.OrganizationConformancePackId.GetHashCode();
                if (this.ConformancePackName != null) hashCode = hashCode * 59 + this.ConformancePackName.GetHashCode();
                return hashCode;
            }
        }
    }
}
