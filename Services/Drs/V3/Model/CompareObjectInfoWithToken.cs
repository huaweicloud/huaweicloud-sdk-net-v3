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
    /// 
    /// </summary>
    public class CompareObjectInfoWithToken 
    {

        /// <summary>
        /// 库名。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 该库下的表信息列表（带token）。
        /// </summary>
        [JsonProperty("table_name_with_token", NullValueHandling = NullValueHandling.Ignore)]
        public List<CompareTableInfoWithToken> TableNameWithToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareObjectInfoWithToken {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  tableNameWithToken: ").Append(TableNameWithToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompareObjectInfoWithToken);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompareObjectInfoWithToken input)
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
                    this.TableNameWithToken == input.TableNameWithToken ||
                    this.TableNameWithToken != null &&
                    input.TableNameWithToken != null &&
                    this.TableNameWithToken.SequenceEqual(input.TableNameWithToken)
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
                if (this.TableNameWithToken != null)
                    hashCode = hashCode * 59 + this.TableNameWithToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
