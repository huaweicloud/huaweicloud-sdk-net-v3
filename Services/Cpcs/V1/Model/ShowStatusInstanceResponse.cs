using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowStatusInstanceResponse : SdkResponse
    {

        /// <summary>
        /// CPU使用率
        /// </summary>
        [JsonProperty("cpu_utils", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowStatusInstanceItem> CpuUtils { get; set; }

        /// <summary>
        /// 内存使用率
        /// </summary>
        [JsonProperty("mem_utils", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowStatusInstanceItem> MemUtils { get; set; }

        /// <summary>
        /// 磁盘使用率
        /// </summary>
        [JsonProperty("disk_utils", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowStatusInstanceItem> DiskUtils { get; set; }

        /// <summary>
        /// CPU使用率对应实例名称
        /// </summary>
        [JsonProperty("cpu_util_instance_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CpuUtilInstanceNames { get; set; }

        /// <summary>
        /// 内存使用率对应实例名称
        /// </summary>
        [JsonProperty("mem_util_instance_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MemUtilInstanceNames { get; set; }

        /// <summary>
        /// 磁盘使用率对应实例名称
        /// </summary>
        [JsonProperty("disk_util_instance_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DiskUtilInstanceNames { get; set; }

        /// <summary>
        /// CPU使用率平均值
        /// </summary>
        [JsonProperty("cpu_util_averages", NullValueHandling = NullValueHandling.Ignore)]
        public List<double?> CpuUtilAverages { get; set; }

        /// <summary>
        /// 内存使用率平均值
        /// </summary>
        [JsonProperty("mem_util_averages", NullValueHandling = NullValueHandling.Ignore)]
        public List<double?> MemUtilAverages { get; set; }

        /// <summary>
        /// 磁盘使用率平均值
        /// </summary>
        [JsonProperty("disk_util_averages", NullValueHandling = NullValueHandling.Ignore)]
        public List<double?> DiskUtilAverages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStatusInstanceResponse {\n");
            sb.Append("  cpuUtils: ").Append(CpuUtils).Append("\n");
            sb.Append("  memUtils: ").Append(MemUtils).Append("\n");
            sb.Append("  diskUtils: ").Append(DiskUtils).Append("\n");
            sb.Append("  cpuUtilInstanceNames: ").Append(CpuUtilInstanceNames).Append("\n");
            sb.Append("  memUtilInstanceNames: ").Append(MemUtilInstanceNames).Append("\n");
            sb.Append("  diskUtilInstanceNames: ").Append(DiskUtilInstanceNames).Append("\n");
            sb.Append("  cpuUtilAverages: ").Append(CpuUtilAverages).Append("\n");
            sb.Append("  memUtilAverages: ").Append(MemUtilAverages).Append("\n");
            sb.Append("  diskUtilAverages: ").Append(DiskUtilAverages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStatusInstanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStatusInstanceResponse input)
        {
            if (input == null) return false;
            if (this.CpuUtils != input.CpuUtils || (this.CpuUtils != null && input.CpuUtils != null && !this.CpuUtils.SequenceEqual(input.CpuUtils))) return false;
            if (this.MemUtils != input.MemUtils || (this.MemUtils != null && input.MemUtils != null && !this.MemUtils.SequenceEqual(input.MemUtils))) return false;
            if (this.DiskUtils != input.DiskUtils || (this.DiskUtils != null && input.DiskUtils != null && !this.DiskUtils.SequenceEqual(input.DiskUtils))) return false;
            if (this.CpuUtilInstanceNames != input.CpuUtilInstanceNames || (this.CpuUtilInstanceNames != null && input.CpuUtilInstanceNames != null && !this.CpuUtilInstanceNames.SequenceEqual(input.CpuUtilInstanceNames))) return false;
            if (this.MemUtilInstanceNames != input.MemUtilInstanceNames || (this.MemUtilInstanceNames != null && input.MemUtilInstanceNames != null && !this.MemUtilInstanceNames.SequenceEqual(input.MemUtilInstanceNames))) return false;
            if (this.DiskUtilInstanceNames != input.DiskUtilInstanceNames || (this.DiskUtilInstanceNames != null && input.DiskUtilInstanceNames != null && !this.DiskUtilInstanceNames.SequenceEqual(input.DiskUtilInstanceNames))) return false;
            if (this.CpuUtilAverages != input.CpuUtilAverages || (this.CpuUtilAverages != null && input.CpuUtilAverages != null && !this.CpuUtilAverages.SequenceEqual(input.CpuUtilAverages))) return false;
            if (this.MemUtilAverages != input.MemUtilAverages || (this.MemUtilAverages != null && input.MemUtilAverages != null && !this.MemUtilAverages.SequenceEqual(input.MemUtilAverages))) return false;
            if (this.DiskUtilAverages != input.DiskUtilAverages || (this.DiskUtilAverages != null && input.DiskUtilAverages != null && !this.DiskUtilAverages.SequenceEqual(input.DiskUtilAverages))) return false;

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
                if (this.CpuUtils != null) hashCode = hashCode * 59 + this.CpuUtils.GetHashCode();
                if (this.MemUtils != null) hashCode = hashCode * 59 + this.MemUtils.GetHashCode();
                if (this.DiskUtils != null) hashCode = hashCode * 59 + this.DiskUtils.GetHashCode();
                if (this.CpuUtilInstanceNames != null) hashCode = hashCode * 59 + this.CpuUtilInstanceNames.GetHashCode();
                if (this.MemUtilInstanceNames != null) hashCode = hashCode * 59 + this.MemUtilInstanceNames.GetHashCode();
                if (this.DiskUtilInstanceNames != null) hashCode = hashCode * 59 + this.DiskUtilInstanceNames.GetHashCode();
                if (this.CpuUtilAverages != null) hashCode = hashCode * 59 + this.CpuUtilAverages.GetHashCode();
                if (this.MemUtilAverages != null) hashCode = hashCode * 59 + this.MemUtilAverages.GetHashCode();
                if (this.DiskUtilAverages != null) hashCode = hashCode * 59 + this.DiskUtilAverages.GetHashCode();
                return hashCode;
            }
        }
    }
}
