using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReadWriteRatioList 
    {

        /// <summary>
        /// 逻辑库名称。
        /// </summary>
        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public string Schema { get; set; }

        /// <summary>
        /// 逻辑表名称。
        /// </summary>
        [JsonProperty("table", NullValueHandling = NullValueHandling.Ignore)]
        public string Table { get; set; }

        /// <summary>
        /// 读次数。
        /// </summary>
        [JsonProperty("readCount", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadCount { get; set; }

        /// <summary>
        /// 写次数。
        /// </summary>
        [JsonProperty("writeCount", NullValueHandling = NullValueHandling.Ignore)]
        public string WriteCount { get; set; }

        /// <summary>
        /// 关联表。
        /// </summary>
        [JsonProperty("relationTables", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationTables { get; set; }

        /// <summary>
        /// 最后执行时间。
        /// </summary>
        [JsonProperty("lastUpdated", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdated { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReadWriteRatioList {\n");
            sb.Append("  schema: ").Append(Schema).Append("\n");
            sb.Append("  table: ").Append(Table).Append("\n");
            sb.Append("  readCount: ").Append(ReadCount).Append("\n");
            sb.Append("  writeCount: ").Append(WriteCount).Append("\n");
            sb.Append("  relationTables: ").Append(RelationTables).Append("\n");
            sb.Append("  lastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReadWriteRatioList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReadWriteRatioList input)
        {
            if (input == null) return false;
            if (this.Schema != input.Schema || (this.Schema != null && !this.Schema.Equals(input.Schema))) return false;
            if (this.Table != input.Table || (this.Table != null && !this.Table.Equals(input.Table))) return false;
            if (this.ReadCount != input.ReadCount || (this.ReadCount != null && !this.ReadCount.Equals(input.ReadCount))) return false;
            if (this.WriteCount != input.WriteCount || (this.WriteCount != null && !this.WriteCount.Equals(input.WriteCount))) return false;
            if (this.RelationTables != input.RelationTables || (this.RelationTables != null && !this.RelationTables.Equals(input.RelationTables))) return false;
            if (this.LastUpdated != input.LastUpdated || (this.LastUpdated != null && !this.LastUpdated.Equals(input.LastUpdated))) return false;

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
                if (this.Table != null) hashCode = hashCode * 59 + this.Table.GetHashCode();
                if (this.ReadCount != null) hashCode = hashCode * 59 + this.ReadCount.GetHashCode();
                if (this.WriteCount != null) hashCode = hashCode * 59 + this.WriteCount.GetHashCode();
                if (this.RelationTables != null) hashCode = hashCode * 59 + this.RelationTables.GetHashCode();
                if (this.LastUpdated != null) hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                return hashCode;
            }
        }
    }
}
