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
    /// 
    /// </summary>
    public class LockRootCause 
    {

        /// <summary>
        /// **参数解释**： 被锁会话ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("locked_pid", NullValueHandling = NullValueHandling.Ignore)]
        public long? LockedPid { get; set; }

        /// <summary>
        /// **参数解释**： 被锁会话当前执行的SQL。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("locked_sql", NullValueHandling = NullValueHandling.Ignore)]
        public string LockedSql { get; set; }

        /// <summary>
        /// **参数解释**： 等待持续时间（秒）。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("wait_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public long? WaitSeconds { get; set; }

        /// <summary>
        /// **参数解释**： 锁所在数据库。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("lock_db", NullValueHandling = NullValueHandling.Ignore)]
        public string LockDb { get; set; }

        /// <summary>
        /// **参数解释**： 锁所在表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("lock_table", NullValueHandling = NullValueHandling.Ignore)]
        public string LockTable { get; set; }

        /// <summary>
        /// **参数解释**： 锁所在索引。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("lock_index", NullValueHandling = NullValueHandling.Ignore)]
        public string LockIndex { get; set; }

        /// <summary>
        /// **参数解释**： 锁模式。 **取值范围**： - IX：表级排他锁。 - X,REC_NOT_GAP：排他记录锁。 - X,GAP：间隙锁。 - X：行级排他锁。 
        /// </summary>
        [JsonProperty("lock_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string LockMode { get; set; }

        /// <summary>
        /// **参数解释**： 锁住的具体数据行的标识。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("lock_data", NullValueHandling = NullValueHandling.Ignore)]
        public string LockData { get; set; }

        /// <summary>
        /// **参数解释**： 阻塞源会话ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("blocker_pid", NullValueHandling = NullValueHandling.Ignore)]
        public long? BlockerPid { get; set; }

        /// <summary>
        /// **参数解释**： 阻塞源事务状态。 **取值范围**： - RUNNING：运行中。 - LOCK WAIT：锁等待。 - ROLLING BACK：回滚中。 - COMMITTING：提交中。 
        /// </summary>
        [JsonProperty("blocker_state", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockerState { get; set; }

        /// <summary>
        /// **参数解释**： 阻塞源事务持续时间（秒）。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("blocker_age", NullValueHandling = NullValueHandling.Ignore)]
        public int? BlockerAge { get; set; }

        /// <summary>
        /// **参数解释**： 阻塞源锁定的行数。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("blocker_rows_locked", NullValueHandling = NullValueHandling.Ignore)]
        public long? BlockerRowsLocked { get; set; }

        /// <summary>
        /// **参数解释**： 阻塞源修改的行数。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("blocker_rows_modified", NullValueHandling = NullValueHandling.Ignore)]
        public long? BlockerRowsModified { get; set; }

        /// <summary>
        /// **参数解释**： 阻塞源当前执行的SQL列表。 
        /// </summary>
        [JsonProperty("blocker_current_sql", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BlockerCurrentSql { get; set; }

        /// <summary>
        /// **参数解释**： 阻塞源主机。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("blocker_host", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockerHost { get; set; }

        /// <summary>
        /// **参数解释**： 阻塞源命令。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("blocker_command", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockerCommand { get; set; }

        /// <summary>
        /// **参数解释**： 阻塞源线程ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("blocker_thread_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BlockerThreadId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LockRootCause {\n");
            sb.Append("  lockedPid: ").Append(LockedPid).Append("\n");
            sb.Append("  lockedSql: ").Append(LockedSql).Append("\n");
            sb.Append("  waitSeconds: ").Append(WaitSeconds).Append("\n");
            sb.Append("  lockDb: ").Append(LockDb).Append("\n");
            sb.Append("  lockTable: ").Append(LockTable).Append("\n");
            sb.Append("  lockIndex: ").Append(LockIndex).Append("\n");
            sb.Append("  lockMode: ").Append(LockMode).Append("\n");
            sb.Append("  lockData: ").Append(LockData).Append("\n");
            sb.Append("  blockerPid: ").Append(BlockerPid).Append("\n");
            sb.Append("  blockerState: ").Append(BlockerState).Append("\n");
            sb.Append("  blockerAge: ").Append(BlockerAge).Append("\n");
            sb.Append("  blockerRowsLocked: ").Append(BlockerRowsLocked).Append("\n");
            sb.Append("  blockerRowsModified: ").Append(BlockerRowsModified).Append("\n");
            sb.Append("  blockerCurrentSql: ").Append(BlockerCurrentSql).Append("\n");
            sb.Append("  blockerHost: ").Append(BlockerHost).Append("\n");
            sb.Append("  blockerCommand: ").Append(BlockerCommand).Append("\n");
            sb.Append("  blockerThreadId: ").Append(BlockerThreadId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LockRootCause);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LockRootCause input)
        {
            if (input == null) return false;
            if (this.LockedPid != input.LockedPid || (this.LockedPid != null && !this.LockedPid.Equals(input.LockedPid))) return false;
            if (this.LockedSql != input.LockedSql || (this.LockedSql != null && !this.LockedSql.Equals(input.LockedSql))) return false;
            if (this.WaitSeconds != input.WaitSeconds || (this.WaitSeconds != null && !this.WaitSeconds.Equals(input.WaitSeconds))) return false;
            if (this.LockDb != input.LockDb || (this.LockDb != null && !this.LockDb.Equals(input.LockDb))) return false;
            if (this.LockTable != input.LockTable || (this.LockTable != null && !this.LockTable.Equals(input.LockTable))) return false;
            if (this.LockIndex != input.LockIndex || (this.LockIndex != null && !this.LockIndex.Equals(input.LockIndex))) return false;
            if (this.LockMode != input.LockMode || (this.LockMode != null && !this.LockMode.Equals(input.LockMode))) return false;
            if (this.LockData != input.LockData || (this.LockData != null && !this.LockData.Equals(input.LockData))) return false;
            if (this.BlockerPid != input.BlockerPid || (this.BlockerPid != null && !this.BlockerPid.Equals(input.BlockerPid))) return false;
            if (this.BlockerState != input.BlockerState || (this.BlockerState != null && !this.BlockerState.Equals(input.BlockerState))) return false;
            if (this.BlockerAge != input.BlockerAge || (this.BlockerAge != null && !this.BlockerAge.Equals(input.BlockerAge))) return false;
            if (this.BlockerRowsLocked != input.BlockerRowsLocked || (this.BlockerRowsLocked != null && !this.BlockerRowsLocked.Equals(input.BlockerRowsLocked))) return false;
            if (this.BlockerRowsModified != input.BlockerRowsModified || (this.BlockerRowsModified != null && !this.BlockerRowsModified.Equals(input.BlockerRowsModified))) return false;
            if (this.BlockerCurrentSql != input.BlockerCurrentSql || (this.BlockerCurrentSql != null && input.BlockerCurrentSql != null && !this.BlockerCurrentSql.SequenceEqual(input.BlockerCurrentSql))) return false;
            if (this.BlockerHost != input.BlockerHost || (this.BlockerHost != null && !this.BlockerHost.Equals(input.BlockerHost))) return false;
            if (this.BlockerCommand != input.BlockerCommand || (this.BlockerCommand != null && !this.BlockerCommand.Equals(input.BlockerCommand))) return false;
            if (this.BlockerThreadId != input.BlockerThreadId || (this.BlockerThreadId != null && !this.BlockerThreadId.Equals(input.BlockerThreadId))) return false;

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
                if (this.LockedPid != null) hashCode = hashCode * 59 + this.LockedPid.GetHashCode();
                if (this.LockedSql != null) hashCode = hashCode * 59 + this.LockedSql.GetHashCode();
                if (this.WaitSeconds != null) hashCode = hashCode * 59 + this.WaitSeconds.GetHashCode();
                if (this.LockDb != null) hashCode = hashCode * 59 + this.LockDb.GetHashCode();
                if (this.LockTable != null) hashCode = hashCode * 59 + this.LockTable.GetHashCode();
                if (this.LockIndex != null) hashCode = hashCode * 59 + this.LockIndex.GetHashCode();
                if (this.LockMode != null) hashCode = hashCode * 59 + this.LockMode.GetHashCode();
                if (this.LockData != null) hashCode = hashCode * 59 + this.LockData.GetHashCode();
                if (this.BlockerPid != null) hashCode = hashCode * 59 + this.BlockerPid.GetHashCode();
                if (this.BlockerState != null) hashCode = hashCode * 59 + this.BlockerState.GetHashCode();
                if (this.BlockerAge != null) hashCode = hashCode * 59 + this.BlockerAge.GetHashCode();
                if (this.BlockerRowsLocked != null) hashCode = hashCode * 59 + this.BlockerRowsLocked.GetHashCode();
                if (this.BlockerRowsModified != null) hashCode = hashCode * 59 + this.BlockerRowsModified.GetHashCode();
                if (this.BlockerCurrentSql != null) hashCode = hashCode * 59 + this.BlockerCurrentSql.GetHashCode();
                if (this.BlockerHost != null) hashCode = hashCode * 59 + this.BlockerHost.GetHashCode();
                if (this.BlockerCommand != null) hashCode = hashCode * 59 + this.BlockerCommand.GetHashCode();
                if (this.BlockerThreadId != null) hashCode = hashCode * 59 + this.BlockerThreadId.GetHashCode();
                return hashCode;
            }
        }
    }
}
