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
    /// 热词类型。 &gt; SIS:使用的语音识别服务为SIS时选此类型 &gt; MOBVOI:使用的语音识别服务为MOBVOI时选择此类型
    /// </summary>
    /// <value>热词类型。 &gt; SIS:使用的语音识别服务为SIS时选此类型 &gt; MOBVOI:使用的语音识别服务为MOBVOI时选择此类型</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum HotWordsTypeEnum
    {
        /// <summary>
        /// Enum SIS for value: SIS
        /// </summary>
        [EnumMember(Value = "SIS")]
        SIS = 1,

        /// <summary>
        /// Enum MOBVOI for value: MOBVOI
        /// </summary>
        [EnumMember(Value = "MOBVOI")]
        MOBVOI = 2

    }

}
