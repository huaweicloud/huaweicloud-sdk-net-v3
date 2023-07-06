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
    /// 数据库对象迁移或同步目标库信息，两层到三层数据库时需要指定。
    /// </summary>
    public class TargetRootDb 
    {

        /// <summary>
        /// 库名。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 默认编码格式是utf8。
        /// </summary>
        [JsonProperty("db_encoding", NullValueHandling = NullValueHandling.Ignore)]
        public string DbEncoding { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TargetRootDb {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  dbEncoding: ").Append(DbEncoding).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TargetRootDb);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TargetRootDb input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DbName == input.DbName ||
                    (this.DbName != null &&
                    this.DbName.Equals(input.DbName))
                ) && 
                (
                    this.DbEncoding == input.DbEncoding ||
                    (this.DbEncoding != null &&
                    this.DbEncoding.Equals(input.DbEncoding))
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
                if (this.DbName != null)
                    hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.DbEncoding != null)
                    hashCode = hashCode * 59 + this.DbEncoding.GetHashCode();
                return hashCode;
            }
        }
    }
}
