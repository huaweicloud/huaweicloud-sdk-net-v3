using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 更新主机组请求体
    /// </summary>
    public class UpdateHostGroupRequestBody 
    {

        /// <summary>
        /// 主机组ID
        /// </summary>
        [JsonProperty("host_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HostGroupId { get; set; }

        /// <summary>
        /// 主机组名称
        /// </summary>
        [JsonProperty("host_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostGroupName { get; set; }

        /// <summary>
        /// 主机ID列表。主机类型必须与主机组类型一致
        /// </summary>
        [JsonProperty("host_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HostIdList { get; set; }

        /// <summary>
        /// 主机组标签。KEY不能重复
        /// </summary>
        [JsonProperty("host_group_tag", NullValueHandling = NullValueHandling.Ignore)]
        public List<HostGroupTag> HostGroupTag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateHostGroupRequestBody {\n");
            sb.Append("  hostGroupId: ").Append(HostGroupId).Append("\n");
            sb.Append("  hostGroupName: ").Append(HostGroupName).Append("\n");
            sb.Append("  hostIdList: ").Append(HostIdList).Append("\n");
            sb.Append("  hostGroupTag: ").Append(HostGroupTag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateHostGroupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateHostGroupRequestBody input)
        {
            if (input == null) return false;
            if (this.HostGroupId != input.HostGroupId || (this.HostGroupId != null && !this.HostGroupId.Equals(input.HostGroupId))) return false;
            if (this.HostGroupName != input.HostGroupName || (this.HostGroupName != null && !this.HostGroupName.Equals(input.HostGroupName))) return false;
            if (this.HostIdList != input.HostIdList || (this.HostIdList != null && input.HostIdList != null && !this.HostIdList.SequenceEqual(input.HostIdList))) return false;
            if (this.HostGroupTag != input.HostGroupTag || (this.HostGroupTag != null && input.HostGroupTag != null && !this.HostGroupTag.SequenceEqual(input.HostGroupTag))) return false;

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
                if (this.HostGroupId != null) hashCode = hashCode * 59 + this.HostGroupId.GetHashCode();
                if (this.HostGroupName != null) hashCode = hashCode * 59 + this.HostGroupName.GetHashCode();
                if (this.HostIdList != null) hashCode = hashCode * 59 + this.HostIdList.GetHashCode();
                if (this.HostGroupTag != null) hashCode = hashCode * 59 + this.HostGroupTag.GetHashCode();
                return hashCode;
            }
        }
    }
}
