using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class SearchStatisticUserInfoRequest 
    {
        /// <summary>
        /// 查询时间维度，取值： * D: 按日查询 * M: 按月查询
        /// </summary>
        /// <value>查询时间维度，取值： * D: 按日查询 * M: 按月查询</value>
        [JsonConverter(typeof(EnumClassConverter<TimeUnitEnum>))]
        public class TimeUnitEnum
        {
            /// <summary>
            /// Enum D for value: D
            /// </summary>
            public static readonly TimeUnitEnum D = new TimeUnitEnum("D");

            /// <summary>
            /// Enum M for value: M
            /// </summary>
            public static readonly TimeUnitEnum M = new TimeUnitEnum("M");

            private static readonly Dictionary<string, TimeUnitEnum> StaticFields =
            new Dictionary<string, TimeUnitEnum>()
            {
                { "D", D },
                { "M", M },
            };

            private string _value;

            public TimeUnitEnum()
            {

            }

            public TimeUnitEnum(string value)
            {
                _value = value;
            }

            public static TimeUnitEnum FromValue(string value)
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

                if (this.Equals(obj as TimeUnitEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TimeUnitEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TimeUnitEnum a, TimeUnitEnum b)
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

            public static bool operator !=(TimeUnitEnum a, TimeUnitEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 查询分类，取值： * user_login_info: 用户登录数据 * user_activate_info: 用户激活数据 * user_login_device_info: 用户登录设备数据
        /// </summary>
        /// <value>查询分类，取值： * user_login_info: 用户登录数据 * user_activate_info: 用户激活数据 * user_login_device_info: 用户登录设备数据</value>
        [JsonConverter(typeof(EnumClassConverter<CategoryEnum>))]
        public class CategoryEnum
        {
            /// <summary>
            /// Enum USER_LOGIN_INFO for value: user_login_info
            /// </summary>
            public static readonly CategoryEnum USER_LOGIN_INFO = new CategoryEnum("user_login_info");

            /// <summary>
            /// Enum USER_ACTIVATE_INFO for value: user_activate_info
            /// </summary>
            public static readonly CategoryEnum USER_ACTIVATE_INFO = new CategoryEnum("user_activate_info");

            /// <summary>
            /// Enum USER_LOGIN_DEVICE_INFO for value: user_login_device_info
            /// </summary>
            public static readonly CategoryEnum USER_LOGIN_DEVICE_INFO = new CategoryEnum("user_login_device_info");

            private static readonly Dictionary<string, CategoryEnum> StaticFields =
            new Dictionary<string, CategoryEnum>()
            {
                { "user_login_info", USER_LOGIN_INFO },
                { "user_activate_info", USER_ACTIVATE_INFO },
                { "user_login_device_info", USER_LOGIN_DEVICE_INFO },
            };

            private string _value;

            public CategoryEnum()
            {

            }

            public CategoryEnum(string value)
            {
                _value = value;
            }

            public static CategoryEnum FromValue(string value)
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

                if (this.Equals(obj as CategoryEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CategoryEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CategoryEnum a, CategoryEnum b)
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

            public static bool operator !=(CategoryEnum a, CategoryEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 查询偏移量。 * 取值：大于等于0，默认值为0 * 大于等于最大条目数量，则返回最后一页数据，页数根据总条目数和limit计算得出
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询的条目数量。 * 取值：1-500，默认值为20
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询时间维度，取值： * D: 按日查询 * M: 按月查询
        /// </summary>
        [SDKProperty("timeUnit", IsQuery = true)]
        [JsonProperty("timeUnit", NullValueHandling = NullValueHandling.Ignore)]
        public TimeUnitEnum TimeUnit { get; set; }
        /// <summary>
        /// 查询时间范围的开始时间，格式根据timeUnit的取值而定。 * timeUnit &#x3D; D，格式：yyyy-MM-dd，此情况下startTime与endTime间隔最多31日 * timeUnit &#x3D; M，格式：yyyy-MM，此情况下startTime与endTime间隔最多12个月
        /// </summary>
        [SDKProperty("startTime", IsQuery = true)]
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 查询时间范围的结束时间，格式根据timeUnit的取值而定。 * timeUnit &#x3D; D，格式：yyyy-MM-dd，此情况下startTime与endTime间隔最多31日 * timeUnit &#x3D; M，格式：yyyy-MM，此情况下startTime与endTime间隔最多12个月
        /// </summary>
        [SDKProperty("endTime", IsQuery = true)]
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询分类，取值： * user_login_info: 用户登录数据 * user_activate_info: 用户激活数据 * user_login_device_info: 用户登录设备数据
        /// </summary>
        [SDKProperty("category", IsQuery = true)]
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchStatisticUserInfoRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  timeUnit: ").Append(TimeUnit).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchStatisticUserInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchStatisticUserInfoRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.TimeUnit != input.TimeUnit) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Category != input.Category) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.TimeUnit.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                return hashCode;
            }
        }
    }
}
