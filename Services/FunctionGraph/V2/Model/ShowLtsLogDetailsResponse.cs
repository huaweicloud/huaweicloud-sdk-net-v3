using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowLtsLogDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 日志组id
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 日志流id
        /// </summary>
        [JsonProperty("stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamId { get; set; }

        /// <summary>
        /// 日志流名称
        /// </summary>
        [JsonProperty("stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLtsLogDetailsResponse {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  streamId: ").Append(StreamId).Append("\n");
            sb.Append("  streamName: ").Append(StreamName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLtsLogDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLtsLogDetailsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.StreamId == input.StreamId ||
                    (this.StreamId != null &&
                    this.StreamId.Equals(input.StreamId))
                ) && 
                (
                    this.StreamName == input.StreamName ||
                    (this.StreamName != null &&
                    this.StreamName.Equals(input.StreamName))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.StreamId != null)
                    hashCode = hashCode * 59 + this.StreamId.GetHashCode();
                if (this.StreamName != null)
                    hashCode = hashCode * 59 + this.StreamName.GetHashCode();
                return hashCode;
            }
        }
    }
}