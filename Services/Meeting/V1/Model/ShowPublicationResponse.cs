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
    /// Response Object
    /// </summary>
    public class ShowPublicationResponse : SdkResponse
    {
        /// <summary>
        /// 根据当前时间确定发布状态。 - NOT_ONLINE-未上线 - PUBLISHING-发布中 - ALREADY_OFFLINE-已下线
        /// </summary>
        /// <value>根据当前时间确定发布状态。 - NOT_ONLINE-未上线 - PUBLISHING-发布中 - ALREADY_OFFLINE-已下线</value>
        [JsonConverter(typeof(EnumClassConverter<PublishStatusEnum>))]
        public class PublishStatusEnum
        {
            /// <summary>
            /// Enum NOT_ONLINE for value: NOT_ONLINE
            /// </summary>
            public static readonly PublishStatusEnum NOT_ONLINE = new PublishStatusEnum("NOT_ONLINE");

            /// <summary>
            /// Enum PUBLISHING for value: PUBLISHING
            /// </summary>
            public static readonly PublishStatusEnum PUBLISHING = new PublishStatusEnum("PUBLISHING");

            /// <summary>
            /// Enum ALREADY_OFFLINE for value: ALREADY_OFFLINE
            /// </summary>
            public static readonly PublishStatusEnum ALREADY_OFFLINE = new PublishStatusEnum("ALREADY_OFFLINE");

            private static readonly Dictionary<string, PublishStatusEnum> StaticFields =
            new Dictionary<string, PublishStatusEnum>()
            {
                { "NOT_ONLINE", NOT_ONLINE },
                { "PUBLISHING", PUBLISHING },
                { "ALREADY_OFFLINE", ALREADY_OFFLINE },
            };

            private string _value;

            public PublishStatusEnum()
            {

            }

            public PublishStatusEnum(string value)
            {
                _value = value;
            }

            public static PublishStatusEnum FromValue(string value)
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

                if (this.Equals(obj as PublishStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PublishStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PublishStatusEnum a, PublishStatusEnum b)
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

            public static bool operator !=(PublishStatusEnum a, PublishStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 发布ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 更新者。
        /// </summary>
        [JsonProperty("lastUpdatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("updateTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 发布名称。
        /// </summary>
        [JsonProperty("publishName", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishName { get; set; }

        /// <summary>
        /// 发布范围。
        /// </summary>
        [JsonProperty("publishScope", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishScope { get; set; }

        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 根据当前时间确定发布状态。 - NOT_ONLINE-未上线 - PUBLISHING-发布中 - ALREADY_OFFLINE-已下线
        /// </summary>
        [JsonProperty("publishStatus", NullValueHandling = NullValueHandling.Ignore)]
        public PublishStatusEnum PublishStatus { get; set; }
        /// <summary>
        /// 发布节目ID列表。
        /// </summary>
        [JsonProperty("programList", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProgramResponseBase> ProgramList { get; set; }

        /// <summary>
        /// 发布部门列表。
        /// </summary>
        [JsonProperty("deptList", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublishDeptResponseDTO> DeptList { get; set; }

        /// <summary>
        /// 发布设备列表。
        /// </summary>
        [JsonProperty("deviceList", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublishDeviceResponseDTO> DeviceList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPublicationResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  lastUpdatedBy: ").Append(LastUpdatedBy).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  publishName: ").Append(PublishName).Append("\n");
            sb.Append("  publishScope: ").Append(PublishScope).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  publishStatus: ").Append(PublishStatus).Append("\n");
            sb.Append("  programList: ").Append(ProgramList).Append("\n");
            sb.Append("  deptList: ").Append(DeptList).Append("\n");
            sb.Append("  deviceList: ").Append(DeviceList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPublicationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPublicationResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.LastUpdatedBy != input.LastUpdatedBy || (this.LastUpdatedBy != null && !this.LastUpdatedBy.Equals(input.LastUpdatedBy))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.PublishName != input.PublishName || (this.PublishName != null && !this.PublishName.Equals(input.PublishName))) return false;
            if (this.PublishScope != input.PublishScope || (this.PublishScope != null && !this.PublishScope.Equals(input.PublishScope))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.PublishStatus != input.PublishStatus) return false;
            if (this.ProgramList != input.ProgramList || (this.ProgramList != null && input.ProgramList != null && !this.ProgramList.SequenceEqual(input.ProgramList))) return false;
            if (this.DeptList != input.DeptList || (this.DeptList != null && input.DeptList != null && !this.DeptList.SequenceEqual(input.DeptList))) return false;
            if (this.DeviceList != input.DeviceList || (this.DeviceList != null && input.DeviceList != null && !this.DeviceList.SequenceEqual(input.DeviceList))) return false;

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
                if (this.LastUpdatedBy != null) hashCode = hashCode * 59 + this.LastUpdatedBy.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.PublishName != null) hashCode = hashCode * 59 + this.PublishName.GetHashCode();
                if (this.PublishScope != null) hashCode = hashCode * 59 + this.PublishScope.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.PublishStatus.GetHashCode();
                if (this.ProgramList != null) hashCode = hashCode * 59 + this.ProgramList.GetHashCode();
                if (this.DeptList != null) hashCode = hashCode * 59 + this.DeptList.GetHashCode();
                if (this.DeviceList != null) hashCode = hashCode * 59 + this.DeviceList.GetHashCode();
                return hashCode;
            }
        }
    }
}
