using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 创建大文件请求。
    /// </summary>
    public class LargeFilesCreateReq 
    {

        /// <summary>
        /// 文件名，不区分大小写，最大长度256，最小长度1。
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 文件总的大小，最小1，最大536870912000。
        /// </summary>
        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileSize { get; set; }

        /// <summary>
        /// 文件类型（默认提取文件后缀）。
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 资产ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 文件在资产中的分类。每种资产类型包含的文件分类不同。 * MAIN：主文件 * OTHER：其他文件 * PACKAGE：打包后的资产文件
        /// </summary>
        [JsonProperty("asset_file_category", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetFileCategory { get; set; }

        /// <summary>
        /// ORI4K文件分段上传数量，默认值为1
        /// </summary>
        [JsonProperty("file_multipart_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FileMultipartCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LargeFilesCreateReq {\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  assetFileCategory: ").Append(AssetFileCategory).Append("\n");
            sb.Append("  fileMultipartCount: ").Append(FileMultipartCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LargeFilesCreateReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LargeFilesCreateReq input)
        {
            if (input == null) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.FileSize != input.FileSize || (this.FileSize != null && !this.FileSize.Equals(input.FileSize))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.AssetFileCategory != input.AssetFileCategory || (this.AssetFileCategory != null && !this.AssetFileCategory.Equals(input.AssetFileCategory))) return false;
            if (this.FileMultipartCount != input.FileMultipartCount || (this.FileMultipartCount != null && !this.FileMultipartCount.Equals(input.FileMultipartCount))) return false;

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
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FileSize != null) hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.AssetFileCategory != null) hashCode = hashCode * 59 + this.AssetFileCategory.GetHashCode();
                if (this.FileMultipartCount != null) hashCode = hashCode * 59 + this.FileMultipartCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
