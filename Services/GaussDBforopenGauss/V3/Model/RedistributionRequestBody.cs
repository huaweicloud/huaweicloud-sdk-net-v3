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
    public class RedistributionRequestBody 
    {

        /// <summary>
        /// 具有JOIN关系的表，指定该参数则启用多表扩容模式，扩容前设置生效。 如果指定过该参数，后续调用可以传入空数组清除多表扩容配置。  本次扩容结束后自动清除该配置，下次扩容需要重新设置。 按照“database名称、schema1名称、table1名称、schema2名称、table2名称...”的格式指定，带有大小写或特殊字符的表名需要加\&quot;\&quot;转义。 多个数组则表示存在多个join group。
        /// </summary>
        [JsonProperty("redis_join_tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<string>> RedisJoinTables { get; set; }

        /// <summary>
        /// 重分布并发数，扩容前设置生效。
        /// </summary>
        [JsonProperty("redis_parallel_jobs", NullValueHandling = NullValueHandling.Ignore)]
        public int? RedisParallelJobs { get; set; }

        /// <summary>
        /// 重分布资源管控级别，扩容前或扩容重分布结束前设置生效。
        /// </summary>
        [JsonProperty("redis_resource_level", NullValueHandling = NullValueHandling.Ignore)]
        public string RedisResourceLevel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedistributionRequestBody {\n");
            sb.Append("  redisJoinTables: ").Append(RedisJoinTables).Append("\n");
            sb.Append("  redisParallelJobs: ").Append(RedisParallelJobs).Append("\n");
            sb.Append("  redisResourceLevel: ").Append(RedisResourceLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RedistributionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RedistributionRequestBody input)
        {
            if (input == null) return false;
            if (this.RedisJoinTables != input.RedisJoinTables || (this.RedisJoinTables != null && input.RedisJoinTables != null && !this.RedisJoinTables.SequenceEqual(input.RedisJoinTables))) return false;
            if (this.RedisParallelJobs != input.RedisParallelJobs || (this.RedisParallelJobs != null && !this.RedisParallelJobs.Equals(input.RedisParallelJobs))) return false;
            if (this.RedisResourceLevel != input.RedisResourceLevel || (this.RedisResourceLevel != null && !this.RedisResourceLevel.Equals(input.RedisResourceLevel))) return false;

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
                if (this.RedisJoinTables != null) hashCode = hashCode * 59 + this.RedisJoinTables.GetHashCode();
                if (this.RedisParallelJobs != null) hashCode = hashCode * 59 + this.RedisParallelJobs.GetHashCode();
                if (this.RedisResourceLevel != null) hashCode = hashCode * 59 + this.RedisResourceLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
