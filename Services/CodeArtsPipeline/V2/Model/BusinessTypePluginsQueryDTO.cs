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
    public class BusinessTypePluginsQueryDTO 
    {

        /// <summary>
        /// **参数解释**： 用于区分插件为流水线可使用/模板可使用。 **约束限制**： 不涉及。 **取值范围**： - pipeline：流水线可使用。 - template：模板可使用。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("use_condition", NullValueHandling = NullValueHandling.Ignore)]
        public string UseCondition { get; set; }

        /// <summary>
        /// **参数解释**： 用于区分源的代码仓类型codehub/gitlab/github等。 **约束限制**： 不涉及。 **取值范围**： - codehub。 - gitee。 - github。 - gitcode。 - gitlab。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("input_repo_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InputRepoType { get; set; }

        /// <summary>
        /// **参数解释**： 用于区分单源/多源的情况。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("input_source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InputSourceType { get; set; }

        /// <summary>
        /// **参数解释**： 业务类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

        /// <summary>
        /// **参数解释**： 匹配名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("regex_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegexName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessTypePluginsQueryDTO {\n");
            sb.Append("  useCondition: ").Append(UseCondition).Append("\n");
            sb.Append("  inputRepoType: ").Append(InputRepoType).Append("\n");
            sb.Append("  inputSourceType: ").Append(InputSourceType).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  regexName: ").Append(RegexName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BusinessTypePluginsQueryDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BusinessTypePluginsQueryDTO input)
        {
            if (input == null) return false;
            if (this.UseCondition != input.UseCondition || (this.UseCondition != null && !this.UseCondition.Equals(input.UseCondition))) return false;
            if (this.InputRepoType != input.InputRepoType || (this.InputRepoType != null && !this.InputRepoType.Equals(input.InputRepoType))) return false;
            if (this.InputSourceType != input.InputSourceType || (this.InputSourceType != null && !this.InputSourceType.Equals(input.InputSourceType))) return false;
            if (this.BusinessType != input.BusinessType || (this.BusinessType != null && !this.BusinessType.Equals(input.BusinessType))) return false;
            if (this.RegexName != input.RegexName || (this.RegexName != null && !this.RegexName.Equals(input.RegexName))) return false;

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
                if (this.UseCondition != null) hashCode = hashCode * 59 + this.UseCondition.GetHashCode();
                if (this.InputRepoType != null) hashCode = hashCode * 59 + this.InputRepoType.GetHashCode();
                if (this.InputSourceType != null) hashCode = hashCode * 59 + this.InputSourceType.GetHashCode();
                if (this.BusinessType != null) hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.RegexName != null) hashCode = hashCode * 59 + this.RegexName.GetHashCode();
                return hashCode;
            }
        }
    }
}
