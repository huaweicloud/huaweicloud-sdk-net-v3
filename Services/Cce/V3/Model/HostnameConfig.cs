using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class HostnameConfig 
    {
        /// <summary>
        /// K8S节点名称配置类型, 默认为“privateIp”。  -  privateIp: 将节点私有IP作为K8S节点名称 -  cceNodeName: 将CCE节点名称作为K8S节点名称  &gt; - 配置为cceNodeName的节点, 其节点名称、K8S节点名称以及虚机名称相同。节点名称不支持修改, 并且在ECS侧修改了虚机名称，同步云服务器时，不会将修改后的虚机名称同步到节点。 &gt; - 配置为cceNodeName的节点，为了避免K8S节点名称冲突，系统会自动在节点名称后添加后缀，后缀的格式为中划线(-)+五位随机字符，随机字符的取值为[a-z0-9]。 
        /// </summary>
        /// <value>K8S节点名称配置类型, 默认为“privateIp”。  -  privateIp: 将节点私有IP作为K8S节点名称 -  cceNodeName: 将CCE节点名称作为K8S节点名称  &gt; - 配置为cceNodeName的节点, 其节点名称、K8S节点名称以及虚机名称相同。节点名称不支持修改, 并且在ECS侧修改了虚机名称，同步云服务器时，不会将修改后的虚机名称同步到节点。 &gt; - 配置为cceNodeName的节点，为了避免K8S节点名称冲突，系统会自动在节点名称后添加后缀，后缀的格式为中划线(-)+五位随机字符，随机字符的取值为[a-z0-9]。 </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum PRIVATEIP for value: privateIp
            /// </summary>
            public static readonly TypeEnum PRIVATEIP = new TypeEnum("privateIp");

            /// <summary>
            /// Enum CCENODENAME for value: cceNodeName
            /// </summary>
            public static readonly TypeEnum CCENODENAME = new TypeEnum("cceNodeName");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "privateIp", PRIVATEIP },
                { "cceNodeName", CCENODENAME },
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// K8S节点名称配置类型, 默认为“privateIp”。  -  privateIp: 将节点私有IP作为K8S节点名称 -  cceNodeName: 将CCE节点名称作为K8S节点名称  &gt; - 配置为cceNodeName的节点, 其节点名称、K8S节点名称以及虚机名称相同。节点名称不支持修改, 并且在ECS侧修改了虚机名称，同步云服务器时，不会将修改后的虚机名称同步到节点。 &gt; - 配置为cceNodeName的节点，为了避免K8S节点名称冲突，系统会自动在节点名称后添加后缀，后缀的格式为中划线(-)+五位随机字符，随机字符的取值为[a-z0-9]。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostnameConfig {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HostnameConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HostnameConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
