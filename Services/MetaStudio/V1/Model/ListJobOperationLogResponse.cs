using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListJobOperationLogResponse : SdkResponse
    {

        /// <summary>
        /// 满足查询要求的操作日志总数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 操作日志列表
        /// </summary>
        [JsonProperty("operations", NullValueHandling = NullValueHandling.Ignore)]
        public List<OperationLogItem> Operations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListJobOperationLogResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  operations: ").Append(Operations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListJobOperationLogResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListJobOperationLogResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.Operations != input.Operations || (this.Operations != null && input.Operations != null && !this.Operations.SequenceEqual(input.Operations))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Operations != null) hashCode = hashCode * 59 + this.Operations.GetHashCode();
                return hashCode;
            }
        }
    }
}
