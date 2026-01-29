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
    /// 查询OTT频道统计信息消息体。
    /// </summary>
    public class ShowChannelStatisticReq 
    {
        /// <summary>
        /// 统计信息的类型，scte35。
        /// </summary>
        /// <value>统计信息的类型，scte35。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum SCTE35 for value: scte35
            /// </summary>
            public static readonly TypeEnum SCTE35 = new TypeEnum("scte35");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "scte35", SCTE35 },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 频道对应的region类型，是主region，还是备region **约束限制**： 如果region_type不填，或是没有该字段，则按照主region处理 **取值范围**： - master: 主region - slave: 备region - all: 所有region 
        /// </summary>
        /// <value>**参数解释**： 频道对应的region类型，是主region，还是备region **约束限制**： 如果region_type不填，或是没有该字段，则按照主region处理 **取值范围**： - master: 主region - slave: 备region - all: 所有region </value>
        [JsonConverter(typeof(EnumClassConverter<RegionTypeEnum>))]
        public class RegionTypeEnum
        {
            /// <summary>
            /// Enum MASTER for value: master
            /// </summary>
            public static readonly RegionTypeEnum MASTER = new RegionTypeEnum("master");

            /// <summary>
            /// Enum SLAVE for value: slave
            /// </summary>
            public static readonly RegionTypeEnum SLAVE = new RegionTypeEnum("slave");

            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly RegionTypeEnum ALL = new RegionTypeEnum("all");

            private static readonly Dictionary<string, RegionTypeEnum> StaticFields =
            new Dictionary<string, RegionTypeEnum>()
            {
                { "master", MASTER },
                { "slave", SLAVE },
                { "all", ALL },
            };

            private string _value;

            public RegionTypeEnum()
            {

            }

            public RegionTypeEnum(string value)
            {
                _value = value;
            }

            public static RegionTypeEnum FromValue(string value)
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

                if (this.Equals(obj as RegionTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RegionTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RegionTypeEnum a, RegionTypeEnum b)
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

            public static bool operator !=(RegionTypeEnum a, RegionTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 频道推流域名。
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 组名或应用名。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 频道ID。频道唯一标识，为必填项。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 统计信息的类型，scte35。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scte35", NullValueHandling = NullValueHandling.Ignore)]
        public SCTE35StatisticReq Scte35 { get; set; }

        /// <summary>
        /// **参数解释**： 频道对应的region类型，是主region，还是备region **约束限制**： 如果region_type不填，或是没有该字段，则按照主region处理 **取值范围**： - master: 主region - slave: 备region - all: 所有region 
        /// </summary>
        [JsonProperty("region_type", NullValueHandling = NullValueHandling.Ignore)]
        public RegionTypeEnum RegionType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowChannelStatisticReq {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  scte35: ").Append(Scte35).Append("\n");
            sb.Append("  regionType: ").Append(RegionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowChannelStatisticReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowChannelStatisticReq input)
        {
            if (input == null) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Type != input.Type) return false;
            if (this.Scte35 != input.Scte35 || (this.Scte35 != null && !this.Scte35.Equals(input.Scte35))) return false;
            if (this.RegionType != input.RegionType) return false;

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
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Scte35 != null) hashCode = hashCode * 59 + this.Scte35.GetHashCode();
                hashCode = hashCode * 59 + this.RegionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
