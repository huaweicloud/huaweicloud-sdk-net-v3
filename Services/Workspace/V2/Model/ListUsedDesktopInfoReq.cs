using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 查询使用桌面时长请求。
    /// </summary>
    public class ListUsedDesktopInfoReq 
    {
        /// <summary>
        /// 统计方式，不传则默认按天。可选值为： - DAY: 按天。 - HOUR: 按小时。
        /// </summary>
        /// <value>统计方式，不传则默认按天。可选值为： - DAY: 按天。 - HOUR: 按小时。</value>
        [JsonConverter(typeof(EnumClassConverter<GroupByTypeEnum>))]
        public class GroupByTypeEnum
        {
            /// <summary>
            /// Enum DAY for value: DAY
            /// </summary>
            public static readonly GroupByTypeEnum DAY = new GroupByTypeEnum("DAY");

            /// <summary>
            /// Enum HOUR for value: HOUR
            /// </summary>
            public static readonly GroupByTypeEnum HOUR = new GroupByTypeEnum("HOUR");

            private static readonly Dictionary<string, GroupByTypeEnum> StaticFields =
            new Dictionary<string, GroupByTypeEnum>()
            {
                { "DAY", DAY },
                { "HOUR", HOUR },
            };

            private string _value;

            public GroupByTypeEnum()
            {

            }

            public GroupByTypeEnum(string value)
            {
                _value = value;
            }

            public static GroupByTypeEnum FromValue(string value)
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

                if (this.Equals(obj as GroupByTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(GroupByTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(GroupByTypeEnum a, GroupByTypeEnum b)
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

            public static bool operator !=(GroupByTypeEnum a, GroupByTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 桌面id集合。
        /// </summary>
        [JsonProperty("desktop_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// 开始时间，格式：yyyy-MM-dd（UTC时间，不传查默认最近15天）最多查31天数据。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间，格式：yyyy-MM-dd（UTC时间，不传查默认最近15天）最多查31天数据。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 统计方式，不传则默认按天。可选值为： - DAY: 按天。 - HOUR: 按小时。
        /// </summary>
        [JsonProperty("group_by_type", NullValueHandling = NullValueHandling.Ignore)]
        public GroupByTypeEnum GroupByType { get; set; }
        /// <summary>
        /// 若传桌面的用户名，则查询使用时间只有该用户的使用时间。
        /// </summary>
        [JsonProperty("desktop_username", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopUsername { get; set; }

        /// <summary>
        /// 从查询结果中的第几条数据开始返回,用于分页查询，取值范围0-2147483647，默认从0开始。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询结果中想要返回的信息条目数量,用于分页查询，取值范围0-100，默认值100。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUsedDesktopInfoReq {\n");
            sb.Append("  desktopIds: ").Append(DesktopIds).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  groupByType: ").Append(GroupByType).Append("\n");
            sb.Append("  desktopUsername: ").Append(DesktopUsername).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUsedDesktopInfoReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUsedDesktopInfoReq input)
        {
            if (input == null) return false;
            if (this.DesktopIds != input.DesktopIds || (this.DesktopIds != null && input.DesktopIds != null && !this.DesktopIds.SequenceEqual(input.DesktopIds))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.GroupByType != input.GroupByType) return false;
            if (this.DesktopUsername != input.DesktopUsername || (this.DesktopUsername != null && !this.DesktopUsername.Equals(input.DesktopUsername))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.DesktopIds != null) hashCode = hashCode * 59 + this.DesktopIds.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.GroupByType.GetHashCode();
                if (this.DesktopUsername != null) hashCode = hashCode * 59 + this.DesktopUsername.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
