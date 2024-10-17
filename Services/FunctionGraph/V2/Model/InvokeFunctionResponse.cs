using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class InvokeFunctionResponse : SdkResponse
    {

        /// <summary>
        /// 请求ID。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 函数执行结果
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 函数执行返回日志
        /// </summary>
        [JsonProperty("log", NullValueHandling = NullValueHandling.Ignore)]
        public string Log { get; set; }

        /// <summary>
        /// 函数执行返回状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Cff-Request-Id", IsHeader = true)]
        [JsonProperty("X-Cff-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XCffRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvokeFunctionResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  log: ").Append(Log).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  xCffRequestId: ").Append(XCffRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InvokeFunctionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InvokeFunctionResponse input)
        {
            if (input == null) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.Log != input.Log || (this.Log != null && !this.Log.Equals(input.Log))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.XCffRequestId != input.XCffRequestId || (this.XCffRequestId != null && !this.XCffRequestId.Equals(input.XCffRequestId))) return false;

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
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Log != null) hashCode = hashCode * 59 + this.Log.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.XCffRequestId != null) hashCode = hashCode * 59 + this.XCffRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
