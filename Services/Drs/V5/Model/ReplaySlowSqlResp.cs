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
    /// 回放慢SQL数据结果对象
    /// </summary>
    public class ReplaySlowSqlResp 
    {

        /// <summary>
        /// SQL语句类型
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectType { get; set; }

        /// <summary>
        /// SQL语句
        /// </summary>
        [JsonProperty("slow_sql", NullValueHandling = NullValueHandling.Ignore)]
        public string SlowSql { get; set; }

        /// <summary>
        /// 源库执行耗时
        /// </summary>
        [JsonProperty("old_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OldTime { get; set; }

        /// <summary>
        /// 目标库回放执行耗时
        /// </summary>
        [JsonProperty("replay_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplayTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplaySlowSqlResp {\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  slowSql: ").Append(SlowSql).Append("\n");
            sb.Append("  oldTime: ").Append(OldTime).Append("\n");
            sb.Append("  replayTime: ").Append(ReplayTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplaySlowSqlResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplaySlowSqlResp input)
        {
            if (input == null) return false;
            if (this.ObjectType != input.ObjectType || (this.ObjectType != null && !this.ObjectType.Equals(input.ObjectType))) return false;
            if (this.SlowSql != input.SlowSql || (this.SlowSql != null && !this.SlowSql.Equals(input.SlowSql))) return false;
            if (this.OldTime != input.OldTime || (this.OldTime != null && !this.OldTime.Equals(input.OldTime))) return false;
            if (this.ReplayTime != input.ReplayTime || (this.ReplayTime != null && !this.ReplayTime.Equals(input.ReplayTime))) return false;

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
                if (this.ObjectType != null) hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.SlowSql != null) hashCode = hashCode * 59 + this.SlowSql.GetHashCode();
                if (this.OldTime != null) hashCode = hashCode * 59 + this.OldTime.GetHashCode();
                if (this.ReplayTime != null) hashCode = hashCode * 59 + this.ReplayTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
