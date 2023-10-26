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
    /// EIP防护流量响应体
    /// </summary>
    public class DailyData 
    {

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("period_start", NullValueHandling = NullValueHandling.Ignore)]
        public long? PeriodStart { get; set; }

        /// <summary>
        /// 入流量（bit/s）
        /// </summary>
        [JsonProperty("bps_in", NullValueHandling = NullValueHandling.Ignore)]
        public int? BpsIn { get; set; }

        /// <summary>
        /// 攻击流量（bit/s）
        /// </summary>
        [JsonProperty("bps_attack", NullValueHandling = NullValueHandling.Ignore)]
        public long? BpsAttack { get; set; }

        /// <summary>
        /// 总流量
        /// </summary>
        [JsonProperty("total_bps", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalBps { get; set; }

        /// <summary>
        /// 入报文速率（个/s）
        /// </summary>
        [JsonProperty("pps_in", NullValueHandling = NullValueHandling.Ignore)]
        public long? PpsIn { get; set; }

        /// <summary>
        /// 攻击文速率（个/s）
        /// </summary>
        [JsonProperty("pps_attack", NullValueHandling = NullValueHandling.Ignore)]
        public long? PpsAttack { get; set; }

        /// <summary>
        /// 总报文速率
        /// </summary>
        [JsonProperty("total_pps", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalPps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DailyData {\n");
            sb.Append("  periodStart: ").Append(PeriodStart).Append("\n");
            sb.Append("  bpsIn: ").Append(BpsIn).Append("\n");
            sb.Append("  bpsAttack: ").Append(BpsAttack).Append("\n");
            sb.Append("  totalBps: ").Append(TotalBps).Append("\n");
            sb.Append("  ppsIn: ").Append(PpsIn).Append("\n");
            sb.Append("  ppsAttack: ").Append(PpsAttack).Append("\n");
            sb.Append("  totalPps: ").Append(TotalPps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DailyData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DailyData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PeriodStart == input.PeriodStart ||
                    (this.PeriodStart != null &&
                    this.PeriodStart.Equals(input.PeriodStart))
                ) && 
                (
                    this.BpsIn == input.BpsIn ||
                    (this.BpsIn != null &&
                    this.BpsIn.Equals(input.BpsIn))
                ) && 
                (
                    this.BpsAttack == input.BpsAttack ||
                    (this.BpsAttack != null &&
                    this.BpsAttack.Equals(input.BpsAttack))
                ) && 
                (
                    this.TotalBps == input.TotalBps ||
                    (this.TotalBps != null &&
                    this.TotalBps.Equals(input.TotalBps))
                ) && 
                (
                    this.PpsIn == input.PpsIn ||
                    (this.PpsIn != null &&
                    this.PpsIn.Equals(input.PpsIn))
                ) && 
                (
                    this.PpsAttack == input.PpsAttack ||
                    (this.PpsAttack != null &&
                    this.PpsAttack.Equals(input.PpsAttack))
                ) && 
                (
                    this.TotalPps == input.TotalPps ||
                    (this.TotalPps != null &&
                    this.TotalPps.Equals(input.TotalPps))
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
                if (this.PeriodStart != null)
                    hashCode = hashCode * 59 + this.PeriodStart.GetHashCode();
                if (this.BpsIn != null)
                    hashCode = hashCode * 59 + this.BpsIn.GetHashCode();
                if (this.BpsAttack != null)
                    hashCode = hashCode * 59 + this.BpsAttack.GetHashCode();
                if (this.TotalBps != null)
                    hashCode = hashCode * 59 + this.TotalBps.GetHashCode();
                if (this.PpsIn != null)
                    hashCode = hashCode * 59 + this.PpsIn.GetHashCode();
                if (this.PpsAttack != null)
                    hashCode = hashCode * 59 + this.PpsAttack.GetHashCode();
                if (this.TotalPps != null)
                    hashCode = hashCode * 59 + this.TotalPps.GetHashCode();
                return hashCode;
            }
        }
    }
}
