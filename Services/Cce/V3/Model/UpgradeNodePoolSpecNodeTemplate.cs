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
    /// 同步节点池模板参数
    /// </summary>
    public class UpgradeNodePoolSpecNodeTemplate 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lifeCycle", NullValueHandling = NullValueHandling.Ignore)]
        public NodeLifecycleConfig LifeCycle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("login", NullValueHandling = NullValueHandling.Ignore)]
        public Login Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volumeConfig", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeConfig VolumeConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeNodePoolSpecNodeTemplate {\n");
            sb.Append("  lifeCycle: ").Append(LifeCycle).Append("\n");
            sb.Append("  login: ").Append(Login).Append("\n");
            sb.Append("  volumeConfig: ").Append(VolumeConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeNodePoolSpecNodeTemplate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeNodePoolSpecNodeTemplate input)
        {
            if (input == null) return false;
            if (this.LifeCycle != input.LifeCycle || (this.LifeCycle != null && !this.LifeCycle.Equals(input.LifeCycle))) return false;
            if (this.Login != input.Login || (this.Login != null && !this.Login.Equals(input.Login))) return false;
            if (this.VolumeConfig != input.VolumeConfig || (this.VolumeConfig != null && !this.VolumeConfig.Equals(input.VolumeConfig))) return false;

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
                if (this.LifeCycle != null) hashCode = hashCode * 59 + this.LifeCycle.GetHashCode();
                if (this.Login != null) hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.VolumeConfig != null) hashCode = hashCode * 59 + this.VolumeConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
