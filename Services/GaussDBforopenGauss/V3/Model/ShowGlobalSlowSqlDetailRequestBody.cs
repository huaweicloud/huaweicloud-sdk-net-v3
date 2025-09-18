using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowGlobalSlowSqlDetailRequestBody 
    {
        /// <summary>
        /// **参数解释**: 组件类型。 **约束限制**: 不涉及。 **取值范围**: - cn：CN组件类型。 - dn：DN组件类型。  **默认取值**: 不涉及。
        /// </summary>
        /// <value>**参数解释**: 组件类型。 **约束限制**: 不涉及。 **取值范围**: - cn：CN组件类型。 - dn：DN组件类型。  **默认取值**: 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<ComponentTypeEnum>))]
        public class ComponentTypeEnum
        {
            /// <summary>
            /// Enum CN for value: cn
            /// </summary>
            public static readonly ComponentTypeEnum CN = new ComponentTypeEnum("cn");

            /// <summary>
            /// Enum DN for value: dn
            /// </summary>
            public static readonly ComponentTypeEnum DN = new ComponentTypeEnum("dn");

            private static readonly Dictionary<string, ComponentTypeEnum> StaticFields =
            new Dictionary<string, ComponentTypeEnum>()
            {
                { "cn", CN },
                { "dn", DN },
            };

            private string _value;

            public ComponentTypeEnum()
            {

            }

            public ComponentTypeEnum(string value)
            {
                _value = value;
            }

            public static ComponentTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ComponentTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ComponentTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ComponentTypeEnum a, ComponentTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ComponentTypeEnum a, ComponentTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 实例ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**: 节点ID列表。 **约束限制**: 节点ID数组不能为空。
        /// </summary>
        [JsonProperty("node_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// **参数解释**: 起始日期。 **约束限制**: 13位UNIX时间戳格式，单位是毫秒，时区是UTC。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// **参数解释**: 结束日期。 **约束限制**: 13位UNIX时间戳格式，单位是毫秒，时区是UTC。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// **参数解释**: 慢SQL的SQL ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlId { get; set; }

        /// <summary>
        /// **参数解释**: 组件类型。 **约束限制**: 不涉及。 **取值范围**: - cn：CN组件类型。 - dn：DN组件类型。  **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("component_type", NullValueHandling = NullValueHandling.Ignore)]
        public ComponentTypeEnum ComponentType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGlobalSlowSqlDetailRequestBody {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  nodeIds: ").Append(NodeIds).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  sqlId: ").Append(SqlId).Append("\n");
            sb.Append("  componentType: ").Append(ComponentType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGlobalSlowSqlDetailRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGlobalSlowSqlDetailRequestBody input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.NodeIds != input.NodeIds || (this.NodeIds != null && input.NodeIds != null && !this.NodeIds.SequenceEqual(input.NodeIds))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.SqlId != input.SqlId || (this.SqlId != null && !this.SqlId.Equals(input.SqlId))) return false;
            if (this.ComponentType != input.ComponentType) return false;

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
                if (this.NodeIds != null) hashCode = hashCode * 59 + this.NodeIds.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.SqlId != null) hashCode = hashCode * 59 + this.SqlId.GetHashCode();
                hashCode = hashCode * 59 + this.ComponentType.GetHashCode();
                return hashCode;
            }
        }
    }
}
