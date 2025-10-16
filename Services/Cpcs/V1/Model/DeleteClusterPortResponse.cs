using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DeleteClusterPortResponse : SdkResponse
    {

        /// <summary>
        /// 删除资源结果
        /// </summary>
        [JsonProperty("delete_tenant_resource", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteTenantResource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteClusterPortResponse {\n");
            sb.Append("  deleteTenantResource: ").Append(DeleteTenantResource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteClusterPortResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteClusterPortResponse input)
        {
            if (input == null) return false;
            if (this.DeleteTenantResource != input.DeleteTenantResource || (this.DeleteTenantResource != null && !this.DeleteTenantResource.Equals(input.DeleteTenantResource))) return false;

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
                if (this.DeleteTenantResource != null) hashCode = hashCode * 59 + this.DeleteTenantResource.GetHashCode();
                return hashCode;
            }
        }
    }
}
