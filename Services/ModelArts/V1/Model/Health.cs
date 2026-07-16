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
    /// **参数解释：** 健康检查配置。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
    /// </summary>
    public class Health 
    {

        /// <summary>
        /// **参数解释：** 健康检查方式：HTTP 或者 EXEC（命令行）。 **约束限制：** 不涉及。 **取值范围：** - HTTP：超文本传输协议。 - EXEC：命令行。 **默认取值：** 创建的时候，check_method不传值，默认：check_method。 更新的时候，check_method不传值，会报错。
        /// </summary>
        [JsonProperty("check_method", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckMethod { get; set; }

        /// <summary>
        /// **参数解释：** 当健康检查方式为EXEC时必填，配置的命令行。 **约束限制：** 字符长度限制[0, 1024]，不能包含字符：#~^$|%&amp;*&lt;&gt;()&#39;\&quot;[]{} **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("cmd", NullValueHandling = NullValueHandling.Ignore)]
        public string Cmd { get; set; }

        /// <summary>
        /// **参数解释：** 当健康检查方式为HTTP 时必填，配置的请求地址。 **约束限制：** 字符长度限制[0, 1024]，首字符为/，后续字符可以是：字母 数字 中划线 下划线 / : **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数解释：** 连接协议。默认HTTP。 **约束限制：** 不涉及。 **取值范围：** - HTTPS：超文本传输协议安全版。 - HTTP：超文本传输协议。 - WSS：网络通信协议安全版。 - WS：网络通信协议。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// **参数解释：** 执行首次探测时，应该等待的时间，默认30秒，最小1秒。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 默认值为30。
        /// </summary>
        [JsonProperty("initial_delay_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? InitialDelaySeconds { get; set; }

        /// <summary>
        /// **参数解释：** 执行探测的超时时间，默认30秒，最小1秒。 **约束限制：** 不涉及。 **取值范围：** 最小值为1秒。 **默认取值：** 默认值为30秒。
        /// </summary>
        [JsonProperty("timeout_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// **参数解释：** 执行健康检查的周期时间，执行探测的频率。默认是10秒，最小1秒。 **约束限制：** 不涉及。 **取值范围：** 最小值为1秒。 **默认取值：** 默认值为10秒。
        /// </summary>
        [JsonProperty("period_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodSeconds { get; set; }

        /// <summary>
        /// **参数解释：** 探测成功后，至少连续探测失败多少次才被认定为失败。默认是3。最小值是1。 **约束限制：** 不涉及。 **取值范围：** 最小值为1。 **默认取值：** 默认值为3。
        /// </summary>
        [JsonProperty("failure_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailureThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Health {\n");
            sb.Append("  checkMethod: ").Append(CheckMethod).Append("\n");
            sb.Append("  cmd: ").Append(Cmd).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  initialDelaySeconds: ").Append(InitialDelaySeconds).Append("\n");
            sb.Append("  timeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
            sb.Append("  periodSeconds: ").Append(PeriodSeconds).Append("\n");
            sb.Append("  failureThreshold: ").Append(FailureThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Health);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Health input)
        {
            if (input == null) return false;
            if (this.CheckMethod != input.CheckMethod || (this.CheckMethod != null && !this.CheckMethod.Equals(input.CheckMethod))) return false;
            if (this.Cmd != input.Cmd || (this.Cmd != null && !this.Cmd.Equals(input.Cmd))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.InitialDelaySeconds != input.InitialDelaySeconds || (this.InitialDelaySeconds != null && !this.InitialDelaySeconds.Equals(input.InitialDelaySeconds))) return false;
            if (this.TimeoutSeconds != input.TimeoutSeconds || (this.TimeoutSeconds != null && !this.TimeoutSeconds.Equals(input.TimeoutSeconds))) return false;
            if (this.PeriodSeconds != input.PeriodSeconds || (this.PeriodSeconds != null && !this.PeriodSeconds.Equals(input.PeriodSeconds))) return false;
            if (this.FailureThreshold != input.FailureThreshold || (this.FailureThreshold != null && !this.FailureThreshold.Equals(input.FailureThreshold))) return false;

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
                if (this.CheckMethod != null) hashCode = hashCode * 59 + this.CheckMethod.GetHashCode();
                if (this.Cmd != null) hashCode = hashCode * 59 + this.Cmd.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.InitialDelaySeconds != null) hashCode = hashCode * 59 + this.InitialDelaySeconds.GetHashCode();
                if (this.TimeoutSeconds != null) hashCode = hashCode * 59 + this.TimeoutSeconds.GetHashCode();
                if (this.PeriodSeconds != null) hashCode = hashCode * 59 + this.PeriodSeconds.GetHashCode();
                if (this.FailureThreshold != null) hashCode = hashCode * 59 + this.FailureThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
