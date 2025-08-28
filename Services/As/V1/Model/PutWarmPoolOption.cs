using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PutWarmPoolOption 
    {

        /// <summary>
        /// 暖池最小容量，暖池最小与最大容量必须同时填写或不填写。暖池最小容量和最大容量填写时必须相等
        /// </summary>
        [JsonProperty("min_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinCapacity { get; set; }

        /// <summary>
        /// 暖池最大容量，暖池最小与最大容量必须同时填写或不填写。暖池最小容量和最大容量填写时必须相等
        /// </summary>
        [JsonProperty("max_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// 实例初始化等待时间，单位：秒
        /// </summary>
        [JsonProperty("instance_init_wait_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceInitWaitTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutWarmPoolOption {\n");
            sb.Append("  minCapacity: ").Append(MinCapacity).Append("\n");
            sb.Append("  maxCapacity: ").Append(MaxCapacity).Append("\n");
            sb.Append("  instanceInitWaitTime: ").Append(InstanceInitWaitTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PutWarmPoolOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PutWarmPoolOption input)
        {
            if (input == null) return false;
            if (this.MinCapacity != input.MinCapacity || (this.MinCapacity != null && !this.MinCapacity.Equals(input.MinCapacity))) return false;
            if (this.MaxCapacity != input.MaxCapacity || (this.MaxCapacity != null && !this.MaxCapacity.Equals(input.MaxCapacity))) return false;
            if (this.InstanceInitWaitTime != input.InstanceInitWaitTime || (this.InstanceInitWaitTime != null && !this.InstanceInitWaitTime.Equals(input.InstanceInitWaitTime))) return false;

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
                if (this.MinCapacity != null) hashCode = hashCode * 59 + this.MinCapacity.GetHashCode();
                if (this.MaxCapacity != null) hashCode = hashCode * 59 + this.MaxCapacity.GetHashCode();
                if (this.InstanceInitWaitTime != null) hashCode = hashCode * 59 + this.InstanceInitWaitTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
