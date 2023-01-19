using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateTakeOverTaskReq 
    {

        /// <summary>
        /// 源桶名。
        /// </summary>
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string Bucket { get; set; }

        /// <summary>
        /// 源目录名或源文件名。
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public string Object { get; set; }

        /// <summary>
        /// 批量托管时的文件后缀名列表。不传或传空值时，表示托管所有音视频文件，不进行后缀名过滤。
        /// </summary>
        [JsonProperty("suffix", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Suffix { get; set; }

        /// <summary>
        /// 转码模板组名称。  若不为空，则使用指定的转码模板对上传的音视频进行转码，您可以在视频点播控制台配置转码模板，具体请参见转码设置。  &gt; 若同时设置了“**template_group_name**”和“**workflow_name**”字段，则“**template_group_name**”字段生效。
        /// </summary>
        [JsonProperty("template_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateGroupName { get; set; }

        /// <summary>
        /// 工作流名称。  若不为空，则使用指定的工作流对上传的音视频进行处理，您可以在视频点播控制台配置工作流，具体请参见[工作流设置](https://support.huaweicloud.com/usermanual-vod/vod010041.html)。
        /// </summary>
        [JsonProperty("workflow_name", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// 表示音视频处理后生成的媒资文件所存储的位置类型。  取值如下所示： - 0：表示存储到点播桶。 - 1：表示存储在租户桶。 - 2：表示存储到租户桶，并且存储路径与源文件一致。
        /// </summary>
        [JsonProperty("host_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? HostType { get; set; }

        /// <summary>
        /// 输出桶名，host_type为1时必选
        /// </summary>
        [JsonProperty("output_bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputBucket { get; set; }

        /// <summary>
        /// 输出路径名，host_type为1时必选
        /// </summary>
        [JsonProperty("output_path", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputPath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTakeOverTaskReq {\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  suffix: ").Append(Suffix).Append("\n");
            sb.Append("  templateGroupName: ").Append(TemplateGroupName).Append("\n");
            sb.Append("  workflowName: ").Append(WorkflowName).Append("\n");
            sb.Append("  hostType: ").Append(HostType).Append("\n");
            sb.Append("  outputBucket: ").Append(OutputBucket).Append("\n");
            sb.Append("  outputPath: ").Append(OutputPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTakeOverTaskReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTakeOverTaskReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bucket == input.Bucket ||
                    (this.Bucket != null &&
                    this.Bucket.Equals(input.Bucket))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    this.Suffix != null &&
                    input.Suffix != null &&
                    this.Suffix.SequenceEqual(input.Suffix)
                ) && 
                (
                    this.TemplateGroupName == input.TemplateGroupName ||
                    (this.TemplateGroupName != null &&
                    this.TemplateGroupName.Equals(input.TemplateGroupName))
                ) && 
                (
                    this.WorkflowName == input.WorkflowName ||
                    (this.WorkflowName != null &&
                    this.WorkflowName.Equals(input.WorkflowName))
                ) && 
                (
                    this.HostType == input.HostType ||
                    (this.HostType != null &&
                    this.HostType.Equals(input.HostType))
                ) && 
                (
                    this.OutputBucket == input.OutputBucket ||
                    (this.OutputBucket != null &&
                    this.OutputBucket.Equals(input.OutputBucket))
                ) && 
                (
                    this.OutputPath == input.OutputPath ||
                    (this.OutputPath != null &&
                    this.OutputPath.Equals(input.OutputPath))
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
                if (this.Bucket != null)
                    hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                if (this.TemplateGroupName != null)
                    hashCode = hashCode * 59 + this.TemplateGroupName.GetHashCode();
                if (this.WorkflowName != null)
                    hashCode = hashCode * 59 + this.WorkflowName.GetHashCode();
                if (this.HostType != null)
                    hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.OutputBucket != null)
                    hashCode = hashCode * 59 + this.OutputBucket.GetHashCode();
                if (this.OutputPath != null)
                    hashCode = hashCode * 59 + this.OutputPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
