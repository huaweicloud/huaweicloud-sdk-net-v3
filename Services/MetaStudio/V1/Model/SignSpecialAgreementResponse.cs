using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SignSpecialAgreementResponse : SdkResponse
    {

        /// <summary>
        /// 当前服务协议类型
        /// </summary>
        [JsonProperty("agreement_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AgreementType { get; set; }

        /// <summary>
        /// 当前服务协议版本
        /// </summary>
        [JsonProperty("current_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// 签署服务协议版本
        /// </summary>
        [JsonProperty("signed_version", NullValueHandling = NullValueHandling.Ignore)]
        public string SignedVersion { get; set; }

        /// <summary>
        /// 协议签署时间。格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;
        /// </summary>
        [JsonProperty("signed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SignedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignSpecialAgreementResponse {\n");
            sb.Append("  agreementType: ").Append(AgreementType).Append("\n");
            sb.Append("  currentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  signedVersion: ").Append(SignedVersion).Append("\n");
            sb.Append("  signedTime: ").Append(SignedTime).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SignSpecialAgreementResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SignSpecialAgreementResponse input)
        {
            if (input == null) return false;
            if (this.AgreementType != input.AgreementType || (this.AgreementType != null && !this.AgreementType.Equals(input.AgreementType))) return false;
            if (this.CurrentVersion != input.CurrentVersion || (this.CurrentVersion != null && !this.CurrentVersion.Equals(input.CurrentVersion))) return false;
            if (this.SignedVersion != input.SignedVersion || (this.SignedVersion != null && !this.SignedVersion.Equals(input.SignedVersion))) return false;
            if (this.SignedTime != input.SignedTime || (this.SignedTime != null && !this.SignedTime.Equals(input.SignedTime))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.AgreementType != null) hashCode = hashCode * 59 + this.AgreementType.GetHashCode();
                if (this.CurrentVersion != null) hashCode = hashCode * 59 + this.CurrentVersion.GetHashCode();
                if (this.SignedVersion != null) hashCode = hashCode * 59 + this.SignedVersion.GetHashCode();
                if (this.SignedTime != null) hashCode = hashCode * 59 + this.SignedTime.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
