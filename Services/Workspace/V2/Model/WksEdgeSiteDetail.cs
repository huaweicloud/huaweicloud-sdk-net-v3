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
    /// 边缘小站信息。
    /// </summary>
    public class WksEdgeSiteDetail 
    {

        /// <summary>
        /// 边缘小站id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 边缘小站名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 边缘小站描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 边缘小站的可用区ID。
        /// </summary>
        [JsonProperty("availability_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// 部署位置。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 边缘小站的部署状态。 - initial：待部署。 - deploying：部署中。 - available：可用。 - unavailable：不可用。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 边缘小站创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 边缘小站更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// cpu使用率。
        /// </summary>
        [JsonProperty("cpu_usage_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? CpuUsageRate { get; set; }

        /// <summary>
        /// 内存使用率。
        /// </summary>
        [JsonProperty("memory_usage_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? MemoryUsageRate { get; set; }

        /// <summary>
        /// 存储使用率。
        /// </summary>
        [JsonProperty("capacity_usage_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? CapacityUsageRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("site_info", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleSiteInfo SiteInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WksEdgeSiteDetail {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  availabilityZoneId: ").Append(AvailabilityZoneId).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  cpuUsageRate: ").Append(CpuUsageRate).Append("\n");
            sb.Append("  memoryUsageRate: ").Append(MemoryUsageRate).Append("\n");
            sb.Append("  capacityUsageRate: ").Append(CapacityUsageRate).Append("\n");
            sb.Append("  siteInfo: ").Append(SiteInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WksEdgeSiteDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WksEdgeSiteDetail input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.AvailabilityZoneId != input.AvailabilityZoneId || (this.AvailabilityZoneId != null && !this.AvailabilityZoneId.Equals(input.AvailabilityZoneId))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.CpuUsageRate != input.CpuUsageRate || (this.CpuUsageRate != null && !this.CpuUsageRate.Equals(input.CpuUsageRate))) return false;
            if (this.MemoryUsageRate != input.MemoryUsageRate || (this.MemoryUsageRate != null && !this.MemoryUsageRate.Equals(input.MemoryUsageRate))) return false;
            if (this.CapacityUsageRate != input.CapacityUsageRate || (this.CapacityUsageRate != null && !this.CapacityUsageRate.Equals(input.CapacityUsageRate))) return false;
            if (this.SiteInfo != input.SiteInfo || (this.SiteInfo != null && !this.SiteInfo.Equals(input.SiteInfo))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AvailabilityZoneId != null) hashCode = hashCode * 59 + this.AvailabilityZoneId.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.CpuUsageRate != null) hashCode = hashCode * 59 + this.CpuUsageRate.GetHashCode();
                if (this.MemoryUsageRate != null) hashCode = hashCode * 59 + this.MemoryUsageRate.GetHashCode();
                if (this.CapacityUsageRate != null) hashCode = hashCode * 59 + this.CapacityUsageRate.GetHashCode();
                if (this.SiteInfo != null) hashCode = hashCode * 59 + this.SiteInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
