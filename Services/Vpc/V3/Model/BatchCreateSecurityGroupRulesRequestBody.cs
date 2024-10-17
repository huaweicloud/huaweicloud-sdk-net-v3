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
    public class BatchCreateSecurityGroupRulesRequestBody 
    {

        /// <summary>
        /// 待创建的安全组规则列表
        /// </summary>
        [JsonProperty("security_group_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchCreateSecurityGroupRulesOption> SecurityGroupRules { get; set; }

        /// <summary>
        /// 创建时是否忽略重复的安全组规则 默认为false
        /// </summary>
        [JsonProperty("ignore_duplicate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreDuplicate { get; set; }

        /// <summary>
        /// 功能说明：是否只预检此次请求 取值范围： -true：发送检查请求，不会创建安全组规则。检查项包括是否填写了必需参数、请求格式、业务限制。如果检查不通过，则返回对应错误。如果检查通过，则返回响应码202。 -false（默认值）：发送正常请求，并直接创建安全组规则。
        /// </summary>
        [JsonProperty("dry_run", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DryRun { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateSecurityGroupRulesRequestBody {\n");
            sb.Append("  securityGroupRules: ").Append(SecurityGroupRules).Append("\n");
            sb.Append("  ignoreDuplicate: ").Append(IgnoreDuplicate).Append("\n");
            sb.Append("  dryRun: ").Append(DryRun).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateSecurityGroupRulesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateSecurityGroupRulesRequestBody input)
        {
            if (input == null) return false;
            if (this.SecurityGroupRules != input.SecurityGroupRules || (this.SecurityGroupRules != null && input.SecurityGroupRules != null && !this.SecurityGroupRules.SequenceEqual(input.SecurityGroupRules))) return false;
            if (this.IgnoreDuplicate != input.IgnoreDuplicate || (this.IgnoreDuplicate != null && !this.IgnoreDuplicate.Equals(input.IgnoreDuplicate))) return false;
            if (this.DryRun != input.DryRun || (this.DryRun != null && !this.DryRun.Equals(input.DryRun))) return false;

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
                if (this.SecurityGroupRules != null) hashCode = hashCode * 59 + this.SecurityGroupRules.GetHashCode();
                if (this.IgnoreDuplicate != null) hashCode = hashCode * 59 + this.IgnoreDuplicate.GetHashCode();
                if (this.DryRun != null) hashCode = hashCode * 59 + this.DryRun.GetHashCode();
                return hashCode;
            }
        }
    }
}
