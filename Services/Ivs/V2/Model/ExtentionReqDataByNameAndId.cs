using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ivs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExtentionReqDataByNameAndId 
    {

        /// <summary>
        /// 被验证人的姓名。
        /// </summary>
        [JsonProperty("verification_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationName { get; set; }

        /// <summary>
        /// 被验证人的身份证号码。
        /// </summary>
        [JsonProperty("verification_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtentionReqDataByNameAndId {\n");
            sb.Append("  verificationName: ").Append(VerificationName).Append("\n");
            sb.Append("  verificationId: ").Append(VerificationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtentionReqDataByNameAndId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtentionReqDataByNameAndId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VerificationName == input.VerificationName ||
                    (this.VerificationName != null &&
                    this.VerificationName.Equals(input.VerificationName))
                ) && 
                (
                    this.VerificationId == input.VerificationId ||
                    (this.VerificationId != null &&
                    this.VerificationId.Equals(input.VerificationId))
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
                if (this.VerificationName != null)
                    hashCode = hashCode * 59 + this.VerificationName.GetHashCode();
                if (this.VerificationId != null)
                    hashCode = hashCode * 59 + this.VerificationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
