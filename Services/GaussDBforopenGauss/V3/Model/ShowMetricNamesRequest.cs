using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowMetricNamesRequest 
    {
        /// <summary>
        /// **参数解释**: 语言。 **约束限制**: 不涉及。 **取值范围**: - zh-cn  - en-us  **默认取值**: en-us
        /// </summary>
        /// <value>**参数解释**: 语言。 **约束限制**: 不涉及。 **取值范围**: - zh-cn  - en-us  **默认取值**: en-us</value>
        [JsonConverter(typeof(EnumClassConverter<XLanguageEnum>))]
        public class XLanguageEnum
        {
            /// <summary>
            /// Enum ZH_CN for value: zh-cn
            /// </summary>
            public static readonly XLanguageEnum ZH_CN = new XLanguageEnum("zh-cn");

            /// <summary>
            /// Enum EN_US for value: en-us
            /// </summary>
            public static readonly XLanguageEnum EN_US = new XLanguageEnum("en-us");

            private static readonly Dictionary<string, XLanguageEnum> StaticFields =
            new Dictionary<string, XLanguageEnum>()
            {
                { "zh-cn", ZH_CN },
                { "en-us", EN_US },
            };

            private string _value;

            public XLanguageEnum()
            {

            }

            public XLanguageEnum(string value)
            {
                _value = value;
            }

            public static XLanguageEnum FromValue(string value)
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

                if (this.Equals(obj as XLanguageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(XLanguageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(XLanguageEnum a, XLanguageEnum b)
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

            public static bool operator !=(XLanguageEnum a, XLanguageEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**: 指标分组名称。 **约束限制**: 不涉及。 **取值范围**: - CPUMEMORY：CPU/内存。 - IOSTORAGE：IO存储。 - NETWORK：网络。 - CONNECTION：连接。 - TRANSACTION：事务。 - LOCK：锁。 - SYNCSTAT：同步状态。 - PROCESSRESOURCE：进程资源。  **默认取值**: 不涉及。
        /// </summary>
        /// <value>**参数解释**: 指标分组名称。 **约束限制**: 不涉及。 **取值范围**: - CPUMEMORY：CPU/内存。 - IOSTORAGE：IO存储。 - NETWORK：网络。 - CONNECTION：连接。 - TRANSACTION：事务。 - LOCK：锁。 - SYNCSTAT：同步状态。 - PROCESSRESOURCE：进程资源。  **默认取值**: 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<GroupNameEnum>))]
        public class GroupNameEnum
        {
            /// <summary>
            /// Enum CPUMEMORY for value: CPUMEMORY
            /// </summary>
            public static readonly GroupNameEnum CPUMEMORY = new GroupNameEnum("CPUMEMORY");

            /// <summary>
            /// Enum IOSTORAGE for value: IOSTORAGE
            /// </summary>
            public static readonly GroupNameEnum IOSTORAGE = new GroupNameEnum("IOSTORAGE");

            /// <summary>
            /// Enum NETWORK for value: NETWORK
            /// </summary>
            public static readonly GroupNameEnum NETWORK = new GroupNameEnum("NETWORK");

            /// <summary>
            /// Enum CONNECTION for value: CONNECTION
            /// </summary>
            public static readonly GroupNameEnum CONNECTION = new GroupNameEnum("CONNECTION");

            /// <summary>
            /// Enum TRANSACTION for value: TRANSACTION
            /// </summary>
            public static readonly GroupNameEnum TRANSACTION = new GroupNameEnum("TRANSACTION");

            /// <summary>
            /// Enum LOCK for value: LOCK
            /// </summary>
            public static readonly GroupNameEnum LOCK = new GroupNameEnum("LOCK");

            /// <summary>
            /// Enum SYNCSTAT for value: SYNCSTAT
            /// </summary>
            public static readonly GroupNameEnum SYNCSTAT = new GroupNameEnum("SYNCSTAT");

            /// <summary>
            /// Enum PROCESSRESOURCE for value: PROCESSRESOURCE
            /// </summary>
            public static readonly GroupNameEnum PROCESSRESOURCE = new GroupNameEnum("PROCESSRESOURCE");

            private static readonly Dictionary<string, GroupNameEnum> StaticFields =
            new Dictionary<string, GroupNameEnum>()
            {
                { "CPUMEMORY", CPUMEMORY },
                { "IOSTORAGE", IOSTORAGE },
                { "NETWORK", NETWORK },
                { "CONNECTION", CONNECTION },
                { "TRANSACTION", TRANSACTION },
                { "LOCK", LOCK },
                { "SYNCSTAT", SYNCSTAT },
                { "PROCESSRESOURCE", PROCESSRESOURCE },
            };

            private string _value;

            public GroupNameEnum()
            {

            }

            public GroupNameEnum(string value)
            {
                _value = value;
            }

            public static GroupNameEnum FromValue(string value)
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

                if (this.Equals(obj as GroupNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(GroupNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(GroupNameEnum a, GroupNameEnum b)
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

            public static bool operator !=(GroupNameEnum a, GroupNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 语言。 **约束限制**: 不涉及。 **取值范围**: - zh-cn  - en-us  **默认取值**: en-us
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public XLanguageEnum XLanguage { get; set; }
        /// <summary>
        /// **参数解释**: 指标分组名称。 **约束限制**: 不涉及。 **取值范围**: - CPUMEMORY：CPU/内存。 - IOSTORAGE：IO存储。 - NETWORK：网络。 - CONNECTION：连接。 - TRANSACTION：事务。 - LOCK：锁。 - SYNCSTAT：同步状态。 - PROCESSRESOURCE：进程资源。  **默认取值**: 不涉及。
        /// </summary>
        [SDKProperty("group_name", IsQuery = true)]
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public GroupNameEnum GroupName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMetricNamesRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMetricNamesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMetricNamesRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage) return false;
            if (this.GroupName != input.GroupName) return false;

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
                hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                return hashCode;
            }
        }
    }
}
