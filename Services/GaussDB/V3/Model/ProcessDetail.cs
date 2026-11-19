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
    public class ProcessDetail 
    {

        /// <summary>
        /// **参数解释**  会话ID。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// **参数解释**：  用户名。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// **参数解释**：    数据库名。    **取值范围**：    不涉及。
        /// </summary>
        [JsonProperty("db", NullValueHandling = NullValueHandling.Ignore)]
        public string Db { get; set; }

        /// <summary>
        /// **参数解释**：  执行状态。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释**：  命令。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public string Command { get; set; }

        /// <summary>
        /// **参数解释**：  SQL语句。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("sql_info", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlInfo { get; set; }

        /// <summary>
        /// **参数解释**：  状态持续时间，单位是秒。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("state_duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? StateDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessDetail {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  db: ").Append(Db).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  sqlInfo: ").Append(SqlInfo).Append("\n");
            sb.Append("  stateDuration: ").Append(StateDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProcessDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProcessDetail input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.Db != input.Db || (this.Db != null && !this.Db.Equals(input.Db))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Command != input.Command || (this.Command != null && !this.Command.Equals(input.Command))) return false;
            if (this.SqlInfo != input.SqlInfo || (this.SqlInfo != null && !this.SqlInfo.Equals(input.SqlInfo))) return false;
            if (this.StateDuration != input.StateDuration || (this.StateDuration != null && !this.StateDuration.Equals(input.StateDuration))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Db != null) hashCode = hashCode * 59 + this.Db.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Command != null) hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.SqlInfo != null) hashCode = hashCode * 59 + this.SqlInfo.GetHashCode();
                if (this.StateDuration != null) hashCode = hashCode * 59 + this.StateDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
