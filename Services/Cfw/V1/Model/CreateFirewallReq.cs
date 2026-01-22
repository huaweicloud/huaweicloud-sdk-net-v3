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
    /// 按需防火墙实体
    /// </summary>
    public class CreateFirewallReq 
    {

        /// <summary>
        /// **参数解释**： 防火墙名称 约束限制： 不涉及 **取值范围**： 不涉及 默认取值： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 企业项目ID，用户根据组织规划企业项目，对应的ID为企业项目ID，可通过[如何获取企业项目ID](cfw_02_0027.xml)获取 约束限制： 不涉及 **取值范围**： 不涉及 默认取值： 0
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 服务资源标签列表，防火墙资源添加标签后，可根据键、值组合查询资源，同时可根据键、值组合进行话单合并统计 **约束限制**： 不涉及
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateFirewallReqTags> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public CreateFirewallReqFlavor Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("charge_info", NullValueHandling = NullValueHandling.Ignore)]
        public CreateFirewallReqChargeInfo ChargeInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFirewallReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  chargeInfo: ").Append(ChargeInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFirewallReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFirewallReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.ChargeInfo != input.ChargeInfo || (this.ChargeInfo != null && !this.ChargeInfo.Equals(input.ChargeInfo))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.ChargeInfo != null) hashCode = hashCode * 59 + this.ChargeInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
