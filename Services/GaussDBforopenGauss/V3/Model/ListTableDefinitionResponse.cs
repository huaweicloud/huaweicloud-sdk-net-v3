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
    /// Response Object
    /// </summary>
    public class ListTableDefinitionResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 数据库表定义信息。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("table_definition", NullValueHandling = NullValueHandling.Ignore)]
        public string TableDefinition { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTableDefinitionResponse {\n");
            sb.Append("  tableDefinition: ").Append(TableDefinition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTableDefinitionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTableDefinitionResponse input)
        {
            if (input == null) return false;
            if (this.TableDefinition != input.TableDefinition || (this.TableDefinition != null && !this.TableDefinition.Equals(input.TableDefinition))) return false;

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
                if (this.TableDefinition != null) hashCode = hashCode * 59 + this.TableDefinition.GetHashCode();
                return hashCode;
            }
        }
    }
}
