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
    /// Response Object
    /// </summary>
    public class UpdateTenantServiceConfigsResponse : SdkResponse
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
        /// 租户project ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTenantServiceConfigsResponse {\n");
            sb.Append("  serviceSharedConfig: ").Append(ServiceSharedConfig).Append("\n");
            sb.Append("  tenantLogConfig: ").Append(TenantLogConfig).Append("\n");
            sb.Append("  subAccountControlConfig: ").Append(SubAccountControlConfig).Append("\n");
            sb.Append("  isAiMarkOn: ").Append(IsAiMarkOn).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTenantServiceConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTenantServiceConfigsResponse input)
        {
            if (input == null) return false;
            if (this.ServiceSharedConfig != input.ServiceSharedConfig || (this.ServiceSharedConfig != null && !this.ServiceSharedConfig.Equals(input.ServiceSharedConfig))) return false;
            if (this.TenantLogConfig != input.TenantLogConfig || (this.TenantLogConfig != null && !this.TenantLogConfig.Equals(input.TenantLogConfig))) return false;
            if (this.SubAccountControlConfig != input.SubAccountControlConfig || (this.SubAccountControlConfig != null && !this.SubAccountControlConfig.Equals(input.SubAccountControlConfig))) return false;
            if (this.IsAiMarkOn != input.IsAiMarkOn || (this.IsAiMarkOn != null && !this.IsAiMarkOn.Equals(input.IsAiMarkOn))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
