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
    public class CaptureFile 
    {

        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 下载链接
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaptureFile {\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CaptureFile);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CaptureFile input)
        {
            if (input == null) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                return hashCode;
            }
        }
    }
}
