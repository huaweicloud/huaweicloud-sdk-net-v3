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
    /// 网络驱动器映射选项。
    /// </summary>
    public class PoliciesPersonalizedDataMgmtNetworkDriveMappingOptions 
    {

        /// <summary>
        /// 网络驱动器映射路径。
        /// </summary>
        [JsonProperty("network_drive_mapping_path", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkDriveMappingPath { get; set; }

        /// <summary>
        /// 排除文件夹路径。
        /// </summary>
        [JsonProperty("drive_letter", NullValueHandling = NullValueHandling.Ignore)]
        public string DriveLetter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPersonalizedDataMgmtNetworkDriveMappingOptions {\n");
            sb.Append("  networkDriveMappingPath: ").Append(NetworkDriveMappingPath).Append("\n");
            sb.Append("  driveLetter: ").Append(DriveLetter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPersonalizedDataMgmtNetworkDriveMappingOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPersonalizedDataMgmtNetworkDriveMappingOptions input)
        {
            if (input == null) return false;
            if (this.NetworkDriveMappingPath != input.NetworkDriveMappingPath || (this.NetworkDriveMappingPath != null && !this.NetworkDriveMappingPath.Equals(input.NetworkDriveMappingPath))) return false;
            if (this.DriveLetter != input.DriveLetter || (this.DriveLetter != null && !this.DriveLetter.Equals(input.DriveLetter))) return false;

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
                if (this.NetworkDriveMappingPath != null) hashCode = hashCode * 59 + this.NetworkDriveMappingPath.GetHashCode();
                if (this.DriveLetter != null) hashCode = hashCode * 59 + this.DriveLetter.GetHashCode();
                return hashCode;
            }
        }
    }
}
