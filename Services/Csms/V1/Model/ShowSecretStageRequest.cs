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
    public class ShowSecretStageRequest 
    {

        /// <summary>
        /// 凭据名称。
        /// </summary>
        [SDKProperty("secret_name", IsPath = true)]
        [JsonProperty("secret_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretName { get; set; }

        /// <summary>
        /// 凭据版本状态的名称。
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
            sb.Append("class ShowSecretStageRequest {\n");
            sb.Append("  secretName: ").Append(SecretName).Append("\n");
            sb.Append("  stageName: ").Append(StageName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSecretStageRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSecretStageRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecretName == input.SecretName ||
                    (this.SecretName != null &&
                    this.SecretName.Equals(input.SecretName))
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
                if (this.SecretName != null)
                    hashCode = hashCode * 59 + this.SecretName.GetHashCode();
                if (this.StageName != null)
                    hashCode = hashCode * 59 + this.StageName.GetHashCode();
                return hashCode;
            }
        }
    }
}
