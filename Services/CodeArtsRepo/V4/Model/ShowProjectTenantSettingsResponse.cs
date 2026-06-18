using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowProjectTenantSettingsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 仓库默认加密设置是否开启。
        /// </summary>
        [JsonProperty("default_encryption_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultEncryptionEnabled { get; set; }

        /// <summary>
        /// **参数解释：** 租户设置的加密类型。 **取值范围：** KMS,normal,null,当为KMS时表示开启了KMS加密。
        /// </summary>
        [JsonProperty("encryption_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptionType { get; set; }

        /// <summary>
        /// **参数解释：** 允许公共访问。 **取值范围：** allow 允许 deny 拒绝。
        /// </summary>
        [JsonProperty("permit_public", NullValueHandling = NullValueHandling.Ignore)]
        public string PermitPublic { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProjectTenantSettingsResponse {\n");
            sb.Append("  defaultEncryptionEnabled: ").Append(DefaultEncryptionEnabled).Append("\n");
            sb.Append("  encryptionType: ").Append(EncryptionType).Append("\n");
            sb.Append("  permitPublic: ").Append(PermitPublic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProjectTenantSettingsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProjectTenantSettingsResponse input)
        {
            if (input == null) return false;
            if (this.DefaultEncryptionEnabled != input.DefaultEncryptionEnabled || (this.DefaultEncryptionEnabled != null && !this.DefaultEncryptionEnabled.Equals(input.DefaultEncryptionEnabled))) return false;
            if (this.EncryptionType != input.EncryptionType || (this.EncryptionType != null && !this.EncryptionType.Equals(input.EncryptionType))) return false;
            if (this.PermitPublic != input.PermitPublic || (this.PermitPublic != null && !this.PermitPublic.Equals(input.PermitPublic))) return false;

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
                if (this.DefaultEncryptionEnabled != null) hashCode = hashCode * 59 + this.DefaultEncryptionEnabled.GetHashCode();
                if (this.EncryptionType != null) hashCode = hashCode * 59 + this.EncryptionType.GetHashCode();
                if (this.PermitPublic != null) hashCode = hashCode * 59 + this.PermitPublic.GetHashCode();
                return hashCode;
            }
        }
    }
}
