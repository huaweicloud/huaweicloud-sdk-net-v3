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
    /// Lite Server实例批量操作请求体。
    /// </summary>
    public class DevServerBatchRequest 
    {
        /// <summary>
        /// **参数解释**：批量操作类型。 **约束限制**：不涉及。 **取值范围**： - START：批量启动Lite Server实例 - STOP：批量停止Lite Server实例 - REBOOT：批量重启Lite Server实例 - CHANGEOS：批量切换Lite Server服务器操作系统镜像 - REINSTALLOS：批量重装Lite Server服务器操作系统镜像 - DELETE：批量删除Lite Server实例 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：批量操作类型。 **约束限制**：不涉及。 **取值范围**： - START：批量启动Lite Server实例 - STOP：批量停止Lite Server实例 - REBOOT：批量重启Lite Server实例 - CHANGEOS：批量切换Lite Server服务器操作系统镜像 - REINSTALLOS：批量重装Lite Server服务器操作系统镜像 - DELETE：批量删除Lite Server实例 **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum START for value: START
            /// </summary>
            public static readonly TypeEnum START = new TypeEnum("START");

            /// <summary>
            /// Enum STOP for value: STOP
            /// </summary>
            public static readonly TypeEnum STOP = new TypeEnum("STOP");

            /// <summary>
            /// Enum REBOOT for value: REBOOT
            /// </summary>
            public static readonly TypeEnum REBOOT = new TypeEnum("REBOOT");

            /// <summary>
            /// Enum CHANGEOS for value: CHANGEOS
            /// </summary>
            public static readonly TypeEnum CHANGEOS = new TypeEnum("CHANGEOS");

            /// <summary>
            /// Enum REINSTALLOS for value: REINSTALLOS
            /// </summary>
            public static readonly TypeEnum REINSTALLOS = new TypeEnum("REINSTALLOS");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly TypeEnum DELETE = new TypeEnum("DELETE");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "START", START },
                { "STOP", STOP },
                { "REBOOT", REBOOT },
                { "CHANGEOS", CHANGEOS },
                { "REINSTALLOS", REINSTALLOS },
                { "DELETE", DELETE },
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
        /// **参数解释**：批量操作类型。 **约束限制**：不涉及。 **取值范围**： - START：批量启动Lite Server实例 - STOP：批量停止Lite Server实例 - REBOOT：批量重启Lite Server实例 - CHANGEOS：批量切换Lite Server服务器操作系统镜像 - REINSTALLOS：批量重装Lite Server服务器操作系统镜像 - DELETE：批量删除Lite Server实例 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**：批量操作Lite Server ID列表。
        /// </summary>
        [JsonProperty("servers", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchActionDevServerIds> Servers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extend_param", NullValueHandling = NullValueHandling.Ignore)]
        public ServerOsRequest ExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DevServerBatchRequest {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  servers: ").Append(Servers).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DevServerBatchRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DevServerBatchRequest input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.Servers != input.Servers || (this.Servers != null && input.Servers != null && !this.Servers.SequenceEqual(input.Servers))) return false;
            if (this.ExtendParam != input.ExtendParam || (this.ExtendParam != null && !this.ExtendParam.Equals(input.ExtendParam))) return false;

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
                if (this.Servers != null) hashCode = hashCode * 59 + this.Servers.GetHashCode();
                if (this.ExtendParam != null) hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
