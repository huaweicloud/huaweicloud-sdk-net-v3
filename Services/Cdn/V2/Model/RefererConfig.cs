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
    /// 防盗链。
    /// </summary>
    public class RefererConfig 
    {

        /// <summary>
        /// Referer黑白名单类型，off：关闭Referer黑白名单，black：Referer黑名单，white：Referer白名单。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 域名或IP地址，以“,”进行分割，域名、IP地址可以混合输入，支持泛域名和带端口的域名。域名、IP地址总数不超过500个，端口取值范围1-65535。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 是否包含空Referer，如果是黑名单并开启该选项，则表示无referer不允许访问，如果是白名单并开启该选项，则表示无referer允许访问，true:包含空，false：不包含空，默认值false。
        /// </summary>
        [JsonProperty("include_empty", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeEmpty { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefererConfig {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  includeEmpty: ").Append(IncludeEmpty).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RefererConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RefererConfig input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.IncludeEmpty != input.IncludeEmpty || (this.IncludeEmpty != null && !this.IncludeEmpty.Equals(input.IncludeEmpty))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.IncludeEmpty != null) hashCode = hashCode * 59 + this.IncludeEmpty.GetHashCode();
                return hashCode;
            }
        }
    }
}
