using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListSessionsRequest 
    {

        /// <summary>
        /// 单次查询的大小[1-100]，默认值10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询的偏移量，默认值0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [SDKProperty("user_name", IsQuery = true)]
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 搜索开始时间，以会话开始时间为条件查询，格式2024-02-27T03:47:51.182Z。
        /// </summary>
        [SDKProperty("query_begin_time", IsQuery = true)]
        [JsonProperty("query_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryBeginTime { get; set; }

        /// <summary>
        /// 搜索结束时间，以会话开始时间为条件查询，格式2024-02-27T03:47:51.182Z。
        /// </summary>
        [SDKProperty("query_end_time", IsQuery = true)]
        [JsonProperty("query_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryEndTime { get; set; }

        /// <summary>
        /// AppServer组ID。
        /// </summary>
        [SDKProperty("app_server_group_id", IsQuery = true)]
        [JsonProperty("app_server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppServerGroupId { get; set; }

        /// <summary>
        /// 服务器IP。
        /// </summary>
        [SDKProperty("vm_ip", IsQuery = true)]
        [JsonProperty("vm_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string VmIp { get; set; }

        /// <summary>
        /// 客户端出口IP。
        /// </summary>
        [SDKProperty("public_ip", IsQuery = true)]
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 应用服务器名称。
        /// </summary>
        [SDKProperty("machine_name", IsQuery = true)]
        [JsonProperty("machine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineName { get; set; }

        /// <summary>
        /// 应用状态，支持查询多个，中间用英文逗号分隔： * &#x60;Active&#x60; - 会话当前处于活动状态，有用户登录并且正在使用。 * &#x60;Disconnected&#x60; - 用户已经登录但会话处于断开连接状态。 * &#x60;AppcInit&#x60; - 会话正在初始化。 * &#x60;SignedOut&#x60; - 会话已注销。 * &#x60;InitFail&#x60; - 会话初始化失败。
        /// </summary>
        [SDKProperty("session_state", IsQuery = true)]
        [JsonProperty("session_state", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionState { get; set; }

        /// <summary>
        /// 会话是否创建成功,默认不填则查询全部 * &#39;true&#39; - 会话创建成功 * &#39;false&#39; - 会话创建失败
        /// </summary>
        [SDKProperty("is_success", IsQuery = true)]
        [JsonProperty("is_success", NullValueHandling = NullValueHandling.Ignore)]
        public string IsSuccess { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSessionsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  queryBeginTime: ").Append(QueryBeginTime).Append("\n");
            sb.Append("  queryEndTime: ").Append(QueryEndTime).Append("\n");
            sb.Append("  appServerGroupId: ").Append(AppServerGroupId).Append("\n");
            sb.Append("  vmIp: ").Append(VmIp).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  machineName: ").Append(MachineName).Append("\n");
            sb.Append("  sessionState: ").Append(SessionState).Append("\n");
            sb.Append("  isSuccess: ").Append(IsSuccess).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSessionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSessionsRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.QueryBeginTime != input.QueryBeginTime || (this.QueryBeginTime != null && !this.QueryBeginTime.Equals(input.QueryBeginTime))) return false;
            if (this.QueryEndTime != input.QueryEndTime || (this.QueryEndTime != null && !this.QueryEndTime.Equals(input.QueryEndTime))) return false;
            if (this.AppServerGroupId != input.AppServerGroupId || (this.AppServerGroupId != null && !this.AppServerGroupId.Equals(input.AppServerGroupId))) return false;
            if (this.VmIp != input.VmIp || (this.VmIp != null && !this.VmIp.Equals(input.VmIp))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.MachineName != input.MachineName || (this.MachineName != null && !this.MachineName.Equals(input.MachineName))) return false;
            if (this.SessionState != input.SessionState || (this.SessionState != null && !this.SessionState.Equals(input.SessionState))) return false;
            if (this.IsSuccess != input.IsSuccess || (this.IsSuccess != null && !this.IsSuccess.Equals(input.IsSuccess))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.QueryBeginTime != null) hashCode = hashCode * 59 + this.QueryBeginTime.GetHashCode();
                if (this.QueryEndTime != null) hashCode = hashCode * 59 + this.QueryEndTime.GetHashCode();
                if (this.AppServerGroupId != null) hashCode = hashCode * 59 + this.AppServerGroupId.GetHashCode();
                if (this.VmIp != null) hashCode = hashCode * 59 + this.VmIp.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.MachineName != null) hashCode = hashCode * 59 + this.MachineName.GetHashCode();
                if (this.SessionState != null) hashCode = hashCode * 59 + this.SessionState.GetHashCode();
                if (this.IsSuccess != null) hashCode = hashCode * 59 + this.IsSuccess.GetHashCode();
                return hashCode;
            }
        }
    }
}
