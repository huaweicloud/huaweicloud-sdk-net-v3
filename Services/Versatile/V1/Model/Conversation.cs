using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Versatile.V1.Model
{
    /// <summary>
    /// 会话记录
    /// </summary>
    public class Conversation 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lastUpdateTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastUpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("messageList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Message> MessageList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Conversation {\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  messageList: ").Append(MessageList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Conversation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Conversation input)
        {
            if (input == null) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;
            if (this.MessageList != input.MessageList || (this.MessageList != null && input.MessageList != null && !this.MessageList.SequenceEqual(input.MessageList))) return false;

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
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.MessageList != null) hashCode = hashCode * 59 + this.MessageList.GetHashCode();
                return hashCode;
            }
        }
    }
}
