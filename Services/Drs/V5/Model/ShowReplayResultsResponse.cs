using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowReplayResultsResponse : SdkResponse
    {

        /// <summary>
        /// 数据总量
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 回放基于时间统计详细信息列表，在type为shard_statistics时返回
        /// </summary>
        [JsonProperty("shard_statics", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReplayShardStaticsResp> ShardStatics { get; set; }

        /// <summary>
        /// 慢SQL信息列表，在type为slow_sql时返回
        /// </summary>
        [JsonProperty("slow_sqls", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReplaySlowSqlResp> SlowSqls { get; set; }

        /// <summary>
        /// 慢SQL统计信息列表，在type为slow_sql_template时返回
        /// </summary>
        [JsonProperty("slow_sql_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReplaySlowSqlTemplateResp> SlowSqlTemplates { get; set; }

        /// <summary>
        /// 异常SQL信息列表，在type为error_sql时返回
        /// </summary>
        [JsonProperty("error_sqls", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReplayErrorSqlResp> ErrorSqls { get; set; }

        /// <summary>
        /// 异常SQL统计信息列表，在type为error_sql_template时返回
        /// </summary>
        [JsonProperty("error_sql_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReplayErrorSqlTemplateResp> ErrorSqlTemplates { get; set; }

        /// <summary>
        /// 正在回放SQL信息列表，在type为replaying_sql时返回
        /// </summary>
        [JsonProperty("replaying_sqls", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReplayingSqlResp> ReplayingSqls { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowReplayResultsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  shardStatics: ").Append(ShardStatics).Append("\n");
            sb.Append("  slowSqls: ").Append(SlowSqls).Append("\n");
            sb.Append("  slowSqlTemplates: ").Append(SlowSqlTemplates).Append("\n");
            sb.Append("  errorSqls: ").Append(ErrorSqls).Append("\n");
            sb.Append("  errorSqlTemplates: ").Append(ErrorSqlTemplates).Append("\n");
            sb.Append("  replayingSqls: ").Append(ReplayingSqls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowReplayResultsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowReplayResultsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.ShardStatics == input.ShardStatics ||
                    this.ShardStatics != null &&
                    input.ShardStatics != null &&
                    this.ShardStatics.SequenceEqual(input.ShardStatics)
                ) && 
                (
                    this.SlowSqls == input.SlowSqls ||
                    this.SlowSqls != null &&
                    input.SlowSqls != null &&
                    this.SlowSqls.SequenceEqual(input.SlowSqls)
                ) && 
                (
                    this.SlowSqlTemplates == input.SlowSqlTemplates ||
                    this.SlowSqlTemplates != null &&
                    input.SlowSqlTemplates != null &&
                    this.SlowSqlTemplates.SequenceEqual(input.SlowSqlTemplates)
                ) && 
                (
                    this.ErrorSqls == input.ErrorSqls ||
                    this.ErrorSqls != null &&
                    input.ErrorSqls != null &&
                    this.ErrorSqls.SequenceEqual(input.ErrorSqls)
                ) && 
                (
                    this.ErrorSqlTemplates == input.ErrorSqlTemplates ||
                    this.ErrorSqlTemplates != null &&
                    input.ErrorSqlTemplates != null &&
                    this.ErrorSqlTemplates.SequenceEqual(input.ErrorSqlTemplates)
                ) && 
                (
                    this.ReplayingSqls == input.ReplayingSqls ||
                    this.ReplayingSqls != null &&
                    input.ReplayingSqls != null &&
                    this.ReplayingSqls.SequenceEqual(input.ReplayingSqls)
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
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.ShardStatics != null)
                    hashCode = hashCode * 59 + this.ShardStatics.GetHashCode();
                if (this.SlowSqls != null)
                    hashCode = hashCode * 59 + this.SlowSqls.GetHashCode();
                if (this.SlowSqlTemplates != null)
                    hashCode = hashCode * 59 + this.SlowSqlTemplates.GetHashCode();
                if (this.ErrorSqls != null)
                    hashCode = hashCode * 59 + this.ErrorSqls.GetHashCode();
                if (this.ErrorSqlTemplates != null)
                    hashCode = hashCode * 59 + this.ErrorSqlTemplates.GetHashCode();
                if (this.ReplayingSqls != null)
                    hashCode = hashCode * 59 + this.ReplayingSqls.GetHashCode();
                return hashCode;
            }
        }
    }
}
