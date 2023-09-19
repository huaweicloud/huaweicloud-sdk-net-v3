using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MemberGroupandStreamResults 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_streams", NullValueHandling = NullValueHandling.Ignore)]
        public List<MemberGroupandStreamLogStreams> LogStreams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberGroupandStreamResults {\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  logStreams: ").Append(LogStreams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MemberGroupandStreamResults);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MemberGroupandStreamResults input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogGroupId == input.LogGroupId ||
                    (this.LogGroupId != null &&
                    this.LogGroupId.Equals(input.LogGroupId))
                ) && 
                (
                    this.LogGroupName == input.LogGroupName ||
                    (this.LogGroupName != null &&
                    this.LogGroupName.Equals(input.LogGroupName))
                ) && 
                (
                    this.LogStreams == input.LogStreams ||
                    this.LogStreams != null &&
                    input.LogStreams != null &&
                    this.LogStreams.SequenceEqual(input.LogStreams)
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
                if (this.LogGroupId != null)
                    hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogGroupName != null)
                    hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.LogStreams != null)
                    hashCode = hashCode * 59 + this.LogStreams.GetHashCode();
                return hashCode;
            }
        }
    }
}
