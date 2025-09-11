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
    /// 磁盘使用情况
    /// </summary>
    public class DiskInfo 
    {

        /// <summary>
        /// 数据盘可用量
        /// </summary>
        [JsonProperty("data_available", NullValueHandling = NullValueHandling.Ignore)]
        public double? DataAvailable { get; set; }

        /// <summary>
        /// 数据盘总容量
        /// </summary>
        [JsonProperty("data_total", NullValueHandling = NullValueHandling.Ignore)]
        public double? DataTotal { get; set; }

        /// <summary>
        /// 数据盘使用百分比
        /// </summary>
        [JsonProperty("data_use_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? DataUsePercent { get; set; }

        /// <summary>
        /// 记录ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 临时目录可用量
        /// </summary>
        [JsonProperty("swap_available", NullValueHandling = NullValueHandling.Ignore)]
        public double? SwapAvailable { get; set; }

        /// <summary>
        /// 临时目录总容量
        /// </summary>
        [JsonProperty("swap_total", NullValueHandling = NullValueHandling.Ignore)]
        public double? SwapTotal { get; set; }

        /// <summary>
        /// 临时目录使用百分比
        /// </summary>
        [JsonProperty("swap_use_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? SwapUsePercent { get; set; }

        /// <summary>
        /// 系统盘可用量
        /// </summary>
        [JsonProperty("system_available", NullValueHandling = NullValueHandling.Ignore)]
        public double? SystemAvailable { get; set; }

        /// <summary>
        /// 系统盘容量
        /// </summary>
        [JsonProperty("system_total", NullValueHandling = NullValueHandling.Ignore)]
        public double? SystemTotal { get; set; }

        /// <summary>
        /// 系统盘使用百分比
        /// </summary>
        [JsonProperty("system_use_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? SystemUsePercent { get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiskInfo {\n");
            sb.Append("  dataAvailable: ").Append(DataAvailable).Append("\n");
            sb.Append("  dataTotal: ").Append(DataTotal).Append("\n");
            sb.Append("  dataUsePercent: ").Append(DataUsePercent).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  swapAvailable: ").Append(SwapAvailable).Append("\n");
            sb.Append("  swapTotal: ").Append(SwapTotal).Append("\n");
            sb.Append("  swapUsePercent: ").Append(SwapUsePercent).Append("\n");
            sb.Append("  systemAvailable: ").Append(SystemAvailable).Append("\n");
            sb.Append("  systemTotal: ").Append(SystemTotal).Append("\n");
            sb.Append("  systemUsePercent: ").Append(SystemUsePercent).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiskInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiskInfo input)
        {
            if (input == null) return false;
            if (this.DataAvailable != input.DataAvailable || (this.DataAvailable != null && !this.DataAvailable.Equals(input.DataAvailable))) return false;
            if (this.DataTotal != input.DataTotal || (this.DataTotal != null && !this.DataTotal.Equals(input.DataTotal))) return false;
            if (this.DataUsePercent != input.DataUsePercent || (this.DataUsePercent != null && !this.DataUsePercent.Equals(input.DataUsePercent))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.SwapAvailable != input.SwapAvailable || (this.SwapAvailable != null && !this.SwapAvailable.Equals(input.SwapAvailable))) return false;
            if (this.SwapTotal != input.SwapTotal || (this.SwapTotal != null && !this.SwapTotal.Equals(input.SwapTotal))) return false;
            if (this.SwapUsePercent != input.SwapUsePercent || (this.SwapUsePercent != null && !this.SwapUsePercent.Equals(input.SwapUsePercent))) return false;
            if (this.SystemAvailable != input.SystemAvailable || (this.SystemAvailable != null && !this.SystemAvailable.Equals(input.SystemAvailable))) return false;
            if (this.SystemTotal != input.SystemTotal || (this.SystemTotal != null && !this.SystemTotal.Equals(input.SystemTotal))) return false;
            if (this.SystemUsePercent != input.SystemUsePercent || (this.SystemUsePercent != null && !this.SystemUsePercent.Equals(input.SystemUsePercent))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;

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
                if (this.DataAvailable != null) hashCode = hashCode * 59 + this.DataAvailable.GetHashCode();
                if (this.DataTotal != null) hashCode = hashCode * 59 + this.DataTotal.GetHashCode();
                if (this.DataUsePercent != null) hashCode = hashCode * 59 + this.DataUsePercent.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SwapAvailable != null) hashCode = hashCode * 59 + this.SwapAvailable.GetHashCode();
                if (this.SwapTotal != null) hashCode = hashCode * 59 + this.SwapTotal.GetHashCode();
                if (this.SwapUsePercent != null) hashCode = hashCode * 59 + this.SwapUsePercent.GetHashCode();
                if (this.SystemAvailable != null) hashCode = hashCode * 59 + this.SystemAvailable.GetHashCode();
                if (this.SystemTotal != null) hashCode = hashCode * 59 + this.SystemTotal.GetHashCode();
                if (this.SystemUsePercent != null) hashCode = hashCode * 59 + this.SystemUsePercent.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }
}
