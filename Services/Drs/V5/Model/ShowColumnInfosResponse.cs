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
    /// Response Object
    /// </summary>
    public class ShowColumnInfosResponse : SdkResponse
    {

        /// <summary>
        /// 列映射信息
        /// </summary>
        [JsonProperty("column_map_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ColumnMappingInfo> ColumnMapInfos { get; set; }

        /// <summary>
        /// 和列信息相关的对象
        /// </summary>
        [JsonProperty("object_with_column_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObjectWithColumnInfo> ObjectWithColumnInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowColumnInfosResponse {\n");
            sb.Append("  columnMapInfos: ").Append(ColumnMapInfos).Append("\n");
            sb.Append("  objectWithColumnInfos: ").Append(ObjectWithColumnInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowColumnInfosResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowColumnInfosResponse input)
        {
            if (input == null) return false;
            if (this.ColumnMapInfos != input.ColumnMapInfos || (this.ColumnMapInfos != null && input.ColumnMapInfos != null && !this.ColumnMapInfos.SequenceEqual(input.ColumnMapInfos))) return false;
            if (this.ObjectWithColumnInfos != input.ObjectWithColumnInfos || (this.ObjectWithColumnInfos != null && input.ObjectWithColumnInfos != null && !this.ObjectWithColumnInfos.SequenceEqual(input.ObjectWithColumnInfos))) return false;

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
                if (this.ColumnMapInfos != null) hashCode = hashCode * 59 + this.ColumnMapInfos.GetHashCode();
                if (this.ObjectWithColumnInfos != null) hashCode = hashCode * 59 + this.ObjectWithColumnInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
