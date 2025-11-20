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
    /// 租户信息。
    /// </summary>
    public class SpTenantInfo 
    {

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("customer_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerProjectId { get; set; }

        /// <summary>
        /// 被关联租户的名称。
        /// </summary>
        [JsonProperty("customer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerName { get; set; }

        /// <summary>
        /// 租户的可用区。
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 分配表记录总数，用于分页。
        /// </summary>
        [JsonProperty("resource_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceCount { get; set; }

        /// <summary>
        /// 分配给租户的资源。
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllocateSpResourceInfo> Resources { get; set; }

        /// <summary>
        /// 分配给租户的资源总览。
        /// </summary>
        [JsonProperty("resources_overview", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllocateSpResourceSummaryInfo> ResourcesOverview { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpTenantInfo {\n");
            sb.Append("  customerProjectId: ").Append(CustomerProjectId).Append("\n");
            sb.Append("  customerName: ").Append(CustomerName).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  resourceCount: ").Append(ResourceCount).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  resourcesOverview: ").Append(ResourcesOverview).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SpTenantInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SpTenantInfo input)
        {
            if (input == null) return false;
            if (this.CustomerProjectId != input.CustomerProjectId || (this.CustomerProjectId != null && !this.CustomerProjectId.Equals(input.CustomerProjectId))) return false;
            if (this.CustomerName != input.CustomerName || (this.CustomerName != null && !this.CustomerName.Equals(input.CustomerName))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.ResourceCount != input.ResourceCount || (this.ResourceCount != null && !this.ResourceCount.Equals(input.ResourceCount))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
            if (this.ResourcesOverview != input.ResourcesOverview || (this.ResourcesOverview != null && input.ResourcesOverview != null && !this.ResourcesOverview.SequenceEqual(input.ResourcesOverview))) return false;

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
                if (this.CustomerProjectId != null) hashCode = hashCode * 59 + this.CustomerProjectId.GetHashCode();
                if (this.CustomerName != null) hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.ResourceCount != null) hashCode = hashCode * 59 + this.ResourceCount.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.ResourcesOverview != null) hashCode = hashCode * 59 + this.ResourcesOverview.GetHashCode();
                return hashCode;
            }
        }
    }
}
