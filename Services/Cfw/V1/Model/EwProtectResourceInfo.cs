using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// **参数解释**： 东西向防护的资源信息，例如VPC、VGW等 **取值范围**： 不涉及
    /// </summary>
    public class EwProtectResourceInfo 
    {

        /// <summary>
        /// **参数解释**： 防护资源类 **取值范围**： - 0：VPC - 1：VGW - 2：VPN - 3：PEERING
        /// </summary>
        [JsonProperty("protected_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtectedResourceType { get; set; }

        /// <summary>
        /// **参数解释**： 防护资源名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protected_resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectedResourceName { get; set; }

        /// <summary>
        /// **参数解释**： 防护资源id **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protected_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectedResourceId { get; set; }

        /// <summary>
        /// **参数解释**： 防护资源nat网关名称，专业版防火墙支持NAT规则，此字段表示防护连接的NAT的名称。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protected_resource_nat_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectedResourceNatName { get; set; }

        /// <summary>
        /// **参数解释**： 防护资源nat网关id，专业版防火墙支持NAT规则，此字段表示防护连接的NAT的id。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protected_resource_nat_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectedResourceNatId { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙支持跨账户防护，此处为防护资源租户id **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protected_resource_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectedResourceProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 防护资源模式，为er **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protected_resource_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectedResourceMode { get; set; }

        /// <summary>
        /// **参数解释**： 防护资源的防护状态 **取值范围**： - 0：已关联 - 1：未关联
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EwProtectResourceInfo {\n");
            sb.Append("  protectedResourceType: ").Append(ProtectedResourceType).Append("\n");
            sb.Append("  protectedResourceName: ").Append(ProtectedResourceName).Append("\n");
            sb.Append("  protectedResourceId: ").Append(ProtectedResourceId).Append("\n");
            sb.Append("  protectedResourceNatName: ").Append(ProtectedResourceNatName).Append("\n");
            sb.Append("  protectedResourceNatId: ").Append(ProtectedResourceNatId).Append("\n");
            sb.Append("  protectedResourceProjectId: ").Append(ProtectedResourceProjectId).Append("\n");
            sb.Append("  protectedResourceMode: ").Append(ProtectedResourceMode).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EwProtectResourceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EwProtectResourceInfo input)
        {
            if (input == null) return false;
            if (this.ProtectedResourceType != input.ProtectedResourceType || (this.ProtectedResourceType != null && !this.ProtectedResourceType.Equals(input.ProtectedResourceType))) return false;
            if (this.ProtectedResourceName != input.ProtectedResourceName || (this.ProtectedResourceName != null && !this.ProtectedResourceName.Equals(input.ProtectedResourceName))) return false;
            if (this.ProtectedResourceId != input.ProtectedResourceId || (this.ProtectedResourceId != null && !this.ProtectedResourceId.Equals(input.ProtectedResourceId))) return false;
            if (this.ProtectedResourceNatName != input.ProtectedResourceNatName || (this.ProtectedResourceNatName != null && !this.ProtectedResourceNatName.Equals(input.ProtectedResourceNatName))) return false;
            if (this.ProtectedResourceNatId != input.ProtectedResourceNatId || (this.ProtectedResourceNatId != null && !this.ProtectedResourceNatId.Equals(input.ProtectedResourceNatId))) return false;
            if (this.ProtectedResourceProjectId != input.ProtectedResourceProjectId || (this.ProtectedResourceProjectId != null && !this.ProtectedResourceProjectId.Equals(input.ProtectedResourceProjectId))) return false;
            if (this.ProtectedResourceMode != input.ProtectedResourceMode || (this.ProtectedResourceMode != null && !this.ProtectedResourceMode.Equals(input.ProtectedResourceMode))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.ProtectedResourceType != null) hashCode = hashCode * 59 + this.ProtectedResourceType.GetHashCode();
                if (this.ProtectedResourceName != null) hashCode = hashCode * 59 + this.ProtectedResourceName.GetHashCode();
                if (this.ProtectedResourceId != null) hashCode = hashCode * 59 + this.ProtectedResourceId.GetHashCode();
                if (this.ProtectedResourceNatName != null) hashCode = hashCode * 59 + this.ProtectedResourceNatName.GetHashCode();
                if (this.ProtectedResourceNatId != null) hashCode = hashCode * 59 + this.ProtectedResourceNatId.GetHashCode();
                if (this.ProtectedResourceProjectId != null) hashCode = hashCode * 59 + this.ProtectedResourceProjectId.GetHashCode();
                if (this.ProtectedResourceMode != null) hashCode = hashCode * 59 + this.ProtectedResourceMode.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
