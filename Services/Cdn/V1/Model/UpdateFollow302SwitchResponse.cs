using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateFollow302SwitchResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("follow_status", NullValueHandling = NullValueHandling.Ignore)]
        public Follow302StatusBody FollowStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFollow302SwitchResponse {\n");
            sb.Append("  followStatus: ").Append(FollowStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateFollow302SwitchResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateFollow302SwitchResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FollowStatus == input.FollowStatus ||
                    (this.FollowStatus != null &&
                    this.FollowStatus.Equals(input.FollowStatus))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FollowStatus != null)
                    hashCode = hashCode * 59 + this.FollowStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
