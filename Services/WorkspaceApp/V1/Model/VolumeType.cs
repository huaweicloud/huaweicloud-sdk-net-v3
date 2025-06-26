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
    /// 磁盘类型，获取可用磁盘类型详见接口磁盘管理ListVolumeType。 * &#x60;ESSD&#x60; - 极速型SSD * &#x60;SSD&#x60; - 超高IO * &#x60;GPSSD&#x60; - 通用型SSD * &#x60;SAS&#x60; - 高IO * &#x60;SATA&#x60; - 普通IO
    /// </summary>
    /// <value>磁盘类型，获取可用磁盘类型详见接口磁盘管理ListVolumeType。 * &#x60;ESSD&#x60; - 极速型SSD * &#x60;SSD&#x60; - 超高IO * &#x60;GPSSD&#x60; - 通用型SSD * &#x60;SAS&#x60; - 高IO * &#x60;SATA&#x60; - 普通IO</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum VolumeType
    {
        /// <summary>
        /// Enum ESSD for value: ESSD
        /// </summary>
        [EnumMember(Value = "ESSD")]
        ESSD = 1,

        /// <summary>
        /// Enum SSD for value: SSD
        /// </summary>
        [EnumMember(Value = "SSD")]
        SSD = 2,

        /// <summary>
        /// Enum GPSSD for value: GPSSD
        /// </summary>
        [EnumMember(Value = "GPSSD")]
        GPSSD = 3,

        /// <summary>
        /// Enum SAS for value: SAS
        /// </summary>
        [EnumMember(Value = "SAS")]
        SAS = 4,

        /// <summary>
        /// Enum SATA for value: SATA
        /// </summary>
        [EnumMember(Value = "SATA")]
        SATA = 5

    }

}
