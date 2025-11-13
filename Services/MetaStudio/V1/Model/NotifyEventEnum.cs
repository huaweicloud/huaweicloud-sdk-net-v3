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
    /// * AUDIT_TEXT：直播在非人工退出场景（如最大时长中断，网络异常中断，欠费中断）中断。
    /// </summary>
    /// <value>* AUDIT_TEXT：直播在非人工退出场景（如最大时长中断，网络异常中断，欠费中断）中断。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum NotifyEventEnum
    {
        /// <summary>
        /// Enum AUTO_EXIT for value: AUTO_EXIT
        /// </summary>
        [EnumMember(Value = "AUTO_EXIT")]
        AUTO_EXIT = 1

    }

}
