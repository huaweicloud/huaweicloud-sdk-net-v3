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
    public class DeleteThumbnailsResponse : SdkResponse
    {

        /// <summary>
        /// 删除截图信息的处理结果。
        /// </summary>
        [JsonProperty("delete_result_array", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeleteThumbnailResult> DeleteResultArray { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteThumbnailsResponse {\n");
            sb.Append("  deleteResultArray: ").Append(DeleteResultArray).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteThumbnailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteThumbnailsResponse input)
        {
            if (input == null) return false;
            if (this.DeleteResultArray != input.DeleteResultArray || (this.DeleteResultArray != null && input.DeleteResultArray != null && !this.DeleteResultArray.SequenceEqual(input.DeleteResultArray))) return false;

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
                if (this.DeleteResultArray != null) hashCode = hashCode * 59 + this.DeleteResultArray.GetHashCode();
                return hashCode;
            }
        }
    }
}
