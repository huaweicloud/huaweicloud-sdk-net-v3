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
    public class OnlineDDLInfoItem 
    {

        /// <summary>
        /// **参数解释**：   无锁变更的目标表。  **取值范围**：  不涉及。  
        /// </summary>
        [JsonProperty("table", NullValueHandling = NullValueHandling.Ignore)]
        public string Table { get; set; }

        /// <summary>
        /// **参数解释**：  无锁变更的具体执行SQL。  **取值范围**：   不涉及。
        /// </summary>
        [JsonProperty("sql", NullValueHandling = NullValueHandling.Ignore)]
        public string Sql { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnlineDDLInfoItem {\n");
            sb.Append("  table: ").Append(Table).Append("\n");
            sb.Append("  sql: ").Append(Sql).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OnlineDDLInfoItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OnlineDDLInfoItem input)
        {
            if (input == null) return false;
            if (this.Table != input.Table || (this.Table != null && !this.Table.Equals(input.Table))) return false;
            if (this.Sql != input.Sql || (this.Sql != null && !this.Sql.Equals(input.Sql))) return false;

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
                if (this.Sql != null) hashCode = hashCode * 59 + this.Sql.GetHashCode();
                return hashCode;
            }
        }
    }
}
