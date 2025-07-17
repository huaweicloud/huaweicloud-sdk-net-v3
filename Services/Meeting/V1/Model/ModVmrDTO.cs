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
    /// 用户修改云会议室或者个人会议ID信息。
    /// </summary>
    public class ModVmrDTO 
    {

        /// <summary>
        /// 云会议室名称。 
        /// </summary>
        [JsonProperty("vmrName", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrName { get; set; }

        /// <summary>
        /// 来宾密码，设置为空字符串代表不设置来宾密码。 4~16位的数字 
        /// </summary>
        [JsonProperty("gustPwd", NullValueHandling = NullValueHandling.Ignore)]
        public string GustPwd { get; set; }

        /// <summary>
        /// 主持人密码。4~16位的数字。 
        /// </summary>
        [JsonProperty("chairPwd", NullValueHandling = NullValueHandling.Ignore)]
        public string ChairPwd { get; set; }

        /// <summary>
        /// 是否允许来宾先入会。
        /// </summary>
        [JsonProperty("allowGustFirst", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowGustFirst { get; set; }

        /// <summary>
        /// 云会议室被使用后是否通知会议室所有者。
        /// </summary>
        [JsonProperty("gustFirstNotice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GustFirstNotice { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModVmrDTO {\n");
            sb.Append("  vmrName: ").Append(VmrName).Append("\n");
            sb.Append("  gustPwd: ").Append(GustPwd).Append("\n");
            sb.Append("  chairPwd: ").Append(ChairPwd).Append("\n");
            sb.Append("  allowGustFirst: ").Append(AllowGustFirst).Append("\n");
            sb.Append("  gustFirstNotice: ").Append(GustFirstNotice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModVmrDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModVmrDTO input)
        {
            if (input == null) return false;
            if (this.VmrName != input.VmrName || (this.VmrName != null && !this.VmrName.Equals(input.VmrName))) return false;
            if (this.GustPwd != input.GustPwd || (this.GustPwd != null && !this.GustPwd.Equals(input.GustPwd))) return false;
            if (this.ChairPwd != input.ChairPwd || (this.ChairPwd != null && !this.ChairPwd.Equals(input.ChairPwd))) return false;
            if (this.AllowGustFirst != input.AllowGustFirst || (this.AllowGustFirst != null && !this.AllowGustFirst.Equals(input.AllowGustFirst))) return false;
            if (this.GustFirstNotice != input.GustFirstNotice || (this.GustFirstNotice != null && !this.GustFirstNotice.Equals(input.GustFirstNotice))) return false;

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
                if (this.VmrName != null) hashCode = hashCode * 59 + this.VmrName.GetHashCode();
                if (this.GustPwd != null) hashCode = hashCode * 59 + this.GustPwd.GetHashCode();
                if (this.ChairPwd != null) hashCode = hashCode * 59 + this.ChairPwd.GetHashCode();
                if (this.AllowGustFirst != null) hashCode = hashCode * 59 + this.AllowGustFirst.GetHashCode();
                if (this.GustFirstNotice != null) hashCode = hashCode * 59 + this.GustFirstNotice.GetHashCode();
                return hashCode;
            }
        }
    }
}
