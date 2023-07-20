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
    /// 数据库schema信息。
    /// </summary>
    public class GaussDBforOpenGaussDatabaseForListSchema 
    {

        /// <summary>
        /// schema名称。
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// schema所属用户。
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GaussDBforOpenGaussDatabaseForListSchema {\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GaussDBforOpenGaussDatabaseForListSchema);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GaussDBforOpenGaussDatabaseForListSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SchemaName == input.SchemaName ||
                    (this.SchemaName != null &&
                    this.SchemaName.Equals(input.SchemaName))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
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
                if (this.SchemaName != null)
                    hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                return hashCode;
            }
        }
    }
}
