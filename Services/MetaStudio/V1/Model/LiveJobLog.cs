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
    /// 直播任务记录。
    /// </summary>
    public class LiveJobLog 
    {

        /// <summary>
        /// 直播互动记录文件地址
        /// </summary>
        [JsonProperty("interaction_records_url", NullValueHandling = NullValueHandling.Ignore)]
        public string InteractionRecordsUrl { get; set; }

        /// <summary>
        /// 任务配置记录文件地址
        /// </summary>
        [JsonProperty("job_config_records_url", NullValueHandling = NullValueHandling.Ignore)]
        public string JobConfigRecordsUrl { get; set; }

        /// <summary>
        /// 剧本播放记录文件地址
        /// </summary>
        [JsonProperty("scripts_records_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptsRecordsUrl { get; set; }

        /// <summary>
        /// 命令接受记录文件地址
        /// </summary>
        [JsonProperty("command_reviced_records_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandRevicedRecordsUrl { get; set; }

        /// <summary>
        /// 命令执行记录文件地址
        /// </summary>
        [JsonProperty("command_exec_records_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandExecRecordsUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveJobLog {\n");
            sb.Append("  interactionRecordsUrl: ").Append(InteractionRecordsUrl).Append("\n");
            sb.Append("  jobConfigRecordsUrl: ").Append(JobConfigRecordsUrl).Append("\n");
            sb.Append("  scriptsRecordsUrl: ").Append(ScriptsRecordsUrl).Append("\n");
            sb.Append("  commandRevicedRecordsUrl: ").Append(CommandRevicedRecordsUrl).Append("\n");
            sb.Append("  commandExecRecordsUrl: ").Append(CommandExecRecordsUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveJobLog);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveJobLog input)
        {
            if (input == null) return false;
            if (this.InteractionRecordsUrl != input.InteractionRecordsUrl || (this.InteractionRecordsUrl != null && !this.InteractionRecordsUrl.Equals(input.InteractionRecordsUrl))) return false;
            if (this.JobConfigRecordsUrl != input.JobConfigRecordsUrl || (this.JobConfigRecordsUrl != null && !this.JobConfigRecordsUrl.Equals(input.JobConfigRecordsUrl))) return false;
            if (this.ScriptsRecordsUrl != input.ScriptsRecordsUrl || (this.ScriptsRecordsUrl != null && !this.ScriptsRecordsUrl.Equals(input.ScriptsRecordsUrl))) return false;
            if (this.CommandRevicedRecordsUrl != input.CommandRevicedRecordsUrl || (this.CommandRevicedRecordsUrl != null && !this.CommandRevicedRecordsUrl.Equals(input.CommandRevicedRecordsUrl))) return false;
            if (this.CommandExecRecordsUrl != input.CommandExecRecordsUrl || (this.CommandExecRecordsUrl != null && !this.CommandExecRecordsUrl.Equals(input.CommandExecRecordsUrl))) return false;

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
                if (this.InteractionRecordsUrl != null) hashCode = hashCode * 59 + this.InteractionRecordsUrl.GetHashCode();
                if (this.JobConfigRecordsUrl != null) hashCode = hashCode * 59 + this.JobConfigRecordsUrl.GetHashCode();
                if (this.ScriptsRecordsUrl != null) hashCode = hashCode * 59 + this.ScriptsRecordsUrl.GetHashCode();
                if (this.CommandRevicedRecordsUrl != null) hashCode = hashCode * 59 + this.CommandRevicedRecordsUrl.GetHashCode();
                if (this.CommandExecRecordsUrl != null) hashCode = hashCode * 59 + this.CommandExecRecordsUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
