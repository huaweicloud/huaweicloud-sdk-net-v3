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
    public class ChileIdCardConfidence 
    {

        /// <summary>
        /// 姓氏置信度。 
        /// </summary>
        [JsonProperty("surname", NullValueHandling = NullValueHandling.Ignore)]
        public float? Surname { get; set; }

        /// <summary>
        /// 名置信度。 
        /// </summary>
        [JsonProperty("given_name", NullValueHandling = NullValueHandling.Ignore)]
        public float? GivenName { get; set; }

        /// <summary>
        /// 国籍置信度。 
        /// </summary>
        [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
        public float? Nationality { get; set; }

        /// <summary>
        /// 性别置信度。 
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public float? Sex { get; set; }

        /// <summary>
        /// 出生日置信度。 
        /// </summary>
        [JsonProperty("birth", NullValueHandling = NullValueHandling.Ignore)]
        public float? Birth { get; set; }

        /// <summary>
        /// 发行日置信度。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public float? IssueDate { get; set; }

        /// <summary>
        /// 有效期置信度。 
        /// </summary>
        [JsonProperty("expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        public float? ExpiryDate { get; set; }

        /// <summary>
        /// 文档编号置信度。 
        /// </summary>
        [JsonProperty("document_number", NullValueHandling = NullValueHandling.Ignore)]
        public float? DocumentNumber { get; set; }

        /// <summary>
        /// 身份证号置信度。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public float? Number { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChileIdCardConfidence {\n");
            sb.Append("  surname: ").Append(Surname).Append("\n");
            sb.Append("  givenName: ").Append(GivenName).Append("\n");
            sb.Append("  nationality: ").Append(Nationality).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  birth: ").Append(Birth).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  expiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  documentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChileIdCardConfidence);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChileIdCardConfidence input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.GivenName == input.GivenName ||
                    (this.GivenName != null &&
                    this.GivenName.Equals(input.GivenName))
                ) && 
                (
                    this.Nationality == input.Nationality ||
                    (this.Nationality != null &&
                    this.Nationality.Equals(input.Nationality))
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
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.DocumentNumber == input.DocumentNumber ||
                    (this.DocumentNumber != null &&
                    this.DocumentNumber.Equals(input.DocumentNumber))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
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
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.GivenName != null)
                    hashCode = hashCode * 59 + this.GivenName.GetHashCode();
                if (this.Nationality != null)
                    hashCode = hashCode * 59 + this.Nationality.GetHashCode();
                if (this.Sex != null)
                    hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.Birth != null)
                    hashCode = hashCode * 59 + this.Birth.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.DocumentNumber != null)
                    hashCode = hashCode * 59 + this.DocumentNumber.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                return hashCode;
            }
        }
    }
}
