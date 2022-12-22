using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 自定义错误页面
    /// </summary>
    public class ErrorCodeRedirectRules 
    {

        /// <summary>
        /// 重定向的错误码，当前支持以下状态码 4xx:400, 403, 404, 405, 414, 416, 451 5xx:500, 501, 502, 503, 504
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 重定向状态码，取值为301或302
        /// </summary>
        [JsonProperty("target_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetCode { get; set; }

        /// <summary>
        /// 重定向的目标链接
        /// </summary>
        [JsonProperty("target_link", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetLink { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorCodeRedirectRules {\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  targetCode: ").Append(TargetCode).Append("\n");
            sb.Append("  targetLink: ").Append(TargetLink).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ErrorCodeRedirectRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ErrorCodeRedirectRules input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.TargetCode == input.TargetCode ||
                    (this.TargetCode != null &&
                    this.TargetCode.Equals(input.TargetCode))
                ) && 
                (
                    this.TargetLink == input.TargetLink ||
                    (this.TargetLink != null &&
                    this.TargetLink.Equals(input.TargetLink))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.TargetCode != null)
                    hashCode = hashCode * 59 + this.TargetCode.GetHashCode();
                if (this.TargetLink != null)
                    hashCode = hashCode * 59 + this.TargetLink.GetHashCode();
                return hashCode;
            }
        }
    }
}
