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
    /// Response Object
    /// </summary>
    public class ShowRealTimeInfoOfMeetingResponse : SdkResponse
    {

        /// <summary>
        /// 被邀请与会者信息，包括预约会议时邀请的与会者和会中主持人邀请的与会者，已经加入会议的和未加入会议的都返回。
        /// </summary>
        [JsonProperty("attendees", NullValueHandling = NullValueHandling.Ignore)]
        public List<RealTimeAttendee> Attendees { get; set; }

        /// <summary>
        /// 在线与会者列表信息，包括已加入会议、被邀请正在呼叫中、正在加入会议的与会者列表等。 &gt; * 同一个帐号用不同类型终端（手机端或者PC端等）加入会议时，是不同的在线与会者 &gt; * 未加入或者已离会与会者，不在在线与会者列表中 
        /// </summary>
        [JsonProperty("participants", NullValueHandling = NullValueHandling.Ignore)]
        public List<RealTimeParticipant> Participants { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("confInfo", NullValueHandling = NullValueHandling.Ignore)]
        public RealTimeConfInfo ConfInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRealTimeInfoOfMeetingResponse {\n");
            sb.Append("  attendees: ").Append(Attendees).Append("\n");
            sb.Append("  participants: ").Append(Participants).Append("\n");
            sb.Append("  confInfo: ").Append(ConfInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRealTimeInfoOfMeetingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRealTimeInfoOfMeetingResponse input)
        {
            if (input == null) return false;
            if (this.Attendees != input.Attendees || (this.Attendees != null && input.Attendees != null && !this.Attendees.SequenceEqual(input.Attendees))) return false;
            if (this.Participants != input.Participants || (this.Participants != null && input.Participants != null && !this.Participants.SequenceEqual(input.Participants))) return false;
            if (this.ConfInfo != input.ConfInfo || (this.ConfInfo != null && !this.ConfInfo.Equals(input.ConfInfo))) return false;

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
                if (this.Attendees != null) hashCode = hashCode * 59 + this.Attendees.GetHashCode();
                if (this.Participants != null) hashCode = hashCode * 59 + this.Participants.GetHashCode();
                if (this.ConfInfo != null) hashCode = hashCode * 59 + this.ConfInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
