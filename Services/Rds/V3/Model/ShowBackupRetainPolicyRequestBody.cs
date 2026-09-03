using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 查询备份保留策略的请求体
    /// </summary>
    public class ShowBackupRetainPolicyRequestBody 
    {

        /// <summary>
        /// **参数解释**：  实例ID列表，实例ID是实例的唯一标识。  **约束限制**：  不涉及。  **取值范围**：  实例ID只能由英文字母、数字组成，长度为36个字符。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("instanceids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Instanceids { get; set; }

        /// <summary>
        /// **参数解释**  索引位置，偏移量。  **约束限制**  从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询），必须为数字，不能为负数。  **取值范围**  大于等于0的整数。  **默认取值**  0
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释**  查询记录数。  **约束限制**  不能为负数。  **取值范围**  最小值为1，最大值为100。  **默认取值**  10
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**：  实例状态  **约束限制**：  不涉及。  **取值范围**：  normal、deleted  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("instance_status", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// **参数解释**  查询开始时间。时间指实例的删除时间。  **约束限制**  “begin_time”有值时，“end_time”必选。 “begin_time”有值时，查询实例状态为已删除的实例。  **取值范围**  格式为“yyyy-mm-ddThh:mm:ss±HH:mm”。  其中，T指某个时间的开始；±HH:mm指时区偏移量，例如北京时间偏移显示为+08:00。  **默认取值**  不涉及。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// **参数解释**  查询结束时间。时间指实例的删除时间  **约束限制**  “end_time”有值时，“begin_time”必选。 “end_time”有值时，查询实例状态为已删除的实例。  **取值范围**  格式为“yyyy-mm-ddThh:mm:ss±HH:mm”，且大于查询开始时间。  其中，T指某个时间的开始；±HH:mm指时区偏移量，例如北京时间偏移显示为+08:00。  **默认取值**  不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBackupRetainPolicyRequestBody {\n");
            sb.Append("  instanceids: ").Append(Instanceids).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  instanceStatus: ").Append(InstanceStatus).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBackupRetainPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBackupRetainPolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.Instanceids != input.Instanceids || (this.Instanceids != null && input.Instanceids != null && !this.Instanceids.SequenceEqual(input.Instanceids))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.InstanceStatus != input.InstanceStatus || (this.InstanceStatus != null && !this.InstanceStatus.Equals(input.InstanceStatus))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.Instanceids != null) hashCode = hashCode * 59 + this.Instanceids.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.InstanceStatus != null) hashCode = hashCode * 59 + this.InstanceStatus.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
