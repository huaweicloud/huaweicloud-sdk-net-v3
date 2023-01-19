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
    public class QualificationConfidence 
    {

        /// <summary>
        /// 身份证号置信度。 
        /// </summary>
        [JsonProperty("id_number", NullValueHandling = NullValueHandling.Ignore)]
        public float? IdNumber { get; set; }

        /// <summary>
        /// 考核时间置信度。 
        /// </summary>
        [JsonProperty("assessment_date", NullValueHandling = NullValueHandling.Ignore)]
        public float? AssessmentDate { get; set; }

        /// <summary>
        /// 从业资格证号置信度。 
        /// </summary>
        [JsonProperty("certificate_number", NullValueHandling = NullValueHandling.Ignore)]
        public float? CertificateNumber { get; set; }

        /// <summary>
        /// 档案号置信度。 
        /// </summary>
        [JsonProperty("file_number", NullValueHandling = NullValueHandling.Ignore)]
        public float? FileNumber { get; set; }

        /// <summary>
        /// 福路通号置信度。 
        /// </summary>
        [JsonProperty("union_card_number", NullValueHandling = NullValueHandling.Ignore)]
        public float? UnionCardNumber { get; set; }

        /// <summary>
        /// 继续教育信息置信度。 
        /// </summary>
        [JsonProperty("continuing_education_info", NullValueHandling = NullValueHandling.Ignore)]
        public float? ContinuingEducationInfo { get; set; }

        /// <summary>
        /// 性别置信度。 
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public float? Sex { get; set; }

        /// <summary>
        /// 联系电话置信度。 
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public float? PhoneNumber { get; set; }

        /// <summary>
        /// 登记时间置信度。 
        /// </summary>
        [JsonProperty("registration_date", NullValueHandling = NullValueHandling.Ignore)]
        public float? RegistrationDate { get; set; }

        /// <summary>
        /// 单位置信度。 
        /// </summary>
        [JsonProperty("work_unit", NullValueHandling = NullValueHandling.Ignore)]
        public float? WorkUnit { get; set; }

        /// <summary>
        /// 诚信考核信息置信度。 
        /// </summary>
        [JsonProperty("integrity_assessment_info", NullValueHandling = NullValueHandling.Ignore)]
        public float? IntegrityAssessmentInfo { get; set; }

        /// <summary>
        /// 国籍置信度。 
        /// </summary>
        [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
        public float? Nationality { get; set; }

        /// <summary>
        /// 姓名置信度。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public float? Name { get; set; }

        /// <summary>
        /// 住址置信度。 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public float? Address { get; set; }

        /// <summary>
        /// 准驾车型置信度。 
        /// </summary>
        [JsonProperty("driving_class", NullValueHandling = NullValueHandling.Ignore)]
        public float? DrivingClass { get; set; }

        /// <summary>
        /// 发证机关置信度。 
        /// </summary>
        [JsonProperty("issuing_authority", NullValueHandling = NullValueHandling.Ignore)]
        public float? IssuingAuthority { get; set; }

        /// <summary>
        /// 出生日期置信度。 
        /// </summary>
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public float? BirthDate { get; set; }

        /// <summary>
        /// 从业资格列表置信度。 
        /// </summary>
        [JsonProperty("qualification_category_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<QualificationCategoryConfidence> QualificationCategoryList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualificationConfidence {\n");
            sb.Append("  idNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  assessmentDate: ").Append(AssessmentDate).Append("\n");
            sb.Append("  certificateNumber: ").Append(CertificateNumber).Append("\n");
            sb.Append("  fileNumber: ").Append(FileNumber).Append("\n");
            sb.Append("  unionCardNumber: ").Append(UnionCardNumber).Append("\n");
            sb.Append("  continuingEducationInfo: ").Append(ContinuingEducationInfo).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  phoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  registrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  workUnit: ").Append(WorkUnit).Append("\n");
            sb.Append("  integrityAssessmentInfo: ").Append(IntegrityAssessmentInfo).Append("\n");
            sb.Append("  nationality: ").Append(Nationality).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  drivingClass: ").Append(DrivingClass).Append("\n");
            sb.Append("  issuingAuthority: ").Append(IssuingAuthority).Append("\n");
            sb.Append("  birthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  qualificationCategoryList: ").Append(QualificationCategoryList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QualificationConfidence);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QualificationConfidence input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.AssessmentDate == input.AssessmentDate ||
                    (this.AssessmentDate != null &&
                    this.AssessmentDate.Equals(input.AssessmentDate))
                ) && 
                (
                    this.CertificateNumber == input.CertificateNumber ||
                    (this.CertificateNumber != null &&
                    this.CertificateNumber.Equals(input.CertificateNumber))
                ) && 
                (
                    this.FileNumber == input.FileNumber ||
                    (this.FileNumber != null &&
                    this.FileNumber.Equals(input.FileNumber))
                ) && 
                (
                    this.UnionCardNumber == input.UnionCardNumber ||
                    (this.UnionCardNumber != null &&
                    this.UnionCardNumber.Equals(input.UnionCardNumber))
                ) && 
                (
                    this.ContinuingEducationInfo == input.ContinuingEducationInfo ||
                    (this.ContinuingEducationInfo != null &&
                    this.ContinuingEducationInfo.Equals(input.ContinuingEducationInfo))
                ) && 
                (
                    this.Sex == input.Sex ||
                    (this.Sex != null &&
                    this.Sex.Equals(input.Sex))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.RegistrationDate == input.RegistrationDate ||
                    (this.RegistrationDate != null &&
                    this.RegistrationDate.Equals(input.RegistrationDate))
                ) && 
                (
                    this.WorkUnit == input.WorkUnit ||
                    (this.WorkUnit != null &&
                    this.WorkUnit.Equals(input.WorkUnit))
                ) && 
                (
                    this.IntegrityAssessmentInfo == input.IntegrityAssessmentInfo ||
                    (this.IntegrityAssessmentInfo != null &&
                    this.IntegrityAssessmentInfo.Equals(input.IntegrityAssessmentInfo))
                ) && 
                (
                    this.Nationality == input.Nationality ||
                    (this.Nationality != null &&
                    this.Nationality.Equals(input.Nationality))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.DrivingClass == input.DrivingClass ||
                    (this.DrivingClass != null &&
                    this.DrivingClass.Equals(input.DrivingClass))
                ) && 
                (
                    this.IssuingAuthority == input.IssuingAuthority ||
                    (this.IssuingAuthority != null &&
                    this.IssuingAuthority.Equals(input.IssuingAuthority))
                ) && 
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
                (
                    this.QualificationCategoryList == input.QualificationCategoryList ||
                    this.QualificationCategoryList != null &&
                    input.QualificationCategoryList != null &&
                    this.QualificationCategoryList.SequenceEqual(input.QualificationCategoryList)
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
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.AssessmentDate != null)
                    hashCode = hashCode * 59 + this.AssessmentDate.GetHashCode();
                if (this.CertificateNumber != null)
                    hashCode = hashCode * 59 + this.CertificateNumber.GetHashCode();
                if (this.FileNumber != null)
                    hashCode = hashCode * 59 + this.FileNumber.GetHashCode();
                if (this.UnionCardNumber != null)
                    hashCode = hashCode * 59 + this.UnionCardNumber.GetHashCode();
                if (this.ContinuingEducationInfo != null)
                    hashCode = hashCode * 59 + this.ContinuingEducationInfo.GetHashCode();
                if (this.Sex != null)
                    hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.RegistrationDate != null)
                    hashCode = hashCode * 59 + this.RegistrationDate.GetHashCode();
                if (this.WorkUnit != null)
                    hashCode = hashCode * 59 + this.WorkUnit.GetHashCode();
                if (this.IntegrityAssessmentInfo != null)
                    hashCode = hashCode * 59 + this.IntegrityAssessmentInfo.GetHashCode();
                if (this.Nationality != null)
                    hashCode = hashCode * 59 + this.Nationality.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.DrivingClass != null)
                    hashCode = hashCode * 59 + this.DrivingClass.GetHashCode();
                if (this.IssuingAuthority != null)
                    hashCode = hashCode * 59 + this.IssuingAuthority.GetHashCode();
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.QualificationCategoryList != null)
                    hashCode = hashCode * 59 + this.QualificationCategoryList.GetHashCode();
                return hashCode;
            }
        }
    }
}
