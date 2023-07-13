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
    public class ExitEntryPermitConfidence 
    {

        /// <summary>
        /// 姓名的置信度。 
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
        /// 性别的置信度 
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public float? Sex { get; set; }

        /// <summary>
        /// 证件号的置信度。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public float? Number { get; set; }

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
        /// 签发地点的置信度。 
        /// </summary>
        [JsonProperty("issue_place", NullValueHandling = NullValueHandling.Ignore)]
        public float? IssuePlace { get; set; }

        /// <summary>
        /// 机器码的置信度。 
        /// </summary>
        [JsonProperty("machine_code", NullValueHandling = NullValueHandling.Ignore)]
        public float? MachineCode { get; set; }

        /// <summary>
        /// 证件类型的置信度。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public float? Type { get; set; }

        /// <summary>
        /// 证件图片正反面信息的置信度。 
        /// </summary>
        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public float? Side { get; set; }

        /// <summary>
        /// 香港签注信息的置信度。 
        /// </summary>
        [JsonProperty("endorsement_info_hk", NullValueHandling = NullValueHandling.Ignore)]
        public Object EndorsementInfoHk { get; set; }

        /// <summary>
        /// 澳门签注信息的置信度。 
        /// </summary>
        [JsonProperty("endorsement_info_mo", NullValueHandling = NullValueHandling.Ignore)]
        public Object EndorsementInfoMo { get; set; }

        /// <summary>
        /// 台湾签注信息的置信度。 
        /// </summary>
        [JsonProperty("endorsement_info_tw", NullValueHandling = NullValueHandling.Ignore)]
        public Object EndorsementInfoTw { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExitEntryPermitConfidence {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  birthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  validPeriod: ").Append(ValidPeriod).Append("\n");
            sb.Append("  issuingAuthority: ").Append(IssuingAuthority).Append("\n");
            sb.Append("  issuePlace: ").Append(IssuePlace).Append("\n");
            sb.Append("  machineCode: ").Append(MachineCode).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  side: ").Append(Side).Append("\n");
            sb.Append("  endorsementInfoHk: ").Append(EndorsementInfoHk).Append("\n");
            sb.Append("  endorsementInfoMo: ").Append(EndorsementInfoMo).Append("\n");
            sb.Append("  endorsementInfoTw: ").Append(EndorsementInfoTw).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExitEntryPermitConfidence);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExitEntryPermitConfidence input)
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
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
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
                    this.IssuePlace == input.IssuePlace ||
                    (this.IssuePlace != null &&
                    this.IssuePlace.Equals(input.IssuePlace))
                ) && 
                (
                    this.MachineCode == input.MachineCode ||
                    (this.MachineCode != null &&
                    this.MachineCode.Equals(input.MachineCode))
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
                    this.EndorsementInfoHk == input.EndorsementInfoHk ||
                    (this.EndorsementInfoHk != null &&
                    this.EndorsementInfoHk.Equals(input.EndorsementInfoHk))
                ) && 
                (
                    this.EndorsementInfoMo == input.EndorsementInfoMo ||
                    (this.EndorsementInfoMo != null &&
                    this.EndorsementInfoMo.Equals(input.EndorsementInfoMo))
                ) && 
                (
                    this.EndorsementInfoTw == input.EndorsementInfoTw ||
                    (this.EndorsementInfoTw != null &&
                    this.EndorsementInfoTw.Equals(input.EndorsementInfoTw))
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
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.ValidPeriod != null)
                    hashCode = hashCode * 59 + this.ValidPeriod.GetHashCode();
                if (this.IssuingAuthority != null)
                    hashCode = hashCode * 59 + this.IssuingAuthority.GetHashCode();
                if (this.IssuePlace != null)
                    hashCode = hashCode * 59 + this.IssuePlace.GetHashCode();
                if (this.MachineCode != null)
                    hashCode = hashCode * 59 + this.MachineCode.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.EndorsementInfoHk != null)
                    hashCode = hashCode * 59 + this.EndorsementInfoHk.GetHashCode();
                if (this.EndorsementInfoMo != null)
                    hashCode = hashCode * 59 + this.EndorsementInfoMo.GetHashCode();
                if (this.EndorsementInfoTw != null)
                    hashCode = hashCode * 59 + this.EndorsementInfoTw.GetHashCode();
                return hashCode;
            }
        }
    }
}
