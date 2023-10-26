using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// HIS 用户快速执行脚本实体类。
    /// </summary>
    public class HISFastScript 
    {

        /// <summary>
        /// 脚本类型。SHELL BAT PYTHON POWER_SHELL
        /// </summary>
        [JsonProperty("script_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptType { get; set; }

        /// <summary>
        /// 执行脚本的ECS机器用户。
        /// </summary>
        [JsonProperty("cmd_user", NullValueHandling = NullValueHandling.Ignore)]
        public string CmdUser { get; set; }

        /// <summary>
        /// 脚本内容。
        /// </summary>
        [JsonProperty("script_content", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptContent { get; set; }

        /// <summary>
        /// 执行的机器列表。
        /// </summary>
        [JsonProperty("ecs_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsIdList { get; set; }

        /// <summary>
        /// 任务名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 任务参数，多个参数以空格分隔。
        /// </summary>
        [JsonProperty("script_args", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptArgs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HISFastScript {\n");
            sb.Append("  scriptType: ").Append(ScriptType).Append("\n");
            sb.Append("  cmdUser: ").Append(CmdUser).Append("\n");
            sb.Append("  scriptContent: ").Append(ScriptContent).Append("\n");
            sb.Append("  ecsIdList: ").Append(EcsIdList).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  scriptArgs: ").Append(ScriptArgs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HISFastScript);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HISFastScript input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScriptType == input.ScriptType ||
                    (this.ScriptType != null &&
                    this.ScriptType.Equals(input.ScriptType))
                ) && 
                (
                    this.CmdUser == input.CmdUser ||
                    (this.CmdUser != null &&
                    this.CmdUser.Equals(input.CmdUser))
                ) && 
                (
                    this.ScriptContent == input.ScriptContent ||
                    (this.ScriptContent != null &&
                    this.ScriptContent.Equals(input.ScriptContent))
                ) && 
                (
                    this.EcsIdList == input.EcsIdList ||
                    (this.EcsIdList != null &&
                    this.EcsIdList.Equals(input.EcsIdList))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ScriptArgs == input.ScriptArgs ||
                    (this.ScriptArgs != null &&
                    this.ScriptArgs.Equals(input.ScriptArgs))
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
                if (this.ScriptType != null)
                    hashCode = hashCode * 59 + this.ScriptType.GetHashCode();
                if (this.CmdUser != null)
                    hashCode = hashCode * 59 + this.CmdUser.GetHashCode();
                if (this.ScriptContent != null)
                    hashCode = hashCode * 59 + this.ScriptContent.GetHashCode();
                if (this.EcsIdList != null)
                    hashCode = hashCode * 59 + this.EcsIdList.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ScriptArgs != null)
                    hashCode = hashCode * 59 + this.ScriptArgs.GetHashCode();
                return hashCode;
            }
        }
    }
}
