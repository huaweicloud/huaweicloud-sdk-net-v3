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
    public class ListSecretStageRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("secret_id", IsPath = true)]
        [JsonProperty("secret_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("stage_name", IsPath = true)]
        [JsonProperty("stage_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StageName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSecretStageRequest {\n");
            sb.Append("  secretId: ").Append(SecretId).Append("\n");
            sb.Append("  stageName: ").Append(StageName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSecretStageRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSecretStageRequest input)
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
                return hashCode;
            }
        }
    }
}
