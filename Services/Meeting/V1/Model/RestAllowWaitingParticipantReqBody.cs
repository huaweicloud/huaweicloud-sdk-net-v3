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
    /// 
    /// </summary>
    public class RestAllowWaitingParticipantReqBody 
    {

        /// <summary>
        /// 等候室成员标志。通过监听[[会议级事件推送中的“等候室成员列表信息”](https://support.huaweicloud.com/api-meeting/meeting_21_1507.html)](tag:hws)[[会议级事件推送中的“等候室成员列表信息”](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_1507.html)](tag:hk)事件获得。 
        /// </summary>
        [JsonProperty("participantID", NullValueHandling = NullValueHandling.Ignore)]
        public string ParticipantID { get; set; }

        /// <summary>
        /// 允许所有等候者入会。 * false：指定等候者 * true：所有等候者入会 
        /// </summary>
        [JsonProperty("allowAll", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAll { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestAllowWaitingParticipantReqBody {\n");
            sb.Append("  participantID: ").Append(ParticipantID).Append("\n");
            sb.Append("  allowAll: ").Append(AllowAll).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestAllowWaitingParticipantReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestAllowWaitingParticipantReqBody input)
        {
            if (input == null) return false;
            if (this.ParticipantID != input.ParticipantID || (this.ParticipantID != null && !this.ParticipantID.Equals(input.ParticipantID))) return false;
            if (this.AllowAll != input.AllowAll || (this.AllowAll != null && !this.AllowAll.Equals(input.AllowAll))) return false;

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
                if (this.ParticipantID != null) hashCode = hashCode * 59 + this.ParticipantID.GetHashCode();
                if (this.AllowAll != null) hashCode = hashCode * 59 + this.AllowAll.GetHashCode();
                return hashCode;
            }
        }
    }
}
