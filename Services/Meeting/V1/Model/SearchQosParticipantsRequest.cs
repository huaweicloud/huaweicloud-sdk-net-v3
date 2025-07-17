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
    public class SearchQosParticipantsRequest 
    {
        /// <summary>
        /// 会议类别。 * online：在线会议，正在召开的会议 * history：历史会议，已结束的会议
        /// </summary>
        /// <value>会议类别。 * online：在线会议，正在召开的会议 * history：历史会议，已结束的会议</value>
        [JsonConverter(typeof(EnumClassConverter<ConfTypeEnum>))]
        public class ConfTypeEnum
        {
            /// <summary>
            /// Enum ONLINE for value: online
            /// </summary>
            public static readonly ConfTypeEnum ONLINE = new ConfTypeEnum("online");

            /// <summary>
            /// Enum HISTORY for value: history
            /// </summary>
            public static readonly ConfTypeEnum HISTORY = new ConfTypeEnum("history");

            private static readonly Dictionary<string, ConfTypeEnum> StaticFields =
            new Dictionary<string, ConfTypeEnum>()
            {
                { "online", ONLINE },
                { "history", HISTORY },
            };

            private string _value;

            public ConfTypeEnum()
            {

            }

            public ConfTypeEnum(string value)
            {
                _value = value;
            }

            public static ConfTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ConfTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConfTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConfTypeEnum a, ConfTypeEnum b)
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

            public static bool operator !=(ConfTypeEnum a, ConfTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 会议UUID。
        /// </summary>
        [SDKProperty("confUUID", IsQuery = true)]
        [JsonProperty("confUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUUID { get; set; }

        /// <summary>
        /// 会议类别。 * online：在线会议，正在召开的会议 * history：历史会议，已结束的会议
        /// </summary>
        [SDKProperty("confType", IsQuery = true)]
        [JsonProperty("confType", NullValueHandling = NullValueHandling.Ignore)]
        public ConfTypeEnum ConfType { get; set; }
        /// <summary>
        /// 查询偏移量。 * 取值：大于等于0，默认值为0。 * 大于等于最大条目数量，则返回最后一页的数据。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询的条目数量。 * 取值：1-500，默认值为20。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询条件。与会者名称可作为搜索内容。长度限制为1-512个字符。
        /// </summary>
        [SDKProperty("searchKey", IsQuery = true)]
        [JsonProperty("searchKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchQosParticipantsRequest {\n");
            sb.Append("  confUUID: ").Append(ConfUUID).Append("\n");
            sb.Append("  confType: ").Append(ConfType).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  searchKey: ").Append(SearchKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchQosParticipantsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchQosParticipantsRequest input)
        {
            if (input == null) return false;
            if (this.ConfUUID != input.ConfUUID || (this.ConfUUID != null && !this.ConfUUID.Equals(input.ConfUUID))) return false;
            if (this.ConfType != input.ConfType) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SearchKey != input.SearchKey || (this.SearchKey != null && !this.SearchKey.Equals(input.SearchKey))) return false;

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
                if (this.ConfUUID != null) hashCode = hashCode * 59 + this.ConfUUID.GetHashCode();
                hashCode = hashCode * 59 + this.ConfType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SearchKey != null) hashCode = hashCode * 59 + this.SearchKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
