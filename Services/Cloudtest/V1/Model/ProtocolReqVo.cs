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
    /// 
    /// </summary>
    public class ProtocolReqVo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("basic", NullValueHandling = NullValueHandling.Ignore)]
        public BasicInfoVo Basic { get; set; }

        /// <summary>
        /// 请求头
        /// </summary>
        [JsonProperty("headers", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// 方法
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }

        /// <summary>
        /// 请求body体
        /// </summary>
        [JsonProperty("request_body", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestBody { get; set; }

        /// <summary>
        /// url
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtocolReqVo {\n");
            sb.Append("  basic: ").Append(Basic).Append("\n");
            sb.Append("  headers: ").Append(Headers).Append("\n");
            sb.Append("  method: ").Append(Method).Append("\n");
            sb.Append("  requestBody: ").Append(RequestBody).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProtocolReqVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProtocolReqVo input)
        {
            if (input == null) return false;
            if (this.Basic != input.Basic || (this.Basic != null && !this.Basic.Equals(input.Basic))) return false;
            if (this.Headers != input.Headers || (this.Headers != null && input.Headers != null && !this.Headers.SequenceEqual(input.Headers))) return false;
            if (this.Method != input.Method || (this.Method != null && !this.Method.Equals(input.Method))) return false;
            if (this.RequestBody != input.RequestBody || (this.RequestBody != null && !this.RequestBody.Equals(input.RequestBody))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;

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
                if (this.Basic != null) hashCode = hashCode * 59 + this.Basic.GetHashCode();
                if (this.Headers != null) hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Method != null) hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.RequestBody != null) hashCode = hashCode * 59 + this.RequestBody.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }
}
