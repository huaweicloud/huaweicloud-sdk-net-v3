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
    public class SchemaVolumeResult 
    {

        /// <summary>
        /// **参数解释**: schema的大小。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("schema_size", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaSize { get; set; }

        /// <summary>
        /// **参数解释**: schema拥有的表数量。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("table_count", NullValueHandling = NullValueHandling.Ignore)]
        public string TableCount { get; set; }

        /// <summary>
        /// **参数解释**: schema所属用户名称。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**: schema名称空间的名称。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchemaVolumeResult {\n");
            sb.Append("  schemaSize: ").Append(SchemaSize).Append("\n");
            sb.Append("  tableCount: ").Append(TableCount).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SchemaVolumeResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SchemaVolumeResult input)
        {
            if (input == null) return false;
            if (this.SchemaSize != input.SchemaSize || (this.SchemaSize != null && !this.SchemaSize.Equals(input.SchemaSize))) return false;
            if (this.TableCount != input.TableCount || (this.TableCount != null && !this.TableCount.Equals(input.TableCount))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;

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
                if (this.SchemaSize != null) hashCode = hashCode * 59 + this.SchemaSize.GetHashCode();
                if (this.TableCount != null) hashCode = hashCode * 59 + this.TableCount.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                return hashCode;
            }
        }
    }
}
