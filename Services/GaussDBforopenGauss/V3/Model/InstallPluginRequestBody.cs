using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InstallPluginRequestBody 
    {

        /// <summary>
        /// **参数解释**: 插件名称。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// **参数解释**: 插件版本。 **约束限制**: 不涉及。 **取值范围**: 长度为2~64个字符。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**: 插件安装端口。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// **参数解释**: 安装插件的OBS地址。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("obs_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstallPluginRequestBody {\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  obsUrl: ").Append(ObsUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstallPluginRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstallPluginRequestBody input)
        {
            if (input == null) return false;
            if (this.PluginName != input.PluginName || (this.PluginName != null && !this.PluginName.Equals(input.PluginName))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.ObsUrl != input.ObsUrl || (this.ObsUrl != null && !this.ObsUrl.Equals(input.ObsUrl))) return false;

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
                if (this.PluginName != null) hashCode = hashCode * 59 + this.PluginName.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.ObsUrl != null) hashCode = hashCode * 59 + this.ObsUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
