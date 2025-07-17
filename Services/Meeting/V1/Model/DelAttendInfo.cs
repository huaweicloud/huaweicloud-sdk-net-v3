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
    /// 待删除会场信息
    /// </summary>
    public class DelAttendInfo 
    {

        /// <summary>
        /// 会场号码。
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 与会者标识，已入会的必须填写该字段。
        /// </summary>
        [JsonProperty("participantID", NullValueHandling = NullValueHandling.Ignore)]
        public string ParticipantID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DelAttendInfo {\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  participantID: ").Append(ParticipantID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DelAttendInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DelAttendInfo input)
        {
            if (input == null) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.ParticipantID != input.ParticipantID || (this.ParticipantID != null && !this.ParticipantID.Equals(input.ParticipantID))) return false;

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
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.ParticipantID != null) hashCode = hashCode * 59 + this.ParticipantID.GetHashCode();
                return hashCode;
            }
        }
    }
}
