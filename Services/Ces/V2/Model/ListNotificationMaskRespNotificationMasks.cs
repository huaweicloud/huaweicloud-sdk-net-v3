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
    /// 
    /// </summary>
    public class ListNotificationMaskRespNotificationMasks 
    {

        /// <summary>
        /// 屏蔽规则ID
        /// </summary>
        [JsonProperty("notification_mask_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationMaskId { get; set; }

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
        /// 关联编号
        /// </summary>
        [JsonProperty("relation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationId { get; set; }

        /// <summary>
        /// 关联资源类型，relation_type为RESOURCE时存在该字段,只需要查询出资源的namespace+维度名即可
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceCategory> Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mask_status", NullValueHandling = NullValueHandling.Ignore)]
        public MaskStatus MaskStatus { get; set; }
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
        /// 告警策略列表。
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoliciesInListResp> Policies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNotificationMaskRespNotificationMasks {\n");
            sb.Append("  notificationMaskId: ").Append(NotificationMaskId).Append("\n");
            sb.Append("  maskName: ").Append(MaskName).Append("\n");
            sb.Append("  relationType: ").Append(RelationType).Append("\n");
            sb.Append("  relationId: ").Append(RelationId).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  maskStatus: ").Append(MaskStatus).Append("\n");
            sb.Append("  maskType: ").Append(MaskType).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNotificationMaskRespNotificationMasks);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNotificationMaskRespNotificationMasks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NotificationMaskId == input.NotificationMaskId ||
                    (this.NotificationMaskId != null &&
                    this.NotificationMaskId.Equals(input.NotificationMaskId))
                ) && 
                (
                    this.MaskName == input.MaskName ||
                    (this.MaskName != null &&
                    this.MaskName.Equals(input.MaskName))
                ) && 
                (
                    this.RelationType == input.RelationType ||
                    (this.RelationType != null &&
                    this.RelationType.Equals(input.RelationType))
                ) && 
                (
                    this.RelationId == input.RelationId ||
                    (this.RelationId != null &&
                    this.RelationId.Equals(input.RelationId))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
                ) && 
                (
                    this.MaskStatus == input.MaskStatus ||
                    (this.MaskStatus != null &&
                    this.MaskStatus.Equals(input.MaskStatus))
                ) && 
                (
                    this.MaskType == input.MaskType ||
                    (this.MaskType != null &&
                    this.MaskType.Equals(input.MaskType))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.NotificationMaskId != null)
                    hashCode = hashCode * 59 + this.NotificationMaskId.GetHashCode();
                if (this.MaskName != null)
                    hashCode = hashCode * 59 + this.MaskName.GetHashCode();
                if (this.RelationType != null)
                    hashCode = hashCode * 59 + this.RelationType.GetHashCode();
                if (this.RelationId != null)
                    hashCode = hashCode * 59 + this.RelationId.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.MaskStatus != null)
                    hashCode = hashCode * 59 + this.MaskStatus.GetHashCode();
                if (this.MaskType != null)
                    hashCode = hashCode * 59 + this.MaskType.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Policies != null)
                    hashCode = hashCode * 59 + this.Policies.GetHashCode();
                return hashCode;
            }
        }
    }
}
