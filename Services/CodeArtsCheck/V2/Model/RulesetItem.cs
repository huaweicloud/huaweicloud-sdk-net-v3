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
    /// 
    /// </summary>
    public class RulesetItem 
    {

        /// <summary>
        /// 规则集id
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 规则集语言
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 规则集名称
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 创建人时间
        /// </summary>
        [JsonProperty("template_create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateCreateTime { get; set; }

        /// <summary>
        /// 使用状态1使用中，0空闲中
        /// </summary>
        [JsonProperty("is_used", NullValueHandling = NullValueHandling.Ignore)]
        public string IsUsed { get; set; }

        /// <summary>
        /// 规则集包含的规则id
        /// </summary>
        [JsonProperty("rule_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleIds { get; set; }

        /// <summary>
        /// 是否该语言默认规则集，0不是，1是
        /// </summary>
        [JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        public string IsDefault { get; set; }

        /// <summary>
        /// 是否是项目下语言默认规则集，0不是，1是
        /// </summary>
        [JsonProperty("is_devcloud_project_default", NullValueHandling = NullValueHandling.Ignore)]
        public string IsDevcloudProjectDefault { get; set; }

        /// <summary>
        /// 是否是系统规则集，0不是，1是
        /// </summary>
        [JsonProperty("is_default_template", NullValueHandling = NullValueHandling.Ignore)]
        public string IsDefaultTemplate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RulesetItem {\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  templateCreateTime: ").Append(TemplateCreateTime).Append("\n");
            sb.Append("  isUsed: ").Append(IsUsed).Append("\n");
            sb.Append("  ruleIds: ").Append(RuleIds).Append("\n");
            sb.Append("  isDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  isDevcloudProjectDefault: ").Append(IsDevcloudProjectDefault).Append("\n");
            sb.Append("  isDefaultTemplate: ").Append(IsDefaultTemplate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RulesetItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RulesetItem input)
        {
            if (input == null) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.TemplateCreateTime != input.TemplateCreateTime || (this.TemplateCreateTime != null && !this.TemplateCreateTime.Equals(input.TemplateCreateTime))) return false;
            if (this.IsUsed != input.IsUsed || (this.IsUsed != null && !this.IsUsed.Equals(input.IsUsed))) return false;
            if (this.RuleIds != input.RuleIds || (this.RuleIds != null && !this.RuleIds.Equals(input.RuleIds))) return false;
            if (this.IsDefault != input.IsDefault || (this.IsDefault != null && !this.IsDefault.Equals(input.IsDefault))) return false;
            if (this.IsDevcloudProjectDefault != input.IsDevcloudProjectDefault || (this.IsDevcloudProjectDefault != null && !this.IsDevcloudProjectDefault.Equals(input.IsDevcloudProjectDefault))) return false;
            if (this.IsDefaultTemplate != input.IsDefaultTemplate || (this.IsDefaultTemplate != null && !this.IsDefaultTemplate.Equals(input.IsDefaultTemplate))) return false;

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
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.TemplateCreateTime != null) hashCode = hashCode * 59 + this.TemplateCreateTime.GetHashCode();
                if (this.IsUsed != null) hashCode = hashCode * 59 + this.IsUsed.GetHashCode();
                if (this.RuleIds != null) hashCode = hashCode * 59 + this.RuleIds.GetHashCode();
                if (this.IsDefault != null) hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                if (this.IsDevcloudProjectDefault != null) hashCode = hashCode * 59 + this.IsDevcloudProjectDefault.GetHashCode();
                if (this.IsDefaultTemplate != null) hashCode = hashCode * 59 + this.IsDefaultTemplate.GetHashCode();
                return hashCode;
            }
        }
    }
}
