using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// **参数解释**： 修改通知屏蔽时间请求体。 **约束限制**： 不涉及。 
    /// </summary>
    public class BatchUpdateNotificationMaskTimeRequestBody 
    {

        /// <summary>
        /// **参数解释**： 告警屏蔽ID列表 **约束限制**： 包含的告警屏蔽ID数量为[1,100]个。 
        /// </summary>
        [JsonProperty("notification_mask_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NotificationMaskIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mask_type", NullValueHandling = NullValueHandling.Ignore)]
        public MaskType MaskType { get; set; }
        /// <summary>
        /// **参数解释**： 屏蔽起始日期。           **约束限制**： 不涉及。 **取值范围**： 字符长度为10，格式为：yyyy-MM-dd           **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// **参数解释**： 屏蔽起始时间。          **约束限制**： 不涉及。 **取值范围**： 字符长度为8，格式为：HH:mm:ss         **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 屏蔽截止日期。           **约束限制**： 不涉及。 **取值范围**： 字符长度为10，格式为：yyyy-MM-dd           **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// **参数解释**： 屏蔽截止时间。          **约束限制**： 不涉及。 **取值范围**： 字符长度为8，格式为：HH:mm:ss         **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 时区，形如：\&quot;GMT-08:00\&quot;、\&quot;GMT+08:00\&quot;、\&quot;GMT+0:00\&quot;。    **约束限制**： 不涉及。 **取值范围**： 长度为[1,16]个字符。           **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("effective_timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTimezone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateNotificationMaskTimeRequestBody {\n");
            sb.Append("  notificationMaskIds: ").Append(NotificationMaskIds).Append("\n");
            sb.Append("  maskType: ").Append(MaskType).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  effectiveTimezone: ").Append(EffectiveTimezone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateNotificationMaskTimeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateNotificationMaskTimeRequestBody input)
        {
            if (input == null) return false;
            if (this.NotificationMaskIds != input.NotificationMaskIds || (this.NotificationMaskIds != null && input.NotificationMaskIds != null && !this.NotificationMaskIds.SequenceEqual(input.NotificationMaskIds))) return false;
            if (this.MaskType != input.MaskType) return false;
            if (this.StartDate != input.StartDate || (this.StartDate != null && !this.StartDate.Equals(input.StartDate))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndDate != input.EndDate || (this.EndDate != null && !this.EndDate.Equals(input.EndDate))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.EffectiveTimezone != input.EffectiveTimezone || (this.EffectiveTimezone != null && !this.EffectiveTimezone.Equals(input.EffectiveTimezone))) return false;

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
                if (this.NotificationMaskIds != null) hashCode = hashCode * 59 + this.NotificationMaskIds.GetHashCode();
                hashCode = hashCode * 59 + this.MaskType.GetHashCode();
                if (this.StartDate != null) hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndDate != null) hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.EffectiveTimezone != null) hashCode = hashCode * 59 + this.EffectiveTimezone.GetHashCode();
                return hashCode;
            }
        }
    }
}
