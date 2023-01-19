using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 东西向防护的资源信息，例如VPC、VGW等
    /// </summary>
    public class EwProtectResourceInfo 
    {

        /// <summary>
        /// 防护资源类型：0 VPC，1 VGW
        /// </summary>
        [JsonProperty("protected_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtectedResourceType { get; set; }

        /// <summary>
        /// 防护资源名称
        /// </summary>
        [JsonProperty("protected_resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectedResourceName { get; set; }

        /// <summary>
        /// 防护资源id
        /// </summary>
        [JsonProperty("protected_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectedResourceId { get; set; }

        /// <summary>
        /// 防护资源nat网关名称
        /// </summary>
        [JsonProperty("protected_resource_nat_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectedResourceNatName { get; set; }

        /// <summary>
        /// 防护资源nat网关id
        /// </summary>
        [JsonProperty("protected_resource_nat_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectedResourceNatId { get; set; }

        /// <summary>
        /// 防护资源租户id
        /// </summary>
        [JsonProperty("protected_resource_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectedResourceProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EwProtectResourceInfo {\n");
            sb.Append("  protectedResourceType: ").Append(ProtectedResourceType).Append("\n");
            sb.Append("  protectedResourceName: ").Append(ProtectedResourceName).Append("\n");
            sb.Append("  protectedResourceId: ").Append(ProtectedResourceId).Append("\n");
            sb.Append("  protectedResourceNatName: ").Append(ProtectedResourceNatName).Append("\n");
            sb.Append("  protectedResourceNatId: ").Append(ProtectedResourceNatId).Append("\n");
            sb.Append("  protectedResourceProjectId: ").Append(ProtectedResourceProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EwProtectResourceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EwProtectResourceInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProtectedResourceType == input.ProtectedResourceType ||
                    (this.ProtectedResourceType != null &&
                    this.ProtectedResourceType.Equals(input.ProtectedResourceType))
                ) && 
                (
                    this.ProtectedResourceName == input.ProtectedResourceName ||
                    (this.ProtectedResourceName != null &&
                    this.ProtectedResourceName.Equals(input.ProtectedResourceName))
                ) && 
                (
                    this.ProtectedResourceId == input.ProtectedResourceId ||
                    (this.ProtectedResourceId != null &&
                    this.ProtectedResourceId.Equals(input.ProtectedResourceId))
                ) && 
                (
                    this.ProtectedResourceNatName == input.ProtectedResourceNatName ||
                    (this.ProtectedResourceNatName != null &&
                    this.ProtectedResourceNatName.Equals(input.ProtectedResourceNatName))
                ) && 
                (
                    this.ProtectedResourceNatId == input.ProtectedResourceNatId ||
                    (this.ProtectedResourceNatId != null &&
                    this.ProtectedResourceNatId.Equals(input.ProtectedResourceNatId))
                ) && 
                (
                    this.ProtectedResourceProjectId == input.ProtectedResourceProjectId ||
                    (this.ProtectedResourceProjectId != null &&
                    this.ProtectedResourceProjectId.Equals(input.ProtectedResourceProjectId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ProtectedResourceType != null)
                    hashCode = hashCode * 59 + this.ProtectedResourceType.GetHashCode();
                if (this.ProtectedResourceName != null)
                    hashCode = hashCode * 59 + this.ProtectedResourceName.GetHashCode();
                if (this.ProtectedResourceId != null)
                    hashCode = hashCode * 59 + this.ProtectedResourceId.GetHashCode();
                if (this.ProtectedResourceNatName != null)
                    hashCode = hashCode * 59 + this.ProtectedResourceNatName.GetHashCode();
                if (this.ProtectedResourceNatId != null)
                    hashCode = hashCode * 59 + this.ProtectedResourceNatId.GetHashCode();
                if (this.ProtectedResourceProjectId != null)
                    hashCode = hashCode * 59 + this.ProtectedResourceProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
