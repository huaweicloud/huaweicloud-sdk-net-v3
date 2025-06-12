using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 输入信息。
    /// </summary>
    public class InputInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rtc_room_info", NullValueHandling = NullValueHandling.Ignore)]
        public RTCRoomInfoList RtcRoomInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputInfo {\n");
            sb.Append("  rtcRoomInfo: ").Append(RtcRoomInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InputInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InputInfo input)
        {
            if (input == null) return false;
            if (this.RtcRoomInfo != input.RtcRoomInfo || (this.RtcRoomInfo != null && !this.RtcRoomInfo.Equals(input.RtcRoomInfo))) return false;

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
                if (this.RtcRoomInfo != null) hashCode = hashCode * 59 + this.RtcRoomInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
