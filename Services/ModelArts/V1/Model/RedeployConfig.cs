using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RedeployConfig 
    {
        /// <summary>
        /// 节点的重部署类型。若节点状态为不可用，将无法进行SOFT模式，只能进行HARD模式，HARD模式包含节点重置操作，会导致本地盘及云盘上的全部数据丢失，请谨慎操作
        /// </summary>
        /// <value>节点的重部署类型。若节点状态为不可用，将无法进行SOFT模式，只能进行HARD模式，HARD模式包含节点重置操作，会导致本地盘及云盘上的全部数据丢失，请谨慎操作</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum SOFT for value: SOFT
            /// </summary>
            public static readonly TypeEnum SOFT = new TypeEnum("SOFT");

            /// <summary>
            /// Enum HARD for value: HARD
            /// </summary>
            public static readonly TypeEnum HARD = new TypeEnum("HARD");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "SOFT", SOFT },
                { "HARD", HARD },
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
        /// 静默修复开关。开启autoFlow开关时，如重部署失败系统将自动流转至\&quot;系统维护\&quot;或发起\&quot;二次重部署\&quot;，并产生新的计划事件，该过程自动授权，无需二次授权
        /// </summary>
        /// <value>静默修复开关。开启autoFlow开关时，如重部署失败系统将自动流转至\&quot;系统维护\&quot;或发起\&quot;二次重部署\&quot;，并产生新的计划事件，该过程自动授权，无需二次授权</value>
        [JsonConverter(typeof(EnumClassConverter<AutoFlowEnum>))]
        public class AutoFlowEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly AutoFlowEnum TRUE = new AutoFlowEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly AutoFlowEnum FALSE = new AutoFlowEnum("false");

            private static readonly Dictionary<string, AutoFlowEnum> StaticFields =
            new Dictionary<string, AutoFlowEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public AutoFlowEnum()
            {

            }

            public AutoFlowEnum(string value)
            {
                _value = value;
            }

            public static AutoFlowEnum FromValue(string value)
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

                if (this.Equals(obj as AutoFlowEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AutoFlowEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AutoFlowEnum a, AutoFlowEnum b)
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

            public static bool operator !=(AutoFlowEnum a, AutoFlowEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 节点的重部署类型。若节点状态为不可用，将无法进行SOFT模式，只能进行HARD模式，HARD模式包含节点重置操作，会导致本地盘及云盘上的全部数据丢失，请谨慎操作
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 静默修复开关。开启autoFlow开关时，如重部署失败系统将自动流转至\&quot;系统维护\&quot;或发起\&quot;二次重部署\&quot;，并产生新的计划事件，该过程自动授权，无需二次授权
        /// </summary>
        [JsonProperty("autoFlow", NullValueHandling = NullValueHandling.Ignore)]
        public AutoFlowEnum AutoFlow { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedeployConfig {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  autoFlow: ").Append(AutoFlow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RedeployConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RedeployConfig input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.AutoFlow != input.AutoFlow) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.AutoFlow.GetHashCode();
                return hashCode;
            }
        }
    }
}
