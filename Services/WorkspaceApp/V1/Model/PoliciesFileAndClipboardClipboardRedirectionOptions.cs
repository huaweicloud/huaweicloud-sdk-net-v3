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
    /// 剪切板重定向控制的选项。
    /// </summary>
    public class PoliciesFileAndClipboardClipboardRedirectionOptions 
    {
        /// <summary>
        /// 剪切板富文本重定向。取值为： DISABLED：表示禁用。（默认） SERVER_TO_CLIENT_ENABLED：表示开启服务端到客户端。 CLIENT_TO_SERVER_ENABLED：表示开启客户端到服务端。 TWO_WAY_ENABLED：表示开启双向。
        /// </summary>
        /// <value>剪切板富文本重定向。取值为： DISABLED：表示禁用。（默认） SERVER_TO_CLIENT_ENABLED：表示开启服务端到客户端。 CLIENT_TO_SERVER_ENABLED：表示开启客户端到服务端。 TWO_WAY_ENABLED：表示开启双向。</value>
        [JsonConverter(typeof(EnumClassConverter<RichTextClipboardRedirectionEnum>))]
        public class RichTextClipboardRedirectionEnum
        {
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly RichTextClipboardRedirectionEnum DISABLED = new RichTextClipboardRedirectionEnum("DISABLED");

            /// <summary>
            /// Enum SERVER_TO_CLIENT_ENABLED for value: SERVER_TO_CLIENT_ENABLED
            /// </summary>
            public static readonly RichTextClipboardRedirectionEnum SERVER_TO_CLIENT_ENABLED = new RichTextClipboardRedirectionEnum("SERVER_TO_CLIENT_ENABLED");

            /// <summary>
            /// Enum CLIENT_TO_SERVER_ENABLED for value: CLIENT_TO_SERVER_ENABLED
            /// </summary>
            public static readonly RichTextClipboardRedirectionEnum CLIENT_TO_SERVER_ENABLED = new RichTextClipboardRedirectionEnum("CLIENT_TO_SERVER_ENABLED");

            /// <summary>
            /// Enum TWO_WAY_ENABLED for value: TWO_WAY_ENABLED
            /// </summary>
            public static readonly RichTextClipboardRedirectionEnum TWO_WAY_ENABLED = new RichTextClipboardRedirectionEnum("TWO_WAY_ENABLED");

            private static readonly Dictionary<string, RichTextClipboardRedirectionEnum> StaticFields =
            new Dictionary<string, RichTextClipboardRedirectionEnum>()
            {
                { "DISABLED", DISABLED },
                { "SERVER_TO_CLIENT_ENABLED", SERVER_TO_CLIENT_ENABLED },
                { "CLIENT_TO_SERVER_ENABLED", CLIENT_TO_SERVER_ENABLED },
                { "TWO_WAY_ENABLED", TWO_WAY_ENABLED },
            };

            private string _value;

            public RichTextClipboardRedirectionEnum()
            {

            }

            public RichTextClipboardRedirectionEnum(string value)
            {
                _value = value;
            }

            public static RichTextClipboardRedirectionEnum FromValue(string value)
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

                if (this.Equals(obj as RichTextClipboardRedirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RichTextClipboardRedirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RichTextClipboardRedirectionEnum a, RichTextClipboardRedirectionEnum b)
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

            public static bool operator !=(RichTextClipboardRedirectionEnum a, RichTextClipboardRedirectionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 剪切板文件重定向。取值为： DISABLED：表示禁用。（默认） SERVER_TO_CLIENT_ENABLED：表示开启服务端到客户端。 CLIENT_TO_SERVER_ENABLED：表示开启客户端到服务端。 TWO_WAY_ENABLED：表示开启双向。
        /// </summary>
        /// <value>剪切板文件重定向。取值为： DISABLED：表示禁用。（默认） SERVER_TO_CLIENT_ENABLED：表示开启服务端到客户端。 CLIENT_TO_SERVER_ENABLED：表示开启客户端到服务端。 TWO_WAY_ENABLED：表示开启双向。</value>
        [JsonConverter(typeof(EnumClassConverter<FileClipboardRedirectionEnum>))]
        public class FileClipboardRedirectionEnum
        {
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly FileClipboardRedirectionEnum DISABLED = new FileClipboardRedirectionEnum("DISABLED");

            /// <summary>
            /// Enum SERVER_TO_CLIENT_ENABLED for value: SERVER_TO_CLIENT_ENABLED
            /// </summary>
            public static readonly FileClipboardRedirectionEnum SERVER_TO_CLIENT_ENABLED = new FileClipboardRedirectionEnum("SERVER_TO_CLIENT_ENABLED");

            /// <summary>
            /// Enum CLIENT_TO_SERVER_ENABLED for value: CLIENT_TO_SERVER_ENABLED
            /// </summary>
            public static readonly FileClipboardRedirectionEnum CLIENT_TO_SERVER_ENABLED = new FileClipboardRedirectionEnum("CLIENT_TO_SERVER_ENABLED");

            /// <summary>
            /// Enum TWO_WAY_ENABLED for value: TWO_WAY_ENABLED
            /// </summary>
            public static readonly FileClipboardRedirectionEnum TWO_WAY_ENABLED = new FileClipboardRedirectionEnum("TWO_WAY_ENABLED");

            private static readonly Dictionary<string, FileClipboardRedirectionEnum> StaticFields =
            new Dictionary<string, FileClipboardRedirectionEnum>()
            {
                { "DISABLED", DISABLED },
                { "SERVER_TO_CLIENT_ENABLED", SERVER_TO_CLIENT_ENABLED },
                { "CLIENT_TO_SERVER_ENABLED", CLIENT_TO_SERVER_ENABLED },
                { "TWO_WAY_ENABLED", TWO_WAY_ENABLED },
            };

            private string _value;

            public FileClipboardRedirectionEnum()
            {

            }

            public FileClipboardRedirectionEnum(string value)
            {
                _value = value;
            }

            public static FileClipboardRedirectionEnum FromValue(string value)
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

                if (this.Equals(obj as FileClipboardRedirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FileClipboardRedirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FileClipboardRedirectionEnum a, FileClipboardRedirectionEnum b)
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

            public static bool operator !=(FileClipboardRedirectionEnum a, FileClipboardRedirectionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否开启剪切板富文本重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("rich_text_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RichTextRedirectionEnable { get; set; }

        /// <summary>
        /// 剪切板富文本重定向。取值为： DISABLED：表示禁用。（默认） SERVER_TO_CLIENT_ENABLED：表示开启服务端到客户端。 CLIENT_TO_SERVER_ENABLED：表示开启客户端到服务端。 TWO_WAY_ENABLED：表示开启双向。
        /// </summary>
        [JsonProperty("rich_text_clipboard_redirection", NullValueHandling = NullValueHandling.Ignore)]
        public RichTextClipboardRedirectionEnum RichTextClipboardRedirection { get; set; }
        /// <summary>
        /// 是否开启剪切板文件重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("clipboard_file_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClipboardFileRedirectionEnable { get; set; }

        /// <summary>
        /// 剪切板文件重定向。取值为： DISABLED：表示禁用。（默认） SERVER_TO_CLIENT_ENABLED：表示开启服务端到客户端。 CLIENT_TO_SERVER_ENABLED：表示开启客户端到服务端。 TWO_WAY_ENABLED：表示开启双向。
        /// </summary>
        [JsonProperty("file_clipboard_redirection", NullValueHandling = NullValueHandling.Ignore)]
        public FileClipboardRedirectionEnum FileClipboardRedirection { get; set; }
        /// <summary>
        /// 本地到虚拟机长度限制开关。取值为： false: 标识关闭。 ture: 标识开启。
        /// </summary>
        [JsonProperty("clipboard_length_limit_cts_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClipboardLengthLimitCtsEnable { get; set; }

        /// <summary>
        /// 本地到虚拟机长度限制。
        /// </summary>
        [JsonProperty("clipboard_length_limit_cts", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClipboardLengthLimitCts { get; set; }

        /// <summary>
        /// 虚拟机到本地到长度限制开关。取值为： false: 标识关闭。 ture: 标识开启。
        /// </summary>
        [JsonProperty("clipboard_length_limit_stc_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClipboardLengthLimitStcEnable { get; set; }

        /// <summary>
        /// 虚拟机到本地长度限制。
        /// </summary>
        [JsonProperty("clipboard_length_limit_stc", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClipboardLengthLimitStc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesFileAndClipboardClipboardRedirectionOptions {\n");
            sb.Append("  richTextRedirectionEnable: ").Append(RichTextRedirectionEnable).Append("\n");
            sb.Append("  richTextClipboardRedirection: ").Append(RichTextClipboardRedirection).Append("\n");
            sb.Append("  clipboardFileRedirectionEnable: ").Append(ClipboardFileRedirectionEnable).Append("\n");
            sb.Append("  fileClipboardRedirection: ").Append(FileClipboardRedirection).Append("\n");
            sb.Append("  clipboardLengthLimitCtsEnable: ").Append(ClipboardLengthLimitCtsEnable).Append("\n");
            sb.Append("  clipboardLengthLimitCts: ").Append(ClipboardLengthLimitCts).Append("\n");
            sb.Append("  clipboardLengthLimitStcEnable: ").Append(ClipboardLengthLimitStcEnable).Append("\n");
            sb.Append("  clipboardLengthLimitStc: ").Append(ClipboardLengthLimitStc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesFileAndClipboardClipboardRedirectionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesFileAndClipboardClipboardRedirectionOptions input)
        {
            if (input == null) return false;
            if (this.RichTextRedirectionEnable != input.RichTextRedirectionEnable || (this.RichTextRedirectionEnable != null && !this.RichTextRedirectionEnable.Equals(input.RichTextRedirectionEnable))) return false;
            if (this.RichTextClipboardRedirection != input.RichTextClipboardRedirection) return false;
            if (this.ClipboardFileRedirectionEnable != input.ClipboardFileRedirectionEnable || (this.ClipboardFileRedirectionEnable != null && !this.ClipboardFileRedirectionEnable.Equals(input.ClipboardFileRedirectionEnable))) return false;
            if (this.FileClipboardRedirection != input.FileClipboardRedirection) return false;
            if (this.ClipboardLengthLimitCtsEnable != input.ClipboardLengthLimitCtsEnable || (this.ClipboardLengthLimitCtsEnable != null && !this.ClipboardLengthLimitCtsEnable.Equals(input.ClipboardLengthLimitCtsEnable))) return false;
            if (this.ClipboardLengthLimitCts != input.ClipboardLengthLimitCts || (this.ClipboardLengthLimitCts != null && !this.ClipboardLengthLimitCts.Equals(input.ClipboardLengthLimitCts))) return false;
            if (this.ClipboardLengthLimitStcEnable != input.ClipboardLengthLimitStcEnable || (this.ClipboardLengthLimitStcEnable != null && !this.ClipboardLengthLimitStcEnable.Equals(input.ClipboardLengthLimitStcEnable))) return false;
            if (this.ClipboardLengthLimitStc != input.ClipboardLengthLimitStc || (this.ClipboardLengthLimitStc != null && !this.ClipboardLengthLimitStc.Equals(input.ClipboardLengthLimitStc))) return false;

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
                if (this.RichTextRedirectionEnable != null) hashCode = hashCode * 59 + this.RichTextRedirectionEnable.GetHashCode();
                hashCode = hashCode * 59 + this.RichTextClipboardRedirection.GetHashCode();
                if (this.ClipboardFileRedirectionEnable != null) hashCode = hashCode * 59 + this.ClipboardFileRedirectionEnable.GetHashCode();
                hashCode = hashCode * 59 + this.FileClipboardRedirection.GetHashCode();
                if (this.ClipboardLengthLimitCtsEnable != null) hashCode = hashCode * 59 + this.ClipboardLengthLimitCtsEnable.GetHashCode();
                if (this.ClipboardLengthLimitCts != null) hashCode = hashCode * 59 + this.ClipboardLengthLimitCts.GetHashCode();
                if (this.ClipboardLengthLimitStcEnable != null) hashCode = hashCode * 59 + this.ClipboardLengthLimitStcEnable.GetHashCode();
                if (this.ClipboardLengthLimitStc != null) hashCode = hashCode * 59 + this.ClipboardLengthLimitStc.GetHashCode();
                return hashCode;
            }
        }
    }
}
