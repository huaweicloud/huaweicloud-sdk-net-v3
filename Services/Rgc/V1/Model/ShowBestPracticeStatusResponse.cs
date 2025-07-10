using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBestPracticeStatusResponse : SdkResponse
    {

        /// <summary>
        /// 操作Id
        /// </summary>
        [JsonProperty("operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationId { get; set; }

        /// <summary>
        /// 状态：进行中，成功，成败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 检测进度
        /// </summary>
        [JsonProperty("percentage_complete", NullValueHandling = NullValueHandling.Ignore)]
        public int? PercentageComplete { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [JsonProperty("error_messages", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ErrorMessages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBestPracticeStatusResponse {\n");
            sb.Append("  operationId: ").Append(OperationId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  percentageComplete: ").Append(PercentageComplete).Append("\n");
            sb.Append("  errorMessages: ").Append(ErrorMessages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBestPracticeStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBestPracticeStatusResponse input)
        {
            if (input == null) return false;
            if (this.OperationId != input.OperationId || (this.OperationId != null && !this.OperationId.Equals(input.OperationId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.PercentageComplete != input.PercentageComplete || (this.PercentageComplete != null && !this.PercentageComplete.Equals(input.PercentageComplete))) return false;
            if (this.ErrorMessages != input.ErrorMessages || (this.ErrorMessages != null && input.ErrorMessages != null && !this.ErrorMessages.SequenceEqual(input.ErrorMessages))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PercentageComplete != null) hashCode = hashCode * 59 + this.PercentageComplete.GetHashCode();
                if (this.ErrorMessages != null) hashCode = hashCode * 59 + this.ErrorMessages.GetHashCode();
                return hashCode;
            }
        }
    }
}
