using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResendReq 
    {

        /// <summary>
        /// **参数解释**： Group ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值** 不涉及。
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        /// <summary>
        /// **参数解释**： 消息所属Topic。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值** 不涉及。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// **参数解释**： 客户端ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值** 不涉及。
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// **参数解释**： 消息列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值** 不涉及。
        /// </summary>
        [JsonProperty("msg_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MsgIdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResendReq {\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  clientId: ").Append(ClientId).Append("\n");
            sb.Append("  msgIdList: ").Append(MsgIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResendReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResendReq input)
        {
            if (input == null) return false;
            if (this.Group != input.Group || (this.Group != null && !this.Group.Equals(input.Group))) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.ClientId != input.ClientId || (this.ClientId != null && !this.ClientId.Equals(input.ClientId))) return false;
            if (this.MsgIdList != input.MsgIdList || (this.MsgIdList != null && input.MsgIdList != null && !this.MsgIdList.SequenceEqual(input.MsgIdList))) return false;

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
                if (this.Group != null) hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.ClientId != null) hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.MsgIdList != null) hashCode = hashCode * 59 + this.MsgIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
