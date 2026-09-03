using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 上传状态枚举。
    /// </summary>
    /// <value>上传状态枚举。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UploadStatusEnum
    {
        /// <summary>
        /// Enum UPLOADING for value: UPLOADING
        /// </summary>
        [EnumMember(Value = "UPLOADING")]
        UPLOADING = 1,

        /// <summary>
        /// Enum UPLOADED for value: UPLOADED
        /// </summary>
        [EnumMember(Value = "UPLOADED")]
        UPLOADED = 2,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 3

    }

}
