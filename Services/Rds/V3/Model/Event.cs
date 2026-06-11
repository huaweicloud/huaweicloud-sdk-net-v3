using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 事件信息
    /// </summary>
    public class Event 
    {

        /// <summary>
        /// 采样时间
        /// </summary>
        [JsonProperty("sample_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SampleTime { get; set; }

        /// <summary>
        /// 个数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 会话状态
        /// </summary>
        [JsonProperty("session_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionStatus { get; set; }

        /// <summary>
        /// 等待事件类型
        /// </summary>
        [JsonProperty("wait_event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string WaitEventType { get; set; }

        /// <summary>
        /// 等待事件名称
        /// </summary>
        [JsonProperty("wait_event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string WaitEventName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Event {\n");
            sb.Append("  sampleTime: ").Append(SampleTime).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  sessionStatus: ").Append(SessionStatus).Append("\n");
            sb.Append("  waitEventType: ").Append(WaitEventType).Append("\n");
            sb.Append("  waitEventName: ").Append(WaitEventName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Event);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Event input)
        {
            if (input == null) return false;
            if (this.SampleTime != input.SampleTime || (this.SampleTime != null && !this.SampleTime.Equals(input.SampleTime))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.SessionStatus != input.SessionStatus || (this.SessionStatus != null && !this.SessionStatus.Equals(input.SessionStatus))) return false;
            if (this.WaitEventType != input.WaitEventType || (this.WaitEventType != null && !this.WaitEventType.Equals(input.WaitEventType))) return false;
            if (this.WaitEventName != input.WaitEventName || (this.WaitEventName != null && !this.WaitEventName.Equals(input.WaitEventName))) return false;

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
                if (this.SampleTime != null) hashCode = hashCode * 59 + this.SampleTime.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.SessionStatus != null) hashCode = hashCode * 59 + this.SessionStatus.GetHashCode();
                if (this.WaitEventType != null) hashCode = hashCode * 59 + this.WaitEventType.GetHashCode();
                if (this.WaitEventName != null) hashCode = hashCode * 59 + this.WaitEventName.GetHashCode();
                return hashCode;
            }
        }
    }
}
