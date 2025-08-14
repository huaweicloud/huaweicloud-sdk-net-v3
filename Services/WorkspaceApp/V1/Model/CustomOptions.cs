using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 自定义策略设置项。
    /// </summary>
    public class CustomOptions 
    {

        /// <summary>
        /// 配置项1内容。
        /// </summary>
        [JsonProperty("custom_configuration1_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomConfiguration1Rule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rail_transparent_config", NullValueHandling = NullValueHandling.Ignore)]
        public RailTransparentConfig RailTransparentConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomOptions {\n");
            sb.Append("  customConfiguration1Rule: ").Append(CustomConfiguration1Rule).Append("\n");
            sb.Append("  railTransparentConfig: ").Append(RailTransparentConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomOptions input)
        {
            if (input == null) return false;
            if (this.CustomConfiguration1Rule != input.CustomConfiguration1Rule || (this.CustomConfiguration1Rule != null && !this.CustomConfiguration1Rule.Equals(input.CustomConfiguration1Rule))) return false;
            if (this.RailTransparentConfig != input.RailTransparentConfig || (this.RailTransparentConfig != null && !this.RailTransparentConfig.Equals(input.RailTransparentConfig))) return false;

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
                if (this.CustomConfiguration1Rule != null) hashCode = hashCode * 59 + this.CustomConfiguration1Rule.GetHashCode();
                if (this.RailTransparentConfig != null) hashCode = hashCode * 59 + this.RailTransparentConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
