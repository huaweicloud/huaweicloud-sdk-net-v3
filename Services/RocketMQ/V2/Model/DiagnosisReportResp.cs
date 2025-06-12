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
    /// 
    /// </summary>
    public class DiagnosisReportResp 
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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagnosisReportResp {\n");
            sb.Append("  reportId: ").Append(ReportId).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  consumerNums: ").Append(ConsumerNums).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  creatAt: ").Append(CreatAt).Append("\n");
            sb.Append("  abnormalItemSum: ").Append(AbnormalItemSum).Append("\n");
            sb.Append("  faultedNodeSum: ").Append(FaultedNodeSum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiagnosisReportResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiagnosisReportResp input)
        {
            if (input == null) return false;
            if (this.ReportId != input.ReportId || (this.ReportId != null && !this.ReportId.Equals(input.ReportId))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.ConsumerNums != input.ConsumerNums || (this.ConsumerNums != null && !this.ConsumerNums.Equals(input.ConsumerNums))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreatAt != input.CreatAt || (this.CreatAt != null && !this.CreatAt.Equals(input.CreatAt))) return false;
            if (this.AbnormalItemSum != input.AbnormalItemSum || (this.AbnormalItemSum != null && !this.AbnormalItemSum.Equals(input.AbnormalItemSum))) return false;
            if (this.FaultedNodeSum != input.FaultedNodeSum || (this.FaultedNodeSum != null && !this.FaultedNodeSum.Equals(input.FaultedNodeSum))) return false;

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
                return hashCode;
            }
        }
    }
}
