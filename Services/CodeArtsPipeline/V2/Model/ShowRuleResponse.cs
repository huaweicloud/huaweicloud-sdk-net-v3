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
    /// Response Object
    /// </summary>
    public class ShowRuleResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 规则ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 规则类型。 **取值范围**： - Build：构建。 - Gate：代码检查。 - Test：测试。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 规则名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 规则是否有效。 **取值范围**： true:有效，false:无效 
        /// </summary>
        [JsonProperty("is_valid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// **参数解释**： 规则版本。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件唯一ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginId { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件版本号。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_version", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginVersion { get; set; }

        /// <summary>
        /// **参数解释**： 规则创建人。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// **参数解释**： 规则创建时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// **参数解释**： 规则最后更新人。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("updater", NullValueHandling = NullValueHandling.Ignore)]
        public string Updater { get; set; }

        /// <summary>
        /// **参数解释**： 规则最后更新时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// **参数解释**： 规则详细属性。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleContent> Content { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRuleResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  isValid: ").Append(IsValid).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  pluginId: ").Append(PluginId).Append("\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  pluginVersion: ").Append(PluginVersion).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updater: ").Append(Updater).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRuleResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.IsValid != input.IsValid || (this.IsValid != null && !this.IsValid.Equals(input.IsValid))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.PluginId != input.PluginId || (this.PluginId != null && !this.PluginId.Equals(input.PluginId))) return false;
            if (this.PluginName != input.PluginName || (this.PluginName != null && !this.PluginName.Equals(input.PluginName))) return false;
            if (this.PluginVersion != input.PluginVersion || (this.PluginVersion != null && !this.PluginVersion.Equals(input.PluginVersion))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Updater != input.Updater || (this.Updater != null && !this.Updater.Equals(input.Updater))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Content != input.Content || (this.Content != null && input.Content != null && !this.Content.SequenceEqual(input.Content))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsValid != null) hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.PluginId != null) hashCode = hashCode * 59 + this.PluginId.GetHashCode();
                if (this.PluginName != null) hashCode = hashCode * 59 + this.PluginName.GetHashCode();
                if (this.PluginVersion != null) hashCode = hashCode * 59 + this.PluginVersion.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Updater != null) hashCode = hashCode * 59 + this.Updater.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }
    }
}
