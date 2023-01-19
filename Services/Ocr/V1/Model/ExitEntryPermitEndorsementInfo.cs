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
    public class ExitEntryPermitEndorsementInfo 
    {

        /// <summary>
        /// 签注种类。 
        /// </summary>
        [JsonProperty("endorsement_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EndorsementType { get; set; }

        /// <summary>
        /// 签注往返有效次数。 
        /// </summary>
        [JsonProperty("valid_round_trips", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidRoundTrips { get; set; }

        /// <summary>
        /// 签注有效期。 
        /// </summary>
        [JsonProperty("endorsement_valid_period", NullValueHandling = NullValueHandling.Ignore)]
        public string EndorsementValidPeriod { get; set; }

        /// <summary>
        /// 签注备注。 
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>
        /// 签注签发信息。 
        /// </summary>
        [JsonProperty("issue_info", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExitEntryPermitEndorsementInfo {\n");
            sb.Append("  endorsementType: ").Append(EndorsementType).Append("\n");
            sb.Append("  validRoundTrips: ").Append(ValidRoundTrips).Append("\n");
            sb.Append("  endorsementValidPeriod: ").Append(EndorsementValidPeriod).Append("\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("  issueInfo: ").Append(IssueInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExitEntryPermitEndorsementInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExitEntryPermitEndorsementInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndorsementType == input.EndorsementType ||
                    (this.EndorsementType != null &&
                    this.EndorsementType.Equals(input.EndorsementType))
                ) && 
                (
                    this.ValidRoundTrips == input.ValidRoundTrips ||
                    (this.ValidRoundTrips != null &&
                    this.ValidRoundTrips.Equals(input.ValidRoundTrips))
                ) && 
                (
                    this.EndorsementValidPeriod == input.EndorsementValidPeriod ||
                    (this.EndorsementValidPeriod != null &&
                    this.EndorsementValidPeriod.Equals(input.EndorsementValidPeriod))
                ) && 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
                ) && 
                (
                    this.IssueInfo == input.IssueInfo ||
                    (this.IssueInfo != null &&
                    this.IssueInfo.Equals(input.IssueInfo))
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
                if (this.EndorsementType != null)
                    hashCode = hashCode * 59 + this.EndorsementType.GetHashCode();
                if (this.ValidRoundTrips != null)
                    hashCode = hashCode * 59 + this.ValidRoundTrips.GetHashCode();
                if (this.EndorsementValidPeriod != null)
                    hashCode = hashCode * 59 + this.EndorsementValidPeriod.GetHashCode();
                if (this.Remark != null)
                    hashCode = hashCode * 59 + this.Remark.GetHashCode();
                if (this.IssueInfo != null)
                    hashCode = hashCode * 59 + this.IssueInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
