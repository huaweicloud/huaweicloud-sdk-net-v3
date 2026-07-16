using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释：** 开启后，支持设置停机时间及停机命令等，避免正在处理的请求被强制中断，从而提高系统的可用性和稳定性。 **约束限制：** 长度不超过255。 **取值范围：** - 协议范围：http/https。 - 端口范围：1-65535。 - 地址范围：仅包含字母、数字、点号（.）、中划线（-)、下划线（_）、斜杠（/）的路径，非斜杠（/）开头。 **默认取值：** 不涉及。
    /// </summary>
    public class TerminationGrace 
    {

        /// <summary>
        /// **参数解释：** 停机命令在容器收到停止信号时触发，但必须在停机时间的宽限期内完成，否则容器会被强制停止。您可以通过该命令精细化操作，如关闭数据库连接、释放文件句柄、停止子进程等。 **约束限制：** 长度不超过255。 **取值范围：** - 协议范围：http/https。 - 端口范围：1-65535。 - 地址范围：仅包含字母、数字、点号（.）、中划线（-)、下划线（_）、斜杠（/）的路径，非斜杠（/）开头。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("pre_stop_cmd", NullValueHandling = NullValueHandling.Ignore)]
        public string PreStopCmd { get; set; }

        /// <summary>
        /// **参数解释：** 该参数表示 Pod 收到停止信号到强制停止的最大时间窗口，用于 Pod 执行清理操作（如关闭连接、释放资源、保存状态等）。 **约束限制：** 长度不超过255。 **取值范围：** - 协议范围：http/https。 - 端口范围：1-65535。 - 地址范围：仅包含字母、数字、点号（.）、中划线（-)、下划线（_）、斜杠（/）的路径，非斜杠（/）开头。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("termination_grace_period_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? TerminationGracePeriodSeconds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TerminationGrace {\n");
            sb.Append("  preStopCmd: ").Append(PreStopCmd).Append("\n");
            sb.Append("  terminationGracePeriodSeconds: ").Append(TerminationGracePeriodSeconds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TerminationGrace);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TerminationGrace input)
        {
            if (input == null) return false;
            if (this.PreStopCmd != input.PreStopCmd || (this.PreStopCmd != null && !this.PreStopCmd.Equals(input.PreStopCmd))) return false;
            if (this.TerminationGracePeriodSeconds != input.TerminationGracePeriodSeconds || (this.TerminationGracePeriodSeconds != null && !this.TerminationGracePeriodSeconds.Equals(input.TerminationGracePeriodSeconds))) return false;

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
                if (this.PreStopCmd != null) hashCode = hashCode * 59 + this.PreStopCmd.GetHashCode();
                if (this.TerminationGracePeriodSeconds != null) hashCode = hashCode * 59 + this.TerminationGracePeriodSeconds.GetHashCode();
                return hashCode;
            }
        }
    }
}
