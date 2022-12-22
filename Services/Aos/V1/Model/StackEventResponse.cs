using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// stack_event
    /// </summary>
    public class StackEventResponse 
    {
        /// <summary>
        /// 此次事件的类型 * &#x60;LOG&#x60; - 记录状态信息，比如当前状态，目标状态等。详细信息将在EventMessage中存储。此为暂时状态， 因为目前我们无法解析terraform的log，只能直全部以LOG形式打出，未来我们吃掉terraform内核以后， 将去除这个状态，并改为下列的更精准的状态 * &#x60;ERROR&#x60; - 记录失败信息 * &#x60;DRIFT&#x60; - 记录资源偏移信息 * &#x60;SUMMARY&#x60; - 记录资源变更结果总结 * &#x60;CREATION_IN_PROGRESS&#x60; - 正在生成 * &#x60;CREATION_FAILED&#x60; - 生成失败 * &#x60;CREATION_COMPLETE&#x60; - 生成完成 * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除 * &#x60;DELETION_FAILED&#x60; - 删除失败 * &#x60;DELETION_COMPLETE&#x60; - 已经删除 * &#x60;DELETION_SKIPPED&#x60; - 跳过删除。未来我们将支持，用户可以从资源编排服务中删除，但是不真的删除资源本身 * &#x60;UPDATE_IN_PROGRESS&#x60; - 正在更新。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION * &#x60;UPDATE_FAILED&#x60; - 更新失败。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后 * &#x60;UPDATE_COMPLETE&#x60; - 更新完成。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION
        /// </summary>
        /// <value>此次事件的类型 * &#x60;LOG&#x60; - 记录状态信息，比如当前状态，目标状态等。详细信息将在EventMessage中存储。此为暂时状态， 因为目前我们无法解析terraform的log，只能直全部以LOG形式打出，未来我们吃掉terraform内核以后， 将去除这个状态，并改为下列的更精准的状态 * &#x60;ERROR&#x60; - 记录失败信息 * &#x60;DRIFT&#x60; - 记录资源偏移信息 * &#x60;SUMMARY&#x60; - 记录资源变更结果总结 * &#x60;CREATION_IN_PROGRESS&#x60; - 正在生成 * &#x60;CREATION_FAILED&#x60; - 生成失败 * &#x60;CREATION_COMPLETE&#x60; - 生成完成 * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除 * &#x60;DELETION_FAILED&#x60; - 删除失败 * &#x60;DELETION_COMPLETE&#x60; - 已经删除 * &#x60;DELETION_SKIPPED&#x60; - 跳过删除。未来我们将支持，用户可以从资源编排服务中删除，但是不真的删除资源本身 * &#x60;UPDATE_IN_PROGRESS&#x60; - 正在更新。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION * &#x60;UPDATE_FAILED&#x60; - 更新失败。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后 * &#x60;UPDATE_COMPLETE&#x60; - 更新完成。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION</value>
        [JsonConverter(typeof(EnumClassConverter<EventTypeEnum>))]
        public class EventTypeEnum
        {
            /// <summary>
            /// Enum LOG for value: LOG
            /// </summary>
            public static readonly EventTypeEnum LOG = new EventTypeEnum("LOG");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly EventTypeEnum ERROR = new EventTypeEnum("ERROR");

            /// <summary>
            /// Enum DRIFT for value: DRIFT
            /// </summary>
            public static readonly EventTypeEnum DRIFT = new EventTypeEnum("DRIFT");

            /// <summary>
            /// Enum SUMMARY for value: SUMMARY
            /// </summary>
            public static readonly EventTypeEnum SUMMARY = new EventTypeEnum("SUMMARY");

            /// <summary>
            /// Enum CREATION_IN_PROGRESS for value: CREATION_IN_PROGRESS
            /// </summary>
            public static readonly EventTypeEnum CREATION_IN_PROGRESS = new EventTypeEnum("CREATION_IN_PROGRESS");

            /// <summary>
            /// Enum CREATION_FAILED for value: CREATION_FAILED
            /// </summary>
            public static readonly EventTypeEnum CREATION_FAILED = new EventTypeEnum("CREATION_FAILED");

            /// <summary>
            /// Enum CREATION_COMPLETE for value: CREATION_COMPLETE
            /// </summary>
            public static readonly EventTypeEnum CREATION_COMPLETE = new EventTypeEnum("CREATION_COMPLETE");

            /// <summary>
            /// Enum DELETION_IN_PROGRESS for value: DELETION_IN_PROGRESS
            /// </summary>
            public static readonly EventTypeEnum DELETION_IN_PROGRESS = new EventTypeEnum("DELETION_IN_PROGRESS");

            /// <summary>
            /// Enum DELETION_FAILED for value: DELETION_FAILED
            /// </summary>
            public static readonly EventTypeEnum DELETION_FAILED = new EventTypeEnum("DELETION_FAILED");

            /// <summary>
            /// Enum DELETION_COMPLETE for value: DELETION_COMPLETE
            /// </summary>
            public static readonly EventTypeEnum DELETION_COMPLETE = new EventTypeEnum("DELETION_COMPLETE");

            /// <summary>
            /// Enum DELETION_SKIPPED for value: DELETION_SKIPPED
            /// </summary>
            public static readonly EventTypeEnum DELETION_SKIPPED = new EventTypeEnum("DELETION_SKIPPED");

            /// <summary>
            /// Enum UPDATE_IN_PROGRESS for value: UPDATE_IN_PROGRESS
            /// </summary>
            public static readonly EventTypeEnum UPDATE_IN_PROGRESS = new EventTypeEnum("UPDATE_IN_PROGRESS");

            /// <summary>
            /// Enum UPDATE_FAILED for value: UPDATE_FAILED
            /// </summary>
            public static readonly EventTypeEnum UPDATE_FAILED = new EventTypeEnum("UPDATE_FAILED");

            /// <summary>
            /// Enum UPDATE_COMPLETE for value: UPDATE_COMPLETE
            /// </summary>
            public static readonly EventTypeEnum UPDATE_COMPLETE = new EventTypeEnum("UPDATE_COMPLETE");

            private static readonly Dictionary<string, EventTypeEnum> StaticFields =
            new Dictionary<string, EventTypeEnum>()
            {
                { "LOG", LOG },
                { "ERROR", ERROR },
                { "DRIFT", DRIFT },
                { "SUMMARY", SUMMARY },
                { "CREATION_IN_PROGRESS", CREATION_IN_PROGRESS },
                { "CREATION_FAILED", CREATION_FAILED },
                { "CREATION_COMPLETE", CREATION_COMPLETE },
                { "DELETION_IN_PROGRESS", DELETION_IN_PROGRESS },
                { "DELETION_FAILED", DELETION_FAILED },
                { "DELETION_COMPLETE", DELETION_COMPLETE },
                { "DELETION_SKIPPED", DELETION_SKIPPED },
                { "UPDATE_IN_PROGRESS", UPDATE_IN_PROGRESS },
                { "UPDATE_FAILED", UPDATE_FAILED },
                { "UPDATE_COMPLETE", UPDATE_COMPLETE },
            };

            private string _value;

            public EventTypeEnum()
            {

            }

            public EventTypeEnum(string value)
            {
                _value = value;
            }

            public static EventTypeEnum FromValue(string value)
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

                if (this.Equals(obj as EventTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EventTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EventTypeEnum a, EventTypeEnum b)
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

            public static bool operator !=(EventTypeEnum a, EventTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源的id名称，即对应资源作为唯一id使用的值的名称，当资源未创建的时候，不返回resource_id_key
        /// </summary>
        [JsonProperty("resource_id_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceIdKey { get; set; }

        /// <summary>
        /// 资源的id值，即对应资源作为唯一id使用的值，当资源未创建的时候，不返回resource_id_value
        /// </summary>
        [JsonProperty("resource_id_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceIdValue { get; set; }

        /// <summary>
        /// 资源的名称
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 资源的类型
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 事件发生的时间，格式遵循RFC3339，即yyyy-mm-ddTHH:MM:SSZ，如1970-01-01T00:00:00Z
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 此次事件的类型 * &#x60;LOG&#x60; - 记录状态信息，比如当前状态，目标状态等。详细信息将在EventMessage中存储。此为暂时状态， 因为目前我们无法解析terraform的log，只能直全部以LOG形式打出，未来我们吃掉terraform内核以后， 将去除这个状态，并改为下列的更精准的状态 * &#x60;ERROR&#x60; - 记录失败信息 * &#x60;DRIFT&#x60; - 记录资源偏移信息 * &#x60;SUMMARY&#x60; - 记录资源变更结果总结 * &#x60;CREATION_IN_PROGRESS&#x60; - 正在生成 * &#x60;CREATION_FAILED&#x60; - 生成失败 * &#x60;CREATION_COMPLETE&#x60; - 生成完成 * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除 * &#x60;DELETION_FAILED&#x60; - 删除失败 * &#x60;DELETION_COMPLETE&#x60; - 已经删除 * &#x60;DELETION_SKIPPED&#x60; - 跳过删除。未来我们将支持，用户可以从资源编排服务中删除，但是不真的删除资源本身 * &#x60;UPDATE_IN_PROGRESS&#x60; - 正在更新。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION * &#x60;UPDATE_FAILED&#x60; - 更新失败。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后 * &#x60;UPDATE_COMPLETE&#x60; - 更新完成。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// 事件对应的详细信息
        /// </summary>
        [JsonProperty("event_message", NullValueHandling = NullValueHandling.Ignore)]
        public string EventMessage { get; set; }

        /// <summary>
        /// 资源改动所花的时间，以秒为单位
        /// </summary>
        [JsonProperty("elapsed_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? ElapsedSeconds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackEventResponse {\n");
            sb.Append("  resourceIdKey: ").Append(ResourceIdKey).Append("\n");
            sb.Append("  resourceIdValue: ").Append(ResourceIdValue).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  eventMessage: ").Append(EventMessage).Append("\n");
            sb.Append("  elapsedSeconds: ").Append(ElapsedSeconds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StackEventResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StackEventResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceIdKey == input.ResourceIdKey ||
                    (this.ResourceIdKey != null &&
                    this.ResourceIdKey.Equals(input.ResourceIdKey))
                ) && 
                (
                    this.ResourceIdValue == input.ResourceIdValue ||
                    (this.ResourceIdValue != null &&
                    this.ResourceIdValue.Equals(input.ResourceIdValue))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.EventMessage == input.EventMessage ||
                    (this.EventMessage != null &&
                    this.EventMessage.Equals(input.EventMessage))
                ) && 
                (
                    this.ElapsedSeconds == input.ElapsedSeconds ||
                    (this.ElapsedSeconds != null &&
                    this.ElapsedSeconds.Equals(input.ElapsedSeconds))
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
                if (this.ResourceIdKey != null)
                    hashCode = hashCode * 59 + this.ResourceIdKey.GetHashCode();
                if (this.ResourceIdValue != null)
                    hashCode = hashCode * 59 + this.ResourceIdValue.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.EventMessage != null)
                    hashCode = hashCode * 59 + this.EventMessage.GetHashCode();
                if (this.ElapsedSeconds != null)
                    hashCode = hashCode * 59 + this.ElapsedSeconds.GetHashCode();
                return hashCode;
            }
        }
    }
}
