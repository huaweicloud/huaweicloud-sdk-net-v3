using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRestoreTablesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  已恢复库表信息列表。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("data_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestoreTablesInfo> DataList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRestoreTablesResponse {\n");
            sb.Append("  dataList: ").Append(DataList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRestoreTablesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRestoreTablesResponse input)
        {
            if (input == null) return false;
            if (this.DataList != input.DataList || (this.DataList != null && input.DataList != null && !this.DataList.SequenceEqual(input.DataList))) return false;

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
                if (this.DataList != null) hashCode = hashCode * 59 + this.DataList.GetHashCode();
                return hashCode;
            }
        }
    }
}
