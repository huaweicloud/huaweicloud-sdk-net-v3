using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// ResourceSummary 表示成员集群中的资源汇总。
    /// </summary>
    public class ResourceSummary 
    {

        /// <summary>
        /// 可分配的资源
        /// </summary>
        [JsonProperty("allocatable", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Allocatable { get; set; }

        /// <summary>
        /// 分配中的资源
        /// </summary>
        [JsonProperty("allocating", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Allocating { get; set; }

        /// <summary>
        /// 已分配的资源
        /// </summary>
        [JsonProperty("allocated", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Allocated { get; set; }

        /// <summary>
        /// 资源总量
        /// </summary>
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Capacity { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceSummary {\n");
            sb.Append("  allocatable: ").Append(Allocatable).Append("\n");
            sb.Append("  allocating: ").Append(Allocating).Append("\n");
            sb.Append("  allocated: ").Append(Allocated).Append("\n");
            sb.Append("  capacity: ").Append(Capacity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceSummary input)
        {
            if (input == null) return false;
            if (this.Allocatable != input.Allocatable || (this.Allocatable != null && input.Allocatable != null && !this.Allocatable.SequenceEqual(input.Allocatable))) return false;
            if (this.Allocating != input.Allocating || (this.Allocating != null && input.Allocating != null && !this.Allocating.SequenceEqual(input.Allocating))) return false;
            if (this.Allocated != input.Allocated || (this.Allocated != null && input.Allocated != null && !this.Allocated.SequenceEqual(input.Allocated))) return false;
            if (this.Capacity != input.Capacity || (this.Capacity != null && input.Capacity != null && !this.Capacity.SequenceEqual(input.Capacity))) return false;

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
                if (this.Allocatable != null) hashCode = hashCode * 59 + this.Allocatable.GetHashCode();
                if (this.Allocating != null) hashCode = hashCode * 59 + this.Allocating.GetHashCode();
                if (this.Allocated != null) hashCode = hashCode * 59 + this.Allocated.GetHashCode();
                if (this.Capacity != null) hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                return hashCode;
            }
        }
    }
}
