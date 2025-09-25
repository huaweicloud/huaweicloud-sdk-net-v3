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
    public class WaitEventQueryInfo 
    {

        /// <summary>
        /// **参数解释**: 数据库名称。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// **参数解释**: 用户名称。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**: 是否在等待状态。 **约束限制**: 不涉及。 **取值范围**: -t：是。 -f：否。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("waiting", NullValueHandling = NullValueHandling.Ignore)]
        public string Waiting { get; set; }

        /// <summary>
        /// **参数解释**: 会话ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionId { get; set; }

        /// <summary>
        /// **参数解释**: 阻塞当前会话的会话ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("block_session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockSessionId { get; set; }

        /// <summary>
        /// **参数解释**: 阻塞当前会话的会话数。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("block_count", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockCount { get; set; }

        /// <summary>
        /// **参数解释**: 唯一的SQL ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("unique_sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueSqlId { get; set; }

        /// <summary>
        /// **参数解释**: SQL查询ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryId { get; set; }

        /// <summary>
        /// **参数解释**: 该会话当前整体状态。 **约束限制**: 不涉及。 **取值范围**: -active：后台正在执行一个查询。 -idle：后台正在等待一个新的客户端命令。 -idle in transaction：后台在事务中，但事务中没有语句在执行。 -fastpath function call：后台正在执行一个fast-path函数。 -disabled：如果后台禁用track_activities，则事务显示此状态。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释**: 等待事件。 参见“开发指南 &gt; 系统表和系统视图 &gt; 系统视图 &gt; 其他系统视图 &gt; PG_THREAD_WAIT_STATUS”中的wait_event字段。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("wait_event", NullValueHandling = NullValueHandling.Ignore)]
        public string WaitEvent { get; set; }

        /// <summary>
        /// **参数解释**: 等待状态。 参见“开发指南 &gt; 系统表和系统视图 &gt; 系统视图 &gt; 其他系统视图 &gt; PG_THREAD_WAIT_STATUS”中的wait_status列表。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("wait_status", NullValueHandling = NullValueHandling.Ignore)]
        public string WaitStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitEventQueryInfo {\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  waiting: ").Append(Waiting).Append("\n");
            sb.Append("  sessionId: ").Append(SessionId).Append("\n");
            sb.Append("  blockSessionId: ").Append(BlockSessionId).Append("\n");
            sb.Append("  blockCount: ").Append(BlockCount).Append("\n");
            sb.Append("  uniqueSqlId: ").Append(UniqueSqlId).Append("\n");
            sb.Append("  queryId: ").Append(QueryId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  waitEvent: ").Append(WaitEvent).Append("\n");
            sb.Append("  waitStatus: ").Append(WaitStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WaitEventQueryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WaitEventQueryInfo input)
        {
            if (input == null) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.Waiting != input.Waiting || (this.Waiting != null && !this.Waiting.Equals(input.Waiting))) return false;
            if (this.SessionId != input.SessionId || (this.SessionId != null && !this.SessionId.Equals(input.SessionId))) return false;
            if (this.BlockSessionId != input.BlockSessionId || (this.BlockSessionId != null && !this.BlockSessionId.Equals(input.BlockSessionId))) return false;
            if (this.BlockCount != input.BlockCount || (this.BlockCount != null && !this.BlockCount.Equals(input.BlockCount))) return false;
            if (this.UniqueSqlId != input.UniqueSqlId || (this.UniqueSqlId != null && !this.UniqueSqlId.Equals(input.UniqueSqlId))) return false;
            if (this.QueryId != input.QueryId || (this.QueryId != null && !this.QueryId.Equals(input.QueryId))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.WaitEvent != input.WaitEvent || (this.WaitEvent != null && !this.WaitEvent.Equals(input.WaitEvent))) return false;
            if (this.WaitStatus != input.WaitStatus || (this.WaitStatus != null && !this.WaitStatus.Equals(input.WaitStatus))) return false;

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
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Waiting != null) hashCode = hashCode * 59 + this.Waiting.GetHashCode();
                if (this.SessionId != null) hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.BlockSessionId != null) hashCode = hashCode * 59 + this.BlockSessionId.GetHashCode();
                if (this.BlockCount != null) hashCode = hashCode * 59 + this.BlockCount.GetHashCode();
                if (this.UniqueSqlId != null) hashCode = hashCode * 59 + this.UniqueSqlId.GetHashCode();
                if (this.QueryId != null) hashCode = hashCode * 59 + this.QueryId.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.WaitEvent != null) hashCode = hashCode * 59 + this.WaitEvent.GetHashCode();
                if (this.WaitStatus != null) hashCode = hashCode * 59 + this.WaitStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
