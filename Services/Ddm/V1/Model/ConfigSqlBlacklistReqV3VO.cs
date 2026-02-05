using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigSqlBlacklistReqV3VO 
    {

        /// <summary>
        /// **参数解释**：  全量匹配sql黑名单。  **约束限制**：  不涉及  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("sql_black_list_full_check", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlBlackListFullCheck { get; set; }

        /// <summary>
        /// **参数解释**：  请求ID。  **约束限制**：  不涉及  **取值范围**：  只能由英文字母、数字组成。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// **参数解释**：  租户在某一Region下的project ID。  获取方法请参见[获取项目ID](https://support.huaweicloud.com/api-ddm/ddm_api_01_0063.html)。  **约束限制**：  不涉及。  **取值范围**：  只能由英文字母、数字组成，且长度为32个字符。  **默认取值**：  不涉及。 
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**：  实例ID，此参数是实例的唯一标识。  **约束限制**：  不涉及。  **取值范围**：  只能由英文字母、数字组成，后缀为in09，长度为36个字符。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  逻辑库名称。  **约束限制**：  不涉及  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("logic_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogicDbName { get; set; }

        /// <summary>
        /// **参数解释**：  前缀匹配sql黑名单。  **约束限制**：  不涉及  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("sql_black_list_prefix_check", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlBlackListPrefixCheck { get; set; }

        /// <summary>
        /// **参数解释**：  正则匹配sql黑名单。  **约束限制**：  不涉及  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("sql_black_list_regex_check", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlBlackListRegexCheck { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigSqlBlacklistReqV3VO {\n");
            sb.Append("  sqlBlackListFullCheck: ").Append(SqlBlackListFullCheck).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  logicDbName: ").Append(LogicDbName).Append("\n");
            sb.Append("  sqlBlackListPrefixCheck: ").Append(SqlBlackListPrefixCheck).Append("\n");
            sb.Append("  sqlBlackListRegexCheck: ").Append(SqlBlackListRegexCheck).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigSqlBlacklistReqV3VO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigSqlBlacklistReqV3VO input)
        {
            if (input == null) return false;
            if (this.SqlBlackListFullCheck != input.SqlBlackListFullCheck || (this.SqlBlackListFullCheck != null && !this.SqlBlackListFullCheck.Equals(input.SqlBlackListFullCheck))) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.LogicDbName != input.LogicDbName || (this.LogicDbName != null && !this.LogicDbName.Equals(input.LogicDbName))) return false;
            if (this.SqlBlackListPrefixCheck != input.SqlBlackListPrefixCheck || (this.SqlBlackListPrefixCheck != null && !this.SqlBlackListPrefixCheck.Equals(input.SqlBlackListPrefixCheck))) return false;
            if (this.SqlBlackListRegexCheck != input.SqlBlackListRegexCheck || (this.SqlBlackListRegexCheck != null && !this.SqlBlackListRegexCheck.Equals(input.SqlBlackListRegexCheck))) return false;

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
                if (this.SqlBlackListFullCheck != null) hashCode = hashCode * 59 + this.SqlBlackListFullCheck.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.LogicDbName != null) hashCode = hashCode * 59 + this.LogicDbName.GetHashCode();
                if (this.SqlBlackListPrefixCheck != null) hashCode = hashCode * 59 + this.SqlBlackListPrefixCheck.GetHashCode();
                if (this.SqlBlackListRegexCheck != null) hashCode = hashCode * 59 + this.SqlBlackListRegexCheck.GetHashCode();
                return hashCode;
            }
        }
    }
}
