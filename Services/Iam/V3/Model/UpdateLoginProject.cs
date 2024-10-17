using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateLoginProject 
    {

        /// <summary>
        /// IAM用户是否开启登录保护，开启为\&quot;true\&quot;，未开启为\&quot;false\&quot;。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// IAM用户登录验证方式。手机验证为“sms”,邮箱验证为“email”,MFA验证为“vmfa”。
        /// </summary>
        [JsonProperty("verification_method", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationMethod { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLoginProject {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  verificationMethod: ").Append(VerificationMethod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLoginProject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLoginProject input)
        {
            if (input == null) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.VerificationMethod != input.VerificationMethod || (this.VerificationMethod != null && !this.VerificationMethod.Equals(input.VerificationMethod))) return false;

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
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.VerificationMethod != null) hashCode = hashCode * 59 + this.VerificationMethod.GetHashCode();
                return hashCode;
            }
        }
    }
}
