using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSqlPatchResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: SQL Patch信息列表。
        /// </summary>
        [JsonProperty("sql_patch_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<SqlPatchInfosResult> SqlPatchInfos { get; set; }

        /// <summary>
        /// **参数解释**: 返回的SQL Patch数量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSqlPatchResponse {\n");
            sb.Append("  sqlPatchInfos: ").Append(SqlPatchInfos).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSqlPatchResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSqlPatchResponse input)
        {
            if (input == null) return false;
            if (this.SqlPatchInfos != input.SqlPatchInfos || (this.SqlPatchInfos != null && input.SqlPatchInfos != null && !this.SqlPatchInfos.SequenceEqual(input.SqlPatchInfos))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.SqlPatchInfos != null) hashCode = hashCode * 59 + this.SqlPatchInfos.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
