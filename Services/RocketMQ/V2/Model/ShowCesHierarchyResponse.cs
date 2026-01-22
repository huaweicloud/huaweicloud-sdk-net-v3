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
    public class ShowCesHierarchyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 监控维度。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCeshierarchyRespDimensions> Dimensions { get; set; }

        /// <summary>
        /// **参数解释**： 实例信息。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCesHierarchyRespInstanceIds> InstanceIds { get; set; }

        /// <summary>
        /// **参数解释**： 节点信息。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCesHierarchyRespNodes> Nodes { get; set; }

        /// <summary>
        /// **参数解释**： 队列信息。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCeshierarchyRespTopics> Topics { get; set; }

        /// <summary>
        /// **参数解释**： 死信队列。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("dlq", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCeshierarchyRespDlq> Dlq { get; set; }

        /// <summary>
        /// **参数解释**： 消费组信息。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCeshierarchyRespGroups> Groups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCesHierarchyResponse {\n");
            sb.Append("  dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("  dlq: ").Append(Dlq).Append("\n");
            sb.Append("  groups: ").Append(Groups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCesHierarchyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCesHierarchyResponse input)
        {
            if (input == null) return false;
            if (this.Dimensions != input.Dimensions || (this.Dimensions != null && input.Dimensions != null && !this.Dimensions.SequenceEqual(input.Dimensions))) return false;
            if (this.InstanceIds != input.InstanceIds || (this.InstanceIds != null && input.InstanceIds != null && !this.InstanceIds.SequenceEqual(input.InstanceIds))) return false;
            if (this.Nodes != input.Nodes || (this.Nodes != null && input.Nodes != null && !this.Nodes.SequenceEqual(input.Nodes))) return false;
            if (this.Topics != input.Topics || (this.Topics != null && input.Topics != null && !this.Topics.SequenceEqual(input.Topics))) return false;
            if (this.Dlq != input.Dlq || (this.Dlq != null && input.Dlq != null && !this.Dlq.SequenceEqual(input.Dlq))) return false;
            if (this.Groups != input.Groups || (this.Groups != null && input.Groups != null && !this.Groups.SequenceEqual(input.Groups))) return false;

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
                if (this.Dimensions != null) hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.InstanceIds != null) hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                if (this.Nodes != null) hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.Topics != null) hashCode = hashCode * 59 + this.Topics.GetHashCode();
                if (this.Dlq != null) hashCode = hashCode * 59 + this.Dlq.GetHashCode();
                if (this.Groups != null) hashCode = hashCode * 59 + this.Groups.GetHashCode();
                return hashCode;
            }
        }
    }
}
