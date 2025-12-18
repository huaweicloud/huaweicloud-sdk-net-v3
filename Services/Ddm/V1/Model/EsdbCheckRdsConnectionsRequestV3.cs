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
    /// 请求体
    /// </summary>
    public class EsdbCheckRdsConnectionsRequestV3 
    {

        /// <summary>
        /// **参数解释**：  实例ID，此参数是实例的唯一标识。  **约束限制**：  不涉及。  **取值范围**：  只能由英文字母、数字组成，后缀为in09，长度为36个字符。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  rds连通性检查相关信息的集合。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<EsdbCheckRdsConnectionRequestV3> Infos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EsdbCheckRdsConnectionsRequestV3 {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  infos: ").Append(Infos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EsdbCheckRdsConnectionsRequestV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EsdbCheckRdsConnectionsRequestV3 input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Infos != input.Infos || (this.Infos != null && input.Infos != null && !this.Infos.SequenceEqual(input.Infos))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Infos != null) hashCode = hashCode * 59 + this.Infos.GetHashCode();
                return hashCode;
            }
        }
    }
}
