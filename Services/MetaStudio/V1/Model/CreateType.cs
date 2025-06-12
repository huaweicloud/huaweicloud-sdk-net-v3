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
    /// 任务创建方式。 * PACKAGE: 使用一个zip包包含所有数据 * SEGMENT: 逐句上传数据
    /// </summary>
    /// <value>任务创建方式。 * PACKAGE: 使用一个zip包包含所有数据 * SEGMENT: 逐句上传数据</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CreateType
    {
        /// <summary>
        /// Enum PACKAGE for value: PACKAGE
        /// </summary>
        [EnumMember(Value = "PACKAGE")]
        PACKAGE = 1,

        /// <summary>
        /// Enum SEGMENT for value: SEGMENT
        /// </summary>
        [EnumMember(Value = "SEGMENT")]
        SEGMENT = 2

    }

}
