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
    public class StackSetOperationActionPrimitiveTypeHolder 
    {
        /// <summary>
        /// 用户当前的操作   * &#x60;CREATE_STACK_INSTANCES&#x60; - 创建资源栈实例   * &#x60;DELETE_STACK_INSTANCES&#x60; - 删除资源栈实例   * &#x60;DEPLOY_STACK_SET&#x60; - 部署资源栈集   * &#x60;DEPLOY_STACK_INSTANCES&#x60; - 部署资源栈实例
        /// </summary>
        /// <value>用户当前的操作   * &#x60;CREATE_STACK_INSTANCES&#x60; - 创建资源栈实例   * &#x60;DELETE_STACK_INSTANCES&#x60; - 删除资源栈实例   * &#x60;DEPLOY_STACK_SET&#x60; - 部署资源栈集   * &#x60;DEPLOY_STACK_INSTANCES&#x60; - 部署资源栈实例</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum CREATE_STACK_INSTANCES for value: CREATE_STACK_INSTANCES
            /// </summary>
            public static readonly ActionEnum CREATE_STACK_INSTANCES = new ActionEnum("CREATE_STACK_INSTANCES");

            /// <summary>
            /// Enum DELETE_STACK_INSTANCES for value: DELETE_STACK_INSTANCES
            /// </summary>
            public static readonly ActionEnum DELETE_STACK_INSTANCES = new ActionEnum("DELETE_STACK_INSTANCES");

            /// <summary>
            /// Enum DEPLOY_STACK_SET for value: DEPLOY_STACK_SET
            /// </summary>
            public static readonly ActionEnum DEPLOY_STACK_SET = new ActionEnum("DEPLOY_STACK_SET");

            /// <summary>
            /// Enum DEPLOY_STACK_INSTANCES for value: DEPLOY_STACK_INSTANCES
            /// </summary>
            public static readonly ActionEnum DEPLOY_STACK_INSTANCES = new ActionEnum("DEPLOY_STACK_INSTANCES");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "CREATE_STACK_INSTANCES", CREATE_STACK_INSTANCES },
                { "DELETE_STACK_INSTANCES", DELETE_STACK_INSTANCES },
                { "DEPLOY_STACK_SET", DEPLOY_STACK_SET },
                { "DEPLOY_STACK_INSTANCES", DEPLOY_STACK_INSTANCES },
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
        /// 用户当前的操作   * &#x60;CREATE_STACK_INSTANCES&#x60; - 创建资源栈实例   * &#x60;DELETE_STACK_INSTANCES&#x60; - 删除资源栈实例   * &#x60;DEPLOY_STACK_SET&#x60; - 部署资源栈集   * &#x60;DEPLOY_STACK_INSTANCES&#x60; - 部署资源栈实例
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackSetOperationActionPrimitiveTypeHolder {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StackSetOperationActionPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StackSetOperationActionPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                return hashCode;
            }
        }
    }
}
