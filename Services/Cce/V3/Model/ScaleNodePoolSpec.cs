using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 伸缩节点池请求详细参数
    /// </summary>
    public class ScaleNodePoolSpec 
    {

        /// <summary>
        /// 节点池期望节点数
        /// </summary>
        [JsonProperty("desiredNodeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? DesiredNodeCount { get; set; }

        /// <summary>
        /// 扩缩容的节点池，只能填一个伸缩组，如果要伸缩默认伸缩组填default
        /// </summary>
        [JsonProperty("scaleGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ScaleGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleNodePoolOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScaleNodePoolSpec {\n");
            sb.Append("  desiredNodeCount: ").Append(DesiredNodeCount).Append("\n");
            sb.Append("  scaleGroups: ").Append(ScaleGroups).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScaleNodePoolSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScaleNodePoolSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DesiredNodeCount == input.DesiredNodeCount ||
                    (this.DesiredNodeCount != null &&
                    this.DesiredNodeCount.Equals(input.DesiredNodeCount))
                ) && 
                (
                    this.ScaleGroups == input.ScaleGroups ||
                    this.ScaleGroups != null &&
                    input.ScaleGroups != null &&
                    this.ScaleGroups.SequenceEqual(input.ScaleGroups)
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.DesiredNodeCount != null)
                    hashCode = hashCode * 59 + this.DesiredNodeCount.GetHashCode();
                if (this.ScaleGroups != null)
                    hashCode = hashCode * 59 + this.ScaleGroups.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
