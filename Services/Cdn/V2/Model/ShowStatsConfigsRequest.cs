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
    /// Request Object
    /// </summary>
    public class ShowStatsConfigsRequest 
    {

        /// <summary>
        /// - 配置类型 - 目前支持0：热点统计，1：ces上报
        /// </summary>
        [SDKProperty("config_type", IsQuery = true)]
        [JsonProperty("config_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfigType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStatsConfigsRequest {\n");
            sb.Append("  configType: ").Append(ConfigType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStatsConfigsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStatsConfigsRequest input)
        {
            if (input == null) return false;
            if (this.ConfigType != input.ConfigType || (this.ConfigType != null && !this.ConfigType.Equals(input.ConfigType))) return false;

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
                if (this.ConfigType != null) hashCode = hashCode * 59 + this.ConfigType.GetHashCode();
                return hashCode;
            }
        }
    }
}
