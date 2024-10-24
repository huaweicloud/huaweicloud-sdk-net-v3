using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 回看录制的配置信息。
    /// </summary>
    public class CreateOttChannelInfoReqRecordSettings 
    {

        /// <summary>
        /// 最大回看录制时长。在此时间段内会连续不断的录制，为必选项  单位：秒。取值为“0”时，表示不支持录制；最大支持录制14天
        /// </summary>
        [JsonProperty("rollingbuffer_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? RollingbufferDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOttChannelInfoReqRecordSettings {\n");
            sb.Append("  rollingbufferDuration: ").Append(RollingbufferDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOttChannelInfoReqRecordSettings);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateOttChannelInfoReqRecordSettings input)
        {
            if (input == null) return false;
            if (this.RollingbufferDuration != input.RollingbufferDuration || (this.RollingbufferDuration != null && !this.RollingbufferDuration.Equals(input.RollingbufferDuration))) return false;

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
                if (this.RollingbufferDuration != null) hashCode = hashCode * 59 + this.RollingbufferDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
