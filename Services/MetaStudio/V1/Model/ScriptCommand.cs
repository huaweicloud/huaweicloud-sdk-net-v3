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
    /// 数字人话术命令信息。
    /// </summary>
    public class ScriptCommand 
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
        /// 直播剧本列表。
        /// </summary>
        [JsonProperty("scene_scripts", NullValueHandling = NullValueHandling.Ignore)]
        public List<LivePlayingScriptInfo> SceneScripts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScriptCommand {\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  commandId: ").Append(CommandId).Append("\n");
            sb.Append("  commandTime: ").Append(CommandTime).Append("\n");
            sb.Append("  sceneScripts: ").Append(SceneScripts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScriptCommand);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScriptCommand input)
        {
            if (input == null) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.CommandId != input.CommandId || (this.CommandId != null && !this.CommandId.Equals(input.CommandId))) return false;
            if (this.CommandTime != input.CommandTime || (this.CommandTime != null && !this.CommandTime.Equals(input.CommandTime))) return false;
            if (this.SceneScripts != input.SceneScripts || (this.SceneScripts != null && input.SceneScripts != null && !this.SceneScripts.SequenceEqual(input.SceneScripts))) return false;

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
                if (this.SceneScripts != null) hashCode = hashCode * 59 + this.SceneScripts.GetHashCode();
                return hashCode;
            }
        }
    }
}
