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
    /// 训练视频已上传分片信息
    /// </summary>
    public class MultipartUploadInfo 
    {

        /// <summary>
        /// 分片编号
        /// </summary>
        [JsonProperty("part_number", NullValueHandling = NullValueHandling.Ignore)]
        public string PartNumber { get; set; }

        /// <summary>
        /// 分片文件标识
        /// </summary>
        [JsonProperty("etag", NullValueHandling = NullValueHandling.Ignore)]
        public string Etag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultipartUploadInfo {\n");
            sb.Append("  partNumber: ").Append(PartNumber).Append("\n");
            sb.Append("  etag: ").Append(Etag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MultipartUploadInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MultipartUploadInfo input)
        {
            if (input == null) return false;
            if (this.PartNumber != input.PartNumber || (this.PartNumber != null && !this.PartNumber.Equals(input.PartNumber))) return false;
            if (this.Etag != input.Etag || (this.Etag != null && !this.Etag.Equals(input.Etag))) return false;

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
                if (this.PartNumber != null) hashCode = hashCode * 59 + this.PartNumber.GetHashCode();
                if (this.Etag != null) hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }
}
