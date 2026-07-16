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
    /// 算法配置信息，如启动文件等。
    /// </summary>
    public class AlgorithmResponseJobConfig 
    {

        /// <summary>
        /// 算法的代码目录。如：“/usr/app/”。应与boot_file一同出现。
        /// </summary>
        [JsonProperty("code_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeDir { get; set; }

        /// <summary>
        /// 算法的代码启动文件，需要在代码目录下。如：“/usr/app/boot.py”。应与code_dir一同出现。
        /// </summary>
        [JsonProperty("boot_file", NullValueHandling = NullValueHandling.Ignore)]
        public string BootFile { get; set; }

        /// <summary>
        /// 自定义镜像算法的容器启动命令。
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public string Command { get; set; }

        /// <summary>
        /// 算法的运行参数。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Parameter> Parameters { get; set; }

        /// <summary>
        /// 算法的数据输入。
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlgorithmResponseJobConfigInputs> Inputs { get; set; }

        /// <summary>
        /// 算法的数据输出。
        /// </summary>
        [JsonProperty("outputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlgorithmResponseJobConfigOutputs> Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public AlgorithmResponseJobConfigEngine Engine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("code_tree", NullValueHandling = NullValueHandling.Ignore)]
        public CodeTreeNode CodeTree { get; set; }

        /// <summary>
        /// 算法是否允许创建训练作业时自定义超参。
        /// </summary>
        [JsonProperty("parameters_customization", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ParametersCustomization { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlgorithmResponseJobConfig {\n");
            sb.Append("  codeDir: ").Append(CodeDir).Append("\n");
            sb.Append("  bootFile: ").Append(BootFile).Append("\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  outputs: ").Append(Outputs).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  codeTree: ").Append(CodeTree).Append("\n");
            sb.Append("  parametersCustomization: ").Append(ParametersCustomization).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlgorithmResponseJobConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlgorithmResponseJobConfig input)
        {
            if (input == null) return false;
            if (this.CodeDir != input.CodeDir || (this.CodeDir != null && !this.CodeDir.Equals(input.CodeDir))) return false;
            if (this.BootFile != input.BootFile || (this.BootFile != null && !this.BootFile.Equals(input.BootFile))) return false;
            if (this.Command != input.Command || (this.Command != null && !this.Command.Equals(input.Command))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.Inputs != input.Inputs || (this.Inputs != null && input.Inputs != null && !this.Inputs.SequenceEqual(input.Inputs))) return false;
            if (this.Outputs != input.Outputs || (this.Outputs != null && input.Outputs != null && !this.Outputs.SequenceEqual(input.Outputs))) return false;
            if (this.Engine != input.Engine || (this.Engine != null && !this.Engine.Equals(input.Engine))) return false;
            if (this.CodeTree != input.CodeTree || (this.CodeTree != null && !this.CodeTree.Equals(input.CodeTree))) return false;
            if (this.ParametersCustomization != input.ParametersCustomization || (this.ParametersCustomization != null && !this.ParametersCustomization.Equals(input.ParametersCustomization))) return false;

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
                if (this.CodeDir != null) hashCode = hashCode * 59 + this.CodeDir.GetHashCode();
                if (this.BootFile != null) hashCode = hashCode * 59 + this.BootFile.GetHashCode();
                if (this.Command != null) hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Inputs != null) hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Outputs != null) hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.Engine != null) hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.CodeTree != null) hashCode = hashCode * 59 + this.CodeTree.GetHashCode();
                if (this.ParametersCustomization != null) hashCode = hashCode * 59 + this.ParametersCustomization.GetHashCode();
                return hashCode;
            }
        }
    }
}
