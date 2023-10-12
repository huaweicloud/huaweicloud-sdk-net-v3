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
    public class ColombiaIdCardResult 
    {

        /// <summary>
        /// 证件图片正反面信息。可选值包括： - front: 证件图片正面 - back:  证件图片反面
        /// </summary>
        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public string Side { get; set; }

        /// <summary>
        /// 卡证编号。当响应字段\&quot;side\&quot;为front时，返回此字段。
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 名。当响应字段\&quot;side\&quot;为front时，返回此字段。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 姓。当响应字段\&quot;side\&quot;为front时，返回此字段。
        /// </summary>
        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// 出生日期。
        /// </summary>
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthDate { get; set; }

        /// <summary>
        /// 出生地。
        /// </summary>
        [JsonProperty("birth_place", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthPlace { get; set; }

        /// <summary>
        /// 性别。
        /// </summary>
        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public string Gender { get; set; }

        /// <summary>
        /// 血型。
        /// </summary>
        [JsonProperty("blood_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BloodType { get; set; }

        /// <summary>
        /// 签发日期。
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 签发地区。
        /// </summary>
        [JsonProperty("issue_authority", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueAuthority { get; set; }

        /// <summary>
        /// 身高。
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public string Height { get; set; }

        /// <summary>
        /// 公民编码一。
        /// </summary>
        [JsonProperty("citizen_code1", NullValueHandling = NullValueHandling.Ignore)]
        public string CitizenCode1 { get; set; }

        /// <summary>
        /// 公民编码二。
        /// </summary>
        [JsonProperty("citizen_code2", NullValueHandling = NullValueHandling.Ignore)]
        public string CitizenCode2 { get; set; }

        /// <summary>
        /// 公民编码三。
        /// </summary>
        [JsonProperty("citizen_code3", NullValueHandling = NullValueHandling.Ignore)]
        public string CitizenCode3 { get; set; }

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
            sb.Append("class ColombiaIdCardResult {\n");
            sb.Append("  side: ").Append(Side).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  lastName: ").Append(LastName).Append("\n");
            sb.Append("  birthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  birthPlace: ").Append(BirthPlace).Append("\n");
            sb.Append("  gender: ").Append(Gender).Append("\n");
            sb.Append("  bloodType: ").Append(BloodType).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  issueAuthority: ").Append(IssueAuthority).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  citizenCode1: ").Append(CitizenCode1).Append("\n");
            sb.Append("  citizenCode2: ").Append(CitizenCode2).Append("\n");
            sb.Append("  citizenCode3: ").Append(CitizenCode3).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ColombiaIdCardResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ColombiaIdCardResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
                (
                    this.BirthPlace == input.BirthPlace ||
                    (this.BirthPlace != null &&
                    this.BirthPlace.Equals(input.BirthPlace))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.BloodType == input.BloodType ||
                    (this.BloodType != null &&
                    this.BloodType.Equals(input.BloodType))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.IssueAuthority == input.IssueAuthority ||
                    (this.IssueAuthority != null &&
                    this.IssueAuthority.Equals(input.IssueAuthority))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.CitizenCode1 == input.CitizenCode1 ||
                    (this.CitizenCode1 != null &&
                    this.CitizenCode1.Equals(input.CitizenCode1))
                ) && 
                (
                    this.CitizenCode2 == input.CitizenCode2 ||
                    (this.CitizenCode2 != null &&
                    this.CitizenCode2.Equals(input.CitizenCode2))
                ) && 
                (
                    this.CitizenCode3 == input.CitizenCode3 ||
                    (this.CitizenCode3 != null &&
                    this.CitizenCode3.Equals(input.CitizenCode3))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    this.Confidence != null &&
                    input.Confidence != null &&
                    this.Confidence.SequenceEqual(input.Confidence)
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
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.BirthPlace != null)
                    hashCode = hashCode * 59 + this.BirthPlace.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.BloodType != null)
                    hashCode = hashCode * 59 + this.BloodType.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.IssueAuthority != null)
                    hashCode = hashCode * 59 + this.IssueAuthority.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.CitizenCode1 != null)
                    hashCode = hashCode * 59 + this.CitizenCode1.GetHashCode();
                if (this.CitizenCode2 != null)
                    hashCode = hashCode * 59 + this.CitizenCode2.GetHashCode();
                if (this.CitizenCode3 != null)
                    hashCode = hashCode * 59 + this.CitizenCode3.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
