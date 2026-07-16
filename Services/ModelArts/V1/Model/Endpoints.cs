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
    /// 本地IDE（如PyCharm、VSCode）或SSH客户端，通过SSH远程接入Notebook实例时需要的相关配置。
    /// </summary>
    public class Endpoints 
    {
        /// <summary>
        /// **参数解释**：支持的服务。 **取值范围**： - NOTEBOOK：可以通过https协议访问Notebook - SSH：可以通过SSH协议远程连接Notebook
        /// </summary>
        /// <value>**参数解释**：支持的服务。 **取值范围**： - NOTEBOOK：可以通过https协议访问Notebook - SSH：可以通过SSH协议远程连接Notebook</value>
        [JsonConverter(typeof(EnumClassConverter<DevServiceEnum>))]
        public class DevServiceEnum
        {
            /// <summary>
            /// Enum AI_FLOW for value: AI_FLOW
            /// </summary>
            public static readonly DevServiceEnum AI_FLOW = new DevServiceEnum("AI_FLOW");

            /// <summary>
            /// Enum MA_STUDIO for value: MA_STUDIO
            /// </summary>
            public static readonly DevServiceEnum MA_STUDIO = new DevServiceEnum("MA_STUDIO");

            /// <summary>
            /// Enum NOTEBOOK for value: NOTEBOOK
            /// </summary>
            public static readonly DevServiceEnum NOTEBOOK = new DevServiceEnum("NOTEBOOK");

            /// <summary>
            /// Enum SSH for value: SSH
            /// </summary>
            public static readonly DevServiceEnum SSH = new DevServiceEnum("SSH");

            /// <summary>
            /// Enum TENSOR_BOARD for value: TENSOR_BOARD
            /// </summary>
            public static readonly DevServiceEnum TENSOR_BOARD = new DevServiceEnum("TENSOR_BOARD");

            /// <summary>
            /// Enum WEB_IDE for value: WEB_IDE
            /// </summary>
            public static readonly DevServiceEnum WEB_IDE = new DevServiceEnum("WEB_IDE");

            private static readonly Dictionary<string, DevServiceEnum> StaticFields =
            new Dictionary<string, DevServiceEnum>()
            {
                { "AI_FLOW", AI_FLOW },
                { "MA_STUDIO", MA_STUDIO },
                { "NOTEBOOK", NOTEBOOK },
                { "SSH", SSH },
                { "TENSOR_BOARD", TENSOR_BOARD },
                { "WEB_IDE", WEB_IDE },
            };

            private string _value;

            public DevServiceEnum()
            {

            }

            public DevServiceEnum(string value)
            {
                _value = value;
            }

            public static DevServiceEnum FromValue(string value)
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

                if (this.Equals(obj as DevServiceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DevServiceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DevServiceEnum a, DevServiceEnum b)
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

            public static bool operator !=(DevServiceEnum a, DevServiceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：支持的服务。 **取值范围**： - NOTEBOOK：可以通过https协议访问Notebook - SSH：可以通过SSH协议远程连接Notebook
        /// </summary>
        [JsonProperty("dev_service", NullValueHandling = NullValueHandling.Ignore)]
        public DevServiceEnum DevService { get; set; }
        /// <summary>
        /// **参数解释**：通过应用专属URL直接打开应用进入远程开发模式。包含应用的各种扩展配置。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("extensions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Extensions { get; set; }

        /// <summary>
        /// **参数解释**：SSH密钥对名称列表。允许设置多个密钥对实现同时对SSH实例的访问。 **约束限制**：不涉及。 **取值范围**：0 - 1024个密钥对 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("ssh_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SshKeys { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Endpoints {\n");
            sb.Append("  devService: ").Append(DevService).Append("\n");
            sb.Append("  extensions: ").Append(Extensions).Append("\n");
            sb.Append("  sshKeys: ").Append(SshKeys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Endpoints);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Endpoints input)
        {
            if (input == null) return false;
            if (this.DevService != input.DevService) return false;
            if (this.Extensions != input.Extensions || (this.Extensions != null && input.Extensions != null && !this.Extensions.SequenceEqual(input.Extensions))) return false;
            if (this.SshKeys != input.SshKeys || (this.SshKeys != null && input.SshKeys != null && !this.SshKeys.SequenceEqual(input.SshKeys))) return false;

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
                hashCode = hashCode * 59 + this.DevService.GetHashCode();
                if (this.Extensions != null) hashCode = hashCode * 59 + this.Extensions.GetHashCode();
                if (this.SshKeys != null) hashCode = hashCode * 59 + this.SshKeys.GetHashCode();
                return hashCode;
            }
        }
    }
}
