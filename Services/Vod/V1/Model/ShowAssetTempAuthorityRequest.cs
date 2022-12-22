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
    /// Request Object
    /// </summary>
    public class ShowAssetTempAuthorityRequest 
    {

        /// <summary>
        /// 使用AK/SK方式认证时必选，携带的鉴权信息。 
        /// </summary>
        [SDKProperty("Authorization", IsHeader = true)]
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。 
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 分段上传时调用OBS接口的HTTP方法，具体操作需要的HTTP方法请参考OBS的接口文档。  - 初始化上传任务：POST - 上传段：PUT - 合并段：POST - 取消段：DELETE - 列举已上传段：GET
        /// </summary>
        [SDKProperty("http_verb", IsQuery = true)]
        [JsonProperty("http_verb", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpVerb { get; set; }

        /// <summary>
        /// 桶名。  调用[创建媒资：上传方式](https://support.huaweicloud.com/api-vod/vod_04_0196.html)接口中返回的响应体中的target字段获得的bucket值。
        /// </summary>
        [SDKProperty("bucket", IsQuery = true)]
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string Bucket { get; set; }

        /// <summary>
        /// 对象名。  调用[创建媒资：上传方式](https://support.huaweicloud.com/api-vod/vod_04_0196.html)接口中返回的响应体中的target字段获得的object值。
        /// </summary>
        [SDKProperty("object_key", IsQuery = true)]
        [JsonProperty("object_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// 文件类型对应的content-type，如MP4对应video/mp4。
        /// </summary>
        [SDKProperty("content_type", IsQuery = true)]
        [JsonProperty("content_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        /// <summary>
        /// 上传段时每段的MD5。
        /// </summary>
        [SDKProperty("content_md5", IsQuery = true)]
        [JsonProperty("content_md5", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentMd5 { get; set; }

        /// <summary>
        /// 每一个上传任务的id，是OBS进行初始段后OBS返回的。
        /// </summary>
        [SDKProperty("upload_id", IsQuery = true)]
        [JsonProperty("upload_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UploadId { get; set; }

        /// <summary>
        /// 上传段时每一段的id。  取值范围：[1,10000]。
        /// </summary>
        [SDKProperty("part_number", IsQuery = true)]
        [JsonProperty("part_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? PartNumber { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAssetTempAuthorityRequest {\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  httpVerb: ").Append(HttpVerb).Append("\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  objectKey: ").Append(ObjectKey).Append("\n");
            sb.Append("  contentType: ").Append(ContentType).Append("\n");
            sb.Append("  contentMd5: ").Append(ContentMd5).Append("\n");
            sb.Append("  uploadId: ").Append(UploadId).Append("\n");
            sb.Append("  partNumber: ").Append(PartNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssetTempAuthorityRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssetTempAuthorityRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authorization == input.Authorization ||
                    (this.Authorization != null &&
                    this.Authorization.Equals(input.Authorization))
                ) && 
                (
                    this.XSdkDate == input.XSdkDate ||
                    (this.XSdkDate != null &&
                    this.XSdkDate.Equals(input.XSdkDate))
                ) && 
                (
                    this.HttpVerb == input.HttpVerb ||
                    (this.HttpVerb != null &&
                    this.HttpVerb.Equals(input.HttpVerb))
                ) && 
                (
                    this.Bucket == input.Bucket ||
                    (this.Bucket != null &&
                    this.Bucket.Equals(input.Bucket))
                ) && 
                (
                    this.ObjectKey == input.ObjectKey ||
                    (this.ObjectKey != null &&
                    this.ObjectKey.Equals(input.ObjectKey))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.ContentMd5 == input.ContentMd5 ||
                    (this.ContentMd5 != null &&
                    this.ContentMd5.Equals(input.ContentMd5))
                ) && 
                (
                    this.UploadId == input.UploadId ||
                    (this.UploadId != null &&
                    this.UploadId.Equals(input.UploadId))
                ) && 
                (
                    this.PartNumber == input.PartNumber ||
                    (this.PartNumber != null &&
                    this.PartNumber.Equals(input.PartNumber))
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
                if (this.Authorization != null)
                    hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.XSdkDate != null)
                    hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.HttpVerb != null)
                    hashCode = hashCode * 59 + this.HttpVerb.GetHashCode();
                if (this.Bucket != null)
                    hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.ObjectKey != null)
                    hashCode = hashCode * 59 + this.ObjectKey.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.ContentMd5 != null)
                    hashCode = hashCode * 59 + this.ContentMd5.GetHashCode();
                if (this.UploadId != null)
                    hashCode = hashCode * 59 + this.UploadId.GetHashCode();
                if (this.PartNumber != null)
                    hashCode = hashCode * 59 + this.PartNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
