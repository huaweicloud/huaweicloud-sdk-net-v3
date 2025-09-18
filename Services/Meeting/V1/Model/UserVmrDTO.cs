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
    /// 
    /// </summary>
    public class UserVmrDTO 
    {
        /// <summary>
        /// 云会议室状态。 * 0：正常 * 1：停用 * 2：未分配 
        /// </summary>
        /// <value>云会议室状态。 * 0：正常 * 1：停用 * 2：未分配 </value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly StatusEnum NUMBER_0 = new StatusEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly StatusEnum NUMBER_1 = new StatusEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly StatusEnum NUMBER_2 = new StatusEnum(2);

            private static readonly Dictionary<int?, StatusEnum> StaticFields =
            new Dictionary<int?, StatusEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
            };

            private int? _value;

            public StatusEnum()
            {

            }

            public StatusEnum(int? value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(int? value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 云会议室的ID。 &gt; 对应[[创建会议](https://support.huaweicloud.com/api-meeting/meeting_21_0014.html)](tag:hws)[[创建会议](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0014.html)](tag:hk)接口中的vmrID。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 云会议室的固定会议ID。 &gt; 对应[[创建会议](https://support.huaweicloud.com/api-meeting/meeting_21_0014.html)](tag:hws)[[创建会议](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0014.html)](tag:hk)接口返回数据的vmrConferenceID。 
        /// </summary>
        [JsonProperty("vmrId", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrId { get; set; }

        /// <summary>
        /// 云会议室名称。
        /// </summary>
        [JsonProperty("vmrName", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrName { get; set; }

        /// <summary>
        /// VMR模式。 - 0：个人会议ID - 1: 云会议室 - 2: 网络研讨会 
        /// </summary>
        [JsonProperty("vmrMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? VmrMode { get; set; }

        /// <summary>
        /// 云会议室套餐包的id，仅云会议室返回。
        /// </summary>
        [JsonProperty("vmrPkgId", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrPkgId { get; set; }

        /// <summary>
        /// 云会议室套餐包的名称，仅云会议室返回。
        /// </summary>
        [JsonProperty("vmrPkgName", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrPkgName { get; set; }

        /// <summary>
        /// 云会议室套餐包的会议并发方数，仅云会议室返回。
        /// </summary>
        [JsonProperty("vmrPkgParties", NullValueHandling = NullValueHandling.Ignore)]
        public int? VmrPkgParties { get; set; }

        /// <summary>
        /// 云会议室套餐包的与会时间，若为0则代表无限时长，仅云会议室返回。
        /// </summary>
        [JsonProperty("vmrPkgLength", NullValueHandling = NullValueHandling.Ignore)]
        public int? VmrPkgLength { get; set; }

        /// <summary>
        /// 云会议室状态。 * 0：正常 * 1：停用 * 2：未分配 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserVmrDTO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  vmrId: ").Append(VmrId).Append("\n");
            sb.Append("  vmrName: ").Append(VmrName).Append("\n");
            sb.Append("  vmrMode: ").Append(VmrMode).Append("\n");
            sb.Append("  vmrPkgId: ").Append(VmrPkgId).Append("\n");
            sb.Append("  vmrPkgName: ").Append(VmrPkgName).Append("\n");
            sb.Append("  vmrPkgParties: ").Append(VmrPkgParties).Append("\n");
            sb.Append("  vmrPkgLength: ").Append(VmrPkgLength).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserVmrDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserVmrDTO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.VmrId != input.VmrId || (this.VmrId != null && !this.VmrId.Equals(input.VmrId))) return false;
            if (this.VmrName != input.VmrName || (this.VmrName != null && !this.VmrName.Equals(input.VmrName))) return false;
            if (this.VmrMode != input.VmrMode || (this.VmrMode != null && !this.VmrMode.Equals(input.VmrMode))) return false;
            if (this.VmrPkgId != input.VmrPkgId || (this.VmrPkgId != null && !this.VmrPkgId.Equals(input.VmrPkgId))) return false;
            if (this.VmrPkgName != input.VmrPkgName || (this.VmrPkgName != null && !this.VmrPkgName.Equals(input.VmrPkgName))) return false;
            if (this.VmrPkgParties != input.VmrPkgParties || (this.VmrPkgParties != null && !this.VmrPkgParties.Equals(input.VmrPkgParties))) return false;
            if (this.VmrPkgLength != input.VmrPkgLength || (this.VmrPkgLength != null && !this.VmrPkgLength.Equals(input.VmrPkgLength))) return false;
            if (this.Status != input.Status) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.VmrId != null) hashCode = hashCode * 59 + this.VmrId.GetHashCode();
                if (this.VmrName != null) hashCode = hashCode * 59 + this.VmrName.GetHashCode();
                if (this.VmrMode != null) hashCode = hashCode * 59 + this.VmrMode.GetHashCode();
                if (this.VmrPkgId != null) hashCode = hashCode * 59 + this.VmrPkgId.GetHashCode();
                if (this.VmrPkgName != null) hashCode = hashCode * 59 + this.VmrPkgName.GetHashCode();
                if (this.VmrPkgParties != null) hashCode = hashCode * 59 + this.VmrPkgParties.GetHashCode();
                if (this.VmrPkgLength != null) hashCode = hashCode * 59 + this.VmrPkgLength.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
