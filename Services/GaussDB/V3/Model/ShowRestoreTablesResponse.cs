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
    /// Response Object
    /// </summary>
    public class ShowRestoreTablesResponse : SdkResponse
    {

        /// <summary>
        /// 数据库总数。
        /// </summary>
        [JsonProperty("total_databases", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDatabases { get; set; }

        /// <summary>
        /// 数据库信息。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestoreDatabaseInfos> Databases { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRestoreTablesResponse {\n");
            sb.Append("  totalDatabases: ").Append(TotalDatabases).Append("\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRestoreTablesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRestoreTablesResponse input)
        {
            if (input == null) return false;
            if (this.TotalDatabases != input.TotalDatabases || (this.TotalDatabases != null && !this.TotalDatabases.Equals(input.TotalDatabases))) return false;
            if (this.Databases != input.Databases || (this.Databases != null && input.Databases != null && !this.Databases.SequenceEqual(input.Databases))) return false;

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
                if (this.TotalDatabases != null) hashCode = hashCode * 59 + this.TotalDatabases.GetHashCode();
                if (this.Databases != null) hashCode = hashCode * 59 + this.Databases.GetHashCode();
                return hashCode;
            }
        }
    }
}
