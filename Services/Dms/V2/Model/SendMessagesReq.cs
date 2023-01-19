using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SendMessagesReq 
    {

        /// <summary>
        /// 发送消息成功后，是否返回Message ID，默认为false，设置为true时，返回参数才有Message ID。
        /// </summary>
        [JsonProperty("return_id", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnId { get; set; }

        /// <summary>
        /// 消息列表。
        /// </summary>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        public List<SendMessageEntity> Messages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendMessagesReq {\n");
            sb.Append("  returnId: ").Append(ReturnId).Append("\n");
            sb.Append("  messages: ").Append(Messages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendMessagesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SendMessagesReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReturnId == input.ReturnId ||
                    (this.ReturnId != null &&
                    this.ReturnId.Equals(input.ReturnId))
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    input.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
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
                if (this.ReturnId != null)
                    hashCode = hashCode * 59 + this.ReturnId.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                return hashCode;
            }
        }
    }
}
