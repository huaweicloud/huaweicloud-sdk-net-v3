using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QuertHistorySQLResultsBody 
    {

        /// <summary>
        /// 上次修改时间，时间戳，毫秒数
        /// </summary>
        [JsonProperty("last_use_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastUseTime { get; set; }

        /// <summary>
        /// 历史sql语句
        /// </summary>
        [JsonProperty("sql_statement", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlStatement { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuertHistorySQLResultsBody {\n");
            sb.Append("  lastUseTime: ").Append(LastUseTime).Append("\n");
            sb.Append("  sqlStatement: ").Append(SqlStatement).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuertHistorySQLResultsBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuertHistorySQLResultsBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastUseTime == input.LastUseTime ||
                    (this.LastUseTime != null &&
                    this.LastUseTime.Equals(input.LastUseTime))
                ) && 
                (
                    this.SqlStatement == input.SqlStatement ||
                    (this.SqlStatement != null &&
                    this.SqlStatement.Equals(input.SqlStatement))
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
                if (this.LastUseTime != null)
                    hashCode = hashCode * 59 + this.LastUseTime.GetHashCode();
                if (this.SqlStatement != null)
                    hashCode = hashCode * 59 + this.SqlStatement.GetHashCode();
                return hashCode;
            }
        }
    }
}
