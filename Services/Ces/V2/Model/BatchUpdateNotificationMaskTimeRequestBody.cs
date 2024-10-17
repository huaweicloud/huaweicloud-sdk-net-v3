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
    /// 修改通知屏蔽时间请求体
    /// </summary>
    public class BatchUpdateNotificationMaskTimeRequestBody 
    {

        /// <summary>
        /// 关联编号
        /// </summary>
        [JsonProperty("notification_mask_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NotificationMaskIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mask_type", NullValueHandling = NullValueHandling.Ignore)]
        public MaskType MaskType { get; set; }
        /// <summary>
        /// 屏蔽起始日期，yyyy-MM-dd。
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 屏蔽起始时间，HH:mm:ss。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 屏蔽截止日期，yyyy-MM-dd。
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// 屏蔽截止时间，HH:mm:ss。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



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
                return hashCode;
            }
        }
    }
}
