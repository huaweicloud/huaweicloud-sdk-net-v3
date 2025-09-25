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
    public class CreateRuleReq 
    {

        /// <summary>
        /// **参数解释**： 创建规则的类型。 **约束限制**： 不涉及。 **取值范围**： - Build。 - Gate。 - Deploy。 - Test。 - Normal。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 规则名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 布局内容。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("layout_content", NullValueHandling = NullValueHandling.Ignore)]
        public string LayoutContent { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件唯一ID。可以通过[查询插件版本详情](ShowPluginVersion.xml)接口，获取响应参数中unique_id。 **约束限制**： 不涉及。 **取值范围**： 32位字符，由数字和字母组成。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginId { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件名称。 **约束限制**： 仅支持输入大小写英文字母、数字、&#39;-&#39;、&#39;_&#39;。 **取值范围**： 1到50位字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// **参数解释**： 插件版本号。 **约束限制**： 必须是类似 x.xx.xx 的格式，其中：x 是 1 到 2 位的数字（范围 0 到 99）。xx 是点后跟随的数字部分，且每部分可以是 1 位或 2 位数字。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_version", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginVersion { get; set; }

        /// <summary>
        /// **参数解释**： 规则属性分组列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleContent> Content { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRuleReq {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  layoutContent: ").Append(LayoutContent).Append("\n");
            sb.Append("  pluginId: ").Append(PluginId).Append("\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  pluginVersion: ").Append(PluginVersion).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRuleReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRuleReq input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.LayoutContent != input.LayoutContent || (this.LayoutContent != null && !this.LayoutContent.Equals(input.LayoutContent))) return false;
            if (this.PluginId != input.PluginId || (this.PluginId != null && !this.PluginId.Equals(input.PluginId))) return false;
            if (this.PluginName != input.PluginName || (this.PluginName != null && !this.PluginName.Equals(input.PluginName))) return false;
            if (this.PluginVersion != input.PluginVersion || (this.PluginVersion != null && !this.PluginVersion.Equals(input.PluginVersion))) return false;
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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LayoutContent != null) hashCode = hashCode * 59 + this.LayoutContent.GetHashCode();
                if (this.PluginId != null) hashCode = hashCode * 59 + this.PluginId.GetHashCode();
                if (this.PluginName != null) hashCode = hashCode * 59 + this.PluginName.GetHashCode();
                if (this.PluginVersion != null) hashCode = hashCode * 59 + this.PluginVersion.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }
    }
}
