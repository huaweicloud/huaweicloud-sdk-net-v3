using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 第三方TTS音色元数据。
    /// </summary>
    public class ExternalVoiceAssetMeta 
    {
        /// <summary>
        /// 第三方TTS供应商类型。 * XIMALAYA：喜马拉雅TTS * HUAWEI_EI：华为云EI TTS * MOBVOI：出门问问 TTS * AUDIOX：逻辑智能 TTS * SINOVOICE：捷通华声 TTS * DATABAKER：标贝 TTS * AISPEECH：思必驰 TTS
        /// </summary>
        /// <value>第三方TTS供应商类型。 * XIMALAYA：喜马拉雅TTS * HUAWEI_EI：华为云EI TTS * MOBVOI：出门问问 TTS * AUDIOX：逻辑智能 TTS * SINOVOICE：捷通华声 TTS * DATABAKER：标贝 TTS * AISPEECH：思必驰 TTS</value>
        [JsonConverter(typeof(EnumClassConverter<ProviderEnum>))]
        public class ProviderEnum
        {
            /// <summary>
            /// Enum XIMALAYA for value: XIMALAYA
            /// </summary>
            public static readonly ProviderEnum XIMALAYA = new ProviderEnum("XIMALAYA");

            /// <summary>
            /// Enum HUAWEI_EI for value: HUAWEI_EI
            /// </summary>
            public static readonly ProviderEnum HUAWEI_EI = new ProviderEnum("HUAWEI_EI");

            /// <summary>
            /// Enum MOBVOI for value: MOBVOI
            /// </summary>
            public static readonly ProviderEnum MOBVOI = new ProviderEnum("MOBVOI");

            /// <summary>
            /// Enum AUDIOX for value: AUDIOX
            /// </summary>
            public static readonly ProviderEnum AUDIOX = new ProviderEnum("AUDIOX");

            /// <summary>
            /// Enum SINOVOICE for value: SINOVOICE
            /// </summary>
            public static readonly ProviderEnum SINOVOICE = new ProviderEnum("SINOVOICE");

            /// <summary>
            /// Enum DATABAKER for value: DATABAKER
            /// </summary>
            public static readonly ProviderEnum DATABAKER = new ProviderEnum("DATABAKER");

            /// <summary>
            /// Enum AISPEECH for value: AISPEECH
            /// </summary>
            public static readonly ProviderEnum AISPEECH = new ProviderEnum("AISPEECH");

            private static readonly Dictionary<string, ProviderEnum> StaticFields =
            new Dictionary<string, ProviderEnum>()
            {
                { "XIMALAYA", XIMALAYA },
                { "HUAWEI_EI", HUAWEI_EI },
                { "MOBVOI", MOBVOI },
                { "AUDIOX", AUDIOX },
                { "SINOVOICE", SINOVOICE },
                { "DATABAKER", DATABAKER },
                { "AISPEECH", AISPEECH },
            };

            private string _value;

            public ProviderEnum()
            {

            }

            public ProviderEnum(string value)
            {
                _value = value;
            }

            public static ProviderEnum FromValue(string value)
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

                if (this.Equals(obj as ProviderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProviderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProviderEnum a, ProviderEnum b)
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

            public static bool operator !=(ProviderEnum a, ProviderEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 第三方TTS供应商类型。 * XIMALAYA：喜马拉雅TTS * HUAWEI_EI：华为云EI TTS * MOBVOI：出门问问 TTS * AUDIOX：逻辑智能 TTS * SINOVOICE：捷通华声 TTS * DATABAKER：标贝 TTS * AISPEECH：思必驰 TTS
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public ProviderEnum Provider { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalVoiceAssetMeta {\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExternalVoiceAssetMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExternalVoiceAssetMeta input)
        {
            if (input == null) return false;
            if (this.Provider != input.Provider) return false;

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
                hashCode = hashCode * 59 + this.Provider.GetHashCode();
                return hashCode;
            }
        }
    }
}
