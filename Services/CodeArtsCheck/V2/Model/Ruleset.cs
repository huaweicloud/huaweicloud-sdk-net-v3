using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 创建规则集信息
    /// </summary>
    public class Ruleset 
    {

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 新规则集名称
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 规则集语言
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 如果有基于的规则集则是1，没有基于的规则集则是0
        /// </summary>
        [JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        public string IsDefault { get; set; }

        /// <summary>
        /// 新启用规则ids
        /// </summary>
        [JsonProperty("rule_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleIds { get; set; }

        /// <summary>
        /// 新关闭规则id
        /// </summary>
        [JsonProperty("uncheck_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string UncheckIds { get; set; }

        /// <summary>
        /// 规则集ID
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 自定义规则参数项，支持修改规则阈值
        /// </summary>
        [JsonProperty("custom_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomAttributes> CustomAttributes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ruleset {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  isDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  ruleIds: ").Append(RuleIds).Append("\n");
            sb.Append("  uncheckIds: ").Append(UncheckIds).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  customAttributes: ").Append(CustomAttributes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Ruleset);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Ruleset input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.IsDefault != input.IsDefault || (this.IsDefault != null && !this.IsDefault.Equals(input.IsDefault))) return false;
            if (this.RuleIds != input.RuleIds || (this.RuleIds != null && !this.RuleIds.Equals(input.RuleIds))) return false;
            if (this.UncheckIds != input.UncheckIds || (this.UncheckIds != null && !this.UncheckIds.Equals(input.UncheckIds))) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.CustomAttributes != input.CustomAttributes || (this.CustomAttributes != null && input.CustomAttributes != null && !this.CustomAttributes.SequenceEqual(input.CustomAttributes))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.IsDefault != null) hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                if (this.RuleIds != null) hashCode = hashCode * 59 + this.RuleIds.GetHashCode();
                if (this.UncheckIds != null) hashCode = hashCode * 59 + this.UncheckIds.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.CustomAttributes != null) hashCode = hashCode * 59 + this.CustomAttributes.GetHashCode();
                return hashCode;
            }
        }
    }
}
