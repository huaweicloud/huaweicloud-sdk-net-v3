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
    public class UpdateCoverByThumbnailReq 
    {

        /// <summary>
        /// 截图文件的URL。  需要根据媒资ID调用[查询媒资详细信息](https://support.huaweicloud.com/api-vod/vod_04_0202.html)接口获取媒资的截图文件URL。
        /// </summary>
        [JsonProperty("thumbnailUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailUrl { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCoverByThumbnailReq {\n");
            sb.Append("  thumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCoverByThumbnailReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCoverByThumbnailReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ThumbnailUrl == input.ThumbnailUrl ||
                    (this.ThumbnailUrl != null &&
                    this.ThumbnailUrl.Equals(input.ThumbnailUrl))
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
                if (this.ThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.ThumbnailUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
