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
    /// 对接的ASR厂商类型 * EI_SIS:华为云SIS（仅国内站点支持） * MOBVOI:出门问问（仅海外站点支持）
    /// </summary>
    /// <value>对接的ASR厂商类型 * EI_SIS:华为云SIS（仅国内站点支持） * MOBVOI:出门问问（仅海外站点支持）</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AsrTypeEnum
    {
        /// <summary>
        /// Enum EI_SIS for value: EI_SIS
        /// </summary>
        [EnumMember(Value = "EI_SIS")]
        EI_SIS = 1,

        /// <summary>
        /// Enum MOBVOI for value: MOBVOI
        /// </summary>
        [EnumMember(Value = "MOBVOI")]
        MOBVOI = 2

    }

}
