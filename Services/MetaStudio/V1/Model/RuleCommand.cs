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
    /// 数字人互动规则命令信息。
    /// </summary>
    public class RuleCommand 
    {

        /// <summary>
        /// 直播间ID
        /// </summary>
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 直播任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 命令ID。
        /// </summary>
        [JsonProperty("command_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandId { get; set; }

        /// <summary>
        /// 命令时间。格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("command_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandTime { get; set; }

        /// <summary>
        /// 互动规则列表
        /// </summary>
        [JsonProperty("interaction_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<LiveRoomInteractionRuleInfo> InteractionRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleCommand {\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  commandId: ").Append(CommandId).Append("\n");
            sb.Append("  commandTime: ").Append(CommandTime).Append("\n");
            sb.Append("  interactionRules: ").Append(InteractionRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleCommand);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleCommand input)
        {
            if (input == null) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.CommandId != input.CommandId || (this.CommandId != null && !this.CommandId.Equals(input.CommandId))) return false;
            if (this.CommandTime != input.CommandTime || (this.CommandTime != null && !this.CommandTime.Equals(input.CommandTime))) return false;
            if (this.InteractionRules != input.InteractionRules || (this.InteractionRules != null && input.InteractionRules != null && !this.InteractionRules.SequenceEqual(input.InteractionRules))) return false;

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
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.CommandId != null) hashCode = hashCode * 59 + this.CommandId.GetHashCode();
                if (this.CommandTime != null) hashCode = hashCode * 59 + this.CommandTime.GetHashCode();
                if (this.InteractionRules != null) hashCode = hashCode * 59 + this.InteractionRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
