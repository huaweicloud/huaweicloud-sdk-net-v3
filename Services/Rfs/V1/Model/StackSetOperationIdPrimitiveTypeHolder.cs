using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rfs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StackSetOperationIdPrimitiveTypeHolder 
    {

        /// <summary>
        /// 资源栈集操作（stack_set_operation）的唯一Id。  此ID由资源编排服务在生成资源栈集操作的时候生成，为UUID。
        /// </summary>
        [JsonProperty("stack_set_operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetOperationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackSetOperationIdPrimitiveTypeHolder {\n");
            sb.Append("  stackSetOperationId: ").Append(StackSetOperationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StackSetOperationIdPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StackSetOperationIdPrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.StackSetOperationId != input.StackSetOperationId || (this.StackSetOperationId != null && !this.StackSetOperationId.Equals(input.StackSetOperationId))) return false;

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
                if (this.StackSetOperationId != null) hashCode = hashCode * 59 + this.StackSetOperationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
