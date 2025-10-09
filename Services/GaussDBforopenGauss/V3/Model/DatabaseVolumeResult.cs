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
    public class DatabaseVolumeResult 
    {

        /// <summary>
        /// **参数解释**: 数据库名称。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// **参数解释**: 数据库的缺省表空间名。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("table_space_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableSpaceName { get; set; }

        /// <summary>
        /// **参数解释**: 表所属用户名称。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**: 数据库占用空间大小。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("database_size", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseVolumeResult {\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  tableSpaceName: ").Append(TableSpaceName).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  databaseSize: ").Append(DatabaseSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatabaseVolumeResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatabaseVolumeResult input)
        {
            if (input == null) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.TableSpaceName != input.TableSpaceName || (this.TableSpaceName != null && !this.TableSpaceName.Equals(input.TableSpaceName))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.DatabaseSize != input.DatabaseSize || (this.DatabaseSize != null && !this.DatabaseSize.Equals(input.DatabaseSize))) return false;

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
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.TableSpaceName != null) hashCode = hashCode * 59 + this.TableSpaceName.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.DatabaseSize != null) hashCode = hashCode * 59 + this.DatabaseSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
