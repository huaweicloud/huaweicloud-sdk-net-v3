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
    /// 导出用户会话列表请求体。
    /// </summary>
    public class ExportSessionsReq 
    {

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 搜索开始时间，以会话开始时间为条件查询，只支持导出30天内数据，格式2024-02-27T03:47:51.182Z。
        /// </summary>
        [JsonProperty("query_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? QueryBeginTime { get; set; }

        /// <summary>
        /// 搜索结束时间，以会话开始时间为条件查询，只支持导出30天内数据，格式2024-02-27T03:47:51.182Z。
        /// </summary>
        [JsonProperty("query_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? QueryEndTime { get; set; }

        /// <summary>
        /// AppServer组ID。
        /// </summary>
        [JsonProperty("app_server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppServerGroupId { get; set; }

        /// <summary>
        /// 服务器IP。
        /// </summary>
        [JsonProperty("vm_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string VmIp { get; set; }

        /// <summary>
        /// 客户端出口IP。
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 应用服务器名称。
        /// </summary>
        [JsonProperty("machine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineName { get; set; }

        /// <summary>
        /// 应用状态，支持查询多个，中间用英文逗号分隔： * &#x60;Active&#x60; - 会话当前处于活动状态，有用户登录并且正在使用。 * &#x60;Disconnected&#x60; - 用户已经登录但会话处于断开连接状态。 * &#x60;AppcInit&#x60; - 会话正在初始化。 * &#x60;SignedOut&#x60; - 会话已注销。 * &#x60;InitFail&#x60; - 会话初始化失败。
        /// </summary>
        [JsonProperty("session_state", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionState { get; set; }

        /// <summary>
        /// 会话是否创建成功,默认不填则查询全部 * &#39;true&#39; - 会话创建成功 * &#39;false&#39; - 会话创建失败
        /// </summary>
        [JsonProperty("is_success", NullValueHandling = NullValueHandling.Ignore)]
        public string IsSuccess { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportSessionsReq {\n");
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
            return this.Equals(input as ExportSessionsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportSessionsReq input)
        {
            if (input == null) return false;
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
