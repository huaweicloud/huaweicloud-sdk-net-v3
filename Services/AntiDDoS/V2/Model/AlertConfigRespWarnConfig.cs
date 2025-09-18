using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V2.Model
{
    /// <summary>
    /// 告警配置信息
    /// </summary>
    public class AlertConfigRespWarnConfig 
    {
        /// <summary>
        /// 取值范围： - 0：表示每天一次 - 1：表示半小时一次  对于HID必选。
        /// </summary>
        /// <value>取值范围： - 0：表示每天一次 - 1：表示半小时一次  对于HID必选。</value>
        [JsonConverter(typeof(EnumClassConverter<SendFrequencyEnum>))]
        public class SendFrequencyEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly SendFrequencyEnum NUMBER_0 = new SendFrequencyEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly SendFrequencyEnum NUMBER_1 = new SendFrequencyEnum(1);

            private static readonly Dictionary<int?, SendFrequencyEnum> StaticFields =
            new Dictionary<int?, SendFrequencyEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public SendFrequencyEnum()
            {

            }

            public SendFrequencyEnum(int? value)
            {
                _value = value;
            }

            public static SendFrequencyEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as SendFrequencyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SendFrequencyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SendFrequencyEnum a, SendFrequencyEnum b)
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

            public static bool operator !=(SendFrequencyEnum a, SendFrequencyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// DDoS攻击
        /// </summary>
        [JsonProperty("antiDDoS", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AntiDDoS { get; set; }

        /// <summary>
        /// 网页后门
        /// </summary>
        [JsonProperty("back_doors", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BackDoors { get; set; }

        /// <summary>
        /// 暴力破解（系统登录，FTP，DB）
        /// </summary>
        [JsonProperty("bruce_force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BruceForce { get; set; }

        /// <summary>
        /// 数据库进程权限过高
        /// </summary>
        [JsonProperty("high_privilege", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HighPrivilege { get; set; }

        /// <summary>
        /// 异地登录提醒
        /// </summary>
        [JsonProperty("remote_login", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemoteLogin { get; set; }

        /// <summary>
        /// 取值范围： - 0：表示每天一次 - 1：表示半小时一次  对于HID必选。
        /// </summary>
        [JsonProperty("send_frequency", NullValueHandling = NullValueHandling.Ignore)]
        public SendFrequencyEnum SendFrequency { get; set; }
        /// <summary>
        /// 保留字段
        /// </summary>
        [JsonProperty("waf", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Waf { get; set; }

        /// <summary>
        /// 弱口令（系统，数据库）
        /// </summary>
        [JsonProperty("weak_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WeakPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertConfigRespWarnConfig {\n");
            sb.Append("  antiDDoS: ").Append(AntiDDoS).Append("\n");
            sb.Append("  backDoors: ").Append(BackDoors).Append("\n");
            sb.Append("  bruceForce: ").Append(BruceForce).Append("\n");
            sb.Append("  highPrivilege: ").Append(HighPrivilege).Append("\n");
            sb.Append("  remoteLogin: ").Append(RemoteLogin).Append("\n");
            sb.Append("  sendFrequency: ").Append(SendFrequency).Append("\n");
            sb.Append("  waf: ").Append(Waf).Append("\n");
            sb.Append("  weakPassword: ").Append(WeakPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlertConfigRespWarnConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlertConfigRespWarnConfig input)
        {
            if (input == null) return false;
            if (this.AntiDDoS != input.AntiDDoS || (this.AntiDDoS != null && !this.AntiDDoS.Equals(input.AntiDDoS))) return false;
            if (this.BackDoors != input.BackDoors || (this.BackDoors != null && !this.BackDoors.Equals(input.BackDoors))) return false;
            if (this.BruceForce != input.BruceForce || (this.BruceForce != null && !this.BruceForce.Equals(input.BruceForce))) return false;
            if (this.HighPrivilege != input.HighPrivilege || (this.HighPrivilege != null && !this.HighPrivilege.Equals(input.HighPrivilege))) return false;
            if (this.RemoteLogin != input.RemoteLogin || (this.RemoteLogin != null && !this.RemoteLogin.Equals(input.RemoteLogin))) return false;
            if (this.SendFrequency != input.SendFrequency) return false;
            if (this.Waf != input.Waf || (this.Waf != null && !this.Waf.Equals(input.Waf))) return false;
            if (this.WeakPassword != input.WeakPassword || (this.WeakPassword != null && !this.WeakPassword.Equals(input.WeakPassword))) return false;

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
                if (this.AntiDDoS != null) hashCode = hashCode * 59 + this.AntiDDoS.GetHashCode();
                if (this.BackDoors != null) hashCode = hashCode * 59 + this.BackDoors.GetHashCode();
                if (this.BruceForce != null) hashCode = hashCode * 59 + this.BruceForce.GetHashCode();
                if (this.HighPrivilege != null) hashCode = hashCode * 59 + this.HighPrivilege.GetHashCode();
                if (this.RemoteLogin != null) hashCode = hashCode * 59 + this.RemoteLogin.GetHashCode();
                hashCode = hashCode * 59 + this.SendFrequency.GetHashCode();
                if (this.Waf != null) hashCode = hashCode * 59 + this.Waf.GetHashCode();
                if (this.WeakPassword != null) hashCode = hashCode * 59 + this.WeakPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
