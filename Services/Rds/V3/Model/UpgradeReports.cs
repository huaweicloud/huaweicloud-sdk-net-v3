using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpgradeReports 
    {

        /// <summary>
        /// 升级报告ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 升级开始时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 升级结束时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 原实例ID。
        /// </summary>
        [JsonProperty("src_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcInstanceId { get; set; }

        /// <summary>
        /// 原数据库版本。
        /// </summary>
        [JsonProperty("src_database_version", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcDatabaseVersion { get; set; }

        /// <summary>
        /// 目标实例ID。
        /// </summary>
        [JsonProperty("dst_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DstInstanceId { get; set; }

        /// <summary>
        /// 目标数据库版本。
        /// </summary>
        [JsonProperty("dst_database_version", NullValueHandling = NullValueHandling.Ignore)]
        public string DstDatabaseVersion { get; set; }

        /// <summary>
        /// 升级结果。 success，表示成功。 failed，表示失败。 running， 表示升级中。
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 实例内网IP是否改变。 true，表示改变。 false，表示不改变。
        /// </summary>
        [JsonProperty("is_private_ip_changed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPrivateIpChanged { get; set; }

        /// <summary>
        /// 实例内网IP修改时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [JsonProperty("private_ip_change_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIpChangeTime { get; set; }

        /// <summary>
        /// 统计信息收集模式。 before_change_private_ip，修改实例内网IP前收集。 after_change_private_ip，修改实例内网IP后收集。
        /// </summary>
        [JsonProperty("statistics_collection_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string StatisticsCollectionMode { get; set; }

        /// <summary>
        /// 升级报告详情。
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeReports {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  srcInstanceId: ").Append(SrcInstanceId).Append("\n");
            sb.Append("  srcDatabaseVersion: ").Append(SrcDatabaseVersion).Append("\n");
            sb.Append("  dstInstanceId: ").Append(DstInstanceId).Append("\n");
            sb.Append("  dstDatabaseVersion: ").Append(DstDatabaseVersion).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  isPrivateIpChanged: ").Append(IsPrivateIpChanged).Append("\n");
            sb.Append("  privateIpChangeTime: ").Append(PrivateIpChangeTime).Append("\n");
            sb.Append("  statisticsCollectionMode: ").Append(StatisticsCollectionMode).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeReports);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeReports input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.SrcInstanceId == input.SrcInstanceId ||
                    (this.SrcInstanceId != null &&
                    this.SrcInstanceId.Equals(input.SrcInstanceId))
                ) && 
                (
                    this.SrcDatabaseVersion == input.SrcDatabaseVersion ||
                    (this.SrcDatabaseVersion != null &&
                    this.SrcDatabaseVersion.Equals(input.SrcDatabaseVersion))
                ) && 
                (
                    this.DstInstanceId == input.DstInstanceId ||
                    (this.DstInstanceId != null &&
                    this.DstInstanceId.Equals(input.DstInstanceId))
                ) && 
                (
                    this.DstDatabaseVersion == input.DstDatabaseVersion ||
                    (this.DstDatabaseVersion != null &&
                    this.DstDatabaseVersion.Equals(input.DstDatabaseVersion))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.IsPrivateIpChanged == input.IsPrivateIpChanged ||
                    (this.IsPrivateIpChanged != null &&
                    this.IsPrivateIpChanged.Equals(input.IsPrivateIpChanged))
                ) && 
                (
                    this.PrivateIpChangeTime == input.PrivateIpChangeTime ||
                    (this.PrivateIpChangeTime != null &&
                    this.PrivateIpChangeTime.Equals(input.PrivateIpChangeTime))
                ) && 
                (
                    this.StatisticsCollectionMode == input.StatisticsCollectionMode ||
                    (this.StatisticsCollectionMode != null &&
                    this.StatisticsCollectionMode.Equals(input.StatisticsCollectionMode))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.SrcInstanceId != null)
                    hashCode = hashCode * 59 + this.SrcInstanceId.GetHashCode();
                if (this.SrcDatabaseVersion != null)
                    hashCode = hashCode * 59 + this.SrcDatabaseVersion.GetHashCode();
                if (this.DstInstanceId != null)
                    hashCode = hashCode * 59 + this.DstInstanceId.GetHashCode();
                if (this.DstDatabaseVersion != null)
                    hashCode = hashCode * 59 + this.DstDatabaseVersion.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.IsPrivateIpChanged != null)
                    hashCode = hashCode * 59 + this.IsPrivateIpChanged.GetHashCode();
                if (this.PrivateIpChangeTime != null)
                    hashCode = hashCode * 59 + this.PrivateIpChangeTime.GetHashCode();
                if (this.StatisticsCollectionMode != null)
                    hashCode = hashCode * 59 + this.StatisticsCollectionMode.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                return hashCode;
            }
        }
    }
}
