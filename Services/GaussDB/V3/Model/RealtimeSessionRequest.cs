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
    /// 收集全部实时会话信息请求体
    /// </summary>
    public class RealtimeSessionRequest 
    {

        /// <summary>
        /// **参数解释**：  需要收集的实时会话类型。  **约束限制**：  不涉及。  **取值范围**：  - slow：慢会话。 - active：活跃会话。 - total：会话总数。 - long：长事务会话。  **默认取值**：  total。
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        /// <summary>
        /// **参数解释**：  慢会话阈值，单位是秒。  **约束限制**：  不涉及。  **取值范围**：  1-86400。  **默认取值**：  10。
        /// </summary>
        [JsonProperty("slow_process_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? SlowProcessThreshold { get; set; }

        /// <summary>
        /// **参数解释**：  实时会话的用户。 获取方法请参见[查询数据库用户](https://support.huaweicloud.com/api-taurusdb/ListGaussMySqlDatabaseUser.html)。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// **参数解释**：  实时会话的主机。 获取方法请参见[查询数据库用户](https://support.huaweicloud.com/api-taurusdb/ListGaussMySqlDatabaseUser.html)。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// **参数解释**：  实时会话的数据库。 获取方法请参见[查询数据库用户](https://support.huaweicloud.com/api-taurusdb/ListGaussMySqlDatabaseUser.html)。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("db", NullValueHandling = NullValueHandling.Ignore)]
        public string Db { get; set; }

        /// <summary>
        /// **参数解释**：  实时会话的命令类型。  **约束限制**：  不涉及。  **取值范围**：  - Sleep：空闲连接，无任何操作。 - Query：正在执行查询。 - Connect：建立连接。 - Init DB：切换数据库。 - Field List：获取表字段列表。 - Processlist：查看会话列表。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public string Command { get; set; }

        /// <summary>
        /// **参数解释**：  实时会话的SQL语句。 您可以通过登录管理控制台，选择智能DBA助手下的实时会话，在会话列表中获取。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("sql_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlKey { get; set; }

        /// <summary>
        /// **参数解释**：  实时会话的排序列。  **约束限制**：  不涉及。  **取值范围**：  - id：会话ID。 - state_duration：状态持续时间。 - trx_executed_time：事务持续时间。 - trx_id：事务ID。 - trx_lock_duration：事务锁等待时长。 - trx_lock_rows：事务锁定行数。 - trx_lock_tables：事务锁定表数量。 - trx_update_rows：事务更新行数。  **默认取值**：  id。
        /// </summary>
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// **参数解释**：  实时会话的排序方向。  **约束限制**：  不涉及。  **取值范围**：  - desc：降序排列。 - asc：升序排列。  **默认取值**：  asc。
        /// </summary>
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDir { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealtimeSessionRequest {\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  slowProcessThreshold: ").Append(SlowProcessThreshold).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  host: ").Append(Host).Append("\n");
            sb.Append("  db: ").Append(Db).Append("\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  sqlKey: ").Append(SqlKey).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RealtimeSessionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RealtimeSessionRequest input)
        {
            if (input == null) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;
            if (this.SlowProcessThreshold != input.SlowProcessThreshold || (this.SlowProcessThreshold != null && !this.SlowProcessThreshold.Equals(input.SlowProcessThreshold))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.Host != input.Host || (this.Host != null && !this.Host.Equals(input.Host))) return false;
            if (this.Db != input.Db || (this.Db != null && !this.Db.Equals(input.Db))) return false;
            if (this.Command != input.Command || (this.Command != null && !this.Command.Equals(input.Command))) return false;
            if (this.SqlKey != input.SqlKey || (this.SqlKey != null && !this.SqlKey.Equals(input.SqlKey))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && !this.SortKey.Equals(input.SortKey))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && !this.SortDir.Equals(input.SortDir))) return false;

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
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.SlowProcessThreshold != null) hashCode = hashCode * 59 + this.SlowProcessThreshold.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Host != null) hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Db != null) hashCode = hashCode * 59 + this.Db.GetHashCode();
                if (this.Command != null) hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.SqlKey != null) hashCode = hashCode * 59 + this.SqlKey.GetHashCode();
                if (this.SortKey != null) hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.SortDir != null) hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                return hashCode;
            }
        }
    }
}
