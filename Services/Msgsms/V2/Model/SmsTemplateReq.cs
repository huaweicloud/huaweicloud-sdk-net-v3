using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Msgsms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SmsTemplateReq 
    {

        /// <summary>
        /// 应用主键ID
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 中括号类型。支持枚举值： 1. CN: 中文类型 2. GB: 英文类型
        /// </summary>
        [JsonProperty("brackets", NullValueHandling = NullValueHandling.Ignore)]
        public string Brackets { get; set; }

        /// <summary>
        /// 地域 1. cn：国内 2. intl：
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 发送国家id列表，只有地域为国际时，该字段有效
        /// </summary>
        [JsonProperty("send_country", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> SendCountry { get; set; }

        /// <summary>
        /// 签名主键ID，只有地域为国内时，该字段有效
        /// </summary>
        [JsonProperty("sign_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SignId { get; set; }

        /// <summary>
        /// 模板内容
        /// </summary>
        [JsonProperty("template_content", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// 模板描述
        /// </summary>
        [JsonProperty("template_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateDesc { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板类型。只有地域为国内时，该字段有效。支持枚举值： 1. VERIFY_CODE_TYPE: 验证码类 2. PROMOTION_TYPE: 推广类 3. NOTIFY_TYPE: 通知类
        /// </summary>
        [JsonProperty("template_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateType { get; set; }

        /// <summary>
        /// 是否为通用模板 1. 0: 非通用模板 2. 1: 通用模板
        /// </summary>
        [JsonProperty("universal_template", NullValueHandling = NullValueHandling.Ignore)]
        public int? UniversalTemplate { get; set; }

        /// <summary>
        /// 模板参数
        /// </summary>
        [JsonProperty("variable_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<SmsTemplateVariableAttrReq> VariableAttributes { get; set; }

        /// <summary>
        /// 流程状态 1. Pending: 待提交 2. Reviewing: 待审核 3. Disable：停用
        /// </summary>
        [JsonProperty("flow_status", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsTemplateReq {\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  brackets: ").Append(Brackets).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  sendCountry: ").Append(SendCountry).Append("\n");
            sb.Append("  signId: ").Append(SignId).Append("\n");
            sb.Append("  templateContent: ").Append(TemplateContent).Append("\n");
            sb.Append("  templateDesc: ").Append(TemplateDesc).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  templateType: ").Append(TemplateType).Append("\n");
            sb.Append("  universalTemplate: ").Append(UniversalTemplate).Append("\n");
            sb.Append("  variableAttributes: ").Append(VariableAttributes).Append("\n");
            sb.Append("  flowStatus: ").Append(FlowStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmsTemplateReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmsTemplateReq input)
        {
            if (input == null) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.Brackets != input.Brackets || (this.Brackets != null && !this.Brackets.Equals(input.Brackets))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.SendCountry != input.SendCountry || (this.SendCountry != null && input.SendCountry != null && !this.SendCountry.SequenceEqual(input.SendCountry))) return false;
            if (this.SignId != input.SignId || (this.SignId != null && !this.SignId.Equals(input.SignId))) return false;
            if (this.TemplateContent != input.TemplateContent || (this.TemplateContent != null && !this.TemplateContent.Equals(input.TemplateContent))) return false;
            if (this.TemplateDesc != input.TemplateDesc || (this.TemplateDesc != null && !this.TemplateDesc.Equals(input.TemplateDesc))) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.TemplateType != input.TemplateType || (this.TemplateType != null && !this.TemplateType.Equals(input.TemplateType))) return false;
            if (this.UniversalTemplate != input.UniversalTemplate || (this.UniversalTemplate != null && !this.UniversalTemplate.Equals(input.UniversalTemplate))) return false;
            if (this.VariableAttributes != input.VariableAttributes || (this.VariableAttributes != null && input.VariableAttributes != null && !this.VariableAttributes.SequenceEqual(input.VariableAttributes))) return false;
            if (this.FlowStatus != input.FlowStatus || (this.FlowStatus != null && !this.FlowStatus.Equals(input.FlowStatus))) return false;

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
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Brackets != null) hashCode = hashCode * 59 + this.Brackets.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.SendCountry != null) hashCode = hashCode * 59 + this.SendCountry.GetHashCode();
                if (this.SignId != null) hashCode = hashCode * 59 + this.SignId.GetHashCode();
                if (this.TemplateContent != null) hashCode = hashCode * 59 + this.TemplateContent.GetHashCode();
                if (this.TemplateDesc != null) hashCode = hashCode * 59 + this.TemplateDesc.GetHashCode();
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.TemplateType != null) hashCode = hashCode * 59 + this.TemplateType.GetHashCode();
                if (this.UniversalTemplate != null) hashCode = hashCode * 59 + this.UniversalTemplate.GetHashCode();
                if (this.VariableAttributes != null) hashCode = hashCode * 59 + this.VariableAttributes.GetHashCode();
                if (this.FlowStatus != null) hashCode = hashCode * 59 + this.FlowStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
