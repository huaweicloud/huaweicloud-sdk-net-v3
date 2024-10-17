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
    /// 
    /// </summary>
    public class UnchangeableParam 
    {

        /// <summary>
        /// 表名大小写是否敏感，默认值是“1”，当前仅MySQL 8.0支持。 取值范围： - 0：表名被存储成固定且表名称大小写敏感。 - 1：表名将被存储成小写且表名称大小写不敏感。
        /// </summary>
        [JsonProperty("lower_case_table_names", NullValueHandling = NullValueHandling.Ignore)]
        public string LowerCaseTableNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnchangeableParam {\n");
            sb.Append("  lowerCaseTableNames: ").Append(LowerCaseTableNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnchangeableParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnchangeableParam input)
        {
            if (input == null) return false;
            if (this.LowerCaseTableNames != input.LowerCaseTableNames || (this.LowerCaseTableNames != null && !this.LowerCaseTableNames.Equals(input.LowerCaseTableNames))) return false;

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
                if (this.LowerCaseTableNames != null) hashCode = hashCode * 59 + this.LowerCaseTableNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
