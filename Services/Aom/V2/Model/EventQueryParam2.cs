using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 查询事件或者告警信息 。
    /// </summary>
    public class EventQueryParam2 
    {

        /// <summary>
        /// timeRange用于指标查询时间范围，主要用于解决客户端时间和服务端时间不一致情况下，查询最近N分钟的数据。另可用于精确查询某一段时间的数据。   如：   - -1.-1.60(表示最近60分钟)，不管当前客户端是什么时间，都以服务端时间为准查询最近60分钟。  - 1650852000000.1650852300000.5(表示GMT+8 2022-04-25 10:00:00至2022-04-25 10:05:00指定的5分钟)   格式：   startTimeInMillis.endTimeInMillis.durationInMinutes   参数解释：   - startTimeInMillis: 查询的开始时间，格式为UTC毫秒，如果指定为-1，服务端将按(endTimeInMillis - durationInMinutes * 60 * 1000)计算开始时间。如-1.1650852300000.5，则相当于1650852000000.1650852300000.5  - endTimeInMillis: 查询的结束时间，格式为UTC毫秒，如果指定为-1，服务端将按(startTimeInMillis + durationInMinutes * 60 * 1000)计算结束时间，如果计算出的结束时间大于当前系统时间，则使用当前系统时间。如1650852000000.-1.5，则相当于1650852000000.1650852300000.5  - durationInMinutes：查询时间的跨度分钟数。 取值范围大于0并且大于等于(endTimeInMillis - startTimeInMillis) / (60 * 1000) - 1。当开始时间与结束时间都设置为-1时，系统会将结束时间设置为当前时间UTC毫秒值，并按(endTimeInMillis - durationInMinutes * 60 * 1000)计算开始时间。如：-1.-1.60(表示最近60分钟)   约束：   单次请求中，查询时长与周期需要满足以下条件: durationInMinutes * 60 / period &lt;&#x3D; 1440
        /// </summary>
        [JsonProperty("time_range", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeRange { get; set; }

        /// <summary>
        /// 统计步长。毫秒数，例如一分钟则填写为60000。
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public long? Step { get; set; }

        /// <summary>
        /// 模糊查询匹配字段，可以为空。如果值不为空，可以模糊匹配。metadata字段为必选字段。
        /// </summary>
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public EventQueryParam2Sort Sort { get; set; }

        /// <summary>
        /// 查询条件组合，可以为空。
        /// </summary>
        [JsonProperty("metadata_relation", NullValueHandling = NullValueHandling.Ignore)]
        public List<RelationModel> MetadataRelation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventQueryParam2 {\n");
            sb.Append("  timeRange: ").Append(TimeRange).Append("\n");
            sb.Append("  step: ").Append(Step).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  metadataRelation: ").Append(MetadataRelation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventQueryParam2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventQueryParam2 input)
        {
            if (input == null) return false;
            if (this.TimeRange != input.TimeRange || (this.TimeRange != null && !this.TimeRange.Equals(input.TimeRange))) return false;
            if (this.Step != input.Step || (this.Step != null && !this.Step.Equals(input.Step))) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.Sort != input.Sort || (this.Sort != null && !this.Sort.Equals(input.Sort))) return false;
            if (this.MetadataRelation != input.MetadataRelation || (this.MetadataRelation != null && input.MetadataRelation != null && !this.MetadataRelation.SequenceEqual(input.MetadataRelation))) return false;

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
                if (this.TimeRange != null) hashCode = hashCode * 59 + this.TimeRange.GetHashCode();
                if (this.Step != null) hashCode = hashCode * 59 + this.Step.GetHashCode();
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.Sort != null) hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.MetadataRelation != null) hashCode = hashCode * 59 + this.MetadataRelation.GetHashCode();
                return hashCode;
            }
        }
    }
}
