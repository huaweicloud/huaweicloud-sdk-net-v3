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
    /// 查询任务存在性请求体
    /// </summary>
    public class CheckScheduleTaskExistRequestBody 
    {

        /// <summary>
        /// **参数解释**： 定时任务类型。  **约束限制**： 不涉及。  **取值范围**：   - PROXY_VERSION_UPGRADE：表示升级数据库代理的内核小版本。   - VERSION_UPGRADE：表示升级实例的内核小版本。   - RESIZE_FLAVOR：表示实例规格变更。   - REBOOT_NODE：表示重启节点。   - REBOOT_INSTANCE：表示重启实例。  **默认取值**：   不涉及。
        /// </summary>
        [JsonProperty("schedule_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// **参数解释**： 数据库代理ID。 获取方法请参见[查询数据库代理信息列表](https://support.huaweicloud.com/api-taurusdb/ShowGaussMySqlProxyList.html)。  **约束限制**： 不涉及。  **取值范围**： 不涉及。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("proxy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckScheduleTaskExistRequestBody {\n");
            sb.Append("  scheduleType: ").Append(ScheduleType).Append("\n");
            sb.Append("  proxyId: ").Append(ProxyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckScheduleTaskExistRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckScheduleTaskExistRequestBody input)
        {
            if (input == null) return false;
            if (this.ScheduleType != input.ScheduleType || (this.ScheduleType != null && !this.ScheduleType.Equals(input.ScheduleType))) return false;
            if (this.ProxyId != input.ProxyId || (this.ProxyId != null && !this.ProxyId.Equals(input.ProxyId))) return false;

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
                if (this.ScheduleType != null) hashCode = hashCode * 59 + this.ScheduleType.GetHashCode();
                if (this.ProxyId != null) hashCode = hashCode * 59 + this.ProxyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
