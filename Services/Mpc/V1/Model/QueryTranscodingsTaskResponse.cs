using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryTranscodingsTaskResponse 
    {
        /// <summary>
        /// 任务执行状态。 
        /// </summary>
        /// <value>任务执行状态。 </value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum NO_TASK for value: NO_TASK
            /// </summary>
            public static readonly StatusEnum NO_TASK = new StatusEnum("NO_TASK");

            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            public static readonly StatusEnum WAITING = new StatusEnum("WAITING");

            /// <summary>
            /// Enum TRANSCODING for value: TRANSCODING
            /// </summary>
            public static readonly StatusEnum TRANSCODING = new StatusEnum("TRANSCODING");

            /// <summary>
            /// Enum SUCCEEDED for value: SUCCEEDED
            /// </summary>
            public static readonly StatusEnum SUCCEEDED = new StatusEnum("SUCCEEDED");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("FAILED");

            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            public static readonly StatusEnum CANCELED = new StatusEnum("CANCELED");

            /// <summary>
            /// Enum NEED_TO_BE_AUDIT for value: NEED_TO_BE_AUDIT
            /// </summary>
            public static readonly StatusEnum NEED_TO_BE_AUDIT = new StatusEnum("NEED_TO_BE_AUDIT");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "NO_TASK", NO_TASK },
                { "WAITING", WAITING },
                { "TRANSCODING", TRANSCODING },
                { "SUCCEEDED", SUCCEEDED },
                { "FAILED", FAILED },
                { "CANCELED", CANCELED },
                { "NEED_TO_BE_AUDIT", NEED_TO_BE_AUDIT },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务执行状态。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 转码任务启动时间 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 转码任务结束时间 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 转码任务对应的转码模板ID 
        /// </summary>
        [JsonProperty("trans_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> TransTemplateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Output { get; set; }

        /// <summary>
        /// 转码生成的文件名，数组类型，可能包含多个，包含截图文件名。 
        /// </summary>
        [JsonProperty("output_file_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OutputFileName { get; set; }

        /// <summary>
        /// 用户自定义数据。 
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// 转码任务的返回码。 
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 转码任务描述，当转码出现异常时，此字段为异常的原因。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 转码成功，但音频采样率过低时的提示。 
        /// </summary>
        [JsonProperty("tips", NullValueHandling = NullValueHandling.Ignore)]
        public string Tips { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transcode_detail", NullValueHandling = NullValueHandling.Ignore)]
        public TranscodeDetail TranscodeDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thumbnail_output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo ThumbnailOutput { get; set; }

        /// <summary>
        /// 截图压缩包名。 
        /// </summary>
        [JsonProperty("thumbnail_outputname", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailOutputname { get; set; }

        /// <summary>
        /// 截图文件信息。 
        /// </summary>
        [JsonProperty("pic_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<PicInfo> PicInfo { get; set; }

        /// <summary>
        /// 转码参数。  若同时设置“trans_template_id”和此参数，则优先使用此参数进行转码。 
        /// </summary>
        [JsonProperty("av_parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<AvParameters> AvParameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryTranscodingsTaskResponse {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  transTemplateId: ").Append(TransTemplateId).Append("\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  outputFileName: ").Append(OutputFileName).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  tips: ").Append(Tips).Append("\n");
            sb.Append("  transcodeDetail: ").Append(TranscodeDetail).Append("\n");
            sb.Append("  thumbnailOutput: ").Append(ThumbnailOutput).Append("\n");
            sb.Append("  thumbnailOutputname: ").Append(ThumbnailOutputname).Append("\n");
            sb.Append("  picInfo: ").Append(PicInfo).Append("\n");
            sb.Append("  avParameters: ").Append(AvParameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryTranscodingsTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryTranscodingsTaskResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.TransTemplateId == input.TransTemplateId ||
                    this.TransTemplateId != null &&
                    input.TransTemplateId != null &&
                    this.TransTemplateId.SequenceEqual(input.TransTemplateId)
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.OutputFileName == input.OutputFileName ||
                    this.OutputFileName != null &&
                    input.OutputFileName != null &&
                    this.OutputFileName.SequenceEqual(input.OutputFileName)
                ) && 
                (
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Tips == input.Tips ||
                    (this.Tips != null &&
                    this.Tips.Equals(input.Tips))
                ) && 
                (
                    this.TranscodeDetail == input.TranscodeDetail ||
                    (this.TranscodeDetail != null &&
                    this.TranscodeDetail.Equals(input.TranscodeDetail))
                ) && 
                (
                    this.ThumbnailOutput == input.ThumbnailOutput ||
                    (this.ThumbnailOutput != null &&
                    this.ThumbnailOutput.Equals(input.ThumbnailOutput))
                ) && 
                (
                    this.ThumbnailOutputname == input.ThumbnailOutputname ||
                    (this.ThumbnailOutputname != null &&
                    this.ThumbnailOutputname.Equals(input.ThumbnailOutputname))
                ) && 
                (
                    this.PicInfo == input.PicInfo ||
                    this.PicInfo != null &&
                    input.PicInfo != null &&
                    this.PicInfo.SequenceEqual(input.PicInfo)
                ) && 
                (
                    this.AvParameters == input.AvParameters ||
                    this.AvParameters != null &&
                    input.AvParameters != null &&
                    this.AvParameters.SequenceEqual(input.AvParameters)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.TransTemplateId != null)
                    hashCode = hashCode * 59 + this.TransTemplateId.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.OutputFileName != null)
                    hashCode = hashCode * 59 + this.OutputFileName.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Tips != null)
                    hashCode = hashCode * 59 + this.Tips.GetHashCode();
                if (this.TranscodeDetail != null)
                    hashCode = hashCode * 59 + this.TranscodeDetail.GetHashCode();
                if (this.ThumbnailOutput != null)
                    hashCode = hashCode * 59 + this.ThumbnailOutput.GetHashCode();
                if (this.ThumbnailOutputname != null)
                    hashCode = hashCode * 59 + this.ThumbnailOutputname.GetHashCode();
                if (this.PicInfo != null)
                    hashCode = hashCode * 59 + this.PicInfo.GetHashCode();
                if (this.AvParameters != null)
                    hashCode = hashCode * 59 + this.AvParameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
