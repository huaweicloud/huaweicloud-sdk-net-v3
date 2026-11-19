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
    public class KillProcessHistoryItem 
    {

        /// <summary>
        /// **参数解释**：  自动Kill会话任务ID。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// **参数解释**：  会话ID。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionId { get; set; }

        /// <summary>
        /// **参数解释**：  Kill会话的时间戳。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("kill_time", NullValueHandling = NullValueHandling.Ignore)]
        public string KillTime { get; set; }

        /// <summary>
        /// **参数解释**：  Kill会话方式。  **取值范围**：  - once：一键Kill会话。 - condition：条件Kill会话。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// **参数解释**：  用户。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// **参数解释**：  主机。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// **参数解释**：  数据库名。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("db", NullValueHandling = NullValueHandling.Ignore)]
        public string Db { get; set; }

        /// <summary>
        /// **参数解释**：  命令。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public string Command { get; set; }

        /// <summary>
        /// **参数解释**：  会话持续时间，单位是秒。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// **参数解释**：  SQL语句。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public string Info { get; set; }

        /// <summary>
        /// **参数解释**：  执行状态。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释**：  实例ID。  **取值范围**：  只能由英文字母、数字组成，后缀为in07，长度为36个字符。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  节点ID。  **取值范围**：  只能由英文字母、数字组成，后缀为no07，长度为36个字符。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KillProcessHistoryItem {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  sessionId: ").Append(SessionId).Append("\n");
            sb.Append("  killTime: ").Append(KillTime).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  host: ").Append(Host).Append("\n");
            sb.Append("  db: ").Append(Db).Append("\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  info: ").Append(Info).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KillProcessHistoryItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KillProcessHistoryItem input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.SessionId != input.SessionId || (this.SessionId != null && !this.SessionId.Equals(input.SessionId))) return false;
            if (this.KillTime != input.KillTime || (this.KillTime != null && !this.KillTime.Equals(input.KillTime))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.Host != input.Host || (this.Host != null && !this.Host.Equals(input.Host))) return false;
            if (this.Db != input.Db || (this.Db != null && !this.Db.Equals(input.Db))) return false;
            if (this.Command != input.Command || (this.Command != null && !this.Command.Equals(input.Command))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.Info != input.Info || (this.Info != null && !this.Info.Equals(input.Info))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.SessionId != null) hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.KillTime != null) hashCode = hashCode * 59 + this.KillTime.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Host != null) hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Db != null) hashCode = hashCode * 59 + this.Db.GetHashCode();
                if (this.Command != null) hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Info != null) hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
