using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBackupRetainPolicyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  实例id  **约束限制**  不涉及  **取值范围**  不涉及  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  实例名字  **约束限制**  不涉及  **取值范围**  不涉及  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：  引擎类型  **约束限制**  不涉及  **取值范围**  不涉及  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// **参数解释**：  实例引擎版本  **约束限制**  不涉及  **取值范围**  不涉及  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// **参数解释**：  实例删除时间  **约束限制**  不涉及  **取值范围**  不涉及  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("instance_delete_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? InstanceDeleteTime { get; set; }

        /// <summary>
        /// **参数解释**  自动备份保留策略。NONE不保留，LAST保留最后一个，ALL全部保留。  **约束限制**  不涉及  **取值范围**  NONE、LAST、ALL  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("auto", NullValueHandling = NullValueHandling.Ignore)]
        public string Auto { get; set; }

        /// <summary>
        /// **参数解释**  手动备份保留策略。NONE不保留，LAST保留最后一个，ALL全部保留。  **约束限制**  不涉及  **取值范围**  NONE、LAST、ALL  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("manual", NullValueHandling = NullValueHandling.Ignore)]
        public string Manual { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBackupRetainPolicyResponse {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  instanceDeleteTime: ").Append(InstanceDeleteTime).Append("\n");
            sb.Append("  auto: ").Append(Auto).Append("\n");
            sb.Append("  manual: ").Append(Manual).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBackupRetainPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBackupRetainPolicyResponse input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.EngineName != input.EngineName || (this.EngineName != null && !this.EngineName.Equals(input.EngineName))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.InstanceDeleteTime != input.InstanceDeleteTime || (this.InstanceDeleteTime != null && !this.InstanceDeleteTime.Equals(input.InstanceDeleteTime))) return false;
            if (this.Auto != input.Auto || (this.Auto != null && !this.Auto.Equals(input.Auto))) return false;
            if (this.Manual != input.Manual || (this.Manual != null && !this.Manual.Equals(input.Manual))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EngineName != null) hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.InstanceDeleteTime != null) hashCode = hashCode * 59 + this.InstanceDeleteTime.GetHashCode();
                if (this.Auto != null) hashCode = hashCode * 59 + this.Auto.GetHashCode();
                if (this.Manual != null) hashCode = hashCode * 59 + this.Manual.GetHashCode();
                return hashCode;
            }
        }
    }
}
