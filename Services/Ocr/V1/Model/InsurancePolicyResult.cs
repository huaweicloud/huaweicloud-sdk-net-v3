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
    public class InsurancePolicyResult 
    {

        /// <summary>
        /// 发卡行。 
        /// </summary>
        [JsonProperty("bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bill_number", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail BillNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("effective_date", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail EffectiveDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("applicant_name", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail ApplicantName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("applicant_sex", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail ApplicantSex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("applicant_birthday", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail ApplicantBirthday { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("applicant_id_type", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail ApplicantIdType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("applicant_id_number", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail ApplicantIdNumber { get; set; }

        /// <summary>
        /// 被保人列表（第一个默认为主被保人）。 
        /// </summary>
        [JsonProperty("insurant_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<InsurantItem> InsurantList { get; set; }

        /// <summary>
        /// 受益人列表。 
        /// </summary>
        [JsonProperty("beneficiary_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<BeneficiaryItem> BeneficiaryList { get; set; }

        /// <summary>
        /// 保险项目信息列表。 
        /// </summary>
        [JsonProperty("insurance_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<InsuranceItem> InsuranceList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsurancePolicyResult {\n");
            sb.Append("  bankName: ").Append(BankName).Append("\n");
            sb.Append("  billNumber: ").Append(BillNumber).Append("\n");
            sb.Append("  company: ").Append(Company).Append("\n");
            sb.Append("  effectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  applicantName: ").Append(ApplicantName).Append("\n");
            sb.Append("  applicantSex: ").Append(ApplicantSex).Append("\n");
            sb.Append("  applicantBirthday: ").Append(ApplicantBirthday).Append("\n");
            sb.Append("  applicantIdType: ").Append(ApplicantIdType).Append("\n");
            sb.Append("  applicantIdNumber: ").Append(ApplicantIdNumber).Append("\n");
            sb.Append("  insurantList: ").Append(InsurantList).Append("\n");
            sb.Append("  beneficiaryList: ").Append(BeneficiaryList).Append("\n");
            sb.Append("  insuranceList: ").Append(InsuranceList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InsurancePolicyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InsurancePolicyResult input)
        {
            if (input == null) return false;
            if (this.BankName != input.BankName || (this.BankName != null && !this.BankName.Equals(input.BankName))) return false;
            if (this.BillNumber != input.BillNumber || (this.BillNumber != null && !this.BillNumber.Equals(input.BillNumber))) return false;
            if (this.Company != input.Company || (this.Company != null && !this.Company.Equals(input.Company))) return false;
            if (this.EffectiveDate != input.EffectiveDate || (this.EffectiveDate != null && !this.EffectiveDate.Equals(input.EffectiveDate))) return false;
            if (this.ApplicantName != input.ApplicantName || (this.ApplicantName != null && !this.ApplicantName.Equals(input.ApplicantName))) return false;
            if (this.ApplicantSex != input.ApplicantSex || (this.ApplicantSex != null && !this.ApplicantSex.Equals(input.ApplicantSex))) return false;
            if (this.ApplicantBirthday != input.ApplicantBirthday || (this.ApplicantBirthday != null && !this.ApplicantBirthday.Equals(input.ApplicantBirthday))) return false;
            if (this.ApplicantIdType != input.ApplicantIdType || (this.ApplicantIdType != null && !this.ApplicantIdType.Equals(input.ApplicantIdType))) return false;
            if (this.ApplicantIdNumber != input.ApplicantIdNumber || (this.ApplicantIdNumber != null && !this.ApplicantIdNumber.Equals(input.ApplicantIdNumber))) return false;
            if (this.InsurantList != input.InsurantList || (this.InsurantList != null && input.InsurantList != null && !this.InsurantList.SequenceEqual(input.InsurantList))) return false;
            if (this.BeneficiaryList != input.BeneficiaryList || (this.BeneficiaryList != null && input.BeneficiaryList != null && !this.BeneficiaryList.SequenceEqual(input.BeneficiaryList))) return false;
            if (this.InsuranceList != input.InsuranceList || (this.InsuranceList != null && input.InsuranceList != null && !this.InsuranceList.SequenceEqual(input.InsuranceList))) return false;

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
                if (this.BankName != null) hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.BillNumber != null) hashCode = hashCode * 59 + this.BillNumber.GetHashCode();
                if (this.Company != null) hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.EffectiveDate != null) hashCode = hashCode * 59 + this.EffectiveDate.GetHashCode();
                if (this.ApplicantName != null) hashCode = hashCode * 59 + this.ApplicantName.GetHashCode();
                if (this.ApplicantSex != null) hashCode = hashCode * 59 + this.ApplicantSex.GetHashCode();
                if (this.ApplicantBirthday != null) hashCode = hashCode * 59 + this.ApplicantBirthday.GetHashCode();
                if (this.ApplicantIdType != null) hashCode = hashCode * 59 + this.ApplicantIdType.GetHashCode();
                if (this.ApplicantIdNumber != null) hashCode = hashCode * 59 + this.ApplicantIdNumber.GetHashCode();
                if (this.InsurantList != null) hashCode = hashCode * 59 + this.InsurantList.GetHashCode();
                if (this.BeneficiaryList != null) hashCode = hashCode * 59 + this.BeneficiaryList.GetHashCode();
                if (this.InsuranceList != null) hashCode = hashCode * 59 + this.InsuranceList.GetHashCode();
                return hashCode;
            }
        }
    }
}
