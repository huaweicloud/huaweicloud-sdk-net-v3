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
    /// **参数解释**：算法管理算法配置。 **约束限制**：不涉及。
    /// </summary>
    public class TaskAlgorithm 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_config", NullValueHandling = NullValueHandling.Ignore)]
        public TaskAlgorithmJobConfig JobConfig { get; set; }

        /// <summary>
        /// **参数解释**：算法的代码目录。如：“/usr/app/”。 **约束限制**：应与boot_file一同出现。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("code_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeDir { get; set; }

        /// <summary>
        /// **参数解释**：算法的代码启动文件，需要在代码目录下。如：“/usr/app/boot.py”。 **约束限制**：应与code_dir一同出现。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("boot_file", NullValueHandling = NullValueHandling.Ignore)]
        public string BootFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public TaskAlgorithmEngine Engine { get; set; }

        /// <summary>
        /// **参数解释**：算法的数据输入。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskAlgorithmInputs> Inputs { get; set; }

        /// <summary>
        /// **参数解释**：算法的数据输出。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("outputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskAlgorithmOutputs> Outputs { get; set; }

        /// <summary>
        /// **参数解释**：算法的代码目录下载到训练容器内的本地路径。 **约束限制**： - 必须为/home下的目录； - v1兼容模式下，当前字段不生效； - 当code_dir以file://为前缀时，当前字段不生效。  **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("local_code_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalCodeDir { get; set; }

        /// <summary>
        /// **参数解释**：运行算法时所在的工作目录。 **约束限制**：v1兼容模式下，当前字段不生效。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("working_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkingDir { get; set; }

        /// <summary>
        /// **参数解释**：训练作业环境变量。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("environments", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Environments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskAlgorithm {\n");
            sb.Append("  jobConfig: ").Append(JobConfig).Append("\n");
            sb.Append("  codeDir: ").Append(CodeDir).Append("\n");
            sb.Append("  bootFile: ").Append(BootFile).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  outputs: ").Append(Outputs).Append("\n");
            sb.Append("  localCodeDir: ").Append(LocalCodeDir).Append("\n");
            sb.Append("  workingDir: ").Append(WorkingDir).Append("\n");
            sb.Append("  environments: ").Append(Environments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskAlgorithm);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskAlgorithm input)
        {
            if (input == null) return false;
            if (this.JobConfig != input.JobConfig || (this.JobConfig != null && !this.JobConfig.Equals(input.JobConfig))) return false;
            if (this.CodeDir != input.CodeDir || (this.CodeDir != null && !this.CodeDir.Equals(input.CodeDir))) return false;
            if (this.BootFile != input.BootFile || (this.BootFile != null && !this.BootFile.Equals(input.BootFile))) return false;
            if (this.Engine != input.Engine || (this.Engine != null && !this.Engine.Equals(input.Engine))) return false;
            if (this.Inputs != input.Inputs || (this.Inputs != null && input.Inputs != null && !this.Inputs.SequenceEqual(input.Inputs))) return false;
            if (this.Outputs != input.Outputs || (this.Outputs != null && input.Outputs != null && !this.Outputs.SequenceEqual(input.Outputs))) return false;
            if (this.LocalCodeDir != input.LocalCodeDir || (this.LocalCodeDir != null && !this.LocalCodeDir.Equals(input.LocalCodeDir))) return false;
            if (this.WorkingDir != input.WorkingDir || (this.WorkingDir != null && !this.WorkingDir.Equals(input.WorkingDir))) return false;
            if (this.Environments != input.Environments || (this.Environments != null && input.Environments != null && !this.Environments.SequenceEqual(input.Environments))) return false;

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
                if (this.JobConfig != null) hashCode = hashCode * 59 + this.JobConfig.GetHashCode();
                if (this.CodeDir != null) hashCode = hashCode * 59 + this.CodeDir.GetHashCode();
                if (this.BootFile != null) hashCode = hashCode * 59 + this.BootFile.GetHashCode();
                if (this.Engine != null) hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.Inputs != null) hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Outputs != null) hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.LocalCodeDir != null) hashCode = hashCode * 59 + this.LocalCodeDir.GetHashCode();
                if (this.WorkingDir != null) hashCode = hashCode * 59 + this.WorkingDir.GetHashCode();
                if (this.Environments != null) hashCode = hashCode * 59 + this.Environments.GetHashCode();
                return hashCode;
            }
        }
    }
}
