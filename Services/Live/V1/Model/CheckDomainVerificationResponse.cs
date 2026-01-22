using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckDomainVerificationResponse : SdkResponse
    {

        /// <summary>
        /// 主域名
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 校验值，解析值或者文件内容
        /// </summary>
        [JsonProperty("verify_content", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifyContent { get; set; }

        /// <summary>
        /// 验证结果，true为验证成功确认归属，false为归属情况未确认
        /// </summary>
        [JsonProperty("verify_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VerifyResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckDomainVerificationResponse {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  verifyContent: ").Append(VerifyContent).Append("\n");
            sb.Append("  verifyResult: ").Append(VerifyResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckDomainVerificationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckDomainVerificationResponse input)
        {
            if (input == null) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.VerifyContent != input.VerifyContent || (this.VerifyContent != null && !this.VerifyContent.Equals(input.VerifyContent))) return false;
            if (this.VerifyResult != input.VerifyResult || (this.VerifyResult != null && !this.VerifyResult.Equals(input.VerifyResult))) return false;

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
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.VerifyContent != null) hashCode = hashCode * 59 + this.VerifyContent.GetHashCode();
                if (this.VerifyResult != null) hashCode = hashCode * 59 + this.VerifyResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
