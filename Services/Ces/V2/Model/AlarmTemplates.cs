using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AlarmTemplates 
    {

        /// <summary>
        /// 告警模板的ID，以at开头，后跟字母、数字，长度最长为64
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 告警模板的名称，以字母或汉字开头，可包含字母、数字、汉字、_、-，长度范围[1,128]
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("template_type", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateType TemplateType { get; set; }
        /// <summary>
        /// 告警模板的创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 告警模板的描述，长度范围[0,256]，该字段默认值为空字符串
        /// </summary>
        [JsonProperty("template_description", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateDescription { get; set; }

        /// <summary>
        /// 告警模板关联的告警规则数目
        /// </summary>
        [JsonProperty("association_alarm_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssociationAlarmTotal { get; set; }

        /// <summary>
        /// 告警模板的告警策略总数
        /// </summary>
        [JsonProperty("policy_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyTotal { get; set; }

        /// <summary>
        /// 服务列表告警策略数目统计
        /// </summary>
        [JsonProperty("policy_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyStatistics> PolicyStatistics { get; set; }

        /// <summary>
        /// 关联的资源分组
        /// </summary>
        [JsonProperty("association_resource_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssociationResourceGroup> AssociationResourceGroups { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmTemplates {\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  templateType: ").Append(TemplateType).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  templateDescription: ").Append(TemplateDescription).Append("\n");
            sb.Append("  associationAlarmTotal: ").Append(AssociationAlarmTotal).Append("\n");
            sb.Append("  policyTotal: ").Append(PolicyTotal).Append("\n");
            sb.Append("  policyStatistics: ").Append(PolicyStatistics).Append("\n");
            sb.Append("  associationResourceGroups: ").Append(AssociationResourceGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmTemplates);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmTemplates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.TemplateType == input.TemplateType ||
                    (this.TemplateType != null &&
                    this.TemplateType.Equals(input.TemplateType))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.TemplateDescription == input.TemplateDescription ||
                    (this.TemplateDescription != null &&
                    this.TemplateDescription.Equals(input.TemplateDescription))
                ) && 
                (
                    this.AssociationAlarmTotal == input.AssociationAlarmTotal ||
                    (this.AssociationAlarmTotal != null &&
                    this.AssociationAlarmTotal.Equals(input.AssociationAlarmTotal))
                ) && 
                (
                    this.PolicyTotal == input.PolicyTotal ||
                    (this.PolicyTotal != null &&
                    this.PolicyTotal.Equals(input.PolicyTotal))
                ) && 
                (
                    this.PolicyStatistics == input.PolicyStatistics ||
                    this.PolicyStatistics != null &&
                    input.PolicyStatistics != null &&
                    this.PolicyStatistics.SequenceEqual(input.PolicyStatistics)
                ) && 
                (
                    this.AssociationResourceGroups == input.AssociationResourceGroups ||
                    this.AssociationResourceGroups != null &&
                    input.AssociationResourceGroups != null &&
                    this.AssociationResourceGroups.SequenceEqual(input.AssociationResourceGroups)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.TemplateName != null)
                    hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.TemplateType != null)
                    hashCode = hashCode * 59 + this.TemplateType.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.TemplateDescription != null)
                    hashCode = hashCode * 59 + this.TemplateDescription.GetHashCode();
                if (this.AssociationAlarmTotal != null)
                    hashCode = hashCode * 59 + this.AssociationAlarmTotal.GetHashCode();
                if (this.PolicyTotal != null)
                    hashCode = hashCode * 59 + this.PolicyTotal.GetHashCode();
                if (this.PolicyStatistics != null)
                    hashCode = hashCode * 59 + this.PolicyStatistics.GetHashCode();
                if (this.AssociationResourceGroups != null)
                    hashCode = hashCode * 59 + this.AssociationResourceGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
