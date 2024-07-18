using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// 临时安全凭据的属性。
    /// </summary>
    public class Attributes 
    {

        /// <summary>
        /// 颁发临时安全凭证时的时间（timestamp，为标准UTC时间，毫秒级，13位数字）。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 是否已经通过MFA身份认证。
        /// </summary>
        [JsonProperty("mfa_authenticated", NullValueHandling = NullValueHandling.Ignore)]
        public string MfaAuthenticated { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attributes {\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  mfaAuthenticated: ").Append(MfaAuthenticated).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Attributes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Attributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.MfaAuthenticated == input.MfaAuthenticated ||
                    (this.MfaAuthenticated != null &&
                    this.MfaAuthenticated.Equals(input.MfaAuthenticated))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.MfaAuthenticated != null)
                    hashCode = hashCode * 59 + this.MfaAuthenticated.GetHashCode();
                return hashCode;
            }
        }
    }
}
