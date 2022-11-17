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
    /// 实例支持的功能属性描述。
    /// </summary>
    public class ListEngineSupportFeaturesPropertiesEntity 
    {

        /// <summary>
        /// 转储功能的最大任务数。
        /// </summary>
        [JsonProperty("max_task", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxTask { get; set; }

        /// <summary>
        /// 转储功能的最小任务数。
        /// </summary>
        [JsonProperty("min_task", NullValueHandling = NullValueHandling.Ignore)]
        public string MinTask { get; set; }

        /// <summary>
        /// 转储功能的最大节点数。
        /// </summary>
        [JsonProperty("max_node", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxNode { get; set; }

        /// <summary>
        /// 转储功能的最小节点数。
        /// </summary>
        [JsonProperty("min_node", NullValueHandling = NullValueHandling.Ignore)]
        public string MinNode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEngineSupportFeaturesPropertiesEntity {\n");
            sb.Append("  maxTask: ").Append(MaxTask).Append("\n");
            sb.Append("  minTask: ").Append(MinTask).Append("\n");
            sb.Append("  maxNode: ").Append(MaxNode).Append("\n");
            sb.Append("  minNode: ").Append(MinNode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEngineSupportFeaturesPropertiesEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEngineSupportFeaturesPropertiesEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxTask == input.MaxTask ||
                    (this.MaxTask != null &&
                    this.MaxTask.Equals(input.MaxTask))
                ) && 
                (
                    this.MinTask == input.MinTask ||
                    (this.MinTask != null &&
                    this.MinTask.Equals(input.MinTask))
                ) && 
                (
                    this.MaxNode == input.MaxNode ||
                    (this.MaxNode != null &&
                    this.MaxNode.Equals(input.MaxNode))
                ) && 
                (
                    this.MinNode == input.MinNode ||
                    (this.MinNode != null &&
                    this.MinNode.Equals(input.MinNode))
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
                if (this.MaxTask != null)
                    hashCode = hashCode * 59 + this.MaxTask.GetHashCode();
                if (this.MinTask != null)
                    hashCode = hashCode * 59 + this.MinTask.GetHashCode();
                if (this.MaxNode != null)
                    hashCode = hashCode * 59 + this.MaxNode.GetHashCode();
                if (this.MinNode != null)
                    hashCode = hashCode * 59 + this.MinNode.GetHashCode();
                return hashCode;
            }
        }
    }
}
