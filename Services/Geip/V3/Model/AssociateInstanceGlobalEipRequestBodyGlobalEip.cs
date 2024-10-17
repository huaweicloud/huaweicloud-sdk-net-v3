using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// 绑定后端实例请求体对象
    /// </summary>
    public class AssociateInstanceGlobalEipRequestBodyGlobalEip 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("associate_instance_info", NullValueHandling = NullValueHandling.Ignore)]
        public AssociateInstanceGlobalEipRequestBodyGlobalEipAssociateInstanceInfo AssociateInstanceInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gc_bandwidth_info", NullValueHandling = NullValueHandling.Ignore)]
        public AssociateInstanceGlobalEipRequestBodyGlobalEipGcBandwidthInfo GcBandwidthInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateInstanceGlobalEipRequestBodyGlobalEip {\n");
            sb.Append("  associateInstanceInfo: ").Append(AssociateInstanceInfo).Append("\n");
            sb.Append("  gcBandwidthInfo: ").Append(GcBandwidthInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateInstanceGlobalEipRequestBodyGlobalEip);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateInstanceGlobalEipRequestBodyGlobalEip input)
        {
            if (input == null) return false;
            if (this.AssociateInstanceInfo != input.AssociateInstanceInfo || (this.AssociateInstanceInfo != null && !this.AssociateInstanceInfo.Equals(input.AssociateInstanceInfo))) return false;
            if (this.GcBandwidthInfo != input.GcBandwidthInfo || (this.GcBandwidthInfo != null && !this.GcBandwidthInfo.Equals(input.GcBandwidthInfo))) return false;

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
                if (this.AssociateInstanceInfo != null) hashCode = hashCode * 59 + this.AssociateInstanceInfo.GetHashCode();
                if (this.GcBandwidthInfo != null) hashCode = hashCode * 59 + this.GcBandwidthInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
