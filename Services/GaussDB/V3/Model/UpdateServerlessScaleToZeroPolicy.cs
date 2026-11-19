using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 设置Serverless自动启停策略请求体。
    /// </summary>
    public class UpdateServerlessScaleToZeroPolicy 
    {

        /// <summary>
        /// **参数解释**：  是否开启Scale to Zero自动启停。  **约束限制**：  仅Serverless实例支持。  **取值范围**：  - true：开启。实例空闲达idle_duration_seconds阈值时算力自动缩容到零（停止VM计费），有新连接时自动唤醒恢复。 - false：关闭。实例正常计费。  **默认取值**：  false。
        /// </summary>
        [JsonProperty("scale_to_zero", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScaleToZero { get; set; }

        /// <summary>
        /// **参数解释**：  触发缩容到零的空闲检测时长（秒）。实例所有节点无活跃用户连接达到该时长后，自动缩容到零。  **约束限制**：  - 当scale_to_zero为true时，该参数必填。 - 当scale_to_zero为false时，该参数可不传。  **取值范围**：  300～3600。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("idle_duration_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? IdleDurationSeconds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateServerlessScaleToZeroPolicy {\n");
            sb.Append("  scaleToZero: ").Append(ScaleToZero).Append("\n");
            sb.Append("  idleDurationSeconds: ").Append(IdleDurationSeconds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateServerlessScaleToZeroPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateServerlessScaleToZeroPolicy input)
        {
            if (input == null) return false;
            if (this.ScaleToZero != input.ScaleToZero || (this.ScaleToZero != null && !this.ScaleToZero.Equals(input.ScaleToZero))) return false;
            if (this.IdleDurationSeconds != input.IdleDurationSeconds || (this.IdleDurationSeconds != null && !this.IdleDurationSeconds.Equals(input.IdleDurationSeconds))) return false;

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
                if (this.ScaleToZero != null) hashCode = hashCode * 59 + this.ScaleToZero.GetHashCode();
                if (this.IdleDurationSeconds != null) hashCode = hashCode * 59 + this.IdleDurationSeconds.GetHashCode();
                return hashCode;
            }
        }
    }
}
