using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 周期会议的参数。
    /// </summary>
    public class CycleParams 
    {

        /// <summary>
        /// 周期会议的开始日期，格式：YYYY-MM-DD。 开始日期不能早于当前日期。 &gt; 日期是timeZoneID指定的时区的日期，非UTC时间的日期。
        /// </summary>
        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// 周期会议的结束日期，格式：YYYY-MM-DD。 开始日期和结束日期间的时间间隔最长不能超过1年。开始日期和结束日期之间最多允许50个子会议，若超过50个子会议，会自动调整结束日期。 &gt; 日期是timeZoneID指定的时区的日期，非UTC时间的日期。
        /// </summary>
        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// 周期类型。 - Day: 天 - Week: 星期 - Month: 月
        /// </summary>
        [JsonProperty("cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string Cycle { get; set; }

        /// <summary>
        /// 子会议间隔。 - cycle选择了Day，表示每几天召开一次，取值范围[1,15] - cycle选择了Week，表示每几周召开一次，取值范围[1,5] - cycle选择了Month，Interval表示隔几月，取值范围[1,3]
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// 周期内的会议召开点。仅当按周和月时有效。 - cycle选择了Week，point中填入了两个元素1和3，则表示每个周一和周三召开会议，0表示周日 - cycle选择了Month，point中填入了12和20则表示每个月的12号和20号召开会议，取值范围为[1,31]，若当月没有该值，则为月末
        /// </summary>
        [JsonProperty("point", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Point { get; set; }

        /// <summary>
        /// 提前通知天数。所有与会者在每个子会议开始前N天收到会议通知。取值范围[0,30]。 默认值是1。
        /// </summary>
        [JsonProperty("preRemindDays", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreRemindDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CycleParams {\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("  cycle: ").Append(Cycle).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  point: ").Append(Point).Append("\n");
            sb.Append("  preRemindDays: ").Append(PreRemindDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CycleParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CycleParams input)
        {
            if (input == null) return false;
            if (this.StartDate != input.StartDate || (this.StartDate != null && !this.StartDate.Equals(input.StartDate))) return false;
            if (this.EndDate != input.EndDate || (this.EndDate != null && !this.EndDate.Equals(input.EndDate))) return false;
            if (this.Cycle != input.Cycle || (this.Cycle != null && !this.Cycle.Equals(input.Cycle))) return false;
            if (this.Interval != input.Interval || (this.Interval != null && !this.Interval.Equals(input.Interval))) return false;
            if (this.Point != input.Point || (this.Point != null && input.Point != null && !this.Point.SequenceEqual(input.Point))) return false;
            if (this.PreRemindDays != input.PreRemindDays || (this.PreRemindDays != null && !this.PreRemindDays.Equals(input.PreRemindDays))) return false;

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
                if (this.StartDate != null) hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null) hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Cycle != null) hashCode = hashCode * 59 + this.Cycle.GetHashCode();
                if (this.Interval != null) hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.Point != null) hashCode = hashCode * 59 + this.Point.GetHashCode();
                if (this.PreRemindDays != null) hashCode = hashCode * 59 + this.PreRemindDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
