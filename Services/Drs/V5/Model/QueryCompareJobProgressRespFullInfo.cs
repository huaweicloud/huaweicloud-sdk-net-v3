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
    /// 行对比与内容对比会返回该字段，全量对比信息。
    /// </summary>
    public class QueryCompareJobProgressRespFullInfo 
    {

        /// <summary>
        /// 增量数据对比进度，单位为%。
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public float? Progress { get; set; }

        /// <summary>
        /// 全量数据对比速率。
        /// </summary>
        [JsonProperty("src_speed", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcSpeed { get; set; }

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
            sb.Append("class QueryCompareJobProgressRespFullInfo {\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  srcSpeed: ").Append(SrcSpeed).Append("\n");
            sb.Append("  recheckEntities: ").Append(RecheckEntities).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryCompareJobProgressRespFullInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryCompareJobProgressRespFullInfo input)
        {
            if (input == null) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.SrcSpeed != input.SrcSpeed || (this.SrcSpeed != null && !this.SrcSpeed.Equals(input.SrcSpeed))) return false;
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
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.SrcSpeed != null) hashCode = hashCode * 59 + this.SrcSpeed.GetHashCode();
                if (this.RecheckEntities != null) hashCode = hashCode * 59 + this.RecheckEntities.GetHashCode();
                return hashCode;
            }
        }
    }
}
