using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 表配置信息。
    /// </summary>
    public class ChDatabaseTableReplConfigInfo 
    {

        /// <summary>
        /// 表同步类型。 取值范围： - white_list：白名单，此时表范围不能为空。 - black_list：黑名单，此时表范围为空则选择所有表。
        /// </summary>
        [JsonProperty("repl_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplType { get; set; }

        /// <summary>
        /// 白名单或黑名单的表范围。
        /// </summary>
        [JsonProperty("tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tables { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChDatabaseTableReplConfigInfo {\n");
            sb.Append("  replType: ").Append(ReplType).Append("\n");
            sb.Append("  tables: ").Append(Tables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChDatabaseTableReplConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChDatabaseTableReplConfigInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReplType == input.ReplType ||
                    (this.ReplType != null &&
                    this.ReplType.Equals(input.ReplType))
                ) && 
                (
                    this.Tables == input.Tables ||
                    this.Tables != null &&
                    input.Tables != null &&
                    this.Tables.SequenceEqual(input.Tables)
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
                if (this.ReplType != null)
                    hashCode = hashCode * 59 + this.ReplType.GetHashCode();
                if (this.Tables != null)
                    hashCode = hashCode * 59 + this.Tables.GetHashCode();
                return hashCode;
            }
        }
    }
}
