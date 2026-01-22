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
    public class ExportDlqMessageReq 
    {

        /// <summary>
        /// **参数解释**： 主题名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值** 不涉及。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// **参数解释**： 消息ID列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值** 不涉及。
        /// </summary>
        [JsonProperty("msg_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MsgIdList { get; set; }

        /// <summary>
        /// **参数解释**： 唯一Key列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值** 不涉及。
        /// </summary>
        [JsonProperty("uniq_key_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UniqKeyList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportDlqMessageReq {\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  msgIdList: ").Append(MsgIdList).Append("\n");
            sb.Append("  uniqKeyList: ").Append(UniqKeyList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportDlqMessageReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportDlqMessageReq input)
        {
            if (input == null) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.MsgIdList != input.MsgIdList || (this.MsgIdList != null && input.MsgIdList != null && !this.MsgIdList.SequenceEqual(input.MsgIdList))) return false;
            if (this.UniqKeyList != input.UniqKeyList || (this.UniqKeyList != null && input.UniqKeyList != null && !this.UniqKeyList.SequenceEqual(input.UniqKeyList))) return false;

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
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.MsgIdList != null) hashCode = hashCode * 59 + this.MsgIdList.GetHashCode();
                if (this.UniqKeyList != null) hashCode = hashCode * 59 + this.UniqKeyList.GetHashCode();
                return hashCode;
            }
        }
    }
}
