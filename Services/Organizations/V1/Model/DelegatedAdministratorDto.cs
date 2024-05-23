using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// 包含有关委托管理员的信息。
    /// </summary>
    public class DelegatedAdministratorDto 
    {

        /// <summary>
        /// 将账号设置为委托管理员的日期。
        /// </summary>
        [JsonProperty("delegation_enabled_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DelegationEnabledAt { get; set; }

        /// <summary>
        /// 账号的唯一标识符（ID）。
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 账号的统一资源名称。
        /// </summary>
        [JsonProperty("account_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountUrn { get; set; }

        /// <summary>
        /// 账号加入组织的方式,invited：邀请加入，created：创建加入。
        /// </summary>
        [JsonProperty("join_method", NullValueHandling = NullValueHandling.Ignore)]
        public string JoinMethod { get; set; }

        /// <summary>
        /// 账号成为组织一部分的日期。
        /// </summary>
        [JsonProperty("joined_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JoinedAt { get; set; }

        /// <summary>
        /// 账号名称
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DelegatedAdministratorDto {\n");
            sb.Append("  delegationEnabledAt: ").Append(DelegationEnabledAt).Append("\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  accountUrn: ").Append(AccountUrn).Append("\n");
            sb.Append("  joinMethod: ").Append(JoinMethod).Append("\n");
            sb.Append("  joinedAt: ").Append(JoinedAt).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DelegatedAdministratorDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DelegatedAdministratorDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DelegationEnabledAt == input.DelegationEnabledAt ||
                    (this.DelegationEnabledAt != null &&
                    this.DelegationEnabledAt.Equals(input.DelegationEnabledAt))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AccountUrn == input.AccountUrn ||
                    (this.AccountUrn != null &&
                    this.AccountUrn.Equals(input.AccountUrn))
                ) && 
                (
                    this.JoinMethod == input.JoinMethod ||
                    (this.JoinMethod != null &&
                    this.JoinMethod.Equals(input.JoinMethod))
                ) && 
                (
                    this.JoinedAt == input.JoinedAt ||
                    (this.JoinedAt != null &&
                    this.JoinedAt.Equals(input.JoinedAt))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
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
                if (this.DelegationEnabledAt != null)
                    hashCode = hashCode * 59 + this.DelegationEnabledAt.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AccountUrn != null)
                    hashCode = hashCode * 59 + this.AccountUrn.GetHashCode();
                if (this.JoinMethod != null)
                    hashCode = hashCode * 59 + this.JoinMethod.GetHashCode();
                if (this.JoinedAt != null)
                    hashCode = hashCode * 59 + this.JoinedAt.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                return hashCode;
            }
        }
    }
}
