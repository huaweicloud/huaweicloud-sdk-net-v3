using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 自动扩缩容事件返回体
    /// </summary>
    public class HpaEventResponse 
    {

        /// <summary>
        /// **参数解释：** 自动扩缩容策略事件ID **取值范围：** 事件ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容策略ID **取值范围：** 策略ID
        /// </summary>
        [JsonProperty("hpa_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HpaId { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容事件状态。 **取值范围：** - SUCCESS: 成功 - FAILED: 失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容规则执行信息。 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// **参数解释：** 扩缩容前实例数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("current_replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentReplicas { get; set; }

        /// <summary>
        /// **参数解释：** 预设目标实例数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("target_replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetReplicas { get; set; }

        /// <summary>
        /// **参数解释：** 扩缩容后实例数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("final_replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? FinalReplicas { get; set; }

        /// <summary>
        /// **参数解释：** 执行记录时间。 **取值范围：** 2025-05-20 10:05:55
        /// </summary>
        [JsonProperty("record_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HpaEventResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  hpaId: ").Append(HpaId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  currentReplicas: ").Append(CurrentReplicas).Append("\n");
            sb.Append("  targetReplicas: ").Append(TargetReplicas).Append("\n");
            sb.Append("  finalReplicas: ").Append(FinalReplicas).Append("\n");
            sb.Append("  recordTime: ").Append(RecordTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HpaEventResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HpaEventResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.HpaId != input.HpaId || (this.HpaId != null && !this.HpaId.Equals(input.HpaId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.CurrentReplicas != input.CurrentReplicas || (this.CurrentReplicas != null && !this.CurrentReplicas.Equals(input.CurrentReplicas))) return false;
            if (this.TargetReplicas != input.TargetReplicas || (this.TargetReplicas != null && !this.TargetReplicas.Equals(input.TargetReplicas))) return false;
            if (this.FinalReplicas != input.FinalReplicas || (this.FinalReplicas != null && !this.FinalReplicas.Equals(input.FinalReplicas))) return false;
            if (this.RecordTime != input.RecordTime || (this.RecordTime != null && !this.RecordTime.Equals(input.RecordTime))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.HpaId != null) hashCode = hashCode * 59 + this.HpaId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.CurrentReplicas != null) hashCode = hashCode * 59 + this.CurrentReplicas.GetHashCode();
                if (this.TargetReplicas != null) hashCode = hashCode * 59 + this.TargetReplicas.GetHashCode();
                if (this.FinalReplicas != null) hashCode = hashCode * 59 + this.FinalReplicas.GetHashCode();
                if (this.RecordTime != null) hashCode = hashCode * 59 + this.RecordTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
