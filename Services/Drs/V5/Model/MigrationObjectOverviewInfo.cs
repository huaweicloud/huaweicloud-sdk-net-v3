using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 迁移详情概览。
    /// </summary>
    public class MigrationObjectOverviewInfo 
    {

        /// <summary>
        /// 类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 待迁移数量。
        /// </summary>
        [JsonProperty("src_count", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcCount { get; set; }

        /// <summary>
        /// 已迁移数量。
        /// </summary>
        [JsonProperty("dst_count", NullValueHandling = NullValueHandling.Ignore)]
        public string DstCount { get; set; }

        /// <summary>
        /// 状态.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationObjectOverviewInfo {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  srcCount: ").Append(SrcCount).Append("\n");
            sb.Append("  dstCount: ").Append(DstCount).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrationObjectOverviewInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrationObjectOverviewInfo input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.SrcCount != input.SrcCount || (this.SrcCount != null && !this.SrcCount.Equals(input.SrcCount))) return false;
            if (this.DstCount != input.DstCount || (this.DstCount != null && !this.DstCount.Equals(input.DstCount))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SrcCount != null) hashCode = hashCode * 59 + this.SrcCount.GetHashCode();
                if (this.DstCount != null) hashCode = hashCode * 59 + this.DstCount.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
