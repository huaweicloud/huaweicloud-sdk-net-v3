using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 状态流中流转线信息
    /// </summary>
    public class WorkflowTemplateFlowsVO 
    {

        /// <summary>
        /// 流转线编码
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 流转线名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 流转前校验配置
        /// </summary>
        [JsonProperty("before_rule_validator", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowTemplateConfigsVO> BeforeRuleValidator { get; set; }

        /// <summary>
        /// 流转中界面配置
        /// </summary>
        [JsonProperty("before_rule_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowTemplateConfigsVO> BeforeRuleConfigs { get; set; }

        /// <summary>
        /// 流转线的入口状态
        /// </summary>
        [JsonProperty("from_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FromCode { get; set; }

        /// <summary>
        /// 流转线的出口状态
        /// </summary>
        [JsonProperty("to_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ToCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowTemplateFlowsVO {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  beforeRuleValidator: ").Append(BeforeRuleValidator).Append("\n");
            sb.Append("  beforeRuleConfigs: ").Append(BeforeRuleConfigs).Append("\n");
            sb.Append("  fromCode: ").Append(FromCode).Append("\n");
            sb.Append("  toCode: ").Append(ToCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowTemplateFlowsVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowTemplateFlowsVO input)
        {
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.BeforeRuleValidator != input.BeforeRuleValidator || (this.BeforeRuleValidator != null && input.BeforeRuleValidator != null && !this.BeforeRuleValidator.SequenceEqual(input.BeforeRuleValidator))) return false;
            if (this.BeforeRuleConfigs != input.BeforeRuleConfigs || (this.BeforeRuleConfigs != null && input.BeforeRuleConfigs != null && !this.BeforeRuleConfigs.SequenceEqual(input.BeforeRuleConfigs))) return false;
            if (this.FromCode != input.FromCode || (this.FromCode != null && !this.FromCode.Equals(input.FromCode))) return false;
            if (this.ToCode != input.ToCode || (this.ToCode != null && !this.ToCode.Equals(input.ToCode))) return false;

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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BeforeRuleValidator != null) hashCode = hashCode * 59 + this.BeforeRuleValidator.GetHashCode();
                if (this.BeforeRuleConfigs != null) hashCode = hashCode * 59 + this.BeforeRuleConfigs.GetHashCode();
                if (this.FromCode != null) hashCode = hashCode * 59 + this.FromCode.GetHashCode();
                if (this.ToCode != null) hashCode = hashCode * 59 + this.ToCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
