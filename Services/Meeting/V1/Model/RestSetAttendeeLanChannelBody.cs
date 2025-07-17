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
    /// 传译员信息
    /// </summary>
    public class RestSetAttendeeLanChannelBody 
    {

        /// <summary>
        /// 会场标识列表。
        /// </summary>
        [JsonProperty("participantIDs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ParticipantIDs { get; set; }

        /// <summary>
        /// 与会者收听的语言频道，普通与会者听与说一致。
        /// </summary>
        [JsonProperty("listenLanChannel", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenLanChannel { get; set; }

        /// <summary>
        /// 与会者发言的语言频道，普通与会者听与说一致。
        /// </summary>
        [JsonProperty("speakLanChannel", NullValueHandling = NullValueHandling.Ignore)]
        public string SpeakLanChannel { get; set; }

        /// <summary>
        /// 是否包含原声，0：不包含，1：包含。
        /// </summary>
        [JsonProperty("includeOriginalVoice", NullValueHandling = NullValueHandling.Ignore)]
        public int? IncludeOriginalVoice { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestSetAttendeeLanChannelBody {\n");
            sb.Append("  participantIDs: ").Append(ParticipantIDs).Append("\n");
            sb.Append("  listenLanChannel: ").Append(ListenLanChannel).Append("\n");
            sb.Append("  speakLanChannel: ").Append(SpeakLanChannel).Append("\n");
            sb.Append("  includeOriginalVoice: ").Append(IncludeOriginalVoice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestSetAttendeeLanChannelBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestSetAttendeeLanChannelBody input)
        {
            if (input == null) return false;
            if (this.ParticipantIDs != input.ParticipantIDs || (this.ParticipantIDs != null && input.ParticipantIDs != null && !this.ParticipantIDs.SequenceEqual(input.ParticipantIDs))) return false;
            if (this.ListenLanChannel != input.ListenLanChannel || (this.ListenLanChannel != null && !this.ListenLanChannel.Equals(input.ListenLanChannel))) return false;
            if (this.SpeakLanChannel != input.SpeakLanChannel || (this.SpeakLanChannel != null && !this.SpeakLanChannel.Equals(input.SpeakLanChannel))) return false;
            if (this.IncludeOriginalVoice != input.IncludeOriginalVoice || (this.IncludeOriginalVoice != null && !this.IncludeOriginalVoice.Equals(input.IncludeOriginalVoice))) return false;

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
                if (this.ParticipantIDs != null) hashCode = hashCode * 59 + this.ParticipantIDs.GetHashCode();
                if (this.ListenLanChannel != null) hashCode = hashCode * 59 + this.ListenLanChannel.GetHashCode();
                if (this.SpeakLanChannel != null) hashCode = hashCode * 59 + this.SpeakLanChannel.GetHashCode();
                if (this.IncludeOriginalVoice != null) hashCode = hashCode * 59 + this.IncludeOriginalVoice.GetHashCode();
                return hashCode;
            }
        }
    }
}
