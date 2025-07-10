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
    /// 
    /// </summary>
    public class ScreenRecordDetail 
    {

        /// <summary>
        /// 主键UUID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 桌面ID。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 桌面名称。
        /// </summary>
        [JsonProperty("desktop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopName { get; set; }

        /// <summary>
        /// 桌面池ID。
        /// </summary>
        [JsonProperty("desktop_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopPoolId { get; set; }

        /// <summary>
        /// 用户名称。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// 文件大小（Byte）。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 录屏类型。 - FULL：全程录屏。 - INTERVAL：间隔录屏。 - OPERATION：用户操作录屏。 - SESSION：监听会话生命周期录屏。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 录屏状态。 - RECORDING：录制中。 - REC_COMPLETED：录制完成。 - REC_FAILED：录制失败。 - UPLOADING：上传中。 - UPLOAD_COMPLETED：上传完成。 - UPLOAD_FAILED：上传失败。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 策略ID。
        /// </summary>
        [JsonProperty("policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyId { get; set; }

        /// <summary>
        /// OBS桶名称。
        /// </summary>
        [JsonProperty("obs_bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucket { get; set; }

        /// <summary>
        /// 文件目录。
        /// </summary>
        [JsonProperty("file_directory", NullValueHandling = NullValueHandling.Ignore)]
        public string FileDirectory { get; set; }

        /// <summary>
        /// 录屏文件名称。
        /// </summary>
        [JsonProperty("video_filename", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoFilename { get; set; }

        /// <summary>
        /// 录屏文件sha256。
        /// </summary>
        [JsonProperty("video_file_sha256", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoFileSha256 { get; set; }

        /// <summary>
        /// 事件文件名称。
        /// </summary>
        [JsonProperty("event_filename", NullValueHandling = NullValueHandling.Ignore)]
        public string EventFilename { get; set; }

        /// <summary>
        /// 事件文件sha256。
        /// </summary>
        [JsonProperty("event_file_sha256", NullValueHandling = NullValueHandling.Ignore)]
        public string EventFileSha256 { get; set; }

        /// <summary>
        /// 开始时间（2024-10-15T10:04:41.263Z）。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间（2024-10-15T11:04:41.263Z）。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 更新时间（2024-10-15T11:04:41.263Z）。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 视频时长（秒）。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecordDetail {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  desktopName: ").Append(DesktopName).Append("\n");
            sb.Append("  desktopPoolId: ").Append(DesktopPoolId).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  obsBucket: ").Append(ObsBucket).Append("\n");
            sb.Append("  fileDirectory: ").Append(FileDirectory).Append("\n");
            sb.Append("  videoFilename: ").Append(VideoFilename).Append("\n");
            sb.Append("  videoFileSha256: ").Append(VideoFileSha256).Append("\n");
            sb.Append("  eventFilename: ").Append(EventFilename).Append("\n");
            sb.Append("  eventFileSha256: ").Append(EventFileSha256).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScreenRecordDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScreenRecordDetail input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.DesktopName != input.DesktopName || (this.DesktopName != null && !this.DesktopName.Equals(input.DesktopName))) return false;
            if (this.DesktopPoolId != input.DesktopPoolId || (this.DesktopPoolId != null && !this.DesktopPoolId.Equals(input.DesktopPoolId))) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.PolicyId != input.PolicyId || (this.PolicyId != null && !this.PolicyId.Equals(input.PolicyId))) return false;
            if (this.ObsBucket != input.ObsBucket || (this.ObsBucket != null && !this.ObsBucket.Equals(input.ObsBucket))) return false;
            if (this.FileDirectory != input.FileDirectory || (this.FileDirectory != null && !this.FileDirectory.Equals(input.FileDirectory))) return false;
            if (this.VideoFilename != input.VideoFilename || (this.VideoFilename != null && !this.VideoFilename.Equals(input.VideoFilename))) return false;
            if (this.VideoFileSha256 != input.VideoFileSha256 || (this.VideoFileSha256 != null && !this.VideoFileSha256.Equals(input.VideoFileSha256))) return false;
            if (this.EventFilename != input.EventFilename || (this.EventFilename != null && !this.EventFilename.Equals(input.EventFilename))) return false;
            if (this.EventFileSha256 != input.EventFileSha256 || (this.EventFileSha256 != null && !this.EventFileSha256.Equals(input.EventFileSha256))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;

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
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.DesktopName != null) hashCode = hashCode * 59 + this.DesktopName.GetHashCode();
                if (this.DesktopPoolId != null) hashCode = hashCode * 59 + this.DesktopPoolId.GetHashCode();
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PolicyId != null) hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.ObsBucket != null) hashCode = hashCode * 59 + this.ObsBucket.GetHashCode();
                if (this.FileDirectory != null) hashCode = hashCode * 59 + this.FileDirectory.GetHashCode();
                if (this.VideoFilename != null) hashCode = hashCode * 59 + this.VideoFilename.GetHashCode();
                if (this.VideoFileSha256 != null) hashCode = hashCode * 59 + this.VideoFileSha256.GetHashCode();
                if (this.EventFilename != null) hashCode = hashCode * 59 + this.EventFilename.GetHashCode();
                if (this.EventFileSha256 != null) hashCode = hashCode * 59 + this.EventFileSha256.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                return hashCode;
            }
        }
    }
}
