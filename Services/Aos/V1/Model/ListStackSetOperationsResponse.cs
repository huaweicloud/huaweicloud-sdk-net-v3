using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListStackSetOperationsResponse : SdkResponse
    {

        /// <summary>
        /// 资源栈集操作列表
        /// </summary>
        [JsonProperty("stack_set_operations", NullValueHandling = NullValueHandling.Ignore)]
        public List<StackSetOperation> StackSetOperations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStackSetOperationsResponse {\n");
            sb.Append("  stackSetOperations: ").Append(StackSetOperations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStackSetOperationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStackSetOperationsResponse input)
        {
            if (input == null) return false;
            if (this.StackSetOperations != input.StackSetOperations || (this.StackSetOperations != null && input.StackSetOperations != null && !this.StackSetOperations.SequenceEqual(input.StackSetOperations))) return false;

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
                if (this.StackSetOperations != null) hashCode = hashCode * 59 + this.StackSetOperations.GetHashCode();
                return hashCode;
            }
        }
    }
}
