using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 批量举手请求。
    /// </summary>
    public class RestBatchHandsUpReqBody 
    {

        /// <summary>
        /// - 0: 放下手 - 1: 举手
        /// </summary>
        [JsonProperty("handsState", NullValueHandling = NullValueHandling.Ignore)]
        public int? HandsState { get; set; }

        /// <summary>
        /// 与会者标识列表。
        /// </summary>
        [JsonProperty("pids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Pids { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestBatchHandsUpReqBody {\n");
            sb.Append("  handsState: ").Append(HandsState).Append("\n");
            sb.Append("  pids: ").Append(Pids).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestBatchHandsUpReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestBatchHandsUpReqBody input)
        {
            if (input == null) return false;
            if (this.HandsState != input.HandsState || (this.HandsState != null && !this.HandsState.Equals(input.HandsState))) return false;
            if (this.Pids != input.Pids || (this.Pids != null && input.Pids != null && !this.Pids.SequenceEqual(input.Pids))) return false;

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
                if (this.HandsState != null) hashCode = hashCode * 59 + this.HandsState.GetHashCode();
                if (this.Pids != null) hashCode = hashCode * 59 + this.Pids.GetHashCode();
                return hashCode;
            }
        }
    }
}
