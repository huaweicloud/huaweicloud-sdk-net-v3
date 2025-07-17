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
    /// 热词表类型。 &gt; MOBVOI:使用的语音识别服务为MOBVOI时选择此类型
    /// </summary>
    /// <value>热词表类型。 &gt; MOBVOI:使用的语音识别服务为MOBVOI时选择此类型</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AsrVocabularyTypeEnum
    {
        /// <summary>
        /// Enum MOBVOI for value: MOBVOI
        /// </summary>
        [EnumMember(Value = "MOBVOI")]
        MOBVOI = 1

    }

}
