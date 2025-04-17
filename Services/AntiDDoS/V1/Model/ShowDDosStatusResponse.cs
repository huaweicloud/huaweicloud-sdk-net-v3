using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDDosStatusResponse : SdkResponse
    {
        /// <summary>
        /// 防护状态，可选范围：   - normal：表示正常   - configging：表示设置中   - notConfig：表示未设置   - packetcleaning：表示清洗   - packetdropping：表示黑洞
        /// </summary>
        /// <value>防护状态，可选范围：   - normal：表示正常   - configging：表示设置中   - notConfig：表示未设置   - packetcleaning：表示清洗   - packetdropping：表示黑洞</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly StatusEnum NORMAL = new StatusEnum("normal");

            /// <summary>
            /// Enum CONFIGGING for value: configging
            /// </summary>
            public static readonly StatusEnum CONFIGGING = new StatusEnum("configging");

            /// <summary>
            /// Enum NOTCONFIG for value: notConfig
            /// </summary>
            public static readonly StatusEnum NOTCONFIG = new StatusEnum("notConfig");

            /// <summary>
            /// Enum PACKETCLEANING for value: packetcleaning
            /// </summary>
            public static readonly StatusEnum PACKETCLEANING = new StatusEnum("packetcleaning");

            /// <summary>
            /// Enum PACKETDROPPING for value: packetdropping
            /// </summary>
            public static readonly StatusEnum PACKETDROPPING = new StatusEnum("packetdropping");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "normal", NORMAL },
                { "configging", CONFIGGING },
                { "notConfig", NOTCONFIG },
                { "packetcleaning", PACKETCLEANING },
                { "packetdropping", PACKETDROPPING },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 防护状态，可选范围：   - normal：表示正常   - configging：表示设置中   - notConfig：表示未设置   - packetcleaning：表示清洗   - packetdropping：表示黑洞
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDDosStatusResponse {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDDosStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDDosStatusResponse input)
        {
            if (input == null) return false;
            if (this.Status != input.Status) return false;

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
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
