using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CaptureResultUrlVO 
    {

        /// <summary>
        /// 下载链接提取码，用于打开下载链接时使用。
        /// </summary>
        [JsonProperty("captcha", NullValueHandling = NullValueHandling.Ignore)]
        public string Captcha { get; set; }

        /// <summary>
        /// 下载链接过期时间
        /// </summary>
        [JsonProperty("expires", NullValueHandling = NullValueHandling.Ignore)]
        public long? Expires { get; set; }

        /// <summary>
        /// 抓包文件列表，当环境不支持obs文件夹分享时使用。当此字段存在时，无captch，expires，url返回值。
        /// </summary>
        [JsonProperty("file_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<CaptureFile> FileList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("request_header", NullValueHandling = NullValueHandling.Ignore)]
        public HostHeaderInfo RequestHeader { get; set; }

        /// <summary>
        /// 下载链接
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaptureResultUrlVO {\n");
            sb.Append("  captcha: ").Append(Captcha).Append("\n");
            sb.Append("  expires: ").Append(Expires).Append("\n");
            sb.Append("  fileList: ").Append(FileList).Append("\n");
            sb.Append("  requestHeader: ").Append(RequestHeader).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CaptureResultUrlVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CaptureResultUrlVO input)
        {
            if (input == null) return false;
            if (this.Captcha != input.Captcha || (this.Captcha != null && !this.Captcha.Equals(input.Captcha))) return false;
            if (this.Expires != input.Expires || (this.Expires != null && !this.Expires.Equals(input.Expires))) return false;
            if (this.FileList != input.FileList || (this.FileList != null && input.FileList != null && !this.FileList.SequenceEqual(input.FileList))) return false;
            if (this.RequestHeader != input.RequestHeader || (this.RequestHeader != null && !this.RequestHeader.Equals(input.RequestHeader))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;

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
                if (this.Captcha != null) hashCode = hashCode * 59 + this.Captcha.GetHashCode();
                if (this.Expires != null) hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.FileList != null) hashCode = hashCode * 59 + this.FileList.GetHashCode();
                if (this.RequestHeader != null) hashCode = hashCode * 59 + this.RequestHeader.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }
}
