using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// **参数解释**：转发策略跨域的配置。
    /// </summary>
    public class CorsConfig 
    {

        /// <summary>
        /// **参数解释**：允许的访问来源列表。支持只配置一个元素*，或配置一个或多个值。  **约束限制**： - 单个值必须以http://或者https://开头，后边加一个正确的域名或一级泛域名。（例：http://_*.test.abc.example.com） - 单个值可以不加端口，也可以指定端口，端口范围：1~65535。
        /// </summary>
        [JsonProperty("allow_origin", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowOrigin { get; set; }

        /// <summary>
        /// **参数解释**：选择跨域访问时允许的 HTTP 方法。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("allow_methods", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowMethods { get; set; }

        /// <summary>
        /// **参数解释**：允许跨域的 Header 列表。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("allow_headers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowHeaders { get; set; }

        /// <summary>
        /// **参数解释**：允许暴露的Header列表。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("expose_headers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExposeHeaders { get; set; }

        /// <summary>
        /// **参数解释**：是否允许携带凭证信息。  **取值范围**： - true：是。 - false：否。
        /// </summary>
        [JsonProperty("allow_credentials", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowCredentials { get; set; }

        /// <summary>
        /// **参数解释**：预检请求在浏览器的最大缓存时间，单位：秒。  **取值范围**：-1~172800
        /// </summary>
        [JsonProperty("max_age", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxAge { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorsConfig {\n");
            sb.Append("  allowOrigin: ").Append(AllowOrigin).Append("\n");
            sb.Append("  allowMethods: ").Append(AllowMethods).Append("\n");
            sb.Append("  allowHeaders: ").Append(AllowHeaders).Append("\n");
            sb.Append("  exposeHeaders: ").Append(ExposeHeaders).Append("\n");
            sb.Append("  allowCredentials: ").Append(AllowCredentials).Append("\n");
            sb.Append("  maxAge: ").Append(MaxAge).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CorsConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CorsConfig input)
        {
            if (input == null) return false;
            if (this.AllowOrigin != input.AllowOrigin || (this.AllowOrigin != null && input.AllowOrigin != null && !this.AllowOrigin.SequenceEqual(input.AllowOrigin))) return false;
            if (this.AllowMethods != input.AllowMethods || (this.AllowMethods != null && input.AllowMethods != null && !this.AllowMethods.SequenceEqual(input.AllowMethods))) return false;
            if (this.AllowHeaders != input.AllowHeaders || (this.AllowHeaders != null && input.AllowHeaders != null && !this.AllowHeaders.SequenceEqual(input.AllowHeaders))) return false;
            if (this.ExposeHeaders != input.ExposeHeaders || (this.ExposeHeaders != null && input.ExposeHeaders != null && !this.ExposeHeaders.SequenceEqual(input.ExposeHeaders))) return false;
            if (this.AllowCredentials != input.AllowCredentials || (this.AllowCredentials != null && !this.AllowCredentials.Equals(input.AllowCredentials))) return false;
            if (this.MaxAge != input.MaxAge || (this.MaxAge != null && !this.MaxAge.Equals(input.MaxAge))) return false;

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
                if (this.AllowOrigin != null) hashCode = hashCode * 59 + this.AllowOrigin.GetHashCode();
                if (this.AllowMethods != null) hashCode = hashCode * 59 + this.AllowMethods.GetHashCode();
                if (this.AllowHeaders != null) hashCode = hashCode * 59 + this.AllowHeaders.GetHashCode();
                if (this.ExposeHeaders != null) hashCode = hashCode * 59 + this.ExposeHeaders.GetHashCode();
                if (this.AllowCredentials != null) hashCode = hashCode * 59 + this.AllowCredentials.GetHashCode();
                if (this.MaxAge != null) hashCode = hashCode * 59 + this.MaxAge.GetHashCode();
                return hashCode;
            }
        }
    }
}
