using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 设置企业用户指定类型的阈值的请求体。
    /// </summary>
    public class SetQosThresholdReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("latency", NullValueHandling = NullValueHandling.Ignore)]
        public SetThresholdData Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("jitter", NullValueHandling = NullValueHandling.Ignore)]
        public SetThresholdData Jitter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("packetLoss", NullValueHandling = NullValueHandling.Ignore)]
        public SetPacketThresholdData PacketLoss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("clientCpuMax", NullValueHandling = NullValueHandling.Ignore)]
        public SetCPUThresholdData ClientCpuMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("systemCpuMax", NullValueHandling = NullValueHandling.Ignore)]
        public SetCPUThresholdData SystemCpuMax { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetQosThresholdReq {\n");
            sb.Append("  latency: ").Append(Latency).Append("\n");
            sb.Append("  jitter: ").Append(Jitter).Append("\n");
            sb.Append("  packetLoss: ").Append(PacketLoss).Append("\n");
            sb.Append("  clientCpuMax: ").Append(ClientCpuMax).Append("\n");
            sb.Append("  systemCpuMax: ").Append(SystemCpuMax).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetQosThresholdReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetQosThresholdReq input)
        {
            if (input == null) return false;
            if (this.Latency != input.Latency || (this.Latency != null && !this.Latency.Equals(input.Latency))) return false;
            if (this.Jitter != input.Jitter || (this.Jitter != null && !this.Jitter.Equals(input.Jitter))) return false;
            if (this.PacketLoss != input.PacketLoss || (this.PacketLoss != null && !this.PacketLoss.Equals(input.PacketLoss))) return false;
            if (this.ClientCpuMax != input.ClientCpuMax || (this.ClientCpuMax != null && !this.ClientCpuMax.Equals(input.ClientCpuMax))) return false;
            if (this.SystemCpuMax != input.SystemCpuMax || (this.SystemCpuMax != null && !this.SystemCpuMax.Equals(input.SystemCpuMax))) return false;

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
                if (this.Latency != null) hashCode = hashCode * 59 + this.Latency.GetHashCode();
                if (this.Jitter != null) hashCode = hashCode * 59 + this.Jitter.GetHashCode();
                if (this.PacketLoss != null) hashCode = hashCode * 59 + this.PacketLoss.GetHashCode();
                if (this.ClientCpuMax != null) hashCode = hashCode * 59 + this.ClientCpuMax.GetHashCode();
                if (this.SystemCpuMax != null) hashCode = hashCode * 59 + this.SystemCpuMax.GetHashCode();
                return hashCode;
            }
        }
    }
}
