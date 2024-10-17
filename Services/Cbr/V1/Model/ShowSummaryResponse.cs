using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSummaryResponse : SdkResponse
    {

        /// <summary>
        /// 总容量大小
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 总使用量
        /// </summary>
        [JsonProperty("used_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSummaryResponse {\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  usedSize: ").Append(UsedSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSummaryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSummaryResponse input)
        {
            if (input == null) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.UsedSize != input.UsedSize || (this.UsedSize != null && !this.UsedSize.Equals(input.UsedSize))) return false;

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
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.UsedSize != null) hashCode = hashCode * 59 + this.UsedSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
