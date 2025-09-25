using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListStrategyRequest 
    {

        /// <summary>
        /// 租户ID
        /// </summary>
        [SDKProperty("domain_id", IsPath = true)]
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 偏移量，表示从此偏移量开始查询，offset大于等于0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示的条目数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 是否包含租户级规则
        /// </summary>
        [SDKProperty("include_tenant_rule_set", IsQuery = true)]
        [JsonProperty("include_tenant_rule_set", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeTenantRuleSet { get; set; }

        /// <summary>
        /// 策略名称，用于模糊查询
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        [SDKProperty("is_valid", IsQuery = true)]
        [JsonProperty("is_valid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// 策略类型
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [SDKProperty("cloud_project_id", IsQuery = true)]
        [JsonProperty("cloud_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStrategyRequest {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  includeTenantRuleSet: ").Append(IncludeTenantRuleSet).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  isValid: ").Append(IsValid).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  cloudProjectId: ").Append(CloudProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStrategyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStrategyRequest input)
        {
            if (input == null) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.IncludeTenantRuleSet != input.IncludeTenantRuleSet || (this.IncludeTenantRuleSet != null && !this.IncludeTenantRuleSet.Equals(input.IncludeTenantRuleSet))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.IsValid != input.IsValid || (this.IsValid != null && !this.IsValid.Equals(input.IsValid))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.CloudProjectId != input.CloudProjectId || (this.CloudProjectId != null && !this.CloudProjectId.Equals(input.CloudProjectId))) return false;

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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.IncludeTenantRuleSet != null) hashCode = hashCode * 59 + this.IncludeTenantRuleSet.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsValid != null) hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CloudProjectId != null) hashCode = hashCode * 59 + this.CloudProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
