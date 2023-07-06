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
    /// 高级设置信息体。
    /// </summary>
    public class TuningParamInfo 
    {

        /// <summary>
        /// 全量调优参数。
        /// </summary>
        [JsonProperty("full_sync", NullValueHandling = NullValueHandling.Ignore)]
        public List<TuningParameter> FullSync { get; set; }

        /// <summary>
        /// 增量抓取调优参数。
        /// </summary>
        [JsonProperty("incre_capture", NullValueHandling = NullValueHandling.Ignore)]
        public List<TuningParameter> IncreCapture { get; set; }

        /// <summary>
        /// 增量回放调优参数。
        /// </summary>
        [JsonProperty("incre_apply", NullValueHandling = NullValueHandling.Ignore)]
        public List<TuningParameter> IncreApply { get; set; }

        /// <summary>
        /// 增量日志拉取调优参数。
        /// </summary>
        [JsonProperty("incre_relay", NullValueHandling = NullValueHandling.Ignore)]
        public List<TuningParameter> IncreRelay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TuningParamInfo {\n");
            sb.Append("  fullSync: ").Append(FullSync).Append("\n");
            sb.Append("  increCapture: ").Append(IncreCapture).Append("\n");
            sb.Append("  increApply: ").Append(IncreApply).Append("\n");
            sb.Append("  increRelay: ").Append(IncreRelay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TuningParamInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TuningParamInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FullSync == input.FullSync ||
                    this.FullSync != null &&
                    input.FullSync != null &&
                    this.FullSync.SequenceEqual(input.FullSync)
                ) && 
                (
                    this.IncreCapture == input.IncreCapture ||
                    this.IncreCapture != null &&
                    input.IncreCapture != null &&
                    this.IncreCapture.SequenceEqual(input.IncreCapture)
                ) && 
                (
                    this.IncreApply == input.IncreApply ||
                    this.IncreApply != null &&
                    input.IncreApply != null &&
                    this.IncreApply.SequenceEqual(input.IncreApply)
                ) && 
                (
                    this.IncreRelay == input.IncreRelay ||
                    this.IncreRelay != null &&
                    input.IncreRelay != null &&
                    this.IncreRelay.SequenceEqual(input.IncreRelay)
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
                if (this.FullSync != null)
                    hashCode = hashCode * 59 + this.FullSync.GetHashCode();
                if (this.IncreCapture != null)
                    hashCode = hashCode * 59 + this.IncreCapture.GetHashCode();
                if (this.IncreApply != null)
                    hashCode = hashCode * 59 + this.IncreApply.GetHashCode();
                if (this.IncreRelay != null)
                    hashCode = hashCode * 59 + this.IncreRelay.GetHashCode();
                return hashCode;
            }
        }
    }
}
