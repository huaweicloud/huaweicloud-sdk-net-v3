using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UploadBatchTaskFileResponse : SdkResponse
    {

        /// <summary>
        /// 上传的批量任务文件ID，由平台自动生成。
        /// </summary>
        [JsonProperty("file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        /// <summary>
        /// 上传的批量任务文件名称。
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 在物联网平台上传文件的时间。格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如20151212T121212Z。
        /// </summary>
        [JsonProperty("upload_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UploadTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadBatchTaskFileResponse {\n");
            sb.Append("  fileId: ").Append(FileId).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  uploadTime: ").Append(UploadTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadBatchTaskFileResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadBatchTaskFileResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.UploadTime == input.UploadTime ||
                    (this.UploadTime != null &&
                    this.UploadTime.Equals(input.UploadTime))
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
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.UploadTime != null)
                    hashCode = hashCode * 59 + this.UploadTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
