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
    public class PipelineTemplateDTO 
    {

        /// <summary>
        /// **参数解释**： 模板名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 模板描述。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 模板语言。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// **参数解释**： 自定义参数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomVariable> Variables { get; set; }

        /// <summary>
        /// **参数解释**： 模板编排json，包含stages。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("definition", NullValueHandling = NullValueHandling.Ignore)]
        public string Definition { get; set; }

        /// <summary>
        /// **参数解释**： 是否系统模板。 **约束限制**： 不涉及。 **取值范围**： - true：是系统模板。 - false：不是系统模板。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("is_system", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// **参数解释**： 租户id。 **约束限制**： 不涉及。 **取值范围**： 32位字符，由数字和字母组成。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**： 是否显示流水线源。 **约束限制**： 不涉及。 **取值范围**： - true：显示流水线源。 - false：不显示流水线源。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("is_show_source", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsShowSource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PipelineTemplateDTO {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  variables: ").Append(Variables).Append("\n");
            sb.Append("  definition: ").Append(Definition).Append("\n");
            sb.Append("  isSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  isShowSource: ").Append(IsShowSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PipelineTemplateDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PipelineTemplateDTO input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.Variables != input.Variables || (this.Variables != null && input.Variables != null && !this.Variables.SequenceEqual(input.Variables))) return false;
            if (this.Definition != input.Definition || (this.Definition != null && !this.Definition.Equals(input.Definition))) return false;
            if (this.IsSystem != input.IsSystem || (this.IsSystem != null && !this.IsSystem.Equals(input.IsSystem))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.IsShowSource != input.IsShowSource || (this.IsShowSource != null && !this.IsShowSource.Equals(input.IsShowSource))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Variables != null) hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.Definition != null) hashCode = hashCode * 59 + this.Definition.GetHashCode();
                if (this.IsSystem != null) hashCode = hashCode * 59 + this.IsSystem.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.IsShowSource != null) hashCode = hashCode * 59 + this.IsShowSource.GetHashCode();
                return hashCode;
            }
        }
    }
}
