using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EventItemDetail 
    {
        /// <summary>
        /// 事件状态。  枚举类型：normal\\warning\\incident
        /// </summary>
        /// <value>事件状态。  枚举类型：normal\\warning\\incident</value>
        [JsonConverter(typeof(EnumClassConverter<EventStateEnum>))]
        public class EventStateEnum
        {
            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly EventStateEnum NORMAL = new EventStateEnum("normal");

            /// <summary>
            /// Enum WARNING for value: warning
            /// </summary>
            public static readonly EventStateEnum WARNING = new EventStateEnum("warning");

            /// <summary>
            /// Enum INCIDENT for value: incident
            /// </summary>
            public static readonly EventStateEnum INCIDENT = new EventStateEnum("incident");

            private static readonly Dictionary<string, EventStateEnum> StaticFields =
            new Dictionary<string, EventStateEnum>()
            {
                { "normal", NORMAL },
                { "warning", WARNING },
                { "incident", INCIDENT },
            };

            private string Value;

            public EventStateEnum(string value)
            {
                Value = value;
            }

            public static EventStateEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as EventStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EventStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(EventStateEnum a, EventStateEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(EventStateEnum a, EventStateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 事件级别。  枚举类型：Critical, Major, Minor, Info
        /// </summary>
        /// <value>事件级别。  枚举类型：Critical, Major, Minor, Info</value>
        [JsonConverter(typeof(EnumClassConverter<EventLevelEnum>))]
        public class EventLevelEnum
        {
            /// <summary>
            /// Enum CRITICAL for value: Critical
            /// </summary>
            public static readonly EventLevelEnum CRITICAL = new EventLevelEnum("Critical");

            /// <summary>
            /// Enum MAJOR for value: Major
            /// </summary>
            public static readonly EventLevelEnum MAJOR = new EventLevelEnum("Major");

            /// <summary>
            /// Enum MINOR for value: Minor
            /// </summary>
            public static readonly EventLevelEnum MINOR = new EventLevelEnum("Minor");

            /// <summary>
            /// Enum INFO for value: Info
            /// </summary>
            public static readonly EventLevelEnum INFO = new EventLevelEnum("Info");

            private static readonly Dictionary<string, EventLevelEnum> StaticFields =
            new Dictionary<string, EventLevelEnum>()
            {
                { "Critical", CRITICAL },
                { "Major", MAJOR },
                { "Minor", MINOR },
                { "Info", INFO },
            };

            private string Value;

            public EventLevelEnum(string value)
            {
                Value = value;
            }

            public static EventLevelEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as EventLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EventLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(EventLevelEnum a, EventLevelEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(EventLevelEnum a, EventLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 事件内容，最大长度4096。
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 所属分组。  资源分组对应的ID，必须传存在的分组ID。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 资源ID，支持字母、数字_ -：，最大长度128。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源名称，支持字母 中文 数字_ -. ，最大长度128。
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 事件状态。  枚举类型：normal\\warning\\incident
        /// </summary>
        [JsonProperty("event_state", NullValueHandling = NullValueHandling.Ignore)]
        public EventStateEnum EventState { get; set; }
        /// <summary>
        /// 事件级别。  枚举类型：Critical, Major, Minor, Info
        /// </summary>
        [JsonProperty("event_level", NullValueHandling = NullValueHandling.Ignore)]
        public EventLevelEnum EventLevel { get; set; }
        /// <summary>
        /// 事件用户。  支持字母 数字_ -/空格 ，最大长度64。
        /// </summary>
        [JsonProperty("event_user", NullValueHandling = NullValueHandling.Ignore)]
        public string EventUser { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventItemDetail {\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  eventState: ").Append(EventState).Append("\n");
            sb.Append("  eventLevel: ").Append(EventLevel).Append("\n");
            sb.Append("  eventUser: ").Append(EventUser).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventItemDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventItemDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.EventState == input.EventState ||
                    (this.EventState != null &&
                    this.EventState.Equals(input.EventState))
                ) && 
                (
                    this.EventLevel == input.EventLevel ||
                    (this.EventLevel != null &&
                    this.EventLevel.Equals(input.EventLevel))
                ) && 
                (
                    this.EventUser == input.EventUser ||
                    (this.EventUser != null &&
                    this.EventUser.Equals(input.EventUser))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.EventState != null)
                    hashCode = hashCode * 59 + this.EventState.GetHashCode();
                if (this.EventLevel != null)
                    hashCode = hashCode * 59 + this.EventLevel.GetHashCode();
                if (this.EventUser != null)
                    hashCode = hashCode * 59 + this.EventUser.GetHashCode();
                return hashCode;
            }
        }
    }
}
