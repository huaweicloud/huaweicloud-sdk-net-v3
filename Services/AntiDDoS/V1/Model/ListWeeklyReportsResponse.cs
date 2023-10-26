using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListWeeklyReportsResponse : SdkResponse
    {

        /// <summary>
        /// 一周内DDoS拦截次数
        /// </summary>
        [JsonProperty("ddos_intercept_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? DdosInterceptTimes { get; set; }

        /// <summary>
        /// 一周的攻击次数统计数据
        /// </summary>
        [JsonProperty("weekdata", NullValueHandling = NullValueHandling.Ignore)]
        public List<WeeklyCount> Weekdata { get; set; }

        /// <summary>
        /// 被攻击次数排名前10的IP地址
        /// </summary>
        [JsonProperty("top10", NullValueHandling = NullValueHandling.Ignore)]
        public List<WeeklyTop10> Top10 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWeeklyReportsResponse {\n");
            sb.Append("  ddosInterceptTimes: ").Append(DdosInterceptTimes).Append("\n");
            sb.Append("  weekdata: ").Append(Weekdata).Append("\n");
            sb.Append("  top10: ").Append(Top10).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWeeklyReportsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWeeklyReportsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DdosInterceptTimes == input.DdosInterceptTimes ||
                    (this.DdosInterceptTimes != null &&
                    this.DdosInterceptTimes.Equals(input.DdosInterceptTimes))
                ) && 
                (
                    this.Weekdata == input.Weekdata ||
                    this.Weekdata != null &&
                    input.Weekdata != null &&
                    this.Weekdata.SequenceEqual(input.Weekdata)
                ) && 
                (
                    this.Top10 == input.Top10 ||
                    this.Top10 != null &&
                    input.Top10 != null &&
                    this.Top10.SequenceEqual(input.Top10)
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
                if (this.DdosInterceptTimes != null)
                    hashCode = hashCode * 59 + this.DdosInterceptTimes.GetHashCode();
                if (this.Weekdata != null)
                    hashCode = hashCode * 59 + this.Weekdata.GetHashCode();
                if (this.Top10 != null)
                    hashCode = hashCode * 59 + this.Top10.GetHashCode();
                return hashCode;
            }
        }
    }
}
