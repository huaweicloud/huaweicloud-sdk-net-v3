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
    public class RevokePostgresqlDbPrivilegeUser 
    {

        /// <summary>
        /// 数据库账号名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据库下模式名称
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RevokePostgresqlDbPrivilegeUser {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RevokePostgresqlDbPrivilegeUser);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RevokePostgresqlDbPrivilegeUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SchemaName == input.SchemaName ||
                    (this.SchemaName != null &&
                    this.SchemaName.Equals(input.SchemaName))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SchemaName != null)
                    hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                return hashCode;
            }
        }
    }
}
