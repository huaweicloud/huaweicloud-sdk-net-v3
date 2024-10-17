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
    public class MyanmarDriverLicenseConfidence 
    {

        /// <summary>
        /// 缅文驾驶证号置信度。 
        /// </summary>
        [JsonProperty("card_number", NullValueHandling = NullValueHandling.Ignore)]
        public float? CardNumber { get; set; }

        /// <summary>
        /// 英文驾驶证号置信度。 
        /// </summary>
        [JsonProperty("card_number_en", NullValueHandling = NullValueHandling.Ignore)]
        public float? CardNumberEn { get; set; }

        /// <summary>
        /// 缅文名字置信度。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public float? Name { get; set; }

        /// <summary>
        /// 英文名字置信度。 
        /// </summary>
        [JsonProperty("name_en", NullValueHandling = NullValueHandling.Ignore)]
        public float? NameEn { get; set; }

        /// <summary>
        /// 缅文nrc号码置信度。 
        /// </summary>
        [JsonProperty("nrc_id", NullValueHandling = NullValueHandling.Ignore)]
        public float? NrcId { get; set; }

        /// <summary>
        /// 英文nrc号码置信度。 
        /// </summary>
        [JsonProperty("nrc_id_en", NullValueHandling = NullValueHandling.Ignore)]
        public float? NrcIdEn { get; set; }

        /// <summary>
        /// 缅文出生日期置信度。 
        /// </summary>
        [JsonProperty("birth", NullValueHandling = NullValueHandling.Ignore)]
        public float? Birth { get; set; }

        /// <summary>
        /// 英文出生日期置信度。 
        /// </summary>
        [JsonProperty("birth_en", NullValueHandling = NullValueHandling.Ignore)]
        public float? BirthEn { get; set; }

        /// <summary>
        /// 缅文血型置信度。 
        /// </summary>
        [JsonProperty("blood_group", NullValueHandling = NullValueHandling.Ignore)]
        public float? BloodGroup { get; set; }

        /// <summary>
        /// 英文血型置信度。 
        /// </summary>
        [JsonProperty("blood_group_en", NullValueHandling = NullValueHandling.Ignore)]
        public float? BloodGroupEn { get; set; }

        /// <summary>
        /// 缅文有效期置信度。 
        /// </summary>
        [JsonProperty("expiried_date", NullValueHandling = NullValueHandling.Ignore)]
        public float? ExpiriedDate { get; set; }

        /// <summary>
        /// 英文有效期置信度。 
        /// </summary>
        [JsonProperty("expiried_date_en", NullValueHandling = NullValueHandling.Ignore)]
        public float? ExpiriedDateEn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MyanmarDriverLicenseConfidence {\n");
            sb.Append("  cardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  cardNumberEn: ").Append(CardNumberEn).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  nrcId: ").Append(NrcId).Append("\n");
            sb.Append("  nrcIdEn: ").Append(NrcIdEn).Append("\n");
            sb.Append("  birth: ").Append(Birth).Append("\n");
            sb.Append("  birthEn: ").Append(BirthEn).Append("\n");
            sb.Append("  bloodGroup: ").Append(BloodGroup).Append("\n");
            sb.Append("  bloodGroupEn: ").Append(BloodGroupEn).Append("\n");
            sb.Append("  expiriedDate: ").Append(ExpiriedDate).Append("\n");
            sb.Append("  expiriedDateEn: ").Append(ExpiriedDateEn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MyanmarDriverLicenseConfidence);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MyanmarDriverLicenseConfidence input)
        {
            if (input == null) return false;
            if (this.CardNumber != input.CardNumber || (this.CardNumber != null && !this.CardNumber.Equals(input.CardNumber))) return false;
            if (this.CardNumberEn != input.CardNumberEn || (this.CardNumberEn != null && !this.CardNumberEn.Equals(input.CardNumberEn))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NameEn != input.NameEn || (this.NameEn != null && !this.NameEn.Equals(input.NameEn))) return false;
            if (this.NrcId != input.NrcId || (this.NrcId != null && !this.NrcId.Equals(input.NrcId))) return false;
            if (this.NrcIdEn != input.NrcIdEn || (this.NrcIdEn != null && !this.NrcIdEn.Equals(input.NrcIdEn))) return false;
            if (this.Birth != input.Birth || (this.Birth != null && !this.Birth.Equals(input.Birth))) return false;
            if (this.BirthEn != input.BirthEn || (this.BirthEn != null && !this.BirthEn.Equals(input.BirthEn))) return false;
            if (this.BloodGroup != input.BloodGroup || (this.BloodGroup != null && !this.BloodGroup.Equals(input.BloodGroup))) return false;
            if (this.BloodGroupEn != input.BloodGroupEn || (this.BloodGroupEn != null && !this.BloodGroupEn.Equals(input.BloodGroupEn))) return false;
            if (this.ExpiriedDate != input.ExpiriedDate || (this.ExpiriedDate != null && !this.ExpiriedDate.Equals(input.ExpiriedDate))) return false;
            if (this.ExpiriedDateEn != input.ExpiriedDateEn || (this.ExpiriedDateEn != null && !this.ExpiriedDateEn.Equals(input.ExpiriedDateEn))) return false;

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
                if (this.CardNumber != null) hashCode = hashCode * 59 + this.CardNumber.GetHashCode();
                if (this.CardNumberEn != null) hashCode = hashCode * 59 + this.CardNumberEn.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameEn != null) hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                if (this.NrcId != null) hashCode = hashCode * 59 + this.NrcId.GetHashCode();
                if (this.NrcIdEn != null) hashCode = hashCode * 59 + this.NrcIdEn.GetHashCode();
                if (this.Birth != null) hashCode = hashCode * 59 + this.Birth.GetHashCode();
                if (this.BirthEn != null) hashCode = hashCode * 59 + this.BirthEn.GetHashCode();
                if (this.BloodGroup != null) hashCode = hashCode * 59 + this.BloodGroup.GetHashCode();
                if (this.BloodGroupEn != null) hashCode = hashCode * 59 + this.BloodGroupEn.GetHashCode();
                if (this.ExpiriedDate != null) hashCode = hashCode * 59 + this.ExpiriedDate.GetHashCode();
                if (this.ExpiriedDateEn != null) hashCode = hashCode * 59 + this.ExpiriedDateEn.GetHashCode();
                return hashCode;
            }
        }
    }
}
