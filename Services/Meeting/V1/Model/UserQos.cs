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
    /// 会场网络质量对象
    /// </summary>
    public class UserQos 
    {

        /// <summary>
        /// 会场ID
        /// </summary>
        [JsonProperty("participantID", NullValueHandling = NullValueHandling.Ignore)]
        public string ParticipantID { get; set; }

        /// <summary>
        /// 网络质量评级
        /// </summary>
        [JsonProperty("netRate", NullValueHandling = NullValueHandling.Ignore)]
        public string NetRate { get; set; }

        /// <summary>
        /// 上行总带宽(kbit/s)
        /// </summary>
        [JsonProperty("bandWidthUp", NullValueHandling = NullValueHandling.Ignore)]
        public int? BandWidthUp { get; set; }

        /// <summary>
        /// 下行总带宽(kbit/s)
        /// </summary>
        [JsonProperty("bandWidthDown", NullValueHandling = NullValueHandling.Ignore)]
        public int? BandWidthDown { get; set; }

        /// <summary>
        /// 上行丢包率（千分数）
        /// </summary>
        [JsonProperty("lostPacketRateUp", NullValueHandling = NullValueHandling.Ignore)]
        public int? LostPacketRateUp { get; set; }

        /// <summary>
        /// 下行丢包率（千分数）
        /// </summary>
        [JsonProperty("lostPacketRateDown", NullValueHandling = NullValueHandling.Ignore)]
        public int? LostPacketRateDown { get; set; }

        /// <summary>
        /// 时延(ms)
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public int? Delay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("videoQos", NullValueHandling = NullValueHandling.Ignore)]
        public MediaQos VideoQos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audioQos", NullValueHandling = NullValueHandling.Ignore)]
        public MediaQos AudioQos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auxQos", NullValueHandling = NullValueHandling.Ignore)]
        public MediaQos AuxQos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserQos {\n");
            sb.Append("  participantID: ").Append(ParticipantID).Append("\n");
            sb.Append("  netRate: ").Append(NetRate).Append("\n");
            sb.Append("  bandWidthUp: ").Append(BandWidthUp).Append("\n");
            sb.Append("  bandWidthDown: ").Append(BandWidthDown).Append("\n");
            sb.Append("  lostPacketRateUp: ").Append(LostPacketRateUp).Append("\n");
            sb.Append("  lostPacketRateDown: ").Append(LostPacketRateDown).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  videoQos: ").Append(VideoQos).Append("\n");
            sb.Append("  audioQos: ").Append(AudioQos).Append("\n");
            sb.Append("  auxQos: ").Append(AuxQos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserQos);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserQos input)
        {
            if (input == null) return false;
            if (this.ParticipantID != input.ParticipantID || (this.ParticipantID != null && !this.ParticipantID.Equals(input.ParticipantID))) return false;
            if (this.NetRate != input.NetRate || (this.NetRate != null && !this.NetRate.Equals(input.NetRate))) return false;
            if (this.BandWidthUp != input.BandWidthUp || (this.BandWidthUp != null && !this.BandWidthUp.Equals(input.BandWidthUp))) return false;
            if (this.BandWidthDown != input.BandWidthDown || (this.BandWidthDown != null && !this.BandWidthDown.Equals(input.BandWidthDown))) return false;
            if (this.LostPacketRateUp != input.LostPacketRateUp || (this.LostPacketRateUp != null && !this.LostPacketRateUp.Equals(input.LostPacketRateUp))) return false;
            if (this.LostPacketRateDown != input.LostPacketRateDown || (this.LostPacketRateDown != null && !this.LostPacketRateDown.Equals(input.LostPacketRateDown))) return false;
            if (this.Delay != input.Delay || (this.Delay != null && !this.Delay.Equals(input.Delay))) return false;
            if (this.VideoQos != input.VideoQos || (this.VideoQos != null && !this.VideoQos.Equals(input.VideoQos))) return false;
            if (this.AudioQos != input.AudioQos || (this.AudioQos != null && !this.AudioQos.Equals(input.AudioQos))) return false;
            if (this.AuxQos != input.AuxQos || (this.AuxQos != null && !this.AuxQos.Equals(input.AuxQos))) return false;

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
                if (this.NetRate != null) hashCode = hashCode * 59 + this.NetRate.GetHashCode();
                if (this.BandWidthUp != null) hashCode = hashCode * 59 + this.BandWidthUp.GetHashCode();
                if (this.BandWidthDown != null) hashCode = hashCode * 59 + this.BandWidthDown.GetHashCode();
                if (this.LostPacketRateUp != null) hashCode = hashCode * 59 + this.LostPacketRateUp.GetHashCode();
                if (this.LostPacketRateDown != null) hashCode = hashCode * 59 + this.LostPacketRateDown.GetHashCode();
                if (this.Delay != null) hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.VideoQos != null) hashCode = hashCode * 59 + this.VideoQos.GetHashCode();
                if (this.AudioQos != null) hashCode = hashCode * 59 + this.AudioQos.GetHashCode();
                if (this.AuxQos != null) hashCode = hashCode * 59 + this.AuxQos.GetHashCode();
                return hashCode;
            }
        }
    }
}
