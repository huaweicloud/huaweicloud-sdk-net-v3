using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 租户执行分身数字人模型训练任务命令请求。
    /// </summary>
    public class Execute2dModelTrainingCommandByUserReq 
    {
        /// <summary>
        /// 命令类型。 * SUBMITVERIFYING: 提交审核 * CONFIRM_ACCEPT：用户确认训练效果 * CONFIRM_REJECT：用户驳回训练效果 * CONFIRM_ANSWER：用户答复 * CONFIRM_PENDING：用户挂起任务 * CONFIRM_ACTIVE：用户激活任务 * GET_MULTIPART_UPLOADED：获取训练视频已上传分片信息 * CONFIRM_REPAIR:用户发起优化模型请求 * CONFIRM_MULTIPART_UPLOADED：确认训练视频所有分片文件已上传 * GET_ACTION_VIDEO_MULTIPART_UPLOADED：获取动作编排视频分片上传地址 * CONFIRM_ACTION_VIDEO_MULTIPART_UPLOADED：确认动作编排视频所有分片文件已上传 &gt; * CONFIRM_ACCEPT、CONFIRM_REJECT、CONFIRM_ANSWER、CONFIRM_PENDING、CONFIRM_ACTIVE命令仅NA白名单用户可用。
        /// </summary>
        /// <value>命令类型。 * SUBMITVERIFYING: 提交审核 * CONFIRM_ACCEPT：用户确认训练效果 * CONFIRM_REJECT：用户驳回训练效果 * CONFIRM_ANSWER：用户答复 * CONFIRM_PENDING：用户挂起任务 * CONFIRM_ACTIVE：用户激活任务 * GET_MULTIPART_UPLOADED：获取训练视频已上传分片信息 * CONFIRM_REPAIR:用户发起优化模型请求 * CONFIRM_MULTIPART_UPLOADED：确认训练视频所有分片文件已上传 * GET_ACTION_VIDEO_MULTIPART_UPLOADED：获取动作编排视频分片上传地址 * CONFIRM_ACTION_VIDEO_MULTIPART_UPLOADED：确认动作编排视频所有分片文件已上传 &gt; * CONFIRM_ACCEPT、CONFIRM_REJECT、CONFIRM_ANSWER、CONFIRM_PENDING、CONFIRM_ACTIVE命令仅NA白名单用户可用。</value>
        [JsonConverter(typeof(EnumClassConverter<CommandEnum>))]
        public class CommandEnum
        {
            /// <summary>
            /// Enum SUBMITVERIFYING for value: SUBMITVERIFYING
            /// </summary>
            public static readonly CommandEnum SUBMITVERIFYING = new CommandEnum("SUBMITVERIFYING");

            /// <summary>
            /// Enum CONFIRM_ACCEPT for value: CONFIRM_ACCEPT
            /// </summary>
            public static readonly CommandEnum CONFIRM_ACCEPT = new CommandEnum("CONFIRM_ACCEPT");

            /// <summary>
            /// Enum CONFIRM_REJECT for value: CONFIRM_REJECT
            /// </summary>
            public static readonly CommandEnum CONFIRM_REJECT = new CommandEnum("CONFIRM_REJECT");

            /// <summary>
            /// Enum CONFIRM_ANSWER for value: CONFIRM_ANSWER
            /// </summary>
            public static readonly CommandEnum CONFIRM_ANSWER = new CommandEnum("CONFIRM_ANSWER");

            /// <summary>
            /// Enum CONFIRM_PENDING for value: CONFIRM_PENDING
            /// </summary>
            public static readonly CommandEnum CONFIRM_PENDING = new CommandEnum("CONFIRM_PENDING");

            /// <summary>
            /// Enum CONFIRM_ACTIVE for value: CONFIRM_ACTIVE
            /// </summary>
            public static readonly CommandEnum CONFIRM_ACTIVE = new CommandEnum("CONFIRM_ACTIVE");

            /// <summary>
            /// Enum GET_MULTIPART_UPLOADED for value: GET_MULTIPART_UPLOADED
            /// </summary>
            public static readonly CommandEnum GET_MULTIPART_UPLOADED = new CommandEnum("GET_MULTIPART_UPLOADED");

            /// <summary>
            /// Enum CONFIRM_REPAIR for value: CONFIRM_REPAIR
            /// </summary>
            public static readonly CommandEnum CONFIRM_REPAIR = new CommandEnum("CONFIRM_REPAIR");

            /// <summary>
            /// Enum CONFIRM_MULTIPART_UPLOADED for value: CONFIRM_MULTIPART_UPLOADED
            /// </summary>
            public static readonly CommandEnum CONFIRM_MULTIPART_UPLOADED = new CommandEnum("CONFIRM_MULTIPART_UPLOADED");

            /// <summary>
            /// Enum GET_ACTION_VIDEO_MULTIPART_UPLOADED for value: GET_ACTION_VIDEO_MULTIPART_UPLOADED
            /// </summary>
            public static readonly CommandEnum GET_ACTION_VIDEO_MULTIPART_UPLOADED = new CommandEnum("GET_ACTION_VIDEO_MULTIPART_UPLOADED");

            /// <summary>
            /// Enum CONFIRM_ACTION_VIDEO_MULTIPART_UPLOADED for value: CONFIRM_ACTION_VIDEO_MULTIPART_UPLOADED
            /// </summary>
            public static readonly CommandEnum CONFIRM_ACTION_VIDEO_MULTIPART_UPLOADED = new CommandEnum("CONFIRM_ACTION_VIDEO_MULTIPART_UPLOADED");

            private static readonly Dictionary<string, CommandEnum> StaticFields =
            new Dictionary<string, CommandEnum>()
            {
                { "SUBMITVERIFYING", SUBMITVERIFYING },
                { "CONFIRM_ACCEPT", CONFIRM_ACCEPT },
                { "CONFIRM_REJECT", CONFIRM_REJECT },
                { "CONFIRM_ANSWER", CONFIRM_ANSWER },
                { "CONFIRM_PENDING", CONFIRM_PENDING },
                { "CONFIRM_ACTIVE", CONFIRM_ACTIVE },
                { "GET_MULTIPART_UPLOADED", GET_MULTIPART_UPLOADED },
                { "CONFIRM_REPAIR", CONFIRM_REPAIR },
                { "CONFIRM_MULTIPART_UPLOADED", CONFIRM_MULTIPART_UPLOADED },
                { "GET_ACTION_VIDEO_MULTIPART_UPLOADED", GET_ACTION_VIDEO_MULTIPART_UPLOADED },
                { "CONFIRM_ACTION_VIDEO_MULTIPART_UPLOADED", CONFIRM_ACTION_VIDEO_MULTIPART_UPLOADED },
            };

            private string _value;

            public CommandEnum()
            {

            }

            public CommandEnum(string value)
            {
                _value = value;
            }

            public static CommandEnum FromValue(string value)
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

                if (this.Equals(obj as CommandEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CommandEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CommandEnum a, CommandEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(CommandEnum a, CommandEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 命令类型： * UPDATE_VIDEO: 更新视频 * UPLOAD_VIDEO: 上传视频 * CONFIRM_ACTION_VIDEO: 确认动作编排视频 * GET_ACTION_VIDEO_MULTIPART: 获取动作编排视频分片
        /// </summary>
        /// <value>命令类型： * UPDATE_VIDEO: 更新视频 * UPLOAD_VIDEO: 上传视频 * CONFIRM_ACTION_VIDEO: 确认动作编排视频 * GET_ACTION_VIDEO_MULTIPART: 获取动作编排视频分片</value>
        [JsonConverter(typeof(EnumClassConverter<CommandMessageEnum>))]
        public class CommandMessageEnum
        {
            /// <summary>
            /// Enum UPDATE_VIDEO for value: UPDATE_VIDEO
            /// </summary>
            public static readonly CommandMessageEnum UPDATE_VIDEO = new CommandMessageEnum("UPDATE_VIDEO");

            /// <summary>
            /// Enum UPLOAD_VIDEO for value: UPLOAD_VIDEO
            /// </summary>
            public static readonly CommandMessageEnum UPLOAD_VIDEO = new CommandMessageEnum("UPLOAD_VIDEO");

            /// <summary>
            /// Enum CONFIRM_ACTION_VIDEO for value: CONFIRM_ACTION_VIDEO
            /// </summary>
            public static readonly CommandMessageEnum CONFIRM_ACTION_VIDEO = new CommandMessageEnum("CONFIRM_ACTION_VIDEO");

            /// <summary>
            /// Enum GET_ACTION_VIDEO_MULTIPART for value: GET_ACTION_VIDEO_MULTIPART
            /// </summary>
            public static readonly CommandMessageEnum GET_ACTION_VIDEO_MULTIPART = new CommandMessageEnum("GET_ACTION_VIDEO_MULTIPART");

            private static readonly Dictionary<string, CommandMessageEnum> StaticFields =
            new Dictionary<string, CommandMessageEnum>()
            {
                { "UPDATE_VIDEO", UPDATE_VIDEO },
                { "UPLOAD_VIDEO", UPLOAD_VIDEO },
                { "CONFIRM_ACTION_VIDEO", CONFIRM_ACTION_VIDEO },
                { "GET_ACTION_VIDEO_MULTIPART", GET_ACTION_VIDEO_MULTIPART },
            };

            private string _value;

            public CommandMessageEnum()
            {

            }

            public CommandMessageEnum(string value)
            {
                _value = value;
            }

            public static CommandMessageEnum FromValue(string value)
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

                if (this.Equals(obj as CommandMessageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CommandMessageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CommandMessageEnum a, CommandMessageEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(CommandMessageEnum a, CommandMessageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 命令类型。 * SUBMITVERIFYING: 提交审核 * CONFIRM_ACCEPT：用户确认训练效果 * CONFIRM_REJECT：用户驳回训练效果 * CONFIRM_ANSWER：用户答复 * CONFIRM_PENDING：用户挂起任务 * CONFIRM_ACTIVE：用户激活任务 * GET_MULTIPART_UPLOADED：获取训练视频已上传分片信息 * CONFIRM_REPAIR:用户发起优化模型请求 * CONFIRM_MULTIPART_UPLOADED：确认训练视频所有分片文件已上传 * GET_ACTION_VIDEO_MULTIPART_UPLOADED：获取动作编排视频分片上传地址 * CONFIRM_ACTION_VIDEO_MULTIPART_UPLOADED：确认动作编排视频所有分片文件已上传 &gt; * CONFIRM_ACCEPT、CONFIRM_REJECT、CONFIRM_ANSWER、CONFIRM_PENDING、CONFIRM_ACTIVE命令仅NA白名单用户可用。
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public CommandEnum Command { get; set; }
        /// <summary>
        /// 命令类型： * UPDATE_VIDEO: 更新视频 * UPLOAD_VIDEO: 上传视频 * CONFIRM_ACTION_VIDEO: 确认动作编排视频 * GET_ACTION_VIDEO_MULTIPART: 获取动作编排视频分片
        /// </summary>
        [JsonProperty("command_message", NullValueHandling = NullValueHandling.Ignore)]
        public CommandMessageEnum CommandMessage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("comment_data", NullValueHandling = NullValueHandling.Ignore)]
        public CommentData CommentData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Execute2dModelTrainingCommandByUserReq {\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  commandMessage: ").Append(CommandMessage).Append("\n");
            sb.Append("  commentData: ").Append(CommentData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Execute2dModelTrainingCommandByUserReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Execute2dModelTrainingCommandByUserReq input)
        {
            if (input == null) return false;
            if (this.Command != input.Command) return false;
            if (this.CommandMessage != input.CommandMessage) return false;
            if (this.CommentData != input.CommentData || (this.CommentData != null && !this.CommentData.Equals(input.CommentData))) return false;

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
                hashCode = hashCode * 59 + this.Command.GetHashCode();
                hashCode = hashCode * 59 + this.CommandMessage.GetHashCode();
                if (this.CommentData != null) hashCode = hashCode * 59 + this.CommentData.GetHashCode();
                return hashCode;
            }
        }
    }
}
