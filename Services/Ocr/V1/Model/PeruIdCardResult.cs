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
    public class PeruIdCardResult 
    {

        /// <summary>
        /// 身份证号。
        /// </summary>
        [JsonProperty("cui_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CuiNumber { get; set; }

        /// <summary>
        /// 第一姓氏。
        /// </summary>
        [JsonProperty("first_surname", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstSurname { get; set; }

        /// <summary>
        /// 第二姓氏。
        /// </summary>
        [JsonProperty("second_surname", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondSurname { get; set; }

        /// <summary>
        /// 名。
        /// </summary>
        [JsonProperty("given_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GivenName { get; set; }

        /// <summary>
        /// 性别。
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 婚姻状况。
        /// </summary>
        [JsonProperty("marital_status", NullValueHandling = NullValueHandling.Ignore)]
        public string MaritalStatus { get; set; }

        /// <summary>
        /// 出生日期。
        /// </summary>
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthDate { get; set; }

        /// <summary>
        /// 国籍。
        /// </summary>
        [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
        public string Nationality { get; set; }

        /// <summary>
        /// 发行日期。
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 失效日期。
        /// </summary>
        [JsonProperty("expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// 出生地编码。
        /// </summary>
        [JsonProperty("birth_place", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthPlace { get; set; }

        /// <summary>
        /// 投票组。
        /// </summary>
        [JsonProperty("voting_group", NullValueHandling = NullValueHandling.Ignore)]
        public string VotingGroup { get; set; }

        /// <summary>
        /// 器官捐赠意愿。
        /// </summary>
        [JsonProperty("organ_donation", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganDonation { get; set; }

        /// <summary>
        /// 注册日期。
        /// </summary>
        [JsonProperty("registration_date", NullValueHandling = NullValueHandling.Ignore)]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// 头像的base64编码。当输入参数“return_portrait_image”为“true”时，才返回该参数。
        /// </summary>
        [JsonProperty("portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public string PortraitImage { get; set; }

        /// <summary>
        /// 头像在原图上的位置。 当输入参数“return_portrait_location”为“true”时，才返回该参数。以列表形式显示，包含头像区域四个顶点的二维坐标（x,y），坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("portrait_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> PortraitLocation { get; set; }

        /// <summary>
        /// 地址。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 大区。
        /// </summary>
        [JsonProperty("department", NullValueHandling = NullValueHandling.Ignore)]
        public string Department { get; set; }

        /// <summary>
        /// 省。
        /// </summary>
        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }

        /// <summary>
        /// 区。
        /// </summary>
        [JsonProperty("district", NullValueHandling = NullValueHandling.Ignore)]
        public string District { get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        public string Remarks { get; set; }

        /// <summary>
        /// 机器码第一行。
        /// </summary>
        [JsonProperty("machine_code1", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineCode1 { get; set; }

        /// <summary>
        /// 机器码第二行。
        /// </summary>
        [JsonProperty("machine_code2", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineCode2 { get; set; }

        /// <summary>
        /// 机器码第三行。
        /// </summary>
        [JsonProperty("machine_code3", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineCode3 { get; set; }

        /// <summary>
        /// 是否重新登记过。可选值如下所示： -  true: 已重新登记过 -  false: 未重新登记过 
        /// </summary>
        [JsonProperty("duplicate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Duplicate { get; set; }

        /// <summary>
        /// 相关字段的置信度信息，置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。注：置信度由算法给出，不直接等价于对应字段的准确率。
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, float?> Confidence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeruIdCardResult {\n");
            sb.Append("  cuiNumber: ").Append(CuiNumber).Append("\n");
            sb.Append("  firstSurname: ").Append(FirstSurname).Append("\n");
            sb.Append("  secondSurname: ").Append(SecondSurname).Append("\n");
            sb.Append("  givenName: ").Append(GivenName).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  maritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  birthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  nationality: ").Append(Nationality).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  expiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  birthPlace: ").Append(BirthPlace).Append("\n");
            sb.Append("  votingGroup: ").Append(VotingGroup).Append("\n");
            sb.Append("  organDonation: ").Append(OrganDonation).Append("\n");
            sb.Append("  registrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  portraitImage: ").Append(PortraitImage).Append("\n");
            sb.Append("  portraitLocation: ").Append(PortraitLocation).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  department: ").Append(Department).Append("\n");
            sb.Append("  province: ").Append(Province).Append("\n");
            sb.Append("  district: ").Append(District).Append("\n");
            sb.Append("  remarks: ").Append(Remarks).Append("\n");
            sb.Append("  machineCode1: ").Append(MachineCode1).Append("\n");
            sb.Append("  machineCode2: ").Append(MachineCode2).Append("\n");
            sb.Append("  machineCode3: ").Append(MachineCode3).Append("\n");
            sb.Append("  duplicate: ").Append(Duplicate).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PeruIdCardResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PeruIdCardResult input)
        {
            if (input == null) return false;
            if (this.CuiNumber != input.CuiNumber || (this.CuiNumber != null && !this.CuiNumber.Equals(input.CuiNumber))) return false;
            if (this.FirstSurname != input.FirstSurname || (this.FirstSurname != null && !this.FirstSurname.Equals(input.FirstSurname))) return false;
            if (this.SecondSurname != input.SecondSurname || (this.SecondSurname != null && !this.SecondSurname.Equals(input.SecondSurname))) return false;
            if (this.GivenName != input.GivenName || (this.GivenName != null && !this.GivenName.Equals(input.GivenName))) return false;
            if (this.Sex != input.Sex || (this.Sex != null && !this.Sex.Equals(input.Sex))) return false;
            if (this.MaritalStatus != input.MaritalStatus || (this.MaritalStatus != null && !this.MaritalStatus.Equals(input.MaritalStatus))) return false;
            if (this.BirthDate != input.BirthDate || (this.BirthDate != null && !this.BirthDate.Equals(input.BirthDate))) return false;
            if (this.Nationality != input.Nationality || (this.Nationality != null && !this.Nationality.Equals(input.Nationality))) return false;
            if (this.IssueDate != input.IssueDate || (this.IssueDate != null && !this.IssueDate.Equals(input.IssueDate))) return false;
            if (this.ExpiryDate != input.ExpiryDate || (this.ExpiryDate != null && !this.ExpiryDate.Equals(input.ExpiryDate))) return false;
            if (this.BirthPlace != input.BirthPlace || (this.BirthPlace != null && !this.BirthPlace.Equals(input.BirthPlace))) return false;
            if (this.VotingGroup != input.VotingGroup || (this.VotingGroup != null && !this.VotingGroup.Equals(input.VotingGroup))) return false;
            if (this.OrganDonation != input.OrganDonation || (this.OrganDonation != null && !this.OrganDonation.Equals(input.OrganDonation))) return false;
            if (this.RegistrationDate != input.RegistrationDate || (this.RegistrationDate != null && !this.RegistrationDate.Equals(input.RegistrationDate))) return false;
            if (this.PortraitImage != input.PortraitImage || (this.PortraitImage != null && !this.PortraitImage.Equals(input.PortraitImage))) return false;
            if (this.PortraitLocation != input.PortraitLocation || (this.PortraitLocation != null && input.PortraitLocation != null && !this.PortraitLocation.SequenceEqual(input.PortraitLocation))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.Department != input.Department || (this.Department != null && !this.Department.Equals(input.Department))) return false;
            if (this.Province != input.Province || (this.Province != null && !this.Province.Equals(input.Province))) return false;
            if (this.District != input.District || (this.District != null && !this.District.Equals(input.District))) return false;
            if (this.Remarks != input.Remarks || (this.Remarks != null && !this.Remarks.Equals(input.Remarks))) return false;
            if (this.MachineCode1 != input.MachineCode1 || (this.MachineCode1 != null && !this.MachineCode1.Equals(input.MachineCode1))) return false;
            if (this.MachineCode2 != input.MachineCode2 || (this.MachineCode2 != null && !this.MachineCode2.Equals(input.MachineCode2))) return false;
            if (this.MachineCode3 != input.MachineCode3 || (this.MachineCode3 != null && !this.MachineCode3.Equals(input.MachineCode3))) return false;
            if (this.Duplicate != input.Duplicate || (this.Duplicate != null && !this.Duplicate.Equals(input.Duplicate))) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && input.Confidence != null && !this.Confidence.SequenceEqual(input.Confidence))) return false;

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
                if (this.CuiNumber != null) hashCode = hashCode * 59 + this.CuiNumber.GetHashCode();
                if (this.FirstSurname != null) hashCode = hashCode * 59 + this.FirstSurname.GetHashCode();
                if (this.SecondSurname != null) hashCode = hashCode * 59 + this.SecondSurname.GetHashCode();
                if (this.GivenName != null) hashCode = hashCode * 59 + this.GivenName.GetHashCode();
                if (this.Sex != null) hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.MaritalStatus != null) hashCode = hashCode * 59 + this.MaritalStatus.GetHashCode();
                if (this.BirthDate != null) hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.Nationality != null) hashCode = hashCode * 59 + this.Nationality.GetHashCode();
                if (this.IssueDate != null) hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.ExpiryDate != null) hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.BirthPlace != null) hashCode = hashCode * 59 + this.BirthPlace.GetHashCode();
                if (this.VotingGroup != null) hashCode = hashCode * 59 + this.VotingGroup.GetHashCode();
                if (this.OrganDonation != null) hashCode = hashCode * 59 + this.OrganDonation.GetHashCode();
                if (this.RegistrationDate != null) hashCode = hashCode * 59 + this.RegistrationDate.GetHashCode();
                if (this.PortraitImage != null) hashCode = hashCode * 59 + this.PortraitImage.GetHashCode();
                if (this.PortraitLocation != null) hashCode = hashCode * 59 + this.PortraitLocation.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Department != null) hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Province != null) hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.District != null) hashCode = hashCode * 59 + this.District.GetHashCode();
                if (this.Remarks != null) hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.MachineCode1 != null) hashCode = hashCode * 59 + this.MachineCode1.GetHashCode();
                if (this.MachineCode2 != null) hashCode = hashCode * 59 + this.MachineCode2.GetHashCode();
                if (this.MachineCode3 != null) hashCode = hashCode * 59 + this.MachineCode3.GetHashCode();
                if (this.Duplicate != null) hashCode = hashCode * 59 + this.Duplicate.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
