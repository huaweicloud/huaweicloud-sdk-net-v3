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
    /// 修改列信息请求体
    /// </summary>
    public class ModifyColumnInfoReq 
    {

        /// <summary>
        /// 列信息
        /// </summary>
        [JsonProperty("column_map_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ColumnMappingInfo> ColumnMapInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyColumnInfoReq {\n");
            sb.Append("  columnMapInfos: ").Append(ColumnMapInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyColumnInfoReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyColumnInfoReq input)
        {
            if (input == null) return false;
            if (this.ColumnMapInfos != input.ColumnMapInfos || (this.ColumnMapInfos != null && input.ColumnMapInfos != null && !this.ColumnMapInfos.SequenceEqual(input.ColumnMapInfos))) return false;

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
                return hashCode;
            }
        }
    }
}
