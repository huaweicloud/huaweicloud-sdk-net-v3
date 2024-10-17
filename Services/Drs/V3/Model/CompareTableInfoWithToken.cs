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
    public class CompareTableInfoWithToken 
    {

        /// <summary>
        /// 表名。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// 该表的min token。
        /// </summary>
        [JsonProperty("min_token", NullValueHandling = NullValueHandling.Ignore)]
        public string MinToken { get; set; }

        /// <summary>
        /// 该表的max token。
        /// </summary>
        [JsonProperty("max_token", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareTableInfoWithToken {\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  minToken: ").Append(MinToken).Append("\n");
            sb.Append("  maxToken: ").Append(MaxToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompareTableInfoWithToken);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompareTableInfoWithToken input)
        {
            if (input == null) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.MinToken != input.MinToken || (this.MinToken != null && !this.MinToken.Equals(input.MinToken))) return false;
            if (this.MaxToken != input.MaxToken || (this.MaxToken != null && !this.MaxToken.Equals(input.MaxToken))) return false;

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
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.MinToken != null) hashCode = hashCode * 59 + this.MinToken.GetHashCode();
                if (this.MaxToken != null) hashCode = hashCode * 59 + this.MaxToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
