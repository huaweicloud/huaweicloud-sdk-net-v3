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
    /// 短任务类型。 * VOICE_ASSESS: 声音质量检测
    /// </summary>
    /// <value>短任务类型。 * VOICE_ASSESS: 声音质量检测</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShortJobType
    {
        /// <summary>
        /// Enum VOICE_ASSESS for value: VOICE_ASSESS
        /// </summary>
        [EnumMember(Value = "VOICE_ASSESS")]
        VOICE_ASSESS = 1

    }

}
