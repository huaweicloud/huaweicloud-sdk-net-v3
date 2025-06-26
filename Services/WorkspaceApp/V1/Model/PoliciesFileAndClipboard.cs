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
    /// 文件和剪切板。
    /// </summary>
    public class PoliciesFileAndClipboard 
    {
        /// <summary>
        /// 剪切板重定向。取值为： DISABLED：表示禁用。（默认） SERVER_TO_CLIENT_ENABLED：表示开启服务端到客户端。 CLIENT_TO_SERVER_ENABLED：表示开启客户端到服务端。 TWO_WAY_ENABLED：表示开启双向。
        /// </summary>
        /// <value>剪切板重定向。取值为： DISABLED：表示禁用。（默认） SERVER_TO_CLIENT_ENABLED：表示开启服务端到客户端。 CLIENT_TO_SERVER_ENABLED：表示开启客户端到服务端。 TWO_WAY_ENABLED：表示开启双向。</value>
        [JsonConverter(typeof(EnumClassConverter<ClipboardRedirectionEnum>))]
        public class ClipboardRedirectionEnum
        {
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly ClipboardRedirectionEnum DISABLED = new ClipboardRedirectionEnum("DISABLED");

            /// <summary>
            /// Enum SERVER_TO_CLIENT_ENABLED for value: SERVER_TO_CLIENT_ENABLED
            /// </summary>
            public static readonly ClipboardRedirectionEnum SERVER_TO_CLIENT_ENABLED = new ClipboardRedirectionEnum("SERVER_TO_CLIENT_ENABLED");

            /// <summary>
            /// Enum CLIENT_TO_SERVER_ENABLED for value: CLIENT_TO_SERVER_ENABLED
            /// </summary>
            public static readonly ClipboardRedirectionEnum CLIENT_TO_SERVER_ENABLED = new ClipboardRedirectionEnum("CLIENT_TO_SERVER_ENABLED");

            /// <summary>
            /// Enum TWO_WAY_ENABLED for value: TWO_WAY_ENABLED
            /// </summary>
            public static readonly ClipboardRedirectionEnum TWO_WAY_ENABLED = new ClipboardRedirectionEnum("TWO_WAY_ENABLED");

            private static readonly Dictionary<string, ClipboardRedirectionEnum> StaticFields =
            new Dictionary<string, ClipboardRedirectionEnum>()
            {
                { "DISABLED", DISABLED },
                { "SERVER_TO_CLIENT_ENABLED", SERVER_TO_CLIENT_ENABLED },
                { "CLIENT_TO_SERVER_ENABLED", CLIENT_TO_SERVER_ENABLED },
                { "TWO_WAY_ENABLED", TWO_WAY_ENABLED },
            };

            private string _value;

            public ClipboardRedirectionEnum()
            {

            }

            public ClipboardRedirectionEnum(string value)
            {
                _value = value;
            }

            public static ClipboardRedirectionEnum FromValue(string value)
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

                if (this.Equals(obj as ClipboardRedirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ClipboardRedirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ClipboardRedirectionEnum a, ClipboardRedirectionEnum b)
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

            public static bool operator !=(ClipboardRedirectionEnum a, ClipboardRedirectionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 应用聚合场景下是否双向放通：取值为： false：表示不放通。 true：表示放通。
        /// </summary>
        [JsonProperty("bypass_in_remote_app_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BypassInRemoteAppEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("file_redirection", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesFileAndClipboardFileRedirection FileRedirection { get; set; }

        /// <summary>
        /// 移动客户端文件重定向：取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("fd_mobile_client_redir_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FdMobileClientRedirEnable { get; set; }

        /// <summary>
        /// 剪切板重定向。取值为： DISABLED：表示禁用。（默认） SERVER_TO_CLIENT_ENABLED：表示开启服务端到客户端。 CLIENT_TO_SERVER_ENABLED：表示开启客户端到服务端。 TWO_WAY_ENABLED：表示开启双向。
        /// </summary>
        [JsonProperty("clipboard_redirection", NullValueHandling = NullValueHandling.Ignore)]
        public ClipboardRedirectionEnum ClipboardRedirection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("clipboard_redirection_options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesFileAndClipboardClipboardRedirectionOptions ClipboardRedirectionOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesFileAndClipboard {\n");
            sb.Append("  bypassInRemoteAppEnable: ").Append(BypassInRemoteAppEnable).Append("\n");
            sb.Append("  fileRedirection: ").Append(FileRedirection).Append("\n");
            sb.Append("  fdMobileClientRedirEnable: ").Append(FdMobileClientRedirEnable).Append("\n");
            sb.Append("  clipboardRedirection: ").Append(ClipboardRedirection).Append("\n");
            sb.Append("  clipboardRedirectionOptions: ").Append(ClipboardRedirectionOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesFileAndClipboard);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesFileAndClipboard input)
        {
            if (input == null) return false;
            if (this.BypassInRemoteAppEnable != input.BypassInRemoteAppEnable || (this.BypassInRemoteAppEnable != null && !this.BypassInRemoteAppEnable.Equals(input.BypassInRemoteAppEnable))) return false;
            if (this.FileRedirection != input.FileRedirection || (this.FileRedirection != null && !this.FileRedirection.Equals(input.FileRedirection))) return false;
            if (this.FdMobileClientRedirEnable != input.FdMobileClientRedirEnable || (this.FdMobileClientRedirEnable != null && !this.FdMobileClientRedirEnable.Equals(input.FdMobileClientRedirEnable))) return false;
            if (this.ClipboardRedirection != input.ClipboardRedirection) return false;
            if (this.ClipboardRedirectionOptions != input.ClipboardRedirectionOptions || (this.ClipboardRedirectionOptions != null && !this.ClipboardRedirectionOptions.Equals(input.ClipboardRedirectionOptions))) return false;

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
                if (this.BypassInRemoteAppEnable != null) hashCode = hashCode * 59 + this.BypassInRemoteAppEnable.GetHashCode();
                if (this.FileRedirection != null) hashCode = hashCode * 59 + this.FileRedirection.GetHashCode();
                if (this.FdMobileClientRedirEnable != null) hashCode = hashCode * 59 + this.FdMobileClientRedirEnable.GetHashCode();
                hashCode = hashCode * 59 + this.ClipboardRedirection.GetHashCode();
                if (this.ClipboardRedirectionOptions != null) hashCode = hashCode * 59 + this.ClipboardRedirectionOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
