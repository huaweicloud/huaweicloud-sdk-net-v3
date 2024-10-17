using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BusinessLicenseResult 
    {

        /// <summary>
        /// - 老版本营业执照对应注册号。 - 新三证合一版本营业执照对应社会保障号。 
        /// </summary>
        [JsonProperty("registration_number", NullValueHandling = NullValueHandling.Ignore)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// 企业名称。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 公司/企业类型/主体类型/类型。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 住所/营业场所/企业住所/主要经营场所/经营场所。 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 法定代表人/负责人/执行事务合伙人/投资人/经营者。 
        /// </summary>
        [JsonProperty("legal_representative", NullValueHandling = NullValueHandling.Ignore)]
        public string LegalRepresentative { get; set; }

        /// <summary>
        /// 注册资本/出资额。 
        /// </summary>
        [JsonProperty("registered_capital", NullValueHandling = NullValueHandling.Ignore)]
        public string RegisteredCapital { get; set; }

        /// <summary>
        /// 组成形式。 
        /// </summary>
        [JsonProperty("organization_form", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationForm { get; set; }

        /// <summary>
        /// 成立日期/注册日期。 
        /// </summary>
        [JsonProperty("found_date", NullValueHandling = NullValueHandling.Ignore)]
        public string FoundDate { get; set; }

        /// <summary>
        /// 营业期限。 
        /// </summary>
        [JsonProperty("business_term", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessTerm { get; set; }

        /// <summary>
        /// 经营范围。 
        /// </summary>
        [JsonProperty("business_scope", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessScope { get; set; }

        /// <summary>
        /// 发照日期。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 相关字段的置信度信息，置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。 置信度由算法给出，不直接等价于对应字段的准确率。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLicenseResult {\n");
            sb.Append("  registrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  legalRepresentative: ").Append(LegalRepresentative).Append("\n");
            sb.Append("  registeredCapital: ").Append(RegisteredCapital).Append("\n");
            sb.Append("  organizationForm: ").Append(OrganizationForm).Append("\n");
            sb.Append("  foundDate: ").Append(FoundDate).Append("\n");
            sb.Append("  businessTerm: ").Append(BusinessTerm).Append("\n");
            sb.Append("  businessScope: ").Append(BusinessScope).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BusinessLicenseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BusinessLicenseResult input)
        {
            if (input == null) return false;
            if (this.RegistrationNumber != input.RegistrationNumber || (this.RegistrationNumber != null && !this.RegistrationNumber.Equals(input.RegistrationNumber))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.LegalRepresentative != input.LegalRepresentative || (this.LegalRepresentative != null && !this.LegalRepresentative.Equals(input.LegalRepresentative))) return false;
            if (this.RegisteredCapital != input.RegisteredCapital || (this.RegisteredCapital != null && !this.RegisteredCapital.Equals(input.RegisteredCapital))) return false;
            if (this.OrganizationForm != input.OrganizationForm || (this.OrganizationForm != null && !this.OrganizationForm.Equals(input.OrganizationForm))) return false;
            if (this.FoundDate != input.FoundDate || (this.FoundDate != null && !this.FoundDate.Equals(input.FoundDate))) return false;
            if (this.BusinessTerm != input.BusinessTerm || (this.BusinessTerm != null && !this.BusinessTerm.Equals(input.BusinessTerm))) return false;
            if (this.BusinessScope != input.BusinessScope || (this.BusinessScope != null && !this.BusinessScope.Equals(input.BusinessScope))) return false;
            if (this.IssueDate != input.IssueDate || (this.IssueDate != null && !this.IssueDate.Equals(input.IssueDate))) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;

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
                if (this.RegistrationNumber != null) hashCode = hashCode * 59 + this.RegistrationNumber.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.LegalRepresentative != null) hashCode = hashCode * 59 + this.LegalRepresentative.GetHashCode();
                if (this.RegisteredCapital != null) hashCode = hashCode * 59 + this.RegisteredCapital.GetHashCode();
                if (this.OrganizationForm != null) hashCode = hashCode * 59 + this.OrganizationForm.GetHashCode();
                if (this.FoundDate != null) hashCode = hashCode * 59 + this.FoundDate.GetHashCode();
                if (this.BusinessTerm != null) hashCode = hashCode * 59 + this.BusinessTerm.GetHashCode();
                if (this.BusinessScope != null) hashCode = hashCode * 59 + this.BusinessScope.GetHashCode();
                if (this.IssueDate != null) hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
