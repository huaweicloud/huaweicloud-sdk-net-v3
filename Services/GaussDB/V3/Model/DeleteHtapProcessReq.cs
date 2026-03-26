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
    /// **参数解释**：  删除HTAP实例会话请求体。  **约束限制**：  不涉及。
    /// </summary>
    public class DeleteHtapProcessReq 
    {

        /// <summary>
        /// **参数解释**：  HTAP实例会话ID列表，可通过调用[查询HTAP实例当前会话](https://support.huaweicloud.com/api-taurusdb/ShowHtapProcessList.html)。  **约束限制**：  实例会话ID小于等于20个。  **取值范围**：  不涉及。  **默认值**：  不涉及。
        /// </summary>
        [JsonProperty("process_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProcessList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteHtapProcessReq {\n");
            sb.Append("  processList: ").Append(ProcessList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteHtapProcessReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteHtapProcessReq input)
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
