using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDedicatedResourceInfoResponse : SdkResponse
    {

        /// <summary>
        /// 专属资源池ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 专属资源池名称。
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 引擎名称。
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("availability_zone_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneIds { get; set; }

        /// <summary>
        /// 资源规格类型。
        /// </summary>
        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public string Architecture { get; set; }

        /// <summary>
        /// 专属资源池状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dedicated_compute_info", NullValueHandling = NullValueHandling.Ignore)]
        public DedicatedComputeInfo DedicatedComputeInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dedicated_storage_info", NullValueHandling = NullValueHandling.Ignore)]
        public DedicatedStorageInfo DedicatedStorageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDedicatedResourceInfoResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  availabilityZoneIds: ").Append(AvailabilityZoneIds).Append("\n");
            sb.Append("  architecture: ").Append(Architecture).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  dedicatedComputeInfo: ").Append(DedicatedComputeInfo).Append("\n");
            sb.Append("  dedicatedStorageInfo: ").Append(DedicatedStorageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDedicatedResourceInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDedicatedResourceInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.EngineName == input.EngineName ||
                    (this.EngineName != null &&
                    this.EngineName.Equals(input.EngineName))
                ) && 
                (
                    this.AvailabilityZoneIds == input.AvailabilityZoneIds ||
                    this.AvailabilityZoneIds != null &&
                    input.AvailabilityZoneIds != null &&
                    this.AvailabilityZoneIds.SequenceEqual(input.AvailabilityZoneIds)
                ) && 
                (
                    this.Architecture == input.Architecture ||
                    (this.Architecture != null &&
                    this.Architecture.Equals(input.Architecture))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.DedicatedComputeInfo == input.DedicatedComputeInfo ||
                    (this.DedicatedComputeInfo != null &&
                    this.DedicatedComputeInfo.Equals(input.DedicatedComputeInfo))
                ) && 
                (
                    this.DedicatedStorageInfo == input.DedicatedStorageInfo ||
                    (this.DedicatedStorageInfo != null &&
                    this.DedicatedStorageInfo.Equals(input.DedicatedStorageInfo))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.EngineName != null)
                    hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.AvailabilityZoneIds != null)
                    hashCode = hashCode * 59 + this.AvailabilityZoneIds.GetHashCode();
                if (this.Architecture != null)
                    hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DedicatedComputeInfo != null)
                    hashCode = hashCode * 59 + this.DedicatedComputeInfo.GetHashCode();
                if (this.DedicatedStorageInfo != null)
                    hashCode = hashCode * 59 + this.DedicatedStorageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
