using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteVisionActiveCodeRequest 
    {

        /// <summary>
        /// 请求requestId，用来标识一路请求，用于问题跟踪定位，建议使用UUID，若不携带，则后台自动生成。
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }

        /// <summary>
        /// 语言参数，默认为中文zh-CN，英文为en-US。
        /// </summary>
        [SDKProperty("Accept-Language", IsHeader = true)]
        [JsonProperty("Accept-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteVisionActiveCodeRequest {\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("  acceptLanguage: ").Append(AcceptLanguage).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteVisionActiveCodeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteVisionActiveCodeRequest input)
        {
            if (input == null) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;
            if (this.AcceptLanguage != input.AcceptLanguage || (this.AcceptLanguage != null && !this.AcceptLanguage.Equals(input.AcceptLanguage))) return false;
            if (this.Body != input.Body || (this.Body != null && input.Body != null && !this.Body.SequenceEqual(input.Body))) return false;

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
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                if (this.AcceptLanguage != null) hashCode = hashCode * 59 + this.AcceptLanguage.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
