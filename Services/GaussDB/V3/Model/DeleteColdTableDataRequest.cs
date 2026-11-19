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
    public class DeleteColdTableDataRequest 
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
        /// **参数解释**：  冷数据表空间ID。  获取方法请参见[查询冷表元信息](https://support.huaweicloud.com/api-taurusdb/ListColdTableMetas.html)。  **约束限制**：  不涉及。  **取值范围**：  只能由数字组成。  **默认取值**：  不涉及。
        /// </summary>
        [SDKProperty("space_id", IsPath = true)]
        [JsonProperty("space_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceId { get; set; }

        /// <summary>
        /// **参数解释**：  冷数据表ID。  获取方法请参见[查询冷表元信息](https://support.huaweicloud.com/api-taurusdb/ListColdTableMetas.html)。  **约束限制**：  不涉及。  **取值范围**：  只能由数字组成。  **默认取值**：  不涉及。
        /// </summary>
        [SDKProperty("dd_id", IsPath = true)]
        [JsonProperty("dd_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DdId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteColdTableDataRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  spaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  ddId: ").Append(DdId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteColdTableDataRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteColdTableDataRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.SpaceId != input.SpaceId || (this.SpaceId != null && !this.SpaceId.Equals(input.SpaceId))) return false;
            if (this.DdId != input.DdId || (this.DdId != null && !this.DdId.Equals(input.DdId))) return false;

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
                if (this.SpaceId != null) hashCode = hashCode * 59 + this.SpaceId.GetHashCode();
                if (this.DdId != null) hashCode = hashCode * 59 + this.DdId.GetHashCode();
                return hashCode;
            }
        }
    }
}
