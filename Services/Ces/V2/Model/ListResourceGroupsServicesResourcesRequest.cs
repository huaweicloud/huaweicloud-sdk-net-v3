using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListResourceGroupsServicesResourcesRequest 
    {
        /// <summary>
        /// **参数解释** 告警规则按状态信息进行过滤。 **约束限制**： 不涉及。 **取值范围** 枚举值。 - health: 已设置告警规则且无告警触发的资源 - unhealthy: 已设置告警规则且有告警触发的资源 - no_alarm_rule: 未设置告警规则的资源 **默认取值**： 不涉及。 
        /// </summary>
        /// <value>**参数解释** 告警规则按状态信息进行过滤。 **约束限制**： 不涉及。 **取值范围** 枚举值。 - health: 已设置告警规则且无告警触发的资源 - unhealthy: 已设置告警规则且有告警触发的资源 - no_alarm_rule: 未设置告警规则的资源 **默认取值**： 不涉及。 </value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum HEALTH for value: health
            /// </summary>
            public static readonly StatusEnum HEALTH = new StatusEnum("health");

            /// <summary>
            /// Enum UNHEALTHY for value: unhealthy
            /// </summary>
            public static readonly StatusEnum UNHEALTHY = new StatusEnum("unhealthy");

            /// <summary>
            /// Enum NO_ALARM_RULE for value: no_alarm_rule
            /// </summary>
            public static readonly StatusEnum NO_ALARM_RULE = new StatusEnum("no_alarm_rule");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "health", HEALTH },
                { "unhealthy", UNHEALTHY },
                { "no_alarm_rule", NO_ALARM_RULE },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释** 按事件告警状态信息进行过滤。 **约束限制**： 不涉及。 **取值范围** 枚举值。 - health: 已设置事件告警规则且无事件告警触发的资源 - unhealthy: 已设置事件告警规则且有事件告警触发的资源 - no_alarm_rule: 未设置事件告警规则的资源 **默认取值**： 不涉及。 
        /// </summary>
        /// <value>**参数解释** 按事件告警状态信息进行过滤。 **约束限制**： 不涉及。 **取值范围** 枚举值。 - health: 已设置事件告警规则且无事件告警触发的资源 - unhealthy: 已设置事件告警规则且有事件告警触发的资源 - no_alarm_rule: 未设置事件告警规则的资源 **默认取值**： 不涉及。 </value>
        [JsonConverter(typeof(EnumClassConverter<EventStatusEnum>))]
        public class EventStatusEnum
        {
            /// <summary>
            /// Enum HEALTH for value: health
            /// </summary>
            public static readonly EventStatusEnum HEALTH = new EventStatusEnum("health");

            /// <summary>
            /// Enum UNHEALTHY for value: unhealthy
            /// </summary>
            public static readonly EventStatusEnum UNHEALTHY = new EventStatusEnum("unhealthy");

            /// <summary>
            /// Enum NO_ALARM_RULE for value: no_alarm_rule
            /// </summary>
            public static readonly EventStatusEnum NO_ALARM_RULE = new EventStatusEnum("no_alarm_rule");

            private static readonly Dictionary<string, EventStatusEnum> StaticFields =
            new Dictionary<string, EventStatusEnum>()
            {
                { "health", HEALTH },
                { "unhealthy", UNHEALTHY },
                { "no_alarm_rule", NO_ALARM_RULE },
            };

            private string _value;

            public EventStatusEnum()
            {

            }

            public EventStatusEnum(string value)
            {
                _value = value;
            }

            public static EventStatusEnum FromValue(string value)
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

                if (this.Equals(obj as EventStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EventStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EventStatusEnum a, EventStatusEnum b)
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

            public static bool operator !=(EventStatusEnum a, EventStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 分页偏移量 **约束限制**： 不涉及 **取值范围**： 整数，[0,10000] **默认取值**： 0 
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释**： 分页大小。 **约束限制**： 不涉及。 **取值范围**： 大小为1-100。 **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// **参数解释** 资源分组ID。 **约束限制** 不涉及 **取值范围** 以\&quot;rg\&quot;开头，后面跟着22个字母或数字 **默认取值** 不涉及 
        /// </summary>
        [SDKProperty("group_id", IsPath = true)]
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// **参数解释** 服务类别，如SYS.ECS **约束限制** 不涉及 **取值范围** 格式为service.item；service和item必须是字符串，必须以字母开头，只能包含0-9/a-z/A-Z/_。字符串的长度在 [3,32]个字符之间 **默认取值** 不涉及
        /// </summary>
        [SDKProperty("service", IsPath = true)]
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }

        /// <summary>
        /// **参数解释**： 资源维度。 **约束限制**： 不涉及。 **取值范围**： 多维度用\&quot;,\&quot;分割，只能包含0-9、a-z、A-Z、_、-、#、/、(、），每个维度的最大长度为32。字符串总长度最小为1，最大为131。 **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("dim_name", IsQuery = true)]
        [JsonProperty("dim_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DimName { get; set; }

        /// <summary>
        /// **参数解释** 告警规则按状态信息进行过滤。 **约束限制**： 不涉及。 **取值范围** 枚举值。 - health: 已设置告警规则且无告警触发的资源 - unhealthy: 已设置告警规则且有告警触发的资源 - no_alarm_rule: 未设置告警规则的资源 **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数描述**： 资源维度值，不支持模糊匹配，但是多维度资源可以只指定一个维度值 **约束限制**： 不涉及。  **取值范围**： 字符串长度范围[1,1027] **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("dim_value", IsQuery = true)]
        [JsonProperty("dim_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DimValue { get; set; }

        /// <summary>
        /// **参数描述**： 资源的标签信息，格式：\&quot;[key]\&quot;:\&quot;[value]\&quot;，样例参考：\&quot;ssss\&quot;:\&quot;1111\&quot; **约束限制**： 不涉及。  **取值范围**： 字符串长度范围[0,500] **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("tag", IsQuery = true)]
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// **参数解释** 企业项目ID。 **约束限制** 不涉及。 **取值范围** 由数字、字母和-组成，字符串长度范围[1,128] **默认取值** 不涉及。 
        /// </summary>
        [SDKProperty("extend_relation_id", IsQuery = true)]
        [JsonProperty("extend_relation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendRelationId { get; set; }

        /// <summary>
        /// **参数解释**： 资源所属的云产品名称，一般由\&quot;服务命名空间,服务首层维度名称\&quot;组成，如\&quot;SYS.ECS,instance_id\&quot;。 **约束限制**： 不涉及。 **取值范围**： 长度为[0,128]个字符。        **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("product_name", IsQuery = true)]
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// **参数解释** 资源名称 **约束限制** 不涉及 **取值范围** 长度[1,128]个字符 **默认取值** 不涉及 
        /// </summary>
        [SDKProperty("resource_name", IsQuery = true)]
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// **参数解释** 按事件告警状态信息进行过滤。 **约束限制**： 不涉及。 **取值范围** 枚举值。 - health: 已设置事件告警规则且无事件告警触发的资源 - unhealthy: 已设置事件告警规则且有事件告警触发的资源 - no_alarm_rule: 未设置事件告警规则的资源 **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("event_status", IsQuery = true)]
        [JsonProperty("event_status", NullValueHandling = NullValueHandling.Ignore)]
        public EventStatusEnum EventStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResourceGroupsServicesResourcesRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  service: ").Append(Service).Append("\n");
            sb.Append("  dimName: ").Append(DimName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  dimValue: ").Append(DimValue).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  extendRelationId: ").Append(ExtendRelationId).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  eventStatus: ").Append(EventStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResourceGroupsServicesResourcesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourceGroupsServicesResourcesRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.Service != input.Service || (this.Service != null && !this.Service.Equals(input.Service))) return false;
            if (this.DimName != input.DimName || (this.DimName != null && !this.DimName.Equals(input.DimName))) return false;
            if (this.Status != input.Status) return false;
            if (this.DimValue != input.DimValue || (this.DimValue != null && !this.DimValue.Equals(input.DimValue))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.ExtendRelationId != input.ExtendRelationId || (this.ExtendRelationId != null && !this.ExtendRelationId.Equals(input.ExtendRelationId))) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.EventStatus != input.EventStatus) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Service != null) hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.DimName != null) hashCode = hashCode * 59 + this.DimName.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DimValue != null) hashCode = hashCode * 59 + this.DimValue.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.ExtendRelationId != null) hashCode = hashCode * 59 + this.ExtendRelationId.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                hashCode = hashCode * 59 + this.EventStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
