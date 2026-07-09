using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRealNameAuthStatusResponse : SdkResponse
    {

        /// <summary>
        /// 实名认证状态。enum:-1,0,1,2。 -1未实名认证、0实名认证审核中、1实名认证不通过、2已实名认证
        /// </summary>
        [JsonProperty("verified_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? VerifiedStatus { get; set; }

        /// <summary>
        /// 实名认证类型。实名认证状态为-1未实名认证返回null。enum:0,1。 0个人实名认证、1企业实名认证
        /// </summary>
        [JsonProperty("verified_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? VerifiedType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRealNameAuthStatusResponse {\n");
            sb.Append("  verifiedStatus: ").Append(VerifiedStatus).Append("\n");
            sb.Append("  verifiedType: ").Append(VerifiedType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRealNameAuthStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRealNameAuthStatusResponse input)
        {
            if (input == null) return false;
            if (this.VerifiedStatus != input.VerifiedStatus || (this.VerifiedStatus != null && !this.VerifiedStatus.Equals(input.VerifiedStatus))) return false;
            if (this.VerifiedType != input.VerifiedType || (this.VerifiedType != null && !this.VerifiedType.Equals(input.VerifiedType))) return false;

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
                if (this.VerifiedStatus != null) hashCode = hashCode * 59 + this.VerifiedStatus.GetHashCode();
                if (this.VerifiedType != null) hashCode = hashCode * 59 + this.VerifiedType.GetHashCode();
                return hashCode;
            }
        }
    }
}
