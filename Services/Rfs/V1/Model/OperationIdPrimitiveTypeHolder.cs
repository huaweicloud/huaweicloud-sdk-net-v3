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
    public class OperationIdPrimitiveTypeHolder 
    {

        /// <summary>
        /// 资源栈集操作Id。  此ID由资源编排服务在生成资源栈集操作的时候生成，为UUID。
        /// </summary>
        [JsonProperty("operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationIdPrimitiveTypeHolder {\n");
            sb.Append("  operationId: ").Append(OperationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperationIdPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperationIdPrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.OperationId != input.OperationId || (this.OperationId != null && !this.OperationId.Equals(input.OperationId))) return false;

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
                if (this.OperationId != null) hashCode = hashCode * 59 + this.OperationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
