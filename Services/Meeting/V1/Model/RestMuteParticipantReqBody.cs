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
    /// 静音与会者请求。
    /// </summary>
    public class RestMuteParticipantReqBody 
    {

        /// <summary>
        /// - 0: 取消静音 - 1: 静音
        /// </summary>
        [JsonProperty("isMute", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsMute { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestMuteParticipantReqBody {\n");
            sb.Append("  isMute: ").Append(IsMute).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestMuteParticipantReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestMuteParticipantReqBody input)
        {
            if (input == null) return false;
            if (this.IsMute != input.IsMute || (this.IsMute != null && !this.IsMute.Equals(input.IsMute))) return false;

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
                if (this.IsMute != null) hashCode = hashCode * 59 + this.IsMute.GetHashCode();
                return hashCode;
            }
        }
    }
}
