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
    public class ListDatabaseVersionsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 数据库版本列表。
        /// </summary>
        [JsonProperty("database_versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatabaseVersionResult> DatabaseVersions { get; set; }

        /// <summary>
        /// **参数解释**： 数据库三位引擎版本总个数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDatabaseVersionsResponse {\n");
            sb.Append("  databaseVersions: ").Append(DatabaseVersions).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDatabaseVersionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDatabaseVersionsResponse input)
        {
            if (input == null) return false;
            if (this.DatabaseVersions != input.DatabaseVersions || (this.DatabaseVersions != null && input.DatabaseVersions != null && !this.DatabaseVersions.SequenceEqual(input.DatabaseVersions))) return false;
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
                if (this.DatabaseVersions != null) hashCode = hashCode * 59 + this.DatabaseVersions.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
