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
    /// ClickHouse创建数据同步请求。
    /// </summary>
    public class CreateChDatabaseReplicationRequestBody 
    {

        /// <summary>
        /// 源实例ID。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// 源节点ID。GaussDB(for MySQL)只读节点ID。如为空，则取GaussDB(for MySQL)主节点ID。
        /// </summary>
        [JsonProperty("source_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceNodeId { get; set; }

        /// <summary>
        /// 源数据库。
        /// </summary>
        [JsonProperty("source_database", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDatabase { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateChDatabaseReplicationRequestBody {\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  sourceNodeId: ").Append(SourceNodeId).Append("\n");
            sb.Append("  sourceDatabase: ").Append(SourceDatabase).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateChDatabaseReplicationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateChDatabaseReplicationRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceInstanceId == input.SourceInstanceId ||
                    (this.SourceInstanceId != null &&
                    this.SourceInstanceId.Equals(input.SourceInstanceId))
                ) && 
                (
                    this.SourceNodeId == input.SourceNodeId ||
                    (this.SourceNodeId != null &&
                    this.SourceNodeId.Equals(input.SourceNodeId))
                ) && 
                (
                    this.SourceDatabase == input.SourceDatabase ||
                    (this.SourceDatabase != null &&
                    this.SourceDatabase.Equals(input.SourceDatabase))
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
                if (this.SourceInstanceId != null)
                    hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.SourceNodeId != null)
                    hashCode = hashCode * 59 + this.SourceNodeId.GetHashCode();
                if (this.SourceDatabase != null)
                    hashCode = hashCode * 59 + this.SourceDatabase.GetHashCode();
                return hashCode;
            }
        }
    }
}
