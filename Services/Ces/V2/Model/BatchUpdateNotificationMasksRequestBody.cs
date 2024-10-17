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
    /// 通知屏蔽信请求体
    /// </summary>
    public class BatchUpdateNotificationMasksRequestBody 
    {

        /// <summary>
        /// 屏蔽规则名称，只能为字母、数字、汉字、-、_，最大长度为64
        /// </summary>
        [JsonProperty("mask_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("relation_type", NullValueHandling = NullValueHandling.Ignore)]
        public RelationType RelationType { get; set; }
        /// <summary>
        /// 关联编号，relation_type为ALARM_RULE时填屏蔽的告警规则ID；relation_type为RESOURCE_POLICY_NOTIFICATION、RESOURCE_POLICY_ALARM时填屏蔽的告警策略ID；
        /// </summary>
        [JsonProperty("relation_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RelationIds { get; set; }

        /// <summary>
        /// 关联资源，relation_type为RESOURCE、RESOURCE_POLICY_NOTIFICATION、RESOURCE_POLICY_ALARM时填屏蔽的资源信息；
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Resource> Resources { get; set; }

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
            sb.Append("class BatchUpdateNotificationMasksRequestBody {\n");
            sb.Append("  maskName: ").Append(MaskName).Append("\n");
            sb.Append("  relationType: ").Append(RelationType).Append("\n");
            sb.Append("  relationIds: ").Append(RelationIds).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
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
            return this.Equals(input as BatchUpdateNotificationMasksRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateNotificationMasksRequestBody input)
        {
            if (input == null) return false;
            if (this.MaskName != input.MaskName || (this.MaskName != null && !this.MaskName.Equals(input.MaskName))) return false;
            if (this.RelationType != input.RelationType) return false;
            if (this.RelationIds != input.RelationIds || (this.RelationIds != null && input.RelationIds != null && !this.RelationIds.SequenceEqual(input.RelationIds))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
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
                if (this.MaskName != null) hashCode = hashCode * 59 + this.MaskName.GetHashCode();
                hashCode = hashCode * 59 + this.RelationType.GetHashCode();
                if (this.RelationIds != null) hashCode = hashCode * 59 + this.RelationIds.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
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
