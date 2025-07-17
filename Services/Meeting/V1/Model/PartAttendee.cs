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
    /// 部分与会者信息。
    /// </summary>
    public class PartAttendee 
    {

        /// <summary>
        /// 与会者名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 号码。SIP号码或者手机号码。
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// 预留字段，取值类型同参数“phone”。
        /// </summary>
        [JsonProperty("phone2", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone2 { get; set; }

        /// <summary>
        /// 预留字段，取值类型同参数“phone”。
        /// </summary>
        [JsonProperty("phone3", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone3 { get; set; }

        /// <summary>
        /// 终端类型，类型枚举如下： * normal：软终端 * terminal：硬终端 * outside：外部与会人 * mobile：用户手机号码 * ideahub：ideahub * board: 电子白板（SmartRooms）。含Maxhub、海信大屏、IdeaHub B2hwvision：华为智慧屏TV
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 用户入会时是否需要自动静音 。默认不静音。 * 0： 不需要静音 * 1： 需要静音
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public int? Role { get; set; }

        /// <summary>
        /// 用户入会时是否需要自动静音。默认不静音。 * 0: 不需要静音。 * 1: 需要静音。
        /// </summary>
        [JsonProperty("isMute", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsMute { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartAttendee {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  phone2: ").Append(Phone2).Append("\n");
            sb.Append("  phone3: ").Append(Phone3).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  isMute: ").Append(IsMute).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PartAttendee);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PartAttendee input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.Phone2 != input.Phone2 || (this.Phone2 != null && !this.Phone2.Equals(input.Phone2))) return false;
            if (this.Phone3 != input.Phone3 || (this.Phone3 != null && !this.Phone3.Equals(input.Phone3))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.IsMute != input.IsMute || (this.IsMute != null && !this.IsMute.Equals(input.IsMute))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Phone2 != null) hashCode = hashCode * 59 + this.Phone2.GetHashCode();
                if (this.Phone3 != null) hashCode = hashCode * 59 + this.Phone3.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.IsMute != null) hashCode = hashCode * 59 + this.IsMute.GetHashCode();
                return hashCode;
            }
        }
    }
}
