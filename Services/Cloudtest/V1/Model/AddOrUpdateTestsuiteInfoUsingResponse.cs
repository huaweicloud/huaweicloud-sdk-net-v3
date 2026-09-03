using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AddOrUpdateTestsuiteInfoUsingResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public Error Error { get; set; }

        /// <summary>
        /// 对应traceId
        /// </summary>
        [JsonProperty("et_trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EtTraceId { get; set; }

        /// <summary>
        /// 响应结果
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Object Result { get; set; }

        /// <summary>
        /// 响应状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddOrUpdateTestsuiteInfoUsingResponse {\n");
            sb.Append("  error: ").Append(Error).Append("\n");
            sb.Append("  etTraceId: ").Append(EtTraceId).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddOrUpdateTestsuiteInfoUsingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddOrUpdateTestsuiteInfoUsingResponse input)
        {
            if (input == null) return false;
            if (this.Error != input.Error || (this.Error != null && !this.Error.Equals(input.Error))) return false;
            if (this.EtTraceId != input.EtTraceId || (this.EtTraceId != null && !this.EtTraceId.Equals(input.EtTraceId))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.Error != null) hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.EtTraceId != null) hashCode = hashCode * 59 + this.EtTraceId.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
