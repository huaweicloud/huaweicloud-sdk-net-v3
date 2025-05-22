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
    public class ShowSecretsConfigResponse : SdkResponse
    {

        /// <summary>
        /// 凭据强度检测配置是否打开。
        /// </summary>
        [JsonProperty("checking_secret_strength", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckingSecretStrength { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSecretsConfigResponse {\n");
            sb.Append("  checkingSecretStrength: ").Append(CheckingSecretStrength).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSecretsConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSecretsConfigResponse input)
        {
            if (input == null) return false;
            if (this.CheckingSecretStrength != input.CheckingSecretStrength || (this.CheckingSecretStrength != null && !this.CheckingSecretStrength.Equals(input.CheckingSecretStrength))) return false;

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
                if (this.CheckingSecretStrength != null) hashCode = hashCode * 59 + this.CheckingSecretStrength.GetHashCode();
                return hashCode;
            }
        }
    }
}
