using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListUsersForEnterpriseProjectResUsers 
    {

        /// <summary>
        /// 授权用户所属账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 授权用户ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 授权用户名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 授权用户是否启用，true表示启用，false表示停用，默认为true。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 授权用户描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 授权用户的策略数。
        /// </summary>
        [JsonProperty("policy_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyNum { get; set; }

        /// <summary>
        /// 用户最近与企业项目关联策略的时间（毫秒）。
        /// </summary>
        [JsonProperty("lastest_policy_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastestPolicyTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUsersForEnterpriseProjectResUsers {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  policyNum: ").Append(PolicyNum).Append("\n");
            sb.Append("  lastestPolicyTime: ").Append(LastestPolicyTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUsersForEnterpriseProjectResUsers);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUsersForEnterpriseProjectResUsers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PolicyNum == input.PolicyNum ||
                    (this.PolicyNum != null &&
                    this.PolicyNum.Equals(input.PolicyNum))
                ) && 
                (
                    this.LastestPolicyTime == input.LastestPolicyTime ||
                    (this.LastestPolicyTime != null &&
                    this.LastestPolicyTime.Equals(input.LastestPolicyTime))
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
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PolicyNum != null)
                    hashCode = hashCode * 59 + this.PolicyNum.GetHashCode();
                if (this.LastestPolicyTime != null)
                    hashCode = hashCode * 59 + this.LastestPolicyTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
