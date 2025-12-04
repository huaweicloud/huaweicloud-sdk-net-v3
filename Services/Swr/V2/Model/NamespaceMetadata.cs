using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NamespaceMetadata 
    {
        /// <summary>
        /// 是否公开，可选true、false
        /// </summary>
        /// <value>是否公开，可选true、false</value>
        [JsonConverter(typeof(EnumClassConverter<PublicEnum>))]
        public class PublicEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly PublicEnum TRUE = new PublicEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly PublicEnum FALSE = new PublicEnum("false");

            private static readonly Dictionary<string, PublicEnum> StaticFields =
            new Dictionary<string, PublicEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public PublicEnum()
            {

            }

            public PublicEnum(string value)
            {
                _value = value;
            }

            public static PublicEnum FromValue(string value)
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

                if (this.Equals(obj as PublicEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PublicEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PublicEnum a, PublicEnum b)
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

            public static bool operator !=(PublicEnum a, PublicEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 上传制品时，是否自动触发制品扫描，可选true、false
        /// </summary>
        /// <value>上传制品时，是否自动触发制品扫描，可选true、false</value>
        [JsonConverter(typeof(EnumClassConverter<AutoScanEnum>))]
        public class AutoScanEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly AutoScanEnum TRUE = new AutoScanEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly AutoScanEnum FALSE = new AutoScanEnum("false");

            private static readonly Dictionary<string, AutoScanEnum> StaticFields =
            new Dictionary<string, AutoScanEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public AutoScanEnum()
            {

            }

            public AutoScanEnum(string value)
            {
                _value = value;
            }

            public static AutoScanEnum FromValue(string value)
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

                if (this.Equals(obj as AutoScanEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AutoScanEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AutoScanEnum a, AutoScanEnum b)
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

            public static bool operator !=(AutoScanEnum a, AutoScanEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否开启制品阻断，可选true、false
        /// </summary>
        /// <value>是否开启制品阻断，可选true、false</value>
        [JsonConverter(typeof(EnumClassConverter<PreventVulEnum>))]
        public class PreventVulEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly PreventVulEnum TRUE = new PreventVulEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly PreventVulEnum FALSE = new PreventVulEnum("false");

            private static readonly Dictionary<string, PreventVulEnum> StaticFields =
            new Dictionary<string, PreventVulEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public PreventVulEnum()
            {

            }

            public PreventVulEnum(string value)
            {
                _value = value;
            }

            public static PreventVulEnum FromValue(string value)
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

                if (this.Equals(obj as PreventVulEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PreventVulEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PreventVulEnum a, PreventVulEnum b)
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

            public static bool operator !=(PreventVulEnum a, PreventVulEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 阻断开启的场景下，如果存在漏洞，并且存在的漏洞严重程度高于此处定义的级别，则无法拉取镜像。可选值为\&quot;none\&quot;, \&quot;low\&quot;, \&quot;medium\&quot;, \&quot;high\&quot;, \&quot;critical\&quot;。
        /// </summary>
        /// <value>阻断开启的场景下，如果存在漏洞，并且存在的漏洞严重程度高于此处定义的级别，则无法拉取镜像。可选值为\&quot;none\&quot;, \&quot;low\&quot;, \&quot;medium\&quot;, \&quot;high\&quot;, \&quot;critical\&quot;。</value>
        [JsonConverter(typeof(EnumClassConverter<SeverityEnum>))]
        public class SeverityEnum
        {
            /// <summary>
            /// Enum NONE for value: none
            /// </summary>
            public static readonly SeverityEnum NONE = new SeverityEnum("none");

            /// <summary>
            /// Enum LOW for value: low
            /// </summary>
            public static readonly SeverityEnum LOW = new SeverityEnum("low");

            /// <summary>
            /// Enum MEDIUM for value: medium
            /// </summary>
            public static readonly SeverityEnum MEDIUM = new SeverityEnum("medium");

            /// <summary>
            /// Enum HIGH for value: high
            /// </summary>
            public static readonly SeverityEnum HIGH = new SeverityEnum("high");

            /// <summary>
            /// Enum CRITICAL for value: critical
            /// </summary>
            public static readonly SeverityEnum CRITICAL = new SeverityEnum("critical");

            private static readonly Dictionary<string, SeverityEnum> StaticFields =
            new Dictionary<string, SeverityEnum>()
            {
                { "none", NONE },
                { "low", LOW },
                { "medium", MEDIUM },
                { "high", HIGH },
                { "critical", CRITICAL },
            };

            private string _value;

            public SeverityEnum()
            {

            }

            public SeverityEnum(string value)
            {
                _value = value;
            }

            public static SeverityEnum FromValue(string value)
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

                if (this.Equals(obj as SeverityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SeverityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SeverityEnum a, SeverityEnum b)
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

            public static bool operator !=(SeverityEnum a, SeverityEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否公开，可选true、false
        /// </summary>
        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public PublicEnum Public { get; set; }
        /// <summary>
        /// 上传制品时，是否自动触发制品扫描，可选true、false
        /// </summary>
        [JsonProperty("auto_scan", NullValueHandling = NullValueHandling.Ignore)]
        public AutoScanEnum AutoScan { get; set; }
        /// <summary>
        /// 是否开启制品阻断，可选true、false
        /// </summary>
        [JsonProperty("prevent_vul", NullValueHandling = NullValueHandling.Ignore)]
        public PreventVulEnum PreventVul { get; set; }
        /// <summary>
        /// 阻断开启的场景下，如果存在漏洞，并且存在的漏洞严重程度高于此处定义的级别，则无法拉取镜像。可选值为\&quot;none\&quot;, \&quot;low\&quot;, \&quot;medium\&quot;, \&quot;high\&quot;, \&quot;critical\&quot;。
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public SeverityEnum Severity { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NamespaceMetadata {\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  autoScan: ").Append(AutoScan).Append("\n");
            sb.Append("  preventVul: ").Append(PreventVul).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NamespaceMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NamespaceMetadata input)
        {
            if (input == null) return false;
            if (this.Public != input.Public) return false;
            if (this.AutoScan != input.AutoScan) return false;
            if (this.PreventVul != input.PreventVul) return false;
            if (this.Severity != input.Severity) return false;

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
                hashCode = hashCode * 59 + this.Public.GetHashCode();
                hashCode = hashCode * 59 + this.AutoScan.GetHashCode();
                hashCode = hashCode * 59 + this.PreventVul.GetHashCode();
                hashCode = hashCode * 59 + this.Severity.GetHashCode();
                return hashCode;
            }
        }
    }
}
