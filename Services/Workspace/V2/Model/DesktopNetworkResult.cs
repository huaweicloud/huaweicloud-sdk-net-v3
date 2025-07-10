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
    /// 桌面网络查询结果。
    /// </summary>
    public class DesktopNetworkResult 
    {

        /// <summary>
        /// 桌面名称。
        /// </summary>
        [JsonProperty("computer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComputerName { get; set; }

        /// <summary>
        /// 桌面ID。
        /// </summary>
        [JsonProperty("computer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComputerId { get; set; }

        /// <summary>
        /// 桌面IP。
        /// </summary>
        [JsonProperty("computer_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ComputerIp { get; set; }

        /// <summary>
        /// 桌面网络信息。
        /// </summary>
        [JsonProperty("network_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<NetworkInfo> NetworkInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopNetworkResult {\n");
            sb.Append("  computerName: ").Append(ComputerName).Append("\n");
            sb.Append("  computerId: ").Append(ComputerId).Append("\n");
            sb.Append("  computerIp: ").Append(ComputerIp).Append("\n");
            sb.Append("  networkInfos: ").Append(NetworkInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesktopNetworkResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesktopNetworkResult input)
        {
            if (input == null) return false;
            if (this.ComputerName != input.ComputerName || (this.ComputerName != null && !this.ComputerName.Equals(input.ComputerName))) return false;
            if (this.ComputerId != input.ComputerId || (this.ComputerId != null && !this.ComputerId.Equals(input.ComputerId))) return false;
            if (this.ComputerIp != input.ComputerIp || (this.ComputerIp != null && !this.ComputerIp.Equals(input.ComputerIp))) return false;
            if (this.NetworkInfos != input.NetworkInfos || (this.NetworkInfos != null && input.NetworkInfos != null && !this.NetworkInfos.SequenceEqual(input.NetworkInfos))) return false;

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
                if (this.ComputerName != null) hashCode = hashCode * 59 + this.ComputerName.GetHashCode();
                if (this.ComputerId != null) hashCode = hashCode * 59 + this.ComputerId.GetHashCode();
                if (this.ComputerIp != null) hashCode = hashCode * 59 + this.ComputerIp.GetHashCode();
                if (this.NetworkInfos != null) hashCode = hashCode * 59 + this.NetworkInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
