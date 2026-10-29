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
    /// 创建规则集信息。
    /// </summary>
    public class Ruleset 
    {

        /// <summary>
        /// **参数解释:** 项目的32位UUID，通过[[查询项目列表](https://support.huaweicloud.com/api-projectman/ListProjectsV4.html)](tag:hws)[[查询项目列表](https://support.huaweicloud.com/intl/zh-cn/api-projectman/ListProjectsV4.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm,hcs_site,hcs_sitesm,fcs)接口获取。 **约束限制:** 不涉及。 **取值范围:** 长度为[1~32]个字符。 **默认取值:** 不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释:** 新规则集名称。 **约束限制:** 不能含有任意中英文，数字，点，连字符-及下划线_以外的特殊字符。 **取值范围:** 任意中英文，数字，点，连字符-及下划线_。长度为[1~128]个字符。 **默认取值:** 不涉及。
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// **参数解释:** 规则集语言。 **约束限制:** 只能选择当前系统上支持的语言。 **取值范围:** 只能传一种语言。当前支持的语言有： - ARKTS - C# - CANGJIE - C++ - CSS - GO - HTML - JAVA - JAVASCRIPT - KOTLIN - LUA - PHP - PYTHON - RUST - SCALA - SHELL - SQL - TERRAFORM - TYPESCRIPT - AZURERESOURCEMANAGER - DOCKER - KUBERNETES **默认取值:** 不涉及。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// **参数解释:** 是否基于已存在的规则集创建新规则集。 **约束限制:** 只能填0或1。 **取值范围:** - 0：新建空白规则集。 - 1：基于已存在的规则集创建新规则集。 **默认取值:** 不涉及。
        /// </summary>
        [JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        public string IsDefault { get; set; }

        /// <summary>
        /// **参数解释:** 新启用规则ID集合，启用多条规则时，id用英文逗号相连。可调用[[获取规则列表接口](https://support.huaweicloud.com/api-codecheck/ListRules.html)](tag:hws)[[获取规则列表接口](https://support.huaweicloud.com/intl/zh-cn/api-codecheck/ListRules.html)](tag:hws_hk)[获取规则列表接口](tag:hcs,hcs_sm,hcs_site,hcs_sitesm,fcs)获取规则ID。 **约束限制:** 规则ID为32位UUID，多个ID之间用英文逗号分隔。例如：\&quot;00034fc32ee045388365d42ca4e07fe1,002c2eda6d6c11edab16fa163e0fa374\&quot;。 **取值范围:** 长度为[1~4000]个字符。 **默认取值:** 不涉及。
        /// </summary>
        [JsonProperty("rule_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleIds { get; set; }

        /// <summary>
        /// **参数解释:** 新关闭规则ID集合，多个ID用英文逗号相连。可调用[[获取规则列表接口](https://support.huaweicloud.com/api-codecheck/ListRules.html)](tag:hws)[[获取规则列表接口](https://support.huaweicloud.com/intl/zh-cn/api-codecheck/ListRules.html)](tag:hws_hk)[获取规则列表接口](tag:hcs,hcs_sm,hcs_site,hcs_sitesm,fcs)获取规则ID。 **约束限制:** 规则ID为32位UUID，多个ID之间用英文逗号分隔。例如：\&quot;00034fc32ee045388365d42ca4e07fe1,002c2eda6d6c11edab16fa163e0fa374\&quot;。 **取值范围:** 长度为[1~4000]个字符。 **默认取值:** 不涉及。
        /// </summary>
        [JsonProperty("uncheck_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string UncheckIds { get; set; }

        /// <summary>
        /// **参数解释:** 规则集ID。当is_default参数为1时，该参数需要传参。可调用[[查询规则集列表](https://support.huaweicloud.com/api-codecheck/ListRulesets.html)](tag:hws)[[查询规则集列表](https://support.huaweicloud.com/intl/zh-cn/api-codecheck/ListRulesets.html)](tag:hws_hk)[查询规则集列表](tag:hcs,hcs_sm,hcs_site,hcs_sitesm,fcs)获取已存在的规则集ID。 **约束限制:** 32位UUID。例如：\&quot;da303d80d2594faca60dbcc2e29c18aa\&quot;。 **取值范围:** 不涉及。 **默认取值:** 不涉及。
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 自定义规则参数项，支持修改规则阈值。
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
