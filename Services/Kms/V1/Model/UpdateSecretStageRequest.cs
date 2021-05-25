using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateSecretStageRequest 
    {

        /// <summary>
        /// 凭据的资源标识符。
        /// </summary>
        [SDKProperty("secret_id", IsPath = true)]
        [JsonProperty("secret_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretId { get; set; }

        /// <summary>
        /// 凭据版本状态的名称。
        /// </summary>
        [SDKProperty("stage_name", IsPath = true)]
        [JsonProperty("stage_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StageName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateSecretStageRequestBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSecretStageRequest {\n");
            sb.Append("  secretId: ").Append(SecretId).Append("\n");
            sb.Append("  stageName: ").Append(StageName).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSecretStageRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSecretStageRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecretId == input.SecretId ||
                    (this.SecretId != null &&
                    this.SecretId.Equals(input.SecretId))
                ) && 
                (
                    this.StageName == input.StageName ||
                    (this.StageName != null &&
                    this.StageName.Equals(input.StageName))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.SecretId != null)
                    hashCode = hashCode * 59 + this.SecretId.GetHashCode();
                if (this.StageName != null)
                    hashCode = hashCode * 59 + this.StageName.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
