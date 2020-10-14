using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchRestartOrDeleteInstanceReq 
    {
        /// <summary>
        /// 对实例的操作：restart、delete
        /// </summary>
        /// <value>对实例的操作：restart、delete</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum RESTART for value: restart
            /// </summary>
            public static readonly ActionEnum RESTART = new ActionEnum("restart");

            /// <summary>
            /// Enum DELETE for value: delete
            /// </summary>
            public static readonly ActionEnum DELETE = new ActionEnum("delete");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "restart", RESTART },
                { "delete", DELETE },
            };

            private string Value;

            public ActionEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否批量删除创建失败的实例。  当参数值为“true”时，删除租户所有创建失败的实例，此时请求参数instances可为空。
        /// </summary>
        /// <value>是否批量删除创建失败的实例。  当参数值为“true”时，删除租户所有创建失败的实例，此时请求参数instances可为空。</value>
        [JsonConverter(typeof(EnumClassConverter<AllFailureEnum>))]
        public class AllFailureEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly AllFailureEnum TRUE = new AllFailureEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly AllFailureEnum FALSE = new AllFailureEnum("false");

            private static readonly Dictionary<string, AllFailureEnum> StaticFields =
            new Dictionary<string, AllFailureEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string Value;

            public AllFailureEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(AllFailureEnum a, AllFailureEnum b)
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

            public static bool operator !=(AllFailureEnum a, AllFailureEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例的ID列表。
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// 对实例的操作：restart、delete
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 是否批量删除创建失败的实例。  当参数值为“true”时，删除租户所有创建失败的实例，此时请求参数instances可为空。
        /// </summary>
        [JsonProperty("all_failure", NullValueHandling = NullValueHandling.Ignore)]
        public AllFailureEnum AllFailure { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRestartOrDeleteInstanceReq {\n");
            sb.Append("  instances: ").Append(Instances).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  allFailure: ").Append(AllFailure).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchRestartOrDeleteInstanceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchRestartOrDeleteInstanceReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Instances == input.Instances ||
                    this.Instances != null &&
                    input.Instances != null &&
                    this.Instances.SequenceEqual(input.Instances)
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.AllFailure == input.AllFailure ||
                    (this.AllFailure != null &&
                    this.AllFailure.Equals(input.AllFailure))
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
                if (this.Instances != null)
                    hashCode = hashCode * 59 + this.Instances.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.AllFailure != null)
                    hashCode = hashCode * 59 + this.AllFailure.GetHashCode();
                return hashCode;
            }
        }
    }
}
