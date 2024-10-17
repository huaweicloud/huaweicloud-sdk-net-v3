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
    /// Request Object
    /// </summary>
    public class UpdateVersionRequest 
    {

        /// <summary>
        /// 凭据名称。
        /// </summary>
        [SDKProperty("secret_name", IsPath = true)]
        [JsonProperty("secret_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretName { get; set; }

        /// <summary>
        /// 凭据的版本标识符。
        /// </summary>
        [SDKProperty("version_id", IsPath = true)]
        [JsonProperty("version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateVersionRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateVersionRequest {\n");
            sb.Append("  secretName: ").Append(SecretName).Append("\n");
            sb.Append("  versionId: ").Append(VersionId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateVersionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateVersionRequest input)
        {
            if (input == null) return false;
            if (this.SecretName != input.SecretName || (this.SecretName != null && !this.SecretName.Equals(input.SecretName))) return false;
            if (this.VersionId != input.VersionId || (this.VersionId != null && !this.VersionId.Equals(input.VersionId))) return false;
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
                if (this.SecretName != null) hashCode = hashCode * 59 + this.SecretName.GetHashCode();
                if (this.VersionId != null) hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
