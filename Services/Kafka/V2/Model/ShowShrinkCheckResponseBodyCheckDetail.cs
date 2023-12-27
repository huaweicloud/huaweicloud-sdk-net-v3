using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// broker检查结果
    /// </summary>
    public class ShowShrinkCheckResponseBodyCheckDetail 
    {

        /// <summary>
        /// broker序号
        /// </summary>
        [JsonProperty("broker_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokerId { get; set; }

        /// <summary>
        /// 节点是否可删除。
        /// </summary>
        [JsonProperty("can_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// 节点是否为zk部署节点。
        /// </summary>
        [JsonProperty("is_zk_node", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsZkNode { get; set; }

        /// <summary>
        /// broker是否为controller。
        /// </summary>
        [JsonProperty("is_controller", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsController { get; set; }

        /// <summary>
        /// broker上是否存在topic数据。
        /// </summary>
        [JsonProperty("has_topics", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasTopics { get; set; }

        /// <summary>
        /// broker上存在的topic列表。
        /// </summary>
        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Topics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowShrinkCheckResponseBodyCheckDetail {\n");
            sb.Append("  brokerId: ").Append(BrokerId).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  isZkNode: ").Append(IsZkNode).Append("\n");
            sb.Append("  isController: ").Append(IsController).Append("\n");
            sb.Append("  hasTopics: ").Append(HasTopics).Append("\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowShrinkCheckResponseBodyCheckDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowShrinkCheckResponseBodyCheckDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BrokerId == input.BrokerId ||
                    (this.BrokerId != null &&
                    this.BrokerId.Equals(input.BrokerId))
                ) && 
                (
                    this.CanDelete == input.CanDelete ||
                    (this.CanDelete != null &&
                    this.CanDelete.Equals(input.CanDelete))
                ) && 
                (
                    this.IsZkNode == input.IsZkNode ||
                    (this.IsZkNode != null &&
                    this.IsZkNode.Equals(input.IsZkNode))
                ) && 
                (
                    this.IsController == input.IsController ||
                    (this.IsController != null &&
                    this.IsController.Equals(input.IsController))
                ) && 
                (
                    this.HasTopics == input.HasTopics ||
                    (this.HasTopics != null &&
                    this.HasTopics.Equals(input.HasTopics))
                ) && 
                (
                    this.Topics == input.Topics ||
                    this.Topics != null &&
                    input.Topics != null &&
                    this.Topics.SequenceEqual(input.Topics)
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
                if (this.BrokerId != null)
                    hashCode = hashCode * 59 + this.BrokerId.GetHashCode();
                if (this.CanDelete != null)
                    hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.IsZkNode != null)
                    hashCode = hashCode * 59 + this.IsZkNode.GetHashCode();
                if (this.IsController != null)
                    hashCode = hashCode * 59 + this.IsController.GetHashCode();
                if (this.HasTopics != null)
                    hashCode = hashCode * 59 + this.HasTopics.GetHashCode();
                if (this.Topics != null)
                    hashCode = hashCode * 59 + this.Topics.GetHashCode();
                return hashCode;
            }
        }
    }
}
