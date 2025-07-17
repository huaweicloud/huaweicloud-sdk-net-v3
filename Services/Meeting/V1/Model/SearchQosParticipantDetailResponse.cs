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
    /// Response Object
    /// </summary>
    public class SearchQosParticipantDetailResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public QosParticipantInfo User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("qos", NullValueHandling = NullValueHandling.Ignore)]
        public QosInfo Qos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchQosParticipantDetailResponse {\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  qos: ").Append(Qos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchQosParticipantDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchQosParticipantDetailResponse input)
        {
            if (input == null) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.Qos != input.Qos || (this.Qos != null && !this.Qos.Equals(input.Qos))) return false;

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
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Qos != null) hashCode = hashCode * 59 + this.Qos.GetHashCode();
                return hashCode;
            }
        }
    }
}
