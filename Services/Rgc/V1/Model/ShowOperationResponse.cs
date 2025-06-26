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
    public class ShowOperationResponse : SdkResponse
    {

        /// <summary>
        /// 操作ID。
        /// </summary>
        [JsonProperty("operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationId { get; set; }

        /// <summary>
        /// 完成进度百分比。
        /// </summary>
        [JsonProperty("percentage_complete", NullValueHandling = NullValueHandling.Ignore)]
        public int? PercentageComplete { get; set; }

        /// <summary>
        /// 状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 创建账号、纳管注册OU、纳管账号的详细进度信息。
        /// </summary>
        [JsonProperty("percentage_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrganizationalPercentageDetail> PercentageDetails { get; set; }

        /// <summary>
        /// 创建账号、纳管注册OU、纳管账号的错误信息描述。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOperationResponse {\n");
            sb.Append("  operationId: ").Append(OperationId).Append("\n");
            sb.Append("  percentageComplete: ").Append(PercentageComplete).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  percentageDetails: ").Append(PercentageDetails).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOperationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOperationResponse input)
        {
            if (input == null) return false;
            if (this.OperationId != input.OperationId || (this.OperationId != null && !this.OperationId.Equals(input.OperationId))) return false;
            if (this.PercentageComplete != input.PercentageComplete || (this.PercentageComplete != null && !this.PercentageComplete.Equals(input.PercentageComplete))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.PercentageDetails != input.PercentageDetails || (this.PercentageDetails != null && input.PercentageDetails != null && !this.PercentageDetails.SequenceEqual(input.PercentageDetails))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                if (this.PercentageComplete != null) hashCode = hashCode * 59 + this.PercentageComplete.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PercentageDetails != null) hashCode = hashCode * 59 + this.PercentageDetails.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
