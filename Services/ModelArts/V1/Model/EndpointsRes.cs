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
    /// 本地IDE（如PyCharm、VS Code）或SSH客户端，通过SSH远程接入Notebook实例时需要的相关配置。
    /// </summary>
    public class EndpointsRes 
    {
        /// <summary>
        /// **参数解释**：访问Notebook的途径。 **取值范围**：枚举类型，取值如下： - NOTEBOOK：可以通过https协议访问Notebook。 - SSH：可以通过SSH协议远程连接Notebook。
        /// </summary>
        /// <value>**参数解释**：访问Notebook的途径。 **取值范围**：枚举类型，取值如下： - NOTEBOOK：可以通过https协议访问Notebook。 - SSH：可以通过SSH协议远程连接Notebook。</value>
        [JsonConverter(typeof(EnumClassConverter<ServiceEnum>))]
        public class ServiceEnum
        {
            /// <summary>
            /// Enum NOTEBOOK for value: NOTEBOOK
            /// </summary>
            public static readonly ServiceEnum NOTEBOOK = new ServiceEnum("NOTEBOOK");

            /// <summary>
            /// Enum SSH for value: SSH
            /// </summary>
            public static readonly ServiceEnum SSH = new ServiceEnum("SSH");

            private static readonly Dictionary<string, ServiceEnum> StaticFields =
            new Dictionary<string, ServiceEnum>()
            {
                { "NOTEBOOK", NOTEBOOK },
                { "SSH", SSH },
            };

            private string _value;

            public ServiceEnum()
            {

            }

            public ServiceEnum(string value)
            {
                _value = value;
            }

            public static ServiceEnum FromValue(string value)
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

                if (this.Equals(obj as ServiceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ServiceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ServiceEnum a, ServiceEnum b)
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

            public static bool operator !=(ServiceEnum a, ServiceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：访问Notebook的途径。 **取值范围**：枚举类型，取值如下： - NOTEBOOK：可以通过https协议访问Notebook。 - SSH：可以通过SSH协议远程连接Notebook。
        /// </summary>
        [JsonProperty("dev_service", NullValueHandling = NullValueHandling.Ignore)]
        public string DevService { get; set; }

        /// <summary>
        /// **参数解释**：访问Notebook的途径。 **取值范围**：枚举类型，取值如下： - NOTEBOOK：可以通过https协议访问Notebook。 - SSH：可以通过SSH协议远程连接Notebook。
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceEnum Service { get; set; }
        /// <summary>
        /// **参数解释**：实例私有IP地址。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// **参数解释**：SSH密钥对名称列表，允许设置多个密钥对实现同时对SSH实例的访问。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("key_pair_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> KeyPairNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointsRes {\n");
            sb.Append("  devService: ").Append(DevService).Append("\n");
            sb.Append("  service: ").Append(Service).Append("\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  keyPairNames: ").Append(KeyPairNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EndpointsRes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EndpointsRes input)
        {
            if (input == null) return false;
            if (this.DevService != input.DevService || (this.DevService != null && !this.DevService.Equals(input.DevService))) return false;
            if (this.Service != input.Service) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.KeyPairNames != input.KeyPairNames || (this.KeyPairNames != null && input.KeyPairNames != null && !this.KeyPairNames.SequenceEqual(input.KeyPairNames))) return false;

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
                if (this.DevService != null) hashCode = hashCode * 59 + this.DevService.GetHashCode();
                hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.KeyPairNames != null) hashCode = hashCode * 59 + this.KeyPairNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
