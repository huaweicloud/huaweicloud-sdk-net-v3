using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 动态内容对比会返回该字段，增量对比信息。
    /// </summary>
    public class QueryCompareJobProgressRespIncreInfo 
    {

        /// <summary>
        /// 增量对比时延，若时延为0表示所有增量数据都已对比完成。
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public float? Delay { get; set; }

        /// <summary>
        /// 增量数据对比速率。
        /// </summary>
        [JsonProperty("src_speed", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcSpeed { get; set; }

        /// <summary>
        /// 每秒对比行数。
        /// </summary>
        [JsonProperty("rps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rps { get; set; }

        /// <summary>
        /// 增量位点。
        /// </summary>
        [JsonProperty("log_point", NullValueHandling = NullValueHandling.Ignore)]
        public string LogPoint { get; set; }

        /// <summary>
        /// 差异待复查行数。
        /// </summary>
        [JsonProperty("recheck_entities", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecheckEntities { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryCompareJobProgressRespIncreInfo {\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  srcSpeed: ").Append(SrcSpeed).Append("\n");
            sb.Append("  rps: ").Append(Rps).Append("\n");
            sb.Append("  logPoint: ").Append(LogPoint).Append("\n");
            sb.Append("  recheckEntities: ").Append(RecheckEntities).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryCompareJobProgressRespIncreInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryCompareJobProgressRespIncreInfo input)
        {
            if (input == null) return false;
            if (this.Delay != input.Delay || (this.Delay != null && !this.Delay.Equals(input.Delay))) return false;
            if (this.SrcSpeed != input.SrcSpeed || (this.SrcSpeed != null && !this.SrcSpeed.Equals(input.SrcSpeed))) return false;
            if (this.Rps != input.Rps || (this.Rps != null && !this.Rps.Equals(input.Rps))) return false;
            if (this.LogPoint != input.LogPoint || (this.LogPoint != null && !this.LogPoint.Equals(input.LogPoint))) return false;
            if (this.RecheckEntities != input.RecheckEntities || (this.RecheckEntities != null && !this.RecheckEntities.Equals(input.RecheckEntities))) return false;

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
                if (this.Delay != null) hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.SrcSpeed != null) hashCode = hashCode * 59 + this.SrcSpeed.GetHashCode();
                if (this.Rps != null) hashCode = hashCode * 59 + this.Rps.GetHashCode();
                if (this.LogPoint != null) hashCode = hashCode * 59 + this.LogPoint.GetHashCode();
                if (this.RecheckEntities != null) hashCode = hashCode * 59 + this.RecheckEntities.GetHashCode();
                return hashCode;
            }
        }
    }
}
