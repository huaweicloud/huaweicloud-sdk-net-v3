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
    public class PageInfoOptionalSinglePluginVOData 
    {

        /// <summary>
        /// **参数解释**： 扩展插件唯一标识。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件在插件市场和流水线显示的名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// **参数解释**： 标识是否为官方插件。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginAttribution { get; set; }

        /// <summary>
        /// **参数解释**： 图标URL。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IconUrl { get; set; }

        /// <summary>
        /// **参数解释**： 插件描述。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 发布商ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("publisher_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublisherId { get; set; }

        /// <summary>
        /// **参数解释**： 版本。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("manifest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ManifestVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageInfoOptionalSinglePluginVOData {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  pluginAttribution: ").Append(PluginAttribution).Append("\n");
            sb.Append("  iconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  publisherId: ").Append(PublisherId).Append("\n");
            sb.Append("  manifestVersion: ").Append(ManifestVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PageInfoOptionalSinglePluginVOData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PageInfoOptionalSinglePluginVOData input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.PluginAttribution != input.PluginAttribution || (this.PluginAttribution != null && !this.PluginAttribution.Equals(input.PluginAttribution))) return false;
            if (this.IconUrl != input.IconUrl || (this.IconUrl != null && !this.IconUrl.Equals(input.IconUrl))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.PublisherId != input.PublisherId || (this.PublisherId != null && !this.PublisherId.Equals(input.PublisherId))) return false;
            if (this.ManifestVersion != input.ManifestVersion || (this.ManifestVersion != null && !this.ManifestVersion.Equals(input.ManifestVersion))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.PluginAttribution != null) hashCode = hashCode * 59 + this.PluginAttribution.GetHashCode();
                if (this.IconUrl != null) hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PublisherId != null) hashCode = hashCode * 59 + this.PublisherId.GetHashCode();
                if (this.ManifestVersion != null) hashCode = hashCode * 59 + this.ManifestVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
