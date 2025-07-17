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
    /// 邀请与会者请求。
    /// </summary>
    public class RestInviteReqBody 
    {

        /// <summary>
        /// 邀请的与会者列表。
        /// </summary>
        [JsonProperty("attendees", NullValueHandling = NullValueHandling.Ignore)]
        public List<Attendee> Attendees { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestInviteReqBody {\n");
            sb.Append("  attendees: ").Append(Attendees).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestInviteReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestInviteReqBody input)
        {
            if (input == null) return false;
            if (this.Attendees != input.Attendees || (this.Attendees != null && input.Attendees != null && !this.Attendees.SequenceEqual(input.Attendees))) return false;

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
                return hashCode;
            }
        }
    }
}
