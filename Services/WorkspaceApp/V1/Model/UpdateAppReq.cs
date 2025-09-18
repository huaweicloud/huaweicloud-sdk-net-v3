using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 修改应用属性(注意非空字段的限制,操作时会使用入参的字段直接覆盖已有字段的值)。
    /// </summary>
    public class UpdateAppReq 
    {

        /// <summary>
        /// 应用名称,名称需满足如下规则: 1. 名称允许可见字符或空格，不可为全空格。 2. 长度1~64个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 应用版本号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 执行路径。
        /// </summary>
        [JsonProperty("execute_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutePath { get; set; }

        /// <summary>
        /// 应用工作目录。
        /// </summary>
        [JsonProperty("work_path", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkPath { get; set; }

        /// <summary>
        /// 应用描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 启动命令行参数。
        /// </summary>
        [JsonProperty("command_param", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public AppStateEnum? State { get; set; }

        /// <summary>
        /// 是否使用沙箱模式运行，取值为： - false: 表示不以沙箱模式运行 - true: 表示以沙箱模式运行
        /// </summary>
        [JsonProperty("sandbox_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SandboxEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("app_extended_info", NullValueHandling = NullValueHandling.Ignore)]
        public AppExtendedInfo AppExtendedInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAppReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  executePath: ").Append(ExecutePath).Append("\n");
            sb.Append("  workPath: ").Append(WorkPath).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  commandParam: ").Append(CommandParam).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  sandboxEnable: ").Append(SandboxEnable).Append("\n");
            sb.Append("  appExtendedInfo: ").Append(AppExtendedInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAppReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAppReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.ExecutePath != input.ExecutePath || (this.ExecutePath != null && !this.ExecutePath.Equals(input.ExecutePath))) return false;
            if (this.WorkPath != input.WorkPath || (this.WorkPath != null && !this.WorkPath.Equals(input.WorkPath))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CommandParam != input.CommandParam || (this.CommandParam != null && !this.CommandParam.Equals(input.CommandParam))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.SandboxEnable != input.SandboxEnable || (this.SandboxEnable != null && !this.SandboxEnable.Equals(input.SandboxEnable))) return false;
            if (this.AppExtendedInfo != input.AppExtendedInfo || (this.AppExtendedInfo != null && !this.AppExtendedInfo.Equals(input.AppExtendedInfo))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ExecutePath != null) hashCode = hashCode * 59 + this.ExecutePath.GetHashCode();
                if (this.WorkPath != null) hashCode = hashCode * 59 + this.WorkPath.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CommandParam != null) hashCode = hashCode * 59 + this.CommandParam.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SandboxEnable != null) hashCode = hashCode * 59 + this.SandboxEnable.GetHashCode();
                if (this.AppExtendedInfo != null) hashCode = hashCode * 59 + this.AppExtendedInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
