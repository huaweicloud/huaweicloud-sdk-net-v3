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
    /// 主持人暂停/取消暂停会议请求消息体
    /// </summary>
    public class PauseConferenceReq 
    {

        /// <summary>
        /// 主持人暂停/取消暂停会议 0：会议正常 1：会议暂停
        /// </summary>
        [JsonProperty("pause", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pause { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PauseConferenceReq {\n");
            sb.Append("  pause: ").Append(Pause).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PauseConferenceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PauseConferenceReq input)
        {
            if (input == null) return false;
            if (this.Pause != input.Pause || (this.Pause != null && !this.Pause.Equals(input.Pause))) return false;

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
                if (this.Pause != null) hashCode = hashCode * 59 + this.Pause.GetHashCode();
                return hashCode;
            }
        }
    }
}
