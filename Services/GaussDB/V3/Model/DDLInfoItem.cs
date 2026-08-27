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
    /// 
    /// </summary>
    public class DDLInfoItem 
    {

        /// <summary>
        /// **参数解释**：   无锁变更产生的临时表，获取方法参见[查询无锁变更任务记录列表](https://support.huaweicloud.com/api-taurusdb/ListOnlineDdlTaskRecords.html)的响应参数temp_table_name。   **约束限制**：  不涉及。   **取值范围**：   不涉及。   **默认取值**：   不涉及。
        /// </summary>
        [JsonProperty("table", NullValueHandling = NullValueHandling.Ignore)]
        public string Table { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DDLInfoItem {\n");
            sb.Append("  table: ").Append(Table).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DDLInfoItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DDLInfoItem input)
        {
            if (input == null) return false;
            if (this.Table != input.Table || (this.Table != null && !this.Table.Equals(input.Table))) return false;

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
                if (this.Table != null) hashCode = hashCode * 59 + this.Table.GetHashCode();
                return hashCode;
            }
        }
    }
}
