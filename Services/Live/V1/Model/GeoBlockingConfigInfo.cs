using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GeoBlockingConfigInfo 
    {

        /// <summary>
        /// 应用名
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 限制区域列表, 空列表表示不限制。 除中国以外，其他地区代码，2位字母大写。代码格式参阅[ISO 3166-1 alpha-2](https://www.iso.org/obp/ui/#search/code/) 包含如下部分取值： - CN-IN：中国大陆 - CN-HK：中国香港 - CN-MO：中国澳门 - CN-TW：中国台湾 - BR：巴西
        /// </summary>
        [JsonProperty("area_whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AreaWhitelist { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoBlockingConfigInfo {\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  areaWhitelist: ").Append(AreaWhitelist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GeoBlockingConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GeoBlockingConfigInfo input)
        {
            if (input == null) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.AreaWhitelist != input.AreaWhitelist || (this.AreaWhitelist != null && input.AreaWhitelist != null && !this.AreaWhitelist.SequenceEqual(input.AreaWhitelist))) return false;

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
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.AreaWhitelist != null) hashCode = hashCode * 59 + this.AreaWhitelist.GetHashCode();
                return hashCode;
            }
        }
    }
}
