using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RestoreInstanceFromCollectionRequestBodyRestoreCollections 
    {

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("database", NullValueHandling = NullValueHandling.Ignore)]
        public string Database { get; set; }

        /// <summary>
        /// 数据库恢复时间点。如果是数据库级恢复，该参数必传，UNIX时间戳格式，单位是毫秒，时区是UTC。
        /// </summary>
        [JsonProperty("restore_database_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RestoreDatabaseTime { get; set; }

        /// <summary>
        /// 集合信息。
        /// </summary>
        [JsonProperty("collections", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestoreInstanceFromCollectionRequestBodyCollections> Collections { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreInstanceFromCollectionRequestBodyRestoreCollections {\n");
            sb.Append("  database: ").Append(Database).Append("\n");
            sb.Append("  restoreDatabaseTime: ").Append(RestoreDatabaseTime).Append("\n");
            sb.Append("  collections: ").Append(Collections).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreInstanceFromCollectionRequestBodyRestoreCollections);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreInstanceFromCollectionRequestBodyRestoreCollections input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Database == input.Database ||
                    (this.Database != null &&
                    this.Database.Equals(input.Database))
                ) && 
                (
                    this.RestoreDatabaseTime == input.RestoreDatabaseTime ||
                    (this.RestoreDatabaseTime != null &&
                    this.RestoreDatabaseTime.Equals(input.RestoreDatabaseTime))
                ) && 
                (
                    this.Collections == input.Collections ||
                    this.Collections != null &&
                    input.Collections != null &&
                    this.Collections.SequenceEqual(input.Collections)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Database != null)
                    hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.RestoreDatabaseTime != null)
                    hashCode = hashCode * 59 + this.RestoreDatabaseTime.GetHashCode();
                if (this.Collections != null)
                    hashCode = hashCode * 59 + this.Collections.GetHashCode();
                return hashCode;
            }
        }
    }
}
