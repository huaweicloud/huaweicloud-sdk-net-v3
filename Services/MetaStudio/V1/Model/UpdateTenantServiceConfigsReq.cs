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
    public class UpdateTenantServiceConfigsReq 
    {

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
            sb.Append("class UpdateTenantServiceConfigsReq {\n");
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
            return this.Equals(input as UpdateTenantServiceConfigsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTenantServiceConfigsReq input)
        {
            if (input == null) return false;
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
                if (this.SubAccountControlConfig != null) hashCode = hashCode * 59 + this.SubAccountControlConfig.GetHashCode();
                if (this.IsAiMarkOn != null) hashCode = hashCode * 59 + this.IsAiMarkOn.GetHashCode();
                return hashCode;
            }
        }
    }
}
