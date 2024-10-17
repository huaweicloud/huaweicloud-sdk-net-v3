using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListOperationsResponse : SdkResponse
    {

        /// <summary>
        /// 全量云服务的操作事件列表。
        /// </summary>
        [JsonProperty("operations", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListOperation> Operations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOperationsResponse {\n");
            sb.Append("  operations: ").Append(Operations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOperationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOperationsResponse input)
        {
            if (input == null) return false;
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
                if (this.Operations != null) hashCode = hashCode * 59 + this.Operations.GetHashCode();
                return hashCode;
            }
        }
    }
}
