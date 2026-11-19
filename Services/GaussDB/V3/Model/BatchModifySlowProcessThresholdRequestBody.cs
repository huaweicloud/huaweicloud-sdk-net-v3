using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// **参数解释**：  批量修改实例慢会话阈值请求体。  **约束限制**：  不涉及。
    /// </summary>
    public class BatchModifySlowProcessThresholdRequestBody 
    {

        /// <summary>
        /// **参数解释**：  批量修改慢会话阈值的实例ID列表。实例ID只能由英文字母、数字组成，后缀为in07，长度为36个字符。  获取方法请参见[查询实例列表](https://support.huaweicloud.com/api-taurusdb/ListGaussMySqlInstancesUnifyStatus.html)。  **约束限制**：  列表不能为空，且列表长度小于等于100。
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// **参数解释**：  实例慢会话阈值。单位为秒。  **约束限制**：   不涉及。  **取值范围**：  1-86400。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("slow_process_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? SlowProcessThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchModifySlowProcessThresholdRequestBody {\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  slowProcessThreshold: ").Append(SlowProcessThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchModifySlowProcessThresholdRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchModifySlowProcessThresholdRequestBody input)
        {
            if (input == null) return false;
            if (this.InstanceIds != input.InstanceIds || (this.InstanceIds != null && input.InstanceIds != null && !this.InstanceIds.SequenceEqual(input.InstanceIds))) return false;
            if (this.SlowProcessThreshold != input.SlowProcessThreshold || (this.SlowProcessThreshold != null && !this.SlowProcessThreshold.Equals(input.SlowProcessThreshold))) return false;

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
                if (this.InstanceIds != null) hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                if (this.SlowProcessThreshold != null) hashCode = hashCode * 59 + this.SlowProcessThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
