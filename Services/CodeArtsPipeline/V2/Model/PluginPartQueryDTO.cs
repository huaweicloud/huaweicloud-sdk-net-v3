using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PluginPartQueryDTO 
    {

        /// <summary>
        /// **参数解释**： 插件名。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// **参数解释**： 展示名。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// **参数解释**： 版本号。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**： 插件属性。 **约束限制**： 不涉及。 **取值范围**： - custom：自定义插件。 - official：官方插件。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginAttribution { get; set; }

        /// <summary>
        /// **参数解释**： 版本属性。 **约束限制**： 不涉及。 **取值范围**： - draft：草稿版本。 - formal：正式版本。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("version_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionAttribution { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginPartQueryDTO {\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  pluginAttribution: ").Append(PluginAttribution).Append("\n");
            sb.Append("  versionAttribution: ").Append(VersionAttribution).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginPartQueryDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginPartQueryDTO input)
        {
            if (input == null) return false;
            if (this.PluginName != input.PluginName || (this.PluginName != null && !this.PluginName.Equals(input.PluginName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.PluginAttribution != input.PluginAttribution || (this.PluginAttribution != null && !this.PluginAttribution.Equals(input.PluginAttribution))) return false;
            if (this.VersionAttribution != input.VersionAttribution || (this.VersionAttribution != null && !this.VersionAttribution.Equals(input.VersionAttribution))) return false;

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
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.PluginAttribution != null) hashCode = hashCode * 59 + this.PluginAttribution.GetHashCode();
                if (this.VersionAttribution != null) hashCode = hashCode * 59 + this.VersionAttribution.GetHashCode();
                return hashCode;
            }
        }
    }
}
