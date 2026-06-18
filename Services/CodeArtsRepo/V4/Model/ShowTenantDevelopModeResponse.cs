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
    public class ShowTenantDevelopModeResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 是否开启cr模式。
        /// </summary>
        [JsonProperty("cr_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CrEnable { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启租户下加密设置。
        /// </summary>
        [JsonProperty("repo_encryption_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RepoEncryptionEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTenantDevelopModeResponse {\n");
            sb.Append("  crEnable: ").Append(CrEnable).Append("\n");
            sb.Append("  repoEncryptionEnabled: ").Append(RepoEncryptionEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTenantDevelopModeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTenantDevelopModeResponse input)
        {
            if (input == null) return false;
            if (this.CrEnable != input.CrEnable || (this.CrEnable != null && !this.CrEnable.Equals(input.CrEnable))) return false;
            if (this.RepoEncryptionEnabled != input.RepoEncryptionEnabled || (this.RepoEncryptionEnabled != null && !this.RepoEncryptionEnabled.Equals(input.RepoEncryptionEnabled))) return false;

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
                if (this.CrEnable != null) hashCode = hashCode * 59 + this.CrEnable.GetHashCode();
                if (this.RepoEncryptionEnabled != null) hashCode = hashCode * 59 + this.RepoEncryptionEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
