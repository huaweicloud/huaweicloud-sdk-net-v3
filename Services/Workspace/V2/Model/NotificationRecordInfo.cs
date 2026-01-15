using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 通知拦截记录信息详情
    /// </summary>
    public class NotificationRecordInfo 
    {

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 发送SMN类型:EMAIL-邮件、SMS-短信
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 桌面名
        /// </summary>
        [JsonProperty("desktop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopName { get; set; }

        /// <summary>
        /// 桌面池名称
        /// </summary>
        [JsonProperty("desktop_pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopPoolName { get; set; }

        /// <summary>
        /// 发送结果
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 报错信息
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonProperty("operate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationRecordInfo {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  desktopName: ").Append(DesktopName).Append("\n");
            sb.Append("  desktopPoolName: ").Append(DesktopPoolName).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  operateTime: ").Append(OperateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotificationRecordInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NotificationRecordInfo input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.DesktopName != input.DesktopName || (this.DesktopName != null && !this.DesktopName.Equals(input.DesktopName))) return false;
            if (this.DesktopPoolName != input.DesktopPoolName || (this.DesktopPoolName != null && !this.DesktopPoolName.Equals(input.DesktopPoolName))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;
            if (this.OperateTime != input.OperateTime || (this.OperateTime != null && !this.OperateTime.Equals(input.OperateTime))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.DesktopName != null) hashCode = hashCode * 59 + this.DesktopName.GetHashCode();
                if (this.DesktopPoolName != null) hashCode = hashCode * 59 + this.DesktopPoolName.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.OperateTime != null) hashCode = hashCode * 59 + this.OperateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
