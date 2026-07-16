using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 训练作业算法。目前支持三种形式： - id：只取算法的id； - subscription_id+item_version_id：取算法的订阅id和版本id； - code_dir+boot_file：取训练作业的代码目录和启动文件。
    /// </summary>
    public class JobAlgorithmResponse 
    {

        /// <summary>
        /// 训练作业算法。目前支持三种形式：   - id：只取算法的id；   - subscription_id+item_version_id：取算法的订阅id和版本id；   - code_dir+boot_file：取训练作业的代码目录和启动文件。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 算法名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 订阅算法的订阅ID。应与item_version_id一同出现。
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// 订阅算法的版本。应与subscription_id一同出现。
        /// </summary>
        [JsonProperty("item_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemVersionId { get; set; }

        /// <summary>
        /// 训练作业的代码目录。如：“/usr/app/”。应与boot_file一同出现，如果boot_file已经填入id或subscription_id+item_version_id，则无需填写此参数。
        /// </summary>
        [JsonProperty("code_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeDir { get; set; }

        /// <summary>
        /// 训练作业的代码启动文件，需要在代码目录下。如：“/usr/app/boot.py”。应与code_dir一同出现，如果code_dir已经填入id或subscription_id+item_version_id，则无需填写此参数。
        /// </summary>
        [JsonProperty("boot_file", NullValueHandling = NullValueHandling.Ignore)]
        public string BootFile { get; set; }

        /// <summary>
        /// 自动化搜索作业的yaml配置路径，需要提供一个OBS路径。如：“obs://bucket/file.yaml”。
        /// </summary>
        [JsonProperty("autosearch_config_path", NullValueHandling = NullValueHandling.Ignore)]
        public string AutosearchConfigPath { get; set; }

        /// <summary>
        /// 自动化搜索作业的框架代码目录，需要提供一个OBS路径。如：“obs://bucket/files/”。
        /// </summary>
        [JsonProperty("autosearch_framework_path", NullValueHandling = NullValueHandling.Ignore)]
        public string AutosearchFrameworkPath { get; set; }

        /// <summary>
        /// 自定义镜像训练作业的自定义镜像的容器的启动命令。例如python train.py。
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public string Command { get; set; }

        /// <summary>
        /// 训练作业的运行参数。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Parameter> Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public JobAlgorithmResponsePolicies Policies { get; set; }

        /// <summary>
        /// **参数解释**：训练作业的数据输入。
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<InputResp> Inputs { get; set; }

        /// <summary>
        /// **参数解释**：训练作业的结果输出。
        /// </summary>
        [JsonProperty("outputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<OutputResp> Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public JobEngineResp Engine { get; set; }

        /// <summary>
        /// 算法的代码目录下载到训练容器内的本地路径。规则如下： - 必须为/home下的目录； - v1兼容模式下，当前字段不生效； - 当code_dir以file://为前缀时，当前字段不生效。
        /// </summary>
        [JsonProperty("local_code_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalCodeDir { get; set; }

        /// <summary>
        /// 运行算法时所在的工作目录。规则：v1兼容模式下，当前字段不生效。
        /// </summary>
        [JsonProperty("working_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkingDir { get; set; }

        /// <summary>
        /// 训练作业的环境变量。格式：\&quot;key\&quot;:\&quot;value\&quot;，无需填写。
        /// </summary>
        [JsonProperty("environments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, string>> Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public SummaryResp Summary { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobAlgorithmResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  subscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  itemVersionId: ").Append(ItemVersionId).Append("\n");
            sb.Append("  codeDir: ").Append(CodeDir).Append("\n");
            sb.Append("  bootFile: ").Append(BootFile).Append("\n");
            sb.Append("  autosearchConfigPath: ").Append(AutosearchConfigPath).Append("\n");
            sb.Append("  autosearchFrameworkPath: ").Append(AutosearchFrameworkPath).Append("\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  outputs: ").Append(Outputs).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  localCodeDir: ").Append(LocalCodeDir).Append("\n");
            sb.Append("  workingDir: ").Append(WorkingDir).Append("\n");
            sb.Append("  environments: ").Append(Environments).Append("\n");
            sb.Append("  summary: ").Append(Summary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobAlgorithmResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobAlgorithmResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SubscriptionId != input.SubscriptionId || (this.SubscriptionId != null && !this.SubscriptionId.Equals(input.SubscriptionId))) return false;
            if (this.ItemVersionId != input.ItemVersionId || (this.ItemVersionId != null && !this.ItemVersionId.Equals(input.ItemVersionId))) return false;
            if (this.CodeDir != input.CodeDir || (this.CodeDir != null && !this.CodeDir.Equals(input.CodeDir))) return false;
            if (this.BootFile != input.BootFile || (this.BootFile != null && !this.BootFile.Equals(input.BootFile))) return false;
            if (this.AutosearchConfigPath != input.AutosearchConfigPath || (this.AutosearchConfigPath != null && !this.AutosearchConfigPath.Equals(input.AutosearchConfigPath))) return false;
            if (this.AutosearchFrameworkPath != input.AutosearchFrameworkPath || (this.AutosearchFrameworkPath != null && !this.AutosearchFrameworkPath.Equals(input.AutosearchFrameworkPath))) return false;
            if (this.Command != input.Command || (this.Command != null && !this.Command.Equals(input.Command))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.Policies != input.Policies || (this.Policies != null && !this.Policies.Equals(input.Policies))) return false;
            if (this.Inputs != input.Inputs || (this.Inputs != null && input.Inputs != null && !this.Inputs.SequenceEqual(input.Inputs))) return false;
            if (this.Outputs != input.Outputs || (this.Outputs != null && input.Outputs != null && !this.Outputs.SequenceEqual(input.Outputs))) return false;
            if (this.Engine != input.Engine || (this.Engine != null && !this.Engine.Equals(input.Engine))) return false;
            if (this.LocalCodeDir != input.LocalCodeDir || (this.LocalCodeDir != null && !this.LocalCodeDir.Equals(input.LocalCodeDir))) return false;
            if (this.WorkingDir != input.WorkingDir || (this.WorkingDir != null && !this.WorkingDir.Equals(input.WorkingDir))) return false;
            if (this.Environments != input.Environments || (this.Environments != null && input.Environments != null && !this.Environments.SequenceEqual(input.Environments))) return false;
            if (this.Summary != input.Summary || (this.Summary != null && !this.Summary.Equals(input.Summary))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SubscriptionId != null) hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.ItemVersionId != null) hashCode = hashCode * 59 + this.ItemVersionId.GetHashCode();
                if (this.CodeDir != null) hashCode = hashCode * 59 + this.CodeDir.GetHashCode();
                if (this.BootFile != null) hashCode = hashCode * 59 + this.BootFile.GetHashCode();
                if (this.AutosearchConfigPath != null) hashCode = hashCode * 59 + this.AutosearchConfigPath.GetHashCode();
                if (this.AutosearchFrameworkPath != null) hashCode = hashCode * 59 + this.AutosearchFrameworkPath.GetHashCode();
                if (this.Command != null) hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Policies != null) hashCode = hashCode * 59 + this.Policies.GetHashCode();
                if (this.Inputs != null) hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Outputs != null) hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.Engine != null) hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.LocalCodeDir != null) hashCode = hashCode * 59 + this.LocalCodeDir.GetHashCode();
                if (this.WorkingDir != null) hashCode = hashCode * 59 + this.WorkingDir.GetHashCode();
                if (this.Environments != null) hashCode = hashCode * 59 + this.Environments.GetHashCode();
                if (this.Summary != null) hashCode = hashCode * 59 + this.Summary.GetHashCode();
                return hashCode;
            }
        }
    }
}
