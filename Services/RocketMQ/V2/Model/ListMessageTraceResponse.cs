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
    public class ListMessageTraceResponse : SdkResponse
    {

        /// <summary>
        /// 消息轨迹列表。
        /// </summary>
        [JsonProperty("trace", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListMessageTraceRespTrace> Trace { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMessageTraceResponse {\n");
            sb.Append("  trace: ").Append(Trace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMessageTraceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMessageTraceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Trace == input.Trace ||
                    this.Trace != null &&
                    input.Trace != null &&
                    this.Trace.SequenceEqual(input.Trace)
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
                if (this.Trace != null)
                    hashCode = hashCode * 59 + this.Trace.GetHashCode();
                return hashCode;
            }
        }
    }
}
