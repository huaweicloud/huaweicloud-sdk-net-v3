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
    /// Response Object
    /// </summary>
    public class ListSlowlogForLtsResponse : SdkResponse
    {

        /// <summary>
        /// 日志数据集合。
        /// </summary>
        [JsonProperty("slow_log_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlSlowLogDetailsItem> SlowLogList { get; set; }

        /// <summary>
        /// 当前慢日志阈值时间。
        /// </summary>
        [JsonProperty("long_query_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LongQueryTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSlowlogForLtsResponse {\n");
            sb.Append("  slowLogList: ").Append(SlowLogList).Append("\n");
            sb.Append("  longQueryTime: ").Append(LongQueryTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSlowlogForLtsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSlowlogForLtsResponse input)
        {
            if (input == null) return false;
            if (this.SlowLogList != input.SlowLogList || (this.SlowLogList != null && input.SlowLogList != null && !this.SlowLogList.SequenceEqual(input.SlowLogList))) return false;
            if (this.LongQueryTime != input.LongQueryTime || (this.LongQueryTime != null && !this.LongQueryTime.Equals(input.LongQueryTime))) return false;

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
                if (this.SlowLogList != null) hashCode = hashCode * 59 + this.SlowLogList.GetHashCode();
                if (this.LongQueryTime != null) hashCode = hashCode * 59 + this.LongQueryTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
