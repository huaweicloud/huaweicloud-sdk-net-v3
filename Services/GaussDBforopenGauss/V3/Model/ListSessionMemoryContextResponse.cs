using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSessionMemoryContextResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 总数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**: 会话内存上下文列表。
        /// </summary>
        [JsonProperty("memory_context_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<SessionMemoryContextInfoResult> MemoryContextInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSessionMemoryContextResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  memoryContextInfo: ").Append(MemoryContextInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSessionMemoryContextResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSessionMemoryContextResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.MemoryContextInfo != input.MemoryContextInfo || (this.MemoryContextInfo != null && input.MemoryContextInfo != null && !this.MemoryContextInfo.SequenceEqual(input.MemoryContextInfo))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.MemoryContextInfo != null) hashCode = hashCode * 59 + this.MemoryContextInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
