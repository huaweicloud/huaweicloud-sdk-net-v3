using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchDeleteInstanceReq 
    {
        /// <summary>
        /// **参数解释**： 对实例的操作：delete。 **约束限制**： 不涉及。 **取值范围**：  - delete **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 对实例的操作：delete。 **约束限制**： 不涉及。 **取值范围**：  - delete **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum DELETE for value: delete
            /// </summary>
            public static readonly ActionEnum DELETE = new ActionEnum("delete");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "delete", DELETE },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 参数值为reliability，表示删除租户所有创建失败的RocketMQ实例。 **约束限制**： 不涉及。 **取值范围**： - reliability **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 参数值为reliability，表示删除租户所有创建失败的RocketMQ实例。 **约束限制**： 不涉及。 **取值范围**： - reliability **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<AllFailureEnum>))]
        public class AllFailureEnum
        {
            /// <summary>
            /// Enum RELIABILITY for value: reliability
            /// </summary>
            public static readonly AllFailureEnum RELIABILITY = new AllFailureEnum("reliability");

            private static readonly Dictionary<string, AllFailureEnum> StaticFields =
            new Dictionary<string, AllFailureEnum>()
            {
                { "reliability", RELIABILITY },
            };

            private string _value;

            public AllFailureEnum()
            {

            }

            public AllFailureEnum(string value)
            {
                _value = value;
            }

            public static AllFailureEnum FromValue(string value)
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

                if (this.Equals(obj as AllFailureEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AllFailureEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AllFailureEnum a, AllFailureEnum b)
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

            public static bool operator !=(AllFailureEnum a, AllFailureEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 实例的ID列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// **参数解释**： 对实例的操作：delete。 **约束限制**： 不涉及。 **取值范围**：  - delete **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// **参数解释**： 参数值为reliability，表示删除租户所有创建失败的RocketMQ实例。 **约束限制**： 不涉及。 **取值范围**： - reliability **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("all_failure", NullValueHandling = NullValueHandling.Ignore)]
        public AllFailureEnum AllFailure { get; set; }
        /// <summary>
        /// **参数解释**： 是否强删除。 **约束限制**： 不涉及。 **取值范围**： - true：强删除，强删除实例不进入回收站。 - false：弱删除，开启回收站功能后，实例进入回收站。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("force_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceDelete { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteInstanceReq {\n");
            sb.Append("  instances: ").Append(Instances).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  allFailure: ").Append(AllFailure).Append("\n");
            sb.Append("  forceDelete: ").Append(ForceDelete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteInstanceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteInstanceReq input)
        {
            if (input == null) return false;
            if (this.Instances != input.Instances || (this.Instances != null && input.Instances != null && !this.Instances.SequenceEqual(input.Instances))) return false;
            if (this.Action != input.Action) return false;
            if (this.AllFailure != input.AllFailure) return false;
            if (this.ForceDelete != input.ForceDelete || (this.ForceDelete != null && !this.ForceDelete.Equals(input.ForceDelete))) return false;

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
                if (this.Instances != null) hashCode = hashCode * 59 + this.Instances.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.AllFailure.GetHashCode();
                if (this.ForceDelete != null) hashCode = hashCode * 59 + this.ForceDelete.GetHashCode();
                return hashCode;
            }
        }
    }
}
