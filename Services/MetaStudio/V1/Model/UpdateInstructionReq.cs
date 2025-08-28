using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 修改指令请求。
    /// </summary>
    public class UpdateInstructionReq 
    {

        /// <summary>
        /// 指令名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 指令描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 操作指令。
        /// </summary>
        [JsonProperty("instruction", NullValueHandling = NullValueHandling.Ignore)]
        public string Instruction { get; set; }

        /// <summary>
        /// 槽位列表
        /// </summary>
        [JsonProperty("slot_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstructionSlotInfo> SlotList { get; set; }

        /// <summary>
        /// 指令回复话术列表
        /// </summary>
        [JsonProperty("reply_words_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstructionReplyWordsInfo> ReplyWordsList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstructionReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  instruction: ").Append(Instruction).Append("\n");
            sb.Append("  slotList: ").Append(SlotList).Append("\n");
            sb.Append("  replyWordsList: ").Append(ReplyWordsList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInstructionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInstructionReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Instruction != input.Instruction || (this.Instruction != null && !this.Instruction.Equals(input.Instruction))) return false;
            if (this.SlotList != input.SlotList || (this.SlotList != null && input.SlotList != null && !this.SlotList.SequenceEqual(input.SlotList))) return false;
            if (this.ReplyWordsList != input.ReplyWordsList || (this.ReplyWordsList != null && input.ReplyWordsList != null && !this.ReplyWordsList.SequenceEqual(input.ReplyWordsList))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Instruction != null) hashCode = hashCode * 59 + this.Instruction.GetHashCode();
                if (this.SlotList != null) hashCode = hashCode * 59 + this.SlotList.GetHashCode();
                if (this.ReplyWordsList != null) hashCode = hashCode * 59 + this.ReplyWordsList.GetHashCode();
                return hashCode;
            }
        }
    }
}
