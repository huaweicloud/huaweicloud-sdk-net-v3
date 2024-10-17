using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RtcHistoryScaleTimeValue 
    {

        /// <summary>
        /// 采样时间。日期格式按照ISO8601表示法，并使用UTC时间。格式为YYYY-MM-DD
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// 通话人数，指总的uid个数
        /// </summary>
        [JsonProperty("user_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? UserCount { get; set; }

        /// <summary>
        /// 通话人次，指总的session个数
        /// </summary>
        [JsonProperty("session_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? SessionCount { get; set; }

        /// <summary>
        /// 房间数
        /// </summary>
        [JsonProperty("room_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? RoomCount { get; set; }

        /// <summary>
        /// 最大同时在线人数
        /// </summary>
        [JsonProperty("max_online_user_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxOnlineUserCount { get; set; }

        /// <summary>
        /// 最大同时在线房间数
        /// </summary>
        [JsonProperty("max_online_room_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxOnlineRoomCount { get; set; }

        /// <summary>
        /// 音视频通话总时长，单位秒
        /// </summary>
        [JsonProperty("communication_duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? CommunicationDuration { get; set; }

        /// <summary>
        /// 视频通话总时长，单位秒
        /// </summary>
        [JsonProperty("video_communication_duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? VideoCommunicationDuration { get; set; }

        /// <summary>
        /// 音频通话总时长，单位秒
        /// </summary>
        [JsonProperty("audio_communication_duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? AudioCommunicationDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RtcHistoryScaleTimeValue {\n");
            sb.Append("  date: ").Append(Date).Append("\n");
            sb.Append("  userCount: ").Append(UserCount).Append("\n");
            sb.Append("  sessionCount: ").Append(SessionCount).Append("\n");
            sb.Append("  roomCount: ").Append(RoomCount).Append("\n");
            sb.Append("  maxOnlineUserCount: ").Append(MaxOnlineUserCount).Append("\n");
            sb.Append("  maxOnlineRoomCount: ").Append(MaxOnlineRoomCount).Append("\n");
            sb.Append("  communicationDuration: ").Append(CommunicationDuration).Append("\n");
            sb.Append("  videoCommunicationDuration: ").Append(VideoCommunicationDuration).Append("\n");
            sb.Append("  audioCommunicationDuration: ").Append(AudioCommunicationDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RtcHistoryScaleTimeValue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RtcHistoryScaleTimeValue input)
        {
            if (input == null) return false;
            if (this.Date != input.Date || (this.Date != null && !this.Date.Equals(input.Date))) return false;
            if (this.UserCount != input.UserCount || (this.UserCount != null && !this.UserCount.Equals(input.UserCount))) return false;
            if (this.SessionCount != input.SessionCount || (this.SessionCount != null && !this.SessionCount.Equals(input.SessionCount))) return false;
            if (this.RoomCount != input.RoomCount || (this.RoomCount != null && !this.RoomCount.Equals(input.RoomCount))) return false;
            if (this.MaxOnlineUserCount != input.MaxOnlineUserCount || (this.MaxOnlineUserCount != null && !this.MaxOnlineUserCount.Equals(input.MaxOnlineUserCount))) return false;
            if (this.MaxOnlineRoomCount != input.MaxOnlineRoomCount || (this.MaxOnlineRoomCount != null && !this.MaxOnlineRoomCount.Equals(input.MaxOnlineRoomCount))) return false;
            if (this.CommunicationDuration != input.CommunicationDuration || (this.CommunicationDuration != null && !this.CommunicationDuration.Equals(input.CommunicationDuration))) return false;
            if (this.VideoCommunicationDuration != input.VideoCommunicationDuration || (this.VideoCommunicationDuration != null && !this.VideoCommunicationDuration.Equals(input.VideoCommunicationDuration))) return false;
            if (this.AudioCommunicationDuration != input.AudioCommunicationDuration || (this.AudioCommunicationDuration != null && !this.AudioCommunicationDuration.Equals(input.AudioCommunicationDuration))) return false;

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
                if (this.Date != null) hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.UserCount != null) hashCode = hashCode * 59 + this.UserCount.GetHashCode();
                if (this.SessionCount != null) hashCode = hashCode * 59 + this.SessionCount.GetHashCode();
                if (this.RoomCount != null) hashCode = hashCode * 59 + this.RoomCount.GetHashCode();
                if (this.MaxOnlineUserCount != null) hashCode = hashCode * 59 + this.MaxOnlineUserCount.GetHashCode();
                if (this.MaxOnlineRoomCount != null) hashCode = hashCode * 59 + this.MaxOnlineRoomCount.GetHashCode();
                if (this.CommunicationDuration != null) hashCode = hashCode * 59 + this.CommunicationDuration.GetHashCode();
                if (this.VideoCommunicationDuration != null) hashCode = hashCode * 59 + this.VideoCommunicationDuration.GetHashCode();
                if (this.AudioCommunicationDuration != null) hashCode = hashCode * 59 + this.AudioCommunicationDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
