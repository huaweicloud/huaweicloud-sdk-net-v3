using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowStreamPortraitResponse : SdkResponse
    {

        /// <summary>
        /// 播放画像信息列表。
        /// </summary>
        [JsonProperty("stream_portraits", NullValueHandling = NullValueHandling.Ignore)]
        public List<StreamPortrait> StreamPortraits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStreamPortraitResponse {\n");
            sb.Append("  streamPortraits: ").Append(StreamPortraits).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStreamPortraitResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStreamPortraitResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StreamPortraits == input.StreamPortraits ||
                    this.StreamPortraits != null &&
                    input.StreamPortraits != null &&
                    this.StreamPortraits.SequenceEqual(input.StreamPortraits)
                ) && 
                (
                    this.XRequestId == input.XRequestId ||
                    (this.XRequestId != null &&
                    this.XRequestId.Equals(input.XRequestId))
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
                if (this.StreamPortraits != null)
                    hashCode = hashCode * 59 + this.StreamPortraits.GetHashCode();
                if (this.XRequestId != null)
                    hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
