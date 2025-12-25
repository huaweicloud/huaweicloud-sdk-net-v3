using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Versatile.V1.Model
{
    /// <summary>
    /// 插件参数
    /// </summary>
    public class PluginConfig 
    {

        /// <summary>
        /// 插件id
        /// </summary>
        [JsonProperty("plugin_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginId { get; set; }

        /// <summary>
        /// 单个插件参数
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Config { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginConfig {\n");
            sb.Append("  pluginId: ").Append(PluginId).Append("\n");
            sb.Append("  config: ").Append(Config).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginConfig input)
        {
            if (input == null) return false;
            if (this.PluginId != input.PluginId || (this.PluginId != null && !this.PluginId.Equals(input.PluginId))) return false;
            if (this.Config != input.Config || (this.Config != null && input.Config != null && !this.Config.SequenceEqual(input.Config))) return false;

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
                if (this.PluginId != null) hashCode = hashCode * 59 + this.PluginId.GetHashCode();
                if (this.Config != null) hashCode = hashCode * 59 + this.Config.GetHashCode();
                return hashCode;
            }
        }
    }
}
