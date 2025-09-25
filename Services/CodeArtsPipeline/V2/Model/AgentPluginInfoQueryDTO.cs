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
    public class AgentPluginInfoQueryDTO 
    {

        /// <summary>
        /// **参数解释**： 可选的查询条件-插件名。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// **参数解释**： 可选的查询条件-匹配名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("regex_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegexName { get; set; }

        /// <summary>
        /// **参数解释**： 维护者。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("maintainer", NullValueHandling = NullValueHandling.Ignore)]
        public string Maintainer { get; set; }

        /// <summary>
        /// **参数解释**： 业务类型。 **约束限制**： 不涉及。 **取值范围**： - Build。 - Gate。 - Deploy。 - Test。 - Normal。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BusinessType { get; set; }

        /// <summary>
        /// **参数解释**： 插件属性。 **约束限制**： 不涉及。 **取值范围**： - official：自定义插件。 - custom：基础插件。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginAttribution { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentPluginInfoQueryDTO {\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  regexName: ").Append(RegexName).Append("\n");
            sb.Append("  maintainer: ").Append(Maintainer).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  pluginAttribution: ").Append(PluginAttribution).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentPluginInfoQueryDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentPluginInfoQueryDTO input)
        {
            if (input == null) return false;
            if (this.PluginName != input.PluginName || (this.PluginName != null && !this.PluginName.Equals(input.PluginName))) return false;
            if (this.RegexName != input.RegexName || (this.RegexName != null && !this.RegexName.Equals(input.RegexName))) return false;
            if (this.Maintainer != input.Maintainer || (this.Maintainer != null && !this.Maintainer.Equals(input.Maintainer))) return false;
            if (this.BusinessType != input.BusinessType || (this.BusinessType != null && input.BusinessType != null && !this.BusinessType.SequenceEqual(input.BusinessType))) return false;
            if (this.PluginAttribution != input.PluginAttribution || (this.PluginAttribution != null && !this.PluginAttribution.Equals(input.PluginAttribution))) return false;

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
                if (this.RegexName != null) hashCode = hashCode * 59 + this.RegexName.GetHashCode();
                if (this.Maintainer != null) hashCode = hashCode * 59 + this.Maintainer.GetHashCode();
                if (this.BusinessType != null) hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.PluginAttribution != null) hashCode = hashCode * 59 + this.PluginAttribution.GetHashCode();
                return hashCode;
            }
        }
    }
}
