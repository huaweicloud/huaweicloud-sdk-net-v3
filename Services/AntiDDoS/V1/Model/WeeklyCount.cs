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
    /// WeeklyCount
    /// </summary>
    public class WeeklyCount 
    {

        /// <summary>
        /// DDoS拦截次数
        /// </summary>
        [JsonProperty("ddos_intercept_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? DdosInterceptTimes { get; set; }

        /// <summary>
        /// DDoS黑洞次数
        /// </summary>
        [JsonProperty("ddos_blackhole_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? DdosBlackholeTimes { get; set; }

        /// <summary>
        /// 最大攻击流量
        /// </summary>
        [JsonProperty("max_attack_bps", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxAttackBps { get; set; }

        /// <summary>
        /// 最大攻击连接数
        /// </summary>
        [JsonProperty("max_attack_conns", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxAttackConns { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("period_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? PeriodStartDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeeklyCount {\n");
            sb.Append("  ddosInterceptTimes: ").Append(DdosInterceptTimes).Append("\n");
            sb.Append("  ddosBlackholeTimes: ").Append(DdosBlackholeTimes).Append("\n");
            sb.Append("  maxAttackBps: ").Append(MaxAttackBps).Append("\n");
            sb.Append("  maxAttackConns: ").Append(MaxAttackConns).Append("\n");
            sb.Append("  periodStartDate: ").Append(PeriodStartDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WeeklyCount);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WeeklyCount input)
        {
            if (input == null) return false;
            if (this.DdosInterceptTimes != input.DdosInterceptTimes || (this.DdosInterceptTimes != null && !this.DdosInterceptTimes.Equals(input.DdosInterceptTimes))) return false;
            if (this.DdosBlackholeTimes != input.DdosBlackholeTimes || (this.DdosBlackholeTimes != null && !this.DdosBlackholeTimes.Equals(input.DdosBlackholeTimes))) return false;
            if (this.MaxAttackBps != input.MaxAttackBps || (this.MaxAttackBps != null && !this.MaxAttackBps.Equals(input.MaxAttackBps))) return false;
            if (this.MaxAttackConns != input.MaxAttackConns || (this.MaxAttackConns != null && !this.MaxAttackConns.Equals(input.MaxAttackConns))) return false;
            if (this.PeriodStartDate != input.PeriodStartDate || (this.PeriodStartDate != null && !this.PeriodStartDate.Equals(input.PeriodStartDate))) return false;

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
                if (this.DdosInterceptTimes != null) hashCode = hashCode * 59 + this.DdosInterceptTimes.GetHashCode();
                if (this.DdosBlackholeTimes != null) hashCode = hashCode * 59 + this.DdosBlackholeTimes.GetHashCode();
                if (this.MaxAttackBps != null) hashCode = hashCode * 59 + this.MaxAttackBps.GetHashCode();
                if (this.MaxAttackConns != null) hashCode = hashCode * 59 + this.MaxAttackConns.GetHashCode();
                if (this.PeriodStartDate != null) hashCode = hashCode * 59 + this.PeriodStartDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
