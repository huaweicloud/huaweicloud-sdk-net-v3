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
    public class ShowCeshierarchyRespQueues 
    {

        /// <summary>
        /// topic名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 分区列表。
        /// </summary>
        [JsonProperty("partitions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCeshierarchyRespPartitions> Partitions { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCeshierarchyRespQueues {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  partitions: ").Append(Partitions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCeshierarchyRespQueues);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCeshierarchyRespQueues input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Partitions == input.Partitions ||
                    this.Partitions != null &&
                    input.Partitions != null &&
                    this.Partitions.SequenceEqual(input.Partitions)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Partitions != null)
                    hashCode = hashCode * 59 + this.Partitions.GetHashCode();
                return hashCode;
            }
        }
    }
}
