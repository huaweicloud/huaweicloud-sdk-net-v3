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
    /// Response Object
    /// </summary>
    public class ListLogStreamsResponse : SdkResponse
    {

        /// <summary>
        /// 日志流数组
        /// </summary>
        [JsonProperty("log_streams", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListLogStreamsResponseBody1LogStreams> LogStreams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLogStreamsResponse {\n");
            sb.Append("  logStreams: ").Append(LogStreams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLogStreamsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLogStreamsResponse input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.LogStreams != null)
                    hashCode = hashCode * 59 + this.LogStreams.GetHashCode();
                return hashCode;
            }
        }
    }
}
