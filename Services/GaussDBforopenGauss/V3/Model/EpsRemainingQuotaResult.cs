using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EpsRemainingQuotaResult 
    {

        /// <summary>
        /// **参数解释**: 企业项目ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("eps_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string EpsTag { get; set; }

        /// <summary>
        /// **参数解释**: 实例配额。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("instance_eps_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceEpsQuota { get; set; }

        /// <summary>
        /// **参数解释**: CPU配额。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("cpu_eps_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuEpsQuota { get; set; }

        /// <summary>
        /// **参数解释**: 内存配额。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("mem_eps_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemEpsQuota { get; set; }

        /// <summary>
        /// **参数解释**: 存储空间配额。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("volume_eps_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? VolumeEpsQuota { get; set; }

        /// <summary>
        /// **参数解释**: 实例剩余配额。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("instance_eps_remaining_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceEpsRemainingQuota { get; set; }

        /// <summary>
        /// **参数解释**: CPU剩余配额。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("cpu_eps_remaining_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuEpsRemainingQuota { get; set; }

        /// <summary>
        /// **参数解释**: 内存剩余配额。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("mem_eps_remaining_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemEpsRemainingQuota { get; set; }

        /// <summary>
        /// **参数解释**: 存储空间剩余配额。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("volume_eps_remaining_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? VolumeEpsRemainingQuota { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EpsRemainingQuotaResult {\n");
            sb.Append("  epsTag: ").Append(EpsTag).Append("\n");
            sb.Append("  instanceEpsQuota: ").Append(InstanceEpsQuota).Append("\n");
            sb.Append("  cpuEpsQuota: ").Append(CpuEpsQuota).Append("\n");
            sb.Append("  memEpsQuota: ").Append(MemEpsQuota).Append("\n");
            sb.Append("  volumeEpsQuota: ").Append(VolumeEpsQuota).Append("\n");
            sb.Append("  instanceEpsRemainingQuota: ").Append(InstanceEpsRemainingQuota).Append("\n");
            sb.Append("  cpuEpsRemainingQuota: ").Append(CpuEpsRemainingQuota).Append("\n");
            sb.Append("  memEpsRemainingQuota: ").Append(MemEpsRemainingQuota).Append("\n");
            sb.Append("  volumeEpsRemainingQuota: ").Append(VolumeEpsRemainingQuota).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EpsRemainingQuotaResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EpsRemainingQuotaResult input)
        {
            if (input == null) return false;
            if (this.EpsTag != input.EpsTag || (this.EpsTag != null && !this.EpsTag.Equals(input.EpsTag))) return false;
            if (this.InstanceEpsQuota != input.InstanceEpsQuota || (this.InstanceEpsQuota != null && !this.InstanceEpsQuota.Equals(input.InstanceEpsQuota))) return false;
            if (this.CpuEpsQuota != input.CpuEpsQuota || (this.CpuEpsQuota != null && !this.CpuEpsQuota.Equals(input.CpuEpsQuota))) return false;
            if (this.MemEpsQuota != input.MemEpsQuota || (this.MemEpsQuota != null && !this.MemEpsQuota.Equals(input.MemEpsQuota))) return false;
            if (this.VolumeEpsQuota != input.VolumeEpsQuota || (this.VolumeEpsQuota != null && !this.VolumeEpsQuota.Equals(input.VolumeEpsQuota))) return false;
            if (this.InstanceEpsRemainingQuota != input.InstanceEpsRemainingQuota || (this.InstanceEpsRemainingQuota != null && !this.InstanceEpsRemainingQuota.Equals(input.InstanceEpsRemainingQuota))) return false;
            if (this.CpuEpsRemainingQuota != input.CpuEpsRemainingQuota || (this.CpuEpsRemainingQuota != null && !this.CpuEpsRemainingQuota.Equals(input.CpuEpsRemainingQuota))) return false;
            if (this.MemEpsRemainingQuota != input.MemEpsRemainingQuota || (this.MemEpsRemainingQuota != null && !this.MemEpsRemainingQuota.Equals(input.MemEpsRemainingQuota))) return false;
            if (this.VolumeEpsRemainingQuota != input.VolumeEpsRemainingQuota || (this.VolumeEpsRemainingQuota != null && !this.VolumeEpsRemainingQuota.Equals(input.VolumeEpsRemainingQuota))) return false;

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
                if (this.EpsTag != null) hashCode = hashCode * 59 + this.EpsTag.GetHashCode();
                if (this.InstanceEpsQuota != null) hashCode = hashCode * 59 + this.InstanceEpsQuota.GetHashCode();
                if (this.CpuEpsQuota != null) hashCode = hashCode * 59 + this.CpuEpsQuota.GetHashCode();
                if (this.MemEpsQuota != null) hashCode = hashCode * 59 + this.MemEpsQuota.GetHashCode();
                if (this.VolumeEpsQuota != null) hashCode = hashCode * 59 + this.VolumeEpsQuota.GetHashCode();
                if (this.InstanceEpsRemainingQuota != null) hashCode = hashCode * 59 + this.InstanceEpsRemainingQuota.GetHashCode();
                if (this.CpuEpsRemainingQuota != null) hashCode = hashCode * 59 + this.CpuEpsRemainingQuota.GetHashCode();
                if (this.MemEpsRemainingQuota != null) hashCode = hashCode * 59 + this.MemEpsRemainingQuota.GetHashCode();
                if (this.VolumeEpsRemainingQuota != null) hashCode = hashCode * 59 + this.VolumeEpsRemainingQuota.GetHashCode();
                return hashCode;
            }
        }
    }
}
