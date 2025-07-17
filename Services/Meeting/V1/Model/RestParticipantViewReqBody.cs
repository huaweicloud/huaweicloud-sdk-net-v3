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
    /// 会场选看请求。
    /// </summary>
    public class RestParticipantViewReqBody 
    {

        /// <summary>
        /// 选看类型。 - 2: 选看会场
        /// </summary>
        [JsonProperty("viewType", NullValueHandling = NullValueHandling.Ignore)]
        public int? ViewType { get; set; }

        /// <summary>
        /// 被选看的与会者标识。
        /// </summary>
        [JsonProperty("participantID", NullValueHandling = NullValueHandling.Ignore)]
        public string ParticipantID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestParticipantViewReqBody {\n");
            sb.Append("  viewType: ").Append(ViewType).Append("\n");
            sb.Append("  participantID: ").Append(ParticipantID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestParticipantViewReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestParticipantViewReqBody input)
        {
            if (input == null) return false;
            if (this.ViewType != input.ViewType || (this.ViewType != null && !this.ViewType.Equals(input.ViewType))) return false;
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
                if (this.ViewType != null) hashCode = hashCode * 59 + this.ViewType.GetHashCode();
                if (this.ParticipantID != null) hashCode = hashCode * 59 + this.ParticipantID.GetHashCode();
                return hashCode;
            }
        }
    }
}
