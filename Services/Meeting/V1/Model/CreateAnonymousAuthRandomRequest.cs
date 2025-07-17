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
    public class CreateAnonymousAuthRandomRequest 
    {

        /// <summary>
        /// 会议ID。
        /// </summary>
        [SDKProperty("conferenceID", IsQuery = true)]
        [JsonProperty("conferenceID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceID { get; set; }

        /// <summary>
        /// 会议密码。
        /// </summary>
        [SDKProperty("X-Password", IsHeader = true)]
        [JsonProperty("X-Password", NullValueHandling = NullValueHandling.Ignore)]
        public string XPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAnonymousAuthRandomRequest {\n");
            sb.Append("  conferenceID: ").Append(ConferenceID).Append("\n");
            sb.Append("  xPassword: ").Append(XPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAnonymousAuthRandomRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAnonymousAuthRandomRequest input)
        {
            if (input == null) return false;
            if (this.ConferenceID != input.ConferenceID || (this.ConferenceID != null && !this.ConferenceID.Equals(input.ConferenceID))) return false;
            if (this.XPassword != input.XPassword || (this.XPassword != null && !this.XPassword.Equals(input.XPassword))) return false;

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
                if (this.XPassword != null) hashCode = hashCode * 59 + this.XPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
