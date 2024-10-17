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
    /// 查询可恢复表的请求信息
    /// </summary>
    public class PostgreSQLHistoryTableRequest 
    {

        /// <summary>
        /// 实例ID集合
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// 恢复时间点
        /// </summary>
        [JsonProperty("restore_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RestoreTime { get; set; }

        /// <summary>
        /// 数据库名，模糊查询
        /// </summary>
        [JsonProperty("database_name_like", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseNameLike { get; set; }

        /// <summary>
        /// 数据库表名，模糊查询
        /// </summary>
        [JsonProperty("table_name_like", NullValueHandling = NullValueHandling.Ignore)]
        public string TableNameLike { get; set; }

        /// <summary>
        /// 实例名称，模糊查询
        /// </summary>
        [JsonProperty("instance_name_like", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceNameLike { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostgreSQLHistoryTableRequest {\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  restoreTime: ").Append(RestoreTime).Append("\n");
            sb.Append("  databaseNameLike: ").Append(DatabaseNameLike).Append("\n");
            sb.Append("  tableNameLike: ").Append(TableNameLike).Append("\n");
            sb.Append("  instanceNameLike: ").Append(InstanceNameLike).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostgreSQLHistoryTableRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostgreSQLHistoryTableRequest input)
        {
            if (input == null) return false;
            if (this.InstanceIds != input.InstanceIds || (this.InstanceIds != null && input.InstanceIds != null && !this.InstanceIds.SequenceEqual(input.InstanceIds))) return false;
            if (this.RestoreTime != input.RestoreTime || (this.RestoreTime != null && !this.RestoreTime.Equals(input.RestoreTime))) return false;
            if (this.DatabaseNameLike != input.DatabaseNameLike || (this.DatabaseNameLike != null && !this.DatabaseNameLike.Equals(input.DatabaseNameLike))) return false;
            if (this.TableNameLike != input.TableNameLike || (this.TableNameLike != null && !this.TableNameLike.Equals(input.TableNameLike))) return false;
            if (this.InstanceNameLike != input.InstanceNameLike || (this.InstanceNameLike != null && !this.InstanceNameLike.Equals(input.InstanceNameLike))) return false;

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
                if (this.InstanceIds != null) hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                if (this.RestoreTime != null) hashCode = hashCode * 59 + this.RestoreTime.GetHashCode();
                if (this.DatabaseNameLike != null) hashCode = hashCode * 59 + this.DatabaseNameLike.GetHashCode();
                if (this.TableNameLike != null) hashCode = hashCode * 59 + this.TableNameLike.GetHashCode();
                if (this.InstanceNameLike != null) hashCode = hashCode * 59 + this.InstanceNameLike.GetHashCode();
                return hashCode;
            }
        }
    }
}
