using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DomainStatuses 
    {

        /// <summary>
        /// **参数解释**： 服务名。 **约束限制**： 不涉及。 **取值范围**： 默认CodeCI。
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// **参数解释**： 租户id。 **约束限制**： 不涉及。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**： 租户名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// **参数解释**： freeQuota。 **约束限制**： 不涉及。 **取值范围**： true或false。
        /// </summary>
        [JsonProperty("free_quota", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FreeQuota { get; set; }

        /// <summary>
        /// **参数解释**： freePackageQuota。 **约束限制**： 不涉及。 **取值范围**： true或false。
        /// </summary>
        [JsonProperty("free_package_quota", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FreePackageQuota { get; set; }

        /// <summary>
        /// **参数解释**： 状态。 **约束限制**： 不涉及。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// **参数解释**： isFederation。 **约束限制**： 不涉及。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("is_federation", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsFederation { get; set; }

        /// <summary>
        /// **参数解释**： 白名单标识。 **约束限制**： 不涉及。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("is_whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsWhitelist { get; set; }

        /// <summary>
        /// **参数解释**： 地区。 **约束限制**： 不涉及。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释**： 包类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("package_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageType { get; set; }

        /// <summary>
        /// **参数解释**： 租户类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("domain_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? DomainType { get; set; }

        /// <summary>
        /// **参数解释**： 租户业务类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("domain_business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainBusinessType { get; set; }

        /// <summary>
        /// **参数解释**： domainMaliciousDockerArgs。 **约束限制**： 不涉及。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("domain_malicious_docker_args", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainMaliciousDockerArgs { get; set; }

        /// <summary>
        /// **参数解释**： 允许自定义环境数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("allow_custom_env", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllowCustomEnv { get; set; }

        /// <summary>
        /// **参数解释**： 默认的加速阈值注入。 **约束限制**： 不涉及。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("spec_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainStatuses {\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  freeQuota: ").Append(FreeQuota).Append("\n");
            sb.Append("  freePackageQuota: ").Append(FreePackageQuota).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  isFederation: ").Append(IsFederation).Append("\n");
            sb.Append("  isWhitelist: ").Append(IsWhitelist).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  packageType: ").Append(PackageType).Append("\n");
            sb.Append("  domainType: ").Append(DomainType).Append("\n");
            sb.Append("  domainBusinessType: ").Append(DomainBusinessType).Append("\n");
            sb.Append("  domainMaliciousDockerArgs: ").Append(DomainMaliciousDockerArgs).Append("\n");
            sb.Append("  allowCustomEnv: ").Append(AllowCustomEnv).Append("\n");
            sb.Append("  specThreshold: ").Append(SpecThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainStatuses);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainStatuses input)
        {
            if (input == null) return false;
            if (this.ServiceName != input.ServiceName || (this.ServiceName != null && !this.ServiceName.Equals(input.ServiceName))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.FreeQuota != input.FreeQuota || (this.FreeQuota != null && !this.FreeQuota.Equals(input.FreeQuota))) return false;
            if (this.FreePackageQuota != input.FreePackageQuota || (this.FreePackageQuota != null && !this.FreePackageQuota.Equals(input.FreePackageQuota))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.IsFederation != input.IsFederation || (this.IsFederation != null && !this.IsFederation.Equals(input.IsFederation))) return false;
            if (this.IsWhitelist != input.IsWhitelist || (this.IsWhitelist != null && !this.IsWhitelist.Equals(input.IsWhitelist))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.PackageType != input.PackageType || (this.PackageType != null && !this.PackageType.Equals(input.PackageType))) return false;
            if (this.DomainType != input.DomainType || (this.DomainType != null && !this.DomainType.Equals(input.DomainType))) return false;
            if (this.DomainBusinessType != input.DomainBusinessType || (this.DomainBusinessType != null && !this.DomainBusinessType.Equals(input.DomainBusinessType))) return false;
            if (this.DomainMaliciousDockerArgs != input.DomainMaliciousDockerArgs || (this.DomainMaliciousDockerArgs != null && !this.DomainMaliciousDockerArgs.Equals(input.DomainMaliciousDockerArgs))) return false;
            if (this.AllowCustomEnv != input.AllowCustomEnv || (this.AllowCustomEnv != null && !this.AllowCustomEnv.Equals(input.AllowCustomEnv))) return false;
            if (this.SpecThreshold != input.SpecThreshold || (this.SpecThreshold != null && !this.SpecThreshold.Equals(input.SpecThreshold))) return false;

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
                if (this.ServiceName != null) hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.FreeQuota != null) hashCode = hashCode * 59 + this.FreeQuota.GetHashCode();
                if (this.FreePackageQuota != null) hashCode = hashCode * 59 + this.FreePackageQuota.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IsFederation != null) hashCode = hashCode * 59 + this.IsFederation.GetHashCode();
                if (this.IsWhitelist != null) hashCode = hashCode * 59 + this.IsWhitelist.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.PackageType != null) hashCode = hashCode * 59 + this.PackageType.GetHashCode();
                if (this.DomainType != null) hashCode = hashCode * 59 + this.DomainType.GetHashCode();
                if (this.DomainBusinessType != null) hashCode = hashCode * 59 + this.DomainBusinessType.GetHashCode();
                if (this.DomainMaliciousDockerArgs != null) hashCode = hashCode * 59 + this.DomainMaliciousDockerArgs.GetHashCode();
                if (this.AllowCustomEnv != null) hashCode = hashCode * 59 + this.AllowCustomEnv.GetHashCode();
                if (this.SpecThreshold != null) hashCode = hashCode * 59 + this.SpecThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
