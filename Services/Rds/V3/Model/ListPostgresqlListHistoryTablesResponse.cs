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
    /// Response Object
    /// </summary>
    public class ListPostgresqlListHistoryTablesResponse : SdkResponse
    {

        /// <summary>
        /// 恢复表数量限制个数
        /// </summary>
        [JsonProperty("table_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? TableLimit { get; set; }

        /// <summary>
        /// 实例信息
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<PostgreSQLHistoryTableInstance> Instances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPostgresqlListHistoryTablesResponse {\n");
            sb.Append("  tableLimit: ").Append(TableLimit).Append("\n");
            sb.Append("  instances: ").Append(Instances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPostgresqlListHistoryTablesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPostgresqlListHistoryTablesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TableLimit == input.TableLimit ||
                    (this.TableLimit != null &&
                    this.TableLimit.Equals(input.TableLimit))
                ) && 
                (
                    this.Instances == input.Instances ||
                    this.Instances != null &&
                    input.Instances != null &&
                    this.Instances.SequenceEqual(input.Instances)
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
                if (this.TableLimit != null)
                    hashCode = hashCode * 59 + this.TableLimit.GetHashCode();
                if (this.Instances != null)
                    hashCode = hashCode * 59 + this.Instances.GetHashCode();
                return hashCode;
            }
        }
    }
}
