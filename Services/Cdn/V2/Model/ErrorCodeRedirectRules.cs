using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 自定义错误页面。
    /// </summary>
    public class ErrorCodeRedirectRules 
    {

        /// <summary>
        /// **参数解释：** 重定向的错误码 **约束限制：** 不涉及 **取值范围：** - 4xx: 400, 403, 404, 405, 414, 416, 451 - 5xx: 500, 501, 502, 503, 504  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// **参数解释：** 执行规则 **约束限制：** 不涉及 **取值范围：** - break：如果错误码匹配了当前配置，请求将被重定向到目标Path。执行完当前规则后，当存在其他配置规则时，将不再匹配剩余规则。 - redirect：如果错误码匹配了当前配置，请求将被重定向到目标Path。执行完当前规则后，当存在其他配置规则时，将继续匹配剩余规则。  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("execution_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// **参数解释：** 重定向状态码 **约束限制：** 当执行规则选择redirect时，需要配置该参数 **取值范围：** - 301 - 302  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("target_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetCode { get; set; }

        /// <summary>
        /// **参数解释：** 重定向的目标链接 **约束限制：** “执行规则”选择“Break”时：全路径匹配，支持输入一个目标地址，以“/”作为首字符，字符长度不超过512，如：/errorcode.html。 “执行规则”选择“Redirect”时：输入的URL须以http://或https:// 开头 ，字符长度不超过512，包含完整的域名和路径信息，如：http://example.com/errorcode.html。 **取值范围：** 不涉及 **默认取值：** 不涉及
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
            sb.Append("  executionMode: ").Append(ExecutionMode).Append("\n");
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
            if (input == null) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ExecutionMode != input.ExecutionMode || (this.ExecutionMode != null && !this.ExecutionMode.Equals(input.ExecutionMode))) return false;
            if (this.TargetCode != input.TargetCode || (this.TargetCode != null && !this.TargetCode.Equals(input.TargetCode))) return false;
            if (this.TargetLink != input.TargetLink || (this.TargetLink != null && !this.TargetLink.Equals(input.TargetLink))) return false;

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
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ExecutionMode != null) hashCode = hashCode * 59 + this.ExecutionMode.GetHashCode();
                if (this.TargetCode != null) hashCode = hashCode * 59 + this.TargetCode.GetHashCode();
                if (this.TargetLink != null) hashCode = hashCode * 59 + this.TargetLink.GetHashCode();
                return hashCode;
            }
        }
    }
}
