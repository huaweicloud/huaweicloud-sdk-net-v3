using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 文件重定向。
    /// </summary>
    public class PoliciesFileAndClipboardFileRedirection 
    {
        /// <summary>
        /// 文件重定向。取值为： DISABLED：表示禁用。（默认） READ_ONLY：表示只读。 READ_AND_WRITE：表示读写。
        /// </summary>
        /// <value>文件重定向。取值为： DISABLED：表示禁用。（默认） READ_ONLY：表示只读。 READ_AND_WRITE：表示读写。</value>
        [JsonConverter(typeof(EnumClassConverter<RedirectionModeEnum>))]
        public class RedirectionModeEnum
        {
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly RedirectionModeEnum DISABLED = new RedirectionModeEnum("DISABLED");

            /// <summary>
            /// Enum READ_ONLY for value: READ_ONLY
            /// </summary>
            public static readonly RedirectionModeEnum READ_ONLY = new RedirectionModeEnum("READ_ONLY");

            /// <summary>
            /// Enum READ_AND_WRITE for value: READ_AND_WRITE
            /// </summary>
            public static readonly RedirectionModeEnum READ_AND_WRITE = new RedirectionModeEnum("READ_AND_WRITE");

            private static readonly Dictionary<string, RedirectionModeEnum> StaticFields =
            new Dictionary<string, RedirectionModeEnum>()
            {
                { "DISABLED", DISABLED },
                { "READ_ONLY", READ_ONLY },
                { "READ_AND_WRITE", READ_AND_WRITE },
            };

            private string _value;

            public RedirectionModeEnum()
            {

            }

            public RedirectionModeEnum(string value)
            {
                _value = value;
            }

            public static RedirectionModeEnum FromValue(string value)
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

                if (this.Equals(obj as RedirectionModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RedirectionModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RedirectionModeEnum a, RedirectionModeEnum b)
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

            public static bool operator !=(RedirectionModeEnum a, RedirectionModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 文件重定向。取值为： DISABLED：表示禁用。（默认） READ_ONLY：表示只读。 READ_AND_WRITE：表示读写。
        /// </summary>
        [JsonProperty("redirection_mode", NullValueHandling = NullValueHandling.Ignore)]
        public RedirectionModeEnum RedirectionMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public FileRedirectionOptions Options { get; set; }

        /// <summary>
        /// 是否开启发送文件（虚机到客户端）。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("vm_send_file_client", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VmSendFileClient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("redirection_send_file_options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesFileAndClipboardFileRedirectionRedirectionSendFileOptions RedirectionSendFileOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesFileAndClipboardFileRedirection {\n");
            sb.Append("  redirectionMode: ").Append(RedirectionMode).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("  vmSendFileClient: ").Append(VmSendFileClient).Append("\n");
            sb.Append("  redirectionSendFileOptions: ").Append(RedirectionSendFileOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesFileAndClipboardFileRedirection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesFileAndClipboardFileRedirection input)
        {
            if (input == null) return false;
            if (this.RedirectionMode != input.RedirectionMode) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;
            if (this.VmSendFileClient != input.VmSendFileClient || (this.VmSendFileClient != null && !this.VmSendFileClient.Equals(input.VmSendFileClient))) return false;
            if (this.RedirectionSendFileOptions != input.RedirectionSendFileOptions || (this.RedirectionSendFileOptions != null && !this.RedirectionSendFileOptions.Equals(input.RedirectionSendFileOptions))) return false;

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
                hashCode = hashCode * 59 + this.RedirectionMode.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.VmSendFileClient != null) hashCode = hashCode * 59 + this.VmSendFileClient.GetHashCode();
                if (this.RedirectionSendFileOptions != null) hashCode = hashCode * 59 + this.RedirectionSendFileOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
