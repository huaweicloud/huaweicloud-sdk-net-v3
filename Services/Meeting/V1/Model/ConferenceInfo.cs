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
    /// 会议信息。
    /// </summary>
    public class ConferenceInfo 
    {
        /// <summary>
        /// 与会者角色。 * chair ：主持人 * general ：来宾 * audience ： 观众 &gt; * 仅在查询会议详情时返回 &gt; * 返回查询者本身的角色 
        /// </summary>
        /// <value>与会者角色。 * chair ：主持人 * general ：来宾 * audience ： 观众 &gt; * 仅在查询会议详情时返回 &gt; * 返回查询者本身的角色 </value>
        [JsonConverter(typeof(EnumClassConverter<RoleEnum>))]
        public class RoleEnum
        {
            /// <summary>
            /// Enum CHAIR for value: chair
            /// </summary>
            public static readonly RoleEnum CHAIR = new RoleEnum("chair");

            /// <summary>
            /// Enum GENERAL for value: general
            /// </summary>
            public static readonly RoleEnum GENERAL = new RoleEnum("general");

            /// <summary>
            /// Enum AUDIENCE for value: audience
            /// </summary>
            public static readonly RoleEnum AUDIENCE = new RoleEnum("audience");

            private static readonly Dictionary<string, RoleEnum> StaticFields =
            new Dictionary<string, RoleEnum>()
            {
                { "chair", CHAIR },
                { "general", GENERAL },
                { "audience", AUDIENCE },
            };

            private string _value;

            public RoleEnum()
            {

            }

            public RoleEnum(string value)
            {
                _value = value;
            }

            public static RoleEnum FromValue(string value)
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

                if (this.Equals(obj as RoleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RoleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RoleEnum a, RoleEnum b)
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

            public static bool operator !=(RoleEnum a, RoleEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 会议类型模型。 * COMMON：MCU会议 * RTC：MMR会议 
        /// </summary>
        /// <value>会议类型模型。 * COMMON：MCU会议 * RTC：MMR会议 </value>
        [JsonConverter(typeof(EnumClassConverter<ConfModeEnum>))]
        public class ConfModeEnum
        {
            /// <summary>
            /// Enum COMMON for value: COMMON
            /// </summary>
            public static readonly ConfModeEnum COMMON = new ConfModeEnum("COMMON");

            /// <summary>
            /// Enum RTC for value: RTC
            /// </summary>
            public static readonly ConfModeEnum RTC = new ConfModeEnum("RTC");

            private static readonly Dictionary<string, ConfModeEnum> StaticFields =
            new Dictionary<string, ConfModeEnum>()
            {
                { "COMMON", COMMON },
                { "RTC", RTC },
            };

            private string _value;

            public ConfModeEnum()
            {

            }

            public ConfModeEnum(string value)
            {
                _value = value;
            }

            public static ConfModeEnum FromValue(string value)
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

                if (this.Equals(obj as ConfModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConfModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConfModeEnum a, ConfModeEnum b)
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

            public static bool operator !=(ConfModeEnum a, ConfModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 会议ID。
        /// </summary>
        [JsonProperty("conferenceID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceID { get; set; }

        /// <summary>
        /// 会议主题。
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 会议预约时添加的会议者数量。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 会议通知中会议时间的时区信息。时区信息，参考[[时区映射关系](https://support.huaweicloud.com/api-meeting/meeting_21_0110.html#ZH-CN_TOPIC_0212714472__table137407441463)](tag:hws)[[时区映射关系](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0110.html#ZH-CN_TOPIC_0212714472__table137407441463)](tag:hk)。
        /// </summary>
        [JsonProperty("timeZoneID", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZoneID { get; set; }

        /// <summary>
        /// 会议起始时间 (YYYY-MM-DD HH:MM )。
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 会议结束时间 (YYYY-MM-DD HH:MM )。
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 会议的媒体类型。 由1个或多个枚举String组成，多个枚举时，每个枚举值之间通过”,”逗号分隔。 - Voice: 语音 - Video: 标清视频 - HDVideo: 高清视频 - Data: 数据
        /// </summary>
        [JsonProperty("mediaTypes", NullValueHandling = NullValueHandling.Ignore)]
        public string MediaTypes { get; set; }

        /// <summary>
        /// 会议状态。 - Schedule: 预定状态 - Creating: 正在创建状态 - Created: 会议已经被创建，并正在召开 - Destroyed: 会议已经关闭
        /// </summary>
        [JsonProperty("conferenceState", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceState { get; set; }

        /// <summary>
        /// 会议通知短信或邮件的语言。默认中文。 * zh-CN：中文 * en-US：英文 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 会议接入的SIP号码。
        /// </summary>
        [JsonProperty("accessNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessNumber { get; set; }

        /// <summary>
        /// 会议密码。 &gt; * 创建会议时，返回主持人密码和来宾密码 &gt; * 主持人查询会议时，返回主持人密码和来宾密码来 &gt; * 宾查询会议时，返回来宾密码
        /// </summary>
        [JsonProperty("passwordEntry", NullValueHandling = NullValueHandling.Ignore)]
        public List<PasswordEntry> PasswordEntry { get; set; }

        /// <summary>
        /// 会议预订者的用户UUID。
        /// </summary>
        [JsonProperty("userUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string UserUUID { get; set; }

        /// <summary>
        /// 会议预订者名称。
        /// </summary>
        [JsonProperty("scheduserName", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduserName { get; set; }

        /// <summary>
        /// 会议类型。 - 0: 普通会议 - 2: 周期性会议
        /// </summary>
        [JsonProperty("conferenceType", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConferenceType { get; set; }

        /// <summary>
        /// 会议类型。 - FUTURE：将来开始的会议（创建时） - IMMEDIATELY：立即开始的会议（创建时） - CYCLE：周期会议
        /// </summary>
        [JsonProperty("confType", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cycleParams", NullValueHandling = NullValueHandling.Ignore)]
        public CycleParams CycleParams { get; set; }

        /// <summary>
        /// 是否入会自动静音。 - 0: 不自动静音 - 1: 自动静音
        /// </summary>
        [JsonProperty("isAutoMute", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoMute { get; set; }

        /// <summary>
        /// 是否自动开启云录制。 - 0: 不自动启动 - 1: 自动启动
        /// </summary>
        [JsonProperty("isAutoRecord", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoRecord { get; set; }

        /// <summary>
        /// 主持人会议链接地址。
        /// </summary>
        [JsonProperty("chairJoinUri", NullValueHandling = NullValueHandling.Ignore)]
        public string ChairJoinUri { get; set; }

        /// <summary>
        /// 普通与会者会议链接地址。
        /// </summary>
        [JsonProperty("guestJoinUri", NullValueHandling = NullValueHandling.Ignore)]
        public string GuestJoinUri { get; set; }

        /// <summary>
        /// 网络研讨会观众会议链接地址。
        /// </summary>
        [JsonProperty("audienceJoinUri", NullValueHandling = NullValueHandling.Ignore)]
        public string AudienceJoinUri { get; set; }

        /// <summary>
        /// 录播类型。 - 0: 禁用 - 1: 直播 - 2: 录播 - 3: 直播+录播
        /// </summary>
        [JsonProperty("recordType", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordType { get; set; }

        /// <summary>
        /// 辅流直播推流地址。
        /// </summary>
        [JsonProperty("auxAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string AuxAddress { get; set; }

        /// <summary>
        /// 主流直播推流地址。
        /// </summary>
        [JsonProperty("liveAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string LiveAddress { get; set; }

        /// <summary>
        /// 是否录制辅流。  - 0: 否  - 1: 是
        /// </summary>
        [JsonProperty("recordAuxStream", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordAuxStream { get; set; }

        /// <summary>
        /// 观看/下载录播的鉴权方式。  - 0: 可通过链接观看/下载  - 1: 企业用户可观看/下载  - 2: 与会者可观看/下载
        /// </summary>
        [JsonProperty("recordAuthType", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordAuthType { get; set; }

        /// <summary>
        /// 直播观看地址。
        /// </summary>
        [JsonProperty("liveUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string LiveUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("confConfigInfo", NullValueHandling = NullValueHandling.Ignore)]
        public RestConfConfigDTO ConfConfigInfo { get; set; }

        /// <summary>
        /// 是否使用云会议室或个人会议ID召开预约会议。 - 0: 不使用云会议室或个人会议ID - 1: 使用云会议室或个人会议ID
        /// </summary>
        [JsonProperty("vmrFlag", NullValueHandling = NullValueHandling.Ignore)]
        public int? VmrFlag { get; set; }

        /// <summary>
        /// 是否有会议录制文件。仅历史会议查询时返回。 - true: 有录制文件 - false: 没有录制文件
        /// </summary>
        [JsonProperty("isHasRecordFile", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHasRecordFile { get; set; }

        /// <summary>
        /// 云会议室会议ID或个人会议ID，如果vmrFlag为\&quot;1\&quot;，则该字段不为空。
        /// </summary>
        [JsonProperty("vmrConferenceID", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrConferenceID { get; set; }

        /// <summary>
        /// 会议的UUID。 &gt; * 只有创建立即开始的会议才返回UUID，如果是预约未来的会议，不会返回UUID &gt; * 可以通过[[查询历史会议列表](https://support.huaweicloud.com/api-meeting/meeting_21_0051.html)](tag:hws)[[查询历史会议列表](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0051.html)](tag:hk)获取历史会议的UUID 
        /// </summary>
        [JsonProperty("confUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUUID { get; set; }

        /// <summary>
        /// 被邀请的部分与会者信息。 &gt; * 只返回被邀请的前20条软终端与会者信息和前20条硬终端与会者信息 &gt; * 不返回会中主动加入的与会者信息 &gt; * “[[查询会议列表](https://support.huaweicloud.com/api-meeting/meeting_21_0017.html)](tag:hws)[[查询会议列表](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0017.html)](tag:hk)”和“[[查询会议详情](https://support.huaweicloud.com/api-meeting/meeting_21_0018.html)](tag:hws)[[查询会议详情](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0018.html)](tag:hk)”接口，返回预约会议时邀请的与会者和会中主持人邀请的与会者 &gt; * “[[查询在线会议列表](https://support.huaweicloud.com/api-meeting/meeting_21_0025.html)](tag:hws)[[查询在线会议列表](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0025.html)](tag:hk)”、“[[查询在线会议详情](https://support.huaweicloud.com/api-meeting/meeting_21_0026.html)](tag:hws)[[查询在线会议详情](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0026.html)](tag:hk)”、“[[查询历史会议列表](https://support.huaweicloud.com/api-meeting/meeting_21_0051.html)](tag:hws)[[查询历史会议列表](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0051.html)](tag:hk)”和“[[查询历史会议详情](https://support.huaweicloud.com/api-meeting/meeting_21_0052.html)](tag:hws)[[查询历史会议详情](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0052.html)](tag:hk)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       ”接口返回预约会议时邀请的与会者。不返回会中主持人邀请的与会者 
        /// </summary>
        [JsonProperty("partAttendeeInfo", NullValueHandling = NullValueHandling.Ignore)]
        public List<PartAttendee> PartAttendeeInfo { get; set; }

        /// <summary>
        /// 硬终端个数，如IdeaHub，TE30等。
        /// </summary>
        [JsonProperty("terminlCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TerminlCount { get; set; }

        /// <summary>
        /// 软终端个数，如PC端、手机端App等。
        /// </summary>
        [JsonProperty("normalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? NormalCount { get; set; }

        /// <summary>
        /// 会议预定者的企业名称。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 云会议室的ID。
        /// </summary>
        [JsonProperty("vmrID", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrID { get; set; }

        /// <summary>
        /// 与会者角色。 * chair ：主持人 * general ：来宾 * audience ： 观众 &gt; * 仅在查询会议详情时返回 &gt; * 返回查询者本身的角色 
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public RoleEnum Role { get; set; }
        /// <summary>
        /// 是否是网络研讨会。
        /// </summary>
        [JsonProperty("webinar", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Webinar { get; set; }

        /// <summary>
        /// 当前在线与会人数。包含被邀入会和主动入会的与会者。 &gt; 仅在“[[查询在线会议列表](https://support.huaweicloud.com/api-meeting/meeting_21_0025.html)](tag:hws)[[查询在线会议列表](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0025.html)](tag:hk)”接口中返回。 
        /// </summary>
        [JsonProperty("onlineAttendeeAmount", NullValueHandling = NullValueHandling.Ignore)]
        public int? OnlineAttendeeAmount { get; set; }

        /// <summary>
        /// 标识是否为多流视频会议。 * 1：多流会议 
        /// </summary>
        [JsonProperty("multiStreamFlag", NullValueHandling = NullValueHandling.Ignore)]
        public int? MultiStreamFlag { get; set; }

        /// <summary>
        /// 会议类型模型。 * COMMON：MCU会议 * RTC：MMR会议 
        /// </summary>
        [JsonProperty("confMode", NullValueHandling = NullValueHandling.Ignore)]
        public ConfModeEnum ConfMode { get; set; }
        /// <summary>
        /// VMR预约记录。 true: VMR预约记录 false：普通会议 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [JsonProperty("scheduleVmr", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScheduleVmr { get; set; }

        /// <summary>
        /// 会议最大与会人数。默认值0。 * 0：无限制 * 大于0：会议最大与会人数 
        /// </summary>
        [JsonProperty("concurrentParticipants", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConcurrentParticipants { get; set; }

        /// <summary>
        /// 会议是否支持同声传译。默认值false。 * true:支持 * false:不支持 
        /// </summary>
        [JsonProperty("supportSimultaneousInterpretation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportSimultaneousInterpretation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("picDisplay", NullValueHandling = NullValueHandling.Ignore)]
        public MultiPicDisplayDO PicDisplay { get; set; }

        /// <summary>
        /// 周期子会议列表。
        /// </summary>
        [JsonProperty("subConfs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CycleSubConf> SubConfs { get; set; }

        /// <summary>
        /// 第一个周期子会议的UUID。
        /// </summary>
        [JsonProperty("cycleSubConfID", NullValueHandling = NullValueHandling.Ignore)]
        public string CycleSubConfID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConferenceInfo {\n");
            sb.Append("  conferenceID: ").Append(ConferenceID).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  timeZoneID: ").Append(TimeZoneID).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  mediaTypes: ").Append(MediaTypes).Append("\n");
            sb.Append("  conferenceState: ").Append(ConferenceState).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  accessNumber: ").Append(AccessNumber).Append("\n");
            sb.Append("  passwordEntry: ").Append(PasswordEntry).Append("\n");
            sb.Append("  userUUID: ").Append(UserUUID).Append("\n");
            sb.Append("  scheduserName: ").Append(ScheduserName).Append("\n");
            sb.Append("  conferenceType: ").Append(ConferenceType).Append("\n");
            sb.Append("  confType: ").Append(ConfType).Append("\n");
            sb.Append("  cycleParams: ").Append(CycleParams).Append("\n");
            sb.Append("  isAutoMute: ").Append(IsAutoMute).Append("\n");
            sb.Append("  isAutoRecord: ").Append(IsAutoRecord).Append("\n");
            sb.Append("  chairJoinUri: ").Append(ChairJoinUri).Append("\n");
            sb.Append("  guestJoinUri: ").Append(GuestJoinUri).Append("\n");
            sb.Append("  audienceJoinUri: ").Append(AudienceJoinUri).Append("\n");
            sb.Append("  recordType: ").Append(RecordType).Append("\n");
            sb.Append("  auxAddress: ").Append(AuxAddress).Append("\n");
            sb.Append("  liveAddress: ").Append(LiveAddress).Append("\n");
            sb.Append("  recordAuxStream: ").Append(RecordAuxStream).Append("\n");
            sb.Append("  recordAuthType: ").Append(RecordAuthType).Append("\n");
            sb.Append("  liveUrl: ").Append(LiveUrl).Append("\n");
            sb.Append("  confConfigInfo: ").Append(ConfConfigInfo).Append("\n");
            sb.Append("  vmrFlag: ").Append(VmrFlag).Append("\n");
            sb.Append("  isHasRecordFile: ").Append(IsHasRecordFile).Append("\n");
            sb.Append("  vmrConferenceID: ").Append(VmrConferenceID).Append("\n");
            sb.Append("  confUUID: ").Append(ConfUUID).Append("\n");
            sb.Append("  partAttendeeInfo: ").Append(PartAttendeeInfo).Append("\n");
            sb.Append("  terminlCount: ").Append(TerminlCount).Append("\n");
            sb.Append("  normalCount: ").Append(NormalCount).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  vmrID: ").Append(VmrID).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  webinar: ").Append(Webinar).Append("\n");
            sb.Append("  onlineAttendeeAmount: ").Append(OnlineAttendeeAmount).Append("\n");
            sb.Append("  multiStreamFlag: ").Append(MultiStreamFlag).Append("\n");
            sb.Append("  confMode: ").Append(ConfMode).Append("\n");
            sb.Append("  scheduleVmr: ").Append(ScheduleVmr).Append("\n");
            sb.Append("  concurrentParticipants: ").Append(ConcurrentParticipants).Append("\n");
            sb.Append("  supportSimultaneousInterpretation: ").Append(SupportSimultaneousInterpretation).Append("\n");
            sb.Append("  picDisplay: ").Append(PicDisplay).Append("\n");
            sb.Append("  subConfs: ").Append(SubConfs).Append("\n");
            sb.Append("  cycleSubConfID: ").Append(CycleSubConfID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConferenceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConferenceInfo input)
        {
            if (input == null) return false;
            if (this.ConferenceID != input.ConferenceID || (this.ConferenceID != null && !this.ConferenceID.Equals(input.ConferenceID))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.TimeZoneID != input.TimeZoneID || (this.TimeZoneID != null && !this.TimeZoneID.Equals(input.TimeZoneID))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.MediaTypes != input.MediaTypes || (this.MediaTypes != null && !this.MediaTypes.Equals(input.MediaTypes))) return false;
            if (this.ConferenceState != input.ConferenceState || (this.ConferenceState != null && !this.ConferenceState.Equals(input.ConferenceState))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.AccessNumber != input.AccessNumber || (this.AccessNumber != null && !this.AccessNumber.Equals(input.AccessNumber))) return false;
            if (this.PasswordEntry != input.PasswordEntry || (this.PasswordEntry != null && input.PasswordEntry != null && !this.PasswordEntry.SequenceEqual(input.PasswordEntry))) return false;
            if (this.UserUUID != input.UserUUID || (this.UserUUID != null && !this.UserUUID.Equals(input.UserUUID))) return false;
            if (this.ScheduserName != input.ScheduserName || (this.ScheduserName != null && !this.ScheduserName.Equals(input.ScheduserName))) return false;
            if (this.ConferenceType != input.ConferenceType || (this.ConferenceType != null && !this.ConferenceType.Equals(input.ConferenceType))) return false;
            if (this.ConfType != input.ConfType || (this.ConfType != null && !this.ConfType.Equals(input.ConfType))) return false;
            if (this.CycleParams != input.CycleParams || (this.CycleParams != null && !this.CycleParams.Equals(input.CycleParams))) return false;
            if (this.IsAutoMute != input.IsAutoMute || (this.IsAutoMute != null && !this.IsAutoMute.Equals(input.IsAutoMute))) return false;
            if (this.IsAutoRecord != input.IsAutoRecord || (this.IsAutoRecord != null && !this.IsAutoRecord.Equals(input.IsAutoRecord))) return false;
            if (this.ChairJoinUri != input.ChairJoinUri || (this.ChairJoinUri != null && !this.ChairJoinUri.Equals(input.ChairJoinUri))) return false;
            if (this.GuestJoinUri != input.GuestJoinUri || (this.GuestJoinUri != null && !this.GuestJoinUri.Equals(input.GuestJoinUri))) return false;
            if (this.AudienceJoinUri != input.AudienceJoinUri || (this.AudienceJoinUri != null && !this.AudienceJoinUri.Equals(input.AudienceJoinUri))) return false;
            if (this.RecordType != input.RecordType || (this.RecordType != null && !this.RecordType.Equals(input.RecordType))) return false;
            if (this.AuxAddress != input.AuxAddress || (this.AuxAddress != null && !this.AuxAddress.Equals(input.AuxAddress))) return false;
            if (this.LiveAddress != input.LiveAddress || (this.LiveAddress != null && !this.LiveAddress.Equals(input.LiveAddress))) return false;
            if (this.RecordAuxStream != input.RecordAuxStream || (this.RecordAuxStream != null && !this.RecordAuxStream.Equals(input.RecordAuxStream))) return false;
            if (this.RecordAuthType != input.RecordAuthType || (this.RecordAuthType != null && !this.RecordAuthType.Equals(input.RecordAuthType))) return false;
            if (this.LiveUrl != input.LiveUrl || (this.LiveUrl != null && !this.LiveUrl.Equals(input.LiveUrl))) return false;
            if (this.ConfConfigInfo != input.ConfConfigInfo || (this.ConfConfigInfo != null && !this.ConfConfigInfo.Equals(input.ConfConfigInfo))) return false;
            if (this.VmrFlag != input.VmrFlag || (this.VmrFlag != null && !this.VmrFlag.Equals(input.VmrFlag))) return false;
            if (this.IsHasRecordFile != input.IsHasRecordFile || (this.IsHasRecordFile != null && !this.IsHasRecordFile.Equals(input.IsHasRecordFile))) return false;
            if (this.VmrConferenceID != input.VmrConferenceID || (this.VmrConferenceID != null && !this.VmrConferenceID.Equals(input.VmrConferenceID))) return false;
            if (this.ConfUUID != input.ConfUUID || (this.ConfUUID != null && !this.ConfUUID.Equals(input.ConfUUID))) return false;
            if (this.PartAttendeeInfo != input.PartAttendeeInfo || (this.PartAttendeeInfo != null && input.PartAttendeeInfo != null && !this.PartAttendeeInfo.SequenceEqual(input.PartAttendeeInfo))) return false;
            if (this.TerminlCount != input.TerminlCount || (this.TerminlCount != null && !this.TerminlCount.Equals(input.TerminlCount))) return false;
            if (this.NormalCount != input.NormalCount || (this.NormalCount != null && !this.NormalCount.Equals(input.NormalCount))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.VmrID != input.VmrID || (this.VmrID != null && !this.VmrID.Equals(input.VmrID))) return false;
            if (this.Role != input.Role) return false;
            if (this.Webinar != input.Webinar || (this.Webinar != null && !this.Webinar.Equals(input.Webinar))) return false;
            if (this.OnlineAttendeeAmount != input.OnlineAttendeeAmount || (this.OnlineAttendeeAmount != null && !this.OnlineAttendeeAmount.Equals(input.OnlineAttendeeAmount))) return false;
            if (this.MultiStreamFlag != input.MultiStreamFlag || (this.MultiStreamFlag != null && !this.MultiStreamFlag.Equals(input.MultiStreamFlag))) return false;
            if (this.ConfMode != input.ConfMode) return false;
            if (this.ScheduleVmr != input.ScheduleVmr || (this.ScheduleVmr != null && !this.ScheduleVmr.Equals(input.ScheduleVmr))) return false;
            if (this.ConcurrentParticipants != input.ConcurrentParticipants || (this.ConcurrentParticipants != null && !this.ConcurrentParticipants.Equals(input.ConcurrentParticipants))) return false;
            if (this.SupportSimultaneousInterpretation != input.SupportSimultaneousInterpretation || (this.SupportSimultaneousInterpretation != null && !this.SupportSimultaneousInterpretation.Equals(input.SupportSimultaneousInterpretation))) return false;
            if (this.PicDisplay != input.PicDisplay || (this.PicDisplay != null && !this.PicDisplay.Equals(input.PicDisplay))) return false;
            if (this.SubConfs != input.SubConfs || (this.SubConfs != null && input.SubConfs != null && !this.SubConfs.SequenceEqual(input.SubConfs))) return false;
            if (this.CycleSubConfID != input.CycleSubConfID || (this.CycleSubConfID != null && !this.CycleSubConfID.Equals(input.CycleSubConfID))) return false;

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
                if (this.ConferenceID != null) hashCode = hashCode * 59 + this.ConferenceID.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.TimeZoneID != null) hashCode = hashCode * 59 + this.TimeZoneID.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.MediaTypes != null) hashCode = hashCode * 59 + this.MediaTypes.GetHashCode();
                if (this.ConferenceState != null) hashCode = hashCode * 59 + this.ConferenceState.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.AccessNumber != null) hashCode = hashCode * 59 + this.AccessNumber.GetHashCode();
                if (this.PasswordEntry != null) hashCode = hashCode * 59 + this.PasswordEntry.GetHashCode();
                if (this.UserUUID != null) hashCode = hashCode * 59 + this.UserUUID.GetHashCode();
                if (this.ScheduserName != null) hashCode = hashCode * 59 + this.ScheduserName.GetHashCode();
                if (this.ConferenceType != null) hashCode = hashCode * 59 + this.ConferenceType.GetHashCode();
                if (this.ConfType != null) hashCode = hashCode * 59 + this.ConfType.GetHashCode();
                if (this.CycleParams != null) hashCode = hashCode * 59 + this.CycleParams.GetHashCode();
                if (this.IsAutoMute != null) hashCode = hashCode * 59 + this.IsAutoMute.GetHashCode();
                if (this.IsAutoRecord != null) hashCode = hashCode * 59 + this.IsAutoRecord.GetHashCode();
                if (this.ChairJoinUri != null) hashCode = hashCode * 59 + this.ChairJoinUri.GetHashCode();
                if (this.GuestJoinUri != null) hashCode = hashCode * 59 + this.GuestJoinUri.GetHashCode();
                if (this.AudienceJoinUri != null) hashCode = hashCode * 59 + this.AudienceJoinUri.GetHashCode();
                if (this.RecordType != null) hashCode = hashCode * 59 + this.RecordType.GetHashCode();
                if (this.AuxAddress != null) hashCode = hashCode * 59 + this.AuxAddress.GetHashCode();
                if (this.LiveAddress != null) hashCode = hashCode * 59 + this.LiveAddress.GetHashCode();
                if (this.RecordAuxStream != null) hashCode = hashCode * 59 + this.RecordAuxStream.GetHashCode();
                if (this.RecordAuthType != null) hashCode = hashCode * 59 + this.RecordAuthType.GetHashCode();
                if (this.LiveUrl != null) hashCode = hashCode * 59 + this.LiveUrl.GetHashCode();
                if (this.ConfConfigInfo != null) hashCode = hashCode * 59 + this.ConfConfigInfo.GetHashCode();
                if (this.VmrFlag != null) hashCode = hashCode * 59 + this.VmrFlag.GetHashCode();
                if (this.IsHasRecordFile != null) hashCode = hashCode * 59 + this.IsHasRecordFile.GetHashCode();
                if (this.VmrConferenceID != null) hashCode = hashCode * 59 + this.VmrConferenceID.GetHashCode();
                if (this.ConfUUID != null) hashCode = hashCode * 59 + this.ConfUUID.GetHashCode();
                if (this.PartAttendeeInfo != null) hashCode = hashCode * 59 + this.PartAttendeeInfo.GetHashCode();
                if (this.TerminlCount != null) hashCode = hashCode * 59 + this.TerminlCount.GetHashCode();
                if (this.NormalCount != null) hashCode = hashCode * 59 + this.NormalCount.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.VmrID != null) hashCode = hashCode * 59 + this.VmrID.GetHashCode();
                hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Webinar != null) hashCode = hashCode * 59 + this.Webinar.GetHashCode();
                if (this.OnlineAttendeeAmount != null) hashCode = hashCode * 59 + this.OnlineAttendeeAmount.GetHashCode();
                if (this.MultiStreamFlag != null) hashCode = hashCode * 59 + this.MultiStreamFlag.GetHashCode();
                hashCode = hashCode * 59 + this.ConfMode.GetHashCode();
                if (this.ScheduleVmr != null) hashCode = hashCode * 59 + this.ScheduleVmr.GetHashCode();
                if (this.ConcurrentParticipants != null) hashCode = hashCode * 59 + this.ConcurrentParticipants.GetHashCode();
                if (this.SupportSimultaneousInterpretation != null) hashCode = hashCode * 59 + this.SupportSimultaneousInterpretation.GetHashCode();
                if (this.PicDisplay != null) hashCode = hashCode * 59 + this.PicDisplay.GetHashCode();
                if (this.SubConfs != null) hashCode = hashCode * 59 + this.SubConfs.GetHashCode();
                if (this.CycleSubConfID != null) hashCode = hashCode * 59 + this.CycleSubConfID.GetHashCode();
                return hashCode;
            }
        }
    }
}
