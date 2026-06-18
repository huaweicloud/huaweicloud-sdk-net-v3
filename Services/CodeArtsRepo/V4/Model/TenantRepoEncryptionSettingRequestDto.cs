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
    /// 
    /// </summary>
    public class TenantRepoEncryptionSettingRequestDto 
    {

        /// <summary>
        /// **参数解释：** 租户id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// **参数解释：** 加密类型。 **取值范围：** KMS表示开启KMS加密，normal或者null表示未开启KMS加密。
        /// </summary>
        [JsonProperty("encryption_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptionType { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启租户下默认加密设置。
        /// </summary>
        [JsonProperty("default_encryption_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultEncryptionEnabled { get; set; }

        /// <summary>
        /// **参数解释：** 加密主密钥的名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("cmk_key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CmkKeyName { get; set; }

        /// <summary>
        /// **参数解释：** 加密主密钥的id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("cmk_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CmkKeyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantRepoEncryptionSettingRequestDto {\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  encryptionType: ").Append(EncryptionType).Append("\n");
            sb.Append("  defaultEncryptionEnabled: ").Append(DefaultEncryptionEnabled).Append("\n");
            sb.Append("  cmkKeyName: ").Append(CmkKeyName).Append("\n");
            sb.Append("  cmkKeyId: ").Append(CmkKeyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TenantRepoEncryptionSettingRequestDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TenantRepoEncryptionSettingRequestDto input)
        {
            if (input == null) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.EncryptionType != input.EncryptionType || (this.EncryptionType != null && !this.EncryptionType.Equals(input.EncryptionType))) return false;
            if (this.DefaultEncryptionEnabled != input.DefaultEncryptionEnabled || (this.DefaultEncryptionEnabled != null && !this.DefaultEncryptionEnabled.Equals(input.DefaultEncryptionEnabled))) return false;
            if (this.CmkKeyName != input.CmkKeyName || (this.CmkKeyName != null && !this.CmkKeyName.Equals(input.CmkKeyName))) return false;
            if (this.CmkKeyId != input.CmkKeyId || (this.CmkKeyId != null && !this.CmkKeyId.Equals(input.CmkKeyId))) return false;

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
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.EncryptionType != null) hashCode = hashCode * 59 + this.EncryptionType.GetHashCode();
                if (this.DefaultEncryptionEnabled != null) hashCode = hashCode * 59 + this.DefaultEncryptionEnabled.GetHashCode();
                if (this.CmkKeyName != null) hashCode = hashCode * 59 + this.CmkKeyName.GetHashCode();
                if (this.CmkKeyId != null) hashCode = hashCode * 59 + this.CmkKeyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
