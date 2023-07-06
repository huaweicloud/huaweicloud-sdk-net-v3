using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 目标实例根节点库信息体
    /// </summary>
    public class DefaultRootDb 
    {

        /// <summary>
        /// 库名。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 编码格式。
        /// </summary>
        [JsonProperty("db_encoding", NullValueHandling = NullValueHandling.Ignore)]
        public string DbEncoding { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefaultRootDb {\n");
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
            return this.Equals(input as DefaultRootDb);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DefaultRootDb input)
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
