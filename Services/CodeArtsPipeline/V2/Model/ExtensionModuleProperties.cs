using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 扩展模块属性信息
    /// </summary>
    public class ExtensionModuleProperties 
    {

        /// <summary>
        /// 构建清单版本
        /// </summary>
        [JsonProperty("build_manifestVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildManifestVersion { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 任务uuid
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        [JsonProperty("operationSystem", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationSystem { get; set; }

        /// <summary>
        /// 镜像来源
        /// </summary>
        [JsonProperty("imageSource", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageSource { get; set; }

        /// <summary>
        /// 镜像名
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 图标路径
        /// </summary>
        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        /// <summary>
        /// 环境变量，按region映射。键为变量类别(如registry/mirror)，值为region到配置命令的映射。
        /// </summary>
        [JsonProperty("environmentVariables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Dictionary<string, string>> EnvironmentVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("execution", NullValueHandling = NullValueHandling.Ignore)]
        public ExtensionExecution Execution { get; set; }

        /// <summary>
        /// 用户可配置参数列表。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtensionParameter> Parameters { get; set; }

        /// <summary>
        /// 内部标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionModuleProperties {\n");
            sb.Append("  buildManifestVersion: ").Append(BuildManifestVersion).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  operationSystem: ").Append(OperationSystem).Append("\n");
            sb.Append("  imageSource: ").Append(ImageSource).Append("\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  icon: ").Append(Icon).Append("\n");
            sb.Append("  environmentVariables: ").Append(EnvironmentVariables).Append("\n");
            sb.Append("  execution: ").Append(Execution).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtensionModuleProperties);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtensionModuleProperties input)
        {
            if (input == null) return false;
            if (this.BuildManifestVersion != input.BuildManifestVersion || (this.BuildManifestVersion != null && !this.BuildManifestVersion.Equals(input.BuildManifestVersion))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Uuid != input.Uuid || (this.Uuid != null && !this.Uuid.Equals(input.Uuid))) return false;
            if (this.OperationSystem != input.OperationSystem || (this.OperationSystem != null && !this.OperationSystem.Equals(input.OperationSystem))) return false;
            if (this.ImageSource != input.ImageSource || (this.ImageSource != null && !this.ImageSource.Equals(input.ImageSource))) return false;
            if (this.Image != input.Image || (this.Image != null && !this.Image.Equals(input.Image))) return false;
            if (this.Icon != input.Icon || (this.Icon != null && !this.Icon.Equals(input.Icon))) return false;
            if (this.EnvironmentVariables != input.EnvironmentVariables || (this.EnvironmentVariables != null && input.EnvironmentVariables != null && !this.EnvironmentVariables.SequenceEqual(input.EnvironmentVariables))) return false;
            if (this.Execution != input.Execution || (this.Execution != null && !this.Execution.Equals(input.Execution))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.BuildManifestVersion != null) hashCode = hashCode * 59 + this.BuildManifestVersion.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Uuid != null) hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.OperationSystem != null) hashCode = hashCode * 59 + this.OperationSystem.GetHashCode();
                if (this.ImageSource != null) hashCode = hashCode * 59 + this.ImageSource.GetHashCode();
                if (this.Image != null) hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Icon != null) hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.EnvironmentVariables != null) hashCode = hashCode * 59 + this.EnvironmentVariables.GetHashCode();
                if (this.Execution != null) hashCode = hashCode * 59 + this.Execution.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
