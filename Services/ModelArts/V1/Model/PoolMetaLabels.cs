using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 资源池metadata的标签信息。
    /// </summary>
    public class PoolMetaLabels 
    {

        /// <summary>
        /// **参数解释**：资源池的显示名称。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/name", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsName { get; set; }

        /// <summary>
        /// **参数解释**：工作空间ID。[获取方法请参见[查询工作空间列表](ListWorkspace.xml)。](tag:hc) **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：0。
        /// </summary>
        [JsonProperty("os.modelarts/workspace.id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsWorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**：自定义节点前缀，可选值。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/node.prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNodePrefix { get; set; }

        /// <summary>
        /// **参数解释**：资源池计费使用的资源ID。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/resource.id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsResourceId { get; set; }

        /// <summary>
        /// **参数解释**：资源池所属的租户ID。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/tenant.domain.id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsTenantDomainId { get; set; }

        /// <summary>
        /// **参数解释**：资源池所属的租户项目ID。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/tenant.project.id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsTenantProjectId { get; set; }

        /// <summary>
        /// **参数解释**：资源池所属的企业项目ID。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/enterprise.project.id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsEnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**：资源池商业类型，public是公共池，private个人专属池。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts.pool/biz", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsPoolBiz { get; set; }

        /// <summary>
        /// **参数解释**：资源池创建来源，比如admin-console，标记来自admin创建，console标记来自ma console。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/create-from", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsCreateFrom { get; set; }

        /// <summary>
        /// **参数解释**：资源池是否计费。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/nobilling", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNobilling { get; set; }

        /// <summary>
        /// **参数解释**：资源池关联的上一次订单作业记录。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/order.name", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsOrderName { get; set; }

        /// <summary>
        /// **参数解释**：资源池所属区域。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/region", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsRegion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolMetaLabels {\n");
            sb.Append("  osModelartsName: ").Append(OsModelartsName).Append("\n");
            sb.Append("  osModelartsWorkspaceId: ").Append(OsModelartsWorkspaceId).Append("\n");
            sb.Append("  osModelartsNodePrefix: ").Append(OsModelartsNodePrefix).Append("\n");
            sb.Append("  osModelartsResourceId: ").Append(OsModelartsResourceId).Append("\n");
            sb.Append("  osModelartsTenantDomainId: ").Append(OsModelartsTenantDomainId).Append("\n");
            sb.Append("  osModelartsTenantProjectId: ").Append(OsModelartsTenantProjectId).Append("\n");
            sb.Append("  osModelartsEnterpriseProjectId: ").Append(OsModelartsEnterpriseProjectId).Append("\n");
            sb.Append("  osModelartsPoolBiz: ").Append(OsModelartsPoolBiz).Append("\n");
            sb.Append("  osModelartsCreateFrom: ").Append(OsModelartsCreateFrom).Append("\n");
            sb.Append("  osModelartsNobilling: ").Append(OsModelartsNobilling).Append("\n");
            sb.Append("  osModelartsOrderName: ").Append(OsModelartsOrderName).Append("\n");
            sb.Append("  osModelartsRegion: ").Append(OsModelartsRegion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolMetaLabels);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolMetaLabels input)
        {
            if (input == null) return false;
            if (this.OsModelartsName != input.OsModelartsName || (this.OsModelartsName != null && !this.OsModelartsName.Equals(input.OsModelartsName))) return false;
            if (this.OsModelartsWorkspaceId != input.OsModelartsWorkspaceId || (this.OsModelartsWorkspaceId != null && !this.OsModelartsWorkspaceId.Equals(input.OsModelartsWorkspaceId))) return false;
            if (this.OsModelartsNodePrefix != input.OsModelartsNodePrefix || (this.OsModelartsNodePrefix != null && !this.OsModelartsNodePrefix.Equals(input.OsModelartsNodePrefix))) return false;
            if (this.OsModelartsResourceId != input.OsModelartsResourceId || (this.OsModelartsResourceId != null && !this.OsModelartsResourceId.Equals(input.OsModelartsResourceId))) return false;
            if (this.OsModelartsTenantDomainId != input.OsModelartsTenantDomainId || (this.OsModelartsTenantDomainId != null && !this.OsModelartsTenantDomainId.Equals(input.OsModelartsTenantDomainId))) return false;
            if (this.OsModelartsTenantProjectId != input.OsModelartsTenantProjectId || (this.OsModelartsTenantProjectId != null && !this.OsModelartsTenantProjectId.Equals(input.OsModelartsTenantProjectId))) return false;
            if (this.OsModelartsEnterpriseProjectId != input.OsModelartsEnterpriseProjectId || (this.OsModelartsEnterpriseProjectId != null && !this.OsModelartsEnterpriseProjectId.Equals(input.OsModelartsEnterpriseProjectId))) return false;
            if (this.OsModelartsPoolBiz != input.OsModelartsPoolBiz || (this.OsModelartsPoolBiz != null && !this.OsModelartsPoolBiz.Equals(input.OsModelartsPoolBiz))) return false;
            if (this.OsModelartsCreateFrom != input.OsModelartsCreateFrom || (this.OsModelartsCreateFrom != null && !this.OsModelartsCreateFrom.Equals(input.OsModelartsCreateFrom))) return false;
            if (this.OsModelartsNobilling != input.OsModelartsNobilling || (this.OsModelartsNobilling != null && !this.OsModelartsNobilling.Equals(input.OsModelartsNobilling))) return false;
            if (this.OsModelartsOrderName != input.OsModelartsOrderName || (this.OsModelartsOrderName != null && !this.OsModelartsOrderName.Equals(input.OsModelartsOrderName))) return false;
            if (this.OsModelartsRegion != input.OsModelartsRegion || (this.OsModelartsRegion != null && !this.OsModelartsRegion.Equals(input.OsModelartsRegion))) return false;

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
                if (this.OsModelartsName != null) hashCode = hashCode * 59 + this.OsModelartsName.GetHashCode();
                if (this.OsModelartsWorkspaceId != null) hashCode = hashCode * 59 + this.OsModelartsWorkspaceId.GetHashCode();
                if (this.OsModelartsNodePrefix != null) hashCode = hashCode * 59 + this.OsModelartsNodePrefix.GetHashCode();
                if (this.OsModelartsResourceId != null) hashCode = hashCode * 59 + this.OsModelartsResourceId.GetHashCode();
                if (this.OsModelartsTenantDomainId != null) hashCode = hashCode * 59 + this.OsModelartsTenantDomainId.GetHashCode();
                if (this.OsModelartsTenantProjectId != null) hashCode = hashCode * 59 + this.OsModelartsTenantProjectId.GetHashCode();
                if (this.OsModelartsEnterpriseProjectId != null) hashCode = hashCode * 59 + this.OsModelartsEnterpriseProjectId.GetHashCode();
                if (this.OsModelartsPoolBiz != null) hashCode = hashCode * 59 + this.OsModelartsPoolBiz.GetHashCode();
                if (this.OsModelartsCreateFrom != null) hashCode = hashCode * 59 + this.OsModelartsCreateFrom.GetHashCode();
                if (this.OsModelartsNobilling != null) hashCode = hashCode * 59 + this.OsModelartsNobilling.GetHashCode();
                if (this.OsModelartsOrderName != null) hashCode = hashCode * 59 + this.OsModelartsOrderName.GetHashCode();
                if (this.OsModelartsRegion != null) hashCode = hashCode * 59 + this.OsModelartsRegion.GetHashCode();
                return hashCode;
            }
        }
    }
}
