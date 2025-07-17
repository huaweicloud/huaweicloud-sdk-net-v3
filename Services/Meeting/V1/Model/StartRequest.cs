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
    /// 激活会议请求。
    /// </summary>
    public class StartRequest 
    {

        /// <summary>
        /// 会议ID。
        /// </summary>
        [JsonProperty("conferenceID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceID { get; set; }

        /// <summary>
        /// 会议密码。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartRequest {\n");
            sb.Append("  conferenceID: ").Append(ConferenceID).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartRequest input)
        {
            if (input == null) return false;
            if (this.ConferenceID != input.ConferenceID || (this.ConferenceID != null && !this.ConferenceID.Equals(input.ConferenceID))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;

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
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }
    }
}
