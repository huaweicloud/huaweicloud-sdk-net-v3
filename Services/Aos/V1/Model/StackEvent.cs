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
    /// 
    /// </summary>
    public class StackEvent 
    {
        /// <summary>
        /// 此次事件的类型 * &#x60;LOG&#x60; - 记录状态信息，比如当前状态，目标状态等。 * &#x60;ERROR&#x60; - 记录失败信息 * &#x60;DRIFT&#x60; - 记录资源偏移信息 * &#x60;SUMMARY&#x60; - 记录资源变更结果总结 * &#x60;CREATION_IN_PROGRESS&#x60; - 正在生成 * &#x60;CREATION_FAILED&#x60; - 生成失败 * &#x60;CREATION_COMPLETE&#x60; - 生成完成 * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除 * &#x60;DELETION_FAILED&#x60; - 删除失败 * &#x60;DELETION_COMPLETE&#x60; - 已经删除 * &#x60;UPDATE_IN_PROGRESS&#x60; - 正在更新。此处的更新特指非替换式更新，如果是替换式更新，则是DELETION后CREATION，或者CREATION后DELETION，具体以何种行为进行替换式更新由Provider定义。 * &#x60;UPDATE_FAILED&#x60; - 更新失败。此处的更新特指非替换式更新，如果是替换式更新，则是DELETION后CREATION，或者CREATION后DELETION，具体以何种行为进行替换式更新由Provider定义。 * &#x60;UPDATE_COMPLETE&#x60; - 更新完成。此处的更新特指非替换式更新，如果是替换式更新，则是DELETION后CREATION，或者CREATION后DELETION，具体以何种行为进行替换式更新由Provider定义。
        /// </summary>
        /// <value>此次事件的类型 * &#x60;LOG&#x60; - 记录状态信息，比如当前状态，目标状态等。 * &#x60;ERROR&#x60; - 记录失败信息 * &#x60;DRIFT&#x60; - 记录资源偏移信息 * &#x60;SUMMARY&#x60; - 记录资源变更结果总结 * &#x60;CREATION_IN_PROGRESS&#x60; - 正在生成 * &#x60;CREATION_FAILED&#x60; - 生成失败 * &#x60;CREATION_COMPLETE&#x60; - 生成完成 * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除 * &#x60;DELETION_FAILED&#x60; - 删除失败 * &#x60;DELETION_COMPLETE&#x60; - 已经删除 * &#x60;UPDATE_IN_PROGRESS&#x60; - 正在更新。此处的更新特指非替换式更新，如果是替换式更新，则是DELETION后CREATION，或者CREATION后DELETION，具体以何种行为进行替换式更新由Provider定义。 * &#x60;UPDATE_FAILED&#x60; - 更新失败。此处的更新特指非替换式更新，如果是替换式更新，则是DELETION后CREATION，或者CREATION后DELETION，具体以何种行为进行替换式更新由Provider定义。 * &#x60;UPDATE_COMPLETE&#x60; - 更新完成。此处的更新特指非替换式更新，如果是替换式更新，则是DELETION后CREATION，或者CREATION后DELETION，具体以何种行为进行替换式更新由Provider定义。</value>
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

            public static bool operator !=(EventTypeEnum a, EventTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源的类型  以HCL格式的模板为例，resource_type 为 huaweicloud_vpc  &#x60;&#x60;&#x60;hcl resource \&quot;huaweicloud_vpc\&quot; \&quot;my_hello_world_vpc\&quot; {   name &#x3D; \&quot;test_vpc\&quot; } &#x60;&#x60;&#x60;  以json格式的模板为例，resource_type 为 huaweicloud_vpc  &#x60;&#x60;&#x60;json {   \&quot;resource\&quot;: {     \&quot;huaweicloud_vpc\&quot;: {       \&quot;my_hello_world_vpc\&quot;: {         \&quot;name\&quot;: \&quot;test_vpc\&quot;       }     }   } } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源的名称，默认为资源的逻辑名称  以HCL格式的模板为例，resource_name 为 my_hello_world_vpc  &#x60;&#x60;&#x60;hcl resource \&quot;huaweicloud_vpc\&quot; \&quot;my_hello_world_vpc\&quot; {   name &#x3D; \&quot;test_vpc\&quot; } &#x60;&#x60;&#x60;  以json格式的模板为例，resource_name 为 my_hello_world_vpc  &#x60;&#x60;&#x60;json {   \&quot;resource\&quot;: {     \&quot;huaweicloud_vpc\&quot;: {       \&quot;my_hello_world_vpc\&quot;: {         \&quot;name\&quot;: \&quot;test_vpc\&quot;       }     }   } } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 资源id的名称，即对应资源作为id使用的值的名称，当资源未创建的时候，不返回resource_id_key 此id由provider定义，因此不同的provider可能遵循了不同的命名规则，具体的命名规则请与provider开发者确认或阅读provider文档
        /// </summary>
        [JsonProperty("resource_id_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceIdKey { get; set; }

        /// <summary>
        /// 资源id的值，即对应资源作为id使用的值，当资源未创建的时候，不返回resource_id_value
        /// </summary>
        [JsonProperty("resource_id_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceIdValue { get; set; }

        /// <summary>
        /// 资源键，如果用户在模板中使用了count或for_each则会返回resource_key  如果用户在模板中使用count，则resource_key为从0开始的数字  以HCL格式的模板为例，模板中count为2，意味着将会生成两个资源，对应的resource_key分别为0和1  &#x60;&#x60;&#x60;hcl resource \&quot;huaweicloud_vpc\&quot; \&quot;my_hello_world_vpc\&quot; {   count &#x3D; 2   name &#x3D; \&quot;test_vpc\&quot; } &#x60;&#x60;&#x60;  以json格式的模板为例，模板中count为2，意味着将会生成两个资源，对应的resource_key分别为0和1  &#x60;&#x60;&#x60;json {   \&quot;resource\&quot;: {     \&quot;huaweicloud_vpc\&quot;: {       \&quot;my_hello_world_vpc\&quot;: {         \&quot;name\&quot;: \&quot;test_vpc\&quot;,         \&quot;count\&quot;: 2       }     }   } } &#x60;&#x60;&#x60;  如果用户在模板中使用for_each，则resource_key为用户自定义的字符串  以HCL格式的模板为例，resource_key分别为vpc1和vpc2  &#x60;&#x60;&#x60;hcl resource \&quot;huaweicloud_vpc\&quot; \&quot;my_hello_world_vpc\&quot; {   for_each &#x3D; {     \&quot;vpc1\&quot; &#x3D; \&quot;test_vpc\&quot;     \&quot;vpc2\&quot; &#x3D; \&quot;test_vpc\&quot;   }   name &#x3D; each.value } &#x60;&#x60;&#x60;  以json格式的模板为例，resource_key分别为vpc1和vpc2  &#x60;&#x60;&#x60;json {   \&quot;resource\&quot;: {     \&quot;huaweicloud_vpc\&quot;: {       \&quot;my_hello_world_vpc\&quot;: {         \&quot;for_each\&quot;: {           \&quot;vpc1\&quot;: \&quot;test_vpc\&quot;,           \&quot;vpc2\&quot;: \&quot;test_vpc\&quot;         }         \&quot;name\&quot;: \&quot;${each.value}\&quot;       }     }   } } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("resource_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceKey { get; set; }

        /// <summary>
        /// 事件发生的时间 格式遵循RFC3339，即yyyy-mm-ddTHH:MM:SSZ，如1970-01-01T00:00:00Z
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 此次事件的类型 * &#x60;LOG&#x60; - 记录状态信息，比如当前状态，目标状态等。 * &#x60;ERROR&#x60; - 记录失败信息 * &#x60;DRIFT&#x60; - 记录资源偏移信息 * &#x60;SUMMARY&#x60; - 记录资源变更结果总结 * &#x60;CREATION_IN_PROGRESS&#x60; - 正在生成 * &#x60;CREATION_FAILED&#x60; - 生成失败 * &#x60;CREATION_COMPLETE&#x60; - 生成完成 * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除 * &#x60;DELETION_FAILED&#x60; - 删除失败 * &#x60;DELETION_COMPLETE&#x60; - 已经删除 * &#x60;UPDATE_IN_PROGRESS&#x60; - 正在更新。此处的更新特指非替换式更新，如果是替换式更新，则是DELETION后CREATION，或者CREATION后DELETION，具体以何种行为进行替换式更新由Provider定义。 * &#x60;UPDATE_FAILED&#x60; - 更新失败。此处的更新特指非替换式更新，如果是替换式更新，则是DELETION后CREATION，或者CREATION后DELETION，具体以何种行为进行替换式更新由Provider定义。 * &#x60;UPDATE_COMPLETE&#x60; - 更新完成。此处的更新特指非替换式更新，如果是替换式更新，则是DELETION后CREATION，或者CREATION后DELETION，具体以何种行为进行替换式更新由Provider定义。
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// 该资源栈事件对应的详细信息
        /// </summary>
        [JsonProperty("event_message", NullValueHandling = NullValueHandling.Ignore)]
        public string EventMessage { get; set; }

        /// <summary>
        /// 此事件执行所花的时间，以秒为单位
        /// </summary>
        [JsonProperty("elapsed_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? ElapsedSeconds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackEvent {\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceIdKey: ").Append(ResourceIdKey).Append("\n");
            sb.Append("  resourceIdValue: ").Append(ResourceIdValue).Append("\n");
            sb.Append("  resourceKey: ").Append(ResourceKey).Append("\n");
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
            return this.Equals(input as StackEvent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StackEvent input)
        {
            if (input == null) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.ResourceIdKey != input.ResourceIdKey || (this.ResourceIdKey != null && !this.ResourceIdKey.Equals(input.ResourceIdKey))) return false;
            if (this.ResourceIdValue != input.ResourceIdValue || (this.ResourceIdValue != null && !this.ResourceIdValue.Equals(input.ResourceIdValue))) return false;
            if (this.ResourceKey != input.ResourceKey || (this.ResourceKey != null && !this.ResourceKey.Equals(input.ResourceKey))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.EventType != input.EventType) return false;
            if (this.EventMessage != input.EventMessage || (this.EventMessage != null && !this.EventMessage.Equals(input.EventMessage))) return false;
            if (this.ElapsedSeconds != input.ElapsedSeconds || (this.ElapsedSeconds != null && !this.ElapsedSeconds.Equals(input.ElapsedSeconds))) return false;

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
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceIdKey != null) hashCode = hashCode * 59 + this.ResourceIdKey.GetHashCode();
                if (this.ResourceIdValue != null) hashCode = hashCode * 59 + this.ResourceIdValue.GetHashCode();
                if (this.ResourceKey != null) hashCode = hashCode * 59 + this.ResourceKey.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.EventMessage != null) hashCode = hashCode * 59 + this.EventMessage.GetHashCode();
                if (this.ElapsedSeconds != null) hashCode = hashCode * 59 + this.ElapsedSeconds.GetHashCode();
                return hashCode;
            }
        }
    }
}
