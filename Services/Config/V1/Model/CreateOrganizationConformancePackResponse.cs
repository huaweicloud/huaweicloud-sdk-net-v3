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
    public class CreateOrganizationConformancePackResponse : SdkResponse
    {

        /// <summary>
        /// 组织合规规则包ID。
        /// </summary>
        [JsonProperty("org_conformance_pack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgConformancePackId { get; set; }

        /// <summary>
        /// 组织合规规则包名称。
        /// </summary>
        [JsonProperty("org_conformance_pack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgConformancePackName { get; set; }

        /// <summary>
        /// 组织合规规则包创建者。
        /// </summary>
        [JsonProperty("owner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerId { get; set; }

        /// <summary>
        /// 组织ID
        /// </summary>
        [JsonProperty("organization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 组织合规规则包资源唯一标识。
        /// </summary>
        [JsonProperty("org_conformance_pack_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgConformancePackUrn { get; set; }

        /// <summary>
        /// 合规规则包参数。
        /// </summary>
        [JsonProperty("vars_structure", NullValueHandling = NullValueHandling.Ignore)]
        public List<VarsStructure> VarsStructure { get; set; }

        /// <summary>
        /// 组织合规规则包创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 组织合规规则包更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrganizationConformancePackResponse {\n");
            sb.Append("  orgConformancePackId: ").Append(OrgConformancePackId).Append("\n");
            sb.Append("  orgConformancePackName: ").Append(OrgConformancePackName).Append("\n");
            sb.Append("  ownerId: ").Append(OwnerId).Append("\n");
            sb.Append("  organizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  orgConformancePackUrn: ").Append(OrgConformancePackUrn).Append("\n");
            sb.Append("  varsStructure: ").Append(VarsStructure).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOrganizationConformancePackResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateOrganizationConformancePackResponse input)
        {
            if (input == null) return false;
            if (this.OrgConformancePackId != input.OrgConformancePackId || (this.OrgConformancePackId != null && !this.OrgConformancePackId.Equals(input.OrgConformancePackId))) return false;
            if (this.OrgConformancePackName != input.OrgConformancePackName || (this.OrgConformancePackName != null && !this.OrgConformancePackName.Equals(input.OrgConformancePackName))) return false;
            if (this.OwnerId != input.OwnerId || (this.OwnerId != null && !this.OwnerId.Equals(input.OwnerId))) return false;
            if (this.OrganizationId != input.OrganizationId || (this.OrganizationId != null && !this.OrganizationId.Equals(input.OrganizationId))) return false;
            if (this.OrgConformancePackUrn != input.OrgConformancePackUrn || (this.OrgConformancePackUrn != null && !this.OrgConformancePackUrn.Equals(input.OrgConformancePackUrn))) return false;
            if (this.VarsStructure != input.VarsStructure || (this.VarsStructure != null && input.VarsStructure != null && !this.VarsStructure.SequenceEqual(input.VarsStructure))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.OrgConformancePackId != null) hashCode = hashCode * 59 + this.OrgConformancePackId.GetHashCode();
                if (this.OrgConformancePackName != null) hashCode = hashCode * 59 + this.OrgConformancePackName.GetHashCode();
                if (this.OwnerId != null) hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.OrganizationId != null) hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.OrgConformancePackUrn != null) hashCode = hashCode * 59 + this.OrgConformancePackUrn.GetHashCode();
                if (this.VarsStructure != null) hashCode = hashCode * 59 + this.VarsStructure.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
