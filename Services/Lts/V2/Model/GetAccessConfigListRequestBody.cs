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
    /// 查询日志接入列表请求体
    /// </summary>
    public class GetAccessConfigListRequestBody 
    {

        /// <summary>
        /// 接入配置名称列表
        /// </summary>
        [JsonProperty("access_config_name_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessConfigNameList { get; set; }

        /// <summary>
        /// 主机组名称列表
        /// </summary>
        [JsonProperty("host_group_name_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HostGroupNameList { get; set; }

        /// <summary>
        /// 日志组名称列表
        /// </summary>
        [JsonProperty("log_group_name_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LogGroupNameList { get; set; }

        /// <summary>
        /// 日志流名称列表
        /// </summary>
        [JsonProperty("log_stream_name_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LogStreamNameList { get; set; }

        /// <summary>
        /// 接入配置标签，KEY不能重复,最多20个标签
        /// </summary>
        [JsonProperty("access_config_tag_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessConfigTag> AccessConfigTagList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAccessConfigListRequestBody {\n");
            sb.Append("  accessConfigNameList: ").Append(AccessConfigNameList).Append("\n");
            sb.Append("  hostGroupNameList: ").Append(HostGroupNameList).Append("\n");
            sb.Append("  logGroupNameList: ").Append(LogGroupNameList).Append("\n");
            sb.Append("  logStreamNameList: ").Append(LogStreamNameList).Append("\n");
            sb.Append("  accessConfigTagList: ").Append(AccessConfigTagList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetAccessConfigListRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetAccessConfigListRequestBody input)
        {
            if (input == null) return false;
            if (this.AccessConfigNameList != input.AccessConfigNameList || (this.AccessConfigNameList != null && input.AccessConfigNameList != null && !this.AccessConfigNameList.SequenceEqual(input.AccessConfigNameList))) return false;
            if (this.HostGroupNameList != input.HostGroupNameList || (this.HostGroupNameList != null && input.HostGroupNameList != null && !this.HostGroupNameList.SequenceEqual(input.HostGroupNameList))) return false;
            if (this.LogGroupNameList != input.LogGroupNameList || (this.LogGroupNameList != null && input.LogGroupNameList != null && !this.LogGroupNameList.SequenceEqual(input.LogGroupNameList))) return false;
            if (this.LogStreamNameList != input.LogStreamNameList || (this.LogStreamNameList != null && input.LogStreamNameList != null && !this.LogStreamNameList.SequenceEqual(input.LogStreamNameList))) return false;
            if (this.AccessConfigTagList != input.AccessConfigTagList || (this.AccessConfigTagList != null && input.AccessConfigTagList != null && !this.AccessConfigTagList.SequenceEqual(input.AccessConfigTagList))) return false;

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
                if (this.AccessConfigNameList != null) hashCode = hashCode * 59 + this.AccessConfigNameList.GetHashCode();
                if (this.HostGroupNameList != null) hashCode = hashCode * 59 + this.HostGroupNameList.GetHashCode();
                if (this.LogGroupNameList != null) hashCode = hashCode * 59 + this.LogGroupNameList.GetHashCode();
                if (this.LogStreamNameList != null) hashCode = hashCode * 59 + this.LogStreamNameList.GetHashCode();
                if (this.AccessConfigTagList != null) hashCode = hashCode * 59 + this.AccessConfigTagList.GetHashCode();
                return hashCode;
            }
        }
    }
}
