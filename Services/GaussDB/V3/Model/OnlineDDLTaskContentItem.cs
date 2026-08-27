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
    public class OnlineDDLTaskContentItem 
    {

        /// <summary>
        /// **参数解释**：  无锁变更的目标数据库。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public string Schema { get; set; }

        /// <summary>
        /// **参数解释**：  无锁变更的DDL信息。
        /// </summary>
        [JsonProperty("ddl_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<OnlineDDLInfoItem> DdlInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnlineDDLTaskContentItem {\n");
            sb.Append("  schema: ").Append(Schema).Append("\n");
            sb.Append("  ddlInfo: ").Append(DdlInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OnlineDDLTaskContentItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OnlineDDLTaskContentItem input)
        {
            if (input == null) return false;
            if (this.Schema != input.Schema || (this.Schema != null && !this.Schema.Equals(input.Schema))) return false;
            if (this.DdlInfo != input.DdlInfo || (this.DdlInfo != null && input.DdlInfo != null && !this.DdlInfo.SequenceEqual(input.DdlInfo))) return false;

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
                if (this.Schema != null) hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.DdlInfo != null) hashCode = hashCode * 59 + this.DdlInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
