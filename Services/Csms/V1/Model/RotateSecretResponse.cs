using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class RotateSecretResponse : SdkResponse
    {

        /// <summary>
        /// 凭据的版本号标识符。
        /// </summary>
        [JsonProperty("version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionId { get; set; }

        /// <summary>
        /// 凭据的名称。
        /// </summary>
        [JsonProperty("secret_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RotateSecretResponse {\n");
            sb.Append("  versionId: ").Append(VersionId).Append("\n");
            sb.Append("  secretName: ").Append(SecretName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RotateSecretResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RotateSecretResponse input)
        {
            if (input == null) return false;
            if (this.VersionId != input.VersionId || (this.VersionId != null && !this.VersionId.Equals(input.VersionId))) return false;
            if (this.SecretName != input.SecretName || (this.SecretName != null && !this.SecretName.Equals(input.SecretName))) return false;

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
                if (this.VersionId != null) hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                if (this.SecretName != null) hashCode = hashCode * 59 + this.SecretName.GetHashCode();
                return hashCode;
            }
        }
    }
}
