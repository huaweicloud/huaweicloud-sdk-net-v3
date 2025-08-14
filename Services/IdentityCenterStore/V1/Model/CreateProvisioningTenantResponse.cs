using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateProvisioningTenantResponse : SdkResponse
    {

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("creation_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CreationTime { get; set; }

        /// <summary>
        /// SCIM终端节点
        /// </summary>
        [JsonProperty("scim_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string ScimEndpoint { get; set; }

        /// <summary>
        /// 开启自动预配后生成的全局唯一标识符（ID）
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateProvisioningTenantResponse {\n");
            sb.Append("  creationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  scimEndpoint: ").Append(ScimEndpoint).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateProvisioningTenantResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateProvisioningTenantResponse input)
        {
            if (input == null) return false;
            if (this.CreationTime != input.CreationTime || (this.CreationTime != null && !this.CreationTime.Equals(input.CreationTime))) return false;
            if (this.ScimEndpoint != input.ScimEndpoint || (this.ScimEndpoint != null && !this.ScimEndpoint.Equals(input.ScimEndpoint))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;

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
                if (this.CreationTime != null) hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.ScimEndpoint != null) hashCode = hashCode * 59 + this.ScimEndpoint.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }
    }
}
