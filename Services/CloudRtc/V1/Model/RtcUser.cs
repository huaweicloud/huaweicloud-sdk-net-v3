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
    /// 
    /// </summary>
    public class RtcUser 
    {
        /// <summary>
        /// 用户状态   - FAIL： 加入失败   - ONLINE：在线   - OFFLINE：离开 
        /// </summary>
        /// <value>用户状态   - FAIL： 加入失败   - ONLINE：在线   - OFFLINE：离开 </value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum FAIL for value: FAIL
            /// </summary>
            public static readonly StateEnum FAIL = new StateEnum("FAIL");

            /// <summary>
            /// Enum ONLINE for value: ONLINE
            /// </summary>
            public static readonly StateEnum ONLINE = new StateEnum("ONLINE");

            /// <summary>
            /// Enum OFFLINE for value: OFFLINE
            /// </summary>
            public static readonly StateEnum OFFLINE = new StateEnum("OFFLINE");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "FAIL", FAIL },
                { "ONLINE", ONLINE },
                { "OFFLINE", OFFLINE },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 应用标识
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 房间ID
        /// </summary>
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [JsonProperty("session", NullValueHandling = NullValueHandling.Ignore)]
        public string Session { get; set; }

        /// <summary>
        /// 用户状态   - FAIL： 加入失败   - ONLINE：在线   - OFFLINE：离开 
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 用户接入IP
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 用户接入IP所在省份
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 用户接入IP所在运营商
        /// </summary>
        [JsonProperty("isp", NullValueHandling = NullValueHandling.Ignore)]
        public string Isp { get; set; }

        /// <summary>
        /// 用户设备型号
        /// </summary>
        [JsonProperty("device_model", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceModel { get; set; }

        /// <summary>
        /// 用户设备平台
        /// </summary>
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// 用户sdk版本
        /// </summary>
        [JsonProperty("sdk", NullValueHandling = NullValueHandling.Ignore)]
        public string Sdk { get; set; }

        /// <summary>
        /// 用户加入房间时间。格式为：YYYY-MM-DDThh:mm:ssZ 
        /// </summary>
        [JsonProperty("join_time", NullValueHandling = NullValueHandling.Ignore)]
        public string JoinTime { get; set; }

        /// <summary>
        /// 用户离开房间时间。格式为：YYYY-MM-DDThh:mm:ssZ，若用户未离开，则返回 “-” 
        /// </summary>
        [JsonProperty("leave_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LeaveTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RtcUser {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  session: ").Append(Session).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  isp: ").Append(Isp).Append("\n");
            sb.Append("  deviceModel: ").Append(DeviceModel).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  sdk: ").Append(Sdk).Append("\n");
            sb.Append("  joinTime: ").Append(JoinTime).Append("\n");
            sb.Append("  leaveTime: ").Append(LeaveTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RtcUser);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RtcUser input)
        {
            if (input == null) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.Session != input.Session || (this.Session != null && !this.Session.Equals(input.Session))) return false;
            if (this.State != input.State) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Isp != input.Isp || (this.Isp != null && !this.Isp.Equals(input.Isp))) return false;
            if (this.DeviceModel != input.DeviceModel || (this.DeviceModel != null && !this.DeviceModel.Equals(input.DeviceModel))) return false;
            if (this.Platform != input.Platform || (this.Platform != null && !this.Platform.Equals(input.Platform))) return false;
            if (this.Sdk != input.Sdk || (this.Sdk != null && !this.Sdk.Equals(input.Sdk))) return false;
            if (this.JoinTime != input.JoinTime || (this.JoinTime != null && !this.JoinTime.Equals(input.JoinTime))) return false;
            if (this.LeaveTime != input.LeaveTime || (this.LeaveTime != null && !this.LeaveTime.Equals(input.LeaveTime))) return false;

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
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Session != null) hashCode = hashCode * 59 + this.Session.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Isp != null) hashCode = hashCode * 59 + this.Isp.GetHashCode();
                if (this.DeviceModel != null) hashCode = hashCode * 59 + this.DeviceModel.GetHashCode();
                if (this.Platform != null) hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Sdk != null) hashCode = hashCode * 59 + this.Sdk.GetHashCode();
                if (this.JoinTime != null) hashCode = hashCode * 59 + this.JoinTime.GetHashCode();
                if (this.LeaveTime != null) hashCode = hashCode * 59 + this.LeaveTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
