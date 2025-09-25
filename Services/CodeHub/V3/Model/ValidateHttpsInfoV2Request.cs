using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ValidateHttpsInfoV2Request 
    {

        /// <summary>
        /// 用户iam_user_uuid
        /// </summary>
        [SDKProperty("iam_user_uuid", IsPath = true)]
        [JsonProperty("iam_user_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string IamUserUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public PasswordRequest Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateHttpsInfoV2Request {\n");
            sb.Append("  iamUserUuid: ").Append(IamUserUuid).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidateHttpsInfoV2Request);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ValidateHttpsInfoV2Request input)
        {
            if (input == null) return false;
            if (this.IamUserUuid != input.IamUserUuid || (this.IamUserUuid != null && !this.IamUserUuid.Equals(input.IamUserUuid))) return false;
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
                if (this.IamUserUuid != null) hashCode = hashCode * 59 + this.IamUserUuid.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
