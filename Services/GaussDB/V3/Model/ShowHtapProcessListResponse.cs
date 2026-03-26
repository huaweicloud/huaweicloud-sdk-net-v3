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
    public class ShowHtapProcessListResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  HTAP标准版查询的会话信息。  **默认值**：  不涉及。
        /// </summary>
        [JsonProperty("process_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<HtapProcessInfo> ProcessList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowHtapProcessListResponse {\n");
            sb.Append("  processList: ").Append(ProcessList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowHtapProcessListResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowHtapProcessListResponse input)
        {
            if (input == null) return false;
            if (this.ProcessList != input.ProcessList || (this.ProcessList != null && input.ProcessList != null && !this.ProcessList.SequenceEqual(input.ProcessList))) return false;

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
                if (this.ProcessList != null) hashCode = hashCode * 59 + this.ProcessList.GetHashCode();
                return hashCode;
            }
        }
    }
}
