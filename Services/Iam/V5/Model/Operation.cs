using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 操作。
    /// </summary>
    public class Operation 
    {

        /// <summary>
        /// OpenAPI的操作标识符。
        /// </summary>
        [JsonProperty("operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationId { get; set; }

        /// <summary>
        /// 三段式的授权项名称，例如\&quot;iam:policies:createV5\&quot;。
        /// </summary>
        [JsonProperty("operation_action", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationAction { get; set; }

        /// <summary>
        /// 该操作可能需要的其他授权项授权。
        /// </summary>
        [JsonProperty("dependent_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DependentActions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Operation {\n");
            sb.Append("  operationId: ").Append(OperationId).Append("\n");
            sb.Append("  operationAction: ").Append(OperationAction).Append("\n");
            sb.Append("  dependentActions: ").Append(DependentActions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Operation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Operation input)
        {
            if (input == null) return false;
            if (this.OperationId != input.OperationId || (this.OperationId != null && !this.OperationId.Equals(input.OperationId))) return false;
            if (this.OperationAction != input.OperationAction || (this.OperationAction != null && !this.OperationAction.Equals(input.OperationAction))) return false;
            if (this.DependentActions != input.DependentActions || (this.DependentActions != null && input.DependentActions != null && !this.DependentActions.SequenceEqual(input.DependentActions))) return false;

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
                if (this.OperationAction != null) hashCode = hashCode * 59 + this.OperationAction.GetHashCode();
                if (this.DependentActions != null) hashCode = hashCode * 59 + this.DependentActions.GetHashCode();
                return hashCode;
            }
        }
    }
}
