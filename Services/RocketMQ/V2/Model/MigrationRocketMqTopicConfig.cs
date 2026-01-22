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
    /// **参数解释**： RocketMQ元数据迁移，RocketMQ Topic元数据。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
    /// </summary>
    public class MigrationRocketMqTopicConfig 
    {

        /// <summary>
        /// **参数解释**： Topic名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("topic_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicName { get; set; }

        /// <summary>
        /// **参数解释**： 是否有序消息。 **约束限制**： 不涉及。 **取值范围**： - true：有序消息。 - false：无序消息。 **默认取值**： false。
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Order { get; set; }

        /// <summary>
        /// **参数解释**： Topic权限。 **约束限制**： 不涉及。 **取值范围**： - PUB：拥有发布权限。 - SUB：拥有订阅权限。 - PUB|SUB：拥有发布订阅权限。 - DENY：无权限。 **默认取值**： 6。
        /// </summary>
        [JsonProperty("perm", NullValueHandling = NullValueHandling.Ignore)]
        public int? Perm { get; set; }

        /// <summary>
        /// **参数解释**： 读队列个数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 16。
        /// </summary>
        [JsonProperty("read_queue_nums", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReadQueueNums { get; set; }

        /// <summary>
        /// **参数解释**： 写队列个数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 16。
        /// </summary>
        [JsonProperty("write_queue_nums", NullValueHandling = NullValueHandling.Ignore)]
        public int? WriteQueueNums { get; set; }

        /// <summary>
        /// **参数解释**： Topic过滤类型。 **约束限制**： 不涉及。 **取值范围**： - SINGLE_TAG：单标签   - MULTI_TAG：多标签 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("topic_filter_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicFilterType { get; set; }

        /// <summary>
        /// **参数解释**： Topic系统标志位。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 0。
        /// </summary>
        [JsonProperty("topic_sys_flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopicSysFlag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationRocketMqTopicConfig {\n");
            sb.Append("  topicName: ").Append(TopicName).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  perm: ").Append(Perm).Append("\n");
            sb.Append("  readQueueNums: ").Append(ReadQueueNums).Append("\n");
            sb.Append("  writeQueueNums: ").Append(WriteQueueNums).Append("\n");
            sb.Append("  topicFilterType: ").Append(TopicFilterType).Append("\n");
            sb.Append("  topicSysFlag: ").Append(TopicSysFlag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrationRocketMqTopicConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrationRocketMqTopicConfig input)
        {
            if (input == null) return false;
            if (this.TopicName != input.TopicName || (this.TopicName != null && !this.TopicName.Equals(input.TopicName))) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;
            if (this.Perm != input.Perm || (this.Perm != null && !this.Perm.Equals(input.Perm))) return false;
            if (this.ReadQueueNums != input.ReadQueueNums || (this.ReadQueueNums != null && !this.ReadQueueNums.Equals(input.ReadQueueNums))) return false;
            if (this.WriteQueueNums != input.WriteQueueNums || (this.WriteQueueNums != null && !this.WriteQueueNums.Equals(input.WriteQueueNums))) return false;
            if (this.TopicFilterType != input.TopicFilterType || (this.TopicFilterType != null && !this.TopicFilterType.Equals(input.TopicFilterType))) return false;
            if (this.TopicSysFlag != input.TopicSysFlag || (this.TopicSysFlag != null && !this.TopicSysFlag.Equals(input.TopicSysFlag))) return false;

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
                if (this.TopicName != null) hashCode = hashCode * 59 + this.TopicName.GetHashCode();
                if (this.Order != null) hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Perm != null) hashCode = hashCode * 59 + this.Perm.GetHashCode();
                if (this.ReadQueueNums != null) hashCode = hashCode * 59 + this.ReadQueueNums.GetHashCode();
                if (this.WriteQueueNums != null) hashCode = hashCode * 59 + this.WriteQueueNums.GetHashCode();
                if (this.TopicFilterType != null) hashCode = hashCode * 59 + this.TopicFilterType.GetHashCode();
                if (this.TopicSysFlag != null) hashCode = hashCode * 59 + this.TopicSysFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
