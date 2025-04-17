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
    public class ShowRefreshResultResponse : SdkResponse
    {

        /// <summary>
        /// 刷新任务结果
        /// </summary>
        [JsonProperty("refresh_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<RefreshResult> RefreshResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRefreshResultResponse {\n");
            sb.Append("  refreshResults: ").Append(RefreshResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRefreshResultResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRefreshResultResponse input)
        {
            if (input == null) return false;
            if (this.RefreshResults != input.RefreshResults || (this.RefreshResults != null && input.RefreshResults != null && !this.RefreshResults.SequenceEqual(input.RefreshResults))) return false;

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
                if (this.RefreshResults != null) hashCode = hashCode * 59 + this.RefreshResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
