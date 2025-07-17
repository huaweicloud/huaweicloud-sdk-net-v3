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
    /// 会议状态。 - schedule:预定状态 - created:会议已经被创建并正在召开 - destroyed:会议已经关闭 
    /// </summary>
    /// <value>会议状态。 - schedule:预定状态 - created:会议已经被创建并正在召开 - destroyed:会议已经关闭 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MeetingStatus
    {
        /// <summary>
        /// Enum SCHEDULE for value: schedule
        /// </summary>
        [EnumMember(Value = "schedule")]
        SCHEDULE = 1,

        /// <summary>
        /// Enum CREATED for value: created
        /// </summary>
        [EnumMember(Value = "created")]
        CREATED = 2,

        /// <summary>
        /// Enum DESTROYED for value: destroyed
        /// </summary>
        [EnumMember(Value = "destroyed")]
        DESTROYED = 3

    }

}
