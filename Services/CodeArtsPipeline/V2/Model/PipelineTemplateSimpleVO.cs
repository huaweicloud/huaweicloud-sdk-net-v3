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
    public class PipelineTemplateSimpleVO 
    {

        /// <summary>
        /// **参数解释**： 模板ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 模板名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 模板图标。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        /// <summary>
        /// **参数解释**： 版本。 **取值范围**： 默认3.0。 
        /// </summary>
        [JsonProperty("manifest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ManifestVersion { get; set; }

        /// <summary>
        /// **参数解释**： 模板语言。 **取值范围**： - java。 - python。 - nodejs。 - go。 - net。 - cpp。 - php。 - other。 - none。 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// **参数解释**： 模板描述。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 是否系统模板。 **取值范围**： - true：是系统模板。 - false：不是系统模板。 
        /// </summary>
        [JsonProperty("is_system", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// **参数解释**： 模板局点。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释**： 模板所属租户ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**： 模板创建人ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// **参数解释**： 模板创建人名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// **参数解释**： 模板更新人ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("updater_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdaterId { get; set; }

        /// <summary>
        /// **参数解释**： 是否收藏。 **取值范围**： - true：收藏。 - false：不收藏。 
        /// </summary>
        [JsonProperty("is_collect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCollect { get; set; }

        /// <summary>
        /// **参数解释**： 是否展示流水线源。 **取值范围**： - true：展示流水线源。 - false：不展示流水线源。 
        /// </summary>
        [JsonProperty("is_show_source", NullValueHandling = NullValueHandling.Ignore)]
        public string IsShowSource { get; set; }

        /// <summary>
        /// **参数解释**： 模板编排的阶段列表。 **约束限制**： 不涉及。 
        /// </summary>
        [JsonProperty("stages", NullValueHandling = NullValueHandling.Ignore)]
        public List<PipelineTemplateSimpleVOStages> Stages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PipelineTemplateSimpleVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  icon: ").Append(Icon).Append("\n");
            sb.Append("  manifestVersion: ").Append(ManifestVersion).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  updaterId: ").Append(UpdaterId).Append("\n");
            sb.Append("  isCollect: ").Append(IsCollect).Append("\n");
            sb.Append("  isShowSource: ").Append(IsShowSource).Append("\n");
            sb.Append("  stages: ").Append(Stages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PipelineTemplateSimpleVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PipelineTemplateSimpleVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Icon != input.Icon || (this.Icon != null && !this.Icon.Equals(input.Icon))) return false;
            if (this.ManifestVersion != input.ManifestVersion || (this.ManifestVersion != null && !this.ManifestVersion.Equals(input.ManifestVersion))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsSystem != input.IsSystem || (this.IsSystem != null && !this.IsSystem.Equals(input.IsSystem))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.UpdaterId != input.UpdaterId || (this.UpdaterId != null && !this.UpdaterId.Equals(input.UpdaterId))) return false;
            if (this.IsCollect != input.IsCollect || (this.IsCollect != null && !this.IsCollect.Equals(input.IsCollect))) return false;
            if (this.IsShowSource != input.IsShowSource || (this.IsShowSource != null && !this.IsShowSource.Equals(input.IsShowSource))) return false;
            if (this.Stages != input.Stages || (this.Stages != null && input.Stages != null && !this.Stages.SequenceEqual(input.Stages))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Icon != null) hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.ManifestVersion != null) hashCode = hashCode * 59 + this.ManifestVersion.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsSystem != null) hashCode = hashCode * 59 + this.IsSystem.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.UpdaterId != null) hashCode = hashCode * 59 + this.UpdaterId.GetHashCode();
                if (this.IsCollect != null) hashCode = hashCode * 59 + this.IsCollect.GetHashCode();
                if (this.IsShowSource != null) hashCode = hashCode * 59 + this.IsShowSource.GetHashCode();
                if (this.Stages != null) hashCode = hashCode * 59 + this.Stages.GetHashCode();
                return hashCode;
            }
        }
    }
}
