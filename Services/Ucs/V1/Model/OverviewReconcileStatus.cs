using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OverviewReconcileStatus 
    {

        /// <summary>
        /// 配置集合总数
        /// </summary>
        [JsonProperty("configSetTotalNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfigSetTotalNum { get; set; }

        /// <summary>
        /// 健康状态的配置集合数量
        /// </summary>
        [JsonProperty("healthStatusNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? HealthStatusNum { get; set; }

        /// <summary>
        /// 失败状态的配置集合数量
        /// </summary>
        [JsonProperty("failedStatusNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedStatusNum { get; set; }

        /// <summary>
        /// 未知状态的配置集合数量
        /// </summary>
        [JsonProperty("unknownStatusNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnknownStatusNum { get; set; }

        /// <summary>
        /// 正在处理中的配置集合数量
        /// </summary>
        [JsonProperty("progressingStatusNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProgressingStatusNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OverviewReconcileStatus {\n");
            sb.Append("  configSetTotalNum: ").Append(ConfigSetTotalNum).Append("\n");
            sb.Append("  healthStatusNum: ").Append(HealthStatusNum).Append("\n");
            sb.Append("  failedStatusNum: ").Append(FailedStatusNum).Append("\n");
            sb.Append("  unknownStatusNum: ").Append(UnknownStatusNum).Append("\n");
            sb.Append("  progressingStatusNum: ").Append(ProgressingStatusNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OverviewReconcileStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OverviewReconcileStatus input)
        {
            if (input == null) return false;
            if (this.ConfigSetTotalNum != input.ConfigSetTotalNum || (this.ConfigSetTotalNum != null && !this.ConfigSetTotalNum.Equals(input.ConfigSetTotalNum))) return false;
            if (this.HealthStatusNum != input.HealthStatusNum || (this.HealthStatusNum != null && !this.HealthStatusNum.Equals(input.HealthStatusNum))) return false;
            if (this.FailedStatusNum != input.FailedStatusNum || (this.FailedStatusNum != null && !this.FailedStatusNum.Equals(input.FailedStatusNum))) return false;
            if (this.UnknownStatusNum != input.UnknownStatusNum || (this.UnknownStatusNum != null && !this.UnknownStatusNum.Equals(input.UnknownStatusNum))) return false;
            if (this.ProgressingStatusNum != input.ProgressingStatusNum || (this.ProgressingStatusNum != null && !this.ProgressingStatusNum.Equals(input.ProgressingStatusNum))) return false;

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
                if (this.ConfigSetTotalNum != null) hashCode = hashCode * 59 + this.ConfigSetTotalNum.GetHashCode();
                if (this.HealthStatusNum != null) hashCode = hashCode * 59 + this.HealthStatusNum.GetHashCode();
                if (this.FailedStatusNum != null) hashCode = hashCode * 59 + this.FailedStatusNum.GetHashCode();
                if (this.UnknownStatusNum != null) hashCode = hashCode * 59 + this.UnknownStatusNum.GetHashCode();
                if (this.ProgressingStatusNum != null) hashCode = hashCode * 59 + this.ProgressingStatusNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
