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
    /// QoS数据。
    /// </summary>
    public class QosInfo 
    {

        /// <summary>
        /// Qos类型 - aduio：音频 - video：视频 - screen：屏幕共享 - cpu：cpu
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("send", NullValueHandling = NullValueHandling.Ignore)]
        public QosSendReceiveInfo Send { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("receive", NullValueHandling = NullValueHandling.Ignore)]
        public QosSendReceiveInfo Receive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public QosCpuInfo Cpu { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QosInfo {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  send: ").Append(Send).Append("\n");
            sb.Append("  receive: ").Append(Receive).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QosInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QosInfo input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Send != input.Send || (this.Send != null && !this.Send.Equals(input.Send))) return false;
            if (this.Receive != input.Receive || (this.Receive != null && !this.Receive.Equals(input.Receive))) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Send != null) hashCode = hashCode * 59 + this.Send.GetHashCode();
                if (this.Receive != null) hashCode = hashCode * 59 + this.Receive.GetHashCode();
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                return hashCode;
            }
        }
    }
}
