using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListRtcUserListRequest 
    {
        /// <summary>
        /// 查询模式，取值如下： - detail：会话级 - summary：用户级（默认） 
        /// </summary>
        /// <value>查询模式，取值如下： - detail：会话级 - summary：用户级（默认） </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum DETAIL for value: detail
            /// </summary>
            public static readonly TypeEnum DETAIL = new TypeEnum("detail");

            /// <summary>
            /// Enum SUMMARY for value: summary
            /// </summary>
            public static readonly TypeEnum SUMMARY = new TypeEnum("summary");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "detail", DETAIL },
                { "summary", SUMMARY },
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 使用AK/SK方式认证时必选，携带的鉴权信息。 
        /// </summary>
        [SDKProperty("Authorization", IsHeader = true)]
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。 
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，携带项目ID信息，与路径参数中的项目ID相同。 
        /// </summary>
        [SDKProperty("X-Project-Id", IsHeader = true)]
        [JsonProperty("X-Project-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XProjectId { get; set; }

        /// <summary>
        /// 应用id 
        /// </summary>
        [SDKProperty("app", IsQuery = true)]
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 房间id 
        /// </summary>
        [SDKProperty("room_id", IsQuery = true)]
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 用户id 
        /// </summary>
        [SDKProperty("uid", IsQuery = true)]
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 用户昵称 
        /// </summary>
        [SDKProperty("nickname", IsQuery = true)]
        [JsonProperty("nickname", NullValueHandling = NullValueHandling.Ignore)]
        public string Nickname { get; set; }

        /// <summary>
        /// 用户省份，支持省份名或缩写，如广东或者GD 
        /// </summary>
        [SDKProperty("region", IsQuery = true)]
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Region { get; set; }

        /// <summary>
        /// 用户接入运营商 
        /// </summary>
        [SDKProperty("isp", IsQuery = true)]
        [JsonProperty("isp", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Isp { get; set; }

        /// <summary>
        /// 用户状态，取值如下： - FAIL：加入失败 - ONLINE：在线 - OFFLINE：离开 
        /// </summary>
        [SDKProperty("state", IsQuery = true)]
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> State { get; set; }

        /// <summary>
        /// 查询起始时间。UTC时间，格式：YYYY-MM-DDThh:mm:ssZ，如2020-04-23T06:00:00Z，不写默认读取过去1小时数据数据。 
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 查询结束时间。UTC时间，格式：YYYY-MM-DDThh:mm:ssZ，如2020-04-23T06:00:00Z，不写默认为当前时间。 
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询结果限制 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询偏移量 
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询模式，取值如下： - detail：会话级 - summary：用户级（默认） 
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRtcUserListRequest {\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  xProjectId: ").Append(XProjectId).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  nickname: ").Append(Nickname).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  isp: ").Append(Isp).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRtcUserListRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRtcUserListRequest input)
        {
            if (input == null) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.XProjectId != input.XProjectId || (this.XProjectId != null && !this.XProjectId.Equals(input.XProjectId))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.Nickname != input.Nickname || (this.Nickname != null && !this.Nickname.Equals(input.Nickname))) return false;
            if (this.Region != input.Region || (this.Region != null && input.Region != null && !this.Region.SequenceEqual(input.Region))) return false;
            if (this.Isp != input.Isp || (this.Isp != null && input.Isp != null && !this.Isp.SequenceEqual(input.Isp))) return false;
            if (this.State != input.State || (this.State != null && input.State != null && !this.State.SequenceEqual(input.State))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Type != input.Type) return false;

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
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.XProjectId != null) hashCode = hashCode * 59 + this.XProjectId.GetHashCode();
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Nickname != null) hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Isp != null) hashCode = hashCode * 59 + this.Isp.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
