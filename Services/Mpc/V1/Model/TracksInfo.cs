using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TracksInfo 
    {

        /// <summary>
        /// 音频轨的声道layout 
        /// </summary>
        [JsonProperty("channel_layout", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelLayout { get; set; }

        /// <summary>
        /// 音频轨对应语言描述 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TracksInfo {\n");
            sb.Append("  channelLayout: ").Append(ChannelLayout).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TracksInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TracksInfo input)
        {
            if (input == null) return false;
            if (this.ChannelLayout != input.ChannelLayout || (this.ChannelLayout != null && !this.ChannelLayout.Equals(input.ChannelLayout))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;

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
                if (this.ChannelLayout != null) hashCode = hashCode * 59 + this.ChannelLayout.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
