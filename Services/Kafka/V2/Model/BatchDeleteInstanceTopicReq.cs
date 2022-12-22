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
    public class BatchDeleteInstanceTopicReq 
    {

        /// <summary>
        /// 待删除的topic列表。
        /// </summary>
        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Topics { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteInstanceTopicReq {\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteInstanceTopicReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteInstanceTopicReq input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.Topics != null)
                    hashCode = hashCode * 59 + this.Topics.GetHashCode();
                return hashCode;
            }
        }
    }
}
