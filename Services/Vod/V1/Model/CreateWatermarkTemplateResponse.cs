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
    /// Response Object
    /// </summary>
    public class CreateWatermarkTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 水印配置模板id&lt;br/&gt; 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 水印图片上传地址&lt;br/&gt; 
        /// </summary>
        [JsonProperty("upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string UploadUrl { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWatermarkTemplateResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  uploadUrl: ").Append(UploadUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateWatermarkTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateWatermarkTemplateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UploadUrl == input.UploadUrl ||
                    (this.UploadUrl != null &&
                    this.UploadUrl.Equals(input.UploadUrl))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UploadUrl != null)
                    hashCode = hashCode * 59 + this.UploadUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
