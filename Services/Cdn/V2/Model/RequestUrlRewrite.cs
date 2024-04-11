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
    /// 访问URL重写。
    /// </summary>
    public class RequestUrlRewrite 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public UrlRewriteCondition Condition { get; set; }

        /// <summary>
        /// 重定向状态码。支持301、302、303、307。
        /// </summary>
        [JsonProperty("redirect_status_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? RedirectStatusCode { get; set; }

        /// <summary>
        /// 重定向URL。重定向后的URL，以正斜线（/）开头，不含http://头及域名，如：/test/index.html。   - 当匹配类型为全路径时，\&quot;\\*\&quot;可以用“$1”捕获，例如：匹配内容为/test/\\*.jpg，重定向URL配置为/newtest/$1.jpg，则用户请求/test/11.jpg时，$1捕获11，重定向后请求的URL为/newtest/11.jpg。
        /// </summary>
        [JsonProperty("redirect_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 支持将客户端请求重定向到其他域名。   &gt; 不填时默认为当前域名。   &gt; 支持字符长度为1-255，必须以http://或https://开头，例如http://www.example.com。
        /// </summary>
        [JsonProperty("redirect_host", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectHost { get; set; }

        /// <summary>
        /// 执行规则：   - redirect：如果请求的URL匹配了当前规则，该请求将被重定向到目标Path。执行完当前规则后，当存在其他配置规则时，会继续匹配剩余规则。   - break：如果请求的URL匹配了当前规则，请求将被改写为目标Path。执行完当前规则后，当存在其他配置规则时，将不再匹配剩余规则，此时不支持配置重定向Host和重定向状态码，返回状态码200。
        /// </summary>
        [JsonProperty("execution_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestUrlRewrite {\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  redirectStatusCode: ").Append(RedirectStatusCode).Append("\n");
            sb.Append("  redirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  redirectHost: ").Append(RedirectHost).Append("\n");
            sb.Append("  executionMode: ").Append(ExecutionMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RequestUrlRewrite);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RequestUrlRewrite input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.RedirectStatusCode == input.RedirectStatusCode ||
                    (this.RedirectStatusCode != null &&
                    this.RedirectStatusCode.Equals(input.RedirectStatusCode))
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
                ) && 
                (
                    this.RedirectHost == input.RedirectHost ||
                    (this.RedirectHost != null &&
                    this.RedirectHost.Equals(input.RedirectHost))
                ) && 
                (
                    this.ExecutionMode == input.ExecutionMode ||
                    (this.ExecutionMode != null &&
                    this.ExecutionMode.Equals(input.ExecutionMode))
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
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.RedirectStatusCode != null)
                    hashCode = hashCode * 59 + this.RedirectStatusCode.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                if (this.RedirectHost != null)
                    hashCode = hashCode * 59 + this.RedirectHost.GetHashCode();
                if (this.ExecutionMode != null)
                    hashCode = hashCode * 59 + this.ExecutionMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
