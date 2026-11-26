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
    /// CDN状态码缓存时间。
    /// </summary>
    public class ErrorCodeCache 
    {

        /// <summary>
        /// **参数解释：** 需要缓存的错误码 **约束限制：** 不涉及 **取值范围：** - 3xx: 301, 302 - 4xx: 400, 401, 403, 404, 405, 407, 414, 416, 424, 451 - 5xx: 500, 501, 502, 503, 504, 509, 514  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int? Code { get; set; }

        /// <summary>
        /// **参数解释：** 错误码缓存时间 **约束限制：** 不涉及 **取值范围：** 0-31536000，单位：秒 &gt; 3XX及416状态码缓存时间范围为0-20s  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ttl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorCodeCache {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ErrorCodeCache);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ErrorCodeCache input)
        {
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Ttl != input.Ttl || (this.Ttl != null && !this.Ttl.Equals(input.Ttl))) return false;

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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Ttl != null) hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                return hashCode;
            }
        }
    }
}
