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
    public class PipelineByTemplateDTO 
    {

        /// <summary>
        /// **参数解释**： 流水线名称。 **约束限制**： 不涉及。 **取值范围**： 仅包含中文、大小写英文字母、数字、&#39;-&#39;和&#39;_&#39;，且长度为[1,128]个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 流水线描述。 **约束限制**： 不涉及。 **取值范围**： 不超过1024字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 是否为变更流水线。 **约束限制**： 不涉及。 **取值范围**： - true：是变更流水线。 - false：不是变更流水线。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("is_publish", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPublish { get; set; }

        /// <summary>
        /// **参数解释**： 流水线源列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<CodeSource> Sources { get; set; }

        /// <summary>
        /// **参数解释**： 流水线涉密等级，非涉密场景不涉及，涉密场景必填。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("security_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecurityLevel { get; set; }

        /// <summary>
        /// **参数解释**： 流水线涉密等级编码，非涉密场景不涉及。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("confidentiality_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfidentialityCode { get; set; }

        /// <summary>
        /// **参数解释**： 流水线参数列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public List<PipelineByTemplateDTOVariables> Variables { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PipelineByTemplateDTO {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isPublish: ").Append(IsPublish).Append("\n");
            sb.Append("  sources: ").Append(Sources).Append("\n");
            sb.Append("  securityLevel: ").Append(SecurityLevel).Append("\n");
            sb.Append("  confidentialityCode: ").Append(ConfidentialityCode).Append("\n");
            sb.Append("  variables: ").Append(Variables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PipelineByTemplateDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PipelineByTemplateDTO input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsPublish != input.IsPublish || (this.IsPublish != null && !this.IsPublish.Equals(input.IsPublish))) return false;
            if (this.Sources != input.Sources || (this.Sources != null && input.Sources != null && !this.Sources.SequenceEqual(input.Sources))) return false;
            if (this.SecurityLevel != input.SecurityLevel || (this.SecurityLevel != null && !this.SecurityLevel.Equals(input.SecurityLevel))) return false;
            if (this.ConfidentialityCode != input.ConfidentialityCode || (this.ConfidentialityCode != null && !this.ConfidentialityCode.Equals(input.ConfidentialityCode))) return false;
            if (this.Variables != input.Variables || (this.Variables != null && input.Variables != null && !this.Variables.SequenceEqual(input.Variables))) return false;

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
                if (this.IsPublish != null) hashCode = hashCode * 59 + this.IsPublish.GetHashCode();
                if (this.Sources != null) hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.SecurityLevel != null) hashCode = hashCode * 59 + this.SecurityLevel.GetHashCode();
                if (this.ConfidentialityCode != null) hashCode = hashCode * 59 + this.ConfidentialityCode.GetHashCode();
                if (this.Variables != null) hashCode = hashCode * 59 + this.Variables.GetHashCode();
                return hashCode;
            }
        }
    }
}
