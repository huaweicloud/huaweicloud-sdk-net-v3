using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 新增数据流转积压策略请求结构体
    /// </summary>
    public class AddBacklogPolicy 
    {

        /// <summary>
        /// **参数说明**：数据流转积压策略名称。 **取值范围**：长度不超过256，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-等字符的组合。
        /// </summary>
        [JsonProperty("policy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyName { get; set; }

        /// <summary>
        /// **参数说明**：用户自定义的数据流转积压策略描述。 **取值范围**：长度不超过256，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-等字符的组合。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数说明**：数据积压大小。单位为B（字节），取值范围为0~1073741823的整数，默认为1073741823（即1GB）。当backlog_size为0时，表示不积压。若同时配置了backlog_size和backlog_time两个维度，则以最先达到阈值的维度为准。
        /// </summary>
        [JsonProperty("backlog_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? BacklogSize { get; set; }

        /// <summary>
        /// **参数说明**：数据积压时间。单位为s（秒），取值范围为0~86399的整数，默认为86399（即1天）。当backlog_time为0时，表示不积压。若同时配置了backlog_size和backlog_time两个维度，则以最先达到阈值的维度为准。
        /// </summary>
        [JsonProperty("backlog_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? BacklogTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddBacklogPolicy {\n");
            sb.Append("  policyName: ").Append(PolicyName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  backlogSize: ").Append(BacklogSize).Append("\n");
            sb.Append("  backlogTime: ").Append(BacklogTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddBacklogPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddBacklogPolicy input)
        {
            if (input == null) return false;
            if (this.PolicyName != input.PolicyName || (this.PolicyName != null && !this.PolicyName.Equals(input.PolicyName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.BacklogSize != input.BacklogSize || (this.BacklogSize != null && !this.BacklogSize.Equals(input.BacklogSize))) return false;
            if (this.BacklogTime != input.BacklogTime || (this.BacklogTime != null && !this.BacklogTime.Equals(input.BacklogTime))) return false;

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
                if (this.PolicyName != null) hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.BacklogSize != null) hashCode = hashCode * 59 + this.BacklogSize.GetHashCode();
                if (this.BacklogTime != null) hashCode = hashCode * 59 + this.BacklogTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
