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
    /// 修改数据同步
    /// </summary>
    public class UpdateChDatabaseConfigRequestBody 
    {

        /// <summary>
        /// 源实例ID，严格匹配UUID规则。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// 源实例节点ID。
        /// </summary>
        [JsonProperty("source_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceNodeId { get; set; }

        /// <summary>
        /// 数据库名。
        /// </summary>
        [JsonProperty("database", NullValueHandling = NullValueHandling.Ignore)]
        public string Database { get; set; }

        /// <summary>
        /// 配置值。仅支持修改同步范围，不支持修改白名单或黑名单类型。  例如：创建了白名单数据同步，调用本接口修改时， 支持 \&quot;value\&quot;：\&quot;{\\\&quot;white_list\\\&quot;:\\\&quot;test1,test2,test3\\\&quot;}\&quot; 不支持 \&quot;value\&quot;：\&quot;{\\\&quot;black_list\\\&quot;:\\\&quot;test1,test2,test3\\\&quot;}\&quot;
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateChDatabaseConfigRequestBody {\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  sourceNodeId: ").Append(SourceNodeId).Append("\n");
            sb.Append("  database: ").Append(Database).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateChDatabaseConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateChDatabaseConfigRequestBody input)
        {
            if (input == null) return false;
            if (this.SourceInstanceId != input.SourceInstanceId || (this.SourceInstanceId != null && !this.SourceInstanceId.Equals(input.SourceInstanceId))) return false;
            if (this.SourceNodeId != input.SourceNodeId || (this.SourceNodeId != null && !this.SourceNodeId.Equals(input.SourceNodeId))) return false;
            if (this.Database != input.Database || (this.Database != null && !this.Database.Equals(input.Database))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                if (this.SourceInstanceId != null) hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.SourceNodeId != null) hashCode = hashCode * 59 + this.SourceNodeId.GetHashCode();
                if (this.Database != null) hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
