using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 实例的统计信息。
    /// </summary>
    public class InstanceStatistic 
    {

        /// <summary>
        /// 缓存实例网络入流量，单位：Kbps。
        /// </summary>
        [JsonProperty("input_kbps", NullValueHandling = NullValueHandling.Ignore)]
        public string InputKbps { get; set; }

        /// <summary>
        /// 缓存实例网络出流量，单位：Kbps。
        /// </summary>
        [JsonProperty("output_kbps", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputKbps { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 缓存存储的数据条数。
        /// </summary>
        [JsonProperty("keys", NullValueHandling = NullValueHandling.Ignore)]
        public long? Keys { get; set; }

        /// <summary>
        /// 缓存已经使用内存，单位：MB。
        /// </summary>
        [JsonProperty("used_memory", NullValueHandling = NullValueHandling.Ignore)]
        public long? UsedMemory { get; set; }

        /// <summary>
        /// 缓存的总内存，单位：MB。
        /// </summary>
        [JsonProperty("max_memory", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxMemory { get; set; }

        /// <summary>
        /// 缓存get命令被调用次数。
        /// </summary>
        [JsonProperty("cmd_get_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? CmdGetCount { get; set; }

        /// <summary>
        /// 缓存set命令被调用次数。
        /// </summary>
        [JsonProperty("cmd_set_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? CmdSetCount { get; set; }

        /// <summary>
        /// CPU使用率，单位：百分比。
        /// </summary>
        [JsonProperty("used_cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedCpu { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceStatistic {\n");
            sb.Append("  inputKbps: ").Append(InputKbps).Append("\n");
            sb.Append("  outputKbps: ").Append(OutputKbps).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  keys: ").Append(Keys).Append("\n");
            sb.Append("  usedMemory: ").Append(UsedMemory).Append("\n");
            sb.Append("  maxMemory: ").Append(MaxMemory).Append("\n");
            sb.Append("  cmdGetCount: ").Append(CmdGetCount).Append("\n");
            sb.Append("  cmdSetCount: ").Append(CmdSetCount).Append("\n");
            sb.Append("  usedCpu: ").Append(UsedCpu).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceStatistic);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceStatistic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InputKbps == input.InputKbps ||
                    (this.InputKbps != null &&
                    this.InputKbps.Equals(input.InputKbps))
                ) && 
                (
                    this.OutputKbps == input.OutputKbps ||
                    (this.OutputKbps != null &&
                    this.OutputKbps.Equals(input.OutputKbps))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Keys == input.Keys ||
                    (this.Keys != null &&
                    this.Keys.Equals(input.Keys))
                ) && 
                (
                    this.UsedMemory == input.UsedMemory ||
                    (this.UsedMemory != null &&
                    this.UsedMemory.Equals(input.UsedMemory))
                ) && 
                (
                    this.MaxMemory == input.MaxMemory ||
                    (this.MaxMemory != null &&
                    this.MaxMemory.Equals(input.MaxMemory))
                ) && 
                (
                    this.CmdGetCount == input.CmdGetCount ||
                    (this.CmdGetCount != null &&
                    this.CmdGetCount.Equals(input.CmdGetCount))
                ) && 
                (
                    this.CmdSetCount == input.CmdSetCount ||
                    (this.CmdSetCount != null &&
                    this.CmdSetCount.Equals(input.CmdSetCount))
                ) && 
                (
                    this.UsedCpu == input.UsedCpu ||
                    (this.UsedCpu != null &&
                    this.UsedCpu.Equals(input.UsedCpu))
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
                if (this.InputKbps != null)
                    hashCode = hashCode * 59 + this.InputKbps.GetHashCode();
                if (this.OutputKbps != null)
                    hashCode = hashCode * 59 + this.OutputKbps.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Keys != null)
                    hashCode = hashCode * 59 + this.Keys.GetHashCode();
                if (this.UsedMemory != null)
                    hashCode = hashCode * 59 + this.UsedMemory.GetHashCode();
                if (this.MaxMemory != null)
                    hashCode = hashCode * 59 + this.MaxMemory.GetHashCode();
                if (this.CmdGetCount != null)
                    hashCode = hashCode * 59 + this.CmdGetCount.GetHashCode();
                if (this.CmdSetCount != null)
                    hashCode = hashCode * 59 + this.CmdSetCount.GetHashCode();
                if (this.UsedCpu != null)
                    hashCode = hashCode * 59 + this.UsedCpu.GetHashCode();
                return hashCode;
            }
        }
    }
}
