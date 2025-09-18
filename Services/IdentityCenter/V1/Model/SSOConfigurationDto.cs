using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// the struct of SSOConfiguration
    /// </summary>
    public class SSOConfigurationDto 
    {
        /// <summary>
        /// MFA生效模式
        /// </summary>
        /// <value>MFA生效模式</value>
        [JsonConverter(typeof(EnumClassConverter<MfaModeEnum>))]
        public class MfaModeEnum
        {
            /// <summary>
            /// Enum CONTEXT_AWARE for value: CONTEXT_AWARE
            /// </summary>
            public static readonly MfaModeEnum CONTEXT_AWARE = new MfaModeEnum("CONTEXT_AWARE");

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly MfaModeEnum DISABLED = new MfaModeEnum("DISABLED");

            /// <summary>
            /// Enum ALWAYS_ON for value: ALWAYS_ON
            /// </summary>
            public static readonly MfaModeEnum ALWAYS_ON = new MfaModeEnum("ALWAYS_ON");

            private static readonly Dictionary<string, MfaModeEnum> StaticFields =
            new Dictionary<string, MfaModeEnum>()
            {
                { "CONTEXT_AWARE", CONTEXT_AWARE },
                { "DISABLED", DISABLED },
                { "ALWAYS_ON", ALWAYS_ON },
            };

            private string _value;

            public MfaModeEnum()
            {

            }

            public MfaModeEnum(string value)
            {
                _value = value;
            }

            public static MfaModeEnum FromValue(string value)
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

                if (this.Equals(obj as MfaModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MfaModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MfaModeEnum a, MfaModeEnum b)
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

            public static bool operator !=(MfaModeEnum a, MfaModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 未注册MFA情况下，可选择的登录行为
        /// </summary>
        /// <value>未注册MFA情况下，可选择的登录行为</value>
        [JsonConverter(typeof(EnumClassConverter<NoMfaSigninBehaviorEnum>))]
        public class NoMfaSigninBehaviorEnum
        {
            /// <summary>
            /// Enum ALLOWED_WITH_ENROLLMENT for value: ALLOWED_WITH_ENROLLMENT
            /// </summary>
            public static readonly NoMfaSigninBehaviorEnum ALLOWED_WITH_ENROLLMENT = new NoMfaSigninBehaviorEnum("ALLOWED_WITH_ENROLLMENT");

            /// <summary>
            /// Enum ALLOWED for value: ALLOWED
            /// </summary>
            public static readonly NoMfaSigninBehaviorEnum ALLOWED = new NoMfaSigninBehaviorEnum("ALLOWED");

            /// <summary>
            /// Enum EMAIL_OTP for value: EMAIL_OTP
            /// </summary>
            public static readonly NoMfaSigninBehaviorEnum EMAIL_OTP = new NoMfaSigninBehaviorEnum("EMAIL_OTP");

            /// <summary>
            /// Enum BLOCKED for value: BLOCKED
            /// </summary>
            public static readonly NoMfaSigninBehaviorEnum BLOCKED = new NoMfaSigninBehaviorEnum("BLOCKED");

            private static readonly Dictionary<string, NoMfaSigninBehaviorEnum> StaticFields =
            new Dictionary<string, NoMfaSigninBehaviorEnum>()
            {
                { "ALLOWED_WITH_ENROLLMENT", ALLOWED_WITH_ENROLLMENT },
                { "ALLOWED", ALLOWED },
                { "EMAIL_OTP", EMAIL_OTP },
                { "BLOCKED", BLOCKED },
            };

            private string _value;

            public NoMfaSigninBehaviorEnum()
            {

            }

            public NoMfaSigninBehaviorEnum(string value)
            {
                _value = value;
            }

            public static NoMfaSigninBehaviorEnum FromValue(string value)
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

                if (this.Equals(obj as NoMfaSigninBehaviorEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NoMfaSigninBehaviorEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NoMfaSigninBehaviorEnum a, NoMfaSigninBehaviorEnum b)
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

            public static bool operator !=(NoMfaSigninBehaviorEnum a, NoMfaSigninBehaviorEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 没有密码情况下登录的行为
        /// </summary>
        /// <value>没有密码情况下登录的行为</value>
        [JsonConverter(typeof(EnumClassConverter<NoPasswordSigninBehaviorEnum>))]
        public class NoPasswordSigninBehaviorEnum
        {
            /// <summary>
            /// Enum BLOCKED for value: BLOCKED
            /// </summary>
            public static readonly NoPasswordSigninBehaviorEnum BLOCKED = new NoPasswordSigninBehaviorEnum("BLOCKED");

            /// <summary>
            /// Enum EMAIL_OTP for value: EMAIL_OTP
            /// </summary>
            public static readonly NoPasswordSigninBehaviorEnum EMAIL_OTP = new NoPasswordSigninBehaviorEnum("EMAIL_OTP");

            private static readonly Dictionary<string, NoPasswordSigninBehaviorEnum> StaticFields =
            new Dictionary<string, NoPasswordSigninBehaviorEnum>()
            {
                { "BLOCKED", BLOCKED },
                { "EMAIL_OTP", EMAIL_OTP },
            };

            private string _value;

            public NoPasswordSigninBehaviorEnum()
            {

            }

            public NoPasswordSigninBehaviorEnum(string value)
            {
                _value = value;
            }

            public static NoPasswordSigninBehaviorEnum FromValue(string value)
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

                if (this.Equals(obj as NoPasswordSigninBehaviorEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NoPasswordSigninBehaviorEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NoPasswordSigninBehaviorEnum a, NoPasswordSigninBehaviorEnum b)
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

            public static bool operator !=(NoPasswordSigninBehaviorEnum a, NoPasswordSigninBehaviorEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines allowedMfaTypes
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<AllowedMfaTypesEnum>))]
        public class AllowedMfaTypesEnum
        {
            /// <summary>
            /// Enum TOTP for value: TOTP
            /// </summary>
            public static readonly AllowedMfaTypesEnum TOTP = new AllowedMfaTypesEnum("TOTP");

            /// <summary>
            /// Enum WEBAUTHN for value: WEBAUTHN
            /// </summary>
            public static readonly AllowedMfaTypesEnum WEBAUTHN = new AllowedMfaTypesEnum("WEBAUTHN");

            /// <summary>
            /// Enum WEBAUTHN_SECURITY_KEY for value: WEBAUTHN_SECURITY_KEY
            /// </summary>
            public static readonly AllowedMfaTypesEnum WEBAUTHN_SECURITY_KEY = new AllowedMfaTypesEnum("WEBAUTHN_SECURITY_KEY");

            private static readonly Dictionary<string, AllowedMfaTypesEnum> StaticFields =
            new Dictionary<string, AllowedMfaTypesEnum>()
            {
                { "TOTP", TOTP },
                { "WEBAUTHN", WEBAUTHN },
                { "WEBAUTHN_SECURITY_KEY", WEBAUTHN_SECURITY_KEY },
            };

            private string _value;

            public AllowedMfaTypesEnum()
            {

            }

            public AllowedMfaTypesEnum(string value)
            {
                _value = value;
            }

            public static AllowedMfaTypesEnum FromValue(string value)
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

                if (this.Equals(obj as AllowedMfaTypesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AllowedMfaTypesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AllowedMfaTypesEnum a, AllowedMfaTypesEnum b)
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

            public static bool operator !=(AllowedMfaTypesEnum a, AllowedMfaTypesEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// MFA生效模式
        /// </summary>
        [JsonProperty("mfa_mode", NullValueHandling = NullValueHandling.Ignore)]
        public MfaModeEnum MfaMode { get; set; }
        /// <summary>
        /// 未注册MFA情况下，可选择的登录行为
        /// </summary>
        [JsonProperty("no_mfa_signin_behavior", NullValueHandling = NullValueHandling.Ignore)]
        public NoMfaSigninBehaviorEnum NoMfaSigninBehavior { get; set; }
        /// <summary>
        /// 没有密码情况下登录的行为
        /// </summary>
        [JsonProperty("no_password_signin_behavior", NullValueHandling = NullValueHandling.Ignore)]
        public NoPasswordSigninBehaviorEnum NoPasswordSigninBehavior { get; set; }
        /// <summary>
        /// 允许的MFA类型
        /// </summary>
        [JsonProperty("allowed_mfa_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowedMfaTypesEnum> AllowedMfaTypes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("session_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public SessionConfigurationDto SessionConfiguration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SSOConfigurationDto {\n");
            sb.Append("  mfaMode: ").Append(MfaMode).Append("\n");
            sb.Append("  noMfaSigninBehavior: ").Append(NoMfaSigninBehavior).Append("\n");
            sb.Append("  noPasswordSigninBehavior: ").Append(NoPasswordSigninBehavior).Append("\n");
            sb.Append("  allowedMfaTypes: ").Append(AllowedMfaTypes).Append("\n");
            sb.Append("  sessionConfiguration: ").Append(SessionConfiguration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SSOConfigurationDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SSOConfigurationDto input)
        {
            if (input == null) return false;
            if (this.MfaMode != input.MfaMode) return false;
            if (this.NoMfaSigninBehavior != input.NoMfaSigninBehavior) return false;
            if (this.NoPasswordSigninBehavior != input.NoPasswordSigninBehavior) return false;
            if (this.AllowedMfaTypes != input.AllowedMfaTypes || (this.AllowedMfaTypes != null && input.AllowedMfaTypes != null && !this.AllowedMfaTypes.SequenceEqual(input.AllowedMfaTypes))) return false;
            if (this.SessionConfiguration != input.SessionConfiguration || (this.SessionConfiguration != null && !this.SessionConfiguration.Equals(input.SessionConfiguration))) return false;

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
                hashCode = hashCode * 59 + this.MfaMode.GetHashCode();
                hashCode = hashCode * 59 + this.NoMfaSigninBehavior.GetHashCode();
                hashCode = hashCode * 59 + this.NoPasswordSigninBehavior.GetHashCode();
                hashCode = hashCode * 59 + this.AllowedMfaTypes.GetHashCode();
                if (this.SessionConfiguration != null) hashCode = hashCode * 59 + this.SessionConfiguration.GetHashCode();
                return hashCode;
            }
        }
    }
}
