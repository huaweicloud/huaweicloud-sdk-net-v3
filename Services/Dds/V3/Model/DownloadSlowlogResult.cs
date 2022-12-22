using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DownloadSlowlogResult 
    {

        /// <summary>
        /// 节点名称。
        /// </summary>
        [JsonProperty("node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }

        /// <summary>
        /// 生成的下载文件名。
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 当前链接的生成状态。 - SUCCESS，表示下载链接已经生成完成。 - EXPORTING，表示正在生成文件，准备下载链接。 - FAILED，表示存在日志文件准备失败。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 文件大小，单位为 KB。
        /// </summary>
        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public string FileSize { get; set; }

        /// <summary>
        /// 下载链接。注意：下载链接在更新时间的 15分钟内有效，超出时间会重新获取。
        /// </summary>
        [JsonProperty("file_link", NullValueHandling = NullValueHandling.Ignore)]
        public string FileLink { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateAt { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadSlowlogResult {\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("  fileLink: ").Append(FileLink).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadSlowlogResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadSlowlogResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeName == input.NodeName ||
                    (this.NodeName != null &&
                    this.NodeName.Equals(input.NodeName))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    (this.FileSize != null &&
                    this.FileSize.Equals(input.FileSize))
                ) && 
                (
                    this.FileLink == input.FileLink ||
                    (this.FileLink != null &&
                    this.FileLink.Equals(input.FileLink))
                ) && 
                (
                    this.UpdateAt == input.UpdateAt ||
                    (this.UpdateAt != null &&
                    this.UpdateAt.Equals(input.UpdateAt))
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
                if (this.NodeName != null)
                    hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.FileSize != null)
                    hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.FileLink != null)
                    hashCode = hashCode * 59 + this.FileLink.GetHashCode();
                if (this.UpdateAt != null)
                    hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
