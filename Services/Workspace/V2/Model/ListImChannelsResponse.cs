using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListImChannelsResponse : SdkResponse
    {

        /// <summary>
        /// IM 通道配置列表
        /// </summary>
        [JsonProperty("im_channels", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImChannelItem> ImChannels { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListImChannelsResponse {\n");
            sb.Append("  imChannels: ").Append(ImChannels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListImChannelsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListImChannelsResponse input)
        {
            if (input == null) return false;
            if (this.ImChannels != input.ImChannels || (this.ImChannels != null && input.ImChannels != null && !this.ImChannels.SequenceEqual(input.ImChannels))) return false;

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
                if (this.ImChannels != null) hashCode = hashCode * 59 + this.ImChannels.GetHashCode();
                return hashCode;
            }
        }
    }
}
