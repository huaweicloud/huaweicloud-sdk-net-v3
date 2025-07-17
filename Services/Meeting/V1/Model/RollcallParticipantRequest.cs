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
    /// Request Object
    /// </summary>
    public class RollcallParticipantRequest 
    {

        /// <summary>
        /// 会议ID。
        /// </summary>
        [SDKProperty("conferenceID", IsQuery = true)]
        [JsonProperty("conferenceID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceID { get; set; }

        /// <summary>
        /// 与会者标识。
        /// </summary>
        [SDKProperty("participantID", IsQuery = true)]
        [JsonProperty("participantID", NullValueHandling = NullValueHandling.Ignore)]
        public string ParticipantID { get; set; }

        /// <summary>
        /// 会控Token，通过[[获取会控token](https://support.huaweicloud.com/api-meeting/meeting_21_0027.html)](tag:hws)[[获取会控token](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0027.html)](tag:hk)接口获得。
        /// </summary>
        [SDKProperty("X-Conference-Authorization", IsHeader = true)]
        [JsonProperty("X-Conference-Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string XConferenceAuthorization { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RollcallParticipantRequest {\n");
            sb.Append("  conferenceID: ").Append(ConferenceID).Append("\n");
            sb.Append("  participantID: ").Append(ParticipantID).Append("\n");
            sb.Append("  xConferenceAuthorization: ").Append(XConferenceAuthorization).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RollcallParticipantRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RollcallParticipantRequest input)
        {
            if (input == null) return false;
            if (this.ConferenceID != input.ConferenceID || (this.ConferenceID != null && !this.ConferenceID.Equals(input.ConferenceID))) return false;
            if (this.ParticipantID != input.ParticipantID || (this.ParticipantID != null && !this.ParticipantID.Equals(input.ParticipantID))) return false;
            if (this.XConferenceAuthorization != input.XConferenceAuthorization || (this.XConferenceAuthorization != null && !this.XConferenceAuthorization.Equals(input.XConferenceAuthorization))) return false;

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
                if (this.ConferenceID != null) hashCode = hashCode * 59 + this.ConferenceID.GetHashCode();
                if (this.ParticipantID != null) hashCode = hashCode * 59 + this.ParticipantID.GetHashCode();
                if (this.XConferenceAuthorization != null) hashCode = hashCode * 59 + this.XConferenceAuthorization.GetHashCode();
                return hashCode;
            }
        }
    }
}
