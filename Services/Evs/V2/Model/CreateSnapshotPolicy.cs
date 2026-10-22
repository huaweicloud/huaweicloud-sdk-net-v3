using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 创建自动快照策略模型。
    /// </summary>
    public class CreateSnapshotPolicy 
    {

        /// <summary>
        /// 自动快照策略名称。最大支持255个字节。  最小长度：0  最大长度：255
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 自动快照的重复日期，单位为天，周期为星期。取值范围为 1~7，如 1 表示周一。  当一星期内需要创建多次自动快照时，可以传入多个时间点：  最多传入 7 个时间点。 多个时间点用一个格式类似\&quot;1\&quot;, \&quot;2\&quot;, … \&quot;7\&quot;的 JSON 数组表示，时间点之间用半角逗号（,）隔开。
        /// </summary>
        [JsonProperty("repeat_weekdays", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RepeatWeekdays { get; set; }

        /// <summary>
        /// 自动快照的间隔日期，单位为天，取值范围为 1~30,如1表示每天。
        /// </summary>
        [JsonProperty("repeat_interval_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepeatIntervalDays { get; set; }

        /// <summary>
        /// 自动快照的创建时间点。使用 UTC +8 时间，单位为小时。取值范围为 0~23，代表 00:00 至 23:00 共 24 个时间点，如 1 表示 01:00。  当一天内需要创建多次自动快照时，可以传入多个时间点：  最多传入 24 个时间点。 多个时间点用一个格式类似\&quot;0\&quot;, \&quot;1\&quot;, … \&quot;23\&quot;的 JSON 数组表示，时间点之间用半角逗号（,）隔开。
        /// </summary>
        [JsonProperty("time_points", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TimePoints { get; set; }

        /// <summary>
        /// 设置快照的保留时间，单位为天。保留时间到期后快照会被自动释放，取值范围：1~65536。 缺省值：-1，表示快照持续保留。
        /// </summary>
        [JsonProperty("retention_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// 设置自动快照策略的标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// 企业项目id。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSnapshotPolicy {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  repeatWeekdays: ").Append(RepeatWeekdays).Append("\n");
            sb.Append("  repeatIntervalDays: ").Append(RepeatIntervalDays).Append("\n");
            sb.Append("  timePoints: ").Append(TimePoints).Append("\n");
            sb.Append("  retentionDays: ").Append(RetentionDays).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSnapshotPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSnapshotPolicy input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.RepeatWeekdays != input.RepeatWeekdays || (this.RepeatWeekdays != null && input.RepeatWeekdays != null && !this.RepeatWeekdays.SequenceEqual(input.RepeatWeekdays))) return false;
            if (this.RepeatIntervalDays != input.RepeatIntervalDays || (this.RepeatIntervalDays != null && !this.RepeatIntervalDays.Equals(input.RepeatIntervalDays))) return false;
            if (this.TimePoints != input.TimePoints || (this.TimePoints != null && input.TimePoints != null && !this.TimePoints.SequenceEqual(input.TimePoints))) return false;
            if (this.RetentionDays != input.RetentionDays || (this.RetentionDays != null && !this.RetentionDays.Equals(input.RetentionDays))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RepeatWeekdays != null) hashCode = hashCode * 59 + this.RepeatWeekdays.GetHashCode();
                if (this.RepeatIntervalDays != null) hashCode = hashCode * 59 + this.RepeatIntervalDays.GetHashCode();
                if (this.TimePoints != null) hashCode = hashCode * 59 + this.TimePoints.GetHashCode();
                if (this.RetentionDays != null) hashCode = hashCode * 59 + this.RetentionDays.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
