using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRepositoryStatisticsStatusResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释：** 是否能被统计。 **取值范围：** - 0，表示用户次数和仓库次数都没用完。 - 1，表示仓库次数用完。 - 2，表示用户次数用完。 - 3, 表示仓库次数和用户次数都用完
        /// </summary>
        /// <value>**参数解释：** 是否能被统计。 **取值范围：** - 0，表示用户次数和仓库次数都没用完。 - 1，表示仓库次数用完。 - 2，表示用户次数用完。 - 3, 表示仓库次数和用户次数都用完</value>
        [JsonConverter(typeof(EnumClassConverter<ReasonEnum>))]
        public class ReasonEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly ReasonEnum NUMBER_0 = new ReasonEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly ReasonEnum NUMBER_1 = new ReasonEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly ReasonEnum NUMBER_2 = new ReasonEnum(2);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly ReasonEnum NUMBER_3 = new ReasonEnum(3);

            private static readonly Dictionary<int?, ReasonEnum> StaticFields =
            new Dictionary<int?, ReasonEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
                { 3, NUMBER_3 },
            };

            private int? _value;

            public ReasonEnum()
            {

            }

            public ReasonEnum(int? value)
            {
                _value = value;
            }

            public static ReasonEnum FromValue(int? value)
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

                if (this.Equals(obj as ReasonEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReasonEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReasonEnum a, ReasonEnum b)
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

            public static bool operator !=(ReasonEnum a, ReasonEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 是否能被统计。 **取值范围：** - true，可以被统计。 - false，不可被统计。
        /// </summary>
        [JsonProperty("can_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanStatistics { get; set; }

        /// <summary>
        /// **参数解释：** 是否能被统计。 **取值范围：** - 0，表示用户次数和仓库次数都没用完。 - 1，表示仓库次数用完。 - 2，表示用户次数用完。 - 3, 表示仓库次数和用户次数都用完
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public ReasonEnum Reason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public StatisticEventsDto Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Total", IsHeader = true)]
        [JsonProperty("X-Total", NullValueHandling = NullValueHandling.Ignore)]
        public string XTotal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRepositoryStatisticsStatusResponse {\n");
            sb.Append("  canStatistics: ").Append(CanStatistics).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  xTotal: ").Append(XTotal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRepositoryStatisticsStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRepositoryStatisticsStatusResponse input)
        {
            if (input == null) return false;
            if (this.CanStatistics != input.CanStatistics || (this.CanStatistics != null && !this.CanStatistics.Equals(input.CanStatistics))) return false;
            if (this.Reason != input.Reason) return false;
            if (this.Event != input.Event || (this.Event != null && !this.Event.Equals(input.Event))) return false;
            if (this.XTotal != input.XTotal || (this.XTotal != null && !this.XTotal.Equals(input.XTotal))) return false;

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
                if (this.CanStatistics != null) hashCode = hashCode * 59 + this.CanStatistics.GetHashCode();
                hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Event != null) hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.XTotal != null) hashCode = hashCode * 59 + this.XTotal.GetHashCode();
                return hashCode;
            }
        }
    }
}
