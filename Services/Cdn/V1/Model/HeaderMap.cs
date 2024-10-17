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
    /// 设置HTTP头参数。取值：\&quot;Content-Disposition\&quot;, \&quot;Content-Language\&quot;, \&quot;Access-Control-Allow-Origin\&quot;,\&quot;Access-Control-Allow-Methods\&quot;, \&quot;Access-Control-Max-Age\&quot;, \&quot;Access-Control-Expose-Headers\&quot;。
    /// </summary>
    public class HeaderMap 
    {

        /// <summary>
        /// 指示回复的内容该以何种形式展示
        /// </summary>
        [JsonProperty("Content-Disposition", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentDisposition { get; set; }

        /// <summary>
        /// 说明访问者希望采用的语言或语言组合
        /// </summary>
        [JsonProperty("Content-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentLanguage { get; set; }

        /// <summary>
        /// 指定了该响应的资源是否被允许与给定的origin共享
        /// </summary>
        [JsonProperty("Access-Control-Allow-Origin", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlAllowOrigin { get; set; }

        /// <summary>
        /// 明确了客户端所要访问的资源允许使用的方法或方法列表
        /// </summary>
        [JsonProperty("Access-Control-Allow-Methods", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlAllowMethods { get; set; }

        /// <summary>
        /// Access-Control-Allow-Methods 和Access-Control-Allow-Headers 提供的信息可以被缓存多久
        /// </summary>
        [JsonProperty("Access-Control-Max-Age", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlMaxAge { get; set; }

        /// <summary>
        /// 列出了哪些首部可以作为响应的一部分暴露给外部
        /// </summary>
        [JsonProperty("Access-Control-Expose-Headers", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlExposeHeaders { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HeaderMap {\n");
            sb.Append("  contentDisposition: ").Append(ContentDisposition).Append("\n");
            sb.Append("  contentLanguage: ").Append(ContentLanguage).Append("\n");
            sb.Append("  accessControlAllowOrigin: ").Append(AccessControlAllowOrigin).Append("\n");
            sb.Append("  accessControlAllowMethods: ").Append(AccessControlAllowMethods).Append("\n");
            sb.Append("  accessControlMaxAge: ").Append(AccessControlMaxAge).Append("\n");
            sb.Append("  accessControlExposeHeaders: ").Append(AccessControlExposeHeaders).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HeaderMap);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HeaderMap input)
        {
            if (input == null) return false;
            if (this.ContentDisposition != input.ContentDisposition || (this.ContentDisposition != null && !this.ContentDisposition.Equals(input.ContentDisposition))) return false;
            if (this.ContentLanguage != input.ContentLanguage || (this.ContentLanguage != null && !this.ContentLanguage.Equals(input.ContentLanguage))) return false;
            if (this.AccessControlAllowOrigin != input.AccessControlAllowOrigin || (this.AccessControlAllowOrigin != null && !this.AccessControlAllowOrigin.Equals(input.AccessControlAllowOrigin))) return false;
            if (this.AccessControlAllowMethods != input.AccessControlAllowMethods || (this.AccessControlAllowMethods != null && !this.AccessControlAllowMethods.Equals(input.AccessControlAllowMethods))) return false;
            if (this.AccessControlMaxAge != input.AccessControlMaxAge || (this.AccessControlMaxAge != null && !this.AccessControlMaxAge.Equals(input.AccessControlMaxAge))) return false;
            if (this.AccessControlExposeHeaders != input.AccessControlExposeHeaders || (this.AccessControlExposeHeaders != null && !this.AccessControlExposeHeaders.Equals(input.AccessControlExposeHeaders))) return false;

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
                if (this.ContentDisposition != null) hashCode = hashCode * 59 + this.ContentDisposition.GetHashCode();
                if (this.ContentLanguage != null) hashCode = hashCode * 59 + this.ContentLanguage.GetHashCode();
                if (this.AccessControlAllowOrigin != null) hashCode = hashCode * 59 + this.AccessControlAllowOrigin.GetHashCode();
                if (this.AccessControlAllowMethods != null) hashCode = hashCode * 59 + this.AccessControlAllowMethods.GetHashCode();
                if (this.AccessControlMaxAge != null) hashCode = hashCode * 59 + this.AccessControlMaxAge.GetHashCode();
                if (this.AccessControlExposeHeaders != null) hashCode = hashCode * 59 + this.AccessControlExposeHeaders.GetHashCode();
                return hashCode;
            }
        }
    }
}
