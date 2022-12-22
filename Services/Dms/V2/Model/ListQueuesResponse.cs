using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListQueuesResponse : SdkResponse
    {

        /// <summary>
        /// 该租户的所有队列总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 该租户的所有队列数组。
        /// </summary>
        [JsonProperty("queues", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListQueuesRespQueues> Queues { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListQueuesResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  queues: ").Append(Queues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListQueuesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListQueuesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Queues != null)
                    hashCode = hashCode * 59 + this.Queues.GetHashCode();
                return hashCode;
            }
        }
    }
}
