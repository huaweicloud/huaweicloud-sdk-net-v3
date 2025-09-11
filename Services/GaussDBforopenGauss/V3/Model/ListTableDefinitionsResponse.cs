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
    public class ListTableDefinitionsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 数据库表定义信息列表。
        /// </summary>
        [JsonProperty("table_definitions", NullValueHandling = NullValueHandling.Ignore)]
        public List<SchemaTableDefinitionResult> TableDefinitions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTableDefinitionsResponse {\n");
            sb.Append("  tableDefinitions: ").Append(TableDefinitions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTableDefinitionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTableDefinitionsResponse input)
        {
            if (input == null) return false;
            if (this.TableDefinitions != input.TableDefinitions || (this.TableDefinitions != null && input.TableDefinitions != null && !this.TableDefinitions.SequenceEqual(input.TableDefinitions))) return false;

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
                if (this.TableDefinitions != null) hashCode = hashCode * 59 + this.TableDefinitions.GetHashCode();
                return hashCode;
            }
        }
    }
}
