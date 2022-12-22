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
    public class ShowCeshierarchyRespGroups 
    {

        /// <summary>
        /// 消费组名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// topic信息。
        /// </summary>
        [JsonProperty("queues", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCeshierarchyRespQueues1> Queues { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCeshierarchyRespGroups {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  queues: ").Append(Queues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCeshierarchyRespGroups);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCeshierarchyRespGroups input)
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
                    this.Queues == input.Queues ||
                    this.Queues != null &&
                    input.Queues != null &&
                    this.Queues.SequenceEqual(input.Queues)
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
                if (this.Queues != null)
                    hashCode = hashCode * 59 + this.Queues.GetHashCode();
                return hashCode;
            }
        }
    }
}
