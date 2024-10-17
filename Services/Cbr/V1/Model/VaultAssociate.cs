using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VaultAssociate 
    {

        /// <summary>
        /// 目标vault ID , 只有设置复制策略时使用，而且必传
        /// </summary>
        [JsonProperty("destination_vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationVaultId { get; set; }

        /// <summary>
        /// 策略ID。policy_id字段与add_policy_ids字段在一次请求中有且只有一个。
        /// </summary>
        [JsonProperty("policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyId { get; set; }

        /// <summary>
        /// 多策略场景下，绑定新策略的id列表。policy_id字段与add_policy_ids字段在一次请求中有且只有一个。
        /// </summary>
        [JsonProperty("add_policy_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AddPolicyIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VaultAssociate {\n");
            sb.Append("  destinationVaultId: ").Append(DestinationVaultId).Append("\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  addPolicyIds: ").Append(AddPolicyIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VaultAssociate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VaultAssociate input)
        {
            if (input == null) return false;
            if (this.DestinationVaultId != input.DestinationVaultId || (this.DestinationVaultId != null && !this.DestinationVaultId.Equals(input.DestinationVaultId))) return false;
            if (this.PolicyId != input.PolicyId || (this.PolicyId != null && !this.PolicyId.Equals(input.PolicyId))) return false;
            if (this.AddPolicyIds != input.AddPolicyIds || (this.AddPolicyIds != null && input.AddPolicyIds != null && !this.AddPolicyIds.SequenceEqual(input.AddPolicyIds))) return false;

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
                if (this.DestinationVaultId != null) hashCode = hashCode * 59 + this.DestinationVaultId.GetHashCode();
                if (this.PolicyId != null) hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.AddPolicyIds != null) hashCode = hashCode * 59 + this.AddPolicyIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
