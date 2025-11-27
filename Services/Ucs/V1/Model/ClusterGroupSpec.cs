using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ClusterGroupSpec 
    {

        /// <summary>
        /// 权限策略关联的命名空间列表
        /// </summary>
        [JsonProperty("ruleNamespaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RuleNamespaces { get; set; }

        /// <summary>
        /// 舰队启用联邦ID
        /// </summary>
        [JsonProperty("federationId", NullValueHandling = NullValueHandling.Ignore)]
        public string FederationId { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 舰队对应联邦的DNS后缀，开启联邦后可见
        /// </summary>
        [JsonProperty("dnsSuffix", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DnsSuffix { get; set; }

        /// <summary>
        /// 联邦到期时间戳
        /// </summary>
        [JsonProperty("federationExpirationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string FederationExpirationTimestamp { get; set; }

        /// <summary>
        /// 策略管理id
        /// </summary>
        [JsonProperty("policyId", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyId { get; set; }

        /// <summary>
        /// 舰队启用联邦的版本
        /// </summary>
        [JsonProperty("federationVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string FederationVersion { get; set; }

        /// <summary>
        /// 集群联邦连接网关节点列表，仅当舰队开启集群联邦时有值
        /// </summary>
        [JsonProperty("connectGatewayEndpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConnectEndpoint> ConnectGatewayEndpoints { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterGroupSpec {\n");
            sb.Append("  ruleNamespaces: ").Append(RuleNamespaces).Append("\n");
            sb.Append("  federationId: ").Append(FederationId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  dnsSuffix: ").Append(DnsSuffix).Append("\n");
            sb.Append("  federationExpirationTimestamp: ").Append(FederationExpirationTimestamp).Append("\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  federationVersion: ").Append(FederationVersion).Append("\n");
            sb.Append("  connectGatewayEndpoints: ").Append(ConnectGatewayEndpoints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterGroupSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterGroupSpec input)
        {
            if (input == null) return false;
            if (this.RuleNamespaces != input.RuleNamespaces || (this.RuleNamespaces != null && input.RuleNamespaces != null && !this.RuleNamespaces.SequenceEqual(input.RuleNamespaces))) return false;
            if (this.FederationId != input.FederationId || (this.FederationId != null && !this.FederationId.Equals(input.FederationId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DnsSuffix != input.DnsSuffix || (this.DnsSuffix != null && input.DnsSuffix != null && !this.DnsSuffix.SequenceEqual(input.DnsSuffix))) return false;
            if (this.FederationExpirationTimestamp != input.FederationExpirationTimestamp || (this.FederationExpirationTimestamp != null && !this.FederationExpirationTimestamp.Equals(input.FederationExpirationTimestamp))) return false;
            if (this.PolicyId != input.PolicyId || (this.PolicyId != null && !this.PolicyId.Equals(input.PolicyId))) return false;
            if (this.FederationVersion != input.FederationVersion || (this.FederationVersion != null && !this.FederationVersion.Equals(input.FederationVersion))) return false;
            if (this.ConnectGatewayEndpoints != input.ConnectGatewayEndpoints || (this.ConnectGatewayEndpoints != null && input.ConnectGatewayEndpoints != null && !this.ConnectGatewayEndpoints.SequenceEqual(input.ConnectGatewayEndpoints))) return false;

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
                if (this.RuleNamespaces != null) hashCode = hashCode * 59 + this.RuleNamespaces.GetHashCode();
                if (this.FederationId != null) hashCode = hashCode * 59 + this.FederationId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DnsSuffix != null) hashCode = hashCode * 59 + this.DnsSuffix.GetHashCode();
                if (this.FederationExpirationTimestamp != null) hashCode = hashCode * 59 + this.FederationExpirationTimestamp.GetHashCode();
                if (this.PolicyId != null) hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.FederationVersion != null) hashCode = hashCode * 59 + this.FederationVersion.GetHashCode();
                if (this.ConnectGatewayEndpoints != null) hashCode = hashCode * 59 + this.ConnectGatewayEndpoints.GetHashCode();
                return hashCode;
            }
        }
    }
}
