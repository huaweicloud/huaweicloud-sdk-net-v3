using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 租户业务配置
    /// </summary>
    public class TenantServiceConfigsInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("service_shared_config", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceSharedConfig ServiceSharedConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tenant_log_config", NullValueHandling = NullValueHandling.Ignore)]
        public TenantLogConfig TenantLogConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sub_account_control_config", NullValueHandling = NullValueHandling.Ignore)]
        public SubAccountControlConfig SubAccountControlConfig { get; set; }

        /// <summary>
        /// AI标识开关
        /// </summary>
        [JsonProperty("is_ai_mark_on", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAiMarkOn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantServiceConfigsInfo {\n");
            sb.Append("  serviceSharedConfig: ").Append(ServiceSharedConfig).Append("\n");
            sb.Append("  tenantLogConfig: ").Append(TenantLogConfig).Append("\n");
            sb.Append("  subAccountControlConfig: ").Append(SubAccountControlConfig).Append("\n");
            sb.Append("  isAiMarkOn: ").Append(IsAiMarkOn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TenantServiceConfigsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TenantServiceConfigsInfo input)
        {
            if (input == null) return false;
            if (this.ServiceSharedConfig != input.ServiceSharedConfig || (this.ServiceSharedConfig != null && !this.ServiceSharedConfig.Equals(input.ServiceSharedConfig))) return false;
            if (this.TenantLogConfig != input.TenantLogConfig || (this.TenantLogConfig != null && !this.TenantLogConfig.Equals(input.TenantLogConfig))) return false;
            if (this.SubAccountControlConfig != input.SubAccountControlConfig || (this.SubAccountControlConfig != null && !this.SubAccountControlConfig.Equals(input.SubAccountControlConfig))) return false;
            if (this.IsAiMarkOn != input.IsAiMarkOn || (this.IsAiMarkOn != null && !this.IsAiMarkOn.Equals(input.IsAiMarkOn))) return false;

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
                if (this.ServiceSharedConfig != null) hashCode = hashCode * 59 + this.ServiceSharedConfig.GetHashCode();
                if (this.TenantLogConfig != null) hashCode = hashCode * 59 + this.TenantLogConfig.GetHashCode();
                if (this.SubAccountControlConfig != null) hashCode = hashCode * 59 + this.SubAccountControlConfig.GetHashCode();
                if (this.IsAiMarkOn != null) hashCode = hashCode * 59 + this.IsAiMarkOn.GetHashCode();
                return hashCode;
            }
        }
    }
}
