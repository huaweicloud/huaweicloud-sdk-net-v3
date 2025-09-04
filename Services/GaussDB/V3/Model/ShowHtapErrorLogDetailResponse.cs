using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowHtapErrorLogDetailResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 错误日志列表。  **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("error_log_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<HtapErrorLogDetailResponseErrorLogList> ErrorLogList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowHtapErrorLogDetailResponse {\n");
            sb.Append("  errorLogList: ").Append(ErrorLogList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowHtapErrorLogDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowHtapErrorLogDetailResponse input)
        {
            if (input == null) return false;
            if (this.ErrorLogList != input.ErrorLogList || (this.ErrorLogList != null && input.ErrorLogList != null && !this.ErrorLogList.SequenceEqual(input.ErrorLogList))) return false;

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
                if (this.ErrorLogList != null) hashCode = hashCode * 59 + this.ErrorLogList.GetHashCode();
                return hashCode;
            }
        }
    }
}
