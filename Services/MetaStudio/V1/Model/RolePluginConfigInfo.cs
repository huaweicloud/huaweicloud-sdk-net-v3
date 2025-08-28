using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 角色插件配置信息。
    /// </summary>
    public class RolePluginConfigInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("plugin_type", NullValueHandling = NullValueHandling.Ignore)]
        public PluginTypeEnum PluginType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("plugin_source", NullValueHandling = NullValueHandling.Ignore)]
        public PluginSourceEnum PluginSource { get; set; }
        /// <summary>
        /// 插件配置ID。
        /// </summary>
        [JsonProperty("plugin_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginConfigId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RolePluginConfigInfo {\n");
            sb.Append("  pluginType: ").Append(PluginType).Append("\n");
            sb.Append("  pluginSource: ").Append(PluginSource).Append("\n");
            sb.Append("  pluginConfigId: ").Append(PluginConfigId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RolePluginConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RolePluginConfigInfo input)
        {
            if (input == null) return false;
            if (this.PluginType != input.PluginType) return false;
            if (this.PluginSource != input.PluginSource) return false;
            if (this.PluginConfigId != input.PluginConfigId || (this.PluginConfigId != null && !this.PluginConfigId.Equals(input.PluginConfigId))) return false;

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
                hashCode = hashCode * 59 + this.PluginType.GetHashCode();
                hashCode = hashCode * 59 + this.PluginSource.GetHashCode();
                if (this.PluginConfigId != null) hashCode = hashCode * 59 + this.PluginConfigId.GetHashCode();
                return hashCode;
            }
        }
    }
}
