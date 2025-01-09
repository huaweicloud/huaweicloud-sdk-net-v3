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
    /// 批量执行脚本请求体。
    /// </summary>
    public class ExecuteScriptOrCommandReq 
    {

        /// <summary>
        /// 灰度资源数量。
        /// </summary>
        [JsonProperty("gray_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? GrayCount { get; set; }

        /// <summary>
        /// 资源类型，如桌面(DESKTOP)。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 灰度执行脚本的资源列表。
        /// </summary>
        [JsonProperty("gray_resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GrayResourceIds { get; set; }

        /// <summary>
        /// 灰度失败阈值，达到阈值后停止进行下一批资源执行脚本，小于gray_count。
        /// </summary>
        [JsonProperty("gray_fail_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? GrayFailThreshold { get; set; }

        /// <summary>
        /// 执行脚本的资源列表。
        /// </summary>
        [JsonProperty("resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// 执行的脚本列表。
        /// </summary>
        [JsonProperty("script_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ScriptIds { get; set; }

        /// <summary>
        /// 执行的命令行，与scripts二选一。
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public string Command { get; set; }

        /// <summary>
        /// 命令行的类型（POWERSHELL，BAT，SHELL）。
        /// </summary>
        [JsonProperty("command_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandType { get; set; }

        /// <summary>
        /// 执行脚本的超时时间，单位分钟。
        /// </summary>
        [JsonProperty("execution_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecutionTimeout { get; set; }

        /// <summary>
        /// 执行脚本前置步骤。
        /// </summary>
        [JsonProperty("pre_start", NullValueHandling = NullValueHandling.Ignore)]
        public string PreStart { get; set; }

        /// <summary>
        /// 执行脚本后置步骤(STOP,REBOOT)。
        /// </summary>
        [JsonProperty("post_finish", NullValueHandling = NullValueHandling.Ignore)]
        public string PostFinish { get; set; }

        /// <summary>
        /// 资源组类型，如桌面池(DESKTOP_POOL)。
        /// </summary>
        [JsonProperty("resource_group_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceGroupType { get; set; }

        /// <summary>
        /// 资源组ID。
        /// </summary>
        [JsonProperty("resource_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteScriptOrCommandReq {\n");
            sb.Append("  grayCount: ").Append(GrayCount).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  grayResourceIds: ").Append(GrayResourceIds).Append("\n");
            sb.Append("  grayFailThreshold: ").Append(GrayFailThreshold).Append("\n");
            sb.Append("  resourceIds: ").Append(ResourceIds).Append("\n");
            sb.Append("  scriptIds: ").Append(ScriptIds).Append("\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  commandType: ").Append(CommandType).Append("\n");
            sb.Append("  executionTimeout: ").Append(ExecutionTimeout).Append("\n");
            sb.Append("  preStart: ").Append(PreStart).Append("\n");
            sb.Append("  postFinish: ").Append(PostFinish).Append("\n");
            sb.Append("  resourceGroupType: ").Append(ResourceGroupType).Append("\n");
            sb.Append("  resourceGroupId: ").Append(ResourceGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteScriptOrCommandReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteScriptOrCommandReq input)
        {
            if (input == null) return false;
            if (this.GrayCount != input.GrayCount || (this.GrayCount != null && !this.GrayCount.Equals(input.GrayCount))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.GrayResourceIds != input.GrayResourceIds || (this.GrayResourceIds != null && input.GrayResourceIds != null && !this.GrayResourceIds.SequenceEqual(input.GrayResourceIds))) return false;
            if (this.GrayFailThreshold != input.GrayFailThreshold || (this.GrayFailThreshold != null && !this.GrayFailThreshold.Equals(input.GrayFailThreshold))) return false;
            if (this.ResourceIds != input.ResourceIds || (this.ResourceIds != null && input.ResourceIds != null && !this.ResourceIds.SequenceEqual(input.ResourceIds))) return false;
            if (this.ScriptIds != input.ScriptIds || (this.ScriptIds != null && input.ScriptIds != null && !this.ScriptIds.SequenceEqual(input.ScriptIds))) return false;
            if (this.Command != input.Command || (this.Command != null && !this.Command.Equals(input.Command))) return false;
            if (this.CommandType != input.CommandType || (this.CommandType != null && !this.CommandType.Equals(input.CommandType))) return false;
            if (this.ExecutionTimeout != input.ExecutionTimeout || (this.ExecutionTimeout != null && !this.ExecutionTimeout.Equals(input.ExecutionTimeout))) return false;
            if (this.PreStart != input.PreStart || (this.PreStart != null && !this.PreStart.Equals(input.PreStart))) return false;
            if (this.PostFinish != input.PostFinish || (this.PostFinish != null && !this.PostFinish.Equals(input.PostFinish))) return false;
            if (this.ResourceGroupType != input.ResourceGroupType || (this.ResourceGroupType != null && !this.ResourceGroupType.Equals(input.ResourceGroupType))) return false;
            if (this.ResourceGroupId != input.ResourceGroupId || (this.ResourceGroupId != null && !this.ResourceGroupId.Equals(input.ResourceGroupId))) return false;

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
                if (this.GrayCount != null) hashCode = hashCode * 59 + this.GrayCount.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.GrayResourceIds != null) hashCode = hashCode * 59 + this.GrayResourceIds.GetHashCode();
                if (this.GrayFailThreshold != null) hashCode = hashCode * 59 + this.GrayFailThreshold.GetHashCode();
                if (this.ResourceIds != null) hashCode = hashCode * 59 + this.ResourceIds.GetHashCode();
                if (this.ScriptIds != null) hashCode = hashCode * 59 + this.ScriptIds.GetHashCode();
                if (this.Command != null) hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.CommandType != null) hashCode = hashCode * 59 + this.CommandType.GetHashCode();
                if (this.ExecutionTimeout != null) hashCode = hashCode * 59 + this.ExecutionTimeout.GetHashCode();
                if (this.PreStart != null) hashCode = hashCode * 59 + this.PreStart.GetHashCode();
                if (this.PostFinish != null) hashCode = hashCode * 59 + this.PostFinish.GetHashCode();
                if (this.ResourceGroupType != null) hashCode = hashCode * 59 + this.ResourceGroupType.GetHashCode();
                if (this.ResourceGroupId != null) hashCode = hashCode * 59 + this.ResourceGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
