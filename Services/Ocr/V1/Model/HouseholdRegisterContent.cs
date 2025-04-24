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
    public class HouseholdRegisterContent 
    {

        /// <summary>
        /// 姓名。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 户主或与户主关系。 
        /// </summary>
        [JsonProperty("householder_relationship", NullValueHandling = NullValueHandling.Ignore)]
        public string HouseholderRelationship { get; set; }

        /// <summary>
        /// 曾用名。 
        /// </summary>
        [JsonProperty("former_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FormerName { get; set; }

        /// <summary>
        /// 性别。 
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 出生地。 
        /// </summary>
        [JsonProperty("birthplace", NullValueHandling = NullValueHandling.Ignore)]
        public string Birthplace { get; set; }

        /// <summary>
        /// 民族。 
        /// </summary>
        [JsonProperty("ethnicity", NullValueHandling = NullValueHandling.Ignore)]
        public string Ethnicity { get; set; }

        /// <summary>
        /// 籍贯。 
        /// </summary>
        [JsonProperty("origin_place", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginPlace { get; set; }

        /// <summary>
        /// 出生日期。 
        /// </summary>
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthDate { get; set; }

        /// <summary>
        /// 本市(县)其他住址。 
        /// </summary>
        [JsonProperty("other_address", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherAddress { get; set; }

        /// <summary>
        /// 宗教信仰。 
        /// </summary>
        [JsonProperty("religious_belief", NullValueHandling = NullValueHandling.Ignore)]
        public string ReligiousBelief { get; set; }

        /// <summary>
        /// 公民身份证件编号。 
        /// </summary>
        [JsonProperty("id_card_number", NullValueHandling = NullValueHandling.Ignore)]
        public string IdCardNumber { get; set; }

        /// <summary>
        /// 身高。 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public string Height { get; set; }

        /// <summary>
        /// 血型。 
        /// </summary>
        [JsonProperty("blood_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BloodType { get; set; }

        /// <summary>
        /// 文化程度。 
        /// </summary>
        [JsonProperty("education", NullValueHandling = NullValueHandling.Ignore)]
        public string Education { get; set; }

        /// <summary>
        /// 婚姻状况。 
        /// </summary>
        [JsonProperty("marital_status", NullValueHandling = NullValueHandling.Ignore)]
        public string MaritalStatus { get; set; }

        /// <summary>
        /// 兵役情况。 
        /// </summary>
        [JsonProperty("military_service_status", NullValueHandling = NullValueHandling.Ignore)]
        public string MilitaryServiceStatus { get; set; }

        /// <summary>
        /// 服务处所。 
        /// </summary>
        [JsonProperty("work_place", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkPlace { get; set; }

        /// <summary>
        /// 职业。 
        /// </summary>
        [JsonProperty("occupation", NullValueHandling = NullValueHandling.Ignore)]
        public string Occupation { get; set; }

        /// <summary>
        /// 何时由何地迁来本市(县)。 
        /// </summary>
        [JsonProperty("migrated_to_city", NullValueHandling = NullValueHandling.Ignore)]
        public string MigratedToCity { get; set; }

        /// <summary>
        /// 何时由何地迁来本址。 
        /// </summary>
        [JsonProperty("migrated_to_address", NullValueHandling = NullValueHandling.Ignore)]
        public string MigratedToAddress { get; set; }

        /// <summary>
        /// 承办人签章。 
        /// </summary>
        [JsonProperty("registrar_signature_seal", NullValueHandling = NullValueHandling.Ignore)]
        public string RegistrarSignatureSeal { get; set; }

        /// <summary>
        /// 登记日期。 
        /// </summary>
        [JsonProperty("registration_date", NullValueHandling = NullValueHandling.Ignore)]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// 户别。 
        /// </summary>
        [JsonProperty("household_type", NullValueHandling = NullValueHandling.Ignore)]
        public string HouseholdType { get; set; }

        /// <summary>
        /// 户号。 
        /// </summary>
        [JsonProperty("household_number", NullValueHandling = NullValueHandling.Ignore)]
        public string HouseholdNumber { get; set; }

        /// <summary>
        /// 户主姓名。当type参数为“首页”时，返回此参数。 
        /// </summary>
        [JsonProperty("householder_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HouseholderName { get; set; }

        /// <summary>
        /// 社区。当type参数为“首页”时，返回此参数。 
        /// </summary>
        [JsonProperty("community", NullValueHandling = NullValueHandling.Ignore)]
        public string Community { get; set; }

        /// <summary>
        /// 住址。当type参数为“首页”时，返回此参数。 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 签发日期。当type参数为“首页”时，返回此参数。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 户口登记机关。当type参数为“首页”时，返回此参数。 
        /// </summary>
        [JsonProperty("police_station", NullValueHandling = NullValueHandling.Ignore)]
        public string PoliceStation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HouseholdRegisterContent {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  householderRelationship: ").Append(HouseholderRelationship).Append("\n");
            sb.Append("  formerName: ").Append(FormerName).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  birthplace: ").Append(Birthplace).Append("\n");
            sb.Append("  ethnicity: ").Append(Ethnicity).Append("\n");
            sb.Append("  originPlace: ").Append(OriginPlace).Append("\n");
            sb.Append("  birthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  otherAddress: ").Append(OtherAddress).Append("\n");
            sb.Append("  religiousBelief: ").Append(ReligiousBelief).Append("\n");
            sb.Append("  idCardNumber: ").Append(IdCardNumber).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  bloodType: ").Append(BloodType).Append("\n");
            sb.Append("  education: ").Append(Education).Append("\n");
            sb.Append("  maritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  militaryServiceStatus: ").Append(MilitaryServiceStatus).Append("\n");
            sb.Append("  workPlace: ").Append(WorkPlace).Append("\n");
            sb.Append("  occupation: ").Append(Occupation).Append("\n");
            sb.Append("  migratedToCity: ").Append(MigratedToCity).Append("\n");
            sb.Append("  migratedToAddress: ").Append(MigratedToAddress).Append("\n");
            sb.Append("  registrarSignatureSeal: ").Append(RegistrarSignatureSeal).Append("\n");
            sb.Append("  registrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  householdType: ").Append(HouseholdType).Append("\n");
            sb.Append("  householdNumber: ").Append(HouseholdNumber).Append("\n");
            sb.Append("  householderName: ").Append(HouseholderName).Append("\n");
            sb.Append("  community: ").Append(Community).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  policeStation: ").Append(PoliceStation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HouseholdRegisterContent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HouseholdRegisterContent input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.HouseholderRelationship != input.HouseholderRelationship || (this.HouseholderRelationship != null && !this.HouseholderRelationship.Equals(input.HouseholderRelationship))) return false;
            if (this.FormerName != input.FormerName || (this.FormerName != null && !this.FormerName.Equals(input.FormerName))) return false;
            if (this.Sex != input.Sex || (this.Sex != null && !this.Sex.Equals(input.Sex))) return false;
            if (this.Birthplace != input.Birthplace || (this.Birthplace != null && !this.Birthplace.Equals(input.Birthplace))) return false;
            if (this.Ethnicity != input.Ethnicity || (this.Ethnicity != null && !this.Ethnicity.Equals(input.Ethnicity))) return false;
            if (this.OriginPlace != input.OriginPlace || (this.OriginPlace != null && !this.OriginPlace.Equals(input.OriginPlace))) return false;
            if (this.BirthDate != input.BirthDate || (this.BirthDate != null && !this.BirthDate.Equals(input.BirthDate))) return false;
            if (this.OtherAddress != input.OtherAddress || (this.OtherAddress != null && !this.OtherAddress.Equals(input.OtherAddress))) return false;
            if (this.ReligiousBelief != input.ReligiousBelief || (this.ReligiousBelief != null && !this.ReligiousBelief.Equals(input.ReligiousBelief))) return false;
            if (this.IdCardNumber != input.IdCardNumber || (this.IdCardNumber != null && !this.IdCardNumber.Equals(input.IdCardNumber))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.BloodType != input.BloodType || (this.BloodType != null && !this.BloodType.Equals(input.BloodType))) return false;
            if (this.Education != input.Education || (this.Education != null && !this.Education.Equals(input.Education))) return false;
            if (this.MaritalStatus != input.MaritalStatus || (this.MaritalStatus != null && !this.MaritalStatus.Equals(input.MaritalStatus))) return false;
            if (this.MilitaryServiceStatus != input.MilitaryServiceStatus || (this.MilitaryServiceStatus != null && !this.MilitaryServiceStatus.Equals(input.MilitaryServiceStatus))) return false;
            if (this.WorkPlace != input.WorkPlace || (this.WorkPlace != null && !this.WorkPlace.Equals(input.WorkPlace))) return false;
            if (this.Occupation != input.Occupation || (this.Occupation != null && !this.Occupation.Equals(input.Occupation))) return false;
            if (this.MigratedToCity != input.MigratedToCity || (this.MigratedToCity != null && !this.MigratedToCity.Equals(input.MigratedToCity))) return false;
            if (this.MigratedToAddress != input.MigratedToAddress || (this.MigratedToAddress != null && !this.MigratedToAddress.Equals(input.MigratedToAddress))) return false;
            if (this.RegistrarSignatureSeal != input.RegistrarSignatureSeal || (this.RegistrarSignatureSeal != null && !this.RegistrarSignatureSeal.Equals(input.RegistrarSignatureSeal))) return false;
            if (this.RegistrationDate != input.RegistrationDate || (this.RegistrationDate != null && !this.RegistrationDate.Equals(input.RegistrationDate))) return false;
            if (this.HouseholdType != input.HouseholdType || (this.HouseholdType != null && !this.HouseholdType.Equals(input.HouseholdType))) return false;
            if (this.HouseholdNumber != input.HouseholdNumber || (this.HouseholdNumber != null && !this.HouseholdNumber.Equals(input.HouseholdNumber))) return false;
            if (this.HouseholderName != input.HouseholderName || (this.HouseholderName != null && !this.HouseholderName.Equals(input.HouseholderName))) return false;
            if (this.Community != input.Community || (this.Community != null && !this.Community.Equals(input.Community))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.IssueDate != input.IssueDate || (this.IssueDate != null && !this.IssueDate.Equals(input.IssueDate))) return false;
            if (this.PoliceStation != input.PoliceStation || (this.PoliceStation != null && !this.PoliceStation.Equals(input.PoliceStation))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.HouseholderRelationship != null) hashCode = hashCode * 59 + this.HouseholderRelationship.GetHashCode();
                if (this.FormerName != null) hashCode = hashCode * 59 + this.FormerName.GetHashCode();
                if (this.Sex != null) hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.Birthplace != null) hashCode = hashCode * 59 + this.Birthplace.GetHashCode();
                if (this.Ethnicity != null) hashCode = hashCode * 59 + this.Ethnicity.GetHashCode();
                if (this.OriginPlace != null) hashCode = hashCode * 59 + this.OriginPlace.GetHashCode();
                if (this.BirthDate != null) hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.OtherAddress != null) hashCode = hashCode * 59 + this.OtherAddress.GetHashCode();
                if (this.ReligiousBelief != null) hashCode = hashCode * 59 + this.ReligiousBelief.GetHashCode();
                if (this.IdCardNumber != null) hashCode = hashCode * 59 + this.IdCardNumber.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.BloodType != null) hashCode = hashCode * 59 + this.BloodType.GetHashCode();
                if (this.Education != null) hashCode = hashCode * 59 + this.Education.GetHashCode();
                if (this.MaritalStatus != null) hashCode = hashCode * 59 + this.MaritalStatus.GetHashCode();
                if (this.MilitaryServiceStatus != null) hashCode = hashCode * 59 + this.MilitaryServiceStatus.GetHashCode();
                if (this.WorkPlace != null) hashCode = hashCode * 59 + this.WorkPlace.GetHashCode();
                if (this.Occupation != null) hashCode = hashCode * 59 + this.Occupation.GetHashCode();
                if (this.MigratedToCity != null) hashCode = hashCode * 59 + this.MigratedToCity.GetHashCode();
                if (this.MigratedToAddress != null) hashCode = hashCode * 59 + this.MigratedToAddress.GetHashCode();
                if (this.RegistrarSignatureSeal != null) hashCode = hashCode * 59 + this.RegistrarSignatureSeal.GetHashCode();
                if (this.RegistrationDate != null) hashCode = hashCode * 59 + this.RegistrationDate.GetHashCode();
                if (this.HouseholdType != null) hashCode = hashCode * 59 + this.HouseholdType.GetHashCode();
                if (this.HouseholdNumber != null) hashCode = hashCode * 59 + this.HouseholdNumber.GetHashCode();
                if (this.HouseholderName != null) hashCode = hashCode * 59 + this.HouseholderName.GetHashCode();
                if (this.Community != null) hashCode = hashCode * 59 + this.Community.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.IssueDate != null) hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.PoliceStation != null) hashCode = hashCode * 59 + this.PoliceStation.GetHashCode();
                return hashCode;
            }
        }
    }
}
