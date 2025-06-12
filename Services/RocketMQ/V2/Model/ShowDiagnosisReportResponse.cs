using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDiagnosisReportResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 报告ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("report_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportId { get; set; }

        /// <summary>
        /// **参数解释**： 消费组名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// **参数解释**： 消费者数量。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("consumer_nums", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConsumerNums { get; set; }

        /// <summary>
        /// **参数解释**： 状态。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 生成时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("creat_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatAt { get; set; }

        /// <summary>
        /// **参数解释**： 异常项数量。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("abnormal_item_sum", NullValueHandling = NullValueHandling.Ignore)]
        public int? AbnormalItemSum { get; set; }

        /// <summary>
        /// **参数解释**： 异常节点数量。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("faulted_node_sum", NullValueHandling = NullValueHandling.Ignore)]
        public int? FaultedNodeSum { get; set; }

        /// <summary>
        /// **参数解释**： 是否在线。 **取值范围**： - true: 在线。 - false: 不在线。
        /// </summary>
        [JsonProperty("online", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Online { get; set; }

        /// <summary>
        /// **参数解释**： 消息堆积数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("message_accumulation", NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageAccumulation { get; set; }

        /// <summary>
        /// **参数解释**： 订阅一致性。 **取值范围**： - true: 订阅关系一致。 - false: 订阅关系不一致。
        /// </summary>
        [JsonProperty("subscription_consistency", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SubscriptionConsistency { get; set; }

        /// <summary>
        /// **参数解释**： 订阅者列表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Subscriptions { get; set; }

        /// <summary>
        /// **参数解释**： 诊断节点报告列表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("diagnosis_node_report_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DiagnosisNodeReportList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDiagnosisReportResponse {\n");
            sb.Append("  reportId: ").Append(ReportId).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  consumerNums: ").Append(ConsumerNums).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  creatAt: ").Append(CreatAt).Append("\n");
            sb.Append("  abnormalItemSum: ").Append(AbnormalItemSum).Append("\n");
            sb.Append("  faultedNodeSum: ").Append(FaultedNodeSum).Append("\n");
            sb.Append("  online: ").Append(Online).Append("\n");
            sb.Append("  messageAccumulation: ").Append(MessageAccumulation).Append("\n");
            sb.Append("  subscriptionConsistency: ").Append(SubscriptionConsistency).Append("\n");
            sb.Append("  subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  diagnosisNodeReportList: ").Append(DiagnosisNodeReportList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDiagnosisReportResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDiagnosisReportResponse input)
        {
            if (input == null) return false;
            if (this.ReportId != input.ReportId || (this.ReportId != null && !this.ReportId.Equals(input.ReportId))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.ConsumerNums != input.ConsumerNums || (this.ConsumerNums != null && !this.ConsumerNums.Equals(input.ConsumerNums))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreatAt != input.CreatAt || (this.CreatAt != null && !this.CreatAt.Equals(input.CreatAt))) return false;
            if (this.AbnormalItemSum != input.AbnormalItemSum || (this.AbnormalItemSum != null && !this.AbnormalItemSum.Equals(input.AbnormalItemSum))) return false;
            if (this.FaultedNodeSum != input.FaultedNodeSum || (this.FaultedNodeSum != null && !this.FaultedNodeSum.Equals(input.FaultedNodeSum))) return false;
            if (this.Online != input.Online || (this.Online != null && !this.Online.Equals(input.Online))) return false;
            if (this.MessageAccumulation != input.MessageAccumulation || (this.MessageAccumulation != null && !this.MessageAccumulation.Equals(input.MessageAccumulation))) return false;
            if (this.SubscriptionConsistency != input.SubscriptionConsistency || (this.SubscriptionConsistency != null && !this.SubscriptionConsistency.Equals(input.SubscriptionConsistency))) return false;
            if (this.Subscriptions != input.Subscriptions || (this.Subscriptions != null && input.Subscriptions != null && !this.Subscriptions.SequenceEqual(input.Subscriptions))) return false;
            if (this.DiagnosisNodeReportList != input.DiagnosisNodeReportList || (this.DiagnosisNodeReportList != null && input.DiagnosisNodeReportList != null && !this.DiagnosisNodeReportList.SequenceEqual(input.DiagnosisNodeReportList))) return false;

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
                if (this.ReportId != null) hashCode = hashCode * 59 + this.ReportId.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.ConsumerNums != null) hashCode = hashCode * 59 + this.ConsumerNums.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatAt != null) hashCode = hashCode * 59 + this.CreatAt.GetHashCode();
                if (this.AbnormalItemSum != null) hashCode = hashCode * 59 + this.AbnormalItemSum.GetHashCode();
                if (this.FaultedNodeSum != null) hashCode = hashCode * 59 + this.FaultedNodeSum.GetHashCode();
                if (this.Online != null) hashCode = hashCode * 59 + this.Online.GetHashCode();
                if (this.MessageAccumulation != null) hashCode = hashCode * 59 + this.MessageAccumulation.GetHashCode();
                if (this.SubscriptionConsistency != null) hashCode = hashCode * 59 + this.SubscriptionConsistency.GetHashCode();
                if (this.Subscriptions != null) hashCode = hashCode * 59 + this.Subscriptions.GetHashCode();
                if (this.DiagnosisNodeReportList != null) hashCode = hashCode * 59 + this.DiagnosisNodeReportList.GetHashCode();
                return hashCode;
            }
        }
    }
}
