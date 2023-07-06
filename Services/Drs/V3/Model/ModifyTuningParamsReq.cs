using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 修改调优参数请求体
    /// </summary>
    public class ModifyTuningParamsReq 
    {

        /// <summary>
        /// 全量参数的参数名及对应的取值
        /// </summary>
        [JsonProperty("full_sync", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> FullSync { get; set; }

        /// <summary>
        /// 增量抓取参数的参数名及对应的取值
        /// </summary>
        [JsonProperty("incre_capture", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> IncreCapture { get; set; }

        /// <summary>
        /// 增量回放参数的参数名及对应的取值
        /// </summary>
        [JsonProperty("incre_apply", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> IncreApply { get; set; }

        /// <summary>
        /// 增量日志拉取参数的参数名及对应的取值 -slotAdvanceInterval： 源库逻辑复制槽推进间隔
        /// </summary>
        [JsonProperty("incre_relay", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> IncreRelay { get; set; }

        /// <summary>
        /// 初始化参数，首次调用时需要传true，其他时候不传。
        /// </summary>
        [JsonProperty("recovery", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recovery { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyTuningParamsReq {\n");
            sb.Append("  fullSync: ").Append(FullSync).Append("\n");
            sb.Append("  increCapture: ").Append(IncreCapture).Append("\n");
            sb.Append("  increApply: ").Append(IncreApply).Append("\n");
            sb.Append("  increRelay: ").Append(IncreRelay).Append("\n");
            sb.Append("  recovery: ").Append(Recovery).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyTuningParamsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyTuningParamsReq input)
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
                ) && 
                (
                    this.Recovery == input.Recovery ||
                    (this.Recovery != null &&
                    this.Recovery.Equals(input.Recovery))
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
                if (this.Recovery != null)
                    hashCode = hashCode * 59 + this.Recovery.GetHashCode();
                return hashCode;
            }
        }
    }
}
