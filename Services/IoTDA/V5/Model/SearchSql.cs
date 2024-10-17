using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 设备搜索请求结构体。
    /// </summary>
    public class SearchSql 
    {

        /// <summary>
        /// 搜索sql语句，具体使用方法见类SQL语法使用说明章节
        /// </summary>
        [JsonProperty("sql", NullValueHandling = NullValueHandling.Ignore)]
        public string Sql { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchSql {\n");
            sb.Append("  sql: ").Append(Sql).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchSql);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchSql input)
        {
            if (input == null) return false;
            if (this.Sql != input.Sql || (this.Sql != null && !this.Sql.Equals(input.Sql))) return false;

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
                if (this.Sql != null) hashCode = hashCode * 59 + this.Sql.GetHashCode();
                return hashCode;
            }
        }
    }
}
