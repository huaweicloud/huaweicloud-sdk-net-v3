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
    /// Response Object
    /// </summary>
    public class ShowInstanceMonitorInfoResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("disk_infos", NullValueHandling = NullValueHandling.Ignore)]
        public DiskInfo DiskInfos { get; set; }

        /// <summary>
        /// 系统信息
        /// </summary>
        [JsonProperty("system_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<SystemInfo> SystemInfos { get; set; }

        /// <summary>
        /// 流量统计
        /// </summary>
        [JsonProperty("traffic_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<TrafficInfo> TrafficInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceMonitorInfoResponse {\n");
            sb.Append("  diskInfos: ").Append(DiskInfos).Append("\n");
            sb.Append("  systemInfos: ").Append(SystemInfos).Append("\n");
            sb.Append("  trafficInfos: ").Append(TrafficInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceMonitorInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceMonitorInfoResponse input)
        {
            if (input == null) return false;
            if (this.DiskInfos != input.DiskInfos || (this.DiskInfos != null && !this.DiskInfos.Equals(input.DiskInfos))) return false;
            if (this.SystemInfos != input.SystemInfos || (this.SystemInfos != null && input.SystemInfos != null && !this.SystemInfos.SequenceEqual(input.SystemInfos))) return false;
            if (this.TrafficInfos != input.TrafficInfos || (this.TrafficInfos != null && input.TrafficInfos != null && !this.TrafficInfos.SequenceEqual(input.TrafficInfos))) return false;

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
                if (this.DiskInfos != null) hashCode = hashCode * 59 + this.DiskInfos.GetHashCode();
                if (this.SystemInfos != null) hashCode = hashCode * 59 + this.SystemInfos.GetHashCode();
                if (this.TrafficInfos != null) hashCode = hashCode * 59 + this.TrafficInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
