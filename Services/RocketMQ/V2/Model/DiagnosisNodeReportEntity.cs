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
    public class DiagnosisNodeReportEntity 
    {

        /// <summary>
        /// **参数解释**： 节点ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**： 是否故障。 **约束限制**： 不涉及。 **取值范围**： - true：故障 - false：没有故障。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("is_faulted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFaulted { get; set; }

        /// <summary>
        /// **参数解释**： 异常项总数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("abnormal_item_sum", NullValueHandling = NullValueHandling.Ignore)]
        public int? AbnormalItemSum { get; set; }

        /// <summary>
        /// **参数解释**： 消息堆积数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("message_accumulation", NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageAccumulation { get; set; }

        /// <summary>
        /// **参数解释**： 是否为死锁。 **约束限制**： 不涉及。 **取值范围**： - true：是死锁。 - false：不是死锁。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("dead_lock", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeadLock { get; set; }

        /// <summary>
        /// **参数解释**： 死锁线程。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("deadlock_thread", NullValueHandling = NullValueHandling.Ignore)]
        public string DeadlockThread { get; set; }

        /// <summary>
        /// **参数解释**： 线程ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// **参数解释**： 是否为pop消费模式。 **约束限制**： 不涉及。 **取值范围**： - true：是pop消费模式。 - false：不是pop消费模式。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("is_pop", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPop { get; set; }

        /// <summary>
        /// **参数解释**： 消费类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("consume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumeType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagnosisNodeReportEntity {\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  isFaulted: ").Append(IsFaulted).Append("\n");
            sb.Append("  abnormalItemSum: ").Append(AbnormalItemSum).Append("\n");
            sb.Append("  messageAccumulation: ").Append(MessageAccumulation).Append("\n");
            sb.Append("  deadLock: ").Append(DeadLock).Append("\n");
            sb.Append("  deadlockThread: ").Append(DeadlockThread).Append("\n");
            sb.Append("  stackId: ").Append(StackId).Append("\n");
            sb.Append("  isPop: ").Append(IsPop).Append("\n");
            sb.Append("  consumeType: ").Append(ConsumeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiagnosisNodeReportEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiagnosisNodeReportEntity input)
        {
            if (input == null) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.IsFaulted != input.IsFaulted || (this.IsFaulted != null && !this.IsFaulted.Equals(input.IsFaulted))) return false;
            if (this.AbnormalItemSum != input.AbnormalItemSum || (this.AbnormalItemSum != null && !this.AbnormalItemSum.Equals(input.AbnormalItemSum))) return false;
            if (this.MessageAccumulation != input.MessageAccumulation || (this.MessageAccumulation != null && !this.MessageAccumulation.Equals(input.MessageAccumulation))) return false;
            if (this.DeadLock != input.DeadLock || (this.DeadLock != null && !this.DeadLock.Equals(input.DeadLock))) return false;
            if (this.DeadlockThread != input.DeadlockThread || (this.DeadlockThread != null && !this.DeadlockThread.Equals(input.DeadlockThread))) return false;
            if (this.StackId != input.StackId || (this.StackId != null && !this.StackId.Equals(input.StackId))) return false;
            if (this.IsPop != input.IsPop || (this.IsPop != null && !this.IsPop.Equals(input.IsPop))) return false;
            if (this.ConsumeType != input.ConsumeType || (this.ConsumeType != null && !this.ConsumeType.Equals(input.ConsumeType))) return false;

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
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.IsFaulted != null) hashCode = hashCode * 59 + this.IsFaulted.GetHashCode();
                if (this.AbnormalItemSum != null) hashCode = hashCode * 59 + this.AbnormalItemSum.GetHashCode();
                if (this.MessageAccumulation != null) hashCode = hashCode * 59 + this.MessageAccumulation.GetHashCode();
                if (this.DeadLock != null) hashCode = hashCode * 59 + this.DeadLock.GetHashCode();
                if (this.DeadlockThread != null) hashCode = hashCode * 59 + this.DeadlockThread.GetHashCode();
                if (this.StackId != null) hashCode = hashCode * 59 + this.StackId.GetHashCode();
                if (this.IsPop != null) hashCode = hashCode * 59 + this.IsPop.GetHashCode();
                if (this.ConsumeType != null) hashCode = hashCode * 59 + this.ConsumeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
