using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// bandwidth字段数据结构说明
    /// </summary>
    public class BandWidth 
    {
        /// <summary>
        /// 带宽的共享类型。共享类型枚举：PER，表示独享；WHOLE，表示共享
        /// </summary>
        /// <value>带宽的共享类型。共享类型枚举：PER，表示独享；WHOLE，表示共享</value>
        [JsonConverter(typeof(EnumClassConverter<SharetypeEnum>))]
        public class SharetypeEnum
        {
            /// <summary>
            /// Enum PER for value: PER
            /// </summary>
            public static readonly SharetypeEnum PER = new SharetypeEnum("PER");

            /// <summary>
            /// Enum WHOLE for value: WHOLE
            /// </summary>
            public static readonly SharetypeEnum WHOLE = new SharetypeEnum("WHOLE");

            private static readonly Dictionary<string, SharetypeEnum> StaticFields =
            new Dictionary<string, SharetypeEnum>()
            {
                { "PER", PER },
                { "WHOLE", WHOLE },
            };

            private string _value;

            public SharetypeEnum()
            {

            }

            public SharetypeEnum(string value)
            {
                _value = value;
            }

            public static SharetypeEnum FromValue(string value)
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

                if (this.Equals(obj as SharetypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SharetypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SharetypeEnum a, SharetypeEnum b)
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

            public static bool operator !=(SharetypeEnum a, SharetypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 带宽的计费类型。取值为：traffic（按流量计费）、bandwidth（按带宽计费）未传该字段，表示按带宽计费。字段值为空，表示按带宽计费。 说明：如果sharetype是WHOLE并且id有值，仅支持按带宽计费，该参数会忽略。
        /// </summary>
        /// <value>带宽的计费类型。取值为：traffic（按流量计费）、bandwidth（按带宽计费）未传该字段，表示按带宽计费。字段值为空，表示按带宽计费。 说明：如果sharetype是WHOLE并且id有值，仅支持按带宽计费，该参数会忽略。</value>
        [JsonConverter(typeof(EnumClassConverter<ChargemodeEnum>))]
        public class ChargemodeEnum
        {
            /// <summary>
            /// Enum TRAFFIC for value: traffic
            /// </summary>
            public static readonly ChargemodeEnum TRAFFIC = new ChargemodeEnum("traffic");

            /// <summary>
            /// Enum BANDWIDTH for value: bandwidth
            /// </summary>
            public static readonly ChargemodeEnum BANDWIDTH = new ChargemodeEnum("bandwidth");

            private static readonly Dictionary<string, ChargemodeEnum> StaticFields =
            new Dictionary<string, ChargemodeEnum>()
            {
                { "traffic", TRAFFIC },
                { "bandwidth", BANDWIDTH },
            };

            private string _value;

            public ChargemodeEnum()
            {

            }

            public ChargemodeEnum(string value)
            {
                _value = value;
            }

            public static ChargemodeEnum FromValue(string value)
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

                if (this.Equals(obj as ChargemodeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargemodeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargemodeEnum a, ChargemodeEnum b)
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

            public static bool operator !=(ChargemodeEnum a, ChargemodeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 带宽名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 带宽的共享类型。共享类型枚举：PER，表示独享；WHOLE，表示共享
        /// </summary>
        [JsonProperty("sharetype", NullValueHandling = NullValueHandling.Ignore)]
        public SharetypeEnum Sharetype { get; set; }
        /// <summary>
        /// 共享带宽ID。创建WHOLE类型带宽的弹性公网IP时可以指定之前的共享带宽创建。共享带宽的使用限制请参见“共享带宽简介”。 说明：当创建WHOLE类型的带宽时，该字段必选。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// 取值范围：默认5Mbit/s~2000Mbit/s（具体范围以各Region配置为准，请参见管理控制台对应页面显示）。功能说明：带宽大小。共享带宽的大小有最小值限制，默认为5M。 说明：如果传入的参数为小数（如10.2）或者字符类型（如10），会自动强制转换为整数。带宽小于300Mbit/s时，步长支持1Mbit/s；带宽为300Mbit/s~1000Mbit/s时，步长支持50Mbit/s；带宽为1000Mbit/s~2000Mbit/s时，步长支持1000Mbit/s。如果sharetype是PER，该参数必选；如果sharetype是WHOLE并且id有值，该参数会忽略。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 带宽的计费类型。取值为：traffic（按流量计费）、bandwidth（按带宽计费）未传该字段，表示按带宽计费。字段值为空，表示按带宽计费。 说明：如果sharetype是WHOLE并且id有值，仅支持按带宽计费，该参数会忽略。
        /// </summary>
        [JsonProperty("chargemode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargemodeEnum Chargemode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BandWidth {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sharetype: ").Append(Sharetype).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  chargemode: ").Append(Chargemode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BandWidth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BandWidth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Sharetype == input.Sharetype ||
                    (this.Sharetype != null &&
                    this.Sharetype.Equals(input.Sharetype))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Chargemode == input.Chargemode ||
                    (this.Chargemode != null &&
                    this.Chargemode.Equals(input.Chargemode))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Sharetype != null)
                    hashCode = hashCode * 59 + this.Sharetype.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Chargemode != null)
                    hashCode = hashCode * 59 + this.Chargemode.GetHashCode();
                return hashCode;
            }
        }
    }
}
