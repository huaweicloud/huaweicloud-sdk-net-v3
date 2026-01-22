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
    /// **参数解释**：转发策略跨域的配置。  **约束限制**：不涉及
    /// </summary>
    public class CreateCorsConfig 
    {

        /// <summary>
        /// **参数解释**：允许的访问来源列表。  **约束限制**： - 若配置了通配符（*），则不能配其他值。 - 不支持IP地址。 - 不能配置重复的值。  **取值范围**：单个列表项的取值 - 通配符（*），表示匹配所有来源。 - 除通配符外，其他值只能是以http://或者https://开头（小写），后面加域名。可以是具体域名或一级泛域名，可以包含端口或不包含端口。例：http://_*.test.abc.example.com:80  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("allow_origin", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowOrigin { get; set; }

        /// <summary>
        /// **参数解释**：选择跨域访问时允许的 HTTP 方法。  **约束限制**：不涉及  **取值范围**：不涉及  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("allow_methods", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowMethods { get; set; }

        /// <summary>
        /// **参数解释**：允许跨域的 Header 列表。  **约束限制**：不涉及  **取值范围**：不涉及  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("allow_headers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowHeaders { get; set; }

        /// <summary>
        /// **参数解释**：允许暴露的Header列表。  **约束限制**：不涉及  **取值范围**：不涉及  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("expose_headers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExposeHeaders { get; set; }

        /// <summary>
        /// **参数解释**：是否允许携带凭证信息。  **约束限制**：不涉及  **取值范围**：true 是，false 否。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("allow_credentials", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowCredentials { get; set; }

        /// <summary>
        /// **参数解释**：预检请求在浏览器的最大缓存时间，单位：秒。  **约束限制**：不涉及  **取值范围**：-1~172800  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("max_age", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxAge { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCorsConfig {\n");
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
            return this.Equals(input as CreateCorsConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateCorsConfig input)
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
