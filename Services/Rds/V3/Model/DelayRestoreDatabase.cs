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
    /// 
    /// </summary>
    public class DelayRestoreDatabase 
    {

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 返回该库下的总表数量
        /// </summary>
        [JsonProperty("total_tables", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalTables { get; set; }

        /// <summary>
        /// 该库下的schema列表
        /// </summary>
        [JsonProperty("schemas", NullValueHandling = NullValueHandling.Ignore)]
        public List<DelayRestoreSchema> Schemas { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DelayRestoreDatabase {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  totalTables: ").Append(TotalTables).Append("\n");
            sb.Append("  schemas: ").Append(Schemas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DelayRestoreDatabase);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DelayRestoreDatabase input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.TotalTables != input.TotalTables || (this.TotalTables != null && !this.TotalTables.Equals(input.TotalTables))) return false;
            if (this.Schemas != input.Schemas || (this.Schemas != null && input.Schemas != null && !this.Schemas.SequenceEqual(input.Schemas))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TotalTables != null) hashCode = hashCode * 59 + this.TotalTables.GetHashCode();
                if (this.Schemas != null) hashCode = hashCode * 59 + this.Schemas.GetHashCode();
                return hashCode;
            }
        }
    }
}
