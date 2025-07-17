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
    public class ModCorpDTO 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("basicInfo", NullValueHandling = NullValueHandling.Ignore)]
        public ModCorpBasicDTO BasicInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("adminInfo", NullValueHandling = NullValueHandling.Ignore)]
        public ModAdminDTO AdminInfo { get; set; }

        /// <summary>
        /// 媒体接入（包括SBC和MCU）分组id，可通过[[SP管理员查询资源信息](https://support.huaweicloud.com/api-meeting/meeting_21_1537.html)](tag:hws)[[SP管理员查询资源信息](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_1537.html)](tag:hk)接口查询获取。
        /// </summary>
        [JsonProperty("groupId", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 可配置项信息。
        /// </summary>
        [JsonProperty("propertyInfo", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrgPropertyDTO> PropertyInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModCorpDTO {\n");
            sb.Append("  basicInfo: ").Append(BasicInfo).Append("\n");
            sb.Append("  adminInfo: ").Append(AdminInfo).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  propertyInfo: ").Append(PropertyInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModCorpDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModCorpDTO input)
        {
            if (input == null) return false;
            if (this.BasicInfo != input.BasicInfo || (this.BasicInfo != null && !this.BasicInfo.Equals(input.BasicInfo))) return false;
            if (this.AdminInfo != input.AdminInfo || (this.AdminInfo != null && !this.AdminInfo.Equals(input.AdminInfo))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.PropertyInfo != input.PropertyInfo || (this.PropertyInfo != null && input.PropertyInfo != null && !this.PropertyInfo.SequenceEqual(input.PropertyInfo))) return false;

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
                if (this.BasicInfo != null) hashCode = hashCode * 59 + this.BasicInfo.GetHashCode();
                if (this.AdminInfo != null) hashCode = hashCode * 59 + this.AdminInfo.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.PropertyInfo != null) hashCode = hashCode * 59 + this.PropertyInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
