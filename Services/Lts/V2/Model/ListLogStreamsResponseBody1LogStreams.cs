using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListLogStreamsResponseBody1LogStreams 
    {

        /// <summary>
        /// 日志流创建时间
        /// </summary>
        [JsonProperty("creation_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreationTime { get; set; }

        /// <summary>
        /// 日志流ID
        /// </summary>
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// 日志流名称
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// 日志流别名
        /// </summary>
        [JsonProperty("log_stream_name_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamNameAlias { get; set; }

        /// <summary>
        /// 日志流所属标签
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tag { get; set; }

        /// <summary>
        /// 过滤器个数
        /// </summary>
        [JsonProperty("filter_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FilterCount { get; set; }

        /// <summary>
        /// 是否日志存储
        /// </summary>
        [JsonProperty("whether_log_storage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WhetherLogStorage { get; set; }

        /// <summary>
        /// 是否冷存储
        /// </summary>
        [JsonProperty("hot_cold_separation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HotColdSeparation { get; set; }

        /// <summary>
        /// 匿名写入开关
        /// </summary>
        [JsonProperty("auth_web_tracking", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AuthWebTracking { get; set; }

        /// <summary>
        /// 存储时间
        /// </summary>
        [JsonProperty("ttl_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? TtlInDays { get; set; }

        /// <summary>
        /// 标准存储时间
        /// </summary>
        [JsonProperty("hot_storage_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? HotStorageDays { get; set; }

        /// <summary>
        /// 日志组ID
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLogStreamsResponseBody1LogStreams {\n");
            sb.Append("  creationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("  logStreamNameAlias: ").Append(LogStreamNameAlias).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  filterCount: ").Append(FilterCount).Append("\n");
            sb.Append("  whetherLogStorage: ").Append(WhetherLogStorage).Append("\n");
            sb.Append("  hotColdSeparation: ").Append(HotColdSeparation).Append("\n");
            sb.Append("  authWebTracking: ").Append(AuthWebTracking).Append("\n");
            sb.Append("  ttlInDays: ").Append(TtlInDays).Append("\n");
            sb.Append("  hotStorageDays: ").Append(HotStorageDays).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLogStreamsResponseBody1LogStreams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLogStreamsResponseBody1LogStreams input)
        {
            if (input == null) return false;
            if (this.CreationTime != input.CreationTime || (this.CreationTime != null && !this.CreationTime.Equals(input.CreationTime))) return false;
            if (this.LogStreamId != input.LogStreamId || (this.LogStreamId != null && !this.LogStreamId.Equals(input.LogStreamId))) return false;
            if (this.LogStreamName != input.LogStreamName || (this.LogStreamName != null && !this.LogStreamName.Equals(input.LogStreamName))) return false;
            if (this.LogStreamNameAlias != input.LogStreamNameAlias || (this.LogStreamNameAlias != null && !this.LogStreamNameAlias.Equals(input.LogStreamNameAlias))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && input.Tag != null && !this.Tag.SequenceEqual(input.Tag))) return false;
            if (this.FilterCount != input.FilterCount || (this.FilterCount != null && !this.FilterCount.Equals(input.FilterCount))) return false;
            if (this.WhetherLogStorage != input.WhetherLogStorage || (this.WhetherLogStorage != null && !this.WhetherLogStorage.Equals(input.WhetherLogStorage))) return false;
            if (this.HotColdSeparation != input.HotColdSeparation || (this.HotColdSeparation != null && !this.HotColdSeparation.Equals(input.HotColdSeparation))) return false;
            if (this.AuthWebTracking != input.AuthWebTracking || (this.AuthWebTracking != null && !this.AuthWebTracking.Equals(input.AuthWebTracking))) return false;
            if (this.TtlInDays != input.TtlInDays || (this.TtlInDays != null && !this.TtlInDays.Equals(input.TtlInDays))) return false;
            if (this.HotStorageDays != input.HotStorageDays || (this.HotStorageDays != null && !this.HotStorageDays.Equals(input.HotStorageDays))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;

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
                if (this.CreationTime != null) hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LogStreamId != null) hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.LogStreamName != null) hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                if (this.LogStreamNameAlias != null) hashCode = hashCode * 59 + this.LogStreamNameAlias.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.FilterCount != null) hashCode = hashCode * 59 + this.FilterCount.GetHashCode();
                if (this.WhetherLogStorage != null) hashCode = hashCode * 59 + this.WhetherLogStorage.GetHashCode();
                if (this.HotColdSeparation != null) hashCode = hashCode * 59 + this.HotColdSeparation.GetHashCode();
                if (this.AuthWebTracking != null) hashCode = hashCode * 59 + this.AuthWebTracking.GetHashCode();
                if (this.TtlInDays != null) hashCode = hashCode * 59 + this.TtlInDays.GetHashCode();
                if (this.HotStorageDays != null) hashCode = hashCode * 59 + this.HotStorageDays.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
