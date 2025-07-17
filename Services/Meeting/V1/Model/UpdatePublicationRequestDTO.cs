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
    /// 更新发布信息。
    /// </summary>
    public class UpdatePublicationRequestDTO 
    {

        /// <summary>
        /// 发布名称。
        /// </summary>
        [JsonProperty("publishName", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishName { get; set; }

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
        /// 发布到部门编码列表。
        /// </summary>
        [JsonProperty("deptList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeptList { get; set; }

        /// <summary>
        /// 发布到设备用户ID列表。
        /// </summary>
        [JsonProperty("deviceList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeviceList { get; set; }

        /// <summary>
        /// 发布节目ID列表。
        /// </summary>
        [JsonProperty("programList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProgramList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePublicationRequestDTO {\n");
            sb.Append("  publishName: ").Append(PublishName).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  deptList: ").Append(DeptList).Append("\n");
            sb.Append("  deviceList: ").Append(DeviceList).Append("\n");
            sb.Append("  programList: ").Append(ProgramList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePublicationRequestDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePublicationRequestDTO input)
        {
            if (input == null) return false;
            if (this.PublishName != input.PublishName || (this.PublishName != null && !this.PublishName.Equals(input.PublishName))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.DeptList != input.DeptList || (this.DeptList != null && input.DeptList != null && !this.DeptList.SequenceEqual(input.DeptList))) return false;
            if (this.DeviceList != input.DeviceList || (this.DeviceList != null && input.DeviceList != null && !this.DeviceList.SequenceEqual(input.DeviceList))) return false;
            if (this.ProgramList != input.ProgramList || (this.ProgramList != null && input.ProgramList != null && !this.ProgramList.SequenceEqual(input.ProgramList))) return false;

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
                if (this.PublishName != null) hashCode = hashCode * 59 + this.PublishName.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.DeptList != null) hashCode = hashCode * 59 + this.DeptList.GetHashCode();
                if (this.DeviceList != null) hashCode = hashCode * 59 + this.DeviceList.GetHashCode();
                if (this.ProgramList != null) hashCode = hashCode * 59 + this.ProgramList.GetHashCode();
                return hashCode;
            }
        }
    }
}
