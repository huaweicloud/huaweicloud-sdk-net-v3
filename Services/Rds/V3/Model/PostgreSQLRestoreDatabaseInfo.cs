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
    /// 库级恢复数据库信息
    /// </summary>
    public class PostgreSQLRestoreDatabaseInfo 
    {

        /// <summary>
        /// 恢复前库名
        /// </summary>
        [JsonProperty("old_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OldName { get; set; }

        /// <summary>
        /// 恢复后库名
        /// </summary>
        [JsonProperty("new_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NewName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostgreSQLRestoreDatabaseInfo {\n");
            sb.Append("  oldName: ").Append(OldName).Append("\n");
            sb.Append("  newName: ").Append(NewName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostgreSQLRestoreDatabaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostgreSQLRestoreDatabaseInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OldName == input.OldName ||
                    (this.OldName != null &&
                    this.OldName.Equals(input.OldName))
                ) && 
                (
                    this.NewName == input.NewName ||
                    (this.NewName != null &&
                    this.NewName.Equals(input.NewName))
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
                if (this.OldName != null)
                    hashCode = hashCode * 59 + this.OldName.GetHashCode();
                if (this.NewName != null)
                    hashCode = hashCode * 59 + this.NewName.GetHashCode();
                return hashCode;
            }
        }
    }
}
