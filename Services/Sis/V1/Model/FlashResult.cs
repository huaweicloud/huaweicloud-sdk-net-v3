using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FlashResult 
    {

        /// <summary>
        /// 音频声道id
        /// </summary>
        [JsonProperty("channel_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChannelId { get; set; }

        /// <summary>
        /// 分句结果
        /// </summary>
        [JsonProperty("sentences", NullValueHandling = NullValueHandling.Ignore)]
        public List<Sentences> Sentences { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlashResult {\n");
            sb.Append("  channelId: ").Append(ChannelId).Append("\n");
            sb.Append("  sentences: ").Append(Sentences).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlashResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlashResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) && 
                (
                    this.Sentences == input.Sentences ||
                    this.Sentences != null &&
                    input.Sentences != null &&
                    this.Sentences.SequenceEqual(input.Sentences)
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
                if (this.ChannelId != null)
                    hashCode = hashCode * 59 + this.ChannelId.GetHashCode();
                if (this.Sentences != null)
                    hashCode = hashCode * 59 + this.Sentences.GetHashCode();
                return hashCode;
            }
        }
    }
}
