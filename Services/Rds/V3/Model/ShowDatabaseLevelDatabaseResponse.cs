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
    /// Response Object
    /// </summary>
    public class ShowDatabaseLevelDatabaseResponse : SdkResponse
    {

        /// <summary>
        /// 库信息列表
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatabaseBackupInfo> Databases { get; set; }

        /// <summary>
        /// 可恢复库的个数
        /// </summary>
        [JsonProperty("database_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? DatabaseLimit { get; set; }

        /// <summary>
        /// obs桶名
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDatabaseLevelDatabaseResponse {\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("  databaseLimit: ").Append(DatabaseLimit).Append("\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDatabaseLevelDatabaseResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDatabaseLevelDatabaseResponse input)
        {
            if (input == null) return false;
            if (this.Databases != input.Databases || (this.Databases != null && input.Databases != null && !this.Databases.SequenceEqual(input.Databases))) return false;
            if (this.DatabaseLimit != input.DatabaseLimit || (this.DatabaseLimit != null && !this.DatabaseLimit.Equals(input.DatabaseLimit))) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;

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
                if (this.Databases != null) hashCode = hashCode * 59 + this.Databases.GetHashCode();
                if (this.DatabaseLimit != null) hashCode = hashCode * 59 + this.DatabaseLimit.GetHashCode();
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                return hashCode;
            }
        }
    }
}
