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
    /// 删除数据库schema信息。
    /// </summary>
    public class DeleteDatabaseSchemaRequestBody 
    {

        /// <summary>
        /// 数据库名称。 使用已存在的数据库名称，且不能为模板库。 模板库包括postgres， template0 ，template1，templatea，template_pdb，templatem。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// SCHEMA名称。 SCHEMA名称在1到63个字符之间，由字母、数字、或下划线组成，不能包含其他特殊字符，不能以“pg”和数字开头，且不能和模板库和已存在的SCHEMA重名。 模板库包括postgres， template0 ，template1，templatea，template_pdb，templatem。 已存在的SCHEMA包括public，information_schema。
        /// </summary>
        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public string Schema { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteDatabaseSchemaRequestBody {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  schema: ").Append(Schema).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteDatabaseSchemaRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteDatabaseSchemaRequestBody input)
        {
            if (input == null) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.Schema != input.Schema || (this.Schema != null && !this.Schema.Equals(input.Schema))) return false;

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
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.Schema != null) hashCode = hashCode * 59 + this.Schema.GetHashCode();
                return hashCode;
            }
        }
    }
}
