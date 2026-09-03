using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateSecurityPolicyControlResponse : SdkResponse
    {

        /// <summary>
        /// 开启安全策略管控的资源数量。
        /// </summary>
        [JsonProperty("enabled_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnabledCount { get; set; }

        /// <summary>
        /// 关闭安全策略管控的资源数量。
        /// </summary>
        [JsonProperty("disabled_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisabledCount { get; set; }

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
            sb.Append("class UpdateSecurityPolicyControlResponse {\n");
            sb.Append("  enabledCount: ").Append(EnabledCount).Append("\n");
            sb.Append("  disabledCount: ").Append(DisabledCount).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSecurityPolicyControlResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSecurityPolicyControlResponse input)
        {
            if (input == null) return false;
            if (this.EnabledCount != input.EnabledCount || (this.EnabledCount != null && !this.EnabledCount.Equals(input.EnabledCount))) return false;
            if (this.DisabledCount != input.DisabledCount || (this.DisabledCount != null && !this.DisabledCount.Equals(input.DisabledCount))) return false;
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
                if (this.EnabledCount != null) hashCode = hashCode * 59 + this.EnabledCount.GetHashCode();
                if (this.DisabledCount != null) hashCode = hashCode * 59 + this.DisabledCount.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
