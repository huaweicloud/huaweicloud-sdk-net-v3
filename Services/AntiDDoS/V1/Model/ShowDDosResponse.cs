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
    public class ShowDDosResponse : SdkResponse
    {
        /// <summary>
        /// 应用类型ID，固定值为0
        /// </summary>
        /// <value>应用类型ID，固定值为0</value>
        [JsonConverter(typeof(EnumClassConverter<AppTypeIdEnum>))]
        public class AppTypeIdEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly AppTypeIdEnum NUMBER_0 = new AppTypeIdEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly AppTypeIdEnum NUMBER_1 = new AppTypeIdEnum(1);

            private static readonly Dictionary<long?, AppTypeIdEnum> StaticFields =
            new Dictionary<long?, AppTypeIdEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private long? _value;

            public AppTypeIdEnum()
            {

            }

            public AppTypeIdEnum(long? value)
            {
                _value = value;
            }

            public static AppTypeIdEnum FromValue(long? value)
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

            public long? GetValue()
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

                if (this.Equals(obj as AppTypeIdEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AppTypeIdEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AppTypeIdEnum a, AppTypeIdEnum b)
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

            public static bool operator !=(AppTypeIdEnum a, AppTypeIdEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否开启L7层防护，固定值为fasle
        /// </summary>
        [JsonProperty("enable_L7", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableL7 { get; set; }

        /// <summary>
        /// 流量分段ID，取值范围：1：10M;2：30M;3：50M;4：70M;5：100M;6：150M;7：200M;8：250M;9：300M;10：500M;11：800M;88：1000M;99：默认防护。
        /// </summary>
        [JsonProperty("traffic_pos_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrafficPosId { get; set; }

        /// <summary>
        /// HTTP请求数分段ID，固定值为1
        /// </summary>
        [JsonProperty("http_request_pos_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? HttpRequestPosId { get; set; }

        /// <summary>
        /// 清洗时访问限制分段ID，取值范围：1：10M;2：30M;3：50M;4：70M;5：100M;6：150M;7：200M;8：250M;9：300M;10：500M;11：800M;88：1000M;99：默认防护。
        /// </summary>
        [JsonProperty("cleaning_access_pos_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? CleaningAccessPosId { get; set; }

        /// <summary>
        /// 应用类型ID，固定值为0
        /// </summary>
        [JsonProperty("app_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public AppTypeIdEnum AppTypeId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDDosResponse {\n");
            sb.Append("  enableL7: ").Append(EnableL7).Append("\n");
            sb.Append("  trafficPosId: ").Append(TrafficPosId).Append("\n");
            sb.Append("  httpRequestPosId: ").Append(HttpRequestPosId).Append("\n");
            sb.Append("  cleaningAccessPosId: ").Append(CleaningAccessPosId).Append("\n");
            sb.Append("  appTypeId: ").Append(AppTypeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDDosResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDDosResponse input)
        {
            if (input == null) return false;
            if (this.EnableL7 != input.EnableL7 || (this.EnableL7 != null && !this.EnableL7.Equals(input.EnableL7))) return false;
            if (this.TrafficPosId != input.TrafficPosId || (this.TrafficPosId != null && !this.TrafficPosId.Equals(input.TrafficPosId))) return false;
            if (this.HttpRequestPosId != input.HttpRequestPosId || (this.HttpRequestPosId != null && !this.HttpRequestPosId.Equals(input.HttpRequestPosId))) return false;
            if (this.CleaningAccessPosId != input.CleaningAccessPosId || (this.CleaningAccessPosId != null && !this.CleaningAccessPosId.Equals(input.CleaningAccessPosId))) return false;
            if (this.AppTypeId != input.AppTypeId) return false;

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
                if (this.EnableL7 != null) hashCode = hashCode * 59 + this.EnableL7.GetHashCode();
                if (this.TrafficPosId != null) hashCode = hashCode * 59 + this.TrafficPosId.GetHashCode();
                if (this.HttpRequestPosId != null) hashCode = hashCode * 59 + this.HttpRequestPosId.GetHashCode();
                if (this.CleaningAccessPosId != null) hashCode = hashCode * 59 + this.CleaningAccessPosId.GetHashCode();
                hashCode = hashCode * 59 + this.AppTypeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
