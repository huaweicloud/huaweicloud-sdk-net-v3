using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 列映射信息
    /// </summary>
    public class ColumnMappingInfo 
    {

        /// <summary>
        /// 对象id
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 列信息
        /// </summary>
        [JsonProperty("column_info_lists", NullValueHandling = NullValueHandling.Ignore)]
        public List<ColumnInfo> ColumnInfoLists { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColumnMappingInfo {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  columnInfoLists: ").Append(ColumnInfoLists).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ColumnMappingInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ColumnMappingInfo input)
        {
            if (input == null) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.ColumnInfoLists != input.ColumnInfoLists || (this.ColumnInfoLists != null && input.ColumnInfoLists != null && !this.ColumnInfoLists.SequenceEqual(input.ColumnInfoLists))) return false;

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
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.ColumnInfoLists != null) hashCode = hashCode * 59 + this.ColumnInfoLists.GetHashCode();
                return hashCode;
            }
        }
    }
}
