using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PersistentVolumeClaimStatus 
    {

        /// <summary>
        /// 显示volume实际具有的访问模式。
        /// </summary>
        [JsonProperty("accessModes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessModes { get; set; }

        /// <summary>
        /// 底层卷的实际资源
        /// </summary>
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string Capacity { get; set; }

        /// <summary>
        /// PersistentVolumeClaim当前所处的状态
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersistentVolumeClaimStatus {\n");
            sb.Append("  accessModes: ").Append(AccessModes).Append("\n");
            sb.Append("  capacity: ").Append(Capacity).Append("\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PersistentVolumeClaimStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PersistentVolumeClaimStatus input)
        {
            if (input == null) return false;
            if (this.AccessModes != input.AccessModes || (this.AccessModes != null && input.AccessModes != null && !this.AccessModes.SequenceEqual(input.AccessModes))) return false;
            if (this.Capacity != input.Capacity || (this.Capacity != null && !this.Capacity.Equals(input.Capacity))) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;

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
                if (this.AccessModes != null) hashCode = hashCode * 59 + this.AccessModes.GetHashCode();
                if (this.Capacity != null) hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                return hashCode;
            }
        }
    }
}
