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
    public class SqlRequestResponse 
    {

        /// <summary>
        /// **参数解释：** 日志流ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// **参数解释：** 日志流名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// **参数解释：** 日志流ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// **参数解释：** 日志组名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// **参数解释：** SQL语句。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("sql", NullValueHandling = NullValueHandling.Ignore)]
        public string Sql { get; set; }

        /// <summary>
        /// **参数解释：** 配置告警关联的图表名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("sql_request_title", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlRequestTitle { get; set; }

        /// <summary>
        /// **参数解释：** 查询执行告警任务时最近数据的时间范围。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("search_time_range", NullValueHandling = NullValueHandling.Ignore)]
        public int? SearchTimeRange { get; set; }

        /// <summary>
        /// **参数解释：** 查询告警时间范围单位。 **取值范围：** - minute - hour
        /// </summary>
        [JsonProperty("search_time_range_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchTimeRangeUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_date", NullValueHandling = NullValueHandling.Ignore)]
        public CustomDate CustomDate { get; set; }

        /// <summary>
        /// **参数解释：** 告警查询日志的时间区间为相对时间还是整点时间。 **约束限制：** 不涉及。 **取值范围：** - true: 相对时间。 - false: 整点时间。 **默认取值：** true
        /// </summary>
        [JsonProperty("is_time_range_relative", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTimeRangeRelative { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlRequestResponse {\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  sql: ").Append(Sql).Append("\n");
            sb.Append("  sqlRequestTitle: ").Append(SqlRequestTitle).Append("\n");
            sb.Append("  searchTimeRange: ").Append(SearchTimeRange).Append("\n");
            sb.Append("  searchTimeRangeUnit: ").Append(SearchTimeRangeUnit).Append("\n");
            sb.Append("  customDate: ").Append(CustomDate).Append("\n");
            sb.Append("  isTimeRangeRelative: ").Append(IsTimeRangeRelative).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlRequestResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlRequestResponse input)
        {
            if (input == null) return false;
            if (this.LogStreamId != input.LogStreamId || (this.LogStreamId != null && !this.LogStreamId.Equals(input.LogStreamId))) return false;
            if (this.LogStreamName != input.LogStreamName || (this.LogStreamName != null && !this.LogStreamName.Equals(input.LogStreamName))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;
            if (this.LogGroupName != input.LogGroupName || (this.LogGroupName != null && !this.LogGroupName.Equals(input.LogGroupName))) return false;
            if (this.Sql != input.Sql || (this.Sql != null && !this.Sql.Equals(input.Sql))) return false;
            if (this.SqlRequestTitle != input.SqlRequestTitle || (this.SqlRequestTitle != null && !this.SqlRequestTitle.Equals(input.SqlRequestTitle))) return false;
            if (this.SearchTimeRange != input.SearchTimeRange || (this.SearchTimeRange != null && !this.SearchTimeRange.Equals(input.SearchTimeRange))) return false;
            if (this.SearchTimeRangeUnit != input.SearchTimeRangeUnit || (this.SearchTimeRangeUnit != null && !this.SearchTimeRangeUnit.Equals(input.SearchTimeRangeUnit))) return false;
            if (this.CustomDate != input.CustomDate || (this.CustomDate != null && !this.CustomDate.Equals(input.CustomDate))) return false;
            if (this.IsTimeRangeRelative != input.IsTimeRangeRelative || (this.IsTimeRangeRelative != null && !this.IsTimeRangeRelative.Equals(input.IsTimeRangeRelative))) return false;

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
                if (this.LogStreamId != null) hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.LogStreamName != null) hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogGroupName != null) hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.Sql != null) hashCode = hashCode * 59 + this.Sql.GetHashCode();
                if (this.SqlRequestTitle != null) hashCode = hashCode * 59 + this.SqlRequestTitle.GetHashCode();
                if (this.SearchTimeRange != null) hashCode = hashCode * 59 + this.SearchTimeRange.GetHashCode();
                if (this.SearchTimeRangeUnit != null) hashCode = hashCode * 59 + this.SearchTimeRangeUnit.GetHashCode();
                if (this.CustomDate != null) hashCode = hashCode * 59 + this.CustomDate.GetHashCode();
                if (this.IsTimeRangeRelative != null) hashCode = hashCode * 59 + this.IsTimeRangeRelative.GetHashCode();
                return hashCode;
            }
        }
    }
}
