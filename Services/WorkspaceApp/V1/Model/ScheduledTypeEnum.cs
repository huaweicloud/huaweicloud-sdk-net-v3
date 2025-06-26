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
    /// 执行周期： * &#x60;FIXED_TIME&#x60; - 指定时间 * &#x60;DAY&#x60; - 按天 * &#x60;WEEK&#x60; - 按周 * &#x60;MONTH&#x60; - 按月
    /// </summary>
    /// <value>执行周期： * &#x60;FIXED_TIME&#x60; - 指定时间 * &#x60;DAY&#x60; - 按天 * &#x60;WEEK&#x60; - 按周 * &#x60;MONTH&#x60; - 按月</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ScheduledTypeEnum
    {
        /// <summary>
        /// Enum FIXED_TIME for value: FIXED_TIME
        /// </summary>
        [EnumMember(Value = "FIXED_TIME")]
        FIXED_TIME = 1,

        /// <summary>
        /// Enum DAY for value: DAY
        /// </summary>
        [EnumMember(Value = "DAY")]
        DAY = 2,

        /// <summary>
        /// Enum WEEK for value: WEEK
        /// </summary>
        [EnumMember(Value = "WEEK")]
        WEEK = 3,

        /// <summary>
        /// Enum MONTH for value: MONTH
        /// </summary>
        [EnumMember(Value = "MONTH")]
        MONTH = 4

    }

}
