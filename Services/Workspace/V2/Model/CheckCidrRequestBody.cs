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
    /// 校验租户冲突网段请求体
    /// </summary>
    public class CheckCidrRequestBody 
    {

        /// <summary>
        /// 租户网段
        /// </summary>
        [JsonProperty("tenant_cidrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TenantCidrs { get; set; }

        /// <summary>
        /// 开通服务资源使用的可用分区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckCidrRequestBody {\n");
            sb.Append("  tenantCidrs: ").Append(TenantCidrs).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckCidrRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckCidrRequestBody input)
        {
            if (input == null) return false;
            if (this.TenantCidrs != input.TenantCidrs || (this.TenantCidrs != null && input.TenantCidrs != null && !this.TenantCidrs.SequenceEqual(input.TenantCidrs))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;

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
                if (this.TenantCidrs != null) hashCode = hashCode * 59 + this.TenantCidrs.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
