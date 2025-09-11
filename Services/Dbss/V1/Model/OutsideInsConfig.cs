using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 云实例配置
    /// </summary>
    public class OutsideInsConfig 
    {

        /// <summary>
        /// 主节点IP
        /// </summary>
        [JsonProperty("master_node_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterNodeIp { get; set; }

        /// <summary>
        /// 从节点IP
        /// </summary>
        [JsonProperty("slave_node_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveNodeIp { get; set; }

        /// <summary>
        /// 虚拟IP
        /// </summary>
        [JsonProperty("virtual_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string VirtualIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutsideInsConfig {\n");
            sb.Append("  masterNodeIp: ").Append(MasterNodeIp).Append("\n");
            sb.Append("  slaveNodeIp: ").Append(SlaveNodeIp).Append("\n");
            sb.Append("  virtualIp: ").Append(VirtualIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutsideInsConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OutsideInsConfig input)
        {
            if (input == null) return false;
            if (this.MasterNodeIp != input.MasterNodeIp || (this.MasterNodeIp != null && !this.MasterNodeIp.Equals(input.MasterNodeIp))) return false;
            if (this.SlaveNodeIp != input.SlaveNodeIp || (this.SlaveNodeIp != null && !this.SlaveNodeIp.Equals(input.SlaveNodeIp))) return false;
            if (this.VirtualIp != input.VirtualIp || (this.VirtualIp != null && !this.VirtualIp.Equals(input.VirtualIp))) return false;

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
                if (this.MasterNodeIp != null) hashCode = hashCode * 59 + this.MasterNodeIp.GetHashCode();
                if (this.SlaveNodeIp != null) hashCode = hashCode * 59 + this.SlaveNodeIp.GetHashCode();
                if (this.VirtualIp != null) hashCode = hashCode * 59 + this.VirtualIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
