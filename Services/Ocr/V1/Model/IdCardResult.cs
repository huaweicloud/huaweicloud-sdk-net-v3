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
    public class IdCardResult 
    {

        /// <summary>
        /// 姓名。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 性别。 
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 出生日期。 
        /// </summary>
        [JsonProperty("birth", NullValueHandling = NullValueHandling.Ignore)]
        public string Birth { get; set; }

        /// <summary>
        /// 民族。 
        /// </summary>
        [JsonProperty("ethnicity", NullValueHandling = NullValueHandling.Ignore)]
        public string Ethnicity { get; set; }

        /// <summary>
        /// 地址。 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 身份证号。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 发证机关。 
        /// </summary>
        [JsonProperty("issue", NullValueHandling = NullValueHandling.Ignore)]
        public string Issue { get; set; }

        /// <summary>
        /// 有效起始日期。 
        /// </summary>
        [JsonProperty("valid_from", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidFrom { get; set; }

        /// <summary>
        /// 有效结束日期。   &gt; 说明：  - 身份证识别只支持中国大陆汉族身份证识别。 
        /// </summary>
        [JsonProperty("valid_to", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("verification_result", NullValueHandling = NullValueHandling.Ignore)]
        public IdcardVerificationResult VerificationResult { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdCardResult {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  birth: ").Append(Birth).Append("\n");
            sb.Append("  ethnicity: ").Append(Ethnicity).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  issue: ").Append(Issue).Append("\n");
            sb.Append("  validFrom: ").Append(ValidFrom).Append("\n");
            sb.Append("  validTo: ").Append(ValidTo).Append("\n");
            sb.Append("  verificationResult: ").Append(VerificationResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdCardResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdCardResult input)
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
                    this.Sex == input.Sex ||
                    (this.Sex != null &&
                    this.Sex.Equals(input.Sex))
                ) && 
                (
                    this.Birth == input.Birth ||
                    (this.Birth != null &&
                    this.Birth.Equals(input.Birth))
                ) && 
                (
                    this.Ethnicity == input.Ethnicity ||
                    (this.Ethnicity != null &&
                    this.Ethnicity.Equals(input.Ethnicity))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Issue == input.Issue ||
                    (this.Issue != null &&
                    this.Issue.Equals(input.Issue))
                ) && 
                (
                    this.ValidFrom == input.ValidFrom ||
                    (this.ValidFrom != null &&
                    this.ValidFrom.Equals(input.ValidFrom))
                ) && 
                (
                    this.ValidTo == input.ValidTo ||
                    (this.ValidTo != null &&
                    this.ValidTo.Equals(input.ValidTo))
                ) && 
                (
                    this.VerificationResult == input.VerificationResult ||
                    (this.VerificationResult != null &&
                    this.VerificationResult.Equals(input.VerificationResult))
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
                if (this.Sex != null)
                    hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.Birth != null)
                    hashCode = hashCode * 59 + this.Birth.GetHashCode();
                if (this.Ethnicity != null)
                    hashCode = hashCode * 59 + this.Ethnicity.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Issue != null)
                    hashCode = hashCode * 59 + this.Issue.GetHashCode();
                if (this.ValidFrom != null)
                    hashCode = hashCode * 59 + this.ValidFrom.GetHashCode();
                if (this.ValidTo != null)
                    hashCode = hashCode * 59 + this.ValidTo.GetHashCode();
                if (this.VerificationResult != null)
                    hashCode = hashCode * 59 + this.VerificationResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
