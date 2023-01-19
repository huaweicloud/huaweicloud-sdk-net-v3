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
    public class MainlandTravelPermitConfidence 
    {

        /// <summary>
        /// 中文姓名的置信度。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public float? Name { get; set; }

        /// <summary>
        /// 英文姓名的置信度。 
        /// </summary>
        [JsonProperty("name_en", NullValueHandling = NullValueHandling.Ignore)]
        public float? NameEn { get; set; }

        /// <summary>
        /// 出生日期的置信度。 
        /// </summary>
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public float? BirthDate { get; set; }

        /// <summary>
        /// 性别的置信度。 
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public float? Sex { get; set; }

        /// <summary>
        /// 有效期限的置信度。 
        /// </summary>
        [JsonProperty("valid_period", NullValueHandling = NullValueHandling.Ignore)]
        public float? ValidPeriod { get; set; }

        /// <summary>
        /// 签发机关的置信度。 
        /// </summary>
        [JsonProperty("issuing_authority", NullValueHandling = NullValueHandling.Ignore)]
        public float? IssuingAuthority { get; set; }

        /// <summary>
        /// 证件号的置信度。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public float? Number { get; set; }

        /// <summary>
        /// 签发地点的置信度。 
        /// </summary>
        [JsonProperty("issue_place", NullValueHandling = NullValueHandling.Ignore)]
        public float? IssuePlace { get; set; }

        /// <summary>
        /// 签发次数的置信度。 
        /// </summary>
        [JsonProperty("issue_times", NullValueHandling = NullValueHandling.Ignore)]
        public float? IssueTimes { get; set; }

        /// <summary>
        /// 证件类别的置信度。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public float? Type { get; set; }

        /// <summary>
        /// 证件图片正反面信息的置信度。 
        /// </summary>
        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public float? Side { get; set; }

        /// <summary>
        /// 回乡证背面的香港/澳门/台湾身份证姓名的置信度。 
        /// </summary>
        [JsonProperty("id_name", NullValueHandling = NullValueHandling.Ignore)]
        public float? IdName { get; set; }

        /// <summary>
        /// 回乡证背面的香港/澳门/台湾身份证号码的置信度。 
        /// </summary>
        [JsonProperty("id_number", NullValueHandling = NullValueHandling.Ignore)]
        public float? IdNumber { get; set; }

        /// <summary>
        /// 机读码第一行的置信度。 
        /// </summary>
        [JsonProperty("machine_code1", NullValueHandling = NullValueHandling.Ignore)]
        public float? MachineCode1 { get; set; }

        /// <summary>
        /// 机读码第二行的置信度。 
        /// </summary>
        [JsonProperty("machine_code2", NullValueHandling = NullValueHandling.Ignore)]
        public float? MachineCode2 { get; set; }

        /// <summary>
        /// 机读码第三行的置信度。 
        /// </summary>
        [JsonProperty("machine_code3", NullValueHandling = NullValueHandling.Ignore)]
        public float? MachineCode3 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MainlandTravelPermitConfidence {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  birthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  validPeriod: ").Append(ValidPeriod).Append("\n");
            sb.Append("  issuingAuthority: ").Append(IssuingAuthority).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  issuePlace: ").Append(IssuePlace).Append("\n");
            sb.Append("  issueTimes: ").Append(IssueTimes).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  side: ").Append(Side).Append("\n");
            sb.Append("  idName: ").Append(IdName).Append("\n");
            sb.Append("  idNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  machineCode1: ").Append(MachineCode1).Append("\n");
            sb.Append("  machineCode2: ").Append(MachineCode2).Append("\n");
            sb.Append("  machineCode3: ").Append(MachineCode3).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MainlandTravelPermitConfidence);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MainlandTravelPermitConfidence input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NameEn == input.NameEn ||
                    (this.NameEn != null &&
                    this.NameEn.Equals(input.NameEn))
                ) && 
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
                (
                    this.Sex == input.Sex ||
                    (this.Sex != null &&
                    this.Sex.Equals(input.Sex))
                ) && 
                (
                    this.ValidPeriod == input.ValidPeriod ||
                    (this.ValidPeriod != null &&
                    this.ValidPeriod.Equals(input.ValidPeriod))
                ) && 
                (
                    this.IssuingAuthority == input.IssuingAuthority ||
                    (this.IssuingAuthority != null &&
                    this.IssuingAuthority.Equals(input.IssuingAuthority))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.IssuePlace == input.IssuePlace ||
                    (this.IssuePlace != null &&
                    this.IssuePlace.Equals(input.IssuePlace))
                ) && 
                (
                    this.IssueTimes == input.IssueTimes ||
                    (this.IssueTimes != null &&
                    this.IssueTimes.Equals(input.IssueTimes))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.IdName == input.IdName ||
                    (this.IdName != null &&
                    this.IdName.Equals(input.IdName))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.MachineCode1 == input.MachineCode1 ||
                    (this.MachineCode1 != null &&
                    this.MachineCode1.Equals(input.MachineCode1))
                ) && 
                (
                    this.MachineCode2 == input.MachineCode2 ||
                    (this.MachineCode2 != null &&
                    this.MachineCode2.Equals(input.MachineCode2))
                ) && 
                (
                    this.MachineCode3 == input.MachineCode3 ||
                    (this.MachineCode3 != null &&
                    this.MachineCode3.Equals(input.MachineCode3))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameEn != null)
                    hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.Sex != null)
                    hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.ValidPeriod != null)
                    hashCode = hashCode * 59 + this.ValidPeriod.GetHashCode();
                if (this.IssuingAuthority != null)
                    hashCode = hashCode * 59 + this.IssuingAuthority.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.IssuePlace != null)
                    hashCode = hashCode * 59 + this.IssuePlace.GetHashCode();
                if (this.IssueTimes != null)
                    hashCode = hashCode * 59 + this.IssueTimes.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.IdName != null)
                    hashCode = hashCode * 59 + this.IdName.GetHashCode();
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.MachineCode1 != null)
                    hashCode = hashCode * 59 + this.MachineCode1.GetHashCode();
                if (this.MachineCode2 != null)
                    hashCode = hashCode * 59 + this.MachineCode2.GetHashCode();
                if (this.MachineCode3 != null)
                    hashCode = hashCode * 59 + this.MachineCode3.GetHashCode();
                return hashCode;
            }
        }
    }
}
