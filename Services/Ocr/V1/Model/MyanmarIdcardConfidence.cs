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
    public class MyanmarIdcardConfidence 
    {

        /// <summary>
        /// 身份证号码置信度。 
        /// </summary>
        [JsonProperty("nrc_id", NullValueHandling = NullValueHandling.Ignore)]
        public float? NrcId { get; set; }

        /// <summary>
        /// 签发日期置信度。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public float? IssueDate { get; set; }

        /// <summary>
        /// 姓名置信度。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public float? Name { get; set; }

        /// <summary>
        /// 出生日期置信度。 
        /// </summary>
        [JsonProperty("birth", NullValueHandling = NullValueHandling.Ignore)]
        public float? Birth { get; set; }

        /// <summary>
        /// 族群或宗教置信度。 
        /// </summary>
        [JsonProperty("bloodlines_religion", NullValueHandling = NullValueHandling.Ignore)]
        public float? BloodlinesReligion { get; set; }

        /// <summary>
        /// 身高置信度。 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public float? Height { get; set; }

        /// <summary>
        /// 血型置信度。 
        /// </summary>
        [JsonProperty("blood_group", NullValueHandling = NullValueHandling.Ignore)]
        public float? BloodGroup { get; set; }

        /// <summary>
        /// 身份证的卡号（背面）置信度。 
        /// </summary>
        [JsonProperty("card_id", NullValueHandling = NullValueHandling.Ignore)]
        public float? CardId { get; set; }

        /// <summary>
        /// 背面的身份证号码。 
        /// </summary>
        [JsonProperty("nrc_id_back", NullValueHandling = NullValueHandling.Ignore)]
        public float? NrcIdBack { get; set; }

        /// <summary>
        /// 职业置信度。 
        /// </summary>
        [JsonProperty("profession", NullValueHandling = NullValueHandling.Ignore)]
        public float? Profession { get; set; }

        /// <summary>
        /// 地址置信度。 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public float? Address { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MyanmarIdcardConfidence {\n");
            sb.Append("  nrcId: ").Append(NrcId).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  birth: ").Append(Birth).Append("\n");
            sb.Append("  bloodlinesReligion: ").Append(BloodlinesReligion).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  bloodGroup: ").Append(BloodGroup).Append("\n");
            sb.Append("  cardId: ").Append(CardId).Append("\n");
            sb.Append("  nrcIdBack: ").Append(NrcIdBack).Append("\n");
            sb.Append("  profession: ").Append(Profession).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MyanmarIdcardConfidence);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MyanmarIdcardConfidence input)
        {
            if (input == null) return false;
            if (this.NrcId != input.NrcId || (this.NrcId != null && !this.NrcId.Equals(input.NrcId))) return false;
            if (this.IssueDate != input.IssueDate || (this.IssueDate != null && !this.IssueDate.Equals(input.IssueDate))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Birth != input.Birth || (this.Birth != null && !this.Birth.Equals(input.Birth))) return false;
            if (this.BloodlinesReligion != input.BloodlinesReligion || (this.BloodlinesReligion != null && !this.BloodlinesReligion.Equals(input.BloodlinesReligion))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.BloodGroup != input.BloodGroup || (this.BloodGroup != null && !this.BloodGroup.Equals(input.BloodGroup))) return false;
            if (this.CardId != input.CardId || (this.CardId != null && !this.CardId.Equals(input.CardId))) return false;
            if (this.NrcIdBack != input.NrcIdBack || (this.NrcIdBack != null && !this.NrcIdBack.Equals(input.NrcIdBack))) return false;
            if (this.Profession != input.Profession || (this.Profession != null && !this.Profession.Equals(input.Profession))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;

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
                if (this.NrcId != null) hashCode = hashCode * 59 + this.NrcId.GetHashCode();
                if (this.IssueDate != null) hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Birth != null) hashCode = hashCode * 59 + this.Birth.GetHashCode();
                if (this.BloodlinesReligion != null) hashCode = hashCode * 59 + this.BloodlinesReligion.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.BloodGroup != null) hashCode = hashCode * 59 + this.BloodGroup.GetHashCode();
                if (this.CardId != null) hashCode = hashCode * 59 + this.CardId.GetHashCode();
                if (this.NrcIdBack != null) hashCode = hashCode * 59 + this.NrcIdBack.GetHashCode();
                if (this.Profession != null) hashCode = hashCode * 59 + this.Profession.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                return hashCode;
            }
        }
    }
}
