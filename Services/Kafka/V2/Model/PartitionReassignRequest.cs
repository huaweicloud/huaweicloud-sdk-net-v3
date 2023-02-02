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
    /// 
    /// </summary>
    public class PartitionReassignRequest 
    {

        /// <summary>
        /// 重平衡分配方案。
        /// </summary>
        [JsonProperty("reassignments", NullValueHandling = NullValueHandling.Ignore)]
        public List<PartitionReassignEntity> Reassignments { get; set; }

        /// <summary>
        /// 重平衡门限值。
        /// </summary>
        [JsonProperty("throttle", NullValueHandling = NullValueHandling.Ignore)]
        public int? Throttle { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartitionReassignRequest {\n");
            sb.Append("  reassignments: ").Append(Reassignments).Append("\n");
            sb.Append("  throttle: ").Append(Throttle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PartitionReassignRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PartitionReassignRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reassignments == input.Reassignments ||
                    this.Reassignments != null &&
                    input.Reassignments != null &&
                    this.Reassignments.SequenceEqual(input.Reassignments)
                ) && 
                (
                    this.Throttle == input.Throttle ||
                    (this.Throttle != null &&
                    this.Throttle.Equals(input.Throttle))
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
                if (this.Reassignments != null)
                    hashCode = hashCode * 59 + this.Reassignments.GetHashCode();
                if (this.Throttle != null)
                    hashCode = hashCode * 59 + this.Throttle.GetHashCode();
                return hashCode;
            }
        }
    }
}
