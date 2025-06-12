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
    /// Response Object
    /// </summary>
    public class CreateFileResponse : SdkResponse
    {

        /// <summary>
        /// 文件ID。
        /// </summary>
        [JsonProperty("file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        /// <summary>
        /// 文件上传地址，有效期为24小时。 &gt; * [调用OBS的[“PUT上传”](https://support.huaweicloud.com/api-obs/obs_04_0080.html)接口上传文件。](tag:hc) &gt; * [调用OBS的[“PUT上传”](https://support.huaweicloud.com/intl/zh-cn/api-obs/obs_04_0080.html)接口上传文件。](tag:hk) &gt; * [调用OBS的“PUT上传”接口上传文件。](tag:cmcc) &gt; * 调用上述接口时，Content-MD5头必须填写，填写的值跟file_md5中的值相同，md5值获取详情请参考[使用Java代码生成文件内容的MD5值](metastudio_02_0052.xml)。 &gt; * 调用上述接口时，Content-Type头必须填写，填写的值根据不同的文件类型有所不同。     文件类型为gif，Content-Type填写image/gif     文件类型为jpeg、jpg，Content-Type填写image/jpeg     文件类型为png，Content-Type填写image/png     文件类型为mp4，Content-Type填写video/mp4     文件类型为mp3，Content-Type填写audio/mp3     文件类型为wav，Content-Type填写audio/wav     其余所有类型，Content-Type填写application/octet-stream
        /// </summary>
        [JsonProperty("upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string UploadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFileResponse {\n");
            sb.Append("  fileId: ").Append(FileId).Append("\n");
            sb.Append("  uploadUrl: ").Append(UploadUrl).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFileResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFileResponse input)
        {
            if (input == null) return false;
            if (this.FileId != input.FileId || (this.FileId != null && !this.FileId.Equals(input.FileId))) return false;
            if (this.UploadUrl != input.UploadUrl || (this.UploadUrl != null && !this.UploadUrl.Equals(input.UploadUrl))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.FileId != null) hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.UploadUrl != null) hashCode = hashCode * 59 + this.UploadUrl.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
