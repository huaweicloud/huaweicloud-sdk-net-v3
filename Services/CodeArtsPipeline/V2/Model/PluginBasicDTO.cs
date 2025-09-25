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
    public class PluginBasicDTO 
    {

        /// <summary>
        /// **参数解释**： 扩展插件UUID。 **约束限制**： 不涉及。 **取值范围**： 32位字符，由数字和字母组成。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueId { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件图标URL。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IconUrl { get; set; }

        /// <summary>
        /// **参数解释**： 运行属性。 **约束限制**： 不涉及。 **取值范围**： - agent：基于agent运行。 - agentless：无需agent运行。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("runtime_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string RuntimeAttribution { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件唯一标识。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件展示名。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件业务类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件业务类型展示名。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("business_type_display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessTypeDisplayName { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件描述。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 是否私有。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("is_private", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsPrivate { get; set; }

        /// <summary>
        /// **参数解释**： 局点。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释**： 维护者。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("maintainers", NullValueHandling = NullValueHandling.Ignore)]
        public string Maintainers { get; set; }

        /// <summary>
        /// **参数解释**： 标识是否为多个step组成的组。 **约束限制**： 不涉及。 **取值范围**： - single：单step插件。 - multi：组合插件。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_composition_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginCompositionType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginBasicDTO {\n");
            sb.Append("  uniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  iconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  runtimeAttribution: ").Append(RuntimeAttribution).Append("\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  businessTypeDisplayName: ").Append(BusinessTypeDisplayName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  maintainers: ").Append(Maintainers).Append("\n");
            sb.Append("  pluginCompositionType: ").Append(PluginCompositionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginBasicDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginBasicDTO input)
        {
            if (input == null) return false;
            if (this.UniqueId != input.UniqueId || (this.UniqueId != null && !this.UniqueId.Equals(input.UniqueId))) return false;
            if (this.IconUrl != input.IconUrl || (this.IconUrl != null && !this.IconUrl.Equals(input.IconUrl))) return false;
            if (this.RuntimeAttribution != input.RuntimeAttribution || (this.RuntimeAttribution != null && !this.RuntimeAttribution.Equals(input.RuntimeAttribution))) return false;
            if (this.PluginName != input.PluginName || (this.PluginName != null && !this.PluginName.Equals(input.PluginName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.BusinessType != input.BusinessType || (this.BusinessType != null && !this.BusinessType.Equals(input.BusinessType))) return false;
            if (this.BusinessTypeDisplayName != input.BusinessTypeDisplayName || (this.BusinessTypeDisplayName != null && !this.BusinessTypeDisplayName.Equals(input.BusinessTypeDisplayName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsPrivate != input.IsPrivate || (this.IsPrivate != null && !this.IsPrivate.Equals(input.IsPrivate))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Maintainers != input.Maintainers || (this.Maintainers != null && !this.Maintainers.Equals(input.Maintainers))) return false;
            if (this.PluginCompositionType != input.PluginCompositionType || (this.PluginCompositionType != null && !this.PluginCompositionType.Equals(input.PluginCompositionType))) return false;

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
                if (this.UniqueId != null) hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                if (this.IconUrl != null) hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.RuntimeAttribution != null) hashCode = hashCode * 59 + this.RuntimeAttribution.GetHashCode();
                if (this.PluginName != null) hashCode = hashCode * 59 + this.PluginName.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.BusinessType != null) hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.BusinessTypeDisplayName != null) hashCode = hashCode * 59 + this.BusinessTypeDisplayName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsPrivate != null) hashCode = hashCode * 59 + this.IsPrivate.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Maintainers != null) hashCode = hashCode * 59 + this.Maintainers.GetHashCode();
                if (this.PluginCompositionType != null) hashCode = hashCode * 59 + this.PluginCompositionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
