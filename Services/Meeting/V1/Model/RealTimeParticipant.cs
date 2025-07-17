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
    /// 在线会场信息。
    /// </summary>
    public class RealTimeParticipant 
    {

        /// <summary>
        /// 与会者标识。
        /// </summary>
        [JsonProperty("pid", NullValueHandling = NullValueHandling.Ignore)]
        public string Pid { get; set; }

        /// <summary>
        /// 与会者名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 与会者号码。
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// 用户状态。 - 0: 会议中 - 1: 正在呼叫 - 2: 正在加入会议 &gt; 若会场未入会或已离会，则不会显示于在线会场列表。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public int? State { get; set; }

        /// <summary>
        /// 音视频能力。 - 0: 音频 - 1: 视频
        /// </summary>
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public int? Video { get; set; }

        /// <summary>
        /// 麦克风状态。 - 0: 麦克风打开 - 1: 麦克风关闭
        /// </summary>
        [JsonProperty("mute", NullValueHandling = NullValueHandling.Ignore)]
        public int? Mute { get; set; }

        /// <summary>
        /// 与会者举手状态。 - 0: 未举手 - 1: 举手
        /// </summary>
        [JsonProperty("hand", NullValueHandling = NullValueHandling.Ignore)]
        public int? Hand { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealTimeParticipant {\n");
            sb.Append("  pid: ").Append(Pid).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  video: ").Append(Video).Append("\n");
            sb.Append("  mute: ").Append(Mute).Append("\n");
            sb.Append("  hand: ").Append(Hand).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RealTimeParticipant);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RealTimeParticipant input)
        {
            if (input == null) return false;
            if (this.Pid != input.Pid || (this.Pid != null && !this.Pid.Equals(input.Pid))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Video != input.Video || (this.Video != null && !this.Video.Equals(input.Video))) return false;
            if (this.Mute != input.Mute || (this.Mute != null && !this.Mute.Equals(input.Mute))) return false;
            if (this.Hand != input.Hand || (this.Hand != null && !this.Hand.Equals(input.Hand))) return false;

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
                if (this.Pid != null) hashCode = hashCode * 59 + this.Pid.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Video != null) hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.Mute != null) hashCode = hashCode * 59 + this.Mute.GetHashCode();
                if (this.Hand != null) hashCode = hashCode * 59 + this.Hand.GetHashCode();
                return hashCode;
            }
        }
    }
}
