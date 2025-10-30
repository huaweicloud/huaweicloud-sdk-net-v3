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
    /// Request Object
    /// </summary>
    public class GetInstancesNoIndexTablesRequest 
    {

        /// <summary>
        /// 实例ID
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 指定查询是否应侧重于检索最新或最新的特殊表。
        /// </summary>
        [SDKProperty("newest", IsQuery = true)]
        [JsonProperty("newest", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newest { get; set; }

        /// <summary>
        /// 表格类型。
        /// </summary>
        [SDKProperty("table_type", IsQuery = true)]
        [JsonProperty("table_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TableType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetInstancesNoIndexTablesRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  newest: ").Append(Newest).Append("\n");
            sb.Append("  tableType: ").Append(TableType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetInstancesNoIndexTablesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetInstancesNoIndexTablesRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Newest != input.Newest || (this.Newest != null && !this.Newest.Equals(input.Newest))) return false;
            if (this.TableType != input.TableType || (this.TableType != null && !this.TableType.Equals(input.TableType))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Newest != null) hashCode = hashCode * 59 + this.Newest.GetHashCode();
                if (this.TableType != null) hashCode = hashCode * 59 + this.TableType.GetHashCode();
                return hashCode;
            }
        }
    }
}
