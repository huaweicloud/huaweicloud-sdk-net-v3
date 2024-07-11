using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SetRefererChainInfo 
    {
        /// <summary>
        /// referer防盗链开关：true表示开启；false表示关闭
        /// </summary>
        /// <value>referer防盗链开关：true表示开启；false表示关闭</value>
        [JsonConverter(typeof(EnumClassConverter<GuardSwitchEnum>))]
        public class GuardSwitchEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly GuardSwitchEnum TRUE = new GuardSwitchEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly GuardSwitchEnum FALSE = new GuardSwitchEnum("false");

            private static readonly Dictionary<string, GuardSwitchEnum> StaticFields =
            new Dictionary<string, GuardSwitchEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public GuardSwitchEnum()
            {

            }

            public GuardSwitchEnum(string value)
            {
                _value = value;
            }

            public static GuardSwitchEnum FromValue(string value)
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

                if (this.Equals(obj as GuardSwitchEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(GuardSwitchEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(GuardSwitchEnum a, GuardSwitchEnum b)
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

            public static bool operator !=(GuardSwitchEnum a, GuardSwitchEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否包含referer头域：true表示包含；false表示不包含；guard_switch为true则必填
        /// </summary>
        /// <value>是否包含referer头域：true表示包含；false表示不包含；guard_switch为true则必填</value>
        [JsonConverter(typeof(EnumClassConverter<RefererConfigEmptyEnum>))]
        public class RefererConfigEmptyEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly RefererConfigEmptyEnum TRUE = new RefererConfigEmptyEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly RefererConfigEmptyEnum FALSE = new RefererConfigEmptyEnum("false");

            private static readonly Dictionary<string, RefererConfigEmptyEnum> StaticFields =
            new Dictionary<string, RefererConfigEmptyEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public RefererConfigEmptyEnum()
            {

            }

            public RefererConfigEmptyEnum(string value)
            {
                _value = value;
            }

            public static RefererConfigEmptyEnum FromValue(string value)
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

                if (this.Equals(obj as RefererConfigEmptyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RefererConfigEmptyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RefererConfigEmptyEnum a, RefererConfigEmptyEnum b)
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

            public static bool operator !=(RefererConfigEmptyEnum a, RefererConfigEmptyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否为referer白名单：true表示白名单；false表示黑名单；guard_switch为true则必填
        /// </summary>
        /// <value>是否为referer白名单：true表示白名单；false表示黑名单；guard_switch为true则必填</value>
        [JsonConverter(typeof(EnumClassConverter<RefererWhiteListEnum>))]
        public class RefererWhiteListEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly RefererWhiteListEnum TRUE = new RefererWhiteListEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly RefererWhiteListEnum FALSE = new RefererWhiteListEnum("false");

            private static readonly Dictionary<string, RefererWhiteListEnum> StaticFields =
            new Dictionary<string, RefererWhiteListEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public RefererWhiteListEnum()
            {

            }

            public RefererWhiteListEnum(string value)
            {
                _value = value;
            }

            public static RefererWhiteListEnum FromValue(string value)
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

                if (this.Equals(obj as RefererWhiteListEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RefererWhiteListEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RefererWhiteListEnum a, RefererWhiteListEnum b)
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

            public static bool operator !=(RefererWhiteListEnum a, RefererWhiteListEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 直播域名
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// referer防盗链开关：true表示开启；false表示关闭
        /// </summary>
        [JsonProperty("guard_switch", NullValueHandling = NullValueHandling.Ignore)]
        public GuardSwitchEnum GuardSwitch { get; set; }
        /// <summary>
        /// 是否包含referer头域：true表示包含；false表示不包含；guard_switch为true则必填
        /// </summary>
        [JsonProperty("referer_config_empty", NullValueHandling = NullValueHandling.Ignore)]
        public RefererConfigEmptyEnum RefererConfigEmpty { get; set; }
        /// <summary>
        /// 是否为referer白名单：true表示白名单；false表示黑名单；guard_switch为true则必填
        /// </summary>
        [JsonProperty("referer_white_list", NullValueHandling = NullValueHandling.Ignore)]
        public RefererWhiteListEnum RefererWhiteList { get; set; }
        /// <summary>
        /// 域名列表，域名为正则表达式；最多支持配置100个域名，以英文“;”进行分隔；guard_switch为true则必填
        /// </summary>
        [JsonProperty("referer_auth_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RefererAuthList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetRefererChainInfo {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  guardSwitch: ").Append(GuardSwitch).Append("\n");
            sb.Append("  refererConfigEmpty: ").Append(RefererConfigEmpty).Append("\n");
            sb.Append("  refererWhiteList: ").Append(RefererWhiteList).Append("\n");
            sb.Append("  refererAuthList: ").Append(RefererAuthList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetRefererChainInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetRefererChainInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.GuardSwitch == input.GuardSwitch ||
                    (this.GuardSwitch != null &&
                    this.GuardSwitch.Equals(input.GuardSwitch))
                ) && 
                (
                    this.RefererConfigEmpty == input.RefererConfigEmpty ||
                    (this.RefererConfigEmpty != null &&
                    this.RefererConfigEmpty.Equals(input.RefererConfigEmpty))
                ) && 
                (
                    this.RefererWhiteList == input.RefererWhiteList ||
                    (this.RefererWhiteList != null &&
                    this.RefererWhiteList.Equals(input.RefererWhiteList))
                ) && 
                (
                    this.RefererAuthList == input.RefererAuthList ||
                    this.RefererAuthList != null &&
                    input.RefererAuthList != null &&
                    this.RefererAuthList.SequenceEqual(input.RefererAuthList)
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.GuardSwitch != null)
                    hashCode = hashCode * 59 + this.GuardSwitch.GetHashCode();
                if (this.RefererConfigEmpty != null)
                    hashCode = hashCode * 59 + this.RefererConfigEmpty.GetHashCode();
                if (this.RefererWhiteList != null)
                    hashCode = hashCode * 59 + this.RefererWhiteList.GetHashCode();
                if (this.RefererAuthList != null)
                    hashCode = hashCode * 59 + this.RefererAuthList.GetHashCode();
                return hashCode;
            }
        }
    }
}
