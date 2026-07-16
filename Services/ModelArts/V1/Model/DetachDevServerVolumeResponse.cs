using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DetachDevServerVolumeResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：操作ID。 **取值范围**：长度为[8,36]个字符。
        /// </summary>
        [JsonProperty("operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationId { get; set; }

        /// <summary>
        /// **参数解释**：操作状态。 **取值范围**：长度为[8,36]个字符。
        /// </summary>
        [JsonProperty("operation_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationStatus { get; set; }

        /// <summary>
        /// **参数解释**：操作类型。 **取值范围**：长度为[8,36]个字符。
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("operation_error", NullValueHandling = NullValueHandling.Ignore)]
        public ServerOperationError OperationError { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetachDevServerVolumeResponse {\n");
            sb.Append("  operationId: ").Append(OperationId).Append("\n");
            sb.Append("  operationStatus: ").Append(OperationStatus).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  operationError: ").Append(OperationError).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetachDevServerVolumeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetachDevServerVolumeResponse input)
        {
            if (input == null) return false;
            if (this.OperationId != input.OperationId || (this.OperationId != null && !this.OperationId.Equals(input.OperationId))) return false;
            if (this.OperationStatus != input.OperationStatus || (this.OperationStatus != null && !this.OperationStatus.Equals(input.OperationStatus))) return false;
            if (this.OperationType != input.OperationType || (this.OperationType != null && !this.OperationType.Equals(input.OperationType))) return false;
            if (this.OperationError != input.OperationError || (this.OperationError != null && !this.OperationError.Equals(input.OperationError))) return false;

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
                if (this.OperationStatus != null) hashCode = hashCode * 59 + this.OperationStatus.GetHashCode();
                if (this.OperationType != null) hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.OperationError != null) hashCode = hashCode * 59 + this.OperationError.GetHashCode();
                return hashCode;
            }
        }
    }
}
