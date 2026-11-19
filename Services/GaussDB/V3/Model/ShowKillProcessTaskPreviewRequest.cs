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
    /// Request Object
    /// </summary>
    public class ShowKillProcessTaskPreviewRequest 
    {

        /// <summary>
        /// **参数解释**：              请求语言类型。  **约束限制**：  不涉及。  **取值范围**：  - en-us：英文。 - zh-cn：中文。  **默认取值**：  en-us。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// **参数解释**：  实例ID，此参数是实例的唯一标识。  获取方法请参见[查询实例列表](https://support.huaweicloud.com/api-taurusdb/ListGaussMySqlInstancesUnifyStatus.html)。  **约束限制**：  不涉及。  **取值范围**：  只能由英文字母、数字组成，后缀为in07，长度为36个字符。  **默认取值**：  不涉及。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：    持续时间，单位为秒。持续时间大于等于该值的会话满足Kill条件。  **约束限制**：    整数。  **取值范围**：    由数字组成，其中数字表示的范围应为1-2147483647。  **默认取值**：    不涉及。
        /// </summary>
        [SDKProperty("time", IsQuery = true)]
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// **参数解释**：  用户名。  **约束限制**：  不涉及。  **取值范围**：  名称在1到32个字符之间，由字母、数字、中划线或下划线组成，不能包含其他特殊字符。  **默认取值**：  不涉及。
        /// </summary>
        [SDKProperty("user", IsQuery = true)]
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// **参数解释**：    主机。    **约束限制**：    不涉及。    **取值范围**：    不涉及。  **默认取值**：    不涉及。
        /// </summary>
        [SDKProperty("host", IsQuery = true)]
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// **参数解释**：    数据库名。    **约束限制**：    不涉及。   **取值范围**：    1到64个字符之间，由字母、数字、中划线或下划线组成，不能包含其他特殊字符。   **默认取值**：    不涉及。
        /// </summary>
        [SDKProperty("db", IsQuery = true)]
        [JsonProperty("db", NullValueHandling = NullValueHandling.Ignore)]
        public string Db { get; set; }

        /// <summary>
        /// **参数解释**：    命令。    **约束限制**：    不涉及。    **取值范围**：    不涉及。  **默认取值**：    不涉及。
        /// </summary>
        [SDKProperty("command", IsQuery = true)]
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public string Command { get; set; }

        /// <summary>
        /// **参数解释**：    SQL语句。    **约束限制**：    不涉及。  **取值范围**：    不涉及。  **默认取值**：    不涉及。
        /// </summary>
        [SDKProperty("info", IsQuery = true)]
        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public string Info { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKillProcessTaskPreviewRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  host: ").Append(Host).Append("\n");
            sb.Append("  db: ").Append(Db).Append("\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  info: ").Append(Info).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKillProcessTaskPreviewRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKillProcessTaskPreviewRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.Host != input.Host || (this.Host != null && !this.Host.Equals(input.Host))) return false;
            if (this.Db != input.Db || (this.Db != null && !this.Db.Equals(input.Db))) return false;
            if (this.Command != input.Command || (this.Command != null && !this.Command.Equals(input.Command))) return false;
            if (this.Info != input.Info || (this.Info != null && !this.Info.Equals(input.Info))) return false;

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
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Host != null) hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Db != null) hashCode = hashCode * 59 + this.Db.GetHashCode();
                if (this.Command != null) hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Info != null) hashCode = hashCode * 59 + this.Info.GetHashCode();
                return hashCode;
            }
        }
    }
}
