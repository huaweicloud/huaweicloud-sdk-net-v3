using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AomMappingfilesInfo 
    {

        /// <summary>
        /// 路径名
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_stream_info", NullValueHandling = NullValueHandling.Ignore)]
        public AomMappingLogStreamInfo LogStreamInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AomMappingfilesInfo {\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  logStreamInfo: ").Append(LogStreamInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AomMappingfilesInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AomMappingfilesInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.LogStreamInfo == input.LogStreamInfo ||
                    (this.LogStreamInfo != null &&
                    this.LogStreamInfo.Equals(input.LogStreamInfo))
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
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.LogStreamInfo != null)
                    hashCode = hashCode * 59 + this.LogStreamInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
