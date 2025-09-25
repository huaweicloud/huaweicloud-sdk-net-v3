using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GpgKeyDto 
    {

        /// <summary>
        /// gpg名称
        /// </summary>
        [JsonProperty("gpg_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GpgName { get; set; }

        /// <summary>
        /// 是否开启gpg认证
        /// </summary>
        [JsonProperty("open_gpg_verified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenGpgVerified { get; set; }

        /// <summary>
        /// gpg认证状态
        /// </summary>
        [JsonProperty("verification_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? VerificationStatus { get; set; }

        /// <summary>
        /// gpg初始化id
        /// </summary>
        [JsonProperty("gpg_primary_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GpgPrimaryKeyId { get; set; }

        /// <summary>
        /// gpg昵称
        /// </summary>
        [JsonProperty("gpg_nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GpgNickName { get; set; }

        /// <summary>
        /// gpg租户昵称
        /// </summary>
        [JsonProperty("gpg_tenant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GpgTenantName { get; set; }

        /// <summary>
        /// gpg用户名称
        /// </summary>
        [JsonProperty("gpg_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GpgUserName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GpgKeyDto {\n");
            sb.Append("  gpgName: ").Append(GpgName).Append("\n");
            sb.Append("  openGpgVerified: ").Append(OpenGpgVerified).Append("\n");
            sb.Append("  verificationStatus: ").Append(VerificationStatus).Append("\n");
            sb.Append("  gpgPrimaryKeyId: ").Append(GpgPrimaryKeyId).Append("\n");
            sb.Append("  gpgNickName: ").Append(GpgNickName).Append("\n");
            sb.Append("  gpgTenantName: ").Append(GpgTenantName).Append("\n");
            sb.Append("  gpgUserName: ").Append(GpgUserName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GpgKeyDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GpgKeyDto input)
        {
            if (input == null) return false;
            if (this.GpgName != input.GpgName || (this.GpgName != null && !this.GpgName.Equals(input.GpgName))) return false;
            if (this.OpenGpgVerified != input.OpenGpgVerified || (this.OpenGpgVerified != null && !this.OpenGpgVerified.Equals(input.OpenGpgVerified))) return false;
            if (this.VerificationStatus != input.VerificationStatus || (this.VerificationStatus != null && !this.VerificationStatus.Equals(input.VerificationStatus))) return false;
            if (this.GpgPrimaryKeyId != input.GpgPrimaryKeyId || (this.GpgPrimaryKeyId != null && !this.GpgPrimaryKeyId.Equals(input.GpgPrimaryKeyId))) return false;
            if (this.GpgNickName != input.GpgNickName || (this.GpgNickName != null && !this.GpgNickName.Equals(input.GpgNickName))) return false;
            if (this.GpgTenantName != input.GpgTenantName || (this.GpgTenantName != null && !this.GpgTenantName.Equals(input.GpgTenantName))) return false;
            if (this.GpgUserName != input.GpgUserName || (this.GpgUserName != null && !this.GpgUserName.Equals(input.GpgUserName))) return false;

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
                if (this.GpgName != null) hashCode = hashCode * 59 + this.GpgName.GetHashCode();
                if (this.OpenGpgVerified != null) hashCode = hashCode * 59 + this.OpenGpgVerified.GetHashCode();
                if (this.VerificationStatus != null) hashCode = hashCode * 59 + this.VerificationStatus.GetHashCode();
                if (this.GpgPrimaryKeyId != null) hashCode = hashCode * 59 + this.GpgPrimaryKeyId.GetHashCode();
                if (this.GpgNickName != null) hashCode = hashCode * 59 + this.GpgNickName.GetHashCode();
                if (this.GpgTenantName != null) hashCode = hashCode * 59 + this.GpgTenantName.GetHashCode();
                if (this.GpgUserName != null) hashCode = hashCode * 59 + this.GpgUserName.GetHashCode();
                return hashCode;
            }
        }
    }
}
