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
    /// 
    /// </summary>
    public class OneResourceGroupResp 
    {
        /// <summary>
        /// 资源添加/匹配方式，取值只能为EPS（匹配企业项目）,TAG（匹配标签）,NAME（匹配实例名称）, COMB（组合匹配）,Manual（手动添加）
        /// </summary>
        /// <value>资源添加/匹配方式，取值只能为EPS（匹配企业项目）,TAG（匹配标签）,NAME（匹配实例名称）, COMB（组合匹配）,Manual（手动添加）</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum EPS for value: EPS
            /// </summary>
            public static readonly TypeEnum EPS = new TypeEnum("EPS");

            /// <summary>
            /// Enum TAG for value: TAG
            /// </summary>
            public static readonly TypeEnum TAG = new TypeEnum("TAG");

            /// <summary>
            /// Enum NAME for value: NAME
            /// </summary>
            public static readonly TypeEnum NAME = new TypeEnum("NAME");

            /// <summary>
            /// Enum COMB for value: COMB
            /// </summary>
            public static readonly TypeEnum COMB = new TypeEnum("COMB");

            /// <summary>
            /// Enum MANUAL for value: Manual
            /// </summary>
            public static readonly TypeEnum MANUAL = new TypeEnum("Manual");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "EPS", EPS },
                { "TAG", TAG },
                { "NAME", NAME },
                { "COMB", COMB },
                { "Manual", MANUAL },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 指标告警状态，取值为health（告警中）、unhealthy（已触发）、no_alarm_rule（未设置告警规则）
        /// </summary>
        /// <value>指标告警状态，取值为health（告警中）、unhealthy（已触发）、no_alarm_rule（未设置告警规则）</value>
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
        /// 事件告警状态，取值为health（告警中）、unhealthy（已触发）、no_alarm_rule（未设置告警规则）
        /// </summary>
        /// <value>事件告警状态，取值为health（告警中）、unhealthy（已触发）、no_alarm_rule（未设置告警规则）</value>
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
        /// 资源分组的名称
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 资源分组ID，以rg开头，后跟22位由字母或数字组成的字符串
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 资源分组的创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 资源分组归属企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 资源添加/匹配方式，取值只能为EPS（匹配企业项目）,TAG（匹配标签）,NAME（匹配实例名称）, COMB（组合匹配）,Manual（手动添加）
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 指标告警状态，取值为health（告警中）、unhealthy（已触发）、no_alarm_rule（未设置告警规则）
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 事件告警状态，取值为health（告警中）、unhealthy（已触发）、no_alarm_rule（未设置告警规则）
        /// </summary>
        [JsonProperty("event_status", NullValueHandling = NullValueHandling.Ignore)]
        public EventStatusEnum EventStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public OneResourceGroupRespResourceStatistics ResourceStatistics { get; set; }

        /// <summary>
        /// 当资源匹配规则为匹配企业项目时，指定的企业项目列表
        /// </summary>
        [JsonProperty("related_ep_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RelatedEpIds { get; set; }

        /// <summary>
        /// 关联的告警模板列表
        /// </summary>
        [JsonProperty("association_alarm_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssociationAlarmTemplate> AssociationAlarmTemplates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OneResourceGroupResp {\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  eventStatus: ").Append(EventStatus).Append("\n");
            sb.Append("  resourceStatistics: ").Append(ResourceStatistics).Append("\n");
            sb.Append("  relatedEpIds: ").Append(RelatedEpIds).Append("\n");
            sb.Append("  associationAlarmTemplates: ").Append(AssociationAlarmTemplates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OneResourceGroupResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OneResourceGroupResp input)
        {
            if (input == null) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Type != input.Type) return false;
            if (this.Status != input.Status) return false;
            if (this.EventStatus != input.EventStatus) return false;
            if (this.ResourceStatistics != input.ResourceStatistics || (this.ResourceStatistics != null && !this.ResourceStatistics.Equals(input.ResourceStatistics))) return false;
            if (this.RelatedEpIds != input.RelatedEpIds || (this.RelatedEpIds != null && input.RelatedEpIds != null && !this.RelatedEpIds.SequenceEqual(input.RelatedEpIds))) return false;
            if (this.AssociationAlarmTemplates != input.AssociationAlarmTemplates || (this.AssociationAlarmTemplates != null && input.AssociationAlarmTemplates != null && !this.AssociationAlarmTemplates.SequenceEqual(input.AssociationAlarmTemplates))) return false;

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
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.EventStatus.GetHashCode();
                if (this.ResourceStatistics != null) hashCode = hashCode * 59 + this.ResourceStatistics.GetHashCode();
                if (this.RelatedEpIds != null) hashCode = hashCode * 59 + this.RelatedEpIds.GetHashCode();
                if (this.AssociationAlarmTemplates != null) hashCode = hashCode * 59 + this.AssociationAlarmTemplates.GetHashCode();
                return hashCode;
            }
        }
    }
}
