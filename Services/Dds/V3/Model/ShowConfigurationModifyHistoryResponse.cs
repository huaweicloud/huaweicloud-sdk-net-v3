using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowConfigurationModifyHistoryResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 参数模板的修改历史列表。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("histories", NullValueHandling = NullValueHandling.Ignore)]
        public List<HistoryInfo> Histories { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowConfigurationModifyHistoryResponse {\n");
            sb.Append("  histories: ").Append(Histories).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowConfigurationModifyHistoryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConfigurationModifyHistoryResponse input)
        {
            if (input == null) return false;
            if (this.Histories != input.Histories || (this.Histories != null && input.Histories != null && !this.Histories.SequenceEqual(input.Histories))) return false;

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
                if (this.Histories != null) hashCode = hashCode * 59 + this.Histories.GetHashCode();
                return hashCode;
            }
        }
    }
}
