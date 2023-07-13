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
    /// 封面信息。
    /// </summary>
    public class CoverInfo 
    {

        /// <summary>
        /// 封面文件的下载地址。
        /// </summary>
        [JsonProperty("cover_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoverInfo {\n");
            sb.Append("  coverUrl: ").Append(CoverUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CoverInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CoverInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CoverUrl == input.CoverUrl ||
                    (this.CoverUrl != null &&
                    this.CoverUrl.Equals(input.CoverUrl))
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
                if (this.CoverUrl != null)
                    hashCode = hashCode * 59 + this.CoverUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
