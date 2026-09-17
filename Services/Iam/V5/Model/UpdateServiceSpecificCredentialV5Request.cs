using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateServiceSpecificCredentialV5Request 
    {

        /// <summary>
        /// IAM用户ID。
        /// </summary>
        [SDKProperty("user_id", IsPath = true)]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 服务专属凭证ID。
        /// </summary>
        [SDKProperty("credential_id", IsPath = true)]
        [JsonProperty("credential_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CredentialId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateServiceSpecificCredentialReq Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateServiceSpecificCredentialV5Request {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  credentialId: ").Append(CredentialId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateServiceSpecificCredentialV5Request);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateServiceSpecificCredentialV5Request input)
        {
            if (input == null) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.CredentialId != input.CredentialId || (this.CredentialId != null && !this.CredentialId.Equals(input.CredentialId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.CredentialId != null) hashCode = hashCode * 59 + this.CredentialId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
