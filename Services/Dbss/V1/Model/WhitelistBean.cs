using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WhitelistBean 
    {

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_timestamp_ms", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTimestampMs { get; set; }

        /// <summary>
        /// 数据库IDs
        /// </summary>
        [JsonProperty("db_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DbIds { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        /// 状态 - true:启用 - false: 禁用
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 记录ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// SQL语句
        /// </summary>
        [JsonProperty("sql", NullValueHandling = NullValueHandling.Ignore)]
        public string Sql { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_timestamp_ms", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTimestampMs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhitelistBean {\n");
            sb.Append("  createTimestampMs: ").Append(CreateTimestampMs).Append("\n");
            sb.Append("  dbIds: ").Append(DbIds).Append("\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  sql: ").Append(Sql).Append("\n");
            sb.Append("  updateTimestampMs: ").Append(UpdateTimestampMs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WhitelistBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WhitelistBean input)
        {
            if (input == null) return false;
            if (this.CreateTimestampMs != input.CreateTimestampMs || (this.CreateTimestampMs != null && !this.CreateTimestampMs.Equals(input.CreateTimestampMs))) return false;
            if (this.DbIds != input.DbIds || (this.DbIds != null && input.DbIds != null && !this.DbIds.SequenceEqual(input.DbIds))) return false;
            if (this.Desc != input.Desc || (this.Desc != null && !this.Desc.Equals(input.Desc))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Sql != input.Sql || (this.Sql != null && !this.Sql.Equals(input.Sql))) return false;
            if (this.UpdateTimestampMs != input.UpdateTimestampMs || (this.UpdateTimestampMs != null && !this.UpdateTimestampMs.Equals(input.UpdateTimestampMs))) return false;

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
                if (this.CreateTimestampMs != null) hashCode = hashCode * 59 + this.CreateTimestampMs.GetHashCode();
                if (this.DbIds != null) hashCode = hashCode * 59 + this.DbIds.GetHashCode();
                if (this.Desc != null) hashCode = hashCode * 59 + this.Desc.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Sql != null) hashCode = hashCode * 59 + this.Sql.GetHashCode();
                if (this.UpdateTimestampMs != null) hashCode = hashCode * 59 + this.UpdateTimestampMs.GetHashCode();
                return hashCode;
            }
        }
    }
}
