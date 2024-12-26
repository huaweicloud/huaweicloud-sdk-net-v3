using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowIpsUpdateTimeResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpsRuleUpdateTimeVO> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fail_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIpsUpdateTimeResponse {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorDescription: ").Append(ErrorDescription).Append("\n");
            sb.Append("  failReason: ").Append(FailReason).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  traceId: ").Append(TraceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIpsUpdateTimeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIpsUpdateTimeResponse input)
        {
            if (input == null) return false;
            if (this.Data != input.Data || (this.Data != null && input.Data != null && !this.Data.SequenceEqual(input.Data))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorDescription != input.ErrorDescription || (this.ErrorDescription != null && !this.ErrorDescription.Equals(input.ErrorDescription))) return false;
            if (this.FailReason != input.FailReason || (this.FailReason != null && !this.FailReason.Equals(input.FailReason))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.TraceId != input.TraceId || (this.TraceId != null && !this.TraceId.Equals(input.TraceId))) return false;

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
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorDescription != null) hashCode = hashCode * 59 + this.ErrorDescription.GetHashCode();
                if (this.FailReason != null) hashCode = hashCode * 59 + this.FailReason.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.TraceId != null) hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
