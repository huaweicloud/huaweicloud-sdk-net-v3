using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 下载临时路径请求
    /// </summary>
    public class DownLoadPathReq 
    {

        /// <summary>
        /// **参数解释**：带授权信息的URL的过期时间。 **约束限制**：0-86400。 **取值范围**：不涉及。 **默认取值**：3000。
        /// </summary>
        [JsonProperty("expires", NullValueHandling = NullValueHandling.Ignore)]
        public long? Expires { get; set; }

        /// <summary>
        /// **参数解释**：要下载文件的对象名。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownLoadPathReq {\n");
            sb.Append("  expires: ").Append(Expires).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownLoadPathReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownLoadPathReq input)
        {
            if (input == null) return false;
            if (this.Expires != input.Expires || (this.Expires != null && !this.Expires.Equals(input.Expires))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;

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
                if (this.Expires != null) hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                return hashCode;
            }
        }
    }
}
