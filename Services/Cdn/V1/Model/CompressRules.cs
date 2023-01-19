using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CompressRules 
    {

        /// <summary>
        /// GZIP压缩类型（目前只支持 gzip）
        /// </summary>
        [JsonProperty("compress_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CompressType { get; set; }

        /// <summary>
        /// GZIP压缩文件类型（文件后缀竖线分割，如：.js|.html|.css|.xml）
        /// </summary>
        [JsonProperty("compress_file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CompressFileType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompressRules {\n");
            sb.Append("  compressType: ").Append(CompressType).Append("\n");
            sb.Append("  compressFileType: ").Append(CompressFileType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompressRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompressRules input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompressType == input.CompressType ||
                    (this.CompressType != null &&
                    this.CompressType.Equals(input.CompressType))
                ) && 
                (
                    this.CompressFileType == input.CompressFileType ||
                    (this.CompressFileType != null &&
                    this.CompressFileType.Equals(input.CompressFileType))
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
                if (this.CompressType != null)
                    hashCode = hashCode * 59 + this.CompressType.GetHashCode();
                if (this.CompressFileType != null)
                    hashCode = hashCode * 59 + this.CompressFileType.GetHashCode();
                return hashCode;
            }
        }
    }
}
