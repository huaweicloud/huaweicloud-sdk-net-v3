using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AlarmRuleTemplateBody 
    {

        /// <summary>
        /// 告警模板名称。
        /// </summary>
        [JsonProperty("alarm_rule_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleTemplateName { get; set; }

        /// <summary>
        /// 告警模板英文名称。
        /// </summary>
        [JsonProperty("alarm_rule_template_name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleTemplateNameEn { get; set; }

        /// <summary>
        /// 告警模板描述。
        /// </summary>
        [JsonProperty("alarm_rule_template_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleTemplateDescription { get; set; }

        /// <summary>
        /// 告警模板id。
        /// </summary>
        [JsonProperty("alarm_rule_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleTemplateId { get; set; }

        /// <summary>
        /// 项目ID，可以从控制台获取，也可以从调用API处获取。获取方式请参见：[获取项目ID](aom_04_0024.xml)。
        /// </summary>
        [JsonProperty("alarm_rule_template_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleTemplateProjectId { get; set; }

        /// <summary>
        /// 告警模板类型 - “statics”：静态告警模板 - “dynamic”：动态告警模板
        /// </summary>
        [JsonProperty("alarm_rule_template_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleTemplateType { get; set; }

        /// <summary>
        /// 告警模板来源。
        /// </summary>
        [JsonProperty("alarm_rule_template_source", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleTemplateSource { get; set; }

        /// <summary>
        /// 告警模板所绑定的告警规则。
        /// </summary>
        [JsonProperty("alarm_rule_template_binding", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AlarmRuleTemplateBinding { get; set; }

        /// <summary>
        /// 告警模板列表。
        /// </summary>
        [JsonProperty("alarm_template_spec_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmRuleTemplateSpecWithCloudService> AlarmTemplateSpecList { get; set; }

        /// <summary>
        /// 企业项目id。获取方式请参见：[获取企业项目ID](aom_04_0024.xml)。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("modify_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("templating", NullValueHandling = NullValueHandling.Ignore)]
        public Templating Templating { get; set; }

        /// <summary>
        /// 告警模板版本。
        /// </summary>
        [JsonProperty("template_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmRuleTemplateBody {\n");
            sb.Append("  alarmRuleTemplateName: ").Append(AlarmRuleTemplateName).Append("\n");
            sb.Append("  alarmRuleTemplateNameEn: ").Append(AlarmRuleTemplateNameEn).Append("\n");
            sb.Append("  alarmRuleTemplateDescription: ").Append(AlarmRuleTemplateDescription).Append("\n");
            sb.Append("  alarmRuleTemplateId: ").Append(AlarmRuleTemplateId).Append("\n");
            sb.Append("  alarmRuleTemplateProjectId: ").Append(AlarmRuleTemplateProjectId).Append("\n");
            sb.Append("  alarmRuleTemplateType: ").Append(AlarmRuleTemplateType).Append("\n");
            sb.Append("  alarmRuleTemplateSource: ").Append(AlarmRuleTemplateSource).Append("\n");
            sb.Append("  alarmRuleTemplateBinding: ").Append(AlarmRuleTemplateBinding).Append("\n");
            sb.Append("  alarmTemplateSpecList: ").Append(AlarmTemplateSpecList).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  modifyTime: ").Append(ModifyTime).Append("\n");
            sb.Append("  templating: ").Append(Templating).Append("\n");
            sb.Append("  templateVersion: ").Append(TemplateVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmRuleTemplateBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmRuleTemplateBody input)
        {
            if (input == null) return false;
            if (this.AlarmRuleTemplateName != input.AlarmRuleTemplateName || (this.AlarmRuleTemplateName != null && !this.AlarmRuleTemplateName.Equals(input.AlarmRuleTemplateName))) return false;
            if (this.AlarmRuleTemplateNameEn != input.AlarmRuleTemplateNameEn || (this.AlarmRuleTemplateNameEn != null && !this.AlarmRuleTemplateNameEn.Equals(input.AlarmRuleTemplateNameEn))) return false;
            if (this.AlarmRuleTemplateDescription != input.AlarmRuleTemplateDescription || (this.AlarmRuleTemplateDescription != null && !this.AlarmRuleTemplateDescription.Equals(input.AlarmRuleTemplateDescription))) return false;
            if (this.AlarmRuleTemplateId != input.AlarmRuleTemplateId || (this.AlarmRuleTemplateId != null && !this.AlarmRuleTemplateId.Equals(input.AlarmRuleTemplateId))) return false;
            if (this.AlarmRuleTemplateProjectId != input.AlarmRuleTemplateProjectId || (this.AlarmRuleTemplateProjectId != null && !this.AlarmRuleTemplateProjectId.Equals(input.AlarmRuleTemplateProjectId))) return false;
            if (this.AlarmRuleTemplateType != input.AlarmRuleTemplateType || (this.AlarmRuleTemplateType != null && !this.AlarmRuleTemplateType.Equals(input.AlarmRuleTemplateType))) return false;
            if (this.AlarmRuleTemplateSource != input.AlarmRuleTemplateSource || (this.AlarmRuleTemplateSource != null && !this.AlarmRuleTemplateSource.Equals(input.AlarmRuleTemplateSource))) return false;
            if (this.AlarmRuleTemplateBinding != input.AlarmRuleTemplateBinding || (this.AlarmRuleTemplateBinding != null && input.AlarmRuleTemplateBinding != null && !this.AlarmRuleTemplateBinding.SequenceEqual(input.AlarmRuleTemplateBinding))) return false;
            if (this.AlarmTemplateSpecList != input.AlarmTemplateSpecList || (this.AlarmTemplateSpecList != null && input.AlarmTemplateSpecList != null && !this.AlarmTemplateSpecList.SequenceEqual(input.AlarmTemplateSpecList))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ModifyTime != input.ModifyTime || (this.ModifyTime != null && !this.ModifyTime.Equals(input.ModifyTime))) return false;
            if (this.Templating != input.Templating || (this.Templating != null && !this.Templating.Equals(input.Templating))) return false;
            if (this.TemplateVersion != input.TemplateVersion || (this.TemplateVersion != null && !this.TemplateVersion.Equals(input.TemplateVersion))) return false;

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
                if (this.AlarmRuleTemplateName != null) hashCode = hashCode * 59 + this.AlarmRuleTemplateName.GetHashCode();
                if (this.AlarmRuleTemplateNameEn != null) hashCode = hashCode * 59 + this.AlarmRuleTemplateNameEn.GetHashCode();
                if (this.AlarmRuleTemplateDescription != null) hashCode = hashCode * 59 + this.AlarmRuleTemplateDescription.GetHashCode();
                if (this.AlarmRuleTemplateId != null) hashCode = hashCode * 59 + this.AlarmRuleTemplateId.GetHashCode();
                if (this.AlarmRuleTemplateProjectId != null) hashCode = hashCode * 59 + this.AlarmRuleTemplateProjectId.GetHashCode();
                if (this.AlarmRuleTemplateType != null) hashCode = hashCode * 59 + this.AlarmRuleTemplateType.GetHashCode();
                if (this.AlarmRuleTemplateSource != null) hashCode = hashCode * 59 + this.AlarmRuleTemplateSource.GetHashCode();
                if (this.AlarmRuleTemplateBinding != null) hashCode = hashCode * 59 + this.AlarmRuleTemplateBinding.GetHashCode();
                if (this.AlarmTemplateSpecList != null) hashCode = hashCode * 59 + this.AlarmTemplateSpecList.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ModifyTime != null) hashCode = hashCode * 59 + this.ModifyTime.GetHashCode();
                if (this.Templating != null) hashCode = hashCode * 59 + this.Templating.GetHashCode();
                if (this.TemplateVersion != null) hashCode = hashCode * 59 + this.TemplateVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
