using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Bucket 
    {

        /// <summary>
        /// 标识OBS桶名称。由数字或字母开头，支持小写字母、数字、“-”、“.”，长度为3～63个字符。
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// 标识桶位置。
        /// </summary>
        [JsonProperty("bucket_location", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketLocation { get; set; }

        /// <summary>
        /// 事件文件转储加密所采用的秘钥id。 如果is_support_trace_files_encryption\&quot;参数值为“是”时，此参数为必选项。
        /// </summary>
        [JsonProperty("kms_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsId { get; set; }

        /// <summary>
        /// 事件文件转储加密功能开关。 该参数必须与kms_id参数同时使用。
        /// </summary>
        [JsonProperty("is_support_trace_files_encryption", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportTraceFilesEncryption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("check_bucket_response", NullValueHandling = NullValueHandling.Ignore)]
        public CheckBucketResponse CheckBucketResponse { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bucket {\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  bucketLocation: ").Append(BucketLocation).Append("\n");
            sb.Append("  kmsId: ").Append(KmsId).Append("\n");
            sb.Append("  isSupportTraceFilesEncryption: ").Append(IsSupportTraceFilesEncryption).Append("\n");
            sb.Append("  checkBucketResponse: ").Append(CheckBucketResponse).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Bucket);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Bucket input)
        {
            if (input == null) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;
            if (this.BucketLocation != input.BucketLocation || (this.BucketLocation != null && !this.BucketLocation.Equals(input.BucketLocation))) return false;
            if (this.KmsId != input.KmsId || (this.KmsId != null && !this.KmsId.Equals(input.KmsId))) return false;
            if (this.IsSupportTraceFilesEncryption != input.IsSupportTraceFilesEncryption || (this.IsSupportTraceFilesEncryption != null && !this.IsSupportTraceFilesEncryption.Equals(input.IsSupportTraceFilesEncryption))) return false;
            if (this.CheckBucketResponse != input.CheckBucketResponse || (this.CheckBucketResponse != null && !this.CheckBucketResponse.Equals(input.CheckBucketResponse))) return false;

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
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.BucketLocation != null) hashCode = hashCode * 59 + this.BucketLocation.GetHashCode();
                if (this.KmsId != null) hashCode = hashCode * 59 + this.KmsId.GetHashCode();
                if (this.IsSupportTraceFilesEncryption != null) hashCode = hashCode * 59 + this.IsSupportTraceFilesEncryption.GetHashCode();
                if (this.CheckBucketResponse != null) hashCode = hashCode * 59 + this.CheckBucketResponse.GetHashCode();
                return hashCode;
            }
        }
    }
}
