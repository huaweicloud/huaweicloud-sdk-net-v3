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
    /// 配置信息
    /// </summary>
    public class ConfigInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public TopUrl Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ua", NullValueHandling = NullValueHandling.Ignore)]
        public TopUa Ua { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigInfo {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  ua: ").Append(Ua).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigInfo input)
        {
            if (input == null) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Ua != input.Ua || (this.Ua != null && !this.Ua.Equals(input.Ua))) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Ua != null) hashCode = hashCode * 59 + this.Ua.GetHashCode();
                return hashCode;
            }
        }
    }
}
