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
    /// 工作项流转规则配置
    /// </summary>
    public class WorkItemFlowRuleConfigVO 
    {

        /// <summary>
        /// 规则编码
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 规则开关
        /// </summary>
        [JsonProperty("open", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Open { get; set; }

        /// <summary>
        /// 字段配置值列表
        /// </summary>
        [JsonProperty("config_value", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkItemFlowFieldConfigVO> ConfigValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemFlowRuleConfigVO {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  open: ").Append(Open).Append("\n");
            sb.Append("  configValue: ").Append(ConfigValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemFlowRuleConfigVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemFlowRuleConfigVO input)
        {
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Open != input.Open || (this.Open != null && !this.Open.Equals(input.Open))) return false;
            if (this.ConfigValue != input.ConfigValue || (this.ConfigValue != null && input.ConfigValue != null && !this.ConfigValue.SequenceEqual(input.ConfigValue))) return false;

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
                if (this.Open != null) hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.ConfigValue != null) hashCode = hashCode * 59 + this.ConfigValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
