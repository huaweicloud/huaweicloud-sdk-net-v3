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
    public class UpdateSignaturePolicyRequestBody 
    {
        /// <summary>
        /// 加签方式，可选KMS
        /// </summary>
        /// <value>加签方式，可选KMS</value>
        [JsonConverter(typeof(EnumClassConverter<SignatureMethodEnum>))]
        public class SignatureMethodEnum
        {
            /// <summary>
            /// Enum KMS for value: KMS
            /// </summary>
            public static readonly SignatureMethodEnum KMS = new SignatureMethodEnum("KMS");

            private static readonly Dictionary<string, SignatureMethodEnum> StaticFields =
            new Dictionary<string, SignatureMethodEnum>()
            {
                { "KMS", KMS },
            };

            private string _value;

            public SignatureMethodEnum()
            {

            }

            public SignatureMethodEnum(string value)
            {
                _value = value;
            }

            public static SignatureMethodEnum FromValue(string value)
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

                if (this.Equals(obj as SignatureMethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SignatureMethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SignatureMethodEnum a, SignatureMethodEnum b)
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

            public static bool operator !=(SignatureMethodEnum a, SignatureMethodEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 加签算法，KMS的密钥算法EC_P256对应着ECDSA_SHA_256，EC_P384对应着ECDSA_SHA_384，SM2对应着SM2DSA_SM3
        /// </summary>
        /// <value>加签算法，KMS的密钥算法EC_P256对应着ECDSA_SHA_256，EC_P384对应着ECDSA_SHA_384，SM2对应着SM2DSA_SM3</value>
        [JsonConverter(typeof(EnumClassConverter<SignatureAlgorithmEnum>))]
        public class SignatureAlgorithmEnum
        {
            /// <summary>
            /// Enum ECDSA_SHA_384 for value: ECDSA_SHA_384
            /// </summary>
            public static readonly SignatureAlgorithmEnum ECDSA_SHA_384 = new SignatureAlgorithmEnum("ECDSA_SHA_384");

            /// <summary>
            /// Enum SM2DSA_SM3 for value: SM2DSA_SM3
            /// </summary>
            public static readonly SignatureAlgorithmEnum SM2DSA_SM3 = new SignatureAlgorithmEnum("SM2DSA_SM3");

            /// <summary>
            /// Enum ECDSA_SHA_256 for value: ECDSA_SHA_256
            /// </summary>
            public static readonly SignatureAlgorithmEnum ECDSA_SHA_256 = new SignatureAlgorithmEnum("ECDSA_SHA_256");

            private static readonly Dictionary<string, SignatureAlgorithmEnum> StaticFields =
            new Dictionary<string, SignatureAlgorithmEnum>()
            {
                { "ECDSA_SHA_384", ECDSA_SHA_384 },
                { "SM2DSA_SM3", SM2DSA_SM3 },
                { "ECDSA_SHA_256", ECDSA_SHA_256 },
            };

            private string _value;

            public SignatureAlgorithmEnum()
            {

            }

            public SignatureAlgorithmEnum(string value)
            {
                _value = value;
            }

            public static SignatureAlgorithmEnum FromValue(string value)
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

                if (this.Equals(obj as SignatureAlgorithmEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SignatureAlgorithmEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SignatureAlgorithmEnum a, SignatureAlgorithmEnum b)
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

            public static bool operator !=(SignatureAlgorithmEnum a, SignatureAlgorithmEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 签名策略名称，由字母、汉字、数字、下划线（_）、中划线 (-)组成，1-256个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 签名策略描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 是否开启
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 加签方式，可选KMS
        /// </summary>
        [JsonProperty("signature_method", NullValueHandling = NullValueHandling.Ignore)]
        public SignatureMethodEnum SignatureMethod { get; set; }
        /// <summary>
        /// 加签算法，KMS的密钥算法EC_P256对应着ECDSA_SHA_256，EC_P384对应着ECDSA_SHA_384，SM2对应着SM2DSA_SM3
        /// </summary>
        [JsonProperty("signature_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public SignatureAlgorithmEnum SignatureAlgorithm { get; set; }
        /// <summary>
        /// 加签Key
        /// </summary>
        [JsonProperty("signature_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("trigger", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerConfig Trigger { get; set; }

        /// <summary>
        /// 作用范围规则
        /// </summary>
        [JsonProperty("scope_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<SignScopeRule> ScopeRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSignaturePolicyRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  signatureMethod: ").Append(SignatureMethod).Append("\n");
            sb.Append("  signatureAlgorithm: ").Append(SignatureAlgorithm).Append("\n");
            sb.Append("  signatureKey: ").Append(SignatureKey).Append("\n");
            sb.Append("  trigger: ").Append(Trigger).Append("\n");
            sb.Append("  scopeRules: ").Append(ScopeRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSignaturePolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSignaturePolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.SignatureMethod != input.SignatureMethod) return false;
            if (this.SignatureAlgorithm != input.SignatureAlgorithm) return false;
            if (this.SignatureKey != input.SignatureKey || (this.SignatureKey != null && !this.SignatureKey.Equals(input.SignatureKey))) return false;
            if (this.Trigger != input.Trigger || (this.Trigger != null && !this.Trigger.Equals(input.Trigger))) return false;
            if (this.ScopeRules != input.ScopeRules || (this.ScopeRules != null && input.ScopeRules != null && !this.ScopeRules.SequenceEqual(input.ScopeRules))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                hashCode = hashCode * 59 + this.SignatureMethod.GetHashCode();
                hashCode = hashCode * 59 + this.SignatureAlgorithm.GetHashCode();
                if (this.SignatureKey != null) hashCode = hashCode * 59 + this.SignatureKey.GetHashCode();
                if (this.Trigger != null) hashCode = hashCode * 59 + this.Trigger.GetHashCode();
                if (this.ScopeRules != null) hashCode = hashCode * 59 + this.ScopeRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
