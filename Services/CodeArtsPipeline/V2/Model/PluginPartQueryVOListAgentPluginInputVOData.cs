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
    public class PluginPartQueryVOListAgentPluginInputVOData 
    {

        /// <summary>
        /// **参数解释**： 插件输入项唯一ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueId { get; set; }

        /// <summary>
        /// **参数解释**： 插件输入项名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 插件输入项默认值。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// **参数解释**： 插件名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// **参数解释**： 插件版本。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**： 插件输入项类型。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 租户id。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("validation", NullValueHandling = NullValueHandling.Ignore)]
        public ExtensionValidation Validation { get; set; }

        /// <summary>
        /// **参数解释**： 插件输入项样式信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("layout_content", NullValueHandling = NullValueHandling.Ignore)]
        public string LayoutContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extend_prop", NullValueHandling = NullValueHandling.Ignore)]
        public ExtensionExtendProp ExtendProp { get; set; }

        /// <summary>
        /// **参数解释**： 前端渲染使用的数据信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("front_data_prop", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDataProp { get; set; }

        /// <summary>
        /// **参数解释**： 标签。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// **参数解释**： 描述。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 是否必须。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public string Required { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginPartQueryVOListAgentPluginInputVOData {\n");
            sb.Append("  uniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  validation: ").Append(Validation).Append("\n");
            sb.Append("  layoutContent: ").Append(LayoutContent).Append("\n");
            sb.Append("  extendProp: ").Append(ExtendProp).Append("\n");
            sb.Append("  frontDataProp: ").Append(FrontDataProp).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  required: ").Append(Required).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginPartQueryVOListAgentPluginInputVOData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginPartQueryVOListAgentPluginInputVOData input)
        {
            if (input == null) return false;
            if (this.UniqueId != input.UniqueId || (this.UniqueId != null && !this.UniqueId.Equals(input.UniqueId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.DefaultValue != input.DefaultValue || (this.DefaultValue != null && !this.DefaultValue.Equals(input.DefaultValue))) return false;
            if (this.PluginName != input.PluginName || (this.PluginName != null && !this.PluginName.Equals(input.PluginName))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.Validation != input.Validation || (this.Validation != null && !this.Validation.Equals(input.Validation))) return false;
            if (this.LayoutContent != input.LayoutContent || (this.LayoutContent != null && !this.LayoutContent.Equals(input.LayoutContent))) return false;
            if (this.ExtendProp != input.ExtendProp || (this.ExtendProp != null && !this.ExtendProp.Equals(input.ExtendProp))) return false;
            if (this.FrontDataProp != input.FrontDataProp || (this.FrontDataProp != null && !this.FrontDataProp.Equals(input.FrontDataProp))) return false;
            if (this.Label != input.Label || (this.Label != null && !this.Label.Equals(input.Label))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Required != input.Required || (this.Required != null && !this.Required.Equals(input.Required))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DefaultValue != null) hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.PluginName != null) hashCode = hashCode * 59 + this.PluginName.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.Validation != null) hashCode = hashCode * 59 + this.Validation.GetHashCode();
                if (this.LayoutContent != null) hashCode = hashCode * 59 + this.LayoutContent.GetHashCode();
                if (this.ExtendProp != null) hashCode = hashCode * 59 + this.ExtendProp.GetHashCode();
                if (this.FrontDataProp != null) hashCode = hashCode * 59 + this.FrontDataProp.GetHashCode();
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Required != null) hashCode = hashCode * 59 + this.Required.GetHashCode();
                return hashCode;
            }
        }
    }
}
