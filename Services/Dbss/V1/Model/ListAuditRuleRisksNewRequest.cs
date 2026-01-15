using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAuditRuleRisksNewRequest 
    {

        /// <summary>
        /// **参数解释**： 实例ID。可通过查询实例列表接口ID字段获取 **约束限制**： 不涉及 **取值范围**： 以查询实例列表接口值为准，字符长度32-64。 **默认取值**： 不涉及 
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 风险名称
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 风险级别 **约束限制**： 以取值范围为准 **取值范围**： - LOW：低风险 - MEDIUM：中风险 - HIGH：高风险 - NO_RISK：无风险 **默认取值**： 不涉及 
        /// </summary>
        [SDKProperty("risk_levels", IsQuery = true)]
        [JsonProperty("risk_levels", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskLevels { get; set; }

        /// <summary>
        /// **参数解释**： 实例前端是否支持按数据库类型展示风险规则 **约束限制**： 以取值范围为准 **取值范围**： - true: 支持 - false: 不支持 **默认取值**： false: 不支持 
        /// </summary>
        [SDKProperty("support_db_classify_rule", IsQuery = true)]
        [JsonProperty("support_db_classify_rule", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportDbClassifyRule { get; set; }

        /// <summary>
        /// **参数解释**： 分页偏移量，从第一条数据偏移offset条数据后开始查询 **约束限制**： 仅支持大于等于0的整数 **取值范围**： 大于等于0 **默认取值**： 默认值为0 
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// **参数解释**： 每页查询记录数。 **约束限制**： 仅支持大于0的整数 **取值范围**： 大于0小于等于1000 **默认取值**： 默认值为100 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAuditRuleRisksNewRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  riskLevels: ").Append(RiskLevels).Append("\n");
            sb.Append("  supportDbClassifyRule: ").Append(SupportDbClassifyRule).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAuditRuleRisksNewRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAuditRuleRisksNewRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.RiskLevels != input.RiskLevels || (this.RiskLevels != null && !this.RiskLevels.Equals(input.RiskLevels))) return false;
            if (this.SupportDbClassifyRule != input.SupportDbClassifyRule || (this.SupportDbClassifyRule != null && !this.SupportDbClassifyRule.Equals(input.SupportDbClassifyRule))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RiskLevels != null) hashCode = hashCode * 59 + this.RiskLevels.GetHashCode();
                if (this.SupportDbClassifyRule != null) hashCode = hashCode * 59 + this.SupportDbClassifyRule.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
