using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class CreateSecurityGroupRuleRequestBody 
    {

        /// <summary>
        /// 功能说明：是否只预检此次请求 取值范围： -true：发送检查请求，不会创建安全组规则。检查项包括是否填写了必需参数、请求格式、业务限制。如果检查不通过，则返回对应错误。如果检查通过，则返回响应码202。 -false（默认值）：发送正常请求，并直接创建安全组规则。
        /// </summary>
        [JsonProperty("dry_run", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("security_group_rule", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSecurityGroupRuleOption SecurityGroupRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSecurityGroupRuleRequestBody {\n");
            sb.Append("  dryRun: ").Append(DryRun).Append("\n");
            sb.Append("  securityGroupRule: ").Append(SecurityGroupRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSecurityGroupRuleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSecurityGroupRuleRequestBody input)
        {
            if (input == null) return false;
            if (this.DryRun != input.DryRun || (this.DryRun != null && !this.DryRun.Equals(input.DryRun))) return false;
            if (this.SecurityGroupRule != input.SecurityGroupRule || (this.SecurityGroupRule != null && !this.SecurityGroupRule.Equals(input.SecurityGroupRule))) return false;

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
                if (this.DryRun != null) hashCode = hashCode * 59 + this.DryRun.GetHashCode();
                if (this.SecurityGroupRule != null) hashCode = hashCode * 59 + this.SecurityGroupRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
