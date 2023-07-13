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
    public class QualificationCategory 
    {

        /// <summary>
        /// 诚信考核信息（非必有，依赖对应从业资格证板式）。 
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 初次领证日期（非必有，依赖对应从业资格证板式） 
        /// </summary>
        [JsonProperty("initial_issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string InitialIssueDate { get; set; }

        /// <summary>
        /// 有效起始日期（非必有，依赖对应从业资格证板式） 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 有效期至 
        /// </summary>
        [JsonProperty("expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualificationCategory {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  initialIssueDate: ").Append(InitialIssueDate).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  expiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QualificationCategory);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QualificationCategory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.InitialIssueDate == input.InitialIssueDate ||
                    (this.InitialIssueDate != null &&
                    this.InitialIssueDate.Equals(input.InitialIssueDate))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.InitialIssueDate != null)
                    hashCode = hashCode * 59 + this.InitialIssueDate.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
