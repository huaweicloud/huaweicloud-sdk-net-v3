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
    /// 发布应用的结构体。
    /// </summary>
    public class PublishApp 
    {

        /// <summary>
        /// 应用名称,名称需满足如下规则: 1. 名称允许可见字符或空格，不可为全空格。 2. 不允许包含如下字符:^;|~&#x60;{}[]&lt;&gt;。 3. 长度1~64个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 应用版本号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 启动命令行参数。
        /// </summary>
        [JsonProperty("command_param", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandParam { get; set; }

        /// <summary>
        /// 图标地址，该字段当前未使用。 &gt; - 图片的默认大小当前限制为8KB，即1024 * 8字节。 &gt; - 如果数据格式为data;image/png;base64,iVBORw0KGgoAAAANS时实际大小约为字段约为：size * 4/3 + 4bytes。
        /// </summary>
        [JsonProperty("icon_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string IconUri { get; set; }

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
        /// 应用图标的路径。
        /// </summary>
        [JsonProperty("icon_path", NullValueHandling = NullValueHandling.Ignore)]
        public string IconPath { get; set; }

        /// <summary>
        /// 应用图标的索引。
        /// </summary>
        [JsonProperty("icon_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? IconIndex { get; set; }

        /// <summary>
        /// 应用描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 应用类型： - &#39;1&#39;:系统保留不可用。 - &#39;2&#39;:镜像应用。 - &#39;3&#39;:自定义应用。
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceType { get; set; }

        /// <summary>
        /// 应用发布者。
        /// </summary>
        [JsonProperty("publisher", NullValueHandling = NullValueHandling.Ignore)]
        public string Publisher { get; set; }

        /// <summary>
        /// 镜像ids,最多20个。
        /// </summary>
        [JsonProperty("source_image_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SourceImageIds { get; set; }

        /// <summary>
        /// 是否使用沙箱模式运行，取值为： - false: 表示不以沙箱模式运行。 - true: 表示以沙箱模式运行。
        /// </summary>
        [JsonProperty("sandbox_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SandboxEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublishApp {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  commandParam: ").Append(CommandParam).Append("\n");
            sb.Append("  iconUri: ").Append(IconUri).Append("\n");
            sb.Append("  executePath: ").Append(ExecutePath).Append("\n");
            sb.Append("  workPath: ").Append(WorkPath).Append("\n");
            sb.Append("  iconPath: ").Append(IconPath).Append("\n");
            sb.Append("  iconIndex: ").Append(IconIndex).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  publisher: ").Append(Publisher).Append("\n");
            sb.Append("  sourceImageIds: ").Append(SourceImageIds).Append("\n");
            sb.Append("  sandboxEnable: ").Append(SandboxEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublishApp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublishApp input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.CommandParam != input.CommandParam || (this.CommandParam != null && !this.CommandParam.Equals(input.CommandParam))) return false;
            if (this.IconUri != input.IconUri || (this.IconUri != null && !this.IconUri.Equals(input.IconUri))) return false;
            if (this.ExecutePath != input.ExecutePath || (this.ExecutePath != null && !this.ExecutePath.Equals(input.ExecutePath))) return false;
            if (this.WorkPath != input.WorkPath || (this.WorkPath != null && !this.WorkPath.Equals(input.WorkPath))) return false;
            if (this.IconPath != input.IconPath || (this.IconPath != null && !this.IconPath.Equals(input.IconPath))) return false;
            if (this.IconIndex != input.IconIndex || (this.IconIndex != null && !this.IconIndex.Equals(input.IconIndex))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.SourceType != input.SourceType || (this.SourceType != null && !this.SourceType.Equals(input.SourceType))) return false;
            if (this.Publisher != input.Publisher || (this.Publisher != null && !this.Publisher.Equals(input.Publisher))) return false;
            if (this.SourceImageIds != input.SourceImageIds || (this.SourceImageIds != null && input.SourceImageIds != null && !this.SourceImageIds.SequenceEqual(input.SourceImageIds))) return false;
            if (this.SandboxEnable != input.SandboxEnable || (this.SandboxEnable != null && !this.SandboxEnable.Equals(input.SandboxEnable))) return false;

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
                if (this.CommandParam != null) hashCode = hashCode * 59 + this.CommandParam.GetHashCode();
                if (this.IconUri != null) hashCode = hashCode * 59 + this.IconUri.GetHashCode();
                if (this.ExecutePath != null) hashCode = hashCode * 59 + this.ExecutePath.GetHashCode();
                if (this.WorkPath != null) hashCode = hashCode * 59 + this.WorkPath.GetHashCode();
                if (this.IconPath != null) hashCode = hashCode * 59 + this.IconPath.GetHashCode();
                if (this.IconIndex != null) hashCode = hashCode * 59 + this.IconIndex.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SourceType != null) hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.Publisher != null) hashCode = hashCode * 59 + this.Publisher.GetHashCode();
                if (this.SourceImageIds != null) hashCode = hashCode * 59 + this.SourceImageIds.GetHashCode();
                if (this.SandboxEnable != null) hashCode = hashCode * 59 + this.SandboxEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
