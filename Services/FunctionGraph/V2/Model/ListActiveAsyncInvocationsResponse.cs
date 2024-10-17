using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListActiveAsyncInvocationsResponse : SdkResponse
    {

        /// <summary>
        /// 异步调用记录列表。
        /// </summary>
        [JsonProperty("invocations", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListFunctionAsyncInvocationsResult> Invocations { get; set; }

        /// <summary>
        /// 查询数据总条数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 查询下一页的起始位置
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public int? NextMarker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListActiveAsyncInvocationsResponse {\n");
            sb.Append("  invocations: ").Append(Invocations).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  nextMarker: ").Append(NextMarker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListActiveAsyncInvocationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListActiveAsyncInvocationsResponse input)
        {
            if (input == null) return false;
            if (this.Invocations != input.Invocations || (this.Invocations != null && input.Invocations != null && !this.Invocations.SequenceEqual(input.Invocations))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.NextMarker != input.NextMarker || (this.NextMarker != null && !this.NextMarker.Equals(input.NextMarker))) return false;

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
                if (this.Invocations != null) hashCode = hashCode * 59 + this.Invocations.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.NextMarker != null) hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                return hashCode;
            }
        }
    }
}
