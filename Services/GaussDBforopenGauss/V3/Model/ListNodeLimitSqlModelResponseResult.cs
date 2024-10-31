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
    /// 
    /// </summary>
    public class ListNodeLimitSqlModelResponseResult 
    {

        /// <summary>
        /// 限流任务SQL_ID。
        /// </summary>
        [JsonProperty("sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlId { get; set; }

        /// <summary>
        /// 限流任务SQL模板。
        /// </summary>
        [JsonProperty("sql_model", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlModel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNodeLimitSqlModelResponseResult {\n");
            sb.Append("  sqlId: ").Append(SqlId).Append("\n");
            sb.Append("  sqlModel: ").Append(SqlModel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNodeLimitSqlModelResponseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNodeLimitSqlModelResponseResult input)
        {
            if (input == null) return false;
            if (this.SqlId != input.SqlId || (this.SqlId != null && !this.SqlId.Equals(input.SqlId))) return false;
            if (this.SqlModel != input.SqlModel || (this.SqlModel != null && !this.SqlModel.Equals(input.SqlModel))) return false;

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
                if (this.SqlId != null) hashCode = hashCode * 59 + this.SqlId.GetHashCode();
                if (this.SqlModel != null) hashCode = hashCode * 59 + this.SqlModel.GetHashCode();
                return hashCode;
            }
        }
    }
}
