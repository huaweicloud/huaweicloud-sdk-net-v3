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
    /// 平台对接类型。 * MEITUAN_OFFICIAL：对接美团直播平台官方接口 * MSS_STANDARD：对接MetaStudio定义的标准接口
    /// </summary>
    /// <value>平台对接类型。 * MEITUAN_OFFICIAL：对接美团直播平台官方接口 * MSS_STANDARD：对接MetaStudio定义的标准接口</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AccessTypeEnum
    {
        /// <summary>
        /// Enum MEITUAN_OFFICIAL for value: MEITUAN_OFFICIAL
        /// </summary>
        [EnumMember(Value = "MEITUAN_OFFICIAL")]
        MEITUAN_OFFICIAL = 1,

        /// <summary>
        /// Enum MSS_STANDARD for value: MSS_STANDARD
        /// </summary>
        [EnumMember(Value = "MSS_STANDARD")]
        MSS_STANDARD = 2

    }

}
