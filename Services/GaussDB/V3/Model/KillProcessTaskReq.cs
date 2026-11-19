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
    /// **参数解释**：  Kill会话任务条件，条件各项之间是“与”的逻辑关系。  **约束限制**：  支持同时运行最多5个条件Kill任务。
    /// </summary>
    public class KillProcessTaskReq 
    {

        /// <summary>
        /// **参数解释**：  用户名。  **约束限制**：  不涉及。  **取值范围**：  1到32个字符之间，由字母、数字、中划线或下划线组成，不能包含其他特殊字符。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// **参数解释**：  主机。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// **参数解释**：  数据库名。  **约束限制**：  不涉及。  **取值范围**：  1到64个字符之间，由字母、数字、中划线或下划线组成，不能包含其他特殊字符。   **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("db", NullValueHandling = NullValueHandling.Ignore)]
        public string Db { get; set; }

        /// <summary>
        /// **参数解释**：  命令。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public string Command { get; set; }

        /// <summary>
        /// **参数解释**：  SQL语句。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public string Info { get; set; }

        /// <summary>
        /// **参数解释**：  持续时间，单位为秒。持续时间大于等于该值的会话满足Kill条件。  **约束限制**：  必须是整数。  **取值范围**：  1-2147483647。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// **参数解释**：  任务持续时间，单位为秒。  **约束限制**：  执行方式为auto时必填。  **取值范围**：  10-31535999。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**：  执行方式。  **约束限制**：  不涉及。  **取值范围**：  - auto：定时关闭，任务持续时长等于end_time参数值。 - manual：手动关闭。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KillProcessTaskReq {\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  host: ").Append(Host).Append("\n");
            sb.Append("  db: ").Append(Db).Append("\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  info: ").Append(Info).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KillProcessTaskReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KillProcessTaskReq input)
        {
            if (input == null) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.Host != input.Host || (this.Host != null && !this.Host.Equals(input.Host))) return false;
            if (this.Db != input.Db || (this.Db != null && !this.Db.Equals(input.Db))) return false;
            if (this.Command != input.Command || (this.Command != null && !this.Command.Equals(input.Command))) return false;
            if (this.Info != input.Info || (this.Info != null && !this.Info.Equals(input.Info))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;

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
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Host != null) hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Db != null) hashCode = hashCode * 59 + this.Db.GetHashCode();
                if (this.Command != null) hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Info != null) hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
